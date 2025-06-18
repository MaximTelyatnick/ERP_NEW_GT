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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.MTS
{
    public partial class JournalAssembliesFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsSpecificationsService mtsSpecificationsService;

        private BindingSource journalAssembliesBS = new BindingSource();
        private UserTasksDTO userTasksDTO;
        private bool ourProjects;

        public JournalAssembliesFm(UserTasksDTO userTasksDTO, bool ourProjects = true)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;
            this.ourProjects = ourProjects;

            AuthorizatedUserAccess();

            beginDateEdit.EditValue = new DateTime(DateTime.Now.Year, 1, 1).AddYears(-1);
            endDateEdit.EditValue = DateTime.Now;

            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        #region Metod's

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
                      
            journalAssembliesGridView.BeginDataUpdate();
          
            mtsSpecificationsService = Program.kernel.Get<IMtsSpecificationsService>();

            if(ourProjects)
                journalAssembliesBS.DataSource = mtsSpecificationsService.GetMtsAssembliesAll(beginDate, endDate).Where(bdsm => bdsm.DesignerCompanyId == 1).OrderByDescending(srt => srt.DateCreated).ToList();
            else
                journalAssembliesBS.DataSource = mtsSpecificationsService.GetMtsAssembliesAll(beginDate, endDate).Where(bdsm => bdsm.DesignerCompanyId != 1).OrderByDescending(srt => srt.DateCreated).ToList();

            journalAssembliesGrid.DataSource = journalAssembliesBS;

            journalAssembliesGridView.EndDataUpdate();
            
            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void AddAssembly()
        {
            MtsAssembliesDTO mtsAssembliesDTO = new MtsAssembliesDTO();
            if (ourProjects)
                mtsAssembliesDTO.DesignerCompanyId = 1;
            else
                mtsAssembliesDTO.DesignerCompanyId = 2;

            using (MtsAssemblyEditFm mtsAssemblyEditFm = new MtsAssemblyEditFm(Utils.Operation.Add, mtsAssembliesDTO))
            {
                if (mtsAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = mtsAssemblyEditFm.Return();
                    journalAssembliesGridView.BeginDataUpdate();
                    LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                    journalAssembliesGridView.EndDataUpdate();
                    int rowHandle = journalAssembliesGridView.LocateByValue("AssemblyId", return_Id);
                    journalAssembliesGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void EditAssembly()
        {
            if (journalAssembliesBS.Count != 0)
            {
                MtsAssembliesInfoDTO item = (MtsAssembliesInfoDTO)journalAssembliesBS.Current;
                using (MtsAssemblyEditFm mtsAssemblyEditFm = new MtsAssemblyEditFm(Utils.Operation.Update, new MtsAssembliesDTO
                {
                    Id = item.AssemblyId,
                    Name = item.Name,
                    Drawing = item.Drawing,
                    DesignerId = item.DesignerId,
                    Description = item.Description,
                    UserId = item.UserId,
                    DateCreated = item.DateCreated,
                    AssemblyStatus = item.AssemblyStatus,
                    CityId = item.CityId,
                    ContractorId = item.ContractorId,
                     DesignerCompanyId = item.DesignerCompanyId
                }))
                {
                    if (mtsAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = mtsAssemblyEditFm.Return();
                        journalAssembliesGridView.BeginDataUpdate();
                        LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                        journalAssembliesGridView.EndDataUpdate();
                        int rowHandle = journalAssembliesGridView.LocateByValue("AssemblyId", return_Id);
                        journalAssembliesGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }

        }

        private void DeleteAssembly()
        {
            if (journalAssembliesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити виріб?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (mtsSpecificationsService.DeleteSpecification((long)((MtsAssembliesInfoDTO)journalAssembliesBS.Current).SpecificationId))
                    {
                        if (mtsSpecificationsService.DeleteAssembly(((MtsAssembliesInfoDTO)journalAssembliesBS.Current).AssemblyId))
                        {
                            int rowHandle = journalAssembliesGridView.FocusedRowHandle - 1;
                            journalAssembliesGridView.BeginDataUpdate();
                            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                            journalAssembliesGridView.EndDataUpdate();
                            journalAssembliesGridView.FocusedRowHandle = (journalAssembliesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                        }
                    }
                }
            }
        }
        private void UpdateAssembly()
        {
            journalAssembliesGridView.BeginDataUpdate();
            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            journalAssembliesGridView.EndDataUpdate();
        }
        #endregion

            #region Event's

        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteAssembly();
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddAssembly();
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditAssembly();
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            journalAssembliesGridView.BeginDataUpdate();
            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            journalAssembliesGridView.EndDataUpdate();
        }

        private void journalAssembliesGridView_DoubleClick(object sender, EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
            {
                EditAssembly();
            }
        }

        #endregion

        private void changeAssemblyBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (journalAssembliesBS.Count != 0)
            {
                if (ourProjects)
                {

                    if (MessageBox.Show("Перемістити проєкт до журналу виробів (креслення замовників)?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mtsSpecificationsService.UpdateAssemblyDesignerCompany((int)((MtsAssembliesInfoDTO)journalAssembliesBS.Current).AssemblyId, 2);
                        UpdateAssembly();
                    }
                }
                else
                {
                    if (MessageBox.Show("Перемістити проєкт до журналу виробів (креслення наші)?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mtsSpecificationsService.UpdateAssemblyDesignerCompany((int)((MtsAssembliesInfoDTO)journalAssembliesBS.Current).AssemblyId, 1);
                        UpdateAssembly();
                    }
                }
            }
        }
    }
}