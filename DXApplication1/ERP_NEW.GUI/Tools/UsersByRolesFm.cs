using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Collections;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using System;

using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;


namespace ERP_NEW.GUI.Tools
{
    public partial class UsersByRolesFm : DevExpress.XtraEditors.XtraForm
    {
        private IUserService userService;
        private BindingSource userRolesBS = new BindingSource();
        private BindingSource usersBS = new BindingSource();
        private BindingSource userTasksBS = new BindingSource();
        private List<UserTasksDTO> usersTasksList = new List<UserTasksDTO>();
        private List<TasksDTO> listTasks = new List<TasksDTO>();
        private List<UserRolesDTO> userRolesList = new List<UserRolesDTO>();
        private List<UsersInfoDTO> usersList = new List<UsersInfoDTO>();

        public UsersByRolesFm()
        {
            InitializeComponent();

            LoadRoles();
        }

        private void LoadRoles()
        {
            userService = Program.kernel.Get<IUserService>();
            userRolesBS.DataSource = userService.GetUserRoles().ToList();
            userRolesGrid.DataSource = userRolesBS;
        }

        private void userRolesGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (userRolesBS.Count > 0)
            {
                userService = Program.kernel.Get<IUserService>();

                usersList = userService.GetUsers().Where(m => m.UserRoleId == ((UserRolesDTO)userRolesBS.Current).RoleId).ToList();
                usersBS.DataSource = usersList;
                usersGrid.DataSource = usersBS;

                usersTasksList = userService.GetUserTasks(((UserRolesDTO)userRolesBS.Current).RoleId).ToList();
                userTasksBS.DataSource = usersTasksList;
                userTasksGrid.DataSource = userTasksBS;

            }
        
        }

        private void tasksAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userRolesBS.Count > 0)
            {
                using (TasksEditFm tasksEditFm = new TasksEditFm(((UserRolesDTO)userRolesBS.Current).RoleId, Utils.Operation.Add, null))
                {
                    if (tasksEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void tasksEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userTasksBS.Count > 0)
            {
                listTasks = usersTasksList.Select(c => new TasksDTO { TaskId = c.TaskId, TaskName = c.TaskName, TaskCaption = c.TaskCaption, UserTaskId = c.UserTaskId, AccessRight = (c.AccessRightId == 1 ? true : false), PriceAttribute = c.PriceAttribute }).ToList();
                using (TasksEditFm tasksEditFm = new TasksEditFm(((UserRolesDTO)userRolesBS.Current).RoleId, Utils.Operation.Update, listTasks))
                {
                    if (tasksEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void taskDeleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userTasksBS.Count > 0)
            {
                if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.userService.UserTaskDeleteById(((UserTasksDTO)userTasksBS.Current).UserTaskId))
                        this.userTasksBS.RemoveCurrent();

                    LoadData();
                }
            }
        }

        private void usersAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userRolesBS.Count > 0)
            {
                using (UsersByRolesEditFm usersByRolesEditFm = new UsersByRolesEditFm(((UserRolesDTO)userRolesBS.Current).RoleId))
                {
                    if (usersByRolesEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
        }

        private void userDeleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (usersBS.Count > 0)
            {
                if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.userService.UserDeleteById(((UsersInfoDTO)usersBS.Current).UserId))
                        this.usersBS.RemoveCurrent();

                    LoadData();
                }
            }
        }

        private void userRoleAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (UserRoleEditFm userRoleEditFm = new UserRoleEditFm(Utils.Operation.Add, new UserRolesDTO()))
            {
                if (userRoleEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_RoleId = userRoleEditFm.Return();
                    userRolesGridView.BeginDataUpdate();

                    LoadRoles();

                    userRolesGridView.EndDataUpdate();
                    int rowHandle = userRolesGridView.LocateByValue("RoleId", return_RoleId);
                    userRolesGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void userRoleEditItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (userRolesBS.Count > 0)
            {
                using (UserRoleEditFm userRoleEditFm = new UserRoleEditFm(Utils.Operation.Update, (UserRolesDTO)userRolesBS.Current))
                {
                    if (userRoleEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        int return_RoleId = userRoleEditFm.Return();
                        userRolesGridView.BeginDataUpdate();

                        LoadRoles();

                        userRolesGridView.EndDataUpdate();
                        int rowHandle = userRolesGridView.LocateByValue("RoleId", return_RoleId);
                        userRolesGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        private void userRoleDeleteItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((usersBS.Count == 0) && (userTasksBS.Count == 0))
            {
                if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.userService.UserRoleDeleteById(((UserRolesDTO)userRolesBS.Current).RoleId))
                        this.userRolesBS.RemoveCurrent();

                    userService = Program.kernel.Get<IUserService>();
                    LoadRoles();
                }

            }
            else
                MessageBox.Show("Групу не можна видилити, бо вона містить поєднані дані", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}