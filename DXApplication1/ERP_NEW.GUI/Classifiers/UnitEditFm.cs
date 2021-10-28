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
    public partial class UnitEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IUnitsService unitsService;

        private BindingSource unitsBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return unitsBS.Current as ObjectBase; }
            set
            {
                unitsBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public UnitEditFm(Utils.Operation operation, UnitsDTO model)
        {
            InitializeComponent();
            this.operation = operation;
            unitsBS.DataSource = Item = model;

            unitFullNameEdit.DataBindings.Add("EditValue", unitsBS, "UnitFullName");
            unitLocalNameEdit.DataBindings.Add("EditValue", unitsBS, "UnitLocalName");

            unitValidationProvider.Validate();
        }
        
        #region Method's

        private bool SaveUnit()
        {
            this.Item.EndEdit();

            unitsService = Program.kernel.Get<IUnitsService>();

            if (FindDublicate((UnitsDTO)this.Item))
            {
                MessageBox.Show("Одиниця вимірювання вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (this.operation == Utils.Operation.Add)
                ((UnitsDTO)Item).UnitId = unitsService.UnitCreate((UnitsDTO)Item);
            else
                unitsService.UnitCreate((UnitsDTO)Item);

            return true;
        }

        private bool FindDublicate(UnitsDTO model)
        {
            return unitsService.GetUnits().Any(s => s.UnitLocalName.Trim() == model.UnitLocalName.Trim());
        }

        public long Return()
        {
            return ((UnitsDTO)Item).UnitId;
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveUnit())
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
            return unitValidationProvider.Validate();
        }
        
        private void unitFullNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            unitValidationProvider.Validate((Control)sender);
        }
        private void unitLocalNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            unitValidationProvider.Validate((Control)sender);
        }

        private void unitValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void unitValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (unitValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        #endregion
    }
}