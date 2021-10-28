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
    public partial class DefectActRepliesEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDefectActsService defectActsService;
        private IDocumentTypesService documentTypesService;
        
        private BindingSource defectActRepliesBS = new BindingSource();
        
        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return defectActRepliesBS.Current as ObjectBase; }
            set
            {
                defectActRepliesBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public DefectActRepliesEditFm(Utils.Operation operation, DefectActRepliesDTO model)
        {
            InitializeComponent();
            
            _operation = operation;
                                    
            defectActRepliesBS.DataSource = Item = model;

            descriptionMemoEdit.DataBindings.Add("EditValue", defectActRepliesBS, "Description");
            detailsMemoEdit.DataBindings.Add("EditValue", defectActRepliesBS, "Details");
            documentNumberTbox.DataBindings.Add("EditValue", defectActRepliesBS, "DocumentNumber");
            documentDateEdit.DataBindings.Add("EditValue", defectActRepliesBS, "DocumentDate", true, DataSourceUpdateMode.OnPropertyChanged);

            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
            documentTypeEdit.DataBindings.Add("EditValue", defectActRepliesBS, "DocumentTypeId", true, DataSourceUpdateMode.OnPropertyChanged);
            documentTypeEdit.Properties.DataSource = documentTypesService.GetDocumentTypes().Where(d => d.DocumentKind == 3);
            documentTypeEdit.Properties.ValueMember = "DocumentTypeId";
            documentTypeEdit.Properties.DisplayMember = "DocumentTypeName";
            documentTypeEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
            {
                ((DefectActRepliesDTO)Item).DocumentDate = DateTime.Today;
            }
            else
            {
                pictureEdit.EditValue = ((DefectActRepliesDTO)Item).DocumentScan;
                
                if (pictureEdit.Image == null && ((DefectActRepliesDTO)Item).FileName != null)
                {
                    int stratIndex = ((DefectActRepliesDTO)Item).FileName.IndexOf('.');
                    string typeFile = ((DefectActRepliesDTO)Item).FileName.Substring(stratIndex);

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

                fileNameTbox.EditValue = ((DefectActRepliesDTO)Item).FileName;
            }

            ControlValidation();
        }

        #region Method's

        public int Return()
        {
            return ((DefectActRepliesDTO)Item).Id;
        }

        private bool SaveDocument()
        {
            Item.EndEdit();
            
            try
            {
                defectActsService = Program.kernel.Get<IDefectActsService>();

                if (_operation == Utils.Operation.Add)
                    ((DefectActRepliesDTO)Item).Id = defectActsService.CreateDefectActReplie((DefectActRepliesDTO)Item);
                else
                    defectActsService.UpdateDefectActReplie((DefectActRepliesDTO)Item);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;               
            }
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

                ((DefectActRepliesDTO)Item).DocumentScan = scan;
                ((DefectActRepliesDTO)Item).FileName = fileName;
            }
            else
            {
                return;
            }

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
            byte[] scan = ((DefectActRepliesDTO)Item).DocumentScan;
            if (fileName != null)
            {
                string puth = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ((DefectActRepliesDTO)Item).DocumentScan = null;
            ((DefectActRepliesDTO)Item).FileName = null;
            pictureEdit.EditValue = null;
            fileNameTbox.EditValue = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ControlValidation()) return;

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveDocument())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void documentTypeEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Clean
                    documentTypeEdit.EditValue = null;
                    ((DefectActRepliesDTO)Item).DocumentTypeId = null;

                    break;
                case 2: //Add
                    using (ShipmentDocTypeEditFm shipmentDocTypeEditFm = new ShipmentDocTypeEditFm(Utils.Operation.Add, new DocumentTypesDTO() { DocumentKind = 3 }))
                    {
                        if (shipmentDocTypeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            int returnId = shipmentDocTypeEditFm.Return();

                            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                            documentTypeEdit.Properties.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 3);

                            documentTypeEdit.EditValue = returnId;
                        }
                    }

                    break;
                case 3: //Edit
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
                                documentTypeEdit.Properties.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 3);

                                documentTypeEdit.EditValue = returnId;
                            }
                        }
                    }

                    break;
                case 4: //Delete
                    if (documentTypeEdit.EditValue != null)
                    {
                        documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                        documentTypesService.DocumentTypeDelete((int)documentTypeEdit.EditValue);

                        documentTypeEdit.Properties.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 3);

                        documentTypeEdit.EditValue = null;
                        ((DefectActRepliesDTO)Item).DocumentTypeId = null;
                    }

                    break;
            }
        }

        #endregion

        #region Validate event's

        private bool ControlValidation()
        {
            return defectActValidationProvider.Validate();
        }

        private void documentNumberTBox_TextChanged(object sender, EventArgs e)
        {
            defectActValidationProvider.Validate((Control)sender);
        }

        private void documentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            defectActValidationProvider.Validate((Control)sender);
        }

        private void defectActValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (defectActValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void defectActValidationProviderValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        #endregion

    }
}