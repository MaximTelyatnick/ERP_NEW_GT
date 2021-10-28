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
using ERP_NEW.GUI.Marketing;

namespace ERP_NEW.GUI.OTK
{
    public partial class EmployeeCertificateEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;
        private IDocumentTypesService documentTypesService;
        private BindingSource empCertificateBS = new BindingSource();
        private BindingSource documentTypesBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return empCertificateBS.Current as ObjectBase; }
            set
            {
                empCertificateBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public EmployeeCertificateEditFm(Utils.Operation operation, EmployeeCertificatesDTO model)
        {
            InitializeComponent();

            _operation = operation;

            empCertificateBS.DataSource = Item = model;

            fileNameTbox.DataBindings.Add("EditValue", empCertificateBS, "FileName");
            pictureEdit.EditValue = ((EmployeeCertificatesDTO)Item).CertificateScan;

            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
            documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 2);
            documentTypeEdit.Properties.DataSource = documentTypesBS;
            documentTypeEdit.Properties.ValueMember = "DocumentTypeId";
            documentTypeEdit.Properties.DisplayMember = "DocumentTypeName";
            documentTypeEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Update)
            {
                documentTypeEdit.EditValue = ((EmployeeCertificatesDTO)Item).DocumentTypeId;

                if (pictureEdit.Image == null && ((EmployeeCertificatesDTO)Item).FileName != null)
                {
                    int stratIndex = ((EmployeeCertificatesDTO)Item).FileName.IndexOf('.');
                    string typeFile = ((EmployeeCertificatesDTO)Item).FileName.Substring(stratIndex);

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

            empValidationProvider.Validate();
        }

        #region Method's

        private void SaveDocument()
        {
            this.Item.EndEdit();

            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            ((EmployeeCertificatesDTO)Item).DocumentTypeId = ((DocumentTypesDTO)documentTypeEdit.GetSelectedDataRow()).DocumentTypeId;

            if (_operation == Utils.Operation.Add)
            {
                ((EmployeeCertificatesDTO)Item).Id = weldStampsService.CreateEmployeeCertificate((EmployeeCertificatesDTO)Item);
            }
            else
                weldStampsService.UpdateEmployeeCertificate((EmployeeCertificatesDTO)Item);
        }

        #endregion

        #region Event's
        
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

        private void empValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void empValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (empValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
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
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);

                ((EmployeeCertificatesDTO)Item).CertificateScan = scan;
                ((EmployeeCertificatesDTO)Item).FileName = fileName;
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

        private void documentTypeEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Add
                    using (ShipmentDocTypeEditFm shipmentDocTypeEditFm = new ShipmentDocTypeEditFm(Utils.Operation.Add, new DocumentTypesDTO() { DocumentKind = 2 }))
                    {
                        if (shipmentDocTypeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            int returnId = shipmentDocTypeEditFm.Return();

                            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                            documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 2);

                            documentTypeEdit.EditValue = returnId;
                        }
                    }
                    break;
                case 2: //Edit
                    if (documentTypeEdit.EditValue != null)
                    {
                        documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                        var model = documentTypesService.GetDocumentTypeById((int)documentTypeEdit.EditValue);

                        using (ShipmentDocTypeEditFm shipmentDocTypeEditFm = new ShipmentDocTypeEditFm(Utils.Operation.Update, model))
                        {
                            if (shipmentDocTypeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int returnId = shipmentDocTypeEditFm.Return();

                                documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                                documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 2);

                                documentTypeEdit.EditValue = returnId;
                            }
                        }
                    }
                    break;
                case 3: //Delete
                    if (documentTypeEdit.EditValue != null)
                    {
                        documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                        documentTypesService.DocumentTypeDelete((int)documentTypeEdit.EditValue);

                        documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 2);

                        documentTypeEdit.EditValue = null;
                    }
                    break;
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string fileName = (string)fileNameTbox.EditValue;
            byte[] scan = ((EmployeeCertificatesDTO)Item).CertificateScan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        #endregion

        #region Validation's


        private void documentTypesEdit_EditValueChanged(object sender, EventArgs e)
        {
            empValidationProvider.Validate((Control)sender);
        }

        private bool ControlValidation()
        {
            return empValidationProvider.Validate();
        }

        private void fileNameTbox_TextChanged(object sender, EventArgs e)
        {
            empValidationProvider.Validate((Control)sender);
        }


        #endregion

    }
}