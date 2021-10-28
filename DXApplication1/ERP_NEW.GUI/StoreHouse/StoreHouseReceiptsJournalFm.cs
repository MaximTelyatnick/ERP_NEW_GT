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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseReceiptsJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource receiptsBS = new BindingSource();

        public UserTasksDTO _userTasksDTO;

        public StoreHouseReceiptsJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            beginDateEdit.EditValue = firstDay;
            endDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            LoadStoreHouseReceiptsData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void LoadStoreHouseReceiptsData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            receiptsBS.DataSource = storeHouseService.GetReceiptsByPeriod(beginDate, endDate);
            receiptsGrid.DataSource = receiptsBS;

            splashScreenManager.CloseWaitForm();
        }

        public void AuthorizatedUserAccess()
        {
            unitPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);
            totalPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStoreHouseReceiptsData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void printBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                receiptsGridView.ExportToXls(Utils.HomePath + @"\Temp\Матеріали та послуги.xls");

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.Arguments = "\"" + Utils.HomePath + @"\Temp\Матеріали та послуги.xls" + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
            catch (System.IO.IOException) { MessageBox.Show("Документ вже відкритий!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Microsoft Excel не встановлено на ПК!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch { MessageBox.Show("Документ вже відкритий!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStoreHouseReceiptsData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

    }
}