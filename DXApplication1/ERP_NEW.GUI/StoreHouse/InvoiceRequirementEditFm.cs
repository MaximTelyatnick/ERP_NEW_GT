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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class InvoiceRequirementEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private BindingSource invoiceRequirementOrdersBS = new BindingSource();
        private BindingSource invoiceRequirementMaterialsBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();

        private Utils.Operation operation;
        private UserTasksDTO userTasksDTO;

        private List<InvoiceRequirementMaterialsInfoDTO> invoiceRequirementMaterialsList;
        private List<InvoiceRequirementMaterialsDTO> deleteMaterialsList = new List<InvoiceRequirementMaterialsDTO>();
        
        private ObjectBase Item
        {
            get { return invoiceRequirementOrdersBS.Current as ObjectBase; }
            set
            {
                invoiceRequirementOrdersBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public InvoiceRequirementEditFm(Utils.Operation operation,Utils.InvoiceType invoiceType, UserTasksDTO userTasksDTO, InvoiceRequirementOrdersDTO model, List<InvoiceRequirementMaterialsInfoDTO> invoiceRequirementMaterialsInfo)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;
            this.userTasksDTO = userTasksDTO;

            invoiceRequirementOrdersBS.DataSource = Item = model;

            invoiceRequirementMaterialsList = invoiceRequirementMaterialsInfo;
            invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
            invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;

            numberEdit.DataBindings.Add("EditValue", invoiceRequirementOrdersBS, "Number", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue", invoiceRequirementOrdersBS, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            typeCheckEdit.DataBindings.Add("Checked", invoiceRequirementOrdersBS, "Type", true, DataSourceUpdateMode.OnPropertyChanged);

            employeesService = Program.kernel.Get<IEmployeesService>();
            responsiblePersonEdit.DataBindings.Add("EditValue", invoiceRequirementOrdersBS, "Responsible_Person_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonBS.DataSource = employeesService.GetEmployeesWorking().ToList();
            responsiblePersonEdit.Properties.DataSource = responsiblePersonBS;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();
                ((InvoiceRequirementOrdersDTO)Item).Date = DateTime.Now;
                ((InvoiceRequirementOrdersDTO)Item).Number = "";
            }
            else
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();
            }

            ControlValidation();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's
                                
        public InvoiceRequirementOrdersDTO Return()
        {
            return ((InvoiceRequirementOrdersDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            invoiceRequirementMaterialGridView.PostEditor();

            try
            {
                storeHouseService = Program.kernel.Get<IStoreHouseService>();

                if (deleteMaterialsList.Count > 0)
                {
                    storeHouseService.InvoiceRequirementMaterialRemoveRange(deleteMaterialsList);
                }

                if (operation == Utils.Operation.Add)
                {
                    //((InvoiceRequirementOrdersDTO)Item).Id = storeHouseService.InvoiceRequirementOrderCreate((InvoiceRequirementOrdersDTO)Item);

                    //.Where(t => t.Selection && t.Id != 0)

                    ((InvoiceRequirementOrdersDTO)Item).Id = storeHouseService.InvoiceRequirementCreateDirect((InvoiceRequirementOrdersDTO)Item);

                    var saveSource = invoiceRequirementMaterialsList.Select(s => new InvoiceRequirementMaterialsDTO()
                    {

                        Credit_Account_Id = s.CreditAccountId,
                        Description = s.Description,
                        Expenditures_Id = s.ExpendituresId,
                        FixedAssets_Id = s.FixedAssetsId,
                        Invoice_Requirement_Order_Id = ((InvoiceRequirementOrdersDTO)Item).Id,
                        Receipt_Id = s.ReceiptId,
                        Required_Quantity = s.RequiredQuantity ?? 0

                    }).ToList();
                    
                    storeHouseService.InvoiceRequirementMaterialCreateRange(saveSource);

                    return true;
                }
                else
                {
                    storeHouseService.InvoiceRequirementOrderUpdate((InvoiceRequirementOrdersDTO)Item);

                    var saveSource = invoiceRequirementMaterialsList.Select(s => { s.InvoiceRequirementOrderId = ((InvoiceRequirementOrdersDTO)Item).Id; return s; }).ToList();

                    foreach (var item in saveSource)
                    {
                        
                        InvoiceRequirementMaterialsDTO newModel = new InvoiceRequirementMaterialsDTO()
                        {
                            Id = item.Id, 
                            Credit_Account_Id = item.CreditAccountId,
                            Description = item.Description,
                            Expenditures_Id = item.ExpendituresId,
                            FixedAssets_Id = item.FixedAssetsId,
                            Invoice_Requirement_Order_Id = item.InvoiceRequirementOrderId,
                            Receipt_Id = item.ReceiptId,
                            Required_Quantity = item.RequiredQuantity ?? 0
                        };

                        if (newModel.Id == 0)    
                            storeHouseService.InvoiceRequirementMaterialCreate(newModel);         
                        else
                            storeHouseService.InvoiceRequirementMaterialUpdate(newModel);
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
            using (InvoiceRequirementSelectedEditFm invoiceRequirementSelectedEditFm = new InvoiceRequirementSelectedEditFm())
            {
                if (invoiceRequirementSelectedEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnList = invoiceRequirementSelectedEditFm.Return();

                    invoiceRequirementMaterialGridView.BeginDataUpdate();

                    invoiceRequirementMaterialsList.AddRange(returnList.Select(s => new InvoiceRequirementMaterialsInfoDTO()
                    {
                        BalanceAccountNum = s.BalanceNum,
                        CreditAccountId = s.CreditAccountId,
                        UnitPrice = s.UnitPrice,
                        ExpendituresId = s.Id,
                        UnitLocalName = s.UnitLocalName,
                        ReceiptId = s.ReceiptId,
                        ReceiptNum = s.ReceiptNum,
                        Nomenclature = s.Nomenclature,
                        ExpenAccountNum = s.CreditAccount,
                        RequiredQuantity = s.Setkol,
                        ExpenQuantity = s.Setkol,
                        TotalPrice = s.Price,
                        NomenclatureName = s.Name
                    }));

                    invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
                    invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;

                    invoiceRequirementMaterialGridView.EndDataUpdate();
                    
                }
            }
        }

        private void deleteInvoicerequirementMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            invoiceRequirementMaterialGridView.PostEditor();

            invoiceRequirementMaterialGridView.BeginDataUpdate();

            var checkItems = invoiceRequirementMaterialsList.Where(t => t.Selection && t.Id != 0).Select(s => new InvoiceRequirementMaterialsDTO()
            {

                Id = s.Id,
                Credit_Account_Id = s.CreditAccountId ?? 0,
                Description = s.Description,
                Expenditures_Id = s.ExpendituresId ?? 0,
                FixedAssets_Id = s.FixedAssetsId ?? 0,
                Invoice_Requirement_Order_Id = s.InvoiceRequirementOrderId,
                Receipt_Id = s.ReceiptId,
                Required_Quantity = s.RequiredQuantity ?? 0

            });

            foreach (var item in checkItems)
            {
                if (item.Expenditures_Id != 0)
                {
                    invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
                    invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;
                    invoiceRequirementMaterialGridView.EndDataUpdate();

                    MessageBox.Show("Операцію відмінено. Матеріал знаходиться у списанні.\n", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            foreach (var item in checkItems)
            {
                if (storeHouseService.GetExpendituresStoreHousesMaterial(item.Receipt_Id).Count()>0)
                {
                    invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
                    invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;
                    invoiceRequirementMaterialGridView.EndDataUpdate();

                    MessageBox.Show("Операцію відмінено. Матеріал знаходиться у списанні комплектувальника.\n", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            deleteMaterialsList.AddRange(checkItems);
            invoiceRequirementMaterialsList.RemoveAll(s => s.Selection);

            invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
            invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;
            
            invoiceRequirementMaterialGridView.EndDataUpdate();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                addInvoicerequirementMaterialsFromRemainsBtn.Enabled = true;

                splashScreenManager.ShowWaitForm();

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
                    splashScreenManager.CloseWaitForm();
                }

                splashScreenManager.CloseWaitForm();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fixedAssetsRepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    using (InvoiceRequirementSelectFixedAssetsFm invoiceRequirementSelectFixedAssetsFm = new InvoiceRequirementSelectFixedAssetsFm())
                    {
                        if (invoiceRequirementSelectFixedAssetsFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            var returnModel = invoiceRequirementSelectFixedAssetsFm.Return();

                            invoiceRequirementMaterialGridView.BeginDataUpdate();

                            ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).InventoryNumber = returnModel.InventoryNumber;
                            ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).FixedAssetsId = returnModel.Id;
                            invoiceRequirementMaterialsBS.EndEdit();

                            invoiceRequirementMaterialGridView.EndDataUpdate();
                        }
                    }
                    break;
                case 1:
                    invoiceRequirementMaterialGridView.BeginDataUpdate();
                    ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).InventoryNumber = null;
                    ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).FixedAssetsId = null;
                    ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).Description = null;
                    invoiceRequirementMaterialsBS.EndEdit();
                    invoiceRequirementMaterialGridView.PostEditor();
                    invoiceRequirementMaterialGridView.EndDataUpdate();

                    break;
            }
        }
        #endregion

        #region Validation                              

        private bool ControlValidation()
        {
            return invoiceRequirementValidationProvider.Validate();
        }

        private void invoiceRequirementValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void invoiceRequirementValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (invoiceRequirementValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            invoiceRequirementValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            invoiceRequirementValidationProvider.Validate((Control)sender);
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            invoiceRequirementValidationProvider.Validate((Control)sender);
        }

        #endregion

        private void addInvoicerequirementMaterialsFromRemainsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (StoreHouseRemainForProjectFm storeHouseRemainForProjectFm = new StoreHouseRemainForProjectFm(userTasksDTO))
            //{
            //    if (storeHouseRemainForProjectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        var returnList = storeHouseRemainForProjectFm.Return();

            //        invoiceRequirementMaterialGridView.BeginDataUpdate();

            //        invoiceRequirementMaterialsList.AddRange(returnList.Select(s => new InvoiceRequirementMaterialsInfoDTO()
            //        {

            //            InvoiceRequirementOrderId = ((InvoiceRequirementOrdersDTO)Item).Id,
            //            ReceiptId = s.ReceiptId,
            //            ReceiptNum = s.ReceiptNum,
            //            RequiredQuantity = s.RemainsQuantity,
            //            CreditAccountId = null,
            //            ExpendituresId = null,
            //            FixedAssetsId = null,
            //            BalanceAccountNum = s.DebitNum,
            //            UnitPrice = s.UnitPrice,
            //            UnitLocalName = s.UnitLocalName,
            //            Nomenclature = s.Nomenclatures,
            //            TotalPrice = s.TotalPrice,
            //            NomenclatureName = s.Name,

            //        }));

            //        invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
            //        invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;

            //        invoiceRequirementMaterialGridView.EndDataUpdate();

            //    }
            //}

            //addInvoicerequirementMaterialsFromRemainsBtn.Enabled = false;
        }

        private void typeCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            addInvoicerequirementMaterialsFromRemainsBtn.Enabled = typeCheckEdit.Checked;
        }

       
    }
}