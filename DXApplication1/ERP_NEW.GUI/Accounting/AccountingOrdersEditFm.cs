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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using ERP_NEW.BLL.Services;
using ERP_NEW.GUI.StoreHouse;
using DevExpress.XtraEditors.DXErrorProvider;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingOrdersEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IEmployeesService employeesService;
        private IContractorsService contractorsService;
        private IAccountsService accountService;
        private IUnitsService unitsService;
        private ILogService logService;
        //private IPeriodService periodService;
        private ICurrencyService currencyService;

        private const string NameForm = "AccountingOrdersEditFm";

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

        private ValidationRuleBase vatAccountEditValidationRule, vatEditValidationRule, currencyEditValidationRule, rateEditValidationRule;

        private UserTasksDTO userTaskDTO;

        private bool isCurrencyReceipt;

        private ObjectBase Item
        {
            get { return ordersBS.Current as ObjectBase; }
            set
            {
                ordersBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AccountingOrdersEditFm(bool isCurrencyReceipt, Utils.Operation operation, OrdersDTO model, List<ReceiptsDTO> source, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            this.isCurrencyReceipt = isCurrencyReceipt;
            this.operation = operation;
            this.userTaskDTO = userTaskDTO;

            correctionCheckBox.CheckedChanged -= new EventHandler(this.correctionCheckBox_CheckedChanged);

            vatAccountEditValidationRule = ordersValidationProvider.GetValidationRule(vatAccountEdit);
            vatEditValidationRule = ordersValidationProvider.GetValidationRule(vatEdit);
            currencyEditValidationRule = currencyValidationProvider.GetValidationRule(currencyEdit);
            rateEditValidationRule = currencyValidationProvider.GetValidationRule(rateEdit);

            ordersBS.DataSource = Item = model;

            receiptsList = source;
            receiptsBS.DataSource = receiptsList;
            receiptsGrid.DataSource = receiptsBS;

            deliveryOrdersDetailsBS.DataSource = deliveryOrdersDetailsList;
            ttnGrid.DataSource = deliveryOrdersDetailsBS;

            if(this.operation == Utils.Operation.Add)
            {

                //checkBox1.Checked = Properties.Settings.Default.Flag1;
                //checkBox2.Checked = Properties.Settings.Default.Flag2;
                //checkBox3.Checked = (_isCurrencyReceipt) ? false : Properties.Settings.Default.Flag3;
                //checkBox4.Checked = (_isCurrencyReceipt) ? false : Properties.Settings.Default.Flag4;
                //vatChBox.Checked = (_isCurrencyReceipt) ? false : true;

                if (storehouseCheck.Checked) 
                    accountsEdit.EditValue = 16;
                if ((storehouseCheck.Checked || account631Check.Checked) && !isCurrencyReceipt)
                    accountsEdit.EditValue = 15;

                ((OrdersDTO)Item).DEBIT_ACCOUNT_ID = isCurrencyReceipt ? (short)60 : (short)15;
                ((OrdersDTO)Item).TRANSPORT_INVOICE = 0;
                ((OrdersDTO)Item).TAX_INVOICE = 0;

                suppliersEdit.EditValue = null;
                storekeepersEdit.EditValue = null;
                otkPersonsEdit.EditValue = null;
            }
            else
            {
                if (model.Vat == null)
                {
                    vatCheck.Checked = false;
                }
                else
                {
                    vatCheck.Checked = true;

                    
                }

                LoadDeliveryOrderDetails(model.ID);
            }

            if (isCurrencyReceipt)
            {
                account631Check.Visible = false;
                account63Check.Visible = false;

                CheckCurrencyRate();

                
            }
            else
            {
                ((OrdersDTO)Item).CURRENCY_ID = 1;
                

                receiptsGridView.Columns[8].Visible = false;
                receiptsGridView.Columns[9].Visible = false;
                currencyLabel.Visible = false;
                rateLabel.Visible = false;
                orderTotalCurrencyLabel.Visible = false;
                orderTotalCurrencyEdit.Visible = false;
                rateEdit.Visible = false;
                currencyEdit.Visible = false;

                currencyValidationProvider.SetValidationRule(rateEdit, null);
                currencyValidationProvider.SetValidationRule(currencyEdit, null);
            }

            accountService = Program.kernel.Get<IAccountsService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            unitsService = Program.kernel.Get<IUnitsService>();
            logService = Program.kernel.Get<ILogService>();

            

            #region Order binding

            invoiceDateEdit.DataBindings.Add("EditValue", ordersBS, "Invoice_Date", true, DataSourceUpdateMode.OnPropertyChanged);
            orderDateEdit.DataBindings.Add("EditValue", ordersBS, "Order_Date", true, DataSourceUpdateMode.OnPropertyChanged);
            receiptNumTBox.DataBindings.Add("EditValue", ordersBS, "Receipt_Num", true, DataSourceUpdateMode.OnPropertyChanged);
            invoiceNumTBox.DataBindings.Add("EditValue", ordersBS, "Invoice_Num", true, DataSourceUpdateMode.OnPropertyChanged);
            supplierProxyTBox.DataBindings.Add("EditValue", ordersBS, "Supplier_Proxy", true, DataSourceUpdateMode.OnPropertyChanged);
            orderPriceTotalEdit.DataBindings.Add("EditValue", ordersBS, "TOTAL_PRICE", true, DataSourceUpdateMode.OnPropertyChanged);
            //vatEdit.DataBindings.Add("EditValue", ordersBS, "Vat");
            //vatAccountEdit.DataBindings.Add("EditValue", ordersBS, "VatAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            totalWithVatEdit.DataBindings.Add("EditValue", ordersBS, "TOTAL_WITH_VAT", true, DataSourceUpdateMode.OnPropertyChanged);
            orderTotalCurrencyEdit.DataBindings.Add("EditValue", ordersBS, "TOTAL_CURRENCY", true, DataSourceUpdateMode.OnPropertyChanged);
            rateEdit.DataBindings.Add("EditValue", ordersBS, "CURRENCY_RATE", true, DataSourceUpdateMode.OnPropertyChanged);
            accountNumEdit.DataBindings.Add("EditValue", ordersBS, "Account_Num", true, DataSourceUpdateMode.OnPropertyChanged);


            taxInvoiceCheckBox.DataBindings.Add("Checked", ordersBS, "TAX_INVOICE", true, DataSourceUpdateMode.OnPropertyChanged);
            transportInvoiceCheckBox.DataBindings.Add("Checked", ordersBS, "TRANSPORT_INVOICE", true, DataSourceUpdateMode.OnPropertyChanged);
            checkCheckBox.DataBindings.Add("Checked", ordersBS, "CHECKED", true, DataSourceUpdateMode.OnPropertyChanged);
            correctionCheckBox.DataBindings.Add("Checked", ordersBS, "CORRECTION");

            storehouseCheck.DataBindings.Add("Checked", ordersBS, "Flag1", true, DataSourceUpdateMode.OnPropertyChanged);
            storehouseAccountCheck.DataBindings.Add("Checked", ordersBS, "Flag2", true, DataSourceUpdateMode.OnPropertyChanged);
            account631Check.DataBindings.Add("Checked", ordersBS, "Flag3", true, DataSourceUpdateMode.OnPropertyChanged);
            account63Check.DataBindings.Add("Checked", ordersBS, "Flag4", true, DataSourceUpdateMode.OnPropertyChanged);

            vendorEdit.DataBindings.Add("EditValue", ordersBS, "Vendor_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            vendorEdit.Properties.DataSource = contractorsService.GetContractors(1);
            vendorEdit.Properties.ValueMember = "Id";
            vendorEdit.Properties.DisplayMember = "Name";
            vendorEdit.Properties.NullText = "Немає данних";

            employeesList = employeesService.GetEmployeesWorkingNonPhoto().Where(srch => srch.SupplierId!=null).ToList();

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
            accountsEdit.Properties.DataSource = accountService.GetAccounts();
            accountsEdit.Properties.ValueMember = "Id";
            accountsEdit.Properties.DisplayMember = "Num";
            accountsEdit.Properties.NullText = "Немає данних";

            vatAccountEdit.DataBindings.Add("EditValue", ordersBS, "VatAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            vatAccountEdit.Properties.DataSource = accountService.GetVatAccounts();
            vatAccountEdit.Properties.ValueMember = "Id";
            vatAccountEdit.Properties.DisplayMember = "Num";
            vatAccountEdit.Properties.NullText = "Немає данних";

            currencyEdit.DataBindings.Add("EditValue", ordersBS, "CURRENCY_ID", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyService.GetCurrency();
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Code";
            currencyEdit.Properties.NullText = "Немає данних";

            #endregion

            

            CalculateSum();

            ControlValidationOrder();
            ControlValidationCurrency();

            //DialogResult = DialogResult.None;
        }

        public void LoadDeliveryOrderDetails(long orderId)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            deliveryOrdersDetailsList = storeHouseService.GetDeliveryOrdersDetailsByOrderid(orderId).ToList();
            deliveryOrdersDetailsBS.DataSource = deliveryOrdersDetailsList;
            ttnGrid.DataSource = deliveryOrdersDetailsBS;

        }


        public OrdersDTO Return()
        {
            return ((OrdersDTO)Item);
        }

        


        

        private void EditReceipts(Utils.Operation operation, ReceiptsDTO model, bool isCurrencyReceipt, bool isCorrection)
        {
            using (AccountingOrdersReceiptEditFm accountingOrdersReceiptsEditFm = new AccountingOrdersReceiptEditFm(operation, model, userTaskDTO, isCurrencyReceipt, isCorrection))
            {
                if (accountingOrdersReceiptsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ReceiptsDTO returnItem = accountingOrdersReceiptsEditFm.Return();

                    receiptsGridView.BeginDataUpdate();

                    if (operation == Utils.Operation.Add)
                    {
                        receiptsBS.Add(returnItem);

                        
                    }
                    else
                    {
                        ((ReceiptsDTO)receiptsBS.Current).BalanceAccountId = returnItem.BalanceAccountId;
                        ((ReceiptsDTO)receiptsBS.Current).BalanceAccountNum = returnItem.BalanceAccountNum;
                        ((ReceiptsDTO)receiptsBS.Current).CURRENCY_ID = returnItem.CURRENCY_ID;
                        ((ReceiptsDTO)receiptsBS.Current).CURRENCY_RATE = returnItem.CURRENCY_RATE;
                        ((ReceiptsDTO)receiptsBS.Current).ID = returnItem.ID;
                        ((ReceiptsDTO)receiptsBS.Current).Nomenclature = returnItem.Nomenclature;
                        ((ReceiptsDTO)receiptsBS.Current).NOMENCLATURE_ID = returnItem.NOMENCLATURE_ID;
                        ((ReceiptsDTO)receiptsBS.Current).NomenclatureGroupId = returnItem.NomenclatureGroupId;
                        ((ReceiptsDTO)receiptsBS.Current).NomenclatureName = returnItem.NomenclatureName;
                        ((ReceiptsDTO)receiptsBS.Current).ORDER_ID = returnItem.ORDER_ID;
                        ((ReceiptsDTO)receiptsBS.Current).POS = returnItem.POS;
                        ((ReceiptsDTO)receiptsBS.Current).QUANTITY = returnItem.QUANTITY;
                        ((ReceiptsDTO)receiptsBS.Current).Storehouse_Id = returnItem.Storehouse_Id;
                        ((ReceiptsDTO)receiptsBS.Current).StoreHouseName = returnItem.StoreHouseName;
                        ((ReceiptsDTO)receiptsBS.Current).TOTAL_CURRENCY = returnItem.TOTAL_CURRENCY;
                        ((ReceiptsDTO)receiptsBS.Current).TOTAL_PRICE = returnItem.TOTAL_PRICE;
                        ((ReceiptsDTO)receiptsBS.Current).UNIT_CURRENCY = returnItem.UNIT_CURRENCY;
                        ((ReceiptsDTO)receiptsBS.Current).UNIT_PRICE = returnItem.UNIT_PRICE;
                        ((ReceiptsDTO)receiptsBS.Current).UnitId = returnItem.UnitId;
                        ((ReceiptsDTO)receiptsBS.Current).UnitLocalName = returnItem.UnitLocalName;
                       // ((ReceiptsDTO)receiptsBS.Current). = returnItem.UnitLocalName;

                    }

                    //currentDate = new DateTime(((DateTime)yearEdit.EditValue).Year, (int)monthEdit.EditValue, 1);
                    //LoadData(currentDate, currentDate.AddMonths(1).AddDays(-1));

                    receiptsBS.EndEdit();
                    receiptsBS.ResetCurrentItem();
                    receiptsGridView.BeginSummaryUpdate();
                    receiptsGridView.EndSummaryUpdate();

                    receiptsGridView.EndDataUpdate();

                    CalculateSum();

                    CheckCurrencyRate();

                    //vatPriceTBox.EditValue = CalculateVatSum();
                    //paymentTBox.EditValue = CalculatePriceSum();
                    //currencyPaymentTBox.EditValue = CalculatePriceCurrencySum();


                    //int rowHandle = receiptsGridView.LocateByValue("Id", return_Id.Id);

                    //receiptsGridView.FocusedRowHandle = rowHandle;

                    //LoadCashBookRecordsById(((CashBookPageDTO)cashBookBS.Current).Id, ((CashBookPageDTO)cashBookBS.Current).PageDate);



                }
            }
        }

        private void CheckCurrencyRate()
        {
            if (receiptsBS.Count > 0)
                rateEdit.ReadOnly = true;
            else
                rateEdit.ReadOnly = false;
        }

        private void CalculateSum(bool manualVat = false)
        {
            decimal TotalPrice = 0.00m;
            decimal TotalPriceCurrency = 0.00m;

            TotalPrice = CalcTotalPrice();
            TotalPriceCurrency = CalcTotalPriceCurrency();

            orderPriceTotalEdit.Text = TotalPrice.ToString();
            orderTotalCurrencyEdit.Text = TotalPriceCurrency.ToString();
            //((OrdersDTO)Item).TOTAL_PRICE = TotalPrice;

            if (vatCheck.Checked)
            {   
                decimal Vat = 0.00m;
                decimal TotalWithVat = 0.00m;

                if (!manualVat)
                    Vat = TotalPrice * 0.20m;
                TotalWithVat = TotalPrice + Vat;


                vatEdit.EditValue = Math.Round(Vat, 2).ToString();
                totalWithVatEdit.EditValue = Math.Round(TotalWithVat, 2).ToString();

            }
        }

        private decimal CalcTotalPrice()
        {
            decimal Sum = 0.00m;

            foreach (var item in receiptsBS)
                Sum += Convert.ToDecimal(((ReceiptsDTO)item).TOTAL_PRICE);
            return Sum;
        }

        private decimal CalcTotalPriceCurrency()
        {
            decimal Sum = 0.00m;

            foreach (var item in receiptsBS)
                Sum += Convert.ToDecimal(((ReceiptsDTO)item).TOTAL_CURRENCY);
            return Sum;
        }
        

        private void vatEdit_EditValueChanged(object sender, EventArgs e)
        {
            //CalculateSum(true);
        }

        #region Validation's

        private bool ControlValidationOrder()
        {
            return ordersValidationProvider.Validate();
        }

        private bool ControlValidationCurrency()
        {
            return currencyValidationProvider.Validate();
        }

        private void ordersValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void ordersValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (ordersValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void vatEdit_EditValueChanged_1(object sender, EventArgs e)
        {
            ordersValidationProvider.Validate((Control)sender);
        }

        private void vatAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            ordersValidationProvider.Validate((Control)sender);
        }

        private void currencyEdit_EditValueChanged(object sender, EventArgs e)
        {
            currencyValidationProvider.Validate((Control)sender);
        }

        private void rateEdit_EditValueChanged(object sender, EventArgs e)
        {
            currencyValidationProvider.Validate((Control)sender);
        }

        private void vendorEdit_EditValueChanged(object sender, EventArgs e)
        {
            ordersValidationProvider.Validate((Control)sender);
        }

        private void suppliersEdit_EditValueChanged(object sender, EventArgs e)
        {
            ordersValidationProvider.Validate((Control)sender);
        }

        private void accountsEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (accountsEdit.Text == "63")
            {
                storehouseCheck.Checked = false;
                storehouseAccountCheck.Checked = false;
                account631Check.Checked = false;
                account63Check.Checked = true;
            }

            ordersValidationProvider.Validate((Control)sender);
        }

        private void currencyValidationProvider_ValidationFailed(object sender, ValidationFailedEventArgs e)
        {
            this.addMaterialBtn.Enabled = false;
            this.editMaterialBtn.Enabled = false;
        }

        private void currencyValidationProvider_ValidationSucceeded(object sender, ValidationSucceededEventArgs e)
        {
            bool isValidate = (currencyValidationProvider.GetInvalidControls().Count == 0);
            this.addMaterialBtn.Enabled = isValidate;
            this.editMaterialBtn.Enabled = isValidate;
        }

        #endregion

        #region Event's

        private void rateEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            splashScreenManager.ShowWaitForm();

            currencyService = Program.kernel.Get<CurrencyService>();

            rateEdit.EditValue = currencyService.GetCurrencyRateByDate(((CurrencyDTO)currencyEdit.GetSelectedDataRow()).Code, (DateTime)((OrdersDTO)Item).ORDER_DATE);

            splashScreenManager.CloseWaitForm();
        }

        private void vatEdit_TextChanged(object sender, EventArgs e)
        {
            //CalculateSum(true);

            decimal vat = (vatEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(vatEdit.Text);
            decimal totalPrice = (orderPriceTotalEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(orderPriceTotalEdit.Text);
            decimal totalPriceWithVat = totalPrice + vat;

            totalWithVatEdit.Text = totalPriceWithVat.ToString("N", Utils.NumFormat(2));
        }

        private void addMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReceiptsDTO addReceiptsDTO = new ReceiptsDTO();

            if (isCurrencyReceipt)
            {
                addReceiptsDTO.CURRENCY_ID = ((OrdersDTO)Item).CURRENCY_ID;
                addReceiptsDTO.CURRENCY_RATE = ((OrdersDTO)Item).CURRENCY_RATE;
            }

            EditReceipts(Utils.Operation.Add, addReceiptsDTO, isCurrencyReceipt, Convert.ToBoolean(((OrdersDTO)Item).CORRECTION));
        }


        private void editMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (receiptsBS.Count > 0)
                EditReceipts(Utils.Operation.Update, ((ReceiptsDTO)receiptsBS.Current), isCurrencyReceipt, Convert.ToBoolean(((OrdersDTO)Item).CORRECTION));

        }

        private void deleteMaterialBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (receiptsBS.Count > 0)
            {
                receiptsGridView.PostEditor();
                receiptsGridView.BeginDataUpdate();
                var checkItems = receiptsList.Where(t => t.Selected && t.ID != 0).ToList();
                deleteReceiptsList.AddRange(checkItems);
                receiptsList.RemoveAll(s => s.Selected);
                receiptsBS.DataSource = receiptsList;
                receiptsGrid.DataSource = receiptsBS;
                receiptsGridView.EndDataUpdate();

                CalculateSum();

                CheckCurrencyRate();

                //CheckTransportInvoice();
            }
        }


        private void addTtnBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    deliveryOrdersDetailsBS.DataSource = deliveryOrdersDetailsList;

                    ttnGridView.EndDataUpdate();

                    CheckTransportInvoice();
                }
            }
        }

        private void deleteTtnBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (deliveryOrdersDetailsBS.Count > 0)
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
        }

        private void vatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!vatCheck.Checked)
            {
                ordersValidationProvider.SetValidationRule(vatEdit, null);
                ordersValidationProvider.SetValidationRule(vatAccountEdit, null);

                vatAccountEdit.Properties.ReadOnly = true;
                vatEdit.Properties.ReadOnly = true;

                vatEdit.EditValue = 0.00m;

            }
            else
            {
                ordersValidationProvider.SetValidationRule(vatAccountEdit, vatAccountEditValidationRule);
                ordersValidationProvider.SetValidationRule(vatEdit, vatEditValidationRule);

                vatAccountEdit.Properties.ReadOnly = false;
                vatEdit.Properties.ReadOnly = false;

                CalculateSum();
            }

            ControlValidationOrder();
        }

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
                    logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTaskDTO, NameForm);
                }
            }
        }

        #endregion

       

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

        private bool CheckReceiptNum()
        {

            var orders = storeHouseService.GetOrdersByPeriod(new DateTime(((OrdersDTO)Item).ORDER_DATE.Value.Year, 1, 1), new DateTime(((OrdersDTO)Item).ORDER_DATE.Value.Year, 12, 31));

            string searchReceipt = ((OrdersDTO)Item).RECEIPT_NUM;
            if (searchReceipt == null || searchReceipt == "")
            {
                return true;
            }
            else
            {
                if (!orders.Any(bdsm => bdsm.ReceiptNum == searchReceipt && bdsm.Id != ((OrdersDTO)Item).ID))
                    return true;
                else
                    return false;
            }
        }

        private bool AddVat()
        {
            try
            {
                storeHouseService.VatCreateDirect(((OrdersDTO)Item).ID);
                //(vatEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(vatEdit.Text)

                //decimal vat = (vatEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(vatEdit.Text);

                //MessageBox.Show(vatEdit.Text);

                //MessageBox.Show(vatEdit.EditValue.ToString());

                if (vatCheck.Checked)
                {
                    //VatDTO vatDTO = new VatDTO()
                    //{
                    //    ID = ((OrdersDTO)Item).ID,
                    //    PRICE = (vatEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(vatEdit.Text),
                    //    ACCOUNT_ID = ((OrdersDTO)Item).VatAccountId
                    //};

                    storeHouseService.VatUpdate(new VatDTO()
                    {
                        ID = ((OrdersDTO)Item).ID,
                        PRICE = (vatEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(vatEdit.Text),
                        ACCOUNT_ID = ((OrdersDTO)Item).VatAccountId
                    });
                }
                else
                {
                    storeHouseService.VatUpdate(new VatDTO()
                    {
                        ID = ((OrdersDTO)Item).ID,
                        PRICE = null,
                        ACCOUNT_ID = null
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при записі ПДВ! Помилка " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTaskDTO, NameForm);
                return false;
            }

            return true;
        }

        private bool AddMaterials()
        {

            try
            {
                foreach (var item in receiptsBS)
                {
                    ReceiptsDTO newModel = new ReceiptsDTO();

                    newModel.ORDER_ID = ((OrdersDTO)Item).ID;
                    newModel.QUANTITY = ((ReceiptsDTO)item).QUANTITY;
                    newModel.POS = null;
                    newModel.NOMENCLATURE_ID = ((ReceiptsDTO)item).NOMENCLATURE_ID;
                    newModel.TOTAL_PRICE = ((ReceiptsDTO)item).TOTAL_PRICE;
                    newModel.TOTAL_CURRENCY = ((ReceiptsDTO)item).TOTAL_CURRENCY;
                    storeHouseService.ReceiptCreate(newModel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при записі матеріалу! Помилка " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTaskDTO, NameForm);
                return false;
            }
            
            return true;
        }

        private bool AddTtn()
        {
            try
            {
                foreach (var item in deliveryOrdersDetailsBS)
                    {
                        DeliveryOrdersDetailsDTO newModel = new DeliveryOrdersDetailsDTO();

                        newModel.OrderId = ((OrdersDTO)Item).ID;
                        newModel.DeliveryOrderId = ((DeliveryOrdersDetailsDTO)item).DeliveryOrderId;

                        storeHouseService.DeliveryOrdersDetailsCreate(newModel);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при записі матеріалу! Помилка " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTaskDTO, NameForm);
                return false;
            }

            return true;

        }


        private bool SaveOrder()
        {
            this.Item.EndEdit();

            ordersBS.EndEdit();
            receiptsBS.EndEdit();
            deliveryOrdersDetailsBS.EndEdit();

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

            if (!storehouseCheck.Checked && !storehouseAccountCheck.Checked && !account63Check.Checked && !account631Check.Checked)
            {
                MessageBox.Show("Не обрана відмітка", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            try
            {
                if (operation == Utils.Operation.Add)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();

                    //((OrdersDTO)Item).ID = storeHouseService.OrderCreateDirect();
                    ((OrdersDTO)Item).ID = storeHouseService.OrderCreate(((OrdersDTO)Item));

                    if (!AddVat())
                        return false;

                    if (!AddMaterials())
                        return false;

                    if (!AddTtn())
                        return false;

                    OrdersDTO updateOrderItem = new OrdersDTO()
                    {
                        ID = ((OrdersDTO)Item).ID,
                        RECEIPT_NUM = ((OrdersDTO)Item).RECEIPT_NUM == "" ? null : ((OrdersDTO)Item).RECEIPT_NUM,
                        VENDOR_ID = ((OrdersDTO)Item).VENDOR_ID,
                        INVOICE_NUM = ((OrdersDTO)Item).INVOICE_NUM,
                        SUPPLIER_ID = (short?)employeesList.FirstOrDefault(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).SupplierId).SupplierId,
                        SupplierId = ((OrdersDTO)Item).SupplierId,
                        OtkId = ((OrdersDTO)Item).OtkId,
                        StorekeeperId = ((OrdersDTO)Item).StorekeeperId,
                        Otk_Id = ((OrdersDTO)Item).OtkId != null ? (short?)employeesList.FirstOrDefault(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).OtkId).SupplierId : null,
                        Storekeeper_Id = ((OrdersDTO)Item).StorekeeperId != null ? (short?)employeesList.FirstOrDefault(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).StorekeeperId).SupplierId : null,
                        SUPPLIER_PROXY = ((OrdersDTO)Item).SUPPLIER_PROXY,
                        INVOICE_DATE = ((OrdersDTO)Item).INVOICE_DATE,
                        ORDER_DATE = ((OrdersDTO)Item).ORDER_DATE,
                        TOTAL_WITH_VAT = ((OrdersDTO)Item).TOTAL_WITH_VAT,
                        TOTAL_PRICE = ((OrdersDTO)Item).TOTAL_PRICE,
                        CURRENCY_RATE = ((OrdersDTO)Item).CURRENCY_RATE,
                        TOTAL_CURRENCY = ((OrdersDTO)Item).TOTAL_CURRENCY,
                        ACCOUNT_NUM = ((OrdersDTO)Item).ACCOUNT_NUM,
                        CHECKED = ((OrdersDTO)Item).CHECKED,
                        CORRECTION = ((OrdersDTO)Item).CORRECTION,
                        Color_Id = 1,
                        CURRENCY_ID = ((OrdersDTO)Item).CURRENCY_ID,
                        DEBIT_ACCOUNT_ID = ((OrdersDTO)Item).DEBIT_ACCOUNT_ID,
                        TRANSPORT_INVOICE = ((OrdersDTO)Item).TRANSPORT_INVOICE,
                        TAX_INVOICE = ((OrdersDTO)Item).TAX_INVOICE,
                        UserId = userTaskDTO.UserId,
                        ENTER_DATE = DateTime.Now,
                        

                        Flag1 = ((OrdersDTO)Item).Flag1,
                        Flag2 = ((OrdersDTO)Item).Flag2,
                        Flag3 = ((OrdersDTO)Item).Flag3,
                        Flag4 = ((OrdersDTO)Item).Flag4
                    };

                    storeHouseService.OrderUpdate(updateOrderItem, true);

                    return true;
                }
                else
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();

                    OrdersDTO updateOrderItem = new OrdersDTO()
                    {
                        ID = ((OrdersDTO)Item).ID,
                        RECEIPT_NUM = ((OrdersDTO)Item).RECEIPT_NUM == "" ? null : ((OrdersDTO)Item).RECEIPT_NUM,
                        VENDOR_ID = ((OrdersDTO)Item).VENDOR_ID,
                        INVOICE_NUM = ((OrdersDTO)Item).INVOICE_NUM,
                        SUPPLIER_ID = (short?)employeesList.FirstOrDefault(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).SupplierId).SupplierId,
                        SupplierId = ((OrdersDTO)Item).SupplierId,
                        OtkId = ((OrdersDTO)Item).OtkId,
                        StorekeeperId = ((OrdersDTO)Item).StorekeeperId,
                        Otk_Id = ((OrdersDTO)Item).OtkId != null ? (short?)employeesList.FirstOrDefault(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).OtkId).SupplierId : null,
                        Storekeeper_Id = ((OrdersDTO)Item).StorekeeperId != null ? (short?)employeesList.FirstOrDefault(bdsm => bdsm.EmployeeID == ((OrdersDTO)Item).StorekeeperId).SupplierId : null,
                        SUPPLIER_PROXY = ((OrdersDTO)Item).SUPPLIER_PROXY,
                        INVOICE_DATE = ((OrdersDTO)Item).INVOICE_DATE,
                        ORDER_DATE = ((OrdersDTO)Item).ORDER_DATE,
                        TOTAL_WITH_VAT = ((OrdersDTO)Item).TOTAL_WITH_VAT,
                        TOTAL_PRICE = ((OrdersDTO)Item).TOTAL_PRICE,
                        CURRENCY_RATE = ((OrdersDTO)Item).CURRENCY_RATE,
                        TOTAL_CURRENCY = ((OrdersDTO)Item).TOTAL_CURRENCY,
                         ACCOUNT_NUM = ((OrdersDTO)Item).ACCOUNT_NUM,

                        CHECKED = ((OrdersDTO)Item).CHECKED,
                        CORRECTION = ((OrdersDTO)Item).CORRECTION,
                        Color_Id = ((OrdersDTO)Item).Color_Id,
                        CURRENCY_ID = ((OrdersDTO)Item).CURRENCY_ID,
                        DEBIT_ACCOUNT_ID = ((OrdersDTO)Item).DEBIT_ACCOUNT_ID,
                        TRANSPORT_INVOICE = ((OrdersDTO)Item).TRANSPORT_INVOICE,
                        TAX_INVOICE = ((OrdersDTO)Item).TAX_INVOICE,
                        UserId = userTaskDTO.UserId,
                        ENTER_DATE = DateTime.Now,

                        Flag1 = ((OrdersDTO)Item).Flag1,
                        Flag2 = ((OrdersDTO)Item).Flag2,
                        Flag3 = ((OrdersDTO)Item).Flag3,
                        Flag4 = ((OrdersDTO)Item).Flag4
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
                                Storehouse_Id = 1,
                                NOMENCLATURE_ID = ((ReceiptsDTO)item).NOMENCLATURE_ID,
                                TOTAL_PRICE = ((ReceiptsDTO)item).TOTAL_PRICE,
                                TOTAL_CURRENCY = ((ReceiptsDTO)item).TOTAL_CURRENCY
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
                                Storehouse_Id = 1,
                                NOMENCLATURE_ID = ((ReceiptsDTO)item).NOMENCLATURE_ID,
                                TOTAL_PRICE = ((ReceiptsDTO)item).TOTAL_PRICE,
                                TOTAL_CURRENCY = ((ReceiptsDTO)item).TOTAL_CURRENCY
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
                            PRICE = (vatEdit.Text.Length == 0) ? 0.00m : Convert.ToDecimal(vatEdit.Text),
                            ACCOUNT_ID = ((OrdersDTO)Item).VatAccountId 
                        });
                    }
                    else
                    {
                        storeHouseService.VatUpdate(new VatDTO()
                        {
                            ID = ((OrdersDTO)Item).ID,
                            PRICE = null,
                            ACCOUNT_ID = null
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTaskDTO, NameForm);
                return false;
            }

            return true;
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void correctionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (receiptsBS.Count > 0)
            {
                MessageBox.Show("Перед зміною режиму, видаліть всі матеріали", "Коригування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                correctionCheckBox.CheckedChanged -= new EventHandler(this.correctionCheckBox_CheckedChanged);
                correctionCheckBox.Checked = !correctionCheckBox.Checked;
                correctionCheckBox.CheckedChanged += new EventHandler(this.correctionCheckBox_CheckedChanged);
            }
        }

        private void AccountingOrdersEditFm_Load(object sender, EventArgs e)
        {
            correctionCheckBox.CheckedChanged += new EventHandler(this.correctionCheckBox_CheckedChanged);

            vatEdit.TextChanged -= new EventHandler(vatEdit_TextChanged);

            vatEdit.Text = ((OrdersDTO)Item).Vat.ToString(); ;

            vatEdit.TextChanged += new EventHandler(vatEdit_TextChanged);
        }

        private void editMaterialBtn_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReceiptsDTO editReceiptsDTO = new ReceiptsDTO();

            editReceiptsDTO = (ReceiptsDTO)receiptsBS.Current;

            if (isCurrencyReceipt)
            {
                editReceiptsDTO.CURRENCY_ID = ((OrdersDTO)Item).CURRENCY_ID;
                editReceiptsDTO.CURRENCY_RATE = ((OrdersDTO)Item).CURRENCY_RATE;
            }

            EditReceipts(Utils.Operation.Update, editReceiptsDTO, isCurrencyReceipt, Convert.ToBoolean(((OrdersDTO)Item).CORRECTION));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}