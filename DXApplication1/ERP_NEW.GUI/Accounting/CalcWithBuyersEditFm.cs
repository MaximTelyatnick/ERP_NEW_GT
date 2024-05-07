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
    public partial class CalcWithBuyersEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICalcWithBuyersService calcWithBuyersService;
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        private IContractorsService contractorsService;
        private ICurrencyService currencyService;
        private IPeriodService periodService;
        private IAccountingOperationService accountingOperationService;
        private ILogService logService;

        private const string NameForm = "CalcWithBuyersEditFmFm";

        private BindingSource calcWithBuyersBS = new BindingSource();
        private BindingSource calcWithBuyersSpecBS = new BindingSource();
        private BindingSource currencyRatesBS = new BindingSource();
        private BindingSource accountsBS = new BindingSource();
        private BindingSource specificationBS = new BindingSource();
        private BindingSource customerOrdersForCWBBS = new BindingSource();

        private List<CalcWithBuyersSpecDTO> specificationList = new List<CalcWithBuyersSpecDTO>();
        private List<CalcWithBuyersSpecDTO> specificationDeleteList = new List<CalcWithBuyersSpecDTO>();
        private List<CustomerOrdersForCWBDTO> customerOrderDeleteList = new List<CustomerOrdersForCWBDTO>();

        private Utils.Operation _operation;
        private UserTasksDTO userTasksDTO;

        private ObjectBase Item
        {
            get { return calcWithBuyersBS.Current as ObjectBase; }
            set
            {
                calcWithBuyersBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CalcWithBuyersEditFm(Utils.Operation operation, CalcWithBuyersDTO model, List<CalcWithBuyersSpecDTO> source, UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            _operation = operation;
            specificationList = source;
            specificationBS.DataSource = specificationList;

            calcWithBuyersBS.DataSource = Item = model;

            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            accountingOperationService = Program.kernel.Get<IAccountingOperationService>();
            logService = Program.kernel.Get<ILogService>();

            if (_operation == Utils.Operation.Add)
            {
                ((CalcWithBuyersDTO)Item).DocumentDate = DateTime.Now;
                ((CalcWithBuyersDTO)Item).AccountingOperationId = 1;

                contractorsEdit.Enabled = false;
                employeesEdit.Enabled = false;

                customerOrdersForCWBBS.DataSource = new List<CustomerOrdersForCWBDTO>();
                customerOrdersGrid.DataSource = customerOrdersForCWBBS;
            }
            else
            {
                contractorCheckEdit.Checked = (((CalcWithBuyersDTO)Item).ContractorsId > 0) ? true : false;
                employeeCheckEdit.Checked = (((CalcWithBuyersDTO)Item).EmployeesId > 0) ? true : false;

                customerOrdersForCWBBS.DataSource = calcWithBuyersService.GetCustomerOrdersByCWBId(((CalcWithBuyersDTO)Item).Id);
                customerOrdersGrid.DataSource = customerOrdersForCWBBS;
            }

            currencyRatesBS.DataSource = ((CalcWithBuyersDTO)Item).CurrencyRatesId == null ?
                new Currency_RatesDTO() { Currency_Id = 1, Multiplicity = 1 } :
                currencyService.GetCurrencyRates().Where(s => s.Id == ((CalcWithBuyersDTO)Item).CurrencyRatesId).SingleOrDefault();

            accountsBS.DataSource = accountsService.GetAccounts();
            
            documentDateEdit.DataBindings.Add("EditValue", calcWithBuyersBS, "DocumentDate", true, DataSourceUpdateMode.OnPropertyChanged);
            documentNameTBox.DataBindings.Add("EditValue", calcWithBuyersBS, "DocumentName");
            paymentTBox.DataBindings.Add("EditValue", calcWithBuyersBS, "Payment", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyPaymentTBox.DataBindings.Add("EditValue", currencyRatesBS, "CurrencyPayment", true, DataSourceUpdateMode.OnPropertyChanged);
            rateTBox.DataBindings.Add("EditValue", currencyRatesBS, "Rate", true, DataSourceUpdateMode.OnPropertyChanged);
            
            employeesEdit.DataBindings.Add("EditValue", calcWithBuyersBS, "EmployeesId", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesEdit.Properties.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "FullName";
            employeesEdit.Properties.NullText = "Немає данних";

            contractorsEdit.DataBindings.Add("EditValue", calcWithBuyersBS, "ContractorsId", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            balanceAccountEdit.DataBindings.Add("EditValue", calcWithBuyersBS, "BalanceAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceAccountEdit.Properties.DataSource = accountsBS;
            balanceAccountEdit.Properties.ValueMember = "Id";
            balanceAccountEdit.Properties.DisplayMember = "Num";
            balanceAccountEdit.Properties.NullText = "Немає данних";

            purposeAccountEdit.DataBindings.Add("EditValue", calcWithBuyersBS, "PurposeAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeAccountEdit.Properties.DataSource = accountsBS;
            purposeAccountEdit.Properties.ValueMember = "Id";
            purposeAccountEdit.Properties.DisplayMember = "Num";
            purposeAccountEdit.Properties.NullText = "Немає данних";

            accountingOperationEdit.DataBindings.Add("EditValue", calcWithBuyersBS, "AccountingOperationId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountingOperationEdit.Properties.DataSource = accountingOperationService.GetAccountingOperation();
            accountingOperationEdit.Properties.ValueMember = "Id";
            accountingOperationEdit.Properties.DisplayMember = "Name";
            accountingOperationEdit.Properties.NullText = "Немає данних";
            
            currencyEdit.DataBindings.Add("EditValue", currencyRatesBS, "Currency_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyService.GetCurrency();
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Code";
            currencyEdit.Properties.NullText = "Немає данних";

            vatPriceTBox.EditValue = (_operation == Utils.Operation.Add) ? 0 : CalculateVatSum();

            calcWithBuyersSpecGrid.DataSource = specificationBS;

            ControlValidation();

            splashScreenManager.CloseWaitForm();
        }

        #region Method's

        private decimal CalculateVatSum()
        {
            return specificationList.Sum(s => s.VatSum) ?? 0;
        }

        private decimal CalculatePriceSum()
        {
            return specificationList.Sum(s => s.PaymentPrice) ?? 0;
        }

        private decimal CalculatePriceCurrencySum()
        {
            return specificationList.Sum(s => s.PaymentPriceCurrency) ?? 0;
        }

        public CalcWithBuyersDTO Return()
        {
            return ((CalcWithBuyersDTO)Item);
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
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTasksDTO, NameForm);
                return;
            }
        }

        private bool SaveItem()
        {
            bool currencyRateDelete = false;
            
            this.Item.EndEdit();
            currencyRatesBS.EndEdit();

            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
            currencyService = Program.kernel.Get<ICurrencyService>();

            if (_operation == Utils.Operation.Add)
            {
                if (((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id > 1)
                {
                    int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRatesBS.Current);
                    ((CalcWithBuyersDTO)Item).CurrencyRatesId = currencyRatesId;
                }
                                
                ((CalcWithBuyersDTO)Item).Id = calcWithBuyersService.CalcWithBuyerCreate((CalcWithBuyersDTO)Item);

                //add specification
                specificationList.Select(s => { s.CalcWithBuyerId = ((CalcWithBuyersDTO)Item).Id; s.UserId = ((CalcWithBuyersDTO)Item).UserId; return s; }).ToList();
                
                foreach (var item in specificationList)
                {
                    int curSpecId = calcWithBuyersService.CalcWithBuyerSpecCreate(item);

                    if (item.VatPayment6412 > 0 || item.VatPayment643 > 0)
                    {
                        CalcWithBuyersPaymentVatDTO vatModel = new CalcWithBuyersPaymentVatDTO() 
                        { 
                            CalcWithBuyerSpecId = curSpecId, 
                            VatPayment6412 = item.VatPayment6412, 
                            VatPayment643 = item.VatPayment643 
                        };

                        calcWithBuyersService.CalcWithBuyersPaymentVatCreate(vatModel);
                    }
                }
                
                //add customerorders
                List<CustomerOrdersForCWBDTO> itemList = ((List<CustomerOrdersForCWBDTO>)customerOrdersForCWBBS.DataSource).Select(s => { s.CalcWithBuyerId = ((CalcWithBuyersDTO)Item).Id; return s; }).ToList();

                foreach (var item in itemList)
                {
                    calcWithBuyersService.CustomerOrdersForCWBCreate(item);
                }

                return true;
            }
            else
            {
                //currency
                if (((Currency_RatesDTO)currencyRatesBS.Current).Currency_Id > 1)
                {
                    if (((CalcWithBuyersDTO)Item).CurrencyRatesId == null)
                    {
                        int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRatesBS.Current);
                        ((CalcWithBuyersDTO)Item).CurrencyRatesId = currencyRatesId;
                    }
                    else
                    {
                        currencyService.CurrencyRatesUpdate((Currency_RatesDTO)currencyRatesBS.Current);
                    }
                }
                else
                {
                    if (((CalcWithBuyersDTO)Item).CurrencyRatesId != null)
                    {
                        currencyRateDelete = true;
                    }
                }
                                

                if (currencyRateDelete)
                    ((CalcWithBuyersDTO)Item).CurrencyRatesId = null;
                
                calcWithBuyersService.CalcWithBuyerUpdate((CalcWithBuyersDTO)Item);

                //add update specification
                specificationList.Select(s => { s.CalcWithBuyerId = ((CalcWithBuyersDTO)Item).Id; s.UserId = ((CalcWithBuyersDTO)Item).UserId; return s; }).ToList();

                foreach (var item in specificationList)
                {
                    if (item.Id == 0)
                    {
                        int curSpecId = calcWithBuyersService.CalcWithBuyerSpecCreate(item);

                        if (item.VatPayment6412 > 0 || item.VatPayment643 > 0 || item.VatPayment6412 < 0 || item.VatPayment643 < 0)
                        {
                            CalcWithBuyersPaymentVatDTO vatModel = new CalcWithBuyersPaymentVatDTO()
                            {
                                CalcWithBuyerSpecId = curSpecId,
                                VatPayment6412 = item.VatPayment6412,
                                VatPayment643 = item.VatPayment643
                            };

                            calcWithBuyersService.CalcWithBuyersPaymentVatCreate(vatModel);
                        }
                    }
                    else
                    {
                        calcWithBuyersService.CalcWithBuyerSpecUpdate(item);

                        if (item.CalcWithBuyersPaymentVatId == null)
                        {
                            if (item.VatPayment6412 > 0 || item.VatPayment643 > 0 || item.VatPayment6412 < 0 || item.VatPayment643 < 0)
                            {
                                CalcWithBuyersPaymentVatDTO vatModel = new CalcWithBuyersPaymentVatDTO()
                                {
                                    CalcWithBuyerSpecId = item.Id,
                                    VatPayment6412 = item.VatPayment6412,
                                    VatPayment643 = item.VatPayment643
                                };

                                calcWithBuyersService.CalcWithBuyersPaymentVatCreate(vatModel);
                            }
                        }
                        else
                        {
                            if (item.VatPayment6412 > 0 || item.VatPayment643 > 0 || item.VatPayment6412 < 0 || item.VatPayment643 < 0)
                            {
                                CalcWithBuyersPaymentVatDTO vatModel = new CalcWithBuyersPaymentVatDTO()
                                {
                                    Id = item.CalcWithBuyersPaymentVatId ?? 0,
                                    CalcWithBuyerSpecId = item.Id,
                                    VatPayment6412 = item.VatPayment6412,
                                    VatPayment643 = item.VatPayment643
                                };

                                calcWithBuyersService.CalcWithBuyersPaymentVatUpdate(vatModel);
                            }
                            else if (item.VatPayment643 == 0 && item.VatPayment6412 == 0)
                            {
                                calcWithBuyersService.CalcWithBuyersPaymentVatDelete(item.CalcWithBuyersPaymentVatId ?? 0);
                            }
                        }
                    }
                }

                specificationDeleteList = specificationDeleteList.Where(w => w.Id != 0).ToList();

                if (specificationDeleteList.Count > 0)
                {
                    calcWithBuyersService.CalcWithBuyerSpecRemoveRange(specificationDeleteList);
                }
                
                //currencyrates
                if (currencyRateDelete)
                    currencyService.CurrencyRatesDelete(((Currency_RatesDTO)currencyRatesBS.Current).Id);
                
                //customerorders
                List<CustomerOrdersForCWBDTO> itemList = ((List<CustomerOrdersForCWBDTO>)customerOrdersForCWBBS.DataSource).Where(w => w.Id == 0).Select(s => { s.CalcWithBuyerId = ((CalcWithBuyersDTO)Item).Id; return s; }).ToList();
                
                if (itemList.Count > 0)
                {
                    foreach (var item in itemList)
                    {
                        calcWithBuyersService.CustomerOrdersForCWBCreate(item);
                    }
                }

                if (customerOrderDeleteList.Count > 0)
                {
                    foreach (var item in customerOrderDeleteList)
                    {
                        calcWithBuyersService.CustomerOrdersForCWBDelete(item.Id);
                    }
                }

                return true;
            }
        }

        private void EditSpecification(Utils.Operation operation, CalcWithBuyersSpecDTO model, List<CustomerOrdersForCWBDTO> customerOrderSource)
        {
            using (CalcWithBuyersSpecEditFm calcWithBuyersSpecEditFm = new CalcWithBuyersSpecEditFm(operation, model, customerOrderSource))
            {
                if (calcWithBuyersSpecEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnModel = calcWithBuyersSpecEditFm.Return();

                    calcWithBuyersSpecGridView.BeginDataUpdate();

                    if (operation == Utils.Operation.Add)
                    {
                        specificationBS.Add(returnModel);
                        calcWithBuyersSpecGrid.DataSource = specificationBS;
                    }
                    else
                    {
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).PaymentPrice = returnModel.PaymentPrice;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).SpecificationName = returnModel.SpecificationName;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).CustomerOrderSpecId = returnModel.CustomerOrderSpecId;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).Quantity = returnModel.Quantity;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).Details = returnModel.Details;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).PaymentPriceCurrency = returnModel.PaymentPriceCurrency;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).CpvId = returnModel.CpvId;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).CpvCode = returnModel.CpvCode;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).DkppId = returnModel.DkppId;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).DkppCode = returnModel.DkppCode;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).UktvId = returnModel.UktvId;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).UktvCode = returnModel.UktvCode;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).CalcWithBuyersPaymentVatId = returnModel.CalcWithBuyersPaymentVatId;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).VatPayment6412 = returnModel.VatPayment6412;
                        ((CalcWithBuyersSpecDTO)specificationBS.Current).VatPayment643 = returnModel.VatPayment643;
                    }

                    specificationBS.EndEdit();
                    specificationBS.ResetCurrentItem();
                    calcWithBuyersSpecGridView.BeginSummaryUpdate();
                    calcWithBuyersSpecGridView.EndSummaryUpdate();

                    calcWithBuyersSpecGridView.EndDataUpdate();

                    vatPriceTBox.EditValue = CalculateVatSum();
                    paymentTBox.EditValue = CalculatePriceSum();
                    currencyPaymentTBox.EditValue = CalculatePriceCurrencySum();
                }
            }
        }

        #endregion

        #region Event's
                
        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditSpecification(Utils.Operation.Add, new CalcWithBuyersSpecDTO(), ((customerOrdersForCWBBS.Count == 0) ? new List<CustomerOrdersForCWBDTO>() : ((List<CustomerOrdersForCWBDTO>)customerOrdersForCWBBS.DataSource)));
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (specificationBS.Count > 0)
            {
                EditSpecification(Utils.Operation.Update, (CalcWithBuyersSpecDTO)specificationBS.Current, ((customerOrdersForCWBBS.Count == 0) ? new List<CustomerOrdersForCWBDTO>() : ((List<CustomerOrdersForCWBDTO>)customerOrdersForCWBBS.DataSource)));
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (specificationBS.Count > 0)
            {
                calcWithBuyersSpecGridView.PostEditor();

                calcWithBuyersSpecGridView.BeginDataUpdate();

                var checkItems = specificationList.Where(t => t.Selected && t.Id != 0).ToList();

                specificationDeleteList.AddRange(checkItems);
                specificationList.RemoveAll(s => s.Selected);

                specificationBS.DataSource = specificationList;
                calcWithBuyersSpecGrid.DataSource = specificationBS;

                calcWithBuyersSpecGridView.EndDataUpdate();

                vatPriceTBox.EditValue = CalculateVatSum();
                paymentTBox.EditValue = CalculatePriceSum();
                currencyPaymentTBox.EditValue = CalculatePriceCurrencySum();
            }
        }

        private void calcWithBuyersSpecGridView_DoubleClick(object sender, EventArgs e)
        {
            if (specificationBS.Count > 0)
            {
                EditSpecification(Utils.Operation.Update, (CalcWithBuyersSpecDTO)specificationBS.Current, ((customerOrdersForCWBBS.Count == 0) ? new List<CustomerOrdersForCWBDTO>() : ((List<CustomerOrdersForCWBDTO>)customerOrdersForCWBBS.DataSource)));
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (specificationList.Count == 0)
            {
                MessageBox.Show("До документу не додана специфікація.", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Item.EndEdit();

            if (((CalcWithBuyersDTO)Item).ContractorsId == null && ((CalcWithBuyersDTO)Item).EmployeesId == null)
            {
                MessageBox.Show("Виберіть контрагента або відповідальну особу.", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (!CheckPeriodAccess(((CalcWithBuyersDTO)Item).DocumentDate ?? DateTime.Now))
                    {
                        if (MessageBox.Show("Період закритий або не існує! Відкрити період?", "Редагування", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            OpenPeriodAccess(((CalcWithBuyersDTO)Item).DocumentDate ?? DateTime.Now);
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
                    logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTasksDTO, NameForm);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (CalcWithBuyersCustomerOrdersEditFm calcWithBuyersCustomerOrdersEditFm = new CalcWithBuyersCustomerOrdersEditFm())
            {
                if (calcWithBuyersCustomerOrdersEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnModel = calcWithBuyersCustomerOrdersEditFm.Return();

                    customerOrdersGridView.BeginDataUpdate();

                    customerOrdersForCWBBS.Add(new CustomerOrdersForCWBDTO()
                    {
                        CustomerOrderId = returnModel.Id,
                        CustomerOrderDate = returnModel.OrderDate,
                        CustomerOrderNumber = returnModel.OrderNumber,
                    });

                    customerOrdersGrid.DataSource = customerOrdersForCWBBS;
                    
                    customerOrdersGridView.EndDataUpdate();
                }
            }
        }

        private void deleteOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerOrdersForCWBBS.Count > 0)
            {
                calcWithBuyersSpecGridView.BeginDataUpdate();

                //delete from SpecificationList where exist customerOrderId 
                var checkItems = specificationList.Where(t => t.CustomerOrderId == ((CustomerOrdersForCWBDTO)customerOrdersForCWBBS.Current).CustomerOrderId).ToList();

                specificationDeleteList.AddRange(checkItems);
                specificationList.RemoveAll(s => s.CustomerOrderId == ((CustomerOrdersForCWBDTO)customerOrdersForCWBBS.Current).CustomerOrderId);

                specificationBS.DataSource = specificationList;
                calcWithBuyersSpecGrid.DataSource = specificationBS;
                
                vatPriceTBox.EditValue = CalculateVatSum();
                paymentTBox.EditValue = CalculatePriceSum();
                currencyPaymentTBox.EditValue = CalculatePriceCurrencySum();

                calcWithBuyersSpecGridView.EndDataUpdate();

                //delete from CustomerOrderList
                customerOrdersGridView.BeginDataUpdate();

                if (((CustomerOrdersForCWBDTO)customerOrdersForCWBBS.Current).Id != 0)
                    customerOrderDeleteList.Add((CustomerOrdersForCWBDTO)customerOrdersForCWBBS.Current);

                customerOrdersForCWBBS.RemoveCurrent();

                customerOrdersGridView.EndDataUpdate();

            }
        }

        private void balanceAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void purposeAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
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

        #endregion

        #region Validation

        private bool ControlValidation()
        {
            return calcWithBuyersValidationProvider.Validate();
        }
        
        private void documentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            calcWithBuyersValidationProvider.Validate((Control)sender);
        }

        private void balanceAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            calcWithBuyersValidationProvider.Validate((Control)sender);
        }

        private void purposeAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            calcWithBuyersValidationProvider.Validate((Control)sender);
        }

        private void calcWithBuyersValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void calcWithBuyersValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (calcWithBuyersValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

    }
}