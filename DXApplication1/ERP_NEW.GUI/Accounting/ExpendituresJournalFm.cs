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
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class ExpendituresJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource expendituresBS = new BindingSource();

        private IStoreHouseService storeHouseService;

        private DateTime beginDate;
        private DateTime endDate;

        public ExpendituresJournalFm(DateTime currentDate)
        {
            InitializeComponent();

            this.beginDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            this.endDate = beginDate.AddMonths(1).AddDays(-1);

            beginDateEdit.EditValue = beginDate;
            endDateEdit.EditValue = endDate;

            LoadExpendituresjournalByPeriod(beginDate, endDate);
        }

        private void LoadExpendituresjournalByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            expendituresBS.DataSource = storeHouseService.GetExpenditureJournalByPeriod(beginDate, endDate);
            expendituresGrid.DataSource = expendituresBS;

            splashScreenManager.CloseWaitForm();
        }


        private void showExpenditureBtn_Click(object sender, EventArgs e)
        {
            LoadExpendituresjournalByPeriod((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void ExpendituresJournalFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}