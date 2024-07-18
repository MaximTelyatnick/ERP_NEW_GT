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

namespace ERP_NEW.GUI.Tools
{
    public partial class UserAuthFm : DevExpress.XtraEditors.XtraForm
    {
        public UserAuthFm(string login)
        {
            InitializeComponent();
            loginEdit.Text = login;
            //loginEdit.DataBindings.Add("EditValue", login, "Text", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.authBtn.Enabled = false;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.authBtn.Enabled = isValidate;
        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            if ((loginEdit.Text == "SuperUser") && (passEdit.Text == Properties.Settings.Default.SuperUserPass))
            {
                Properties.Settings.Default.SuperUser = true;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Не вірний логін або пароль!", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UserAuthFm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                authBtn.PerformClick();

        }

        private void passEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                authBtn.PerformClick();
        }
    }
}