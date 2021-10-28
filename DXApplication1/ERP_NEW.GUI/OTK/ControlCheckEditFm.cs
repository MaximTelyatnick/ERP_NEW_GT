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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;

using Ninject;

namespace ERP_NEW.GUI.Production
{
    public partial class ControlCheckEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IProjectDetailsService projectDetailsService;
        private IEmployeesService employeesService;
        private ICustomerOrdersService customerOrderService;

        private BindingSource controlBS = new BindingSource();
        private BindingSource customerOrdersBS = new BindingSource();
        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return controlBS.Current as ObjectBase; }
            set
            {
                controlBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public ControlCheckEditFm(Utils.Operation operation, ControlChecksDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            employeesService = Program.kernel.Get<IEmployeesService>();
            customerOrderService = Program.kernel.Get<ICustomerOrdersService>();

            controlBS.DataSource = Item = model;
            _operation = operation;

            markDateEdit.DataBindings.Add("EditValue", controlBS, "ControlDate", true);
            descriptionMemoEdit.DataBindings.Add("EditValue", controlBS, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            markDocumentTBox.DataBindings.Add("EditValue", controlBS, "MarkDocumentNumber", true, DataSourceUpdateMode.OnPropertyChanged);
            

            orderNumberEdit.DataBindings.Add("EditValue", controlBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            customerOrdersBS.DataSource = customerOrderService.GetCustomerOrdersByPeriod(DateTime.MinValue, DateTime.MaxValue);
            orderNumberEdit.Properties.DataSource = customerOrdersBS;
            orderNumberEdit.Properties.ValueMember = "Id";
            orderNumberEdit.Properties.DisplayMember = "OrderNumber";
            orderNumberEdit.Properties.NullText = "Немає данних";

            otkPersonEdit.DataBindings.Add("EditValue", controlBS, "ControlPersonId", true, DataSourceUpdateMode.OnPropertyChanged);
            var empSource = employeesService.GetEmployeesWorking();
            otkPersonEdit.Properties.DataSource = empSource;
            otkPersonEdit.Properties.ValueMember = "EmployeeID";
            otkPersonEdit.Properties.DisplayMember = "Fio";
            otkPersonEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
            {
                ((ControlChecksDTO)Item).ControlDate = DateTime.Today;
                otkPersonEdit.EditValue = null;
            }
            else
            {
                otkPersonEdit.EditValue = ((ControlChecksDTO)Item).ControlPersonId;
            }

            controlValidationProvider.Validate();

            splashScreenManager.CloseWaitForm();

        }




        #region Method's

        private bool SaveDocument()
        {
            //if (FindDublicate((ControlChecksDTO)this.Item))
            //{
            //    MessageBox.Show("Документ з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            this.Item.EndEdit();

            ((ControlChecksDTO)Item).ControlPersonId = ((EmployeesInfoDTO)otkPersonEdit.GetSelectedDataRow()).EmployeeID;

            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

            if (_operation == Utils.Operation.Add)
                ((ControlChecksDTO)Item).ControlCheckId = projectDetailsService.ControlCheckCreate((ControlChecksDTO)Item);
            else
                projectDetailsService.ControlCheckUpdate((ControlChecksDTO)Item);

            return true;

        }

        private bool FindDublicate(ControlChecksDTO model)
        {
            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

            return projectDetailsService.GetControlChecks().Any(s => s.MarkDocumentNumber == model.MarkDocumentNumber && s.ControlCheckId != model.ControlCheckId);
        }

        #endregion


        #region Validation's

        private bool ControlValidation()
        {
            return controlValidationProvider.Validate();
        }

        private void controlValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void controlValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (controlValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void otkPersonEdit_EditValueChanged(object sender, EventArgs e)
        {
            controlValidationProvider.Validate((Control)sender);
        }

        private void packingDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            controlValidationProvider.Validate((Control)sender);
        }


        private void markDocumentTBox_EditValueChanged(object sender, EventArgs e)
        {
            controlValidationProvider.Validate((Control)sender);
        }

        #endregion

        

       

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

        public ControlChecksDTO Return()
        {
            return ((ControlChecksDTO)Item);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            this.Close();
        }

        private void orderNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            controlValidationProvider.Validate((Control)sender);
        }

        
        
    }
}