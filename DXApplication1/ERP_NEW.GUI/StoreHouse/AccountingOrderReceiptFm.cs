using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingOrderReceiptFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource orderReceiptBS = new BindingSource();
        DateTime firstDay, lastDay;

        public AccountingOrderReceiptFm(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4)
        {
           
            InitializeComponent();
            this.firstDay = beginDate;
            this.lastDay = endDate;

            this.Text = "Надходження за період з "+beginDate.ToShortDateString() + " по " + endDate.ToShortDateString();

            //LoadData(beginDate, endDate, flag1, flag2, flag3, flag4);
            LoadDataLink(beginDate, endDate, flag1, flag2, flag3, flag4);
          
        }

        private void LoadData(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            orderReceiptBS.DataSource = storeHouseService.GetOrderReceipFromQueryProc(beginDate, endDate, flag1, flag2, flag3, flag4);
            AccountingOrderReceiptGrid.DataSource = orderReceiptBS;
        }
        private void LoadDataLink(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            orderReceiptBS.DataSource = storeHouseService.GetOrderReceipFromQuery(beginDate, endDate, flag1, flag2, flag3, flag4);
            AccountingOrderReceiptGrid.DataSource = orderReceiptBS;
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
        
            string path = "За период"  +".xls";

            AccountingOrderReceiptGrid.ExportToXls(path);
            Process.Start(path);


        }
    }
}