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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace ERP_NEW.GUI.OTK
{
    public partial class DefectActsFm : DevExpress.XtraEditors.XtraForm
    {
        private IDefectActsService defectActsService;
        private IMtsSpecificationsService mtsSpecificationService;
        
        private BindingSource defectActsBS = new BindingSource();
        private BindingSource defectActRepliesBS = new BindingSource();
        
        private UserTasksDTO _userTasksDTO;
        
        public DefectActsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            beginDateEditItem.EditValue = new DateTime(DateTime.Now.Year, 1, 1);
            endDateEditItem.EditValue = DateTime.Today;

            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
            
            AuthorizatedUserAccess();
        }

        #region Method's

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            defectActsService = Program.kernel.Get<IDefectActsService>();

            var defectActs = defectActsService.GetDefectActs(beginDate, endDate);
            defectActsBS.DataSource = defectActs;
            defectActsGrid.DataSource = defectActsBS;
            
            if(defectActsBS.Count > 0)
                LoadRepliesData(((DefectActsDTO)defectActsBS.Current).Id);

            splashScreenManager.CloseWaitForm();
        }

        public void LoadRepliesData(int id)
        {
            defectActsService = Program.kernel.Get<IDefectActsService>();
            defectActRepliesBS.DataSource = defectActsService.GetDefectActReplies(id);

            this.defectActRepliesGrid.DataSource = defectActRepliesBS;
        }

        public void AuthorizatedUserAccess()
        {
            addActBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editActBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteActBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addDocumentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editDocumentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteDocumentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void EditDefectAct(Utils.Operation operation, DefectActsDTO model)
        {
            using (DefectActEditFm defectActEditFm = new DefectActEditFm(operation, model))
            {
                if (defectActEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = defectActEditFm.Return();
                    
                    defectActsGridView.BeginDataUpdate();
                    LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                    defectActsGridView.EndDataUpdate();
                    
                    int rowHandle = defectActsGridView.LocateByValue("DefectActId", return_Id);
                    defectActsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void EditDefectActReplie(Utils.Operation operation, DefectActRepliesDTO model)
        {
            using (DefectActRepliesEditFm defectActRepliesFm = new DefectActRepliesEditFm(operation, model))
            {
                if (defectActRepliesFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = defectActRepliesFm.Return();

                    defectActRepliesGridView.BeginDataUpdate();

                    LoadRepliesData(((DefectActsDTO)defectActsBS.Current).Id);

                    defectActRepliesGridView.EndDataUpdate();
                    int rowHandle = defectActRepliesGridView.LocateByValue("Id", return_Id);
                    defectActRepliesGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        #endregion

        #region Event's

        private void defectActsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(defectActsBS.Count > 0)
                LoadRepliesData(((DefectActsDTO)defectActsBS.Current).Id);
        }

        private void defectActsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column == informationCol && e.IsGetData)
            {
                if (((DefectActsDTO)defectActsBS[e.ListSourceRowIndex]).ScanPersence == 1)
                    e.Value = columnCollection.Images[0];
            }

            if (e.Column == assemblyInfoCol && e.IsGetData)
            {
                e.Value = columnCollection.Images[1];
            }
        }

        private void defectActRepliesGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column == infoCol && e.IsGetData)
            {
                if (((DefectActRepliesDTO)defectActRepliesBS[e.ListSourceRowIndex]).ScanPersence == 1)
                    e.Value = columnCollection.Images[0];
             }
        }

        private void addActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDefectAct(Utils.Operation.Add, new DefectActsDTO());
        }

        private void editActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defectActsBS.Count > 0)
                EditDefectAct(Utils.Operation.Update, (DefectActsDTO)defectActsBS.Current);
        }

        private void deleteActBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defectActsBS.Count > 0)
            {
                if (MessageBox.Show("Видалити акт?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    defectActsService = Program.kernel.Get<IDefectActsService>();

                    if (defectActsService.RemoveDefectActById(((DefectActsDTO)defectActsBS.Current).Id))
                    {
                        int rowHandle = defectActsGridView.FocusedRowHandle - 1;
                        
                        defectActsGridView.BeginDataUpdate();

                        LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                        
                        defectActsGridView.EndDataUpdate();

                        defectActsGridView.FocusedRowHandle = (defectActsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void addDocumentItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defectActsBS.Count > 0)
                EditDefectActReplie(Utils.Operation.Add, new DefectActRepliesDTO() { DefectActId = ((DefectActsDTO)defectActsBS.Current).Id });
        }

        private void editDocumentItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defectActRepliesBS.Count > 0)
                EditDefectActReplie(Utils.Operation.Update, (DefectActRepliesDTO)defectActRepliesBS.Current);

        }

        private void deleteDocumentItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (defectActRepliesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (this.defectActsService.RemoveDefectActReplieById(((DefectActRepliesDTO)defectActRepliesBS.Current).Id))
                    {
                        int rowHandle = defectActRepliesGridView.FocusedRowHandle - 1;

                        defectActRepliesGridView.BeginDataUpdate();

                        LoadRepliesData(((DefectActsDTO)defectActsBS.Current).Id);

                        defectActRepliesGridView.EndDataUpdate();

                        defectActRepliesGridView.FocusedRowHandle = (defectActRepliesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void showItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
        }

        private void repositoryItemPictureEdit2_DoubleClick(object sender, EventArgs e)
        {
            if (((DefectActRepliesDTO)defectActRepliesBS.Current).ScanPersence == 1)
            {
                string fileName = ((DefectActRepliesDTO)defectActRepliesBS.Current).FileName;
                byte[] scan = ((DefectActRepliesDTO)defectActRepliesBS.Current).DocumentScan;
                string puth = Utils.HomePath + @"\Temp\";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void repositoryItemPictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            if (((DefectActsDTO)defectActsBS.Current).ScanPersence == 1)
            {
                string fileName = ((DefectActsDTO)defectActsBS.Current).FileName;
                byte[] scan = ((DefectActsDTO)defectActsBS.Current).ActScan;
                string puth = Utils.HomePath + @"\Temp\";

                System.IO.File.WriteAllBytes(puth + fileName, scan);

                System.Diagnostics.Process.Start(puth + fileName);
            }
        }

        private void toolTipController_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl is GridControl)
            {
                GridView view = ((GridControl)e.SelectedControl).GetViewAt(e.ControlMousePosition) as GridView;

                if (view == null) return;

                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == assemblyInfoCol)
                {
                    var relatedModel = view.GetRow(hi.RowHandle);
                    if (relatedModel != null)
                    {
                        MtsAssembliesInfoDTO infoItem = GetMtsAssemblyInfo(((DefectActsDTO)relatedModel).MtsAssemblyId);

                        StringBuilder makeToolMsg = new StringBuilder();
                        makeToolMsg.Append("<u>Найменування:</u> " + "<b>" + infoItem.Name + "</b>");
                        makeToolMsg.AppendLine();
                        makeToolMsg.Append("<u>Дата реєстрації:</u> " + "<b>" + infoItem.DateCreated.ToShortDateString() + "</b>");
                        makeToolMsg.AppendLine();
                        makeToolMsg.Append("<u>Розробник:</u> " + "<b>" + infoItem.DesignerName + "</b>");
                        makeToolMsg.AppendLine();
                        makeToolMsg.Append("<u>Замовник:</u> " + "<b>" + infoItem.ContractorName + "</b>");

                        string toolMsg = makeToolMsg.ToString();

                        ToolTipControlInfo infoTool = new ToolTipControlInfo(hi.Column, toolMsg, "Інформація по перейменуванню міста", ToolTipIconType.Information);

                        e.Info = infoTool;

                    }
                }
            }
        }

        private MtsAssembliesInfoDTO GetMtsAssemblyInfo(int id)
        {
            mtsSpecificationService = Program.kernel.Get<IMtsSpecificationsService>();

            return mtsSpecificationService.GetSingleMtsAssemblyInfo(id);
        }

        #endregion
    }
}