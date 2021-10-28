using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System;
using System.Collections;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;

namespace ERP_NEW.GUI.Tools
{
    public partial class UserRoleEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IUserService userService;
        private BindingSource userRoleBS = new BindingSource();
        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return userRoleBS.Current as ObjectBase; }
            set
            {
                userRoleBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public UserRoleEditFm(Utils.Operation operation, UserRolesDTO userRole)
        {
            InitializeComponent();

            _operation = operation;
            userRoleBS.DataSource = Item = userRole;

            roleNameTBox.DataBindings.Add("EditValue", userRoleBS, "RoleName");
        }

        # region Metod's

        private void SaveUserRole()
        {
            this.Item.EndEdit();

            if (_operation == Utils.Operation.Add)
                ((UserRolesDTO)Item).RoleId = userService.UserRoleCreate((UserRolesDTO)Item);
            else
                userService.UserRoleUpdate((UserRolesDTO)Item);
        }

        private bool ControlValidation()
        {
            return userRoleValidationProvider.Validate();
        }

        private bool IsDuplicateRecord(string roleName)
        {
            return userService.GetUserRoles().Any(s => s.RoleName == roleName);
        }

        public int Return()
        {
            return ((UserRolesDTO)Item).RoleId;
        }

        #endregion

        #region Event's

        private void userRoleValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void userRoleValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (userRoleValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void roleNameTBox_TextChanged(object sender, EventArgs e)
        {
            userRoleValidationProvider.Validate((Control)sender);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ControlValidation()) return;

            if (MessageBox.Show("Зберегти зміни?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userService = Program.kernel.Get<IUserService>();

                if (_operation == Utils.Operation.Add && IsDuplicateRecord(((UserRolesDTO)Item).RoleName))
                {
                    MessageBox.Show("Група з такою назвою вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    roleNameTBox.Focus();
                    return;
                }

                SaveUserRole();

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

        
    }
}