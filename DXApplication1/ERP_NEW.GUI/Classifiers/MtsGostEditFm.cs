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
    public partial class MtsGostEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclaturesService;

        private BindingSource gostsBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return gostsBS.Current as ObjectBase; }
            set
            {
                gostsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public MtsGostEditFm(Utils.Operation operation, MtsGostsDTO model)
        {
            InitializeComponent();
            this.operation = operation;
            gostsBS.DataSource = Item = model;

            nameEdit.DataBindings.Add("EditValue", gostsBS, "Name");

            gostValidationProvider.Validate();
        }
        #region Method's

        private bool SaveGost()
        {
            this.Item.EndEdit();

            mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();

            if (FindDublicate((MtsGostsDTO)this.Item))
            {
                MessageBox.Show("ГОСТ, ТУ вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (this.operation == Utils.Operation.Add)
                ((MtsGostsDTO)Item).Id = mtsNomenclaturesService.GostCreate((MtsGostsDTO)Item);
            else
                mtsNomenclaturesService.GostUpdate((MtsGostsDTO)Item);

            return true;
        }

        private bool FindDublicate(MtsGostsDTO model)
        {
            return mtsNomenclaturesService.GetGosts().Any(s => s.Name.Trim() == model.Name.Trim());
        }

        public long Return()
        {
            return ((MtsGostsDTO)Item).Id;
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveGost())
                {
                DialogResult = DialogResult.OK;
                this.Close();
                }
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
            return gostValidationProvider.Validate();
        }
       

        private void nameEdit_EditValueChanged(object sender, EventArgs e)
        {
           gostValidationProvider.Validate((Control)sender);
        }

        private void gostValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void gostValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (gostValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        #endregion
    }
}