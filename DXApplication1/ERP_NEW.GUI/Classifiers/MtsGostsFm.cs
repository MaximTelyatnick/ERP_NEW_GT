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
    public partial class MtsGostsFm : DevExpress.XtraEditors.XtraForm
    {

        private IMtsNomenclaturesService mtsNomenclaturesService;

        private BindingSource mtsGostsBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public MtsGostsFm(UserTasksDTO userTasksDTO)
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
            var mtsGosts= new BindingList<MtsGostsDTO>(mtsNomenclaturesService.GetGosts().ToList());
            mtsGostsBS.DataSource = mtsGosts;
            mtsGostsGrid.DataSource = mtsGostsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addGostBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editGostBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteGostBtn.Enabled = (userTasksDTO.AccessRightId == 2);

        }

        private void AddGost()
        {
            using (MtsGostEditFm mtsGostEditFm = new MtsGostEditFm(Utils.Operation.Add, new MtsGostsDTO()))
            {
                if (mtsGostEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = mtsGostEditFm.Return();
                    mtsGostsGridView.BeginDataUpdate();
                    LoadData();
                    mtsGostsGridView.EndDataUpdate();
                    int rowHandle = mtsGostsGridView.LocateByValue("Id", return_Id);
                    mtsGostsGridView.FocusedRowHandle = rowHandle;
                }
            }

        }

        private void EditGost()
        {
            if (mtsGostsBS.Count != 0)
            {
                using (MtsGostEditFm mtsGostEditFm = new MtsGostEditFm(Utils.Operation.Update, mtsGostsBS.Current as MtsGostsDTO))
                {
                    if (mtsGostEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = mtsGostEditFm.Return();
                        mtsGostsGridView.BeginDataUpdate();
                        LoadData();
                        mtsGostsGridView.EndDataUpdate();
                        int rowHandle = mtsGostsGridView.LocateByValue("Id", return_Id);
                        mtsGostsGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        private void DeleteGost()
        {
            if (mtsGostsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити ГОСТ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (mtsNomenclaturesService.GostDelete(((MtsGostsDTO)mtsGostsBS.Current).Id))
                    {
                        int rowHandle = mtsGostsGridView.FocusedRowHandle - 1;
                        mtsGostsGridView.BeginDataUpdate();
                        LoadData();
                        mtsGostsGridView.EndDataUpdate();
                        mtsGostsGridView.FocusedRowHandle = (mtsGostsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void deleteGostBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteGost();
        }

        private void editGostBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditGost();
        }

        private void addGostBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddGost();
        }

        private void mtsGostsGrid_DoubleClick(object sender, EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
            {
                EditGost();
            }
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            mtsGostsGridView.BeginDataUpdate();
            LoadData();
            mtsGostsGridView.EndDataUpdate();
        }

    }
}