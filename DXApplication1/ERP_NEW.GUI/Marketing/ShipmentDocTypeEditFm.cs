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
    public partial class ShipmentDocTypeEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDocumentTypesService documentTypesService;

        private BindingSource documentTypesBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return documentTypesBS.Current as ObjectBase; }
            set
            {
                documentTypesBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public ShipmentDocTypeEditFm(Utils.Operation operation, DocumentTypesDTO model)
        {
            InitializeComponent();

            _operation = operation;

            documentTypesBS.DataSource = Item = model;

            documentTypeEdit.DataBindings.Add("EditValue", documentTypesBS, "DocumentTypeName");

            docValidationProvider.Validate();
        }

        #region Method's

        public int Return()
        {
            return ((DocumentTypesDTO)Item).DocumentTypeId;
        }

        private void SaveDocument()
        {
            this.Item.EndEdit();

            documentTypesService = Program.kernel.Get<IDocumentTypesService>();
           
            if (_operation == Utils.Operation.Add)
                ((DocumentTypesDTO)Item).DocumentTypeId = documentTypesService.DocumentTypeCreate((DocumentTypesDTO)Item);
            else
                documentTypesService.DocumentTypeUpdate((DocumentTypesDTO)Item);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            this.Close();
        }

        #endregion

        #region Validate's

        private bool ControlValidation()
        {
            return docValidationProvider.Validate();
        }

        private void documentTypeEdit_TextChanged(object sender, EventArgs e)
        {
            docValidationProvider.Validate((Control)sender);
        }

        private void docValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void docValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (docValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion
    }
}