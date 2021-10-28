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
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;
using System.IO;

namespace ERP_NEW.GUI.OTK
{
    public partial class CertificateEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IReceiptCertificateService receiptCertificateService;
        private OrdersInfoDTO ordersInfo2;
        private BindingSource ordersInfoBS = new BindingSource();
        private BindingSource certivicateBS = new BindingSource();
        private Utils.Operation operation;
        private ReceiptCertificatesDTO certificateDTO; 

        public CertificateEditFm(Utils.Operation operation, OrdersInfoDTO ordersInfo)
        {
            InitializeComponent();
            this.operation = operation;
            receiptCertificateService = Program.kernel.Get<IReceiptCertificateService>();
            ordersInfo2 = ordersInfo;
            ordersInfoBS.DataSource = ordersInfo2;
            invoiceNumTbox.DataBindings.Add("EditValue", ordersInfoBS, "InvoiceNum");
            invoiceDateTbox.DataBindings.Add("EditValue", ordersInfoBS, "InvoiceDate");
            receiptNumTbox.DataBindings.Add("EditValue", ordersInfoBS, "ReceiptNum");
            orderDateTbox.DataBindings.Add("EditValue", ordersInfoBS, "OrderDate");
            nomenclatureTbox.DataBindings.Add("EditValue", ordersInfoBS, "Nomenclature");
            nomenclatureNameTbox.DataBindings.Add("EditValue", ordersInfoBS, "NomenclatureName");
            quantityTbox.DataBindings.Add("EditValue", ordersInfoBS, "Quantity");
            measureTbox.DataBindings.Add("EditValue", ordersInfoBS, "Measure");
            certificateNumberTbox.EditValue = ordersInfo2.CertificateNumber;
            certificateDateTbox.EditValue = ordersInfo2.CertificateDate;
            manufacturerInfoMemoEdit.EditValue = ordersInfo2.ManufacturerInfo;
            descriptionMemoEdit.EditValue = ordersInfo2.Description;
                       
            if (this.operation == Utils.Operation.Add)
            {
                certificateDateTbox.EditValue = null;
                certificateDTO = new ReceiptCertificatesDTO() { ReceiptId = ordersInfo2.ReceiptId, CertificateScan = null, CertificateScanTwo = null };
            }
            else 
            {
                certificateDTO = receiptCertificateService.GetCertificate((long)ordersInfo2.ReceiptCertificateId);
                pictureEdit.EditValue = certificateDTO.CertificateScan;

                if (pictureEdit.Image == null && certificateDTO.FileName != null)
                {
                    int stratIndex = certificateDTO.FileName.IndexOf('.');
                    string typeFile = certificateDTO.FileName.Substring(stratIndex);

                    switch (typeFile)
                    {
                        case ".pdf":
                            pictureEdit.Image = imageCollection.Images[1];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                        default:
                            pictureEdit.Image = imageCollection.Images[0];
                            pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                    }
                }
                fileNameTbox.EditValue = certificateDTO.FileName;

                pictureTwoEdit.EditValue = certificateDTO.CertificateScanTwo;

                if (pictureTwoEdit.Image == null && certificateDTO.FileNameTwo != null)
                {
                    int stratIndex = certificateDTO.FileNameTwo.IndexOf('.');
                    string typeFile = certificateDTO.FileNameTwo.Substring(stratIndex);

                    switch (typeFile)
                    {
                        case ".pdf":
                            pictureTwoEdit.Image = imageCollection.Images[1];
                            pictureTwoEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                        default:
                            pictureTwoEdit.Image = imageCollection.Images[0];
                            pictureTwoEdit.Properties.SizeMode = PictureSizeMode.Clip;
                            break;
                    }
                }
                fileNameTwoTBox.EditValue = certificateDTO.FileNameTwo;

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if ((certificateNumberTbox.Text.Trim().Length == 0) || ( certificateDateTbox.Text.Trim().Length == 0)) 
            {
                MessageBox.Show("Не внесено № сертифікату або дата!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            certificateDTO.CertificateNumber = (string)certificateNumberTbox.EditValue;
            certificateDTO.CertificateDate = (DateTime)certificateDateTbox.EditValue;
            certificateDTO.ManufacturerInfo = (string)manufacturerInfoMemoEdit.EditValue;
            certificateDTO.Description = (string)descriptionMemoEdit.EditValue;

            if (this.operation == Utils.Operation.Add)
            {
                certificateDTO.ReceiptCertificateId = receiptCertificateService.CreateCertificate(certificateDTO);
            }
            else
            {
                receiptCertificateService.UpdateCertificate(certificateDTO);
            }

            this.Close();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName =  ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);
                FileInfo info = new FileInfo(@filePath);

                if (Utils.ToSize(info.Length, Utils.SizeUnits.GB) > Properties.Settings.Default.MaxFileSizeMb)
                {
                    MessageBox.Show("Перевищено максимальний розмір файлу (" + Properties.Settings.Default.MaxFileSizeMb.ToString() + " мегабайт) !!!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                certificateDTO.CertificateScan = scan;
                certificateDTO.FileName = fileName;
            }
            else
                return;

            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                pictureEdit.EditValue = bitmap;
                fileNameTbox.EditValue = fileName;
            }
            catch (Exception)
            {
                int stratIndex = filePath.IndexOf('.');
                string typeFile = filePath.Substring(stratIndex);
                
                switch (typeFile)
                {
                    case ".pdf":
                        fileNameTbox.EditValue = fileName;
                        pictureEdit.Image = imageCollection.Images[1];
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                    default:
                        fileNameTbox.EditValue = fileName;
                        pictureEdit.Image = imageCollection.Images[0];
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
             string fileName = (string) fileNameTbox.EditValue;
             byte[] scan = certificateDTO.CertificateScan;
             string puth = Utils.HomePath + @"\Temp";

             System.IO.File.WriteAllBytes(puth + fileName, scan);

             System.Diagnostics.Process.Start(puth + fileName);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            certificateDTO.CertificateScan = null;
            certificateDTO.FileName = null;
            pictureEdit.EditValue =null;
            fileNameTbox.EditValue = null;
        }

        private void openFileTwoBtn_Click(object sender, EventArgs e)
        {
            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);
                FileInfo info = new FileInfo(@filePath);

                if (Utils.ToSize(info.Length, Utils.SizeUnits.MB) > Properties.Settings.Default.MaxFileSizeMb)
                {
                    MessageBox.Show("Перевищено максимальний розмір файлу (" + Properties.Settings.Default.MaxFileSizeMb.ToString()+ " мегабайт) !!!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                certificateDTO.CertificateScanTwo = scan;
                certificateDTO.FileNameTwo = fileName;
            }
            else
                return;

            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                pictureTwoEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                pictureTwoEdit.EditValue = bitmap;
                fileNameTwoTBox.EditValue = fileName;
            }
            catch (Exception)
            {
                int stratIndex = filePath.IndexOf('.');
                string typeFile = filePath.Substring(stratIndex);

                switch (typeFile)
                {
                    case ".pdf":
                        fileNameTwoTBox.EditValue = fileName;
                        pictureTwoEdit.Image = imageCollection.Images[1];
                        pictureTwoEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                    default:
                        fileNameTwoTBox.EditValue = fileName;
                        pictureTwoEdit.Image = imageCollection.Images[0];
                        pictureTwoEdit.Properties.SizeMode = PictureSizeMode.Clip;
                        break;
                }
            }
        }

        private void clearTwoBtn_Click(object sender, EventArgs e)
        {
            certificateDTO.CertificateScanTwo = null;
            certificateDTO.FileNameTwo = null;
            pictureTwoEdit.EditValue =null;
            fileNameTwoTBox.EditValue = null;
        }

        private void showTwoBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)fileNameTwoTBox.EditValue;
            byte[] scan = certificateDTO.CertificateScanTwo;
            string puth = Utils.HomePath + @"\Temp";

            System.IO.File.WriteAllBytes(puth + fileName, scan);

            System.Diagnostics.Process.Start(puth + fileName);
        }
    }
}