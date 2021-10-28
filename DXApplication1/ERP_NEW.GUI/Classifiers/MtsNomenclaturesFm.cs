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
    public partial class MtsNomenclaturesFm : DevExpress.XtraEditors.XtraForm
    {
        private IMtsNomenclaturesService mtsNomenclaturesService;

        private BindingSource mtsNomenclaturesBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public MtsNomenclaturesFm(UserTasksDTO userTasksDTO)
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
            var mtsNomenclatures = new BindingList<MtsNomenclaturesDTO>(mtsNomenclaturesService.GetNomenclarures().ToList());
            mtsNomenclaturesBS.DataSource = mtsNomenclatures;
            mtsNomenclaturesGrid.DataSource = mtsNomenclaturesBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addMaterialBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editMaterialBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteMaterialBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            priceCol.Visible = (userTasksDTO.PriceAttribute == 1);
        }

        private void AddNomenclature()
        {
            using (MtsNomenclatureEditFm mtsNomenclatureEditFm = new MtsNomenclatureEditFm(Utils.Operation.Add, new MtsNomenclaturesDTO()))
            {
                if (mtsNomenclatureEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                   long return_Id = mtsNomenclatureEditFm.Return();
                    mtsNomenclaturesGridView.BeginDataUpdate();
                    LoadData();
                    mtsNomenclaturesGridView.EndDataUpdate();
                    int rowHandle = mtsNomenclaturesGridView.LocateByValue("Id", return_Id);
                    mtsNomenclaturesGridView.FocusedRowHandle = rowHandle;
                }
            }

        }

        private void EditNomenclature()
        {
            if (mtsNomenclaturesBS.Count != 0)
            {
                using (MtsNomenclatureEditFm mtsNomenclatureEditFm = new MtsNomenclatureEditFm(Utils.Operation.Update, mtsNomenclaturesBS.Current as MtsNomenclaturesDTO))
                {
                    if (mtsNomenclatureEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = mtsNomenclatureEditFm.Return();
                        mtsNomenclaturesGridView.BeginDataUpdate();
                        LoadData();
                        mtsNomenclaturesGridView.EndDataUpdate();
                        int rowHandle = mtsNomenclaturesGridView.LocateByValue("Id", return_Id);
                        mtsNomenclaturesGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }

        }

        private void DeleteNomenclature()
        {
            if (mtsNomenclaturesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити номенклатуру?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (mtsNomenclaturesService.NomenclarureDelete(((MtsNomenclaturesDTO)mtsNomenclaturesBS.Current).Id))
                    {
                        int rowHandle = mtsNomenclaturesGridView.FocusedRowHandle - 1;
                        mtsNomenclaturesGridView.BeginDataUpdate();
                        LoadData();
                        mtsNomenclaturesGridView.EndDataUpdate();
                        mtsNomenclaturesGridView.FocusedRowHandle = (mtsNomenclaturesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void deleteMaterialBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteNomenclature();
        }

        private void addMaterialBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddNomenclature();
        }

        private void editMaterialBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditNomenclature();
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            mtsNomenclaturesGridView.BeginDataUpdate();
            LoadData();
            mtsNomenclaturesGridView.EndDataUpdate();
        }

        private void mtsNomenclaturesGridView_DoubleClick(object sender, EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
            {
                EditNomenclature();
            }
        }

        private void nomenclatureGroupsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
           new MtsNomenclatureGroupsFm(this.userTasksDTO).Show();
        }
    }
}