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
using DevExpress.XtraEditors.Repository;
using ERP_NEW.GUI.Contractors;

namespace ERP_NEW.GUI.Accounting
{
    public partial class BankPaymentEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBankPaymentsService bankPaymentsService;
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        private IContractorsService contractorsService;
        private ICurrencyService currencyService;
        private IPeriodService periodService;
        private IAccountingOperationService accountingOperationService;
        private ICalcWithBuyersService calcWithBuyersService;

        private BindingSource bankPaymentsBS = new BindingSource();
        private BindingSource currencyRatesBS = new BindingSource();
        private BindingSource accountsBS = new BindingSource();
        
        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return bankPaymentsBS.Current as ObjectBase; }
            set
            {
                bankPaymentsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BankPaymentEditFm(Utils.Operation operation, Bank_PaymentsDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            _operation = operation;
            
            bankPaymentsBS.DataSource = Item = model;

            employeesService = Program.kernel.Get<IEmployeesService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            accountingOperationService = Program.kernel.Get<IAccountingOperationService>();
            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();

            currencyRatesBS.DataSource = ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId == null ?
                new Currency_RatesDTO() { Currency_Id = 1, Multiplicity = 1, CurrencyPayment = 0.00m, Rate = 0.000000m } :
                currencyService.GetCurrencyRates().Where(s => s.Id == ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId).SingleOrDefault();

            if (_operation == Utils.Operation.Add)
            {
                ((Bank_PaymentsDTO)Item).Payment_Date = DateTime.Now;
                ((Bank_PaymentsDTO)Item).Payment_Price = 0.00m;
                ((Bank_PaymentsDTO)Item).Payment_PriceCurrency = 0.00m;
                ((Bank_PaymentsDTO)Item).VatPrice = 0.00m;
                ((Bank_PaymentsDTO)Item).Rate = 0.000000m;
                ((Bank_PaymentsDTO)Item).CurrencyId = 1;
                ((Bank_PaymentsDTO)Item).AccountingOperationId = 1;

                contractorsEdit.Enabled = false;
                employeesEdit.Enabled = false;

                currencyConvertEdit.Enabled = false;
                currencyPriceConvertTBox.Enabled = false;
                rateConvertTBox.Enabled = false;
            }
            else
            {
                contractorCheckEdit.Checked = (((Bank_PaymentsDTO)Item).Contractor_Id > 0) ? true : false;
                employeeCheckEdit.Checked = (((Bank_PaymentsDTO)Item).EmployeesId > 0) ? true : false;
                
                if (((Bank_PaymentsDTO)Item).CurrencyRatesConvertId != null)
                {
                    convertCheckEdit.CheckState = CheckState.Checked;

                    currencyConvertEdit.Enabled = true;
                    currencyPriceConvertTBox.Enabled = true;
                    rateConvertTBox.Enabled = true;
                }
                else
                {
                    currencyConvertEdit.Enabled = false;
                    currencyPriceConvertTBox.Enabled = false;
                    rateConvertTBox.Enabled = false;
                }
            }

            if (_operation == Utils.Operation.Custom)
            {
                employeesEdit.Enabled = false;
                currencyConvertEdit.Enabled = false;
                currencyPriceConvertTBox.Enabled = false;
                rateConvertTBox.Enabled = false;

                contractorCheckEdit.Checked = true;
            }
            if (_operation == Utils.Operation.Template)
            {
                paymentDateEdit.Enabled = false;
                paymentDocumentTBox.Enabled = false;
                paymentPriceTBox.Enabled = false;
                paymentPriceCurrencyTBox.Enabled = false;
                currencyEdit.Enabled = false;
                groupControl3.Enabled = false;
                purposeEdit.Enabled = false;
                rateTBox.Enabled = false;
                vatPriceTBox.Enabled = false;

                vatAccountEdit.Enabled = false;
                convertCheckEdit.Enabled = false;
                groupControl4.Enabled = false;





                employeesEdit.Enabled = false;
                currencyConvertEdit.Enabled = false;
                currencyPriceConvertTBox.Enabled = false;
                rateConvertTBox.Enabled = false;

                contractorCheckEdit.Checked = true;
            }

            accountsBS.DataSource = accountsService.GetAccounts();

            if (_operation == Utils.Operation.Info)
            {
                employeesEdit.Enabled = false;
                currencyConvertEdit.Enabled = false;
                currencyPriceConvertTBox.Enabled = false;
                rateConvertTBox.Enabled = false;

                contractorCheckEdit.Checked = true;
                if(model.Purpose_Account_Id != 26)
                    accountsBS.DataSource = accountsService.GetAccounts().Where(flt=>flt.Num.Contains("312") || flt.Num.Contains("313")).ToList();
            }



            

            #region DataBinding's

            paymentDateEdit.DataBindings.Add("EditValue", bankPaymentsBS, "Payment_Date", true, DataSourceUpdateMode.OnPropertyChanged);
            paymentDocumentTBox.DataBindings.Add("EditValue", bankPaymentsBS, "Payment_Document", true, DataSourceUpdateMode.OnPropertyChanged);
            paymentPriceTBox.DataBindings.Add("EditValue", bankPaymentsBS, "Payment_Price", true, DataSourceUpdateMode.OnPropertyChanged);
            paymentPriceCurrencyTBox.DataBindings.Add("EditValue", bankPaymentsBS, "Payment_PriceCurrency", true, DataSourceUpdateMode.OnPropertyChanged);
            rateTBox.DataBindings.Add("EditValue", bankPaymentsBS, "Rate", true, DataSourceUpdateMode.OnPropertyChanged);
            vatPriceTBox.DataBindings.Add("EditValue", bankPaymentsBS, "VatPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeEdit.DataBindings.Add("EditValue", bankPaymentsBS, "Purpose", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyPriceConvertTBox.DataBindings.Add("EditValue", currencyRatesBS, "CurrencyPayment", true, DataSourceUpdateMode.OnPropertyChanged);
            rateConvertTBox.DataBindings.Add("EditValue", currencyRatesBS, "Rate", true, DataSourceUpdateMode.OnPropertyChanged);
            
            currencyEdit.DataBindings.Add("EditValue", bankPaymentsBS, "CurrencyId", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyService.GetCurrency();
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Code";
            currencyEdit.Properties.NullText = "Немає данних";

            employeesEdit.DataBindings.Add("EditValue", bankPaymentsBS, "EmployeesId", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesEdit.Properties.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "FullName";
            employeesEdit.Properties.NullText = "Немає данних";

            contractorsEdit.DataBindings.Add("EditValue", bankPaymentsBS, "Contractor_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            bankAccountEdit.DataBindings.Add("EditValue", bankPaymentsBS, "Bank_Account_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            bankAccountEdit.Properties.DataSource = accountsBS;
            bankAccountEdit.Properties.ValueMember = "Id";
            bankAccountEdit.Properties.DisplayMember = "Num";
            bankAccountEdit.Properties.NullText = "Немає данних";

            purposeAccountEdit.DataBindings.Add("EditValue", bankPaymentsBS, "Purpose_Account_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeAccountEdit.Properties.DataSource = accountsBS;
            purposeAccountEdit.Properties.ValueMember = "Id";
            purposeAccountEdit.Properties.DisplayMember = "Num";
            purposeAccountEdit.Properties.NullText = "Немає данних";

            vatAccountEdit.DataBindings.Add("EditValue", bankPaymentsBS, "VatAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            vatAccountEdit.Properties.DataSource = ((IEnumerable<AccountsDTO>)accountsBS.DataSource).Where(a => a.VatMark == 1).ToList();
            vatAccountEdit.Properties.ValueMember = "Id";
            vatAccountEdit.Properties.DisplayMember = "Num";
            vatAccountEdit.Properties.NullText = "Немає данних";

            accountingOperationEdit.DataBindings.Add("EditValue", bankPaymentsBS, "AccountingOperationId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountingOperationEdit.Properties.DataSource = accountingOperationService.GetAccountingOperation();
            accountingOperationEdit.Properties.ValueMember = "Id";
            accountingOperationEdit.Properties.DisplayMember = "Name";
            accountingOperationEdit.Properties.NullText = "Немає данних";

            currencyConvertEdit.DataBindings.Add("EditValue", currencyRatesBS, "Currency_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyConvertEdit.Properties.DataSource = currencyService.GetAllCurrency();
            currencyConvertEdit.Properties.ValueMember = "Id";
            currencyConvertEdit.Properties.DisplayMember = "Code";
            currencyConvertEdit.Properties.NullText = "Немає данних";

            #endregion

            ControlValidation();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's
        
        public Bank_PaymentsDTO Return()
        {
            return ((Bank_PaymentsDTO)Item);
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBank);
        }

        private bool CheckPeriodExist(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }

        private void OpenPeriodAccess(DateTime periodDate)
        {
            try
            {
                periodService = Program.kernel.Get<IPeriodService>();

                if (CheckPeriodAccess(periodDate))
                {
                    PeriodsDTO model = periodService.GetPeriodByKey(periodDate.Year, periodDate.Month);
                    model.StateBank = false;

                    periodService.PeriodsUpdate(model);
                }
                else
                {
                    if (CheckPeriodExist(periodDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(periodDate.Year, periodDate.Month);
                        model.StateBank = true;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        PeriodsDTO model = new PeriodsDTO()
                        {
                            Year = periodDate.Year,
                            Month = periodDate.Month,
                            State = false,
                            StateBank = true,
                            StateBusinesTrip = false
                        };

                        periodService.PeriodsCreate(model);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool SaveItem()
        {
            bool currencyConvertDelete = false;

            this.Item.EndEdit();
            currencyRatesBS.EndEdit();

            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();

            switch (_operation)
            {
                case Utils.Operation.Add:

                    if (convertCheckEdit.Checked && ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id > 1)
                    {
                        ((Currency_RatesDTO)currencyRatesBS.Current).Date = ((Bank_PaymentsDTO)Item).Payment_Date ?? DateTime.Now;
                        int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRatesBS.Current);
                        ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId = currencyRatesId;
                    }

                    ((Bank_PaymentsDTO)Item).DateCreate = DateTime.Now;
                    ((Bank_PaymentsDTO)Item).DateUpdate = DateTime.Now;

                    ((Bank_PaymentsDTO)Item).Id = bankPaymentsService.BankPaymentCreate((Bank_PaymentsDTO)Item);

                    return true;

                case Utils.Operation.Template:

                    if (convertCheckEdit.Checked && ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id > 1)
                    {
                        ((Currency_RatesDTO)currencyRatesBS.Current).Date = ((Bank_PaymentsDTO)Item).Payment_Date ?? DateTime.Now;
                        int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRatesBS.Current);
                        ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId = currencyRatesId;
                    }

                    //((Bank_PaymentsDTO)Item).DateCreate = DateTime.Now;
                    //((Bank_PaymentsDTO)Item).DateUpdate = DateTime.Now;

                    ((Bank_PaymentsDTO)Item).Id = bankPaymentsService.BankPaymentCreate((Bank_PaymentsDTO)Item);

                    return true;

                case Utils.Operation.Update:
                    //currency
                    if (convertCheckEdit.Checked && ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id > 1)
                    {
                        if (((Bank_PaymentsDTO)Item).CurrencyRatesConvertId == null)
                        {
                            int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRatesBS.Current);
                            ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId = currencyRatesId;
                        }
                        else
                        {
                            ((Currency_RatesDTO)currencyRatesBS.Current).Date = ((Bank_PaymentsDTO)Item).Payment_Date ?? DateTime.Now;
                            currencyService.CurrencyRatesUpdate((Currency_RatesDTO)currencyRatesBS.Current);
                        }
                    }
                    else
                    {
                        if (((Bank_PaymentsDTO)Item).CurrencyRatesConvertId != null)
                        {
                            currencyConvertDelete = true;
                        }
                    }

                    if (currencyConvertDelete)
                        ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId = null;

                    bankPaymentsService.BankPaymentUpdate((Bank_PaymentsDTO)Item);

                    if (currencyConvertDelete)
                        currencyService.CurrencyRatesDelete(((Currency_RatesDTO)currencyRatesBS.Current).Id);

                    return true;

                case Utils.Operation.Custom:
                    //create BankPayment          
                    ((Bank_PaymentsDTO)Item).Id = bankPaymentsService.BankPaymentCreate((Bank_PaymentsDTO)Item);

                    //create CalcWithBuyer
                    CalcWithBuyersDTO cwbModel = new CalcWithBuyersDTO()
                    {
                        AccountingOperationId = 1,
                        BalanceAccountId = 120,
                        ContractorsId = -1,
                        DocumentDate = ((Bank_PaymentsDTO)Item).Payment_Date,
                        DocumentName = ((Bank_PaymentsDTO)Item).Payment_Document,
                        Payment = ((Bank_PaymentsDTO)Item).Payment_Price - (((Bank_PaymentsDTO)Item).VatPrice ?? 0.00m),
                        PurposeAccountId = 24,
                        UserId = ((Bank_PaymentsDTO)Item).UserId ?? 0
                    };

                    int cwbId = calcWithBuyersService.CalcWithBuyerCreate(cwbModel);

                    //create CalcWithBuyersSpec
                    CalcWithBuyersSpecDTO cwbsModel = new CalcWithBuyersSpecDTO()
                    {
                        CalcWithBuyerId = cwbId,
                        PaymentPrice = cwbModel.Payment,
                        Quantity = 1,
                        Details = ((Bank_PaymentsDTO)Item).Purpose,
                        PaymentPriceCurrency = 0.00m,
                        DkppId = 9227,
                        UserId = cwbModel.UserId
                    };

                    int cwbsId = calcWithBuyersService.CalcWithBuyerSpecCreate(cwbsModel);

                    //create CalcWithBuyersPaymentVat
                    CalcWithBuyersPaymentVatDTO cwbVatModel = new CalcWithBuyersPaymentVatDTO()
                    {
                        CalcWithBuyerSpecId = cwbsId,
                        VatPayment6412 = (((Bank_PaymentsDTO)Item).VatPrice ?? 0.00m),
                        VatPayment643 = 0.00m
                    };

                    int cwbVatId = calcWithBuyersService.CalcWithBuyersPaymentVatCreate(cwbVatModel);

                    return true;

                case Utils.Operation.Info:
                    //create BankPayment          
                    if (convertCheckEdit.Checked && ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id > 1)
                    {
                        ((Currency_RatesDTO)currencyRatesBS.Current).Date = ((Bank_PaymentsDTO)Item).Payment_Date ?? DateTime.Now;
                        int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRatesBS.Current);
                        ((Bank_PaymentsDTO)Item).CurrencyRatesConvertId = currencyRatesId;
                    }

                    ((Bank_PaymentsDTO)Item).DateCreate = DateTime.Now;
                    ((Bank_PaymentsDTO)Item).DateUpdate = DateTime.Now;

                    ((Bank_PaymentsDTO)Item).Id = bankPaymentsService.BankPaymentCreate((Bank_PaymentsDTO)Item);

                    return true;


                default:
                    return false;
            }
            
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (((Bank_PaymentsDTO)Item).Contractor_Id == null && ((Bank_PaymentsDTO)Item).EmployeesId == null)
            {
                MessageBox.Show("Виберіть контрагента або відповідальну особу.", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (convertCheckEdit.Checked && ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id == 1)
            {
                MessageBox.Show("Не вірно вибрана валюта для конвертації. Змініть найменування валюти.", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (!CheckPeriodAccess(((Bank_PaymentsDTO)Item).Payment_Date ?? DateTime.Now))
                    {
                        if (MessageBox.Show("Період закритий або не існує! Відкрити період?", "Редагування", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            OpenPeriodAccess(((Bank_PaymentsDTO)Item).Payment_Date ?? DateTime.Now);
                        }
                        else
                        {
                            return;
                        }
                    }

                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void contractorsEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Add, new ContractorsDTO()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
                                contractorsEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2: //Редагувати
                    {
                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Update, (ContractorsDTO)contractorsEdit.GetSelectedDataRow()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
                                contractorsEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3: //Поновити
                    {
                        long? currentId = ((ContractorsDTO)contractorsEdit.GetSelectedDataRow()).Id;
                        contractorsService = Program.kernel.Get<IContractorsService>();
                        contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
                        contractorsEdit.EditValue = currentId;
                        break;
                    }
            }
        }
        
        private void vatAccountEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        vatAccountEdit.EditValue = null;
                        break;
                    }
            }
        }

        private void contractorCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (contractorCheckEdit.Checked)
            {
                employeeCheckEdit.Checked = false;
                employeesEdit.Enabled = false;
                employeesEdit.EditValue = null;

                contractorsEdit.Enabled = true;
            }
            else
            {
                contractorsEdit.Enabled = false;
                contractorsEdit.EditValue = null;
            }
        }

        private void employeeCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeCheckEdit.Checked)
            {
                contractorCheckEdit.Checked = false;
                contractorsEdit.Enabled = false;
                contractorsEdit.EditValue = null;

                employeesEdit.Enabled = true;
            }
            else
            {
                employeesEdit.Enabled = false;
                employeesEdit.EditValue = null;
            }
        }

        private void convertCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (convertCheckEdit.Checked)
            {
                currencyConvertEdit.Enabled = true;
                currencyPriceConvertTBox.Enabled = true;
                rateConvertTBox.Enabled = true;
                if (((Currency_RatesDTO)currencyRatesBS.Current).Id == 0)
                {
                    ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id = 1;
                    ((Currency_RatesDTO)currencyRatesBS.Current).CurrencyPayment = 0.00m;
                    ((Currency_RatesDTO)currencyRatesBS.Current).Rate = 0.000000m;
                }
            }
            else
            {
                currencyConvertEdit.Enabled = false;
                currencyPriceConvertTBox.Enabled = false;
                rateConvertTBox.Enabled = false;

                ((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id = 1;
                ((Currency_RatesDTO)currencyRatesBS.Current).CurrencyPayment = 0.00m;
                ((Currency_RatesDTO)currencyRatesBS.Current).Rate = 0.000000m;
            }
        }

        private void purposeAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }
        
        private void bankAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void vatAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void accountingOperationEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        #endregion

        #region Validation

        private bool ControlValidation()
        {
            return bankPaymentsValidationProvider.Validate();
        }

        private void paymentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            bankPaymentsValidationProvider.Validate((Control)sender);
        }

        private void paymentDocumentTBox_EditValueChanged(object sender, EventArgs e)
        {
            bankPaymentsValidationProvider.Validate((Control)sender);
        }

        private void bankAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            bankPaymentsValidationProvider.Validate((Control)sender);
        }

        private void purposeAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            bankPaymentsValidationProvider.Validate((Control)sender);
        }

        private void bankPaymentsValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void bankPaymentsValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (bankPaymentsValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }




        #endregion

        private void accountingOperationEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void accountingOperationEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (_operation == Utils.Operation.Info && (int)purposeAccountEdit.EditValue!=26)
            {
                if (((Bank_PaymentsDTO)Item).AccountingOperationId == 1)
                    purposeAccountEdit.EditValue = 42;
                else
                    purposeAccountEdit.EditValue = 41;
            }
        }
    }
}