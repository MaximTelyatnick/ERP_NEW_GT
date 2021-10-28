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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class WeldStampsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;

        private BindingSource weldStampsBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return weldStampsBS.Current as ObjectBase; }
            set
            {
                weldStampsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public WeldStampsEditFm(Utils.Operation operation, WeldStampsDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            weldStampsBS.DataSource = Item = model;

            stampNumberEdit.DataBindings.Add("EditValue", weldStampsBS, "StampNumber");
            stampDateEdit.DataBindings.Add("EditValue", weldStampsBS, "StampDate");

            if (this.operation == Utils.Operation.Add)
                ((WeldStampsDTO)this.Item).StampDate = DateTime.Now;

            stampValidationProvider.Validate();
        }

        #region Method's

        private void SaveStamp()
        {
            this.Item.EndEdit();

            weldStampsService = Program.kernel.Get<IWeldStampsService>();
            
            if (FindDublicate((WeldStampsDTO)this.Item))
            {
                MessageBox.Show("Клеймо з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (this.operation == Utils.Operation.Add)
                ((WeldStampsDTO)Item).Id = weldStampsService.CreateWeldStamps((WeldStampsDTO)Item);
            else
                weldStampsService.UpdateWeldStamps((WeldStampsDTO)Item);
        }

        private bool FindDublicate(WeldStampsDTO model)
        {
            return weldStampsService.GetWeldStamps().Any(s => s.StampNumber == model.StampNumber && s.Id != model.Id);
        }

        public int Return()
        {
            return ((WeldStampsDTO)Item).Id;
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveStamp();

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return stampValidationProvider.Validate();
        }

        private void stampDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            stampValidationProvider.Validate((Control)sender);
        }

        private void stampNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            stampValidationProvider.Validate((Control)sender);
        }

        private void stampValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void stampValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (stampValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion
    }
}