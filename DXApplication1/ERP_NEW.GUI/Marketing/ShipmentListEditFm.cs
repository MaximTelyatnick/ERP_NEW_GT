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

namespace ERP_NEW.GUI.Marketing
{
    public partial class ShipmentListEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IShipmentListsService shipmentListsService;
        private ICustomerOrdersService customerOrdersService;
        private IDocumentTypesService documentTypesService;
        private BindingSource shipmentListsBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource documentTypesBS = new BindingSource();
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return shipmentListsBS.Current as ObjectBase; }
            set
            {
                shipmentListsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public ShipmentListEditFm(Utils.Operation operation, ShipmentListsDTO shipmentList)
        {
            InitializeComponent();
            this.operation = operation;
            shipmentListsService = Program.kernel.Get<IShipmentListsService>();
            shipmentListsBS.DataSource = Item = shipmentList;

            shipmentNumberTbox.DataBindings.Add("EditValue", shipmentListsBS, "ShipmentNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            shipmentDateEdit.DataBindings.Add("EditValue", shipmentListsBS, "ShipmentDate", true);
            descriptionMemoEdit.DataBindings.Add("EditValue", shipmentListsBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrdersBS.DataSource = customerOrdersService.GetCustomerOrders();
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "Немає данних";

            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
            documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 1);
            documentTypeEdit.Properties.DataSource = documentTypesBS;
            documentTypeEdit.Properties.ValueMember = "DocumentTypeId";
            documentTypeEdit.Properties.DisplayMember = "DocumentTypeName";
            documentTypeEdit.Properties.NullText = "Немає данних";


            if (this.operation == Utils.Operation.Add)
            {
                ((ShipmentListsDTO)Item).ShipmentDate = DateTime.Today;
                orderNumberEdit.EditValue = null;
                orderDateEdit.EditValue = null;
            }
            else
            {
                orderNumberEdit.EditValue = ((ShipmentListsDTO)Item).CustomerOrderId;
                orderDateEdit.EditValue = ((ShipmentListsDTO)Item).OrderDate;
                pictureEdit.EditValue = ((ShipmentListsDTO)Item).ShipmentScan;
                documentTypeEdit.EditValue = ((ShipmentListsDTO)Item).DocumentTypeId;
                if (pictureEdit.Image == null && ((ShipmentListsDTO)Item).FileName != null)
                {
                    int stratIndex = ((ShipmentListsDTO)Item).FileName.IndexOf('.');
                    string typeFile = ((ShipmentListsDTO)Item).FileName.Substring(stratIndex);

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
                fileNameTbox.EditValue = ((ShipmentListsDTO)Item).FileName;
            }
            shipmentValidationProvider.Validate();
        }

        #region Method's

        public int Return()
        {
            return ((ShipmentListsDTO)Item).ShipmentListId;
        }

        private void SaveDocument()
        {
            this.Item.EndEdit();

            ((ShipmentListsDTO)Item).CustomerOrderId = ((CustomerOrdersDTO)orderNumberEdit.GetSelectedDataRow()).Id;
            ((ShipmentListsDTO)Item).DocumentTypeId = ((DocumentTypesDTO)documentTypeEdit.GetSelectedDataRow()).DocumentTypeId;

            if (this.operation == Utils.Operation.Add)
                ((ShipmentListsDTO)Item).ShipmentListId = shipmentListsService.CreateShipmentList((ShipmentListsDTO)Item);
            else
                shipmentListsService.UpdateShipmentList((ShipmentListsDTO)Item);

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

                ((ShipmentListsDTO)Item).ShipmentScan = scan;
                ((ShipmentListsDTO)Item).FileName = fileName;
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
            byte[] scan = ((ShipmentListsDTO)Item).ShipmentScan;
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
            ((ShipmentListsDTO)Item).ShipmentScan = null;
            ((ShipmentListsDTO)Item).FileName = null;
            pictureEdit.EditValue = null;
            fileNameTbox.EditValue = null;
        }

        private void documentTypeEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Add
                    using (ShipmentDocTypeEditFm shipmentDocTypeEditFm = new ShipmentDocTypeEditFm(Utils.Operation.Add, new DocumentTypesDTO() { DocumentKind = 1}))
                    {
                        if (shipmentDocTypeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            int returnId = shipmentDocTypeEditFm.Return();
                            
                            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
                            documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 1);

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
                                documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 1);

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

                        documentTypesBS.DataSource = documentTypesService.GetDocumentTypes().Where(w => w.DocumentKind == 1);

                        documentTypeEdit.EditValue = null;
                    }
                    break;
            }
        }

        #endregion

        #region Validate's

        private bool ControlValidation()
        {
            return shipmentValidationProvider.Validate();
        }
        
        private void shipmentNumberTBox_TextChanged(object sender, EventArgs e)
        {
            shipmentValidationProvider.Validate((Control)sender);
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (orderNumberEdit.EditValue != null)
            {
                object key = orderNumberEdit.EditValue;
                var selectedIndex = orderNumberEdit.Properties.GetIndexByKeyValue(key);
                orderDateEdit.EditValue = ((CustomerOrdersDTO)orderNumberEdit.GetSelectedDataRow()).OrderDate;
            }

            shipmentValidationProvider.Validate((Control)sender);
        }

        private void documentTypesEdit_EditValueChanged(object sender, EventArgs e)
        {
            shipmentValidationProvider.Validate((Control)sender);
        }

        private void shipmentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            shipmentValidationProvider.Validate((Control)sender);
        }

        private void shipmentValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (shipmentValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void shipmentValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }
        
        #endregion
    }
}