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
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsDecreeFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IReportService reportService;

        private BindingSource decreeTreeBS = new BindingSource();
        private BindingSource businessTripsBS = new BindingSource();

        private List<BusinessTripsJournalDTO> businessTripsJournalList = new List<BusinessTripsJournalDTO>();

        private UserTasksDTO _userTasksDTO;

        public BusinessTripsDecreeFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            beginDateEdit.EditValue = firstDay;
            endDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            DateTime firstReportDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime lastReportDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            beginReportDateEdit.EditValue = firstReportDay;
            endReportDateEdit.EditValue = lastReportDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            splashScreenManager.ShowWaitForm();

            LoadDecreeData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);

            splashScreenManager.CloseWaitForm();
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addDecreeBtn1.Enabled = (_userTasksDTO.AccessRightId == 2);
            editDecreeBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            prolongationDecreeBtn1.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteDecreeBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            showDecreeBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            avoidanceDecreeBtn1.Enabled = (_userTasksDTO.AccessRightId == 2);
            reportBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDecreeData(DateTime beginDate, DateTime endDate)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            decreeTreeBS.DataSource = businessTripsService.GetBusinessTripsDecreeByPeriod(beginDate, endDate);
            decreeTree.DataSource = decreeTreeBS;
            decreeTree.KeyFieldName = "ID";
            decreeTree.ParentFieldName = "ParentId";
            decreeTree.ExpandAll();

            if (decreeTreeBS.Count > 0)
                LoadBusinessTripsData(((BusinessTripsDecreeDTO)decreeTreeBS.Current).ID);
            else
                businessTripsGrid.DataSource = null;

            showDecreeBtn.Enabled = (_userTasksDTO.AccessRightId == 2 && decreeTreeBS.Count > 0);
        }

        private void LoadBusinessTripsData(int decreeId)
        {
            businessTripsGridView.BeginDataUpdate();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            businessTripsJournalList = businessTripsService.GetBusinessTripsByDecree(decreeId).ToList();
            businessTripsBS.DataSource = businessTripsJournalList;
            businessTripsGrid.DataSource = businessTripsBS;

            businessTripsGridView.EndDataUpdate();

        }

        private void EditBusinessTripDecree(Utils.Operation operation, BusinessTripsDecreeDTO model, int decreeType, List<BusinessTripsJournalDTO> tripList)
        {
            using (BusinessTripsDecreeEditFm businessTripsDecreeEditFm = new BusinessTripsDecreeEditFm(operation, model, decreeType, tripList))
            {
                if (businessTripsDecreeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = businessTripsDecreeEditFm.Return();

                    decreeTree.BeginUpdate();

                    LoadDecreeData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);

                    decreeTree.EndUpdate();

                    decreeTree.SetFocusedNode(decreeTree.FindNodeByKeyID(return_Id));

                }
            }
        }

        #endregion

        #region Event's

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDecreeData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void updateDecreeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadDecreeData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void decreeTree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (decreeTreeBS.Count > 0)
            {
                LoadBusinessTripsData(((BusinessTripsDecreeDTO)decreeTreeBS.Current).ID);

                if (e.Node.Level > 0)
                {
                    addDecreeBtn1.Enabled = false;
                    prolongationDecreeBtn1.Enabled = false;
                    avoidanceDecreeBtn1.Enabled = false;
                }
                else
                {
                    addDecreeBtn1.Enabled = true;
                    prolongationDecreeBtn1.Enabled = true;
                    avoidanceDecreeBtn1.Enabled = true;
                }
            }
        }

        private void addDecreeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditBusinessTripDecree(Utils.Operation.Add, new BusinessTripsDecreeDTO(), 1, new List<BusinessTripsJournalDTO>());
        }

        private void editDecreeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (decreeTreeBS.Count > 0)
            {
                EditBusinessTripDecree(Utils.Operation.Update,
                    (BusinessTripsDecreeDTO)decreeTreeBS.Current,
                    ((BusinessTripsDecreeDTO)decreeTreeBS.Current).DecreeType,
                    (List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
            }
        }

        private void deleteDecreeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (decreeTreeBS.Count > 0)
            {
                bool haveNonDeleteRecord = ((List<BusinessTripsJournalDTO>)businessTripsBS.DataSource).Any(t => t.DecreeProlongStatus == 1 ||
                    t.DecreeAvoidanceStatus == 1 ||
                    t.PaymentStatus == 1 ||
                    t.PrepaymentStatus == 1);

                if (decreeTree.FocusedNode.Level == 0 && haveNonDeleteRecord)
                {
                    MessageBox.Show("До наказу входять посвідчення, які мають статус змінених, скасованих, або містять грошові виплати.", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Видалити наказ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    businessTripsService = Program.kernel.Get<IBusinessTripsService>();

                    decreeTree.BeginUpdate();

                    if (businessTripsService.BusinessTripDecreeDelete(((BusinessTripsDecreeDTO)decreeTreeBS.Current).ID))
                    {
                        LoadDecreeData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                    }

                    decreeTree.EndUpdate();
                }
            }
        }

        private void showDecreeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (businessTripsBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                switch (((BusinessTripsDecreeDTO)decreeTreeBS.Current).DecreeType)
                {
                    case 1:
                        reportService.PrintBusinessTripDecree((List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
                        break;

                    case 2:
                        reportService.PrintBusinessTripDecreeProlong((List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
                        break;

                    case 3:
                        reportService.PrintBusinessTripDecreeCancel((List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
                        break;

                    default:
                        MessageBox.Show("Не вірні параметри виклику!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }
            }
        }

        private void decreeTree_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            var item = (BusinessTripsDecreeDTO)decreeTree.GetDataRecordByNode(e.Node);

            if (item == null)
                return;

            e.Node.StateImageIndex = (item.DecreeType == 1) ? 0 :
                                    (item.DecreeType == 2) ? 1 : 2;
        }

        private void decreeTree_DoubleClick(object sender, System.EventArgs e)
        {
            if (_userTasksDTO.AccessRightId == 2)
                return;

            if (decreeTreeBS.Count > 0)
            {
                EditBusinessTripDecree(Utils.Operation.Update,
                    (BusinessTripsDecreeDTO)decreeTreeBS.Current,
                    ((BusinessTripsDecreeDTO)decreeTreeBS.Current).DecreeType,
                    (List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
            }
        }

        private void prolongationDecreeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (decreeTreeBS.Count > 0)
                EditBusinessTripDecree(Utils.Operation.Add, (BusinessTripsDecreeDTO)decreeTreeBS.Current, 2, (List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
        }

        private void avoidanceDecreeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (decreeTreeBS.Count > 0)
            {
                EditBusinessTripDecree(Utils.Operation.Add, (BusinessTripsDecreeDTO)decreeTreeBS.Current, 3, (List<BusinessTripsJournalDTO>)businessTripsBS.DataSource);
            }
        }

        private void reportBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            if (!reportService.GetBSTReportByDepartments((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
                MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void businessTripsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            BusinessTripsJournalDTO item = (BusinessTripsJournalDTO)businessTripsBS[e.ListSourceRowIndex];

            if (e.Column == decreeStatusCol && e.IsGetData)
            {
                if (item.DecreeProlongStatus == 1)
                    e.Value = imageCollection.Images[1];

                if (item.DecreeAvoidanceStatus == 1)
                    e.Value = imageCollection.Images[2];
            }

            if (e.Column == paymentStatusCol && e.IsGetData)
            {
                if (item.PaymentStatus == 1 || item.PrepaymentStatus == 1)
                    e.Value = imageCollection.Images[3];
            }
        }

        private void toolTipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl is GridControl)
            {
                GridView view = ((GridControl)e.SelectedControl).GetViewAt(e.ControlMousePosition) as GridView;

                if (view == null) return;

                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == decreeStatusCol)
                {
                    Image relatedImage = (Image)view.GetRowCellValue(hi.RowHandle, hi.Column);
                    if (relatedImage != null)
                    {
                        if (relatedImage == imageCollection.Images[0])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до основного наказу");
                        else if (relatedImage == imageCollection.Images[1])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до наказу на зміну терміну");
                        else if (relatedImage == imageCollection.Images[2])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до наказу на скасування");
                    }
                }

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == paymentStatusCol)
                {
                    Image relatedImage = (Image)view.GetRowCellValue(hi.RowHandle, hi.Column);
                    if (relatedImage != null)
                    {
                        if (relatedImage == imageCollection.Images[3])
                            e.Info = new ToolTipControlInfo(hi.Column, "Посвідчення містить грошові виплати");
                    }
                }
            }
        }

        #endregion
    }


}
