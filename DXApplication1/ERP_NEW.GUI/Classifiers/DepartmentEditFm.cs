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
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class DepartmentEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IEmployeesService employeesService;

        private BindingSource departmentsBS = new BindingSource();

        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return departmentsBS.Current as ObjectBase; }
            set
            {
                departmentsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DepartmentEditFm(Utils.Operation operation, DepartmentsDTO model)
        {
            InitializeComponent();

            this.operation = operation;
            departmentsBS.DataSource = Item = model;
            departmentNameEdit.DataBindings.Add("EditValue", departmentsBS, "Name");
            departmentCodeEdit.DataBindings.Add("EditValue", departmentsBS, "Code");
            dxValidationProvider.Validate();
        }

        #region Method's

        private bool SaveDepartment()
        {
            this.Item.EndEdit();

            employeesService = Program.kernel.Get<IEmployeesService>();

            if (operation == Utils.Operation.Add)
            {
                ((DepartmentsDTO)Item).RootID = 1;
                ((DepartmentsDTO)Item).DepartmentID = employeesService.GetLastDepartmentId() + 1;
                employeesService.DepartmentsCreate((DepartmentsDTO)Item);
            }
            else
            {
                employeesService.DepartmentUpdate((DepartmentsDTO)Item);
            }
            return true;
        }

        private bool FindDublicate(DepartmentsDTO model)
        {
            return employeesService.GetDepartments().Any(s => s.Name.Trim() == model.Name.Trim());
        }

        public long Return()
        {
            return ((DepartmentsDTO)Item).DepartmentID;
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveDepartment())
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
            return dxValidationProvider.Validate();
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void departmentNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void departmentCodeEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        #endregion
     
    }
}