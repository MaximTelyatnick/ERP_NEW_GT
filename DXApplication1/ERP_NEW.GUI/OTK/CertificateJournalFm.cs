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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using ERP_NEW.GUI.Properties;

namespace ERP_NEW.GUI.OTK
{
    public partial class CertificateJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private IUserService userService;
        private BindingSource certificatesBS = new BindingSource();
        private UserTasksDTO userTasksDTO;
        private DateTime beginDate, endDate;

        //private ReceiptCertificatesDTO certificateDTO;
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();
        //private DateTime beginDate, endDate;
        public CertificateJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            if (Properties.Settings.Default.CertificateJournalFmBeginDate.Year < 2000)
                this.beginDate = new DateTime(DateTime.Today.Year - 3, DateTime.Today.Month, 1); // год - месяц - день
            else
                this.beginDate = Properties.Settings.Default.CertificateJournalFmBeginDate;

            if (Properties.Settings.Default.CertificateJournalFmEndDate.Year < 2000)
                this.endDate = new DateTime(DateTime.Today.Year + 1, DateTime.Today.Month, DateTime.Today.Day); // год - месяц - день
            else
                this.endDate = Properties.Settings.Default.CertificateJournalFmEndDate;

            beginDateEdit.EditValue = beginDate;
            endDateEdit.EditValue = endDate;

            showCertificateExpirationCheck.EditValueChanged -= showCertificateExpirationCheck_EditValueChanged;

            showCertificateExpirationCheck.EditValue = Properties.Settings.Default.CertificateJournalFmExpirationCheck;

            showCertificateExpirationCheck.EditValueChanged += showCertificateExpirationCheck_EditValueChanged;

            
            //CertificateJournalFmExpirationCheck
            LoadDate(beginDate, endDate, (bool)showCertificateExpirationCheck.EditValue);

            certGridView.SetRowCellValue(GridControl.AutoFilterRowHandle, certGridView.Columns[6], Settings.Default.CertificateJournalFmFilterUserCol);
        }

        public ReceiptCertificatesDTO Return()
        {
            return ((ReceiptCertificatesDTO)certificatesBS.Current);
        }

        private void LoadDate(DateTime beginDate, DateTime endDate, bool showExpiration)
        {
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
            //var orders = receiptCertificateService.GetOrdersWithCertificate(beginDate, endDate);
            splashScreenManager.ShowWaitForm();
            List<ReceiptCertificatesDTO> certs = new List<ReceiptCertificatesDTO>();
            if(showExpiration)
                certs = receiptCertificateService.GetCertificates().Where(srch => srch.CertificateDate>=beginDate && srch.CertificateDate<= endDate).OrderByDescending(sort => sort.CertificateDate).ToList();
            else
                certs = receiptCertificateService.GetCertificates().Where(show => !show.CertificateExpiration && show.CertificateDate>=beginDate && show.CertificateDate<=endDate).OrderByDescending(sort => sort.CertificateDate).ToList();

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
            userService = Program.kernel.Get<IUserService>();
            int employeeId = userService.GetEmployeeIdByUserId(userTasksDTO.UserId);
            editCertificate(Utils.Operation.Add, new ReceiptCertificatesDTO() {UserId = employeeId });
        }
        private void editCertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userService = Program.kernel.Get<IUserService>();
            int employeeId = userService.GetEmployeeIdByUserId(userTasksDTO.UserId);
            ((ReceiptCertificatesDTO)certificatesBS.Current).UserId = employeeId;
            editCertificate(Utils.Operation.Update, (ReceiptCertificatesDTO)certificatesBS.Current);
        }

        private void editCertificate(Utils.Operation operation, ReceiptCertificatesDTO receiptCertificatesDTO)
        {
            CertificateEditFm certificateEditFm = new CertificateEditFm(operation, receiptCertificatesDTO);

            if (certificateEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReceiptCertificatesDTO return_Id = certificateEditFm.Return();
                certGridView.BeginDataUpdate();
                LoadDate(beginDate, endDate, (bool)showCertificateExpirationCheck.EditValue);
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

        private void DeleteReceiptCertificate()
        {
            if (certificatesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити сертифікат?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
                    int rowHandle = certGridView.FocusedRowHandle - 1;
                    certGridView.BeginDataUpdate();
                    receiptCertificateService.RemoveCertificateById(((ReceiptCertificatesDTO)certificatesBS.Current).ReceiptCertificateId);
                    LoadDate(beginDate, endDate, (bool)showCertificateExpirationCheck.EditValue);
                    certGridView.EndDataUpdate();
                    certGridView.FocusedRowHandle = (certGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void selectCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((((ReceiptCertificatesDTO)certificatesBS.Current).CertificateExpiration) && (((ReceiptCertificatesDTO)certificatesBS.Current).CertificateDateEnd < DateTime.Now))
            {
                if (MessageBox.Show("Термін дії сертифіката закінчився!\nПрикріпити сертифікат?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

            
        }

        private void deleteCertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (receiptCertificateService.CheckCertificates(((ReceiptCertificatesDTO)certificatesBS.Current).ReceiptCertificateId))
            {
                MessageBox.Show("Сертифікат прикріплено до надходження!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }

            try
            {
                DeleteReceiptCertificate();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void certGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            var value = certGridView.GetRowCellValue(GridControl.AutoFilterRowHandle, certGridView.Columns[6]);
            if (value == null)
                value = "";
            Settings.Default.CertificateJournalFmFilterUserCol = value.ToString();
            Settings.Default.Save();
        }

        private void certGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                ReceiptCertificatesDTO item = (ReceiptCertificatesDTO)certGridView.GetRow(e.RowHandle);
                if ((item.CertificateExpiration) && (item.CertificateDateEnd<DateTime.Now))
                    e.Appearance.BackColor = Color.MistyRose;
            }
        }

        private void showCertificateExpirationCheck_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CertificateJournalFmExpirationCheck = (bool)showCertificateExpirationCheck.EditValue;
            Properties.Settings.Default.Save();
            LoadDate((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue, (bool)showCertificateExpirationCheck.EditValue);
        }

        private void beginDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CertificateJournalFmBeginDate = (DateTime)beginDateEdit.EditValue;
            Properties.Settings.Default.Save();
        }

        private void endDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CertificateJournalFmEndDate = (DateTime)endDateEdit.EditValue;
            Properties.Settings.Default.Save();
        }

        private void showCertBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDate((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue, (bool)showCertificateExpirationCheck.EditValue);
        }
    }
}