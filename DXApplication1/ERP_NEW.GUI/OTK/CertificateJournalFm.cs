using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.OTK
{
    public partial class CertificateJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private BindingSource certificatesBS = new BindingSource();
        //private ReceiptCertificatesDTO certificateDTO;
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();
        private object informationRow;
        //private DateTime beginDate, endDate;
        public CertificateJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            LoadDate();

        }

        private void LoadDate()
        {
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
            //var orders = receiptCertificateService.GetOrdersWithCertificate(beginDate, endDate);
            splashScreenManager.ShowWaitForm();
            var certs = receiptCertificateService.GetCertificates().OrderByDescending(sort => sort.CertificateDate).ToList();
            certificatesBS.DataSource = certs;
            certGrid.DataSource = certificatesBS;
            certGrid.Refresh();
            splashScreenManager.CloseWaitForm();

        }

        private void certGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (((ReceiptCertificatesDTO)certificatesBS[e.ListSourceRowIndex]).ScanCheck == true)
                e.Value = imageCollection.Images[1];
            else
                e.Value = imageCollection.Images[0];
        }



        private void addCertToolStripMenuItem_Click(object sender, EventArgs e)
        {
                editCertificate(Utils.Operation.Add, new ReceiptCertificatesDTO());
        }
        private void editCertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCertificate(Utils.Operation.Update, (ReceiptCertificatesDTO)certificatesBS.Current);
        }

        private void editCertificate(Utils.Operation operation, ReceiptCertificatesDTO receiptCertificatesDTO)
        {
            CertificateEditFm certificateEditFm = new CertificateEditFm(operation, receiptCertificatesDTO);

            if (certificateEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReceiptCertificatesDTO return_Id = certificateEditFm.Return();
                certGridView.BeginDataUpdate();
                LoadDate();
                certGridView.EndDataUpdate();
                int rowHandle = certGridView.LocateByValue("ReceiptCertificateId", return_Id.ReceiptCertificateId);
                certGridView.FocusedRowHandle = rowHandle;
            }
        }

        private void certGridView_DoubleClick(object sender, EventArgs e)
        {
            if (((ReceiptCertificatesDTO)certificatesBS.Current).ScanCheck)
            {
                byte[] scan = receiptCertificateService.GetCertificate((long)((ReceiptCertificatesDTO)certificatesBS.Current).ReceiptCertificateId).CertificateScan;
                string path = Utils.HomePath + @"\Temp\";
                System.IO.File.WriteAllBytes(path + ((ReceiptCertificatesDTO)certificatesBS.Current).FileName, scan);
                System.Diagnostics.Process.Start(path + ((ReceiptCertificatesDTO)certificatesBS.Current).FileName);
            }
        }

        
    }
}