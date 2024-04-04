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
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Infrastructure;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Data;

namespace ERP_NEW.GUI.Accounting
{
    public partial class ExpendituresEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IPeriodService periodService;
        private IAccountsService accountsService;
        private ICustomerOrdersService customerOrdersService;
        private ICurrencyService currencyService;
        private IEmployeesService employeesService;

        private BindingSource expenditureBS = new BindingSource();
        private BindingSource remainsBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource customerOrdersHistoryBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();

        private int? previosCustomerOrder;

        private Utils.Operation operation;
        private Utils.ExpendTypes expendType;
        private UserTasksDTO userTasksDTO;

        private decimal expQuantity = 0.000000m;
        private decimal expPrice = 0.00m;
        private decimal customerOrderCurrencyRate = 0.00m;

        private decimal expQuantityGeneral = 0.000000m;
        private decimal expPriceGeneral = 0.00m;

        private bool limitActive = false;

        //decimal? quantityColFilter = 0;
        //decimal? totalPriceColFilter = 0;

        private List<NomenclaturesDTO> nomenclatureSearch = new List<NomenclaturesDTO>();

        private ObjectBase Item
        {
            get { return expenditureBS.Current as ObjectBase; }
            set
            {
                expenditureBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public ExpendituresEditFm(ExpedinturesAccountantDTO model, Utils.Operation operation, UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            projectEdit.TextChanged -= projectEdit_TextChanged;

            this.userTasksDTO = userTasksDTO;
            this.operation = operation;

            expenditureBS.DataSource = Item = model;
            previosCustomerOrder = model.CustomerOrderId;

            if (operation == Utils.Operation.Add)
            {
                ((ExpedinturesAccountantDTO)expenditureBS.Current).PRICE = 0.000000m;
                ((ExpedinturesAccountantDTO)expenditureBS.Current).QUANTITY = 0.00000m;
                ((ExpedinturesAccountantDTO)expenditureBS.Current).PROJECT_NUM = "";
                
                model.EXP_DATE = null;

                quantityRBtn.Checked = true;
                expenditureTypeCheck.EditValue = false;

            }
            else
            {
                if (((ExpedinturesAccountantDTO)expenditureBS.Current).PROJECT_NUM == "0")
                    ((ExpedinturesAccountantDTO)expenditureBS.Current).PROJECT_NUM = "";

                endExpBtn.Enabled = false;
                groupControl.Enabled = false;

                if (((ExpedinturesAccountantDTO)expenditureBS.Current).ExpenditureType == false)
                {
                    prodOrderLbl.Visible = false;
                    orderNumberHistoryEdit.Visible = false;
                }

                saveBtn.Text = "Зберегти";
            }

            accountsService = Program.kernel.Get<IAccountsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            employeesService = Program.kernel.Get<IEmployeesService>();

            expenditureDateEdit.DataBindings.Add("EditValue", expenditureBS, "EXP_DATE", true, DataSourceUpdateMode.OnPropertyChanged);
            projectEdit.DataBindings.Add("EditValue", expenditureBS, "PROJECT_NUM", true, DataSourceUpdateMode.OnPropertyChanged);
            measureEdit.DataBindings.Add("EditValue", expenditureBS, "UnitLocalName", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureEdit.DataBindings.Add("EditValue", expenditureBS, "Nomenclature", true, DataSourceUpdateMode.OnPropertyChanged);
            nomenclatureNameEdit.DataBindings.Add("EditValue", expenditureBS, "NomenclatureName", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityEdit.DataBindings.Add("EditValue", expenditureBS, "QUANTITY", true, DataSourceUpdateMode.OnPropertyChanged);
            balanceNumEdit.DataBindings.Add("EditValue", expenditureBS, "BalanceAccountNum", true, DataSourceUpdateMode.OnPropertyChanged);
            sumEdit.DataBindings.Add("EditValue", expenditureBS, "PRICE", true, DataSourceUpdateMode.OnPropertyChanged);
            orderNumberEdit.DataBindings.Add("EditValue", expenditureBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            orderNumberHistoryEdit.DataBindings.Add("EditValue", expenditureBS, "ProdCustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            expenditureTypeCheck.DataBindings.Add("Checked", expenditureBS, "ExpenditureType", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesEdit.DataBindings.Add("EditValue", expenditureBS, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);

            creditEdit.DataBindings.Add("EditValue", expenditureBS, "CREDIT_ACCOUNT_ID", true, DataSourceUpdateMode.OnPropertyChanged);
            creditEdit.Properties.DataSource = accountsService.GetAccounts();
            creditEdit.Properties.ValueMember = "Id";
            creditEdit.Properties.DisplayMember = "Num";
            creditEdit.Properties.NullText = null;

            customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "";

            employeesEdit.Properties.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "Fio";
            employeesEdit.Properties.NullText = null;

            customerOrdersHistoryBS.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            orderNumberHistoryEdit.Properties.DataSource = customerOrdersHistoryBS;
            orderNumberHistoryEdit.Properties.ValueMember = "Id";
            orderNumberHistoryEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberHistoryEdit.Properties.NullText = "";

            expQuantityGeneralEdit.EditValue = expQuantityGeneral;
            expPriceGeneralEdit.EditValue = expPriceGeneral;

            ControlValidation();

        }

        #region Method's

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
                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = ((ExpedinturesAccountantDTO)Item).PROJECT_NUM == "0" ? "" : ((ExpedinturesAccountantDTO)Item).PROJECT_NUM;

                Item.EndEdit();
                
                remainsGrid.DataSource = remainsBS;

                expenditureBS.ResetBindings(true);

                splashScreenManager.CloseWaitForm();
                remainsBS.ResetBindings(true);

                GridControlShow(false);

                quantityEdit.ReadOnly = true;
                sumEdit.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Матеріал повністю витрачено!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClearNomenclature();

                nomenclatureEdit.Focus();

                splashScreenManager.CloseWaitForm();
            }    
        }

        public ExpedinturesAccountantDTO Return()
        {
            return ((ExpedinturesAccountantDTO)Item);
        }

        private void ClearNomenclature()
        {

            Item.BeginEdit();

            ((ExpedinturesAccountantDTO)Item).BalanceAccountNum = "";

            Item.EndEdit();

            expenditureBS.ResetBindings(true);
        }

        private void CheckNomenclature(string Nomenclature)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            //loger.Info("Номенклатура: " + Nomenclature);
            nomenclatureSearch = storeHouseService.GetNomenclatureWithAccountNumber(Nomenclature).ToList();

            if (nomenclatureSearch.Count != 0)
            {
                LoadReceipts(((ExpedinturesAccountantDTO)Item).EXP_DATE, nomenclatureSearch[0]);
            }
            else
            {
                ClearNomenclature();
                nomenclatureEdit.Focus();
                MessageBox.Show("Номенклатура відсутня в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult = DialogResult.None;
        }



        private void Calculate()
        {
            if (remainsBS.Count != 0)
            {
                decimal Quantity = Convert.ToDecimal(quantityEdit.Text.Length == 0 ? "0,00000" : quantityEdit.Text.Replace('.', ','));
                decimal Price = Convert.ToDecimal(sumEdit.Text.Length == 0 ? "0,00" : sumEdit.Text.Replace('.', ','));

                switch (expendType)
                {
                    case Utils.ExpendTypes.ExpendByQuantity:
                        decimal RemainsQuantity = Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity);
                        if (Quantity == RemainsQuantity)
                        {
                            expPrice = Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsSum);
                            sumEdit.Text = Math.Round(expPrice, 2).ToString("N", Utils.NumFormat(2));

                            expQuantity = Quantity;
                        }
                        else
                        {
                            expPrice = Quantity * Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).UnitPrice);
                            sumEdit.Text = quantityEdit.Text.Length == 0 ? "" : Math.Round(expPrice, 2).ToString("N", Utils.NumFormat(2));
                            //((ExpedinturesAccountantDTO)Item).PRICE = quantityEdit.Text.Length == 0 ? 0 : Math.Round(expPrice, 2);
                            //sumEdit

                            expQuantity = Quantity;
                        }

                        if (Quantity > RemainsQuantity)
                            dxErrorProvider.SetError(quantityEdit, "Недостатня кількість!");
                        else
                            dxErrorProvider.ClearErrors();
                        break;
                    case Utils.ExpendTypes.ExpendBySum:
                        decimal RemainsSum = Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsSum);
                        if (Price == RemainsSum)
                        {
                            expQuantity = Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity);
                            quantityEdit.Text = expQuantity.ToString("N", Utils.NumFormat(5));

                            expPrice = Price;
                        }
                        else
                        {
                            if (Price == 0.00m)
                            {
                                expQuantity = 0.000m;
                                quantityEdit.Text = "0";
                            }
                            else
                            {
                                expQuantity = 0.001m;
                                quantityEdit.Text = "0,001";
                            }

                            expPrice = Price;
                        }

                        if (Price > Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsSum))
                            dxErrorProvider.SetError(quantityEdit, "Недостатня сума!");
                        else
                            dxErrorProvider.ClearErrors();
                        break;
                }
            }
        }

        private void ControlValidation()
        {
            dateValidationProvider.Validate();
            generalDataValidationProvider.Validate();
        }

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

                if (!periodService.CheckPeriodAccess((DateTime)((ExpedinturesAccountantDTO)Item).EXP_DATE))
                {
                    MessageBox.Show("Період закрит або не існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (customerOrdersService.CheckCustomerOrderEnable((int?)((ExpedinturesAccountantDTO)Item).CustomerOrderId))
                {
                    MessageBox.Show("Заказ знаходиться на складі!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID == null)
                    if (MessageBox.Show("Відсутній номер рахунку списання, продовжити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return false;

                if (((ExpedinturesAccountantDTO)Item).CustomerOrderId == null && ((ExpedinturesAccountantDTO)Item).EmployeeId == null)
                {
                    MessageBox.Show("Выдсутній номер заказу та не вказано людину на яку проводиться списання!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //if (!((ExpedinturesAccountantDTO)Item).ExpenditureType && ((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID == null)
                //{
                //    MessageBox.Show("Необхідно вказати номер рахунку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}
                
                if (operation == Utils.Operation.Add)
                {
                    if (Convert.ToDecimal(sumEdit.EditValue) == 0.00m)
                    {
                        if (MessageBox.Show("Указана нульова сума, продовжити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            quantityEdit.EditValue = 0;
                            quantityEdit.Focus();
                            return false;
                        }
                    }

                    if (Convert.ToDecimal(quantityEdit.EditValue) == 0.000m)
                    {
                        if (MessageBox.Show("Указано нульова кількість, продовжити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            quantityEdit.EditValue = 0;
                            quantityEdit.Focus();
                            return false;
                        }
                    }

                    if (expendType == Utils.ExpendTypes.ExpendByQuantity)
                    {
                        if (expQuantity > Convert.ToDecimal((((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity)))
                        {
                            MessageBox.Show("Недостатньо матеріалу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //quantityEdit.EditValue = 0;
                            quantityEdit.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        if (expPrice > Convert.ToDecimal((((RemainsNomenclatureDTO)remainsBS.Current).RemainsSum)))
                        {
                            MessageBox.Show("Недостатня сума!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //sumEdit.EditValue = 0;
                            sumEdit.Focus();
                            return false;
                        }
                    }
                }

                if (projectEdit.Text.Trim().Length == 0)
                {
                    if (MessageBox.Show("Не вказано номер проекту, продовжити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return false;

                    if ((creditEdit.Text == "23") && (creditEdit.Text == "473") && (creditEdit.EditValue == null))
                    {
                        MessageBox.Show("Вказан " + creditEdit.Text + " рахунок при списанні без проекту!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    if ((creditEdit.Text != "23") && (creditEdit.Text != "473") && (creditEdit.Text != ""))
                    {
                        MessageBox.Show("Указан не 23й рахунок при списанні по проекту!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                switch (operation)
                {
                    case Utils.Operation.Add:
                        try
                        {
                            var invoices = storeHouseService.GetInvoiceRequirementMaterial(((RemainsNomenclatureDTO)remainsBS.Current).ReceiptId, (decimal)quantityEdit.EditValue);

                            if (invoices.Count() == 0)
                            {
                                if (MessageBox.Show("До надходження не сформовано вимогу, продовжити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ((ExpedinturesAccountantDTO)Item).RECEIPT_ID = ((RemainsNomenclatureDTO)remainsBS.Current).ReceiptId;
                                    ((ExpedinturesAccountantDTO)Item).UserId = userTasksDTO.UserId;
                                    ((ExpedinturesAccountantDTO)Item).PRICE = (decimal)expPrice;
                                    ((ExpedinturesAccountantDTO)Item).QUANTITY = (decimal)expQuantity;
                                    ((ExpedinturesAccountantDTO)Item).RealExpDate = ((ExpedinturesAccountantDTO)Item).EXP_DATE;
                                    ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = projectEdit.Text == "0" ? "" : ((ExpedinturesAccountantDTO)Item).PROJECT_NUM;
                                    ExpedinturesAccountantDTO saveExpModel = new ExpedinturesAccountantDTO();
                                    saveExpModel = (ExpedinturesAccountantDTO)Item;
                                    saveExpModel.PROJECT_NUM = projectEdit.Text.Length == 0 ? "0" : projectEdit.Text.Trim();

                                    if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null)
                                        ((ExpedinturesAccountantDTO)Item).EmployeeId = null;

                                    if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null && ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId == null)
                                        ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;

                                    if (((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID != null)
                                        ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = DateTime.Now;
                                    else
                                        ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = null;

                                    ((ExpedinturesAccountantDTO)Item).ID = storeHouseService.ExpendituresAccountantCreate(saveExpModel);
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {   
                                        ((ExpedinturesAccountantDTO)Item).RECEIPT_ID = ((RemainsNomenclatureDTO)remainsBS.Current).ReceiptId;
                                        ((ExpedinturesAccountantDTO)Item).UserId = userTasksDTO.UserId;
                                        ((ExpedinturesAccountantDTO)Item).PRICE = (decimal)expPrice;
                                        ((ExpedinturesAccountantDTO)Item).QUANTITY = (decimal)expQuantity;
                                        ((ExpedinturesAccountantDTO)Item).RealExpDate = ((ExpedinturesAccountantDTO)Item).EXP_DATE;
                                        ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = projectEdit.Text == "0" ? "" : ((ExpedinturesAccountantDTO)Item).PROJECT_NUM;
                                        ExpedinturesAccountantDTO saveExpModel = new ExpedinturesAccountantDTO();
                                        saveExpModel = (ExpedinturesAccountantDTO)Item;
                                        saveExpModel.PROJECT_NUM = projectEdit.Text.Length == 0 ? "0" : projectEdit.Text.Trim();

                                        if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null)
                                            ((ExpedinturesAccountantDTO)Item).EmployeeId = null;

                                        if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null && ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId == null)
                                            ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;

                                        if (((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID != null)
                                            ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = DateTime.Now;
                                        else
                                            ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = null;

                                        ((ExpedinturesAccountantDTO)Item).ID = storeHouseService.ExpendituresAccountantCreate(saveExpModel);

                                        foreach (var item in invoices)
                                        {
                                            //if (item.Credit_Account_Id == null)
                                            //    continue;
                                            item.Expenditures_Id = ((ExpedinturesAccountantDTO)Item).ID;
                                            item.Credit_Account_Id = ((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID;

                                            storeHouseService.InvoiceRequirementMaterialUpdate(item);
                                        }
                                }
                            }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Виникла помилка при роботі з БД! " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case Utils.Operation.Update:

                        storeHouseService = Program.kernel.Get<IStoreHouseService>();
                        var invoicess = storeHouseService.GetInvoiceRequirementMaterial(((ExpedinturesAccountantDTO)Item).RECEIPT_ID, (decimal)quantityEdit.EditValue);
                        
                        if (invoicess.Count() == 0)
                        {
                            if (MessageBox.Show("До надходження не сформовано вимогу, продовжити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = projectEdit.Text.Length == 0 ? "0" : projectEdit.Text.Trim();
                                ((ExpedinturesAccountantDTO)Item).UserId = userTasksDTO.UserId;
                                if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null)
                                    ((ExpedinturesAccountantDTO)Item).EmployeeId = null;

                                if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != previosCustomerOrder)
                                    ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = previosCustomerOrder;

                                if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null && ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId == null)
                                    ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;

                                if (((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID != null)
                                    ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = DateTime.Now;
                                else
                                    ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = null;

                                storeHouseService.ExpendituresAccountantUpdate((ExpedinturesAccountantDTO)Item);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = projectEdit.Text.Length == 0 ? "0" : projectEdit.Text.Trim();
                            ((ExpedinturesAccountantDTO)Item).UserId = userTasksDTO.UserId;
                            if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null)
                                ((ExpedinturesAccountantDTO)Item).EmployeeId = null;

                            if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != previosCustomerOrder)
                                ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = previosCustomerOrder;

                            if (((ExpedinturesAccountantDTO)Item).CustomerOrderId != null && ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId == null)
                                ((ExpedinturesAccountantDTO)Item).ProdCustomerOrderId = ((ExpedinturesAccountantDTO)Item).CustomerOrderId;

                            if (((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID != null)
                                ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = DateTime.Now;
                            else
                                ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = null;

                            storeHouseService.ExpendituresAccountantUpdate((ExpedinturesAccountantDTO)Item);

                            foreach (var item in invoicess)
                            {
                                //if (item.Credit_Account_Id == null)
                                //    continue;

                                item.Expenditures_Id = ((ExpedinturesAccountantDTO)Item).ID;
                                item.Credit_Account_Id = ((ExpedinturesAccountantDTO)Item).CREDIT_ACCOUNT_ID;

                                storeHouseService.InvoiceRequirementMaterialUpdate(item);
                            }
                        }

                        ((ExpedinturesAccountantDTO)Item).PROJECT_NUM = "";

                        DialogResult = DialogResult.OK;
                        this.Close();

                        break;
                }

                return true;
        }

        private List<ExpenditureInfoDTO> LoadCustomerOrderMaterialExpenditure(string customerOrderNumber)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            List<ExpenditureInfoDTO> expenditureInfoList = storeHouseService.GetExpenditureByCustomerOrder((int)((ExpedinturesAccountantDTO)Item).CustomerOrderId).ToList();
            return expenditureInfoList;
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

        private void GridControlShow(bool flag)
        {
            remainsGridView.OptionsView.ShowIndicator = flag;
            remainsGridView.OptionsSelection.EnableAppearanceFocusedCell = flag;
            remainsGridView.OptionsSelection.EnableAppearanceFocusedRow = flag;
            remainsGridView.OptionsSelection.EnableAppearanceHideSelection = flag;
        }

        private void LoadDataExpenditureTotalPrice(int? customerOrderId)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            currencyService = Program.kernel.Get<ICurrencyService>();

            Decimal expenditurePercentTotalPrice = 0;

            ExpenditureTotalPriceDTO expenditureTotalPrice = storeHouseService.GetExpenditureAccTotalPriceByCustomerOrderId((int)customerOrderId, 1).FirstOrDefault();
            if (expenditureTotalPrice != null)
            {
                if (expenditureTotalPrice.CustomerOrderDate != null && expenditureTotalPrice.CustomerOrderCurrencyPrice > 0)
                    customerOrderCurrencyRate = currencyService.GetCurrencyRateByDate(expenditureTotalPrice.CurrencyCode, (DateTime)expenditureTotalPrice.CustomerOrderDate);
                else
                    customerOrderCurrencyRate = 1;

                if (expenditureTotalPrice.CustomerOrderCurrencyPrice > 0)
                {
                    if (expenditureTotalPrice.ExpendituresTotalPrice != 0 && expenditureTotalPrice.CustomerOrderCurrencyPrice != 0 && customerOrderCurrencyRate > 0)
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

                splashScreenManager.CloseWaitForm();

                if (expenditurePercentTotalPrice > 45)
                    ShowLimitPanel(true);
                else
                    ShowLimitPanel(false);
            }
            else
            {
                splashScreenManager.CloseWaitForm();
                ShowLimitPanel(false);
            }
        }

        #endregion

        #region Event's

        private void ExpendituresEditFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nomenclatureEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (NomenclaturesFm nomenclaturesFm = new NomenclaturesFm(userTasksDTO, true))
            {
                if (nomenclaturesFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    NomenclaturesDTO returnItem = nomenclaturesFm.Return();

                    LoadReceipts(((ExpedinturesAccountantDTO)Item).EXP_DATE, returnItem);

                    DialogResult = DialogResult.None;
                }
                else
                {

                    DialogResult = DialogResult.None;
                }
            }
        }

        private void nomenclatureEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.OnlyNumbers(e);
            if (e.KeyChar == (char)Keys.Enter)
                CheckNomenclature(nomenclatureEdit.Text.Trim());
        }

        private void remainsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (remainsBS.Count > 0)
            {
                if (expendType == Utils.ExpendTypes.ExpendByQuantity)
                    quantityEdit.EditValue = ((RemainsNomenclatureDTO)remainsBS.Current).RemainsQuantity;
                else
                    sumEdit.EditValue = Math.Round(Convert.ToDecimal(((RemainsNomenclatureDTO)remainsBS.Current).RemainsSum), 2);

                Calculate();
            }
        }

        private void periodEditBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (periodService.CheckPeriodAccess((DateTime)expenditureDateEdit.EditValue))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(((DateTime)expenditureDateEdit.EditValue).Year, ((DateTime)expenditureDateEdit.EditValue).Month);
                        model.State = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (periodService.CheckPeriodExist((DateTime)expenditureDateEdit.EditValue))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(((DateTime)expenditureDateEdit.EditValue).Year, ((DateTime)expenditureDateEdit.EditValue).Month);
                            model.State = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else if (MessageBox.Show("Вказаного періода не існує в системі! Додати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = ((DateTime)expenditureDateEdit.EditValue).Year,
                                Month = ((DateTime)expenditureDateEdit.EditValue).Month,
                                State = true,
                                StateBank = false,
                                StateBusinesTrip = false
                            };

                            periodService.PeriodsCreate(model);
                        }
                    }

                    SetPeriodBtnImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void projectEdit_TextChanged(object sender, EventArgs e)
        {
            if (projectEdit.Text.Length != 0)
            {
                creditEdit.EditValue = 18;
                //customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
                //List<ExpenditureInfoDTO> expenditureInfoexpenditureInfo = LoadCustomerOrderMaterialExpenditure(projectEdit.Text);
                //CustonerOrdersDTO customerOrders = customerOrdersService.GetCustomerOrdersFullById(expenditureInfoexpenditureInfo.FirstOrDefault().C);
                //LoadCurrencyInformation();

            }
            else
            {
                creditEdit.EditValue = 19;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни? \nДата списання " + ((ExpedinturesAccountantDTO)Item).EXP_DATE.Value.ToShortDateString(), "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveOrder())
                    {
                        expPriceGeneral +=(decimal)Math.Round(expPrice,2);
                        expQuantityGeneral += (decimal)Math.Round(expQuantity,6);

                        expPriceGeneralEdit.EditValue = expPriceGeneral;
                        expQuantityGeneralEdit.EditValue = expQuantityGeneral;

                        if (operation == Utils.Operation.Add)
                            LoadReceipts(((ExpedinturesAccountantDTO)Item).EXP_DATE, nomenclatureSearch[0]);

                        if (orderNumberEdit.Text != "")
                            LoadDataExpenditureTotalPrice((int?)orderNumberEdit.EditValue);
                        
                        sumEdit.EditValue = 0;
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

        private void expenditureDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (expenditureDateEdit.Text != "")
            {
                DateTime lastDayOfCurrentMonthDate = new DateTime(((DateTime)expenditureDateEdit.EditValue).Year, ((DateTime)expenditureDateEdit.EditValue).Month, 1);
                lastDayOfCurrentMonthDate = lastDayOfCurrentMonthDate.AddMonths(+1).AddDays(-1);

                if ((DateTime)expenditureDateEdit.EditValue != lastDayOfCurrentMonthDate)
                {
                    MessageBox.Show("Необхідно обрати останній день місяця!", "Не коректна дата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    expenditureDateEdit.EditValue = null;
                }
            }

            dateValidationProvider.Validate((Control)sender);
            SetPeriodBtnImage();
        }

        private void radioButtonChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            switch (rb.Name)
            {
                case "quantityRBtn":
                    if (rb.Checked)
                    {
                        expendType = Utils.ExpendTypes.ExpendByQuantity;
                        sumEdit.ReadOnly = true;
                        quantityEdit.EditValue = 0;
                        quantityEdit.ReadOnly = false;
                        quantityEdit.Focus();
                    }
                    break;

                case "sumRBtn":
                    if (rb.Checked)
                    {
                        expendType = Utils.ExpendTypes.ExpendBySum;
                        quantityEdit.ReadOnly = true;
                        sumEdit.EditValue = 0;
                        sumEdit.ReadOnly = false;
                        sumEdit.Focus();
                    }
                    break;
            }
        }

        private void radioButtonChanged(object sender, EventArgs e)
        {
            RadioButton rb = ((RadioButton)sender);
            switch (rb.Name)
            {
                case "quantityRBtn":
                    if (rb.Checked)
                    {
                        expendType = Utils.ExpendTypes.ExpendByQuantity;
                        sumEdit.ReadOnly = true;
                        quantityEdit.EditValue = 0;
                        quantityEdit.ReadOnly = false;
                        quantityEdit.Focus();
                    }
                    break;

                case "sumRBtn":
                    if (rb.Checked)
                    {
                        expendType = Utils.ExpendTypes.ExpendBySum;
                        quantityEdit.ReadOnly = true;
                        sumEdit.EditValue = 0;
                        sumEdit.ReadOnly = false;
                        sumEdit.Focus();
                    }
                    break;
            }
        }

        private void sumEdit_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void quantityEdit_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void endExpBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void creditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        creditEdit.EditValue = null;
                        ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = null;
                        break;
                    }
            }
        }

        private void orderNumberHistoryEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        orderNumberHistoryEdit.EditValue = null;
                        projectEdit.Text = "";
                        break;
                    }
            }
        }

        private void expenditureTypeCheck_EditValueChanged(object sender, EventArgs e)
        {
            if (expenditureTypeCheck.Checked)
            {
                prodOrderLbl.Visible = true;
                orderNumberHistoryEdit.Visible = true;
            }
            else
            {
                prodOrderLbl.Visible = false;
                orderNumberHistoryEdit.Visible = false;
            }
        }

        private void remainsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
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

        private void remainsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (remainsBS.Count > 0)
                Calculate();
        }

        private void ExpendituresEditFm_Load(object sender, EventArgs e)
        {
            GridControlShow(false);
            projectEdit.TextChanged += projectEdit_TextChanged;
        }

        private void quantityEdit_Click(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { quantityEdit.SelectionStart = 1; }));
        }

        private void sumEdit_Click(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate { sumEdit.SelectionStart = 1; }));
        }

        private void remainsGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            GridControlShow(true);

            if (expendType == Utils.ExpendTypes.ExpendBySum)
            {
                quantityEdit.ReadOnly = true;
                sumEdit.ReadOnly = false;
            }
            else
            {
                quantityEdit.ReadOnly = false;
                sumEdit.ReadOnly = true;
            }
        }

        private void showExpendituresJournalBtn_Click(object sender, EventArgs e)
        {
            using (ExpendituresJournalFm expendituresJournalFm = new ExpendituresJournalFm((DateTime)expenditureDateEdit.EditValue))
            {
                if (expendituresJournalFm.ShowDialog() == System.Windows.Forms.DialogResult.None)
                {
                    DialogResult = DialogResult.None;
                }
                else
                    DialogResult = DialogResult.None;
            }
        }

        private void orderNumberEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        orderNumberEdit.EditValue = null;
                        orderNumberHistoryEdit.EditValue = null;
                        projectEdit.Text = "";
                        break;
                    }
            }
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (orderNumberEdit.Text != "")
                LoadDataExpenditureTotalPrice((int?)orderNumberEdit.EditValue);
        }

        private void orderNumberEdit_TextChanged(object sender, EventArgs e)
        {
            if (orderNumberEdit.Text == "")
            {
                employeesEdit.Visible = true;
                employeesLbl.Visible = true;
            }
            else
            {
                employeesEdit.Visible = false;
                employeesLbl.Visible = false;
                projectEdit.Text = orderNumberEdit.Text.Replace(".", "");

                if (orderNumberHistoryEdit.Text == "")
                    orderNumberHistoryEdit.EditValue = orderNumberEdit.EditValue;
            }
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

        #endregion

        #region Validation's

        private void generalDataValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
        }

        private void generalDataValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (generalDataValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
        }

        private void sumEdit_EditValueChanged(object sender, EventArgs e)
        {
            generalDataValidationProvider.Validate((Control)sender);
        }

        private void quantityEdit_EditValueChanged(object sender, EventArgs e)
        {
            generalDataValidationProvider.Validate((Control)sender);
        }

        private void creditEdit_EditValueChanged(object sender, EventArgs e)
        {
            //if (creditEdit.EditValue != null)
            //    ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = DateTime.Now;
            //else
            //    ((ExpedinturesAccountantDTO)Item).ExpenditureCheckDate = null;

            generalDataValidationProvider.Validate((Control)sender);
        }

        private void nomenclatureEdit_EditValueChanged(object sender, EventArgs e)
        {
            generalDataValidationProvider.Validate((Control)sender);

            expPriceGeneral = (decimal)0;
            expQuantityGeneral = (decimal)0;

            expPriceGeneralEdit.EditValue = expPriceGeneral;
            expQuantityGeneralEdit.EditValue = expQuantityGeneral;

            sumEdit.EditValue = 0;
            quantityEdit.EditValue = 0;

            if ((projectEdit.EditValue == "") && (nomenclatureEdit.Text.Contains("22")))
                creditEdit.EditValue = 19;
            else if(projectEdit.EditValue == "")
                creditEdit.EditValue = null;
        }

        private void dateValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.projectEdit.Enabled = false;
            this.measureEdit.Enabled = false;
            this.nomenclatureEdit.Enabled = false;
            this.nomenclatureNameEdit.Enabled = false;
            this.quantityEdit.Enabled = false;
            this.balanceNumEdit.Enabled = false;
            this.sumEdit.Enabled = false;
            this.creditEdit.Enabled = false;
            this.remainsGrid.Enabled = false;
            this.sumRBtn.Enabled = false;
            this.quantityRBtn.Enabled = false;
            this.showExpendituresJournalBtn.Enabled = false;
            this.orderNumberEdit.Enabled = false;
            this.showExpendituresJournalBtn.Enabled = false;
            this.employeesEdit.Enabled = false;
            this.expenditureTypeCheck.Enabled = false;
            this.orderNumberHistoryEdit.Enabled = false;
        }

        private void dateValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dateValidationProvider.GetInvalidControls().Count == 0);

            if (operation == Utils.Operation.Add)
            {
                this.measureEdit.Enabled = isValidate;
                this.nomenclatureEdit.Enabled = isValidate;
                this.nomenclatureNameEdit.Enabled = isValidate;
                this.quantityEdit.Enabled = isValidate;
                this.balanceNumEdit.Enabled = isValidate;
                this.sumEdit.Enabled = isValidate;
                this.remainsGrid.Enabled = isValidate;
                this.sumRBtn.Enabled = isValidate;
                this.quantityRBtn.Enabled = isValidate;
                this.showExpendituresJournalBtn.Enabled = isValidate;
                this.orderNumberHistoryEdit.Enabled = isValidate;
            }

            
            this.employeesEdit.Enabled = isValidate;
            this.expenditureTypeCheck.Enabled = isValidate;
            this.orderNumberEdit.Enabled = isValidate;
            this.projectEdit.Enabled = isValidate;
            this.creditEdit.Enabled = isValidate;
        }

        #endregion    



        private void remainsGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            //GridView view = sender as GridView;
            //// Get the summary ID. 
            //int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

            //// Initialization. 
            //if (e.SummaryProcess == CustomSummaryProcess.Start)
            //{
            //    quantityColFilter = 0;
            //    totalPriceColFilter = 0;
            //}
            //// Calculation.
            //if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            //{
            //    switch (summaryID)
            //    {
            //        case 2: 
            //            totalPriceColFilter += Convert.ToDecimal(e.FieldValue)>0 ? Convert.ToDecimal(e.FieldValue) : 0;
            //            break;
            //        case 3: // The group summary. 
            //            quantityColFilter += Convert.ToDecimal(e.FieldValue) > 0 ? Convert.ToDecimal(e.FieldValue) : 0;
            //            break;
            //    }
            //}
            //// Finalization. 
            //if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            //{
            //    switch (summaryID)
            //    {
            //        case 2:
            //            e.TotalValue = totalPriceColFilter;
            //            break;
            //        case 3:
            //            e.TotalValue = quantityColFilter;
            //            break;
            //    }
            //}      
        }
    }
}