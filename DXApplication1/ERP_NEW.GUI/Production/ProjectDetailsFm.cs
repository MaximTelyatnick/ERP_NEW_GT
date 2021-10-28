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
using Ninject;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Production
{
    public partial class ProjectDetailsFm : DevExpress.XtraEditors.XtraForm
    {
        private IProjectDetailsService projectDetailsService;
        private BindingSource projectDetailsBS = new BindingSource();
        private BindingSource projectDetailExecutorsBS = new BindingSource();
        public UserTasksDTO userTasksDTO;

        public ProjectDetailsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();

            LoadData();
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addActBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editActBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteActBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            addTemplateActBtn.Enabled = (userTasksDTO.AccessRightId == 2);

            addPersonItem.Enabled = (userTasksDTO.AccessRightId == 2);
            deletePersonBtn.Enabled = (userTasksDTO.AccessRightId == 2);

            addOtkMarkItem.Enabled = (userTasksDTO.AccessRightId == 2);
            editOtkMarkItem.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteOtkMarkItem.Enabled = (userTasksDTO.AccessRightId == 2);

            switch (userTasksDTO.UserRoleId)
            {
                case 13:
                    addOtkMarkItem.Enabled = (userTasksDTO.AccessRightId == 1);
                    editOtkMarkItem.Enabled = (userTasksDTO.AccessRightId == 1);
                    deleteOtkMarkItem.Enabled = (userTasksDTO.AccessRightId == 1);
                    break;
                case 2:
                    addActBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                    editActBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                    deleteActBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                    addPersonItem.Enabled = (userTasksDTO.AccessRightId == 1);
                    deletePersonBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                    addTemplateActBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                    break;

                default:
                    break;
            }

        }

        private void LoadData()
        {
            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

            splashScreenManager.ShowWaitForm();

            var projectDetails = projectDetailsService.GetProjectDetails();

            projectDetailsBS.DataSource = projectDetails;
            projectDetailsGrid.DataSource = projectDetailsBS;

            splashScreenManager.CloseWaitForm();

        }


        public void LoadExecutorsData(int projectDetailId)
        {

            //var executorsByProject = (projectDetailsBS.Count == 0 ? null : projectDetailsService.GetProjectDetailExecutors().Where(c => c.ProjectDetailId == ((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId).ToList());
            //projectDetailExecutorsBS.DataSource = executorsByProject;
            //this.projectDetailExecutorsGrid.DataSource = projectDetailExecutorsBS;

            var executorsByProject = projectDetailsService.GetProjectDetailExecutors(projectDetailId);
            projectDetailExecutorsBS.DataSource = executorsByProject;
            this.projectDetailExecutorsGrid.DataSource = projectDetailExecutorsBS;

        }

        private void AddProject(ProjectDetailsDTO model)
        {
            using (ProjectDetailEditFm projectDetailEditFm = new ProjectDetailEditFm(Utils.Operation.Add, model))
            {
                if (projectDetailEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_projectId = projectDetailEditFm.Return();
                    projectDetailsGridView.PostEditor();
                    projectDetailsGridView.BeginUpdate();
                    LoadData();
                    projectDetailsGridView.EndUpdate();
                    int rowHandle = projectDetailsGridView.LocateByValue("ProjectDetailId", return_projectId);
                    projectDetailsGrid.Refresh();
                    projectDetailsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void EditProject()
        {
            using (ProjectDetailEditFm projectDetailEditFm = new ProjectDetailEditFm(Utils.Operation.Update, (ProjectDetailsDTO)projectDetailsBS.Current))
            {
                if (projectDetailEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_projectId = projectDetailEditFm.Return();
                    projectDetailsGridView.PostEditor();
                    projectDetailsGridView.BeginUpdate();
                    LoadData();
                    projectDetailsGridView.EndUpdate();
                    int rowHandle = projectDetailsGridView.LocateByValue("ProjectDetailId", return_projectId);
                    projectDetailsGrid.Refresh();
                    projectDetailsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void AddProjectTemplate(ProjectDetailsDTO model)
        {
            using (ProjectDetailEditFm projectDetailEditFm = new ProjectDetailEditFm(Utils.Operation.Template, model))
            {
                if (projectDetailEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_projectId = projectDetailEditFm.Return();
                    projectDetailsGridView.PostEditor();
                    projectDetailsGridView.BeginUpdate();
                    LoadData();
                    projectDetailsGridView.EndUpdate();
                    int rowHandle = projectDetailsGridView.LocateByValue("ProjectDetailId", return_projectId);
                    projectDetailsGrid.Refresh();
                    projectDetailsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void DeleteProject()
        {
            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (projectDetailsService.ProjectDetailDelete(((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId))
                {
                    projectDetailsGridView.BeginUpdate();
                    LoadData();
                    projectDetailsGridView.EndUpdate();
                    projectDetailsGrid.Refresh();
                }
            }
        }

        private void AddProjectPerson()
        {
            using (ProjectExetutersEditFm projectExetutersEditFm = new ProjectExetutersEditFm((ProjectDetailsDTO)projectDetailsBS.Current))
            {
                if (projectExetutersEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadData();
                    LoadExecutorsData(((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId);
                }
            }
        }

        private void DeleteProjectPerson()
        {
            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

                if (this.projectDetailsService.ProjectExecutorsDelete(((ProjectDetailExecutorsDTO)projectDetailExecutorsBS.Current).ProjectDetailExecutorId))
                    this.projectDetailExecutorsBS.RemoveCurrent();

                LoadData();
            }
        }

        private void AddControlMark()
        {
            using (ControlCheckEditFm controlCheckEditFm = new ControlCheckEditFm(Utils.Operation.Add, new ControlChecksDTO() { ProjectDetailId = ((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId }))
            {
                if (controlCheckEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    projectDetailsGridView.BeginUpdate();
                    LoadData();
                    projectDetailsGridView.EndUpdate();
                }
            }
        }

        private void EditControlMark()
        {
            using (ControlCheckEditFm controlCheckEditFm = new ControlCheckEditFm(Utils.Operation.Update, new ControlChecksDTO()
            {
                ProjectDetailId = ((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId,
                ControlCheckId = ((ProjectDetailsDTO)projectDetailsBS.Current).ControlCheckId ?? 0,
                ControlDate = ((ProjectDetailsDTO)projectDetailsBS.Current).ControlDate ?? DateTime.Now,
                ControlPersonId = ((ProjectDetailsDTO)projectDetailsBS.Current).ControlPersonId ?? 0,
                Description = ((ProjectDetailsDTO)projectDetailsBS.Current).Description,
                MarkDocumentNumber = ((ProjectDetailsDTO)projectDetailsBS.Current).MarkDocumentNumber
                 
            }))
            {
                if (controlCheckEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    projectDetailsGridView.BeginUpdate();
                    LoadData();
                    projectDetailsGridView.EndUpdate();

                }
            }
        }

        private void DeleteControlMark()
        {
            if (MessageBox.Show("Видалити відмітку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

                if (this.projectDetailsService.ControlCheckDelete(((ProjectDetailsDTO)projectDetailsBS.Current).ControlCheckId ?? 0))
                    LoadData();
            }
        }

        #endregion

        #region Event's

        private void addActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddProject(new ProjectDetailsDTO());
        }

        private void editActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0)
                EditProject();
        }

        private void deleteActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0)
                DeleteProject();
        }

        private void addPersonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0)
                AddProjectPerson();
        }

        private void deletePersonBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailExecutorsBS.Count > 0)
                DeleteProjectPerson();
        }

        private void addOtkMark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0)
                AddControlMark();
        }

        private void editOtkMarkItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0 && ((ProjectDetailsDTO)projectDetailsBS.Current).ControlCheckId != null)
                EditControlMark();
        }

        private void deleteOtkMark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0 && ((ProjectDetailsDTO)projectDetailsBS.Current).ControlCheckId != null)
                DeleteControlMark();
        }

        private void addTemplateActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (projectDetailsBS.Count > 0)
            {
                ProjectDetailsDTO model = new ProjectDetailsDTO()
                {
                    Drawing = ((ProjectDetailsDTO)projectDetailsBS.Current).Drawing,
                    AssemblyId = ((ProjectDetailsDTO)projectDetailsBS.Current).AssemblyId,
                    //AssemblyName = ((ProjectDetailsDTO)projectDetailsBS.Current).AssemblyName,
                    CustomerOrderId = ((ProjectDetailsDTO)projectDetailsBS.Current).CustomerOrderId,
                    AssemblyDate = ((ProjectDetailsDTO)projectDetailsBS.Current).AssemblyDate,
                    OrderNumber = ((ProjectDetailsDTO)projectDetailsBS.Current).OrderNumber,
                    OrderDate = ((ProjectDetailsDTO)projectDetailsBS.Current).OrderDate,
                    AssemblyDrawing = "",
                    AssemblyName = "",
                    AssemblyGeneralName = ((ProjectDetailsDTO)projectDetailsBS.Current).AssemblyGeneralName
                };
                AddProjectTemplate(model);
            }
        }

        private void projectDetailsGridView_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (projectDetailsBS.Count > 0)
            {
                LoadExecutorsData(((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId);
            }
            else
            {
                projectDetailsBS.DataSource = null;
                projectDetailExecutorsBS.DataSource = null;
            }
        }

        #endregion

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
 
    }
}