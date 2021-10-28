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
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class InvoiceRequirementFixedAssetsJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource invoiceFixedAssetsInfoBS = new BindingSource();
        private DateTime startDate, endDate;


        public InvoiceRequirementFixedAssetsJournalFm(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            this.startDate = startDate;
            this.endDate = endDate;

            LoadDataInvoiceFixedAssetsInfo(startDate, endDate);
        }

        private void LoadDataInvoiceFixedAssetsInfo(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            invoiceFixedAssetsInfoBS.DataSource = storeHouseService.GetInvoicesFixedAssetsInfo(beginDate, endDate);
            invoiceFixedAssetsGrid.DataSource = invoiceFixedAssetsInfoBS;

            splashScreenManager.CloseWaitForm();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (invoiceFixedAssetsInfoBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.InvoicesForFixedAssets((List<InvoicesFixedAssetsInfoDTO>)invoiceFixedAssetsInfoBS.DataSource,
                                                 (startDate.Date.ToShortDateString()), (endDate.Date.ToShortDateString()));
            }
        }
    }
}