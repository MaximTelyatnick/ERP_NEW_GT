using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ReportsDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System.Collections;





namespace ERP_NEW.GUI.Accounting
{
    public partial class ReportsFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private IReportService reportService;
        private IAccountsService accountService;
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private IEmployeesService employeesService;
        private IAccountingInvoicesService accountingInvoicesService;
        private IAccountsService accountsService;
        private ICustomerOrdersService customerOrdersService;
        private IStoreHouseService storeHouseService;

        private IBankPaymentsService bankPaymentsService;
        private ICalcWithBuyersService calcWithBuyersService;

        private DateTime _beginDate;
        private DateTime _endDate;

        private string Flag1, Flag3, Flag4;
        private string PFlag3, PFlag4;

        List<BankPaymentsInfoDTO> bankPaymentsList = new List<BankPaymentsInfoDTO>();
        List<CalcWithBuyersInfoDTO> calcWithBuyersList = new List<CalcWithBuyersInfoDTO>();
        List<CalcWithBuyersShortReportDTO> calcWithBuyersForSaldoList = new List<CalcWithBuyersShortReportDTO>();

        public ReportsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            accountService = Program.kernel.Get<IAccountsService>();

            balanceAccountEdit.Properties.DataSource = accountService.GetCalcWithBuyerAccounts();
            balanceAccountEdit.Properties.ValueMember = "Id";
            balanceAccountEdit.Properties.DisplayMember = "Num";
            //balanceAccountEdit.Properties.NullText = "Немає данних";

            bankAccountEdit.Properties.DataSource = accountService.GetBankPaymentAccounts();
            bankAccountEdit.Properties.ValueMember = "Id";
            bankAccountEdit.Properties.DisplayMember = "Num";


            contractorsService = Program.kernel.Get<IContractorsService>();
            contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            supplierLookUp.Properties.DataSource = fixedAssetsOrderService.GetResponsible();
            supplierLookUp.Properties.ValueMember = "Id";
            supplierLookUp.Properties.DisplayMember = "FULLNAME";
            supplierLookUp.Properties.NullText = "Немає данних";

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            orderNumberEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull().OrderByDescending(srt => srt.OrderDate).ToList();
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "Немає данних";


        }

        #region Period
        private void beginYearEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null)
                _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);

        }

        private void beginMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null)
                _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);

        }

        private void endYearEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
                _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
            //_endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

        }

        private void endMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
                _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
            //_endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

        }

        #endregion

        #region StoreHouseReports

        #endregion

        #region ContractorsReports
        private void msTrialBalanceBtn_Click(object sender, EventArgs e)
        {
            if (contractorAccountsEdit.Text.Length == 0)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                switch (contractorAccountsEdit.Text)
                {
                    case "632":
                        if (!reportService.GetMSTrialBalanceCurrency(_beginDate, _endDate, contractorAccountsEdit.Text))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "681":
                        if (!reportService.GetMSTrialBalanceCurrency681(_beginDate, _endDate, contractorAccountsEdit.Text))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        if (!reportService.GetMSTrialBalance(_beginDate, _endDate, Flag1, Flag3, Flag4, PFlag3, PFlag4, contractorAccountsEdit.Text))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                splashScreenManager.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void msTrialBalanceByAccountsBtn_Click(object sender, EventArgs e)
        {
            if (contractorAccountsEdit.Text.Length == 0)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                switch (contractorAccountsEdit.Text)
                {
                    case "632":
                        if (!reportService.GetMSTrialBalanceByAccountsCurrency(_beginDate, _endDate, contractorAccountsEdit.Text))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "681":
                        if (!reportService.GetMSTrialBalanceByAccountsCurrency681(_beginDate, _endDate, contractorAccountsEdit.Text))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "39":
                        //if (!reportService.GetMSTrialBalanceByAccounts39(_beginDate, _endDate, contractorAccountsEdit.Text))
                        MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "531":
                        reportService.GetMSTrialBalanceByAccounts(_beginDate, _endDate, Flag1, Flag3, Flag4, PFlag3, PFlag4, true);
                        //MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        reportService.GetMSTrialBalanceByAccounts(_beginDate, _endDate, Flag1, Flag3, Flag4, PFlag3, PFlag4);
                       // MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                splashScreenManager.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        public void reconciliationBtn_Click(object sender, EventArgs e)
        {
            if (contractorsEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть контрагента.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (contractorAccountsEdit.Text.Length == 0)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            contractorsService = Program.kernel.Get<IContractorsService>();

            String currentContractorSrnCode = ((ContractorsDTO)contractorsService.GetContractorSrn((int)contractorsEdit.EditValue)).Srn;

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                switch (contractorAccountsEdit.Text)
                {
                    case "36+681":
                        if (!reportService.GetMSReconsiliation681_36(_beginDate, _endDate, (int)contractorsEdit.EditValue, 55, "36 - 681", contractorsEdit.Text, currentContractorSrnCode))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "36/1+681":
                        if (!reportService.GetMSReconsiliation681_36(_beginDate, _endDate, (int)contractorsEdit.EditValue, 24, "36/1 - 681", contractorsEdit.Text, currentContractorSrnCode))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    //----101,96
                    case "362+681":

                        bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();

                        bankPaymentsList = bankPaymentsService.GetBankPaymentsJournal(_beginDate, _endDate)
                            .Where(a => a.Contractor_Id == (int)contractorsEdit.EditValue).ToList()
                            .GroupBy(q => q.Id).Select(x => x.First()).ToList();

                        calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();

                        calcWithBuyersList = calcWithBuyersService.GetCalcWithBuyersJournal(_beginDate, _endDate)
                            .Where(a => a.ContractorsId == (int)contractorsEdit.EditValue).ToList();

                        calcWithBuyersForSaldoList = reportService.GetCWBShortForSaldo(_beginDate, _endDate, 101, "361")
                            .Where(a => a.ContractorsId == (int)contractorsEdit.EditValue).ToList();

                        if (!reportService.PrintMSReconciliation362_681(bankPaymentsList, calcWithBuyersList, calcWithBuyersForSaldoList, _beginDate, _endDate))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        if (!reportService.GetMSReconciliation(_beginDate, _endDate, (int)contractorsEdit.EditValue, PFlag3, PFlag4, contractorAccountsEdit.Text, contractorsEdit.Text, currentContractorSrnCode))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                splashScreenManager.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }
        #endregion

        #region BankReports

        //Flag1 -> Склад, Flag2 -> склад бух, Flag3 -> 631, Flag4 -> 63 
        private void contractorAccountsEdit_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (contractorAccountsEdit.Text)
            {
                case "631":
                    Flag1 = "1"; Flag3 = "1"; Flag4 = "-1";
                    PFlag3 = "15"; PFlag4 = "15";
                    break;
                case "63":
                    Flag1 = "-1"; Flag3 = "-1"; Flag4 = "1";
                    PFlag3 = "16"; PFlag4 = "16";
                    break;
                case "631, 63":
                    Flag1 = "1"; Flag3 = "1"; Flag4 = "1";
                    PFlag3 = "15"; PFlag4 = "16";
                    break;
                case "632":
                    Flag1 = "1"; Flag3 = "1"; Flag4 = "1";
                    PFlag3 = "60"; PFlag4 = "60";
                    break;
                case "681":
                    Flag1 = "1"; Flag3 = "1"; Flag4 = "1";
                    PFlag3 = "96"; PFlag4 = "96";
                    break;
                case "39":
                    Flag1 = "1"; Flag3 = "1"; Flag4 = "-1";
                    PFlag3 = "128"; PFlag4 = "128";
                    break;
                case "362,681":
                    Flag1 = "1"; Flag3 = "1"; Flag4 = "-1";
                    PFlag3 = "101"; PFlag4 = "96";
                    break;
                case "531":
                    Flag1 = "-1"; Flag3 = "-1"; Flag4 = "-1";
                    PFlag3 = "240"; PFlag4 = "240";
                    break;
            }

            debtorsCreditorsBtn.Enabled = (contractorAccountsEdit.Text != "681" && contractorAccountsEdit.Text != "39");
            paymentsWithoutVatBtn.Enabled = (contractorAccountsEdit.Text != "632" && contractorAccountsEdit.Text != "681" && contractorAccountsEdit.Text != "39");
            contractorsVatBtn.Enabled = (contractorAccountsEdit.Text != "632" && contractorAccountsEdit.Text != "681" && contractorAccountsEdit.Text != "39");
            reconciliationBtn.Enabled = (contractorAccountsEdit.Text != "39");
            msTrialBalanceBtn.Enabled = (contractorAccountsEdit.Text != "39");
        }

        private void debtorsCreditorsBtn_Click(object sender, EventArgs e)
        {

        }

        private void paymentsWithoutVatBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (contractorAccountsEdit.Text.Length == 0)
                {
                    MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetMSPaymentsWithoutVat(_beginDate, _endDate, PFlag3, PFlag4, contractorAccountsEdit.Text))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void cashbookTrialBalanceBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            try
            {

                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (_beginDate != null || _endDate != null)
                    reportService.GetCashBookTrialBalanceByAccounts((DateTime)_beginDate, (DateTime)_endDate);
                else
                    MessageBox.Show("Не вказана дата");

                splashScreenManager.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }

        }

        private void contractorsVatBtn_Click(object sender, EventArgs e)
        {
            try
            {

                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetContractorVat(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void msTrialBalance_631_63Btn_Click(object sender, EventArgs e)
        {
            if (contractorsEdit.Text != "Немає данних")
            {
                switch (contractorAccountsEdit.Text)
                {
                    case "631+63":
                        Flag1 = "1"; Flag3 = "1"; Flag4 = "1";
                        PFlag3 = "15"; PFlag4 = "16";

                        splashScreenManager.ShowWaitForm();
                        reportService = Program.kernel.Get<IReportService>();
                        //(int)contractorsEdit.EditValue
                        DateTime beginDate;
                        DateTime endDate;
                        beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                        endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

                        if (!reportService.GetDetalsReportByOperationContractors(beginDate, 1, 1, 1, 15, 16, endDate,
                            (int)contractorsEdit.EditValue, beginDate, endDate))
                            MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        splashScreenManager.CloseWaitForm();


                        break;
                    default:
                        MessageBox.Show("Оберіть будь-ласка рахунок!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else MessageBox.Show("Оберіть будь-ласка контрагента!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bankTrialBalanceReportBtn_Click(object sender, EventArgs e)
        {
            if (bankAccountEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                //string accountNum = bankAccountRepository.GetDisplayText((int)bankAccountEdit.EditValue);

                AccountsDTO item = (AccountsDTO)bankAccountEdit.GetSelectedDataRow();

                if (!reportService.GetBPReportTrialBalance((DateTime)_beginDate, (DateTime)_endDate, item.Id, item.Num, item.Description))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalance334ReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBPReportForCustomBill((DateTime)_beginDate, (DateTime)_endDate, 79, "334"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
        }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalance373ReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBPReportForCustomBill((DateTime)_beginDate, (DateTime)_endDate, 125, "373"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalanceQurtalReportBtn_Click(object sender, EventArgs e)
        {
            if (bankAccountEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                AccountsDTO item = (AccountsDTO)bankAccountEdit.GetSelectedDataRow();

                if (!reportService.GetBPReportTrialBalanceQuarter((DateTime)_beginDate, (DateTime)_endDate, item.Id, item.Num, item.Description))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalanceFullReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBPReportTrialBalanceFull((DateTime)_beginDate, (DateTime)_endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        #endregion

        #region StoreHouseReports

        #endregion

        #region FixedAssetsReports

        #endregion

        #region FixedAssetsReports

        private void fixedAssetsOrderByGroupBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsReportStraitBS = new BindingSource();
            if (beginYearEdit.EditValue.ToString() != endYearEdit.EditValue.ToString() || beginMonthEdit.EditValue.ToString() != endMonthEdit.EditValue.ToString())
            {
                MessageBox.Show("Выбран неверный период. \n Выберите только один месяц.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            splashScreenManager.ShowWaitForm();
            fixedAssetsReportStraitBS.DataSource = fixedAssetsOrderService.GetFixedAssetsReportStrait(_endDate);
            if (fixedAssetsReportStraitBS.Count == 0)
            {
                MessageBox.Show("За вибраний період немає даних!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                reportService.FixedAssetsReportStrait((List<FixedAssetsOrderReportStraitDTO>)fixedAssetsReportStraitBS.DataSource, _beginDate, _endDate, false);
            }
            splashScreenManager.CloseWaitForm();
        }

        private void fixedAssetsOrderByGroupAmortizationBtn_Click(object sender, EventArgs e)
        {

            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsReportStraitBS = new BindingSource();

            if (beginYearEdit.EditValue.ToString() != endYearEdit.EditValue.ToString() || beginMonthEdit.EditValue.ToString() != endMonthEdit.EditValue.ToString())
            {
                MessageBox.Show("Выбран неверный период. \n Выберите только один месяц.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            splashScreenManager.ShowWaitForm();
            fixedAssetsReportStraitBS.DataSource = fixedAssetsOrderService.GetFixedAssetsOrderByGroupAmortization(_endDate);
            if (fixedAssetsReportStraitBS.Count == 0)
            {
                MessageBox.Show("За вибраний період немає даних!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                reportService.FixedAssetsReportStrait((List<FixedAssetsOrderReportStraitDTO>)fixedAssetsReportStraitBS.DataSource, _beginDate, _endDate, false);
            }
            splashScreenManager.CloseWaitForm();

        }

        private void fixedAssetsOrderByGroupShortBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsOrderByGroupShortBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            fixedAssetsOrderByGroupShortBS.DataSource = fixedAssetsOrderService.GetFixedAssetsByGroupShort(_beginDate, _endDate);

            if (fixedAssetsOrderByGroupShortBS.Count == 0)
            {
                MessageBox.Show("За вибраний період немає даних!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                reportService.FixedAssetsReportGroupShort((List<FixedAssetsOrderByGroupShortReportDTO>)fixedAssetsOrderByGroupShortBS.DataSource, _beginDate, _endDate);
            }
            splashScreenManager.CloseWaitForm();
        }

        private void fixedAssetsOrderJournalFirstBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsOrderJournalFirstBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            fixedAssetsOrderJournalFirstBS.DataSource = fixedAssetsOrderService.GetFixedAssetsReportRegisterCh1(_endDate);
            splashScreenManager.CloseWaitForm();
            reportService.FixedAssetsRegisterCh1((List<FixedAssetsReportRegisterCh1DTO>)fixedAssetsOrderJournalFirstBS.DataSource, _beginDate, _endDate);

        }
        private void fixedAssetsOrderJournalSecondBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsOrderJournalSecondBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            fixedAssetsOrderJournalSecondBS.DataSource = fixedAssetsOrderService.GetFixedAssetsReportRegisterCh2(_beginDate, _endDate);
            splashScreenManager.CloseWaitForm();
            reportService.FixedAssetsRegisterCh2((List<FixedAssetsReportRegisterCh2DTO>)fixedAssetsOrderJournalSecondBS.DataSource, _beginDate, _endDate);

        }

        private void inputFixedForGroupBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource inputFixedForGroupBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            inputFixedForGroupBS.DataSource = fixedAssetsOrderService.GetInputFixedAssetsForGroup(_beginDate, _endDate);
            splashScreenManager.CloseWaitForm();
            reportService.InputFixedAssetsForGroup((List<InputFixedAssetsForGroupDTO>)inputFixedForGroupBS.DataSource, _beginDate, _endDate);

        }
        private void inputFixedForQuarterBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource inputFixedForQuarterBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            inputFixedForQuarterBS.DataSource = fixedAssetsOrderService.GetInputFixedForQuarter(_beginDate, _endDate);
            int test = ((DateTime)beginYearEdit.EditValue).Year;
            reportService.InputFixedAssetsForQuarterReport((List<InputFixedAssetsForQuarterDTO>)inputFixedForQuarterBS.DataSource, test.ToString());
            splashScreenManager.CloseWaitForm();
        }

        private void invoicesForFixedAssetsBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            BindingSource invoicesForFixedAssetsBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            invoicesForFixedAssetsBS.DataSource = storeHouseService.GetInvoicesFixedAssetsInfo(_beginDate, _endDate);

            reportService.InvoicesForFixedAssets((List<InvoicesFixedAssetsInfoDTO>)invoicesForFixedAssetsBS.DataSource,
                                                 (_beginDate.Date.ToShortDateString()), (_endDate.Date.ToShortDateString()));

            splashScreenManager.CloseWaitForm();


            //code empty in AIS
        }
        private void inventoryFixedAssetsForGroupsBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsReportStraitBS = new BindingSource();
            splashScreenManager.ShowWaitForm();
            fixedAssetsReportStraitBS.DataSource = fixedAssetsOrderService.GetInventoryFixedAssetsForGroups(_endDate).ToList();

            if (fixedAssetsReportStraitBS.Count == 0)
            {
                MessageBox.Show("За вибраний період немає даних!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                reportService.InventoryFixedAssetsForGroups((List<FixedAssetsOrderReportStraitDTO>)fixedAssetsReportStraitBS.DataSource, _endDate);
            }
            splashScreenManager.CloseWaitForm();
        }

        private void inventoryFixedAssetsBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            BindingSource fixedAssetsReportStraitBS = new BindingSource();

            var supId = supplierLookUp.EditValue;
            if (supId != null)
            {
                splashScreenManager.ShowWaitForm();
                int emp = ((ResponsibleDTO)supId).EMPLOYEEID;// ((EmployeesInfoDTO)supId).EmployeeID;
                fixedAssetsReportStraitBS.DataSource = fixedAssetsOrderService.GetInventoryFixedAssetsForGroups(_endDate)
                    .Where(a => a.SupplierId == emp).ToList();
                splashScreenManager.CloseWaitForm();

                if (fixedAssetsReportStraitBS.Count == 0)
                {
                    MessageBox.Show("За вибраний період немає даних!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    reportService.InventoryForFixedAssets((List<FixedAssetsOrderReportStraitDTO>)fixedAssetsReportStraitBS.DataSource, _endDate);
                }
            }
            else { MessageBox.Show("Заповніть будь-ласка поле замовника!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        #endregion

        #region CalcWithBuyersReports
        private void calcWithBuyersReportBtn_Click(object sender, EventArgs e)
        {

            if (balanceAccountEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                if (!reportService.GetCWBShortReport(_beginDate, _endDate, (int)balanceAccountEdit.EditValue, (string)balanceAccountEdit.Text))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashScreenManager.CloseWaitForm();
                return;
            }
        }

        private void calcWithBuyersByAccountReportBtn_Click(object sender, EventArgs e)
        {
            if (balanceAccountEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                if (!reportService.GetCWBReport(_beginDate, _endDate, (int)balanceAccountEdit.EditValue, (string)balanceAccountEdit.Text))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashScreenManager.CloseWaitForm();
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (orderNumberEdit.EditValue == null)
                return;

            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            List<ExpenditureInfoDTO> expenditureByCustomerOrderList = storeHouseService.GetExpenditureByCustomerOrder((int)orderNumberEdit.EditValue).Where(srch => srch.CreditAccountId != null).ToList();

            if (expenditureByCustomerOrderList.Count == 0)
            {
                MessageBox.Show("Відсутні списання!", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();


                if (!reportService.ExpendituresForProject(expenditureByCustomerOrderList))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashScreenManager.CloseWaitForm();
                return;
            }

        }

        #endregion

        #region BusinessTripPaymentsReports


        private void cashPaymentReportBtn_Click(object sender, EventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();

            if (!reportService.GetCPReportByAccounts(_beginDate, _endDate))
                MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bstOSVReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportByAccounts(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bstCurrencyPeriodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportCurrencyPeriod(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bstDocumentsReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportDocumentsPeriod(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bstEmployeesReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportEmployeesByPeriod(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bstReportPaymentsBy23_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByAccountId(_beginDate, _endDate, 18, "23"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bstReportPaymentsBy63_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPrepaymentsByAccountId(_beginDate, _endDate, 16, "63"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bstReportPaymentsBy6412_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByVatAccountId(_beginDate, _endDate, 38, "641.2"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        #endregion

        #region Expenditure Report's

        private void expenditureByProjectReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetExpenditureForProjectByPeriod(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
            }

        private void storeHouseTrialBalanceReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetTrialBalanceReport(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void storeHouseInventoryReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetStoreHouseInventoryReport(_endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void operationActBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();
                accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
                reportService = Program.kernel.Get<IReportService>();

                var accountingInvoices = accountingInvoicesService.GetInvoices(_beginDate, _endDate);

                if (!reportService.GetOperationActByPeriod(_beginDate, _endDate, accountingInvoices))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        public void testChess()
        {
            accountsService = Program.kernel.Get<IAccountsService>();
                reportService = Program.kernel.Get<IReportService>();
            //----
                DateTime _endDate = new DateTime(2021, 02, 28);//(2021,02,28);
                DateTime _beginDate = new DateTime(2021, 02, 01);//(2021, 02, 01);

            //---
            // String currentContractorSrnCode = ((ContractorsDTO)contractorsService.GetContractorSrn((int)contractorsEdit.EditValue)).Srn;
            // List<AccountsDTO>accList= accountService.GetAllAccounts().ToList();//.Where(a=>a.Num.Remove(3,1)).ToList();
            //accountService.GetAllAccounts();
            List<AccountsDTO> accountList = new List<AccountsDTO>();
            accountList = accountService.GetAllAccounts().ToList();
            List<FixedAssetsReportRegisterCh1DTO> faGroupShort103 = new List<FixedAssetsReportRegisterCh1DTO>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            faGroupShort103 = fixedAssetsOrderService.GetFixedAssetsReportRegisterCh1(_endDate).ToList();

            List<InvoicesDTO> invoicesInfoList = new List<InvoicesDTO>();
         //   List<InvoicesSortDTO> invoicesSortList = new List<InvoicesSortDTO>();
            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            invoicesInfoList = accountingInvoicesService.GetInvoices(_beginDate, _endDate).OrderByDescending(sort => sort.Month_Current).ToList();

            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
            List<CalcWithBuyersInfoDTO> calcWithBayersInfoList = new List<CalcWithBuyersInfoDTO>();
            calcWithBayersInfoList = calcWithBuyersService.GetCalcWithBuyersJournal(_beginDate, _endDate).ToList();


            

            try
            {
                //fixedAssetsOrderByGroupShort();
                reportService.PrintChessAccount(accountList, (DateTime)_beginDate, (DateTime)_endDate, faGroupShort103, invoicesInfoList, calcWithBayersInfoList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //  splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void chessBtn_Click(object sender, EventArgs e)
            {
            testChess();

            }

        private void bankTrialBalance313ReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                accountService = Program.kernel.Get<IAccountsService>();

                List<AccountsDTO> allAccounts313 = accountService.GetAccounts().Where(bdsm => bdsm.Num.Contains("313") && bdsm.Num.Length > 6).ToList();

                List<BankPaymentsReportTrialBalanceAll313DTO> trialBalanceShortAcount313 = new List<BankPaymentsReportTrialBalanceAll313DTO>();

                for (int i = 0; i < allAccounts313.Count; ++i)
                {
                    reportService = Program.kernel.Get<IReportService>();

                    List<BankPaymentsReportTrialBalanceAll313DTO> bufferList = reportService.GetBPReportTrialBalanceShort((DateTime)_beginDate, (DateTime)_endDate, allAccounts313[i].Id);

                    for (int j = 0; j < bufferList.Count; ++j)
                    {

                        bufferList[j].RecId = i + j;
                        trialBalanceShortAcount313.Add(bufferList[j]);
                    }

                }

                reportService.PrintBPReportTrialBalanceShortAllAccount313(trialBalanceShortAcount313, (DateTime)_beginDate, (DateTime)_endDate);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void storeHouseTrialBalanceAccountReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetTrialBalanceByAccountsReport(_beginDate, _endDate))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<InvoicesDTO> invoicesInfoList = new List<InvoicesDTO>();
                List<InvoicesSortDTO> invoicesSortList = new List<InvoicesSortDTO>();
                accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
                invoicesInfoList = accountingInvoicesService.GetInvoices(_beginDate, _endDate).OrderByDescending(sort => sort.Month_Current).ToList();
                invoicesSortList = invoicesInfoList.Where(a => a.Bal_Name == "63-641/2" || a.Bal_Name == "631-641/2").GroupBy(l => l.Balance_Account_Id).Select(cl => new InvoicesSortDTO
                {
                    SumVat = cl.Sum(cv => cv.Vat)
                }).ToList();

                calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();

                List<CalcWithBuyersInfoDTO> calcWithBayersInfoList36_1 = new List<CalcWithBuyersInfoDTO>();
                calcWithBayersInfoList36_1 = calcWithBuyersService.GetCalcWithBuyersJournal(_beginDate, _endDate).Where(a => a.BalanceNum == "712" && a.PurposeNum == "36/1").ToList();


                //try
                //{
                //    //fixedAssetsOrderByGroupShort();
                //    reportService.PrintChessAccount(accountList, (DateTime)_beginDate, (DateTime)_endDate, faGroupShort103, invoicesSortList, calcWithBayersInfoList36_1);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    splashScreenManager.CloseWaitForm();

                //    return;
                //}
            }
            catch (Exception ex)
            {

            }


        }
        #endregion

        
    }
}