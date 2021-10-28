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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class MtsNomenclatureGroupsFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclaturesService;

        private BindingSource mtsNomenclatureGroupsBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public MtsNomenclatureGroupsFm(UserTasksDTO userTasksDTO)
        {

            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            LoadData();

            AuthorizatedUserAccess();
        }

        private void LoadData()
        {

            splashScreenManager.ShowWaitForm();
            mtsNomenclaturesService = Program.kernel.Get<IMtsNomenclaturesService>();
            var mtsNomenclatureGroups = new BindingList<MtsNomenclatureGroupsDTO>(mtsNomenclaturesService.GetNomenclatureGroups().ToList());
            mtsNomenclatureGroupsBS.DataSource = mtsNomenclatureGroups;
            mtsNomenclatureGroupsGrid.DataSource = mtsNomenclatureGroupsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addGroupBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editGroupBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteGroupBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void AddGroup()
        {
            using (MtsNomenclatureGroupEditFm mtsNomenclatureGroupEditFm = new MtsNomenclatureGroupEditFm(Utils.Operation.Add, new MtsNomenclatureGroupsDTO()))
            {
                if (mtsNomenclatureGroupEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = mtsNomenclatureGroupEditFm.Return();
                    mtsNomenclatureGroupsGridView.BeginDataUpdate();
                    LoadData();
                    mtsNomenclatureGroupsGridView.EndDataUpdate();
                    int rowHandle = mtsNomenclatureGroupsGridView.LocateByValue("Id", return_Id);
                    mtsNomenclatureGroupsGridView.FocusedRowHandle = rowHandle;
                }
            }

        }

        private void EditGroup()
        {
            if (mtsNomenclatureGroupsBS.Count != 0)
            {
                using (MtsNomenclatureGroupEditFm mtsNomenclatureGroupEditFm = new MtsNomenclatureGroupEditFm(Utils.Operation.Update, mtsNomenclatureGroupsBS.Current as MtsNomenclatureGroupsDTO))
                {
                    if (mtsNomenclatureGroupEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = mtsNomenclatureGroupEditFm.Return();
                        mtsNomenclatureGroupsGridView.BeginDataUpdate();
                        LoadData();
                        mtsNomenclatureGroupsGridView.EndDataUpdate();
                        int rowHandle = mtsNomenclatureGroupsGridView.LocateByValue("Id", return_Id);
                        mtsNomenclatureGroupsGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }

        }

        private void DeleteGroup()
        {
            if (mtsNomenclatureGroupsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити групу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (mtsNomenclaturesService.NomenclarureGroupDelete(((MtsNomenclatureGroupsDTO)mtsNomenclatureGroupsBS.Current).Id))
                    {
                        int rowHandle = mtsNomenclatureGroupsGridView.FocusedRowHandle - 1;
                        mtsNomenclatureGroupsGridView.BeginDataUpdate();
                        LoadData();
                        mtsNomenclatureGroupsGridView.EndDataUpdate();
                        mtsNomenclatureGroupsGridView.FocusedRowHandle = (mtsNomenclatureGroupsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void deleteGroupBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteGroup();
        }

        private void addGroupBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddGroup();
        }

        private void editGroupBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditGroup();
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            mtsNomenclatureGroupsGridView.BeginDataUpdate();
            LoadData();
            mtsNomenclatureGroupsGridView.EndDataUpdate();
        }

        private void mtsNomenclatureGroupsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
            {
                EditGroup();
            }
        }
    }
}