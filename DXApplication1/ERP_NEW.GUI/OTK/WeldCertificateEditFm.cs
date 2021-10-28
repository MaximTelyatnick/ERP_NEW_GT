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

namespace ERP_NEW.GUI.OTK
{
    public partial class WeldCertificateEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;
        private BindingSource weldCertificateBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return weldCertificateBS.Current as ObjectBase; }
            set
            {
                weldCertificateBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public WeldCertificateEditFm(Utils.Operation operation, WeldCertificatesDTO model)
        {
            InitializeComponent();

            _operation = operation;

            weldCertificateBS.DataSource = Item = model;

            fileNameTbox.DataBindings.Add("EditValue", weldCertificateBS, "FileName");
            pictureEdit.EditValue = ((WeldCertificatesDTO)Item).CertificateScan;
            
            if (_operation == Utils.Operation.Update)
            {
                if (pictureEdit.Image == null && ((WeldCertificatesDTO)Item).FileName != null)
                {
                    int stratIndex = ((WeldCertificatesDTO)Item).FileName.IndexOf('.');
                    string typeFile = ((WeldCertificatesDTO)Item).FileName.Substring(stratIndex);

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
            }

            weldValidationProvider.Validate();
        }

        #region Method's

        private void SaveDocument()
        {
            this.Item.EndEdit();

            weldStampsService = Program.kernel.Get<IWeldStampsService>();

            if (_operation == Utils.Operation.Add)
                ((WeldCertificatesDTO)Item).Id = weldStampsService.CreateWeldCertificate((WeldCertificatesDTO)Item);
            else
                weldStampsService.UpdateWeldCertificate((WeldCertificatesDTO)Item);

        }

        #endregion

        #region Event's

        private void openFileBtn_Click(object sender, EventArgs e)
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

                ((WeldCertificatesDTO)Item).CertificateScan = scan;
                ((WeldCertificatesDTO)Item).FileName = fileName;
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
            string fileName = (string)fileNameTbox.EditValue;
            byte[] scan = ((WeldCertificatesDTO)Item).CertificateScan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ControlValidation()) return;

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveDocument();

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            this.Close();
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return weldValidationProvider.Validate();
        }

        private void fileNameTbox_TextChanged(object sender, EventArgs e)
        {
            weldValidationProvider.Validate((Control)sender);
        }

        private void weldValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void weldValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (weldValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion
    }
}