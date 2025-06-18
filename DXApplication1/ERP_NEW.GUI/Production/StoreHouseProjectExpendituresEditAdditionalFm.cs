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
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Production
{
    public partial class StoreHouseProjectExpendituresEditAdditionalFm : DevExpress.XtraEditors.XtraForm
    {

        private DateTime searchDate;
        private IStoreHouseService storeHouseService;
        private ICustomerOrdersService customerOrdersService;
        private IPeriodService periodService;
        private IEmployeesService employeesService;
        private ICurrencyService currencyService;

        private decimal? customerOrderCurrencyRate;

        private BindingSource storeHouseReceiptProjectBS = new BindingSource();
        private BindingSource expenditureBS = new BindingSource();
        private BindingSource expenditureAllBS = new BindingSource();
        private BindingSource remainsBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();
        private BindingSource expendituresBS = new BindingSource();

        private Utils.Operation operation;
        private UserTasksDTO userTasksDTO;

        private bool limitActive = false;
        private bool enableOrderActive = false;

        private decimal expQuantity = 0.000000m;
        private decimal expPrice = 0.00m;

        private decimal expQuantityGeneral = 0.000000m;
        //private decimal expPriceGeneral = 0.00m;

        private DateTime beginDate, endDate;

        private List<NomenclaturesDTO> nomenclatureSearch = new List<NomenclaturesDTO>();
        private List<ExpedinturesAccountantDTO> expenditureStoreHouseList = new List<ExpedinturesAccountantDTO>();
        private List<ExpenditureInfoDTO> expenditureStoreHouseInfoList = new List<ExpenditureInfoDTO>();

        private LoggerInfo loger = new LoggerInfo();

        private ObjectBase Item
        {
            get { return expenditureBS.Current as ObjectBase; }
            set
            {
                expenditureBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public StoreHouseProjectExpendituresEditAdditionalFm(ExpedinturesAccountantDTO model, Utils.Operation operation, UserTasksDTO userTasksDTO, DateTime beginDate, DateTime endDate)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;
            this.beginDate = beginDate;
            this.endDate = endDate;
            this.operation = operation;

            expenditureBS.DataSource = Item = model;
            searchDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            if (operation == Utils.Operation.Add)
            {
                ((ExpedinturesAccountantDTO)expenditureBS.Current).PRICE = 0.000000m;
                ((ExpedinturesAccountantDTO)expenditureBS.Current).QUANTITY = 0.00000m;
                //((ExpedinturesAccountantDTO)expenditureBS.Current).PROJECT_NUM = "";
                //((ExpendituresStoreHousesDTO)expenditureBS.Current).Quantity = 0.00000m;
                //((ExpendituresStoreHousesDTO)expenditureBS.Current).CustomerOrderId = null;

                model.RealExpDate = DateTime.Now;
                model.EXP_DATE = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            }

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            employeesService = Program.kernel.Get<IEmployeesService>();

            expenditureDateEdit.DataBindings.Add("EditValue", expenditureBS, "RealExpDate", true, DataSourceUpdateMode.OnPropertyChanged);
            orderNumberEdit.DataBindings.Add("EditValue", expenditureBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesEdit.DataBindings.Add("EditValue", expenditureBS, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);
            measureEdit.DataBindings.Add("EditValue", expenditureBS, "UnitLocalName", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureEdit.DataBindings.Add("EditValue", expenditureBS, "Nomenclature", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureNameEdit.DataBindings.Add("EditValue", expenditureBS, "NomenclatureName", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", expenditureBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            sumEdit.DataBindings.Add("EditValue", expenditureBS, "PRICE", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceNumEdit.DataBindings.Add("EditValue", expenditureBS, "BalanceAccountNum", true, DataSourceUpdateMode.OnPropertyChanged);

            orderNumberEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = null;

            //orderNumberHistoryEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            //orderNumberEdit.Properties.ValueMember = "Id";
            //orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            //orderNumberEdit.Properties.NullText = null;

            employeesEdit.Properties.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "Fio";
            employeesEdit.Properties.NullText = null;

            LoadExpendituresProjectJournalByPeriod(beginDate, endDate);

            infoTabControl.TabPages[0].Text +=" "+orderNumberEdit.Text==""?orderNumberEdit.Text:"0" +" за період:"+ beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();
            infoTabControl.TabPages[1].Text += beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();
        }

        #region Method's

        private void SetPeriodBtnImage()
        {
            periodService = Program.kernel.Get<IPeriodService>();
            if (expenditureDateEdit.EditValue != null && !DBNull.Value.Equals(expenditureDateEdit.EditValue))
            {
                periodEditBtn.Enabled = true;
                if (periodService.CheckPeriodAccess((DateTime)expenditureDateEdit.EditValue))
                    periodEditBtn.Image = imageCollection.Images[1];
                else
                    periodEditBtn.Image = imageCollection.Images[0];
            }
            else
            {
                periodEditBtn.Enabled = false;
            }

        }

        public ExpedinturesAccountantDTO Return()
        {
            return ((ExpedinturesAccountantDTO)Item);
        }

        ////private void CheckNomenclature(string Nomenclature)
        ////{
        ////    storeHouseService = Program.kernel.Get<IStoreHouseService>();

        ////    nomenclatureSearch = storeHouseService.GetNomenclatureWithAccountNumber(Nomenclature).ToList();

        ////    if (nomenclatureSearch.Count != 0)
        ////    {
        ////        LoadReceipts((DateTime)searchDate, nomenclatureSearch.FirstOrDefault());
        ////    }
        ////    else
        ////    {
        ////        ClearNomenclature();
        ////        nomenclatureEdit.Focus();
        ////        MessageBox.Show("Номенклатура відсутня в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ////    }
        ////    DialogResult = DialogResult.None;
        ////}

        private void CheckNomenclature(string Nomenclature)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            //loger.Info("Номенклатура: " + Nomenclature);
            nomenclatureSearch = storeHouseService.GetNomenclatureWithAccountNumber(Nomenclature).ToList();

            if (nomenclatureSearch.Count != 0)
            {
                LoadReceipts(((ExpedinturesAccountantDTO)Item).EXP_DATE, nomenclatureSearch.FirstOrDefault());
            }
            else
            {
                ClearNomenclature();
                nomenclatureEdit.Focus();
                MessageBox.Show("Номенклатура відсутня в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult = DialogResult.None;
        }



        //private void LoadReceipts(DateTime beginDate, NomenclaturesDTO nomenclatureDTO)
        //{
        //    splashScreenManager.ShowWaitForm();

        //    storeHouseService = Program.kernel.Get<IStoreHouseService>();

        //    storeHouseReceiptProjectBS.DataSource = storeHouseService.GetStoreHouseReceiptProject(beginDate).Where(srch => srch.Nomenclature == nomenclatureDTO.Nomenclature).ToList();

        //    if (storeHouseReceiptProjectBS.Count > 0)
        //    {
        //        Item.BeginEdit();

        //        ((ExpendituresStoreHousesDTO)Item).NomenclatureName = nomenclatureDTO.Name;
        //        ((ExpendituresStoreHousesDTO)Item).Nomenclature = nomenclatureDTO.Nomenclature;
        //        ((ExpendituresStoreHousesDTO)Item).UnitLocalName = nomenclatureDTO.UnitLocalName;
        //        ((ExpendituresStoreHousesDTO)Item).UnitId = nomenclatureDTO.UnitId;
        //        ((ExpendituresStoreHousesDTO)Item).BalanceAccountId = nomenclatureDTO.BALANCE_ACCOUNT_ID;
        //        ((ExpendituresStoreHousesDTO)Item).BalanceAccountNum = nomenclatureDTO.Num;
        //        ((ExpendituresStoreHousesDTO)Item).NomenclatureId = nomenclatureDTO.ID;

        //        Item.EndEdit();

        //        storeHouseProjectGrid.DataSource = storeHouseReceiptProjectBS;
        //        expenditureBS.ResetBindings(true);
        //        splashScreenManager.CloseWaitForm();
        //        storeHouseReceiptProjectBS.ResetBindings(true);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Матеріал повністю витрачено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        ClearNomenclature();

        //        nomenclatureEdit.Focus();
        //        splashScreenManager.CloseWaitForm();
        //    }
        //}


        public void LoadReceipts(DateTime? expedintureDate, NomenclaturesDTO nomenclatureDTO)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            remainsBS.DataSource = storeHouseService.GetRemainsByNomenclatureId(nomenclatureDTO.ID, expedintureDate.GetValueOrDefault(DateTime.Now));
            if (remainsBS.Count > 0)
            {
                Item.BeginEdit();

                ((ExpedinturesAccountantDTO)Item).NomenclatureName = nomenclatureDTO.Name;
                ((ExpedinturesAccountantDTO)Item).Nomenclature = nomenclatureDTO.Nomenclature;
                ((ExpedinturesAccountantDTO)Item).UnitLocalName = nomenclatureDTO.UnitLocalName;
                ((ExpedinturesAccountantDTO)Item).UnitId = nomenclatureDTO.UnitId;
                ((ExpedinturesAccountantDTO)Item).BalanceAccountId = nomenclatureDTO.BALANCE_ACCOUNT_ID;
                ((ExpedinturesAccountantDTO)Item).BalanceAccountNum = nomenclatureDTO.Num;
                ((ExpedinturesAccountantDTO)Item).NomenclatureGroupId = nomenclatureDTO.Nomencl_Group_Id;
                ((ExpedinturesAccountantDTO)Item).NomenclatureId = nomenclatureDTO.ID;
                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = ((ExpedinturesAccountantDTO)Item).PROJECT_NUM == "0" ? "0" : ((ExpedinturesAccountantDTO)Item).PROJECT_NUM;

                Item.EndEdit();

                storeHouseProjectGrid.DataSource = remainsBS;

                expenditureBS.ResetBindings(true);

                //splashScreenManager.CloseWaitForm();
                remainsBS.ResetBindings(true);

                //GridControlShow(false);

                //quantityEdit.ReadOnly = true;
                //sumEdit.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Матеріал повністю витрачено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearNomenclature();

                nomenclatureEdit.Focus();

                
            }

            splashScreenManager.CloseWaitForm();
        }

        private void GridControlShow(bool flag)
        {
            storeHouseProjectGridView.OptionsView.ShowIndicator = flag;
            storeHouseProjectGridView.OptionsSelection.EnableAppearanceFocusedCell = flag;
            storeHouseProjectGridView.OptionsSelection.EnableAppearanceFocusedRow = flag;
            storeHouseProjectGridView.OptionsSelection.EnableAppearanceHideSelection = flag;
        }

        private List<ExpedinturesAccountantDTO> ConvertToExpenditureList(List<ExpenditureInfoDTO> convertList)
        {
            List<ExpedinturesAccountantDTO> expenditurestorehousereturnlist = new List<ExpedinturesAccountantDTO>();
            foreach (var item in convertList)
            {
                expenditurestorehousereturnlist.Add(new ExpedinturesAccountantDTO()
                {
                    ID = item.Id,
                    BalanceAccountId = item.BalanceAccountId,
                    BalanceAccountNum = item.BalanceAccountNum,
                    CustomerOrderId = item.CustomerOrderId,
                    CustomerOrderNumber = item.CustomerOrderNumber,
                    EmployeeId = item.EmployeeId,
                    ExpenditureType = item.ExpenditureType,
                    ExpenditureCheckDate = item.ExpenditureCheckDate,
                    CREDIT_ACCOUNT_ID = (int?)item.CreditAccountId,

                    EXP_DATE = item.ExpDate,
                    Nomenclature = item.Nomenclature,
                    NomenclatureName = item.Name,
                    PRICE = (decimal)item.TotalPrice,
                    ProdCustomerOrderId = item.ProdCustomerOrderId,
                    PROJECT_NUM = item.ProjectNum,
                    QUANTITY = (decimal)item.Quantity,
                    RECEIPT_ID = item.ReceiptId,
                    UnitLocalName = item.UnitLocalName,
                    UserId = item.UserId,
                    ReceiptNum = item.ReceiptNum,
                    RealExpDate = item.RealExpDate,
                    ProdCustomerNumber = item.ProdCustomerNumber


                    //id = item.id,
                    //balanceaccountid = item.balanceaccountid,
                    //balanceaccountnum = item.balanceaccountnum,
                    //customerorderid = item.customerorderid,
                    //customerordernumber = item.customerordernumber,
                    //employeeid = item.employeeid,
                    //check = item.check,
                    //expdate = item.expdate,
                    //expenditureaccountdate = item.expenditureaccountdate,
                    //expenditureid = item.expenditureid,
                    //expendituresquantity = item.expendituresquantity,
                    //nomenclature = item.nomenclature,
                    //nomenclatureid = item.nomenclatureid,
                    //nomenclaturename = item.nomenclaturename,
                    //price = item.price,
                    //quantity = item.quantity,
                    //receiptdate = item.receiptdate,
                    //receiptid = item.receiptid,
                    //receiptnum = item.receiptnum,
                    //unitid = item.unitid,
                    //unitlocalname = item.unitlocalname,
                    //expenditurecustomerorder = item.expenditurecustomerorder

                });
            }
            return expenditurestorehousereturnlist;
        }

        private void LoadExpendituresProjectJournalByPeriod(DateTime beginDate, DateTime endDate)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            periodService = Program.kernel.Get<IPeriodService>();

            splashScreenManager.ShowWaitForm();

            //expenditureStoreHouseInfoList = storeHouseService.GetExpendituresStoreHousesInfoByPeriod(beginDate, endDate).ToList();
            expenditureStoreHouseInfoList = storeHouseService.GetExpenditureJournalByPeriod(beginDate, endDate).Where(srch => srch.ExpenditureType == true).OrderByDescending(ord => ord.Id).ToList();
            expenditureStoreHouseList = ConvertToExpenditureList(expenditureStoreHouseInfoList);
            expendituresBS.DataSource = expenditureStoreHouseList;
            expenditureFullGrid.DataSource = expendituresBS;

            expenditureFullGridView.ExpandAllGroups();
            splashScreenManager.CloseWaitForm();
        }

        private void ClearNomenclature()
        {

            Item.BeginEdit();
            ((ExpedinturesAccountantDTO)Item).BalanceAccountNum = "";
            Item.EndEdit();

            expenditureBS.ResetBindings(true);
        }

        //private void LoadDetaExpenditureByCustomerOrder(DateTime beginDate, DateTime endDate, int? customerOrderId)
        //{
        //    splashScreenManager.ShowWaitForm();
        //    storeHouseService = Program.kernel.Get<IStoreHouseService>();

        //    expenditureAllBS.DataSource = storeHouseService.GetExpendituresStoreHousesByPeriod(beginDate, endDate).Where(bdsm => bdsm.CustomerOrderId == customerOrderId).OrderByDescending(sort => sort.Id).ToList();
        //    expendituresGrid.DataSource = expenditureAllBS;

        //    splashScreenManager.CloseWaitForm();
        //}

        private void LoadDetaExpenditureByCustomerOrder(DateTime beginDate, DateTime endDate, int? customerOrderId)
        {          
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            try
            {
                //splashScreenManager.ShowWaitForm();

                var expenditureAllForProduction = storeHouseService.GetExpenditureJournalByPeriod(beginDate, endDate).Where(bdsm => bdsm.CustomerOrderId == customerOrderId && bdsm.ExpenditureType == true).OrderByDescending(sort => sort.Id).ToList();
                expenditureAllBS.DataSource = expenditureAllForProduction;
                expendituresGrid.DataSource = expenditureAllBS;
            }
            catch (Exception)
            {
            }
            finally
            {
                //splashScreenManager.CloseWaitForm();
            }       
        }


        private void LoadDataExpenditureTotalPrice(int? customerOrderId)
        {
            //splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            currencyService = Program.kernel.Get<ICurrencyService>();

            Decimal expenditurePercentTotalPrice = 0;

            ExpenditureTotalPriceDTO expenditureTotalPrice = storeHouseService.GetExpenditureAccTotalPriceByCustomerOrderId((int)customerOrderId).FirstOrDefault();
            if (expenditureTotalPrice != null)
            {
                if (expenditureTotalPrice.CustomerOrderDate != null && expenditureTotalPrice.CustomerOrderCurrencyPrice > 0)
                    customerOrderCurrencyRate = currencyService.GetCurrencyRateByDate(expenditureTotalPrice.CurrencyCode, (DateTime)expenditureTotalPrice.CustomerOrderDate);
                else
                    customerOrderCurrencyRate = 1;

                if (customerOrderCurrencyRate == 0)
                {
                    MessageBox.Show("Не можливо коректно порахувати курс, через відсустність інтернету", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    customerOrderCurrencyRate = 1;
                }

                if (expenditureTotalPrice.CustomerOrderCurrencyPrice > 0)
                {
                    if (expenditureTotalPrice.ExpendituresTotalPrice != 0 && expenditureTotalPrice.CustomerOrderCurrencyPrice != 0)
                        expenditurePercentTotalPrice = (decimal?)Math.Round((decimal)((expenditureTotalPrice.ExpendituresTotalPrice * 100.00m) / (customerOrderCurrencyRate * expenditureTotalPrice.CustomerOrderCurrencyPrice)), 2) ?? 0.00m;
                    else
                        expenditurePercentTotalPrice = 0.00m;
                }
                else
                {
                    if (expenditureTotalPrice.ExpendituresTotalPrice != 0 && expenditureTotalPrice.CustomerOrderPrice != 0)
                        expenditurePercentTotalPrice = (decimal?)Math.Round((decimal)((expenditureTotalPrice.ExpendituresTotalPrice * 100.00m) / (customerOrderCurrencyRate * expenditureTotalPrice.CustomerOrderPrice)), 2) ?? 0.00m;
                    else
                        expenditurePercentTotalPrice = 0.00m;
                }

                //splashScreenManager.CloseWaitForm();

                if (expenditurePercentTotalPrice > 45)
                    ShowLimitPanel(true);
                else
                    ShowLimitPanel(false);
            }
            else
            {
                //splashScreenManager.CloseWaitForm();
                ShowLimitPanel(false);
            }
        }

        private void CheckCustomerOrderEnable(int? customerOrderId)
        {
            if (customerOrdersService.CheckCustomerOrderEnable((int?)orderNumberEdit.EditValue))
            {
                ShowCustomerOrderEnablePanel(true);
                saveBtn.Enabled = false;

            }
            else
            {
                ShowCustomerOrderEnablePanel(false);
                saveBtn.Enabled = true;
            }
          
        }

        void ShowLimitPanel(bool showLimitPanel)
        {
            if (showLimitPanel)
            {
                limitTimer.Start();
                limitPanel.Visible = true;
            }
            else
            {
                limitTimer.Stop();
                limitPanel.Visible = false;
            }
        }

        void ShowCustomerOrderEnablePanel(bool customerOrdersEnablePanel)
        {
            if (customerOrdersEnablePanel)
            {
                enableOrderTimer.Start();
                customerOrderEnablePanel.Visible = true;
            }
            else
            {
                enableOrderTimer.Stop();
                customerOrderEnablePanel.Visible = false;
            }
        }
        private void Calculate()
        {
            if (remainsBS.Count != 0)
            {
                decimal Quantity = Convert.ToDecimal(quantityEdit.Text.Length == 0 ? "0,000000" : quantityEdit.Text.Replace('.', ','));
                decimal Price = Convert.ToDecimal(sumEdit.Text.Length == 0 ? "0,00" : sumEdit.Text.Replace('.', ','));

                //decimal RemainsQuantity = Convert.ToDecimal(((ExpedinturesAccountantDTO)storeHouseReceiptProjectBS.Current).);

                decimal RemainsQuantity = Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity);

                if (Quantity == RemainsQuantity)
                {
                    expQuantity = Quantity;
                    expPrice = Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsSum);
                    sumEdit.Text = Math.Round(expPrice, 2).ToString("N", Utils.NumFormat(2));
                }
                else
                {
                    expPrice = Quantity * Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).UnitPrice);
                    sumEdit.Text = quantityEdit.Text.Length == 0 ? "" : Math.Round(expPrice, 2).ToString("N", Utils.NumFormat(2));
                    expQuantity = Quantity;
                }

                expQuantity = Quantity;

                if (Quantity > RemainsQuantity)
                    dxErrorProvider.SetError(quantityEdit, "Недостатня кількість!");
                else
                    dxErrorProvider.ClearErrors();
            }
        }

        private bool SaveOrder()
        {
            periodService = Program.kernel.Get<IPeriodService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            remainsBS.ResetCurrentItem();

            this.Item.EndEdit();

            if (remainsBS.Count == 0 && operation == Utils.Operation.Add)
            {
                MessageBox.Show("Відсутні надходження!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (((RemainsNomenclatureDTO)remainsBS.Current).Correction == "K")
            {
                MessageBox.Show("Не можливо списати коригування!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!periodService.CheckPeriodAccess((DateTime)((ExpedinturesAccountantDTO)Item).RealExpDate))
            {
                MessageBox.Show("Період закрит або не існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            if (operation == Utils.Operation.Add)
            {
                if (Convert.ToDecimal(quantityEdit.EditValue) == 0.000m)
                {
                    if (MessageBox.Show("Указано нулевое количество, продолжить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        quantityEdit.EditValue = 0;
                        quantityEdit.Focus();
                        return false;
                    }
                }

                if (expQuantity > Convert.ToDecimal((((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity)))
                {
                    MessageBox.Show("Недостатньо матеріалу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //quantityEdit.EditValue = 0;
                    quantityEdit.Focus();
                    return false;
                }

                if (((ExpedinturesAccountantDTO)Item).EmployeeId == null && ((ExpedinturesAccountantDTO)Item).CustomerOrderId == null)
                {
                    MessageBox.Show("Повинен бути вказаний заказ або працівник", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            switch (operation)
            {
                case Utils.Operation.Add:
                    try
                    {
                        ((ExpedinturesAccountantDTO)Item).RECEIPT_ID = ((RemainsNomenclatureDTO)remainsBS.Current).ReceiptId;
                        ((ExpedinturesAccountantDTO)Item).QUANTITY = (decimal)expQuantity;
                        ((ExpedinturesAccountantDTO)Item).PRICE = (decimal)expPrice;
                        ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;                  
                        ((ExpedinturesAccountantDTO)Item).UserId = userTasksDTO.UserId;
                        ((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID = null;
                        ((ExpedinturesAccountantDTO)Item).EXP_DATE = new DateTime(((ExpedinturesAccountantDTO)Item).RealExpDate.Value.Year, ((ExpedinturesAccountantDTO)Item).RealExpDate.Value.Month, 1).AddMonths(1).AddDays(-1);

                        
                        
                        ((ExpedinturesAccountantDTO)Item).ExpenditureType = true;
                        //((ExpendituresStoreHousesDTO)Item).PROJECT_NUM = projectEdit.Text == "0" ? "" : ((ExpedinturesAccountantDTO)Item).PROJECT_NUM;
                        ExpedinturesAccountantDTO saveExpModel = new ExpedinturesAccountantDTO();
                        saveExpModel = (ExpedinturesAccountantDTO)Item;
                        //saveExpModel.PROJECT_NUM = projectEdit.Text.Length == 0 ? "0" : projectEdit.Text.Trim();
                        ((ExpedinturesAccountantDTO)Item).ID = storeHouseService.ExpendituresAccountantCreate(saveExpModel);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Виникла помилка при роботі з БД! " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
            return true;
        }


        #endregion
  
        #region Validation

        private void dateValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.orderNumberEdit.Enabled = false;
            this.measureEdit.Enabled = false;
            this.nomenclatureEdit.Enabled = false;
            this.nomenclatureNameEdit.Enabled = false;
            this.quantityEdit.Enabled = false;
            this.balanceNumEdit.Enabled = false;
        }

        private void dateValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dateValidationProvider.GetInvalidControls().Count == 0);

            this.saveBtn.Enabled = isValidate;
            this.orderNumberEdit.Enabled = isValidate;
            this.measureEdit.Enabled = isValidate;
            this.nomenclatureEdit.Enabled = isValidate;
            this.nomenclatureNameEdit.Enabled = isValidate;
            this.quantityEdit.Enabled = isValidate;
            this.balanceNumEdit.Enabled = isValidate;
        }

        private void ControlValidation()
        {
            dateValidationProvider.Validate();
        }

        #endregion

        #region Event's

        private void quantityEdit_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void quantityEdit_Click(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { quantityEdit.SelectionStart = 1; }));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни? \nДата списання " + ((ExpedinturesAccountantDTO)Item).RealExpDate.Value.ToShortDateString(), "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveOrder())
                    {
                        expQuantityGeneral += (decimal)expQuantity;
                        expQuantityGeneralEdit.EditValue = expQuantityGeneral;

                        if (operation == Utils.Operation.Add)
                        {
                            LoadReceipts(searchDate, nomenclatureSearch.FirstOrDefault());
                            LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
                            if (orderNumberEdit.Text == "")
                                LoadDetaExpenditureByCustomerOrder(beginDate, endDate, null);
                            else
                                LoadDetaExpenditureByCustomerOrder(beginDate, endDate, (int?)orderNumberEdit.EditValue);
                        }
                        quantityEdit.EditValue = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сбереженні виникла помилка: " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void endExpBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void expenditureDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            dateValidationProvider.Validate((Control)sender);
            SetPeriodBtnImage();
        }

        private void orderNumberEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        orderNumberEdit.EditValue = null;
                        break;
                    }
            }
        }

        private void employeesEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        employeesEdit.EditValue = null;
                        break;
                    }
            }
        }

        private void storeHouseProjectGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            RemainsNomenclatureDTO item = (RemainsNomenclatureDTO)remainsBS[e.ListSourceRowIndex];
            if (e.Column == correctionCol && e.IsGetData)
            {
                if (item.Correction == "К")
                    e.Value = imageCollection.Images[2];
                else
                    e.Value = imageCollection.Images[3];
            }
        }

        private void storeHouseProjectGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (remainsBS.Count > 0)
                Calculate();
        }

        private void limitTimer_Tick(object sender, EventArgs e)
        {
            if (limitActive)
            {
                limitPicture.Visible = true;
                limitActive = false;
                return;
            }
            else
            {
                limitPicture.Visible = false;
                limitActive = true;
                return;
            }
        }

        private void enableOrderTimer_Tick(object sender, EventArgs e)
        {
            if (enableOrderActive)
            {
                enableOrderPicture.Visible = true;
                enableOrderActive = false;
                return;
            }
            else
            {
                enableOrderPicture.Visible = false;
                enableOrderActive = true;
                return;
            }
        }

        private void expenditureFullGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            ////if (e.RowHandle >= 0 && ((e.Column.Name == "expAccountantOrderCol") || (e.Column.Name == "expAccountCol") || (e.Column.Name == "expAccountQuantityCol")))
            ////{
            ////    var model = (ExpendituresStoreHousesDTO)expenditureFullGridView.GetRow(e.RowHandle);

            ////    if (model.ExpenditureId == null && (bool)!model.Check)
            ////    {
            ////        e.Appearance.BackColor2 = Color.FromArgb(255, 192, 192);
            ////        e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
            ////    }
            ////    else if (model.ExpenditureId != null)
            ////    {
            ////        e.Appearance.BackColor2 = Color.PaleGreen;
            ////        e.Appearance.BackColor = Color.LightGreen;
            ////    }
            ////    else
            ////    {
            ////        e.Appearance.BackColor2 = Color.SkyBlue;
            ////        e.Appearance.BackColor = Color.SkyBlue;
            ////    }

            ////    if (model.ExpenditureCustomerOrder != "0" && model.ExpenditureId != null && model.ExpenditureCustomerOrder != model.CustomerOrderNumber.Replace(".", ""))
            ////    {
            ////        e.Appearance.BackColor2 = Color.FromArgb(255, 223, 142);
            ////        e.Appearance.BackColor = Color.FromArgb(255, 223, 142);
            ////    }
            ////}
        }

        private void nomenclatureEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.OnlyNumbers(e);
            if (e.KeyChar == (char)Keys.Enter)
                CheckNomenclature(nomenclatureEdit.Text.Trim());
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (orderNumberEdit.Text == "")
            {
                LoadDetaExpenditureByCustomerOrder(beginDate, endDate, null);
                //employeesEdit.EditValue = null;
                ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = null;
                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = "0";
                //((ExpedinturesAccountantDTO)Item).EmployeeId = null;
                employeesEdit.Visible = true;
                employeesLbl.Visible = true;
                infoTabControl.TabPages[0].Text = "Матеріали  списані на заказ 0 за період: " + beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();
            }
            else
            {
                LoadDetaExpenditureByCustomerOrder(beginDate, endDate, (int?)orderNumberEdit.EditValue);
                LoadDataExpenditureTotalPrice((int?)orderNumberEdit.EditValue);
                CheckCustomerOrderEnable((int?)orderNumberEdit.EditValue);

                employeesEdit.Visible = false;
                employeesLbl.Visible = false;
                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = orderNumberEdit.Text.Replace(".", "");
                ((ExpedinturesAccountantDTO)Item).EmployeeId = null;
                ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;
                infoTabControl.TabPages[0].Text = "Матеріали  списані на заказ " + orderNumberEdit.Text + " за період: " + beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();
            }

            ////if (orderNumberEdit.EditValue == null)
            ////{
            ////    LoadDetaExpenditureByCustomerOrder(beginDate, endDate, null);
            ////    employeesEdit.EditValue = null;

            ////    ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = "0";
            ////    ((ExpedinturesAccountantDTO)Item).EmployeeId = null;
            ////    employeesEdit.Visible = true;
            ////    employeesLbl.Visible = true;
            ////    infoTabControl.TabPages[0].Text = "Матеріали  списані на заказ 0 за період: " + beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();
            ////}
            ////else
            ////{

            ////    LoadDetaExpenditureByCustomerOrder(beginDate, endDate, (int?)orderNumberEdit.EditValue);
            ////    LoadDataExpenditureTotalPrice((int?)orderNumberEdit.EditValue);
            ////    employeesEdit.Visible = false;
            ////    employeesLbl.Visible = false;
            ////    if (orderNumberEdit.Text != "")
            ////        ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = orderNumberEdit.Text.Replace(".", "");
            ////    ((ExpedinturesAccountantDTO)Item).EmployeeId = null;
            ////    infoTabControl.TabPages[0].Text = "Матеріали  списані на заказ " + orderNumberEdit.Text + " за період: " + beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();
            ////}
        }

        private void nomenclatureEdit_EditValueChanged(object sender, EventArgs e)
        {
            quantityEdit.EditValue = 0;
            expQuantityGeneral = (decimal)0;
            expQuantityGeneralEdit.EditValue = expQuantityGeneral;
        }

        

        private void storeHouseProjectGrid_DoubleClick(object sender, EventArgs e)
        {
            if (remainsBS.Count > 0 && ((RemainsNomenclatureDTO)remainsBS.Current).Correction != "К")
            {
                quantityEdit.EditValue = ((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity;
                Calculate();
            }
        }

        #endregion 


    }
}