using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.OTK
{
    public partial class WeldAttestationEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;
        private IEmployeesService employeesService;

        private BindingSource weldAttestationsBS = new BindingSource();
        private BindingSource weldAttestationPersonsBS = new BindingSource();

        private List<WeldAttestationPersonsInfoDTO> personsList = new List<WeldAttestationPersonsInfoDTO>();
        private List<WeldAttestationPersonsDTO> deletePersonsList = new List<WeldAttestationPersonsDTO>();
        private List<EmployeesInfoDTO> empSource = new List<EmployeesInfoDTO>();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return weldAttestationsBS.Current as ObjectBase; }
            set
            {
                weldAttestationsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public WeldAttestationEditFm(Utils.Operation operation, WeldAttestationsDTO model, List<WeldAttestationPersonsInfoDTO> persons)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            _operation = operation;

            personsList = persons;

            weldAttestationsBS.DataSource = Item = model;
            weldAttestationPersonsBS.DataSource = personsList;
            personsGrid.DataSource = weldAttestationPersonsBS;

            attestationNumberEdit.DataBindings.Add("EditValue", weldAttestationsBS, "AttestationNumber");
            attestationDateEdit.DataBindings.Add("EditValue", weldAttestationsBS, "AttestationDate");
            responsiblePersonEdit.DataBindings.Add("EditValue", weldAttestationsBS, "ResponsiblePersonId");
            beginDateEdit.DataBindings.Add("EditValue", weldAttestationsBS, "BeginDate");
            endDateEdit.DataBindings.Add("EditValue", weldAttestationsBS, "EndDate");
            descriptionEdit.DataBindings.Add("EditValue", weldAttestationsBS, "Description");

            employeesService = Program.kernel.Get<IEmployeesService>();
            empSource = employeesService.GetEmployeesWorking().ToList();

            responsiblePersonEdit.Properties.DataSource = empSource;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
            {
                ((WeldAttestationsDTO)weldAttestationsBS.Current).AttestationDate = DateTime.Now;
                ((WeldAttestationsDTO)weldAttestationsBS.Current).BeginDate = DateTime.Now;
                ((WeldAttestationsDTO)weldAttestationsBS.Current).EndDate = DateTime.Now;
                ((WeldAttestationsDTO)weldAttestationsBS.Current).UserId = UserService.AuthorizatedUser.UserId;
            }
            
            ((WeldAttestationsDTO)weldAttestationsBS.Current).DateAdded = DateTime.Now;
            
            attestationValidationProvider.Validate();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's
        
        public int Return()
        {
            return ((WeldAttestationsDTO)Item).Id;
        }

        private bool FindDublicate(WeldAttestationsDTO model)
        {
            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            return weldStampsService.GetWeldAttestations().Any(s => s.AttestationNumber == model.AttestationNumber && s.Id != model.Id);
        }

        private bool SaveAttestation()
        {
            this.Item.EndEdit();
                       
            if (FindDublicate((WeldAttestationsDTO)this.Item))
            {
                MessageBox.Show("Протокол з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (weldAttestationPersonsBS.Count == 0)
            {
                MessageBox.Show("Необхідно додати працівників до протоколу!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            try
            {
                if (deletePersonsList.Count > 0)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();
                    weldStampsService.RemoveRangeWeldAttestationsPersons(deletePersonsList);
                }

                if (_operation == Utils.Operation.Add)
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    ((WeldAttestationsDTO)Item).Id = weldStampsService.CreateWeldAttestations((WeldAttestationsDTO)Item);

                    var source = (from p in personsList
                                  select new WeldAttestationPersonsDTO()
                                  {
                                      WeldAttestationId = ((WeldAttestationsDTO)Item).Id,
                                      EmployeeId = p.EmployeesID,
                                  }
                        ).ToList();

                    weldStampsService.CreateRangeWeldAttestationPersons(source);

                    return true;
                }
                else
                {
                    weldStampsService = Program.kernel.Get<IWeldStampsService>();

                    weldStampsService.UpdateWeldAttestations((WeldAttestationsDTO)Item);

                    var source = (from p in personsList
                                  select new WeldAttestationPersonsDTO()
                                  {
                                      Id = p.AttestationPersonId,
                                      WeldAttestationId = p.Id,
                                      EmployeeId = p.EmployeesID
                                  }
                        ).ToList();


                    foreach (var item in source)
                    {
                        if (item.Id == 0)
                            weldStampsService.CreateWeldAttestationPersons(item);
                        else
                            weldStampsService.UpdateWeldAttestationPersons(item);
                    }
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveAttestation())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        private void addPersonBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personsGridView.CloseEditor();

            var currPersonList = (from emp in empSource
                                  where !personsList.Any(p => p.EmployeesID == emp.EmployeeID)
                                  select new WeldAttestationPersonsInfoDTO()
                                  {
                                      EmployeesID = emp.EmployeeID,
                                      AccountNumber = (int)emp.AccountNumber,
                                      ProfessionName = emp.ProfessionName,
                                      EmployeesFio = emp.Fio,
                                      DepartmentName = emp.DepartmentName,
                                      Id = ((WeldAttestationsDTO)Item).Id,
                                      CheckForDelete = false
                                  }
                ).ToList();

            using (WeldAttestationPersonsFm weldAttestationPersonsFm = new WeldAttestationPersonsFm(currPersonList))
            {
                if (weldAttestationPersonsFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = weldAttestationPersonsFm.Return();
                    
                    personsGridView.BeginDataUpdate();

                    personsList.AddRange(returnList.Select(r => { r.CheckForDelete = false; return r; }));
                    weldAttestationPersonsBS.DataSource = personsList;
                    personsGrid.DataSource = weldAttestationPersonsBS;

                    personsGridView.EndDataUpdate();
                }
            }
        }

        private void deletePersonBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            personsGridView.CloseEditor();

            personsGridView.BeginDataUpdate();

            var checkItems = personsList.Where(s => s.CheckForDelete && s.AttestationPersonId != 0).Select(s => new WeldAttestationPersonsDTO()
            {
                Id = s.AttestationPersonId,
                EmployeeId = s.EmployeesID,
                WeldAttestationId = s.Id
            }).ToList();
            
            deletePersonsList.AddRange(checkItems);

            personsList.RemoveAll(s => s.CheckForDelete);

            weldAttestationPersonsBS.DataSource = personsList;
            personsGrid.DataSource = weldAttestationPersonsBS;

            personsGridView.EndDataUpdate();
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return attestationValidationProvider.Validate();
        }

        private void attestationValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void attestationValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (attestationValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void attestationNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            attestationValidationProvider.Validate((Control)sender);
        }

        private void attestationDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            attestationValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            attestationValidationProvider.Validate((Control)sender);
        }

        private void beginDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            attestationValidationProvider.Validate((Control)sender);
        }

        private void endDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            attestationValidationProvider.Validate((Control)sender);
        }

        #endregion
    }
}