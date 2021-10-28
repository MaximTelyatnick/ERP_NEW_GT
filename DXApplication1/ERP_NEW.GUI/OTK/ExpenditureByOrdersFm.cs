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
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;

namespace ERP_NEW.GUI.OTK
{
    public partial class ExpenditureByOrdersFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private BindingSource ordersBS = new BindingSource();

        public ExpenditureByOrdersFm()
        {
            InitializeComponent();
            DateTime begin_Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // год - месяц - день
            DateTime end_Date = DateTime.Today;
            beginDateEdit.EditValue = begin_Date;
            endDateEdit.EditValue = end_Date;

            LoadData(begin_Date, end_Date);
        }

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
            var orders = receiptCertificateService.GetExpenditureByCustomerOrders(beginDate, endDate);
            ordersBS.DataSource = orders;
            expendituresGrid.DataSource = ordersBS;
            splashScreenManager.CloseWaitForm();
            expendituresGridView.CollapseAllGroups();
            expendituresGrid.Focus();
        }

        private void showOrdersForDate_Click(object sender, EventArgs e)
        {
            DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
            DateTime end_Date = (DateTime)endDateEdit.EditValue;
            LoadData(begin_Date, end_Date);
        }

    }
}