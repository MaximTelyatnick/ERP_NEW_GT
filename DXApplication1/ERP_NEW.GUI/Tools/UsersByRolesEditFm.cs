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

using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Tools
{
    public partial class UsersByRolesEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IUserService userService;
        private BindingSource usersByRolesBS = new BindingSource();
        private List<UsersInfoDTO> source;
        private int _roleId;

        public UsersByRolesEditFm(int roleId)
        {
            InitializeComponent();

            userService = Program.kernel.Get<IUserService>();
            _roleId = roleId;
            source = userService.GetUsers().Where(s => s.UserRoleId != roleId).ToList();
            usersByRolesBS.DataSource = source;
            usersByRolesGrid.DataSource = usersByRolesBS;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var usersList = source.Where(s => s.Checked == "1").Select(s => new UsersDTO
            {
                EmployeeNumber = s.EmployeeNumber,
                EmployeeId = s.EmployeeId,
                UserRoleId = _roleId
            }).ToList();

            if (usersList.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Додати користувача(ів)?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        userService.UsersUpdateRange(usersList);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при збереженні!\n" + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Не відмічено жодного користувача", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit editor = sender as DevExpress.XtraEditors.CheckEdit;

            ((UsersInfoDTO)usersByRolesGridView.GetFocusedRow()).Checked = (editor.CheckState == CheckState.Checked ? "1" : "0");
        }
    }
}