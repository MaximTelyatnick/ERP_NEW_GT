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
using ERP_NEW.GUI.Delivery;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.GUI.StoreHouse;

namespace ERP_NEW.GUI.Production
{
    public partial class ProductionInvoicesEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;

        private BindingSource invoiceRequirementOrdersBS = new BindingSource();
        private BindingSource invoiceRequirementMaterialsBS = new BindingSource();
        private BindingSource responsiblePersonBS = new BindingSource();

        private UserTasksDTO userTasksDTO = new UserTasksDTO();

        private Utils.Operation operation;

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

        public ProductionInvoicesEditFm(Utils.Operation operation, InvoiceRequirementOrdersDTO model, List<InvoiceRequirementMaterialsInfoDTO> invoiceRequirementMaterialsInfo, UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;
            this.userTasksDTO = userTasksDTO;
            invoiceRequirementMaterialsList = invoiceRequirementMaterialsInfo;

            invoiceRequirementOrdersBS.DataSource = Item = model;
            invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
            invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;

            numberEdit.DataBindings.Add("EditValue", invoiceRequirementOrdersBS, "Number");

            dateEdit.DataBindings.Add("EditValue", invoiceRequirementOrdersBS, "Date");

            employeesService = Program.kernel.Get<IEmployeesService>();

            responsiblePersonEdit.DataBindings.Add("EditValue", invoiceRequirementOrdersBS, "Responsible_Person_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            responsiblePersonBS.DataSource = employeesService.GetEmployeesWorking().ToList();
            responsiblePersonEdit.Properties.DataSource = responsiblePersonBS;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            if (operation == Utils.Operation.Add)
            {
                ((InvoiceRequirementOrdersDTO)Item).Date = DateTime.Now;
                ((InvoiceRequirementOrdersDTO)Item).Number = "";
            }

            AuthorizatedUserAccess();

            ControlValidation();

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            if (userTasksDTO.AccessRightId == 1)
            {
                addBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                deleteBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                numberEdit.ReadOnly = true;
                responsiblePersonEdit.ReadOnly = true;
                dateEdit.ReadOnly = true;
            }
            else if (userTasksDTO.AccessRightId == 2)
            {
                addBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                deleteBtn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                numberEdit.ReadOnly = false;
                responsiblePersonEdit.ReadOnly = false;
                dateEdit.ReadOnly = false;
            }
        }

        public InvoiceRequirementOrdersDTO Return()
        {
            return ((InvoiceRequirementOrdersDTO)Item);
        }

        private void customerOrderRepository_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    using (DeliveryOrdersCustomerOrderSelectFm deliveryOrdersCustomerOrderSelectFm = new DeliveryOrdersCustomerOrderSelectFm(new int[] { }, true))
                    {
                        if (deliveryOrdersCustomerOrderSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            var returnModel = deliveryOrdersCustomerOrderSelectFm.Return();

                            invoiceRequirementMaterialGridView.BeginDataUpdate();

                            ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).CustomerOrderExpId = returnModel[0].Id;
                            ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).CustomerOrderExp = returnModel[0].OrderNumber;
                            invoiceRequirementMaterialsBS.EndEdit();

                            invoiceRequirementMaterialGridView.EndDataUpdate();
                        }
                    }
                    break;
                case 1:
                    invoiceRequirementMaterialGridView.BeginDataUpdate();
                    ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).CustomerOrderExpId = null;
                    ((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).CustomerOrderExp = null;
                    invoiceRequirementMaterialsBS.EndEdit();
                    invoiceRequirementMaterialGridView.PostEditor();
                    invoiceRequirementMaterialGridView.EndDataUpdate();

                    break;
            }

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
                            //Credit_Account_Id = item.CreditAccountId,
                             Credit_Account_Id = null,
                            Description = item.Description,
                            //Expenditures_Id = item.ExpendituresId,
                             Expenditures_Id = null,
                            FixedAssets_Id = item.FixedAssetsId,
                            Invoice_Requirement_Order_Id = item.InvoiceRequirementOrderId,
                            Receipt_Id = item.ReceiptId,
                            Required_Quantity = item.RequiredQuantity ?? 0,
                             CustomerOrderId = item.CustomerOrderExpId
                            
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


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void editOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            invoiceRequirementMaterialGridView.PostEditor();

            invoiceRequirementMaterialGridView.BeginDataUpdate();


            var updateSource = invoiceRequirementMaterialsList.Where(s => s.Selection).ToList();
            var oldSource = invoiceRequirementMaterialsList.Where(s => !s.Selection).ToList();

            using (DeliveryOrdersCustomerOrderSelectFm deliveryOrdersCustomerOrderSelectFm = new DeliveryOrdersCustomerOrderSelectFm(new int[] { }, true))
            {
                if (deliveryOrdersCustomerOrderSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnModel = deliveryOrdersCustomerOrderSelectFm.Return();

                    //invoiceRequirementMaterialsList.Clear();


                    foreach (var oldItem in invoiceRequirementMaterialsList)
                    {
                        foreach (var newItem in updateSource)
                        {
                            if (oldItem.Id == newItem.Id)
                            {
                                oldItem.CustomerOrderExpId = returnModel[0].Id;
                                oldItem.CustomerOrderExp = returnModel[0].OrderNumber;
                            }

                        }

                        oldItem.Selection = false;
                    }

                    //invoiceRequirementMaterialsList.AddRange(updateSource);
                    //invoiceRequirementMaterialsList.AddRange(oldSource);

                    //invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList.OrderBy(sort => sort.ReceiptNum);

                    invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
                    invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;
                   
                    //((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).CustomerOrderExpId = returnModel[0].Id;
                    //((InvoiceRequirementMaterialsInfoDTO)invoiceRequirementMaterialsBS.Current).CustomerOrderExp = returnModel[0].OrderNumber;

                   
                }
            }

            invoiceRequirementMaterialGridView.EndDataUpdate();
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

            //foreach (var item in checkItems)
            //{
            //    if (item.Expenditures_Id != null)
            //    {
            //        invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
            //        invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;
            //        invoiceRequirementMaterialGridView.EndDataUpdate();

            //        MessageBox.Show("Операцію відмінено. Матеріал знаходиться у списанні.\n", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }

            //}


            deleteMaterialsList.AddRange(checkItems);
            invoiceRequirementMaterialsList.RemoveAll(s => s.Selection);

            invoiceRequirementMaterialsBS.DataSource = invoiceRequirementMaterialsList;
            invoiceRequirementMaterialsGrid.DataSource = invoiceRequirementMaterialsBS;

            invoiceRequirementMaterialGridView.EndDataUpdate();
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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


        #region Validation
        
       

        private bool ControlValidation()
        {
            return productionInvoicesValidationProvider.Validate();
        }

        private void productionInvoicesValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void productionInvoicesValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (productionInvoicesValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            productionInvoicesValidationProvider.Validate((Control)sender);
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            productionInvoicesValidationProvider.Validate((Control)sender);
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            productionInvoicesValidationProvider.Validate((Control)sender);
        }


        #endregion

    }
}