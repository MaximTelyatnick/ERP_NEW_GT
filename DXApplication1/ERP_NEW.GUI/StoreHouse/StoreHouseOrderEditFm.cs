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
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.GUI.Classifiers;
using FirebirdSql.Data.FirebirdClient;
using System.Threading;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseOrderEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;
        private IContractorsService contractorsService;
        private IAccountsService accountService;
        private IUnitsService unitsService;
        private IPeriodService periodService;
        private ICustomerOrdersService customerOrdersService;
        
        private BindingSource ordersBS = new BindingSource();
        private BindingSource receiptsBS = new BindingSource();
        private BindingSource suppliersBS = new BindingSource();
        private BindingSource otkPersonBS = new BindingSource();
        private BindingSource storekeepersBS = new BindingSource();
        private BindingSource contractorsBS = new BindingSource();
        private BindingSource accountDebitBS = new BindingSource();
        private BindingSource deliveryOrdersDetailsBS = new BindingSource();

        private Utils.Operation operation;

        private List<ReceiptsDTO> receiptsList = new List<ReceiptsDTO>();
        private List<ReceiptsDTO> deleteReceiptsList = new List<ReceiptsDTO>();

        private List<DeliveryOrdersDetailsDTO> deliveryOrdersDetailsList = new List<DeliveryOrdersDetailsDTO>();
        private List<DeliveryOrdersDetailsDTO> deleteDeliveryOrdersDetailsList = new List<DeliveryOrdersDetailsDTO>();

        private List<EmployeesInfoNonPhotoDTO> employeesList = new List<EmployeesInfoNonPhotoDTO>();
        private List<ContractorsDTO> contractorsList = new List<ContractorsDTO>();

        private UserTasksDTO userTaskDTO;

        private ObjectBase Item
        {
            get { return ordersBS.Current as ObjectBase; }
            set
            {
                ordersBS.DataSource = value;
                value.BeginEdit();
            }
        }
        
        public StoreHouseOrderEditFm(Utils.Operation operation, OrdersDTO model, List<ReceiptsDTO> source, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.userTaskDTO = userTaskDTO;

            this.operation = operation;

            receiptsList = source;

            ordersBS.DataSource = Item = model;
            receiptsList = source;
            receiptsBS.DataSource = receiptsList;
            receiptsGrid.DataSource = receiptsBS;

            deliveryOrdersDetailsBS.DataSource = deliveryOrdersDetailsList;
            ttnGrid.DataSource = deliveryOrdersDetailsBS;

            if (this.operation == Utils.Operation.Add)
            {
                ((OrdersDTO)Item).ORDER_DATE = DateTime.Now;
                ((OrdersDTO)Item).INVOICE_DATE = DateTime.Now;
                ((OrdersDTO)Item).TAX_INVOICE = 0;
                ((OrdersDTO)Item).DEBIT_ACCOUNT_ID = 15;

                storehouseEdit.EditValue = 1; //склад по умолчанию
                vatCheck.Checked = true;
                MaterialEdit();
     
            }
            else
            {
                if (model.Vat != null)
                    vatCheck.Checked = true;
                else
                    vatCheck.Checked = false;

                LoadDeliveryOrderDetails(model.ID);

                if (this.operation == Utils.Operation.Custom)
                {
                    invoiceDateEdit.Enabled = false;
                    orderDateEdit.Enabled = false;
                    receiptNumTBox.Enabled = false;
                    invoiceNumTBox.Enabled = false;
                    orderPriceTotalEdit.Enabled = false;
                    vatTBox.Enabled = false;
                    totalWithVatTBox.Enabled = false;
                    taxInvoiceCheckBox.Enabled = false;
                    transportInvoiceCheckBox.Enabled = false;
                    vendorEdit.Enabled = false;
                    suppliersEdit.Enabled = false;
                    otkPersonsEdit.Enabled = false;
                    storekeepersEdit.Enabled = false;
                    accountsEdit.Enabled = false;
                    vendorEdit.Enabled = false;
                    supplierProxyTBox.Enabled = false;
                    storehouseEdit.Enabled = false;

                    groupControl.Enabled = false;
                    ttnGroupControl.Enabled = false;

                }
            }

            employeesService = Program.kernel.Get<IEmployeesService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            accountService = Program.kernel.Get<IAccountsService>();
            unitsService = Program.kernel.Get<IUnitsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();


            #region Order binding

            invoiceDateEdit.DataBindings.Add("EditValue", ordersBS, "Invoice_Date", true, DataSourceUpdateMode.OnPropertyChanged);
            orderDateEdit.DataBindings.Add("EditValue", ordersBS, "Order_Date", true, DataSourceUpdateMode.OnPropertyChanged);
            receiptNumTBox.DataBindings.Add("EditValue", ordersBS, "Receipt_Num", true, DataSourceUpdateMode.OnPropertyChanged);
            invoiceNumTBox.DataBindings.Add("EditValue", ordersBS, "Invoice_Num", true, DataSourceUpdateMode.OnPropertyChanged);
            supplierProxyTBox.DataBindings.Add("EditValue", ordersBS, "Supplier_Proxy", true, DataSourceUpdateMode.OnPropertyChanged);
            orderPriceTotalEdit.DataBindings.Add("Text", ordersBS, "Total_Price", true, DataSourceUpdateMode.OnPropertyChanged, 0, "N", Utils.NumFormat(2));
            vatTBox.DataBindings.Add("Text", ordersBS, "Vat", true, DataSourceUpdateMode.OnPropertyChanged);
            totalWithVatTBox.DataBindings.Add("Text", ordersBS, "Total_With_Vat", true, DataSourceUpdateMode.OnPropertyChanged);
            taxInvoiceCheckBox.DataBindings.Add("Checked", ordersBS, "Tax_Invoice", true, DataSourceUpdateMode.OnPropertyChanged);
            transportInvoiceCheckBox.DataBindings.Add("Checked", ordersBS, "Transport_Invoice", true, DataSourceUpdateMode.OnPropertyChanged);

            vendorEdit.DataBindings.Add("EditValue", ordersBS, "Vendor_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            vendorEdit.Properties.DataSource = contractorsService.GetContractors(1);
            vendorEdit.Properties.ValueMember = "Id";
            vendorEdit.Properties.DisplayMember = "Name";
            vendorEdit.Properties.NullText = "Немає данних";

            employeesList = employeesService.GetEmployeesWorkingNonPhoto().ToList();

            suppliersEdit.DataBindings.Add("EditValue", ordersBS, "SupplierId", true, DataSourceUpdateMode.OnPropertyChanged);
            suppliersEdit.Properties.DataSource = employeesList;
            suppliersEdit.Properties.ValueMember = "EmployeeID";
            suppliersEdit.Properties.DisplayMember = "FullName";
            suppliersEdit.Properties.NullText = "Немає данних";

            otkPersonsEdit.DataBindings.Add("EditValue", ordersBS, "OtkId", true, DataSourceUpdateMode.OnPropertyChanged);
            otkPersonsEdit.Properties.DataSource = employeesList.Where(e => e.DepartmentID == 26).ToList();
            otkPersonsEdit.Properties.ValueMember = "EmployeeID";
            otkPersonsEdit.Properties.DisplayMember = "FullName";
            otkPersonsEdit.Properties.NullText = "Немає данних";

            storekeepersEdit.DataBindings.Add("EditValue", ordersBS, "StorekeeperId", true, DataSourceUpdateMode.OnPropertyChanged);
            storekeepersEdit.Properties.DataSource = employeesList.Where(e => (e.ProfessionID == 44 || e.ProfessionID == 46)).ToList();
            storekeepersEdit.Properties.ValueMember = "EmployeeID";
            storekeepersEdit.Properties.DisplayMember = "FullName";
            storekeepersEdit.Properties.NullText = "Немає данних";

            accountsEdit.DataBindings.Add("EditValue", ordersBS, "Debit_Account_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            accountsEdit.Properties.DataSource = accountService.GetAccounts().Where(bdsm => bdsm.Num == "631" || bdsm.Num == "372");
            accountsEdit.Properties.ValueMember = "Id";
            accountsEdit.Properties.DisplayMember = "Num";
            accountsEdit.Properties.NullText = "Немає данних";

            customerOrderEdit.DataBindings.Add("EditValue", ordersBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            customerOrderEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull();
            customerOrderEdit.Properties.ValueMember = "Id";
            customerOrderEdit.Properties.DisplayMember = "OrderNumber";
            customerOrderEdit.Properties.NullText = "Немає данних";

            #endregion

            #region Receipts


            //////storehouseEdit.DataBindings.Add("EditValue", receiptsBS, "Storehouse_Id",  true, DataSourceUpdateMode.OnPropertyChanged);
            //////storehouseEdit.Properties.DataSource = storeHouseService.GetAllStorehousesWithNumber();
            //////storehouseEdit.Properties.ValueMember = "Id";
            //////storehouseEdit.Properties.DisplayMember = "StoreHouseName";
            //////storehouseEdit.Properties.NullText = "Немає данних";

            //////measureEdit.DataBindings.Add("Text", receiptsBS, "UnitLocalName");

            //////nomenclatureEdit.DataBindings.Add("EditValue", receiptsBS, "Nomenclature",false, DataSourceUpdateMode.OnPropertyChanged);
            //////nomenclatureNameEdit.DataBindings.Add("EditValue", receiptsBS, "NomenclatureName", false, DataSourceUpdateMode.OnPropertyChanged);
            
            //////quantityEdit.DataBindings.Add("EditValue", receiptsBS, "QUANTITY");
            //////totalPriceEdit.DataBindings.Add("Text", receiptsBS, "TOTAL_PRICE");
            //////unitPriceEdit.DataBindings.Add("Text", receiptsBS, "UNIT_PRICE");

            storehouseEdit.DataBindings.Add("EditValue", receiptsBS, "Storehouse_Id");
            storehouseEdit.Properties.DataSource = storeHouseService.GetAllStorehousesWithNumber();
            storehouseEdit.Properties.ValueMember = "Id";
            storehouseEdit.Properties.DisplayMember = "StoreHouseName";
            storehouseEdit.Properties.NullText = "Немає данних";

            measureEdit.DataBindings.Add("Text", receiptsBS, "UnitLocalName");

            nomenclatureEdit.DataBindings.Add("EditValue", receiptsBS, "Nomenclature");
            nomenclatureNameEdit.DataBindings.Add("EditValue", receiptsBS, "NomenclatureName");

            quantityEdit.DataBindings.Add("EditValue", receiptsBS, "QUANTITY");
            totalPriceEdit.DataBindings.Add("Text", receiptsBS, "TOTAL_PRICE");
            unitPriceEdit.DataBindings.Add("Text", receiptsBS, "UNIT_PRICE");


	        #endregion

            CheckTransportInvoice();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's



        public OrdersDTO Return()
        {
            return ((OrdersDTO)Item);
        }

        public void MaterialEdit(bool flag = true)
        {
            nomenclatureEdit.ReadOnly = flag;
            nomenclatureNameEdit.ReadOnly = flag;
            measureEdit.ReadOnly = flag;
            quantityEdit.ReadOnly = flag;
            totalPriceEdit.ReadOnly = flag;
        }


        public void LoadDeliveryOrderDetails(long orderId)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            deliveryOrdersDetailsList = storeHouseService.GetDeliveryOrdersDetailsByOrderid(orderId).ToList();
            deliveryOrdersDetailsBS.DataSource = deliveryOrdersDetailsList;
            ttnGrid.DataSource = deliveryOrdersDetailsBS;

        }

        public void AddMaterial(short position)
        {
            if (storehouseEdit.EditValue == null || storehouseEdit.EditValue is System.DBNull)
            {
                MessageBox.Show("Не обрано склад. ", "Додавання надходження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 1;
            int indexOfCurrentRow;

            switch (position)
            {
                case 1:
                    receiptsGridView.BeginDataUpdate();

                    indexOfCurrentRow = receiptsList.Count == 0 ? 0 : (int)receiptsList.Max(min => min.POS);

                    MaterialEdit(false);

                    receiptsBS.Add(new ReceiptsDTO()
                    {
                        ID = 0,
                        POS = indexOfCurrentRow +1,
                        Storehouse_Id = (int)storehouseEdit.EditValue,
                        StoreHouseName = (string)storehouseEdit.Text
                    });

                    receiptsGridView.EndDataUpdate();

                    receiptsBS.MoveLast();

                    break;

                case 2:

                    ReceiptsDTO currentReceipt = ((ReceiptsDTO)receiptsBS.Current);

                    receiptsGridView.BeginDataUpdate();

                    indexOfCurrentRow = receiptsList.FindIndex(fi => fi.POS == ((ReceiptsDTO)receiptsBS.Current).POS);

                    MaterialEdit(false);

                    receiptsBS.Insert(indexOfCurrentRow, new ReceiptsDTO()
                    {
                        ID = 0,
                        POS = ((ReceiptsDTO)receiptsBS.Current).POS,
                        Storehouse_Id = (int)storehouseEdit.EditValue,
                        StoreHouseName = (string)storehouseEdit.Text
                    });

                    foreach (var item in receiptsBS)
                    {
                        ((ReceiptsDTO)item).POS = i;
                        ++i;
                    }

                    receiptsGridView.EndDataUpdate();

                    receiptsGridView.FocusedRowHandle = indexOfCurrentRow;

                    break;

                case 3:

                    receiptsGridView.BeginDataUpdate();

                    indexOfCurrentRow = receiptsList.FindIndex(fi => fi.POS == ((ReceiptsDTO)receiptsBS.Current).POS);

                    MaterialEdit(false);

                    if (indexOfCurrentRow == -1)
                    {
                        receiptsBS.Add(new ReceiptsDTO()
                        {
                            ID = 0,
                            POS = receiptsList.Max(min => min.POS) + 1,
                            Storehouse_Id = (int)storehouseEdit.EditValue,
                            StoreHouseName = (string)storehouseEdit.Text
                        });

                        receiptsGridView.EndDataUpdate();

                        receiptsGridView.FocusedRowHandle = indexOfCurrentRow;
                        break;
                    }
                    else
                    {

                        receiptsBS.Insert(indexOfCurrentRow, new ReceiptsDTO()
                        {
                            ID = 0,
                            POS = ((ReceiptsDTO)receiptsBS.Current).POS,
                            Storehouse_Id = (int)storehouseEdit.EditValue,
                            StoreHouseName = (string)storehouseEdit.Text
                        });

                        foreach (var item in receiptsBS)
                        {
                            ((ReceiptsDTO)item).POS = i;
                            ++i;
                        }

                        receiptsGridView.EndDataUpdate();

                        receiptsGridView.FocusedRowHandle = indexOfCurrentRow;

                        break;
                    }
                default:
                    break;
            }
        }
        
        #endregion

        #region Event's


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveOrder())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        


        private bool SaveOrder()
        {
            this.Item.EndEdit();

            if (receiptsBS.Count == 0)
            {
                MessageBox.Show("Необхідно додати матеріали!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!CheckReceiptNum())
            {
                MessageBox.Show("Такий номер надходження вжу існує", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (deliveryOrdersDetailsBS.Count == 0)
            {
                MessageBox.Show("До надходження не додано ТТН", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                if (operation == Utils.Operation.Add)
                {

                    storeHouseService = Program.kernel.Get<IStoreHouseService>();

                    //((OrdersDTO)Item).SUPPLIER_ID = ((OrdersDTO)Item).SUPPLIER_ID;
                    //((OrdersDTO)Item).Otk_Id = ((OrdersDTO)Item).Otk_Id;
                    //((OrdersDTO)Item).Storekeeper_Id = ((OrdersDTO)Item).Storekeeper_Id;

                    ((OrdersDTO)Item).ID = storeHouseService.OrderCreateDirect();
                    storeHouseService.VatCreateDirect(((OrdersDTO)Item).ID);

                    if (vatCheck.Checked)
                    {
                            storeHouseService.VatUpdate(new VatDTO()
                            {
                                ID = ((OrdersDTO)Item).ID,
                                PRICE = ((OrdersDTO)Item).Vat
                            });
                    }
                    else
                    {
                            storeHouseService.VatUpdate(new VatDTO()
                            {
                                ID = ((OrdersDTO)Item).ID,
                                PRICE = null
                            });
                    }

                    foreach (var item in receiptsBS)
                    {
                        ReceiptsDTO newModel = new ReceiptsDTO();

                        newModel.ORDER_ID = ((OrdersDTO)Item).ID;
                        newModel.QUANTITY = ((ReceiptsDTO)item).QUANTITY;
                        newModel.POS = ((ReceiptsDTO)item).POS;
                        newModel.Storehouse_Id = ((ReceiptsDTO)item).Storehouse_Id;
                        newModel.NOMENCLATURE_ID = ((ReceiptsDTO)item).NOMENCLATURE_ID;
                        newModel.TOTAL_PRICE = ((ReceiptsDTO)item).TOTAL_PRICE;

                        storeHouseService.ReceiptCreate(newModel);
                    }

                    foreach (var item in deliveryOrdersDetailsBS)
                    {
                        DeliveryOrdersDetailsDTO newModel = new DeliveryOrdersDetailsDTO();

                        newModel.OrderId = ((OrdersDTO)Item).ID;
                        newModel.DeliveryOrderId = ((DeliveryOrdersDetailsDTO)item).DeliveryOrderId;

                        storeHouseService.DeliveryOrdersDetailsCreate(newModel);
                    }

                    OrdersDTO updateOrderItem = new OrdersDTO()
                    {
                        ID = ((OrdersDTO)Item).ID,
                        RECEIPT_NUM = ((OrdersDTO)Item).RECEIPT_NUM,
                        VENDOR_ID = ((OrdersDTO)Item).VENDOR_ID,
                        INVOICE_NUM = ((OrdersDTO)Item).INVOICE_NUM,
                        SUPPLIER_ID = (short?)employeesList.First(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).SupplierId).SupplierId,
                        SupplierId = ((OrdersDTO)Item).SupplierId,
                        OtkId = ((OrdersDTO)Item).OtkId,
                        StorekeeperId = ((OrdersDTO)Item).StorekeeperId,
                        Otk_Id = (short?)employeesList.First(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).OtkId).SupplierId,
                        Storekeeper_Id = (short?)employeesList.First(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).StorekeeperId).SupplierId,
                        SUPPLIER_PROXY = ((OrdersDTO)Item).SUPPLIER_PROXY,
                        INVOICE_DATE = ((OrdersDTO)Item).INVOICE_DATE,
                        ORDER_DATE = ((OrdersDTO)Item).ORDER_DATE,
                        TOTAL_WITH_VAT = ((OrdersDTO)Item).TOTAL_WITH_VAT,
                        CHECKED = 0,
                        CORRECTION = 0,
                        Color_Id = 1,
                        CURRENCY_ID = 1,
                        DEBIT_ACCOUNT_ID = ((OrdersDTO)Item).DEBIT_ACCOUNT_ID,
                        TRANSPORT_INVOICE = ((OrdersDTO)Item).TRANSPORT_INVOICE,
                         TAX_INVOICE = ((OrdersDTO)Item).TAX_INVOICE,
                        UserId = userTaskDTO.UserId,
                         CURRENCY_RATE =0,
                          ENTER_DATE = DateTime.Now,
                        
                        Flag1 = 1,
                        Flag2 = 0,
                        Flag3 = 0,
                        Flag4 = 0
                    };

                    storeHouseService.OrderUpdate(updateOrderItem);

                }
                else
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();

                    OrdersDTO updateOrderItem = new OrdersDTO()
                    {
                        ID = ((OrdersDTO)Item).ID,
                        RECEIPT_NUM = ((OrdersDTO)Item).RECEIPT_NUM,
                        VENDOR_ID = ((OrdersDTO)Item).VENDOR_ID,
                        INVOICE_NUM = ((OrdersDTO)Item).INVOICE_NUM,
                        SUPPLIER_ID = (short?)employeesList.First(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).SupplierId).SupplierId,
                        SupplierId = ((OrdersDTO)Item).SupplierId,
                        OtkId = ((OrdersDTO)Item).OtkId,
                        StorekeeperId = ((OrdersDTO)Item).StorekeeperId,
                        Otk_Id = (short?)employeesList.First(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).OtkId).SupplierId,
                        Storekeeper_Id = (short?)employeesList.First(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).StorekeeperId).SupplierId,
                        SUPPLIER_PROXY = ((OrdersDTO)Item).SUPPLIER_PROXY,
                        INVOICE_DATE = ((OrdersDTO)Item).INVOICE_DATE,
                        ORDER_DATE = ((OrdersDTO)Item).ORDER_DATE,
                        TOTAL_WITH_VAT = ((OrdersDTO)Item).TOTAL_WITH_VAT,
                        CHECKED = 0,
                        CORRECTION = 0,
                        Color_Id = 1,
                        CURRENCY_ID = 1,
                        DEBIT_ACCOUNT_ID = ((OrdersDTO)Item).DEBIT_ACCOUNT_ID,
                        TRANSPORT_INVOICE = ((OrdersDTO)Item).TRANSPORT_INVOICE,
                        TAX_INVOICE = ((OrdersDTO)Item).TAX_INVOICE,
                        CURRENCY_RATE = ((OrdersDTO)Item).CURRENCY_RATE,
                        ENTER_DATE = ((OrdersDTO)Item).ENTER_DATE,
                         UserId = userTaskDTO.UserId,
                        Flag1 = 1,
                        Flag2 = 0,
                        Flag3 = 0,
                        Flag4 = 0
                    };

                    storeHouseService.OrderUpdate(updateOrderItem);

                    var checkItems = receiptsList.Where(t => t.Selected && t.ID != 0);


                    foreach (var item in receiptsList)
                    {
                        if (item.ID == 0)
                        {
                            ReceiptsDTO newModel = new ReceiptsDTO()
                            {
                                ORDER_ID = ((OrdersDTO)Item).ID,
                                QUANTITY = ((ReceiptsDTO)item).QUANTITY,
                                POS = ((ReceiptsDTO)item).POS,
                                Storehouse_Id = ((ReceiptsDTO)item).Storehouse_Id,
                                NOMENCLATURE_ID = ((ReceiptsDTO)item).NOMENCLATURE_ID,
                                TOTAL_PRICE = ((ReceiptsDTO)item).TOTAL_PRICE
                            };

                            storeHouseService.ReceiptCreate(newModel);

                        }
                        else
                        {
                            ReceiptsDTO updateModel = new ReceiptsDTO()
                            {

                                ID = ((ReceiptsDTO)item).ID,
                                ORDER_ID = ((OrdersDTO)Item).ID,
                                QUANTITY = ((ReceiptsDTO)item).QUANTITY,
                                POS = ((ReceiptsDTO)item).POS,
                                Storehouse_Id = ((ReceiptsDTO)item).Storehouse_Id,
                                NOMENCLATURE_ID = ((ReceiptsDTO)item).NOMENCLATURE_ID,
                                TOTAL_PRICE = ((ReceiptsDTO)item).TOTAL_PRICE
                            };

                            storeHouseService.ReceiptUpdate(updateModel);
                        }
                    }

                    var checkTTNItems = deliveryOrdersDetailsList.Where(t => t.Selected && t.Id != 0);


                    foreach (var item in deliveryOrdersDetailsList)
                    {
                        if (item.Id == 0)
                        {
                            DeliveryOrdersDetailsDTO newModel = new DeliveryOrdersDetailsDTO()
                            {

                                OrderId = ((OrdersDTO)Item).ID,
                                DeliveryOrderId = item.DeliveryOrderId
                            };

                            storeHouseService.DeliveryOrdersDetailsCreate(newModel);

                        }
                        else
                        {
                            DeliveryOrdersDetailsDTO updateModel = new DeliveryOrdersDetailsDTO()
                            {
                                 Id = item.Id,
                                OrderId = item.OrderId,
                                DeliveryOrderId = item.DeliveryOrderId
                            };

                            storeHouseService.DeliveryOrdersDetailsUpdate(updateModel);
                        }
                    }




                    if (deleteReceiptsList.Count > 0)
                    {
                        foreach (var item in deleteReceiptsList)
                        {
                            if (item.ID > 0)
                                storeHouseService.ReceiptDelete(item.ID);
                                    
                        }
                    }

                    if (deleteDeliveryOrdersDetailsList.Count > 0)
                    {
                        foreach (var item in deleteDeliveryOrdersDetailsList)
                        {
                            if (item.Id > 0)
                                storeHouseService.DeliveryOrdersDetailsDelete(item.Id);
                        }
                    }

                    if (vatCheck.Checked)
                    {
                        storeHouseService.VatUpdate(new VatDTO()
                        {
                            ID = ((OrdersDTO)Item).ID,
                            PRICE = ((OrdersDTO)Item).Vat
                        });
                    }
                    else
                    {
                        storeHouseService.VatUpdate(new VatDTO()
                        {
                            ID = ((OrdersDTO)Item).ID,
                            PRICE = null
                        });
                    }

                }




            }
            catch (Exception ex)
            {
                if(ex.HResult == -2146233087)
                    MessageBox.Show("Не можливо видалити матеріал. Матеріал знаходиться у списанні або у вимогах.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("При сбереженні виникла помилка: "+ ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        public  bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            //var fgfg = periodService.GetAllPeriods();

            bool result = periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);

            if (periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.State))
                return true;
            else if (!result)
            {
                if(MessageBox.Show("Данный период не добавлен! Добавить период?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InsertPeriod(currentDate);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void InsertPeriod(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            periodService.PeriodsCreate(new PeriodsDTO()
            {
                Month = currentDate.Month,
                State = true,
                Year = currentDate.Year,
                StateBank = false,
                StateBusinesTrip = false
            });
        }

        private bool CheckReceiptNum()
        {

            var orders = storeHouseService.GetOrdersByPeriod(new DateTime(((OrdersDTO)Item).ORDER_DATE.Value.Year, 1, 1), new DateTime(((OrdersDTO)Item).ORDER_DATE.Value.Year, 12, 31));

            string searchReceipt = ((OrdersDTO)Item).RECEIPT_NUM;

            if (!orders.Any(bdsm => bdsm.ReceiptNum == searchReceipt && bdsm.Id != ((OrdersDTO)Item).ID))
            {
                //MessageBox.Show("Вказаний номер приходу вже існує.", "Номер приходу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;

            //int n = (int)DataModule.ExecuteScalar
            //    (
            //        @"SELECT COUNT(Receipt_Num) FROM Orders WHERE Receipt_Num = @Receipt_Num AND EXTRACT(YEAR FROM Order_Date) = @Year AND ""Flag1"" = 1",
            //        Parameters
            //    );
            //DataModule.Connection.Close();
            //if ((n == 1 && _inserting) || (n == 1 && !_inserting && receiptNumTBox.Text != recNum))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }


        private void vatChk_CheckedChanged(object sender, EventArgs e)
        {
            if (vatCheck.Checked)
            {
                vatTBox.ReadOnly = false;
                totalWithVatTBox.ReadOnly = false;

               
                CalculateSum();
                
            }
            else
            {
                ((OrdersDTO)ordersBS.Current).Vat = null;
                ((OrdersDTO)ordersBS.Current).TOTAL_WITH_VAT = null;

                vatTBox.EditValue = null;
                totalWithVatTBox.EditValue = null;

                //vatTBox.DataBindings[0].ReadValue();
                //totalWithVatTBox.DataBindings[0].ReadValue();

                vatTBox.ReadOnly = true;
                totalWithVatTBox.ReadOnly = true;
            }
        }

        private void openNomenclaturejournalBtn_Click(object sender, EventArgs e)
        {
            using (NomenclaturesFm nomenclaturesFm = new NomenclaturesFm(userTaskDTO))
            {
                if (nomenclaturesFm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    DialogResult = DialogResult.None;  
            }
        }

        private void nomenclatureEdit_EditValueChanged(object sender, EventArgs e)
        {

        }


        

        //private void receiptsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{

        //}

        private void nomenclatureEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.OnlyNumbers(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(receiptsBS.Count > 0)
                    CheckNomenclature(nomenclatureEdit.Text.Trim());
                else
                    MessageBox.Show("Не додано жодного рядка. Спочатку додайте пустий рядок, перед его редагуванням!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Такого балансового счёта нет в базе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                //receiptsBS.EndEdit();
            }
        }

        private void CheckNomenclature(string Nomenclature)
        {

            
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            accountService = Program.kernel.Get<IAccountsService>();
            receiptsBS.EndEdit();
            //receiptsGridView.ro.DefaultCellStyle.BackColor = Color.White;

            List<NomenclaturesDTO> nomenclatureSearch = storeHouseService.GetNomenclatureWithAccountNumber(Nomenclature).ToList();

            if (nomenclatureSearch.Count != 0)
            {
                ((ReceiptsDTO)receiptsBS.Current).NomenclatureName = nomenclatureSearch[0].Name;
                ((ReceiptsDTO)receiptsBS.Current).UnitLocalName = nomenclatureSearch[0].UnitLocalName;
                ((ReceiptsDTO)receiptsBS.Current).UnitId = nomenclatureSearch[0].UnitId;
                ((ReceiptsDTO)receiptsBS.Current).BalanceAccountId = nomenclatureSearch[0].BALANCE_ACCOUNT_ID;
                ((ReceiptsDTO)receiptsBS.Current).BalanceAccountNum = nomenclatureSearch[0].Num;
                ((ReceiptsDTO)receiptsBS.Current).NomenclatureGroupId = nomenclatureSearch[0].Nomencl_Group_Id;
                ((ReceiptsDTO)receiptsBS.Current).NOMENCLATURE_ID = nomenclatureSearch[0].ID;

                nomenclatureNameEdit.EditValue = nomenclatureSearch[0].Name;
                measureEdit.EditValue = nomenclatureSearch[0].UnitLocalName;

                quantityEdit.Focus();

            }
            else
            {

                //MessageBox.Show("Номенклатура выдсутня в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DialogResult result = MessageBox.Show("Номенклатура выдсутня в базі даних!\n Створити?", "Не знайдено номенклатуру", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NomenclaturesDTO addNomenclature = new NomenclaturesDTO()
                    {
                        Nomenclature = Nomenclature
                    };

                    var balanceAccount = accountService.GetAccounts();

                    foreach (var item in balanceAccount)
                    {

                        string tempValue = item.Num.ToString().Replace("/", "");

                        if (Nomenclature.Length >= tempValue.Length && Nomenclature.IndexOf(tempValue, 0, tempValue.Length) != -1)
                        {
                            addNomenclature.BALANCE_ACCOUNT_ID = item.Id;
                            addNomenclature.Num = item.Num;

                            break;
                        }
                    }

                    if (addNomenclature.BALANCE_ACCOUNT_ID == null)
                    {
                        MessageBox.Show("Балансовий рахунок відсутній в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        nomenclatureNameEdit.EditValue = "";
                        measureEdit.EditValue = "";

                        return;
                    }

                    using (NomenclaturesMaterialsEditFm nomenclaturesMaterialsEditFm = new NomenclaturesMaterialsEditFm(Utils.Operation.Add, addNomenclature))
                    {
                        if (nomenclaturesMaterialsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            NomenclaturesDTO returnItem = nomenclaturesMaterialsEditFm.Return();

                            receiptsGridView.BeginDataUpdate();
                            //LoadOrdersDataByPeriod(_beginDate, _endDate);

                            ((ReceiptsDTO)receiptsBS.Current).NomenclatureName = returnItem.Name;
                            ((ReceiptsDTO)receiptsBS.Current).UnitLocalName = returnItem.UnitLocalName;
                            ((ReceiptsDTO)receiptsBS.Current).UnitId = returnItem.UnitId;
                            ((ReceiptsDTO)receiptsBS.Current).BalanceAccountId = returnItem.BALANCE_ACCOUNT_ID;
                            ((ReceiptsDTO)receiptsBS.Current).BalanceAccountNum = returnItem.Num;
                            ((ReceiptsDTO)receiptsBS.Current).NomenclatureGroupId = returnItem.Nomencl_Group_Id;
                            ((ReceiptsDTO)receiptsBS.Current).NOMENCLATURE_ID = returnItem.ID;

                            nomenclatureNameEdit.EditValue = returnItem.Name;
                            measureEdit.EditValue = returnItem.UnitLocalName;

                            receiptsGridView.EndDataUpdate();


                        }
                    }


                    //this.Close();

                }
                else
                {
                    this.Close(); 
                }

                //((ReceiptsDTO)receiptsBS.Current).NomenclatureName = "";
                //((ReceiptsDTO)receiptsBS.Current).UnitId = null;
                //((ReceiptsDTO)receiptsBS.Current).NomenclatureGroupId = 0;
                //((ReceiptsDTO)receiptsBS.Current).BalanceAccountId = null;
                //((ReceiptsDTO)receiptsBS.Current).BalanceAccountNum = "";

                //var balanceAccount = accountService.GetAccounts();


                //foreach (var item in balanceAccount)
                //{

                //    string tempValue = item.Num.ToString().Replace("/", "");

                //    if (Nomenclature.Length >= tempValue.Length && Nomenclature.IndexOf(tempValue, 0, tempValue.Length) != -1)
                //    {
                //        ((ReceiptsDTO)receiptsBS.Current).BalanceAccountId = item.Id;
                //        ((ReceiptsDTO)receiptsBS.Current).BalanceAccountNum = item.Num;
                //        ((ReceiptsDTO)receiptsBS.Current).InsertNomenclature = true;

                //        //materialGrid.CurrentRow.DefaultCellStyle.BackColor = Color.LightYellow;
                //        break;
                //    }
                //}

                //if (((ReceiptsDTO)receiptsBS.Current).BalanceAccountId == null)
                //{
                //    MessageBox.Show("Балансовий рахунок відсутній в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
            }

            DialogResult = DialogResult.None;

        }


        private void quantityEdit_TextChanged(object sender, EventArgs e)
        {
            UnitPrice();
        }



        private void UnitPrice()
        {
            //double Quantity = quantityTBox.Text.Length == 0 ? 0.000 : Convert.ToDouble(quantityTBox.Text);
            double Quantity = quantityEdit.Text.Length == 0 ? 0.000 : Convert.ToDouble(quantityEdit.Text);
            double TotalPrice = totalPriceEdit.Text.Length == 0 ? 0.00 : Convert.ToDouble(totalPriceEdit.Text);
            if (Quantity > 0 && TotalPrice > 0)
            {
                double UnitPrice = TotalPrice / Quantity;
                unitPriceEdit.Text = Math.Round(UnitPrice, 2).ToString("N", Utils.NumFormat(2));
            }
            else
            {
                unitPriceEdit.Text = "";
            }
        }

        private void CalculateSum()
        {
            decimal TotalPrice = 0.00m;

            TotalPrice = CalcTotalPrice();
            orderPriceTotalEdit.Text = TotalPrice.ToString("N", Utils.NumFormat(2));

            if (vatCheck.Checked)
            {
                decimal Vat = 0.00m;
                decimal TotalWithVat = 0.00m;

                Vat = TotalPrice * 0.20m;
                TotalWithVat = TotalPrice + Vat;

                vatTBox.Text = Math.Round(Vat, 2).ToString();
                totalWithVatTBox.Text = Math.Round(TotalWithVat, 2).ToString();
            }
        }

        private decimal CalcTotalPrice()
        {
            decimal Sum = 0.00m;

            foreach (var item in receiptsBS)
            {
                Sum += Convert.ToDecimal(((ReceiptsDTO)item).TOTAL_PRICE);
            }

            //for (int i = 0; i < DataModule.StorehouseDS.Tables["Receipt"].Rows.Count; i++)
            //{
            //   if (DataModule.StorehouseDS.Tables["Receipt"].Rows[i].RowState != DataRowState.Deleted && DataModule.StorehouseDS.Tables["Receipt"].Rows[i]["Total_Price"] != DBNull.Value)
            //       Sum += Convert.ToDecimal(DataModule.StorehouseDS.Tables["Receipt"].Rows[i]["Total_Price"]);
            //}
            return Sum;
        }


        private void totalPriceEdit_TextChanged(object sender, EventArgs e)
        {
            //UnitPrice();
        }



        private void totalPriceEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.EnterCheck(sender, e, 9, 2);
            if (e.KeyChar == (char)Keys.Enter)
            {
                receiptsBS.EndEdit();
                UnitPrice();
                CalculateSum();

                //addBtn.Focus();
            }
        }

        private void totalPriceEdit_TextChanged_1(object sender, EventArgs e)
        {
            //UnitPrice();
        }

        private void totalPriceEdit_Leave(object sender, EventArgs e)
        {
        //    receiptsBS.EndEdit();
        //    CalculateSum();
        }

        private void totalPriceEdit_TextChanged_2(object sender, EventArgs e)
        {
            UnitPrice();
        }

        private void totalPriceEdit_Leave_1(object sender, EventArgs e)
        {
            receiptsBS.EndEdit();
            CalculateSum();
        }

        private void totalPriceEdit_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            Utils.EnterCheck(sender, e, 9, 2);
            if (e.KeyChar == (char)Keys.Enter)
            {
                receiptsBS.EndEdit();
                UnitPrice();
                CalculateSum();

                barMaterial.ItemLinks[0].Focus();
            }
        }

        private void storehouseEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {



            //receiptsGridView.RefreshData();
        }

        private void storehouseEdit_TextChanged(object sender, EventArgs e)
        {
            if (receiptsBS.Count > 0 && !receiptsBS.IsBindingSuspended)
                ((ReceiptsDTO)receiptsBS.Current).StoreHouseName = storehouseEdit.Text;
            

        }

        private void StoreHouseOrderEditFm_Load(object sender, EventArgs e)
        {

        }

       

        private void dropDownBtn_Click(object sender, EventArgs e)
        {
        }

        private void dropDownBtn_ArrowButtonClick(object sender, EventArgs e)
        {
        }

        private void addAfterButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterial(2);
        }

        private void addBeforeButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterial(3);
        }

        private void receiptsGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            bool check = Convert.ToBoolean(receiptsGridView.GetRowCellValue(e.RowHandle, "InsertNomenclature"));

            if (check)
                e.Appearance.BackColor = Color.Bisque;
            else
                e.Appearance.BackColor = Color.White;

            //Override any other formatting  
            e.HighPriority = true;  
        }



        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void addBeforeItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterial(3);
        }

        private void addAfterItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterial(2);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        #region Validation

        private bool ControlValidation()
        {
            return receiptValidationProvider.Validate();
        }

        private void receiptValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void receiptValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (receiptValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void invoiceDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void orderDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void receiptNumTBox_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void vendorEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void invoiceNumTBox_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void suppliersEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void accountsEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void storekeepersEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void otkPersonsEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        private void storehouseEdit_EditValueChanged(object sender, EventArgs e)
        {
            receiptValidationProvider.Validate((Control)sender);
        }

        #endregion

        private void addReceiptBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterial(1);
            nomenclatureEdit.Focus();
        }

        private void deleteReceiptBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            receiptsBS.SuspendBinding();

            receiptsGridView.PostEditor();

            receiptsGridView.BeginDataUpdate();

            var checkItems = receiptsList.Where(t => t.Selected && t.ID != 0);

            deleteReceiptsList.AddRange(checkItems);

            receiptsList.RemoveAll(s => s.Selected);

            receiptsBS.DataSource = receiptsList;

            int i = 1;

            foreach (var item in receiptsList)
            {
                ((ReceiptsDTO)item).POS = i;
                ++i;
            }
            //if (receiptsBS.Count != 0)
            //{
                
            //    receiptsGridView.FocusedRowHandle = 1;

            //}
            //else
            //{
            //    //receiptsBS.DataSource = null;
            //}
            receiptsGrid.DataSource = receiptsList;

            if(receiptsBS.Count == 0)
                MaterialEdit();
                    

            receiptsGridView.EndDataUpdate();

            receiptsBS.ResumeBinding();

            CalculateSum();
        }

        private void addTTNBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DeliveryTTNFm deliveryTTNFm = new DeliveryTTNFm(userTaskDTO))
            {
                if (deliveryTTNFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DeliveryOrderDTO deliveryOrderDTO = deliveryTTNFm.Return();

                    ttnGridView.BeginDataUpdate();

                    deliveryOrdersDetailsList.Add(new DeliveryOrdersDetailsDTO()
                    {
                         Id = 0,
                         DeliveryName = deliveryOrderDTO.DeliveryName,
                          OrderDate = deliveryOrderDTO.OrderDate,
                         Price = deliveryOrderDTO.Price,
                         TTN = deliveryOrderDTO.TTN,
                          DeliveryPaymentName = deliveryOrderDTO.DeliveryPaymentName,
                         DeliveryOrderId = deliveryOrderDTO.Id
                    });

                    

                    ttnGridView.EndDataUpdate();

                    CheckTransportInvoice();


                }
            }
        }

        private void deleteTTNBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            ttnGridView.PostEditor();

            ttnGridView.BeginDataUpdate();

            var checkItems = deliveryOrdersDetailsList.Where(t => t.Selected && t.Id != 0);

            deleteDeliveryOrdersDetailsList.AddRange(checkItems);

            deliveryOrdersDetailsList.RemoveAll(s => s.Selected);

            deliveryOrdersDetailsBS.DataSource = deliveryOrdersDetailsList;

            ttnGrid.DataSource = deliveryOrdersDetailsBS;

            

            ttnGridView.EndDataUpdate();

            CheckTransportInvoice();

        }

        public void CheckTransportInvoice()
        {
            if (deliveryOrdersDetailsBS != null)
            {
                if (deliveryOrdersDetailsBS.Count > 0)
                {
                    transportInvoiceCheckBox.Checked = true;
                }
                else
                {
                    ((OrdersDTO)Item).TRANSPORT_INVOICE = 0;
                    transportInvoiceCheckBox.Checked = false;
                }
            }
            else
            {
                ((OrdersDTO)Item).TRANSPORT_INVOICE = 0;
                transportInvoiceCheckBox.Checked = false;
            }
        }

        private void invoiceDateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                orderDateEdit.Focus();
        }

        private void orderDateEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                receiptNumTBox.Focus();
        }

        private void receiptNumTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                vendorEdit.Focus();
        }

        private void vendorEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                invoiceNumTBox.Focus();
        }

        private void invoiceNumTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                suppliersEdit.Focus();
        }

        private void supplierProxyTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                otkPersonsEdit.Focus();
        }

        private void otkPersonsEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                storekeepersEdit.Focus();
        }

        private void storekeepersEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                storehouseEdit.Focus();
        }

        private void storehouseEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                barMaterial.ItemLinks[0].Focus(); 
            }

            
                //bar2.ItemLinks[0].ScreenBounds.Location;

    //        Cursor.Position = (baritem.Links(0).ScreenBounds.Location)  
    //Cursor.Position = New Point(Cursor.Position.X + 12, Cursor.Position.Y + 12)
            //barManager1.Bars[0].ItemLinks[0].Focus();
        }

        private void suppliersEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                supplierProxyTBox.Focus();
        }

        private void quantityEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                totalPriceEdit.Focus();
        }

        private void addReceiptBtn_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {

                barMaterial.ItemLinks[0].Focus();
            
        }

        private void customerOrderEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                customerOrderEdit.EditValue = null;
                customerOrderEdit.Properties.NullText = "Немає данних";
            }
        }

        private void customerOrdersEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                customerOrderEdit.EditValue = null;
                customerOrderEdit.Properties.NullText = "Немає данних";
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCustomerOrdersBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

    }
}