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

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class CashPaymentJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IReportService reportService;
        
        private BindingSource cashPrepaymentsBS = new BindingSource();
        private BindingSource cashPaymentsBS = new BindingSource();

        private UserTasksDTO _userTasksDTO;
        private DateTime _beginDate;
        private DateTime _endDate;

        public CashPaymentJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            _userTasksDTO = userTasksDTO;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            _beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            _endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginReportDateEdit.EditValue = _beginDate;
            endReportDateEdit.EditValue = _endDate;

            saldoDebitEdit.DataBindings.Add("EditValue", cashPrepaymentsBS, "SaldoDebit");
            saldoCreditEdit.DataBindings.Add("EditValue", cashPrepaymentsBS, "SaldoCredit");
            
            AuthorizatedUserAccess();

            LoadDataByPeriod(_beginDate, _endDate);
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addPrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editPrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deletePrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);

            addPaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deletePaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            cashPrepaymentsBS.DataSource = businessTripsService.GetCashPrepaymentsByPeriod(_beginDate, _endDate);
            prepaymentsGrid.DataSource = cashPrepaymentsBS;

            if (cashPrepaymentsBS.Count > 0)
            {
                LoadPaymentDateById(((CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current).Id);
            }
            else
            {
                cashPaymentsBS.DataSource = null;
            }

            saldoCaption.Caption = "Сальдо на " + DateTime.Today.ToShortDateString();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadPaymentDateById(int id)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            cashPaymentsBS.DataSource = businessTripsService.GetCashPaymentsById(id);
            paymentsGrid.DataSource = cashPaymentsBS;
        }

        private void EditPrepayment(Utils.Operation operation, CashPrepaymentsDTO model)
        {
            using (CashPrepaymentEditFm cashPrepaymentEditFm = new CashPrepaymentEditFm(operation, model))
            {
                if (cashPrepaymentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CashPrepaymentsDTO returnId = cashPrepaymentEditFm.Return();
                    prepaymentsGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);

                    prepaymentsGridView.EndDataUpdate();

                    int rowHandle = prepaymentsGridView.LocateByValue("Id", returnId.Id);

                    prepaymentsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void AddPayment()
        {
            using (CashPaymentReceiptListFm cashPaymentReceiptListFm = new CashPaymentReceiptListFm(((CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current).Id))
            {
                if (cashPaymentReceiptListFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {                    
                    paymentsGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);
                                                            
                    paymentsGridView.EndDataUpdate();

                    int rowHandle = paymentsGridView.LocateByValue("Id", ((CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current).Id);
                    paymentsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void EditPayment(Utils.Operation operation, CashPaymentsDTO model)
        {
            using (CashPaymentEditFm cashPaymentEditFm = new CashPaymentEditFm(operation, model))
            {
                if (cashPaymentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CashPaymentsDTO returnItem = cashPaymentEditFm.Return();
                    paymentsGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);

                    paymentsGridView.EndDataUpdate();

                    int rowHandle = paymentsGridView.LocateByValue("Id", returnItem.Id);

                    paymentsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        #endregion

        #region Event's

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void addPrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditPrepayment(Utils.Operation.Add, new CashPrepaymentsDTO() { UserId = _userTasksDTO.UserId });
        }

        private void editPrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cashPrepaymentsBS.Count > 0)
            {
                CashPrepaymentsInfoDTO item = (CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current;
                CashPrepaymentsDTO model = new CashPrepaymentsDTO()
                {
                    Id = item.Id,
                    AccountId = item.AccountId,
                    PrepaymentDate = item.PrepaymentDate,
                    PrepaymentPrice = item.PrepaymentPrice,
                    EmployeesId = item.EmployeesId,
                    DateAdded = item.DateAdded,
                    UserId = item.UserId
                };

                EditPrepayment(Utils.Operation.Update, model);
            }
        }

        private void deletePrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cashPrepaymentsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити аванс?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                    int rowHandle = prepaymentsGridView.FocusedRowHandle - 1;
                    prepaymentsGridView.BeginDataUpdate();
                    businessTripsService.CashPrepaymentDelete(((CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current).Id);
                    LoadDataByPeriod(_beginDate, _endDate);
                    prepaymentsGridView.EndDataUpdate();
                    prepaymentsGridView.FocusedRowHandle = (prepaymentsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void reportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();

            if (!reportService.GetCPReportByAccounts((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
                MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addPaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cashPrepaymentsBS.Count > 0)
                AddPayment();
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cashPaymentsBS.Count > 0)
            {
                CashPaymentsInfoDTO item = (CashPaymentsInfoDTO)cashPaymentsBS.Current;
                CashPaymentsDTO model = new CashPaymentsDTO(){
                 Id = item.Id,
                 CashPrepaymentId = item.CashPrepaymentId,
                 CustomerOrderId = item.CustomerOrderId,
                 DateAdded = item.DateAdded,
                 ReceiptId = item.ReceiptId,
                 UserId = item.UserId,
                 VatAccountId = item.VatAccountId,
                 VatPrice = item.VatPrice};

                EditPayment(Utils.Operation.Update, model);
            }
        }

        private void deletePaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            paymentsGridView.PostEditor();

            if (!((List<CashPaymentsInfoDTO>)cashPaymentsBS.DataSource).Any(c => c.Selected))
                return;

            if (MessageBox.Show("Ви впевнені що бажаєте видалити елементи?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    List<CashPaymentsDTO> checkList = (from p in (List<CashPaymentsInfoDTO>)cashPaymentsBS.DataSource
                                                               where p.Selected
                                                               select new CashPaymentsDTO()
                                                               {
                                                                   Id = p.Id,
                                                                   CashPrepaymentId = p.CashPrepaymentId,
                                                                   CustomerOrderId = p.CustomerOrderId,
                                                                   DateAdded = p.DateAdded,
                                                                   ReceiptId = p.ReceiptId,
                                                                   UserId = p.UserId,
                                                                   VatAccountId = p.VatAccountId,
                                                                   VatPrice = p.VatPrice
                                                               }).ToList();

                    paymentsGridView.BeginDataUpdate();

                    businessTripsService.CashPaymentRemoveRange(checkList);

                    LoadPaymentDateById(((CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current).Id);

                    paymentsGridView.EndDataUpdate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення авансу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
                
        private void prepaymentsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (cashPrepaymentsBS.Count > 0)
            {
                CashPrepaymentsInfoDTO item = (CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current;
                CashPrepaymentsDTO model = new CashPrepaymentsDTO()
                {
                    Id = item.Id,
                    AccountId = item.AccountId,
                    PrepaymentDate = item.PrepaymentDate,
                    PrepaymentPrice = item.PrepaymentPrice,
                    EmployeesId = item.EmployeesId,
                    DateAdded = item.DateAdded,
                    UserId = item.UserId
                };

                EditPrepayment(Utils.Operation.Update, model);
            }
        }

        private void prepaymentsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (cashPrepaymentsBS.Count > 0)
            {
                LoadPaymentDateById(((CashPrepaymentsInfoDTO)cashPrepaymentsBS.Current).Id);
            }
        }

        private void paymentsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (cashPaymentsBS.Count > 0)
            {
                CashPaymentsInfoDTO item = (CashPaymentsInfoDTO)cashPaymentsBS.Current;
                CashPaymentsDTO model = new CashPaymentsDTO()
                {
                    Id = item.Id,
                    CashPrepaymentId = item.CashPrepaymentId,
                    CustomerOrderId = item.CustomerOrderId,
                    DateAdded = item.DateAdded,
                    ReceiptId = item.ReceiptId,
                    UserId = item.UserId,
                    VatAccountId = item.VatAccountId,
                    VatPrice = item.VatPrice
                };

                EditPayment(Utils.Operation.Update, model);
            }
        }

        #endregion
    }
}