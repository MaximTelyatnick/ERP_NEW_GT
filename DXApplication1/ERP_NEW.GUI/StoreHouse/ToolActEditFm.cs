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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class ToolActEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private Utils.Operation _operation;

        private BindingSource toolActBS = new BindingSource();
        private BindingSource toolAcMaterialsBS = new BindingSource();

        private List<ToolActMaterialsJournalDTO> toolActMaterialList;
        private List<ToolActMaterialsDTO> deleteActMaterialsList = new List<ToolActMaterialsDTO>();

        public ObjectBase Item
        {
            get { return toolActBS.Current as ObjectBase; }
            set
            {
                toolActBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public ToolActEditFm(Utils.Operation operation, ToolActsDTO toolActModel, List<ToolActMaterialsJournalDTO> toolActMaterialModelsList)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            _operation = operation;

            toolActMaterialList = toolActMaterialModelsList;

            toolActBS.DataSource = Item = toolActModel;
            toolAcMaterialsBS.DataSource = toolActMaterialList;
            toolMaterialGrid.DataSource = toolAcMaterialsBS;

            numberEdit.DataBindings.Add("EditValue", toolActBS, "ActNumber", true, DataSourceUpdateMode.OnPropertyChanged);

            dateEdit.DataBindings.Add("EditValue", toolActBS, "ActDate", true, DataSourceUpdateMode.OnPropertyChanged);

            responsiblePersonEdit.DataBindings.Add("EditValue", toolActBS, "ResponsiblePersonId", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonEdit.Properties.DataSource = employeesService.GetEmployeesWorking().ToList(); ;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();
                ((ToolActsDTO)Item).ActDate = DateTime.Now;
                ((ToolActsDTO)Item).ActNumber = "";
            }

            splashScreenManager.CloseWaitForm();

        }

        #region Method's                          

        public ToolActsDTO Return()
        {
            return ((ToolActsDTO)Item);
        }

        private void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            toolMaterialGridView.PostEditor();

            if (toolActMaterialList.Any(a => a.Quantity == 0 || a.Quantity == null))
            {
                MessageBox.Show("Не повністю введена інформація по кількості списання!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();

                if (deleteActMaterialsList.Count > 0)
                {
                    storeHouseService.ToolActMaterialRemoveRange(deleteActMaterialsList);
                }

                if (_operation == Utils.Operation.Add)
                {
                    ((ToolActsDTO)Item).Id = storeHouseService.ToolActsCreate(((ToolActsDTO)Item));

                    var saveSource = toolActMaterialList.Select(s => new ToolActMaterialsDTO()
                    {
                         InvoiceRequirementId = s.InvoiceRequirementId,
                         ToolActId = ((ToolActsDTO)Item).Id,
                         Quantity = s.Quantity
                    }).ToList();

                    storeHouseService.ToolActMaterialCreateRange(saveSource);


                    return true;
                }
                else
                {
                    storeHouseService.ToolActsUpdate((ToolActsDTO)Item);

                    var saveSource = toolActMaterialList.Select(s => { s.ToolActId = ((ToolActsDTO)Item).Id; return s; }).ToList();
                         
                    foreach (var item in saveSource)
                    {

                        ToolActMaterialsDTO newModel = new ToolActMaterialsDTO()
                        {
                            Id = item.Id,  
                            ToolActId = item.ToolActId,
                            InvoiceRequirementId = item.InvoiceRequirementId,
                            Quantity = item.Quantity
                        };

                        if (newModel.Id == 0)
                            storeHouseService.ToolActMaterialCreate(newModel);
                        else
                            storeHouseService.ToolActsMaterialUpdate(newModel);
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

        private void addInvoicerequirementMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ToolActMatarialsEditFm toolActMaterialsEditFm = new ToolActMatarialsEditFm())
            {
                if (toolActMaterialsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = toolActMaterialsEditFm.Return();

                    toolMaterialGridView.BeginDataUpdate();



                    toolActMaterialList.AddRange(returnList.Select(s => new ToolActMaterialsJournalDTO()
                    {
                        BalanceAccountNum = s.BalanceAccountNum,
                        InvoiceRequirementId = s.Id,
                        InvoiceRequirementDate = s.Date,
                        InvoiceRequirementNumber = s.Number,
                        Required_Quantity = s.RequiredQuantity,
                        OrderDate = s.OrderDate,
                        Nomenclature = s.Nomenclature,
                        NomenclatureName = s.NomenclatureName,
                        Receipt_Id = s.ReceiptId,
                        ReceiptNum = s.ReceiptNum,
                        UnitLocalName = s.UnitLocalName,
                        UnitPrice = s.UnitPrice,
                        ResponsiblePersonName = s.ResponsibleName,
                        Quantity = 0,
                        Selected= false
                    }));

                    toolAcMaterialsBS.DataSource = toolActMaterialList;
                    toolMaterialGrid.DataSource = toolAcMaterialsBS;

                    toolMaterialGridView.EndDataUpdate();

                }
            }
        }

        private void deleteInvoicerequirementMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            toolMaterialGridView.PostEditor();

            toolMaterialGridView.BeginDataUpdate();

            var checkItems = toolActMaterialList.Where(t => t.Selected && t.Id != 0).Select(s => new ToolActMaterialsDTO()
                {
                    Id = s.Id,
                    InvoiceRequirementId = s.InvoiceRequirementId,
                    ToolActId = s.ToolActId,
                    
                });

            deleteActMaterialsList.AddRange(checkItems);
            toolActMaterialList.RemoveAll(s => s.Selected);

            toolAcMaterialsBS.DataSource = toolActMaterialList;
            toolMaterialGrid.DataSource = toolAcMaterialsBS;

            toolMaterialGridView.EndDataUpdate();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При береженні заявки виникла помилка. " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return toolActsValidationProvider.Validate();
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            toolActsValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            toolActsValidationProvider.Validate((Control)sender);
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            toolActsValidationProvider.Validate((Control)sender);
        }

        private void toolActsValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void toolActsValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (toolActsValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

        private void toolMaterialGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "quantityCol")
            {
                int cellValue = Convert.ToInt16(toolMaterialGridView.GetRowCellValue(e.RowHandle, quantityCol));

                if (cellValue > 0)
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.PaleGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
            }
        }

        
        
    }
}