using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Collections;
using DevExpress.XtraTreeList;
using System.Collections.Generic;
using System.ComponentModel;

using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using DevExpress.XtraTreeList.Nodes;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.GUI;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Tools
{
    public partial class TasksEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IUserService usersService;
        private BindingSource tasksBS = new BindingSource();
        private int roleId;
        private List<TasksDTO> source;
        private Utils.Operation operation;

        public TasksEditFm(int roleId, Utils.Operation operation, List<TasksDTO> listTasks)
        {

            InitializeComponent();
            usersService = Program.kernel.Get<IUserService>();
            this.roleId = roleId;
            this.operation = operation;
            source = (this.operation == Utils.Operation.Update ? listTasks : usersService.GetTasks(roleId).ToList());
            tasksBS.DataSource = source;
            tasksTreeList.DataSource = tasksBS;
            tasksTreeList.KeyFieldName = "TaskId";
            tasksTreeList.ParentFieldName = "ParentId";
            tasksTreeList.ExpandAll();

            if (this.operation == Utils.Operation.Update)
                tasksTreeList.Columns[0].Visible = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (this.operation == Utils.Operation.Update)
            {
                if (MessageBox.Show("Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<UserTasksDTO> userTasks = source.Select(s => new UserTasksDTO { UserRoleId = roleId, UserTaskId = (int)s.UserTaskId, TaskId = s.TaskId, AccessRightId = (s.AccessRight ? 1 : 2), PriceAttribute = s.PriceAttribute }).ToList();
                    usersService.UserTasksUpdateRange(userTasks);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                var tasks = source.Where(s => s.Checked && s.UserTaskId == null).ToList();
                if (tasks.Count > 0)
                {
                    if (MessageBox.Show("Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        List<UserTasksDTO> userTasks = tasks.Select(s => new UserTasksDTO { UserRoleId = roleId, TaskId = s.TaskId, AccessRightId = (s.AccessRight ? 1 : 2), PriceAttribute = s.PriceAttribute }).ToList();
                        usersService.UserTasksCreateRange(userTasks);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void repositoryItemCheckEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.CheckEdit editor = sender as DevExpress.XtraEditors.CheckEdit;
            ((TasksDTO)tasksBS.Current).Checked = (editor.CheckState == CheckState.Checked ? true : false);

            if ((((TreeListNode)tasksTreeList.FocusedNode).Level > 0))
            {
                var parent = ((TreeListNode)tasksTreeList.FocusedNode).ParentNode;
                int taskId = ((TasksDTO)tasksTreeList.GetDataRecordByNode(parent)).TaskId;

                if (editor.CheckState == CheckState.Checked)
                    source.Where(s => s.TaskId == taskId).Select(s => { s.Checked = true; return s; }).ToList();
                else
                {
                    var countNode = source.Count(s => s.ParentId == taskId && s.Checked);
                    if (countNode == 0)
                        source.Where(s => s.TaskId == taskId).Select(s => { s.Checked = false; return s; }).ToList();
                }
                tasksBS.ResetBindings(false);
            }

            if ((((TreeListNode)tasksTreeList.FocusedNode).Level == 0)) //&& (editor.CheckState == CheckState.Unchecked))
            {
                var node = (TreeListNode)tasksTreeList.FocusedNode;
                int parentId = ((TasksDTO)tasksTreeList.GetDataRecordByNode(node)).TaskId;
                source.Where(s => s.ParentId == parentId).Select(s => { s.Checked = (editor.CheckState == CheckState.Unchecked ? false : true); return s; }).ToList();
                tasksBS.ResetBindings(false);
            }
        }
    }
}