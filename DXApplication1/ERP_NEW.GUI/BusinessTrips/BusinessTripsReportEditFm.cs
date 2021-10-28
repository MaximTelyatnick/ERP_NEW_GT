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

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsReportEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;

        private BindingSource reportBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return reportBS.Current as ObjectBase; }
            set
            {
                reportBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public BusinessTripsReportEditFm(Utils.Operation operation, BusinessTripsReportDTO model)
        {
            InitializeComponent();

            _operation = operation;
            reportBS.DataSource = Item = model;

            reportNameEdit.DataBindings.Add("EditValue", reportBS, "Name");

            ControlValidation();
        }

        #region Method's

        private bool SaveReport()
        {
            this.Item.EndEdit();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            if (FindDublicate((BusinessTripsReportDTO)this.Item))
            {
                MessageBox.Show("Такий документ вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (_operation == Utils.Operation.Add)
                ((BusinessTripsReportDTO)Item).ID = businessTripsService.BusinessTripReportCreate((BusinessTripsReportDTO)Item);
            else
                businessTripsService.BusinessTripReportUpdate((BusinessTripsReportDTO)Item);

            return true;
        }

        private bool FindDublicate(BusinessTripsReportDTO model)
        {
            return businessTripsService.GetBusinessTripsReports().Any(s => s.Name.Trim() == model.Name.Trim());
        }

        public int Return()
        {
            return ((BusinessTripsReportDTO)Item).ID;
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveReport())
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

        #region Validation

        private bool ControlValidation()
        {
            return reportValidationProvider.Validate();
        }

        private void reportNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            reportValidationProvider.Validate((Control)sender);
        }

        private void reportValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void reportValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (reportValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        
        #endregion
    }
}