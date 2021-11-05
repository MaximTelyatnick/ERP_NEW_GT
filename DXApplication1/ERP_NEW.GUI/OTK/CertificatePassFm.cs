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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.Utils;
using System.IO;

namespace ERP_NEW.GUI.OTK
{
    public partial class CertificatePassFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private BindingSource ordersBS = new BindingSource();
        private ReceiptCertificatesDTO certificateDTO;
        private object informationRow;

        public CertificatePassFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            DateTime begin_Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // год - месяц - день
            DateTime end_Date = DateTime.Today;
            beginDateEdit.EditValue = begin_Date;
            endDateEdit.EditValue = end_Date;
            LoadDate(begin_Date, end_Date);
        }

        private void LoadDate(DateTime beginDate, DateTime endDate)
        {
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
            var orders = receiptCertificateService.GetOrdersWithCertificate(beginDate, endDate);
            ordersBS.DataSource = orders;
            certificatePassGrid.DataSource = ordersBS;
            certificatePassGrid.Refresh();       
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            LoadDate((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            splashScreenManager.CloseWaitForm();
        }

        private void bandedGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
           
                if (((OrdersInfoDTO)ordersBS[e.ListSourceRowIndex]).ScanPersence == 1)
                    e.Value = imageCollection.Images[1];            
                else
                    e.Value = imageCollection.Images[0];
            


        }

        private void bandedGridView_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void repositoryItemPictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            if (((OrdersInfoDTO)ordersBS.Current).ScanPersence == 1)
            {
               
                    string fileName = ((OrdersInfoDTO)ordersBS.Current).FileName;
                    long id = (long)((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId;
                    certificateDTO = receiptCertificateService.GetCertificate(id);
                    byte[] scan = certificateDTO.CertificateScan;
                    string puth = Utils.HomePath + @"\Temp\";
                    System.IO.File.WriteAllBytes(puth + fileName, scan);        
                    System.Diagnostics.Process.Start(puth + fileName);
              
            }
        }

        private void addStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId == null)
            {
                editCertificate(Utils.Operation.Add);
            }
            else
                MessageBox.Show("Сертифікат вже закріплений за вибраним надходженням!");
            
        }



        private void editCertificate(Utils.Operation operation)
        {
            CertificateEditFm certificateEditFm = new CertificateEditFm(operation, (OrdersInfoDTO)ordersBS.Current);

            if (certificateEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
                DateTime end_Date = (DateTime)endDateEdit.EditValue;
                LoadDate(begin_Date, end_Date);
                certificatePassGrid.Focus();
            }
        }

        private void editStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId != null)
            {
                editCertificate(Utils.Operation.Update);
            }
            else
                MessageBox.Show("Сертифікат не закріплений за вибраним надходженням!");
        }
    }
}