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
        private IAccountingOperationService accountingOperationService;
        private ILogService logService;
        private IBusinessTripsService businessTripsService;

        private UserTasksDTO userTasksDTO;
        private DateTime beginDate;
        private DateTime endDate;

        private BindingSource accountOperationsBS = new BindingSource();

        public AccountingTransferFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

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

            //SetPeriodBtnImage();

            splashScreenManager.CloseWaitForm();
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
    }
}