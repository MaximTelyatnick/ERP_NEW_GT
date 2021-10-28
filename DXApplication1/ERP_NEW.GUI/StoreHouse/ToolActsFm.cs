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
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class ToolActsFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO _userTasksDTO;

        private IStoreHouseService storeHouseService;
        private IReportService reportService;

        private BindingSource toolsActsBS = new BindingSource();
        private BindingSource toolsActMaterialsBS = new BindingSource();

        public ToolActsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            startDateEdit.EditValue = firstDay;
            endDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            LoadDataToolActs((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        #region Method's                        

        private void LoadDataToolActs(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            toolsActsBS.DataSource = storeHouseService.GetAllToolActs((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);

            toolActGrid.DataSource = toolsActsBS;

            if (toolsActsBS.Count > 0)
                LoadDataToolMaterials(((ToolActsDTO)toolsActsBS.Current).Id);

            splashScreenManager.CloseWaitForm();
        }

        private void LoadDataToolMaterials(int id)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            toolsActMaterialsBS.DataSource = storeHouseService.GetToolActMaterialsById(id);

            toolMaterialGrid.DataSource = toolsActMaterialsBS;

        }

        private void AuthorizatedUserAccess()
        {
            startDateEdit.Enabled = (_userTasksDTO.AccessRightId == 2);
            endDateEdit.Enabled = (_userTasksDTO.AccessRightId == 2);
            showBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            updateBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            writeActWriteOffMaterialsBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void DeleteToolAct()
        {
            if (toolsActsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити акт?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = toolActGridView.FocusedRowHandle - 1;
                    toolActGridView.BeginDataUpdate();

                    storeHouseService.ToolActsDelete(((ToolActsDTO)toolsActsBS.Current).Id);

                    LoadDataToolActs((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                    if (toolsActsBS.Count == 0)
                        toolsActMaterialsBS.DataSource = null;
                    toolActGridView.EndDataUpdate();
                    toolActGridView.FocusedRowHandle = (toolActGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void EditToolAct(Utils.Operation operation, ToolActsDTO toolActsModel, List<ToolActMaterialsJournalDTO> toolActsMaterialsModel)
        {
            using (ToolActEditFm toolActEditFm = new ToolActEditFm(operation, toolActsModel, toolActsMaterialsModel))
            {
                if (toolActEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ToolActsDTO toolActsDTO = toolActEditFm.Return();

                    toolActGridView.BeginDataUpdate();

                    LoadDataToolActs((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);

                    toolActGridView.EndDataUpdate();

                    int rowHandle = toolActGridView.LocateByValue("Id", toolActsDTO.Id);
                    toolActGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        #endregion

        #region Event's                         

        private void showEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            LoadDataToolActs((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataToolActs((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (toolsActsBS.Count > 0)
                EditToolAct(Utils.Operation.Update, (ToolActsDTO)toolsActsBS.Current, (List<ToolActMaterialsJournalDTO>)toolsActMaterialsBS.DataSource);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditToolAct(Utils.Operation.Add, new ToolActsDTO(), new List<ToolActMaterialsJournalDTO>());
        }

        private void toolActGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (toolsActsBS.Count > 0)
                LoadDataToolMaterials(((ToolActsDTO)toolsActsBS.Current).Id);

        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (toolsActsBS.Count > 0)
            {
                try
                {
                    DeleteToolAct();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void writeActWriteOffMaterialsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (toolsActsBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintToolMaterialsJournalWriteOff((List<ToolActMaterialsJournalDTO>)toolsActMaterialsBS.DataSource, (DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            }
        }

        private void toolActGridView_DoubleClick(object sender, EventArgs e)
        {
            if (toolsActsBS.Count > 0)
                EditToolAct(Utils.Operation.Update, (ToolActsDTO)toolsActsBS.Current, (List<ToolActMaterialsJournalDTO>)toolsActMaterialsBS.DataSource);
        }

        #endregion

    }
}