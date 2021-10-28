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
    public partial class WeldStampJournalEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IWeldStampsService weldStampsService;
        
        private BindingSource journalBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return journalBS.Current as ObjectBase; }
            set
            {
                journalBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public WeldStampJournalEditFm(Utils.Operation operation, WeldStampJournalDTO model)
        {
            InitializeComponent();
            
            weldStampsService = Program.kernel.Get<IWeldStampsService>();

            _operation = operation;
            journalBS.DataSource = Item = model;

            if (_operation == Utils.Operation.Add)
            {
                ((WeldStampJournalDTO)this.Item).BeginDate = DateTime.Now;
                ((WeldStampJournalDTO)this.Item).EndDate = null;
            }
            var empSource = weldStampsService.GetEmployeesByWeldAttestations().OrderBy(o => o.Fio).ToList();
            responsiblePersonEdit.DataBindings.Add("EditValue", journalBS, "EmployeeId");
            responsiblePersonEdit.Properties.DataSource = empSource;
            responsiblePersonEdit.Properties.ValueMember = "EmployeeID";
            responsiblePersonEdit.Properties.DisplayMember = "Fio";
            responsiblePersonEdit.Properties.NullText = "Немає данних";

            var stampSource = weldStampsService.GetWeldStamps();
            weldStampEdit.DataBindings.Add("EditValue", journalBS, "WeldStampId");
            weldStampEdit.Properties.DataSource = stampSource;
            weldStampEdit.Properties.ValueMember = "Id";
            weldStampEdit.Properties.DisplayMember = "StampNumber";
            weldStampEdit.Properties.NullText = "Немає данних";

            beginDateEdit.DataBindings.Add("EditValue", journalBS, "BeginDate", true);
            endDateEdit.DataBindings.Add("EditValue", journalBS, "EndDate", true);
            
            journalValidationProvider.Validate();
        }

        private bool SaveStampJornal()
        {
            this.Item.EndEdit();

            try
            {
                weldStampsService = Program.kernel.Get<IWeldStampsService>();

                if (_operation == Utils.Operation.Add && FindStampExist(((WeldStampJournalDTO)Item).EmployeeId))
                {
                    MessageBox.Show("У даного процівника вже є клеймо!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (_operation == Utils.Operation.Add)
                    ((WeldStampJournalDTO)Item).Id = weldStampsService.CreateWeldStampJournal((WeldStampJournalDTO)Item);
                else
                    weldStampsService.UpdateWeldStampJournal((WeldStampJournalDTO)Item);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool FindStampExist(int employeeId)
        {
            return weldStampsService.GetWeldStampJournals().Any(s => s.EmployeeId == employeeId && s.EndDate == null);
        }

        public int Return()
        {
            return ((WeldStampJournalDTO)Item).Id;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveStampJornal())
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

        #region Validation's

        private bool ControlValidation()
        {
            return journalValidationProvider.Validate();
        }

        private void responsiblePersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            journalValidationProvider.Validate((Control)sender);
        }

        private void weldStampEdit_EditValueChanged(object sender, EventArgs e)
        {
            journalValidationProvider.Validate((Control)sender);
        }

        private void beginDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            journalValidationProvider.Validate((Control)sender);
        }

        private void journalValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void journalValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (journalValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

    }
}