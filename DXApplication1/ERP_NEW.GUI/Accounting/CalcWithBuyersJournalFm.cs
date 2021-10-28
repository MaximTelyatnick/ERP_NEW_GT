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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Infrastructure;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraGrid;

namespace ERP_NEW.GUI.Accounting
{
    public partial class CalcWithBuyersJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private ICalcWithBuyersService calcWithBuyersService;
        private IPeriodService periodService;
        private IReportService reportService;
        private IAccountsService accountsService;

        private BindingSource calcWithBuyersBS = new BindingSource();
        private BindingSource calcWithBuyersSpecBS = new BindingSource();

        private UserTasksDTO _userTasksDTO;
        private DateTime _beginDate;
        private DateTime _endDate;

        private decimal totalPriceSummary = 0.00m;
        private decimal paymentDebit = 0.00m;
        private decimal paymentDebitCurrency = 0.00m;
        private decimal paymentCredit = 0.00m;
        private decimal paymentCreditCurrency = 0.00m;
        private decimal paymentVatPrice = 0.00m;
        private int rowId = 0;

        public CalcWithBuyersJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            _beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            _endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginReportDateEdit.EditValue = _beginDate;
            endReportDateEdit.EditValue = _endDate;

            AuthorizatedUserAccess();
            
            LoadDataByPeriod(_beginDate, _endDate);

            accountsService = Program.kernel.Get<IAccountsService>();
            balanceAccountsRepository.DataSource = accountsService.GetCalcWithBuyerAccounts();
            balanceAccountsRepository.ValueMember = "Id";
            balanceAccountsRepository.DisplayMember = "Num";
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            periodBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();

            calcWithBuyersBS.DataSource = calcWithBuyersService.GetCalcWithBuyersJournal(_beginDate, _endDate);
            calcWithBuyersGrid.DataSource = calcWithBuyersBS;

            if (calcWithBuyersBS.Count > 0)
            {
                LoadCalcWithBuyersSpecDateById(((CalcWithBuyersInfoDTO)calcWithBuyersBS.Current).Id);
            }
            else
            {
                calcWithBuyersBS.DataSource = null;
            }

            SetPeriodBtnImage();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadCalcWithBuyersSpecDateById(int id)
        {
            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();

            calcWithBuyersSpecBS.DataSource = calcWithBuyersService.GetCalcWithBuyersSpec(id);
            calcWithBuyersSpecGrid.DataSource = calcWithBuyersSpecBS;
        }

        private void EditCalcWithBuyers(Utils.Operation operation, CalcWithBuyersDTO model, List<CalcWithBuyersSpecDTO> source)
        {
            using (CalcWithBuyersEditFm calcWithBuyersEditFm = new CalcWithBuyersEditFm(operation, model, source))
            {
                if (calcWithBuyersEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CalcWithBuyersDTO returnItem = calcWithBuyersEditFm.Return();
                    calcWithBuyersGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);

                    calcWithBuyersGridView.EndDataUpdate();

                    int rowHandle = calcWithBuyersGridView.LocateByValue("Id", returnItem.Id);

                    calcWithBuyersGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void SetPeriodBtnImage()
        {
            if (CheckPeriodAccess(_beginDate))
            {
                periodBtn.Glyph = imageCollection.Images[1];
                periodBtn.LargeGlyph = imageCollection.Images[1];
                periodBtn.Caption = "Закрити період";
            }
            else
            {
                periodBtn.Glyph = imageCollection.Images[0];
                periodBtn.LargeGlyph = imageCollection.Images[0];
                periodBtn.Caption = "Відкрити період";
            }

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
        
        #endregion

        #region Event's

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditCalcWithBuyers(Utils.Operation.Add, new CalcWithBuyersDTO() { UserId = _userTasksDTO.UserId }, new List<CalcWithBuyersSpecDTO>());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (calcWithBuyersBS.Count > 0)
            {
                CalcWithBuyersInfoDTO item = (CalcWithBuyersInfoDTO)calcWithBuyersBS.Current;
                CalcWithBuyersDTO model = new CalcWithBuyersDTO()
                {
                    Id = item.Id,
                    AccountingOperationId = item.AccountingOperationId,
                    BalanceAccountId = item.BalanceAccountId,
                    ContractorsId = item.ContractorsId,
                    CurrencyRatesId = item.CurrencyRatesId,
                    DocumentDate = item.DocumentDate,
                    DocumentName = item.DocumentName,
                    EmployeesId = item.EmployeesId,
                    Payment = item.Payment,
                    PurposeAccountId = item.PurposeAccountId,
                    UserId = _userTasksDTO.UserId
                };

                EditCalcWithBuyers(Utils.Operation.Update, model, (List<CalcWithBuyersSpecDTO>)calcWithBuyersSpecBS.DataSource);
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (calcWithBuyersBS.Count != 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
                    int rowHandle = calcWithBuyersGridView.FocusedRowHandle - 1;
                    calcWithBuyersGridView.BeginDataUpdate();
                    calcWithBuyersService.CalcWithBuyerDelete(((CalcWithBuyersInfoDTO)calcWithBuyersBS.Current).Id);
                    LoadDataByPeriod(_beginDate, _endDate);
                    calcWithBuyersGridView.EndDataUpdate();
                    calcWithBuyersGridView.FocusedRowHandle = (calcWithBuyersGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void calcWithBuyersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (calcWithBuyersBS.Count > 0)
            {
                LoadCalcWithBuyersSpecDateById(((CalcWithBuyersInfoDTO)calcWithBuyersBS.Current).Id);
            }
        }

        private void calcWithBuyersGridView_DoubleClick(object sender, EventArgs e)
        {
            if (calcWithBuyersBS.Count > 0 && _userTasksDTO.AccessRightId == 2)
            {
                CalcWithBuyersInfoDTO item = (CalcWithBuyersInfoDTO)calcWithBuyersBS.Current;
                CalcWithBuyersDTO model = new CalcWithBuyersDTO()
                {
                    Id = item.Id,
                    AccountingOperationId = item.AccountingOperationId,
                    BalanceAccountId = item.BalanceAccountId,
                    ContractorsId = item.ContractorsId,
                    CurrencyRatesId = item.CurrencyRatesId,
                    DocumentDate = item.DocumentDate,
                    DocumentName = item.DocumentName,
                    EmployeesId = item.EmployeesId,
                    Payment = item.Payment,
                    PurposeAccountId = item.PurposeAccountId,
                    UserId = _userTasksDTO.UserId
                };

                EditCalcWithBuyers(Utils.Operation.Update, model, (List<CalcWithBuyersSpecDTO>)calcWithBuyersSpecBS.DataSource);
            }
        }

        private void periodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (CheckPeriodAccess(_beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(_beginDate.Year, _beginDate.Month);
                        model.StateBank = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (CheckPeriodExist(_beginDate))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(_beginDate.Year, _beginDate.Month);
                            model.StateBank = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = _beginDate.Year,
                                Month = _beginDate.Month,
                                State = false,
                                StateBank = true,
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
        
        private void calcWithBuyersReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                string accountNum = balanceAccountsRepository.GetDisplayText((int)balanceAccountEdit.EditValue);

                if (!reportService.GetCWBShortReport((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, (int)balanceAccountEdit.EditValue, accountNum))
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

        private void calcWithBuyersByAccountReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                string accountNum = balanceAccountsRepository.GetDisplayText((int)balanceAccountEdit.EditValue);

                if (!reportService.GetCWBReport((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, (int)balanceAccountEdit.EditValue, accountNum))
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

        private void calcWithBuyersGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;

            decimal payment = Convert.ToDecimal(calcWithBuyersGridView.GetListSourceRowCellValue(rowIndex, "Payment"));
            decimal paymentVatPrice = Convert.ToDecimal(calcWithBuyersGridView.GetListSourceRowCellValue(rowIndex, "PaymentVatPrice"));

            if (e.Column.Name == "totalPriceWithVatCol")
            {
                if (e.IsGetData)
                    e.Value = payment + paymentVatPrice;
            }
        }

        #endregion

        private void calcWithBuyersGridView_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            CalcWithBuyersInfoDTO model1 = (CalcWithBuyersInfoDTO)view.GetRow(e.RowHandle1);
            CalcWithBuyersInfoDTO model2 = (CalcWithBuyersInfoDTO)view.GetRow(e.RowHandle2);
                            
            if (e.Column.FieldName != "CustomerNumber")
            {
                e.Merge = (model1.Id == model2.Id);
                e.Handled = true;
            }
        }

        private void calcWithBuyersGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {            
            int itemId = 0;

            if (e.IsTotalSummary)
            {
                GridView view = sender as GridView;
                string fieldName = ((GridSummaryItem)e.Item).FieldName;

                switch (e.SummaryProcess)
                {
                    //calculation entry point 
                    case CustomSummaryProcess.Start:
                        rowId = 0;
                        totalPriceSummary = 0;
                        paymentDebit = 0;
                        paymentCredit = 0;
                        paymentDebitCurrency = 0;
                        paymentCreditCurrency = 0;
                        paymentVatPrice = 0;
                        break;
                    //consequent calculations 
                    case CustomSummaryProcess.Calculate:
                        itemId = ((CalcWithBuyersInfoDTO)view.GetRow(e.RowHandle)).Id;

                        if (itemId != rowId)
                        {
                            rowId = itemId;
                            
                            if (fieldName == "TotalPrice")
                                totalPriceSummary += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "PaymentDebit")
                                paymentDebit += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "PaymentDebitCurrency")
                                paymentDebitCurrency += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "PaymentCredit")
                                paymentCredit += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "PaymentCreditCurrency")
                                paymentCreditCurrency += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "PaymentVatPrice")
                                paymentVatPrice += Convert.ToDecimal(e.FieldValue);
                        }
                        break;
                    //final summary value 
                    case CustomSummaryProcess.Finalize:

                        if(fieldName == "TotalPrice")
                            e.TotalValue = totalPriceSummary;
                        
                        if (fieldName == "PaymentDebit")
                            e.TotalValue = paymentDebit;

                        if (fieldName == "PaymentDebitCurrency")
                            e.TotalValue = paymentDebitCurrency;

                        if (fieldName == "PaymentCredit")
                            e.TotalValue = paymentCredit;

                        if (fieldName == "PaymentCreditCurrency")
                            e.TotalValue = paymentCreditCurrency;

                        if (fieldName == "PaymentVatPrice")
                            e.TotalValue = paymentVatPrice;

                        break;
                }
            }

        }
    }
}