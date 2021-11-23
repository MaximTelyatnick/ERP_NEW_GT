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
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.BLL.Services;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_NEW.GUI.OTK
{
    public partial class CertificatePassFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private IBusinessTripsService businessTripsService;
        private BindingSource ordersBS = new BindingSource();
        private ReceiptCertificatesDTO certificateDTO;
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();
        private object informationRow;
        private DateTime beginDate, endDate;


        public CertificatePassFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.beginDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // год - месяц - день
            this.endDate = DateTime.Today;
            beginDateEdit.EditValue = beginDate;
            endDateEdit.EditValue = endDate;
            LoadDate(beginDate, endDate);
            LoadColorsPallete();
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
            //if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId == null)
            //{
            //    editCertificate(Utils.Operation.Add);
            //}
            //else
            //    MessageBox.Show("Сертифікат вже закріплений за вибраним надходженням!");

        }

        private void LoadColorsPallete()
        {
            splashScreenManager.ShowWaitForm();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            colorsPallete = businessTripsService.GetColors().ToList();
            for (int i = contextMenuStrip.Items.Count; i > 3; i--)
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
            //if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId != null)
            //{
            //    editCertificate(Utils.Operation.Update);
            //}
            //else
            //    MessageBox.Show("Сертифікат не закріплений за вибраним надходженням!");
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Белый")
            {
                long id = (long)((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId;
                certificateDTO = receiptCertificateService.GetCertificate(id);
                certificatePassGrid.BeginUpdate();

                certificateDTO.ColorId = (int)e.ClickedItem.Tag;
                receiptCertificateService.UpdateCertificate(certificateDTO);

                ((OrdersInfoDTO)ordersBS.Current).ColorName = e.ClickedItem.ToolTipText;
                //(long)((OrdersInfoDTO)ordersBS.Current).ColorName = e
                //LoadDate((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);



                certificatePassGrid.EndUpdate();

            }
            else
            {
                certificatePassGrid.BeginUpdate();
                long id = (long)((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId;
                certificateDTO = receiptCertificateService.GetCertificate(id);
                certificateDTO.ColorId = null;
                receiptCertificateService.UpdateCertificate(certificateDTO);

                ((OrdersInfoDTO)ordersBS.Current).ColorName = e.ClickedItem.ToolTipText;
                certificatePassGrid.EndUpdate();
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId == null)
            {
                editCertificate(Utils.Operation.Add);
            }
           // else

            //    MessageBox.Show("Сертифікат вже закріплений за вибраним надходженням!");
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId != null)
            {
                editCertificate(Utils.Operation.Update);
            }
            else
            {
                MessageBox.Show("Сертифікат не закріплений за вибраним надходженням!");
            }
        }

        private void bandedGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (((OrdersInfoDTO)ordersBS.Current).ReceiptCertificateId == null)
            {
                editBtn.Enabled = false;
                contextMenuStrip.Enabled = false;
            }
            else
            {
                editBtn.Enabled = true;
                contextMenuStrip.Enabled = true;
            }
        }

        private void bandedGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (gv.GetRowCellValue(e.RowHandle, "ColorName") != null)
            {
                string currentRowColor = gv.GetRowCellValue(e.RowHandle, "ColorName").ToString();
                e.Appearance.BackColor = Color.FromName(currentRowColor);
            }
            

        }
    }
}