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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using ERP_NEW.BLL.Services;
using System.IO;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsPrepaymentEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        private IPeriodService periodService;

        private BindingSource businessTripsBS = new BindingSource();

        private BindingSource employeesBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return businessTripsBS.Current as ObjectBase; }
            set
            {
                businessTripsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BusinessTripsPrepaymentEditFm(Utils.Operation operation, BusinessTripsPrepaymentDTO model, BusinessTripsPrepaymentJournalDTO currentModel)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            _operation = operation;

            LoadData();

            employeesBS.DataSource = currentModel;

            businessTripsBS.DataSource = Item = model;

            userInfoVGrid.DataSource = employeesBS;

            userFotoEdit.EditValue = PhotoSource(employeesService.GetPhotoById(currentModel.EmployeesID));

            prepaymentDateEdit.DataBindings.Add("EditValue", businessTripsBS, "Prepayment_Date");

            prepaymentCreditEdit.DataBindings.Add("EditValue", businessTripsBS, "Prepayment");

            balanceAccountEdit.DataBindings.Add("EditValue", businessTripsBS, "AccountsID", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceAccountEdit.Properties.DataSource = accountsService.GetAccounts();
            balanceAccountEdit.Properties.ValueMember = "Id";
            balanceAccountEdit.Properties.DisplayMember = "Num";
            balanceAccountEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {
                ((BusinessTripsPrepaymentDTO)Item).Prepayment_Date = DateTime.Now;
                ((BusinessTripsPrepaymentDTO)Item).EmployeesID = currentModel.EmployeesID;
                ((BusinessTripsPrepaymentDTO)Item).Selected = false;
                ((BusinessTripsPrepaymentDTO)Item).UserId = UserService.AuthorizatedUser.UserId;
                ((BusinessTripsPrepaymentDTO)Item).BusinessTripsDetailsID = currentModel.BusinessTripsDetailsID;       
            }

            ((BusinessTripsPrepaymentDTO)Item).Doc_Date = DateTime.Now;

            ControlValidation();
            splashScreenManager.CloseWaitForm();

        }

        #region Method's                           

        private void LoadData()
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
        }

        private byte[] PhotoSource(EmployeePhotoDTO source)
        {
            if (source.Photo == null || source.Photo.Length == 0)
            {
                MemoryStream ms = new MemoryStream();
                Image.FromFile("Images/happy-face.png").Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                source.Photo = ms.ToArray();
            }
            return source.Photo;
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            if (_operation == Utils.Operation.Add)
            {
                ((BusinessTripsPrepaymentDTO)Item).ID = businessTripsService.BusinessTripsPrepaymentCreate((BusinessTripsPrepaymentDTO)Item);

                return true;
            }
            else
            {
                businessTripsService.BusinessTripsPrepaymentUpdate((BusinessTripsPrepaymentDTO)Item);

                return true;
            }
        }

        public BusinessTripsPrepaymentDTO Return()
        {
            return ((BusinessTripsPrepaymentDTO)Item);
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBusinesTrip);
        }

        #endregion

        #region Event's                            

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (!CheckPeriodAccess(((BusinessTripsPrepaymentDTO)Item).Prepayment_Date))
                    {
                        MessageBox.Show("Період закритий або не існує!", "Редагування авансу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження інформації про аванс", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Validation                         

        private bool ControlValidation()
        {
            return businessTripsPrepaymentValidationProvider.Validate();
        }
        
        private void prepaymentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void prepaymentCreditEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void balanceAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void businessTripsPrepaymentValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void businessTripsPrepaymentValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (businessTripsPrepaymentValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion
    }
}