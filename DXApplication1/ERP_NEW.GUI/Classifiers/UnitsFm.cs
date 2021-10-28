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
    public partial class UnitsFm : DevExpress.XtraEditors.XtraForm
    {
        private IUnitsService unitsService;

        private BindingSource unitsBS = new BindingSource();
        private UserTasksDTO userTasksDTO;

        public UnitsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            LoadData();

            AuthorizatedUserAccess();
        }
        
        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();
         
            unitsService = Program.kernel.Get<IUnitsService>();
            var units = new BindingList<UnitsDTO>(unitsService.GetUnits().ToList());
            unitsBS.DataSource = units;
            unitsGrid.DataSource = unitsBS;

            splashScreenManager.CloseWaitForm();
        }

        public void AuthorizatedUserAccess()
        {
            addUnitBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editUnitBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteUnitBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        public void AddUnit()
        {
            using (UnitEditFm unitEditFm = new UnitEditFm(Utils.Operation.Add, new UnitsDTO()))
            {
                if (unitEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = unitEditFm.Return();
                    unitsGridView.BeginDataUpdate();
                    LoadData();
                    unitsGridView.EndDataUpdate();
                    int rowHandle = unitsGridView.LocateByValue("UnitId", return_Id);
                    unitsGridView.FocusedRowHandle = rowHandle;
                }
            }

        }

        public void EditUnit()
        {
            if (unitsBS.Count != 0)
            {
                using (UnitEditFm unitEditFm = new UnitEditFm(Utils.Operation.Update, unitsBS.Current as UnitsDTO))
                {
                    if (unitEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = unitEditFm.Return();
                        unitsGridView.BeginDataUpdate();
                        LoadData();
                        unitsGridView.EndDataUpdate();
                        int rowHandle = unitsGridView.LocateByValue("UnitId", return_Id);
                        unitsGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        public void DeleteUnit()
        {
            if (unitsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити одиницю вимірювання?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (unitsService.UnitDelete(((UnitsDTO)unitsBS.Current).UnitId))
                    {
                        int rowHandle = unitsGridView.FocusedRowHandle - 1;
                        unitsGridView.BeginDataUpdate();
                        LoadData();
                        unitsGridView.EndDataUpdate();
                        unitsGridView.FocusedRowHandle = (unitsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void addUnitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUnit();
        }

        private void editUnitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditUnit();
        }

        private void deleteUnitBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteUnit();
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            unitsGridView.BeginDataUpdate();
            LoadData();
            unitsGridView.EndDataUpdate();
        }

        private void unitsGrid_DoubleClick(object sender, EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
            {
                EditUnit();
            }
        }
    }
}