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

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingTransferFm : DevExpress.XtraEditors.XtraForm
    {
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();

        private IAccountsService accountsService;
        private IPeriodService periodService;
        private IAccountingOperationService accountingOperationService;
        private ILogService logService;
        private IBusinessTripsService businessTripsService;

        private UserTasksDTO userTasksDTO;
        private DateTime beginDate;
        private DateTime endDate;

        private BindingSource accountOperationsBS = new BindingSource();

        private const string NameForm = "AccountingTransferFm";

        public AccountingTransferFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            beginYearEdit.EditValueChanged -= beginYearEdit_EditValueChanged;
            endYearEdit.EditValueChanged -= endYearEdit_EditValueChanged;
            beginMonthEdit.EditValueChanged -= beginMonthEdit_EditValueChanged;
            endMonthEdit.EditValueChanged -= endMonthEdit_EditValueChanged;

            if (Properties.Settings.Default.AccountingOperationsFmBeginYear.Year < 2000)
                beginYearEdit.EditValue = DateTime.Now;
            else
                beginYearEdit.EditValue = Properties.Settings.Default.AccountingOperationsFmBeginYear;

            if (Properties.Settings.Default.AccountingOperationsFmEndYear.Year < 2000)
                endYearEdit.EditValue = DateTime.Now;
            else
                endYearEdit.EditValue = Properties.Settings.Default.AccountingOperationsFmEndYear;

            if (Properties.Settings.Default.AccountingOperationsFmBeginMonth == 0)
                beginMonthEdit.EditValue = DateTime.Now.Month;
            else
                beginMonthEdit.EditValue = Properties.Settings.Default.AccountingOperationsFmBeginMonth;

            if (Properties.Settings.Default.AccountingOperationsFmEndMonth == 0)
                endMonthEdit.EditValue = DateTime.Now.Month;
            else
                endMonthEdit.EditValue = Properties.Settings.Default.AccountingOperationsFmEndMonth;

            beginYearEdit.EditValueChanged += beginYearEdit_EditValueChanged;
            endYearEdit.EditValueChanged += endYearEdit_EditValueChanged;
            beginMonthEdit.EditValueChanged += beginMonthEdit_EditValueChanged;
            endMonthEdit.EditValueChanged += endMonthEdit_EditValueChanged;

            //beginYearEdit.EditValue = DateTime.Now;
            //endYearEdit.EditValue = DateTime.Now;

            //beginMonthEdit.EditValue = DateTime.Now.Month;
            //endMonthEdit.EditValue = DateTime.Now.Month;

            SelectDate();

            AuthorizatedUserAccess();


            LoadDataByPeriod(beginDate, endDate);
        }

        private void LoadDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            accountingOperationService = Program.kernel.Get<IAccountingOperationService>();
            logService = Program.kernel.Get<ILogService>();

            accountOperationsBS.DataSource = accountingOperationService.GetAccountingOperaionsList(beginDate, endDate);
            transferGrid.DataSource = accountOperationsBS;

            SetPeriodBtnImage();

            splashScreenManager.CloseWaitForm();
        }

        private void SetPeriodBtnImage()
        {
            if (CheckPeriodAccess(beginDate))
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

        private void barEditItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadColorsPallete()
        {
            splashScreenManager.ShowWaitForm();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            colorsPallete = businessTripsService.GetColors().ToList();


            for (int i = contextMenuStrip.Items.Count; i > 2; i--)
            {
                contextMenuStrip.Items.RemoveAt(i - 1);
            }

            for (int i = 0; i < colorsPallete.Count; i++)
            {
                ToolStripMenuItem MenuItem = new ToolStripMenuItem()
                {
                    Text = colorsPallete[i].Name_Rus.ToString(),
                    Image = Rgb2Bitmap(colorsPallete[i].Color_Code.ToString()),
                    ToolTipText = colorsPallete[i].Name.ToString(),
                    Tag = colorsPallete[i].Id
                };
                contextMenuStrip.Items.Add(MenuItem);
            }

            splashScreenManager.CloseWaitForm();
        }

        public Bitmap Rgb2Bitmap(string HtmlRgb)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(HtmlRgb));
            graphics.FillRectangle(brush, 0, 0, 16, 16);
            return bitmap;
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(beginDate, endDate);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccountingOperations(Utils.Operation.Add, new AccountingOperationsDTO() { UserId = userTasksDTO.UserId });
        }

        private void EditAccountingOperations(Utils.Operation operation, AccountingOperationsDTO model)
        {
            using (AccountingTransferEditFm accountingTransferEditFm = new AccountingTransferEditFm(operation, model, userTasksDTO))
            {
                if (accountingTransferEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AccountingOperationsDTO returnItem = accountingTransferEditFm.Return();
                    transferGridView.BeginDataUpdate();

                    LoadDataByPeriod(beginDate, endDate);

                    transferGridView.EndDataUpdate();

                    int rowHandle = transferGridView.LocateByValue("Id", returnItem.Id);

                    transferGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentsBS.Current;
            EditAccountingOperations(Utils.Operation.Update, (AccountingOperationsDTO)accountOperationsBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (accountOperationsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    accountingOperationService = Program.kernel.Get<IAccountingOperationService>();
                    int rowHandle = transferGridView.FocusedRowHandle - 1;
                    transferGridView.BeginDataUpdate();
                    accountingOperationService.AccountOperationsDelete(((AccountingOperationsDTO)accountOperationsBS.Current).Id);
                    LoadDataByPeriod(beginDate, endDate);
                    transferGridView.EndDataUpdate();
                    transferGridView.FocusedRowHandle = (transferGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void beginYearEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccountingOperationsFmBeginYear = (DateTime)beginYearEdit.EditValue;
            SelectDate();
            SetPeriodBtnImage();
            Properties.Settings.Default.Save();
        }

        private void beginMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccountingOperationsFmBeginMonth = (int)beginMonthEdit.EditValue;
            SelectDate();
            SetPeriodBtnImage();
            Properties.Settings.Default.Save();
            
        }

        private void endYearEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccountingOperationsFmEndYear = (DateTime)endYearEdit.EditValue;
            Properties.Settings.Default.Save();
            SelectDate();
        }

        private void endMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccountingOperationsFmEndMonth = (int)endMonthEdit.EditValue;
            Properties.Settings.Default.Save();
            SelectDate();
        }

        public void SelectDate()
        {
            beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
        }

        private void periodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (CheckPeriodAccess(beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                        model.StateBank = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (CheckPeriodExist(beginDate))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                            model.StateBank = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = beginDate.Year,
                                Month = beginDate.Month,
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
                    logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTasksDTO, NameForm);
                    return;
                }
            }
        }
    }
}