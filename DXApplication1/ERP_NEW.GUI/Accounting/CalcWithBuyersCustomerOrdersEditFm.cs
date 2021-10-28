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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using ERP_NEW.BLL.Services;
using System.IO;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.Accounting
{
    public partial class CalcWithBuyersCustomerOrdersEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;

        public CalcWithBuyersCustomerOrdersEditFm()
        {
            InitializeComponent();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
                        
            customerOrdersEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull();
            customerOrdersEdit.Properties.ValueMember = "Id";
            customerOrdersEdit.Properties.DisplayMember = "OrderNumber";
            customerOrdersEdit.Properties.NullText = "Немає данних";

            ControlValidation();
        }

        public CustomerOrdersDTO Return()
        {
            return (CustomerOrdersDTO)customerOrdersEdit.GetSelectedDataRow();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {            
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Validation
        
        private bool ControlValidation()
        {
            return customerOrderValidationProvider.Validate();
        }

        private void customerOrderValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void customerOrderValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (customerOrderValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void customerOrdersEdit_EditValueChanged(object sender, EventArgs e)
        {
            customerOrderValidationProvider.Validate((Control)sender);
        }

        #endregion
    }
}