using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Windows.Forms;
using System.Drawing;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IReportService reportService;

        private BindingSource businessTripsBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;
        
        public BusinessTripsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            
            _userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            firstDateBusinessTripEdit.EditValue = firstDay;
            lastDateBusinessTripEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
        }

        #region Method's

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
                        
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            businessTripsBS.DataSource = businessTripsService.GetBusinessTripsJournal(beginDate, endDate);

          
            businessTripsGrid.DataSource = businessTripsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addBusinessTripBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBusinessTripBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBusinessTripBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addNameTamplateBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            printBusinessTripBtn.Enabled = (_userTasksDTO.AccessRightId == 2);

            adminGroupItem.Visible = (_userTasksDTO.UserRoleId == 1);
        }

        private void EditBusinessTrip(Utils.Operation operation, BusinessTripsDTO model)
        {
            using (BusinessTripsEditFm businessTripsEditFm = new BusinessTripsEditFm(operation, model))
            {
                if (businessTripsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BusinessTripsDTO return_Id = businessTripsEditFm.Return();
                    businessTripsGridView.BeginDataUpdate();
                    LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
                    businessTripsGridView.EndDataUpdate();
                    int rowHandle = businessTripsGridView.LocateByValue("BusinessTripsID", return_Id.ID);
                    businessTripsGridView.FocusedRowHandle = rowHandle;

                }
            }

        }

        private void DeleteBusinessTrips()
        {
            if (businessTripsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити заявку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                    int rowHandle = businessTripsGridView.FocusedRowHandle - 1;
                    businessTripsGridView.BeginDataUpdate();
                    businessTripsService.BusinessTripDelete(((BusinessTripsJournalDTO)businessTripsBS.Current).BusinessTripsID);
                    LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
                    businessTripsGridView.EndDataUpdate();
                    businessTripsGridView.FocusedRowHandle = (businessTripsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
        
        #endregion

        #region Event's
        
        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
        }

        private void addBusinessTripBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditBusinessTrip(Utils.Operation.Add, new BusinessTripsDTO() { UserId = _userTasksDTO.UserId });
        }

        private void editBusinessTripBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (businessTripsBS.Count > 0)
            {
                BusinessTripsJournalDTO modelJournal = ((BusinessTripsJournalDTO)businessTripsBS.Current);
                BusinessTripsDTO newModel = new BusinessTripsDTO()
                {
                    ID = ((BusinessTripsJournalDTO)businessTripsBS.Current).BusinessTripsID,
                    Doc_Number = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Number,
                    Doc_Date = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Date,
                    DepartureID = ((BusinessTripsJournalDTO)businessTripsBS.Current).DepartureID,
                    EmployeesID = ((BusinessTripsJournalDTO)businessTripsBS.Current).EmployeesID,
                    CityID = ((BusinessTripsJournalDTO)businessTripsBS.Current).CityID,
                    ContractorsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).ContractorsID,
                    AgreementsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).AgreementsID,
                    PurposeID = ((BusinessTripsJournalDTO)businessTripsBS.Current).PurposeID,
                    StartDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).StartDate,
                    EndDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).EndDate,
                    AmountDays = ((BusinessTripsJournalDTO)businessTripsBS.Current).AmountDays,
                    UserId = _userTasksDTO.UserId
                };

                EditBusinessTrip(Utils.Operation.Update, newModel);
            }
        }

        private void deleteBusinessTripBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((BusinessTripsJournalDTO)businessTripsBS.Current).DecreeId != null)
            {
                MessageBox.Show("Посвідчення включено до наказу. Видаліть спочатку посвідчення із наказу.", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (((BusinessTripsJournalDTO)businessTripsBS.Current).PrepaymentStatus == 1 || ((BusinessTripsJournalDTO)businessTripsBS.Current).PaymentStatus == 1)
            {
                MessageBox.Show("По даному посвідченню видані кошти. Операцію відмінено.", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                DeleteBusinessTrips();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBusinessTripBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
        }

        private void businessTripsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            BusinessTripsJournalDTO item = (BusinessTripsJournalDTO)businessTripsBS[e.ListSourceRowIndex];

            if (e.Column == decreeStatusCol && e.IsGetData)
            {
                if (item.DecreeId != null)
                    e.Value = (item.DecreeProlongStatus == 0 && item.DecreeAvoidanceStatus == 0)
                        ? imageCollection.Images[1]
                        : (item.DecreeProlongStatus == 1)
                            ? imageCollection.Images[2]
                            : imageCollection.Images[3];
                else
                    e.Value = imageCollection.Images[0];
            }

            if (e.Column == paymentStatusCol && e.IsGetData)
            {
                if (item.PaymentStatus == 1 || item.PrepaymentStatus == 1)
                    e.Value = imageCollection.Images[4];
            }
        }

        private void businessTripsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "decreeNumberCol")
            {
                var cellValue = businessTripsGridView.GetRowCellValue(e.RowHandle, decreeNumberCol);

                if (cellValue == null)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "decreeDateCol")
            {
                var cellValue = businessTripsGridView.GetRowCellValue(e.RowHandle, decreeDateCol);

                if (cellValue == null)
                {
                    e.Appearance.BackColor = Color.Tomato;
                    e.Appearance.BackColor2 = Color.LightSalmon;
                }
            }
        }

        private void addNameTamplateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (businessTripsBS.Count > 0)
            {
                BusinessTripsJournalDTO modelJournal = ((BusinessTripsJournalDTO)businessTripsBS.Current);
                BusinessTripsDTO newModel = new BusinessTripsDTO()
                {
                    ID = ((BusinessTripsJournalDTO)businessTripsBS.Current).BusinessTripsID,
                    Doc_Number = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Number,
                    Doc_Date = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Date,
                    DepartureID = ((BusinessTripsJournalDTO)businessTripsBS.Current).DepartureID,
                    EmployeesID = null,
                    CityID = ((BusinessTripsJournalDTO)businessTripsBS.Current).CityID,
                    ContractorsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).ContractorsID,
                    AgreementsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).AgreementsID,
                    PurposeID = ((BusinessTripsJournalDTO)businessTripsBS.Current).PurposeID,
                    StartDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).StartDate,
                    EndDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).EndDate,
                    AmountDays = ((BusinessTripsJournalDTO)businessTripsBS.Current).AmountDays
                };
                EditBusinessTrip(Utils.Operation.Add, newModel);
            }
        }

        private void printBusinessTripBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (businessTripsBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintBusinessTrip((BusinessTripsJournalDTO)businessTripsBS.Current);
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
                            e.Info = new ToolTipControlInfo(hi.Column, "Посвідчення не включено до наказу.");
                        else if (relatedImage == imageCollection.Images[1])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до основного наказу");
                        else if (relatedImage == imageCollection.Images[2])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до наказу на зміну терміну");
                        else if (relatedImage == imageCollection.Images[3])
                            e.Info = new ToolTipControlInfo(hi.Column, "Включено до наказу на скасування");
                    }
                }

                if (hi.HitTest == GridHitTest.RowCell && hi.Column != null && hi.Column == paymentStatusCol)
                {
                    Image relatedImage = (Image)view.GetRowCellValue(hi.RowHandle, hi.Column);
                    if (relatedImage != null)
                    {
                        if (relatedImage == imageCollection.Images[4])
                            e.Info = new ToolTipControlInfo(hi.Column, "Посвідчення містить грошові виплати");
                    }
                }
            }
        }
                
        private void BusinessTripsFm_FormClosed(object sender, FormClosedEventArgs e)
        {
            businessTripsService.Dispose();
            this.Dispose();
        }

        private void businessTripsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (businessTripsBS.Count > 0 && _userTasksDTO.AccessRightId == 2)
            {
                BusinessTripsJournalDTO modelJournal = ((BusinessTripsJournalDTO)businessTripsBS.Current);
                BusinessTripsDTO newModel = new BusinessTripsDTO()
                {
                    ID = ((BusinessTripsJournalDTO)businessTripsBS.Current).BusinessTripsID,
                    Doc_Number = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Number,
                    Doc_Date = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Date,
                    DepartureID = ((BusinessTripsJournalDTO)businessTripsBS.Current).DepartureID,
                    EmployeesID = ((BusinessTripsJournalDTO)businessTripsBS.Current).EmployeesID,
                    CityID = ((BusinessTripsJournalDTO)businessTripsBS.Current).CityID,
                    ContractorsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).ContractorsID,
                    AgreementsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).AgreementsID,
                    PurposeID = ((BusinessTripsJournalDTO)businessTripsBS.Current).PurposeID,
                    StartDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).StartDate,
                    EndDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).EndDate,
                    AmountDays = ((BusinessTripsJournalDTO)businessTripsBS.Current).AmountDays,
                    UserId = _userTasksDTO.UserId
                };

                EditBusinessTrip(Utils.Operation.Update, newModel);
            }
        }

        private void renameBusinessTrip_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (businessTripsBS.Count > 0)
            {
                BusinessTripsJournalDTO modelJournal = ((BusinessTripsJournalDTO)businessTripsBS.Current);
                BusinessTripsDTO newModel = new BusinessTripsDTO()
                {
                    ID = ((BusinessTripsJournalDTO)businessTripsBS.Current).BusinessTripsID,
                    Doc_Number = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Number,
                    Doc_Date = ((BusinessTripsJournalDTO)businessTripsBS.Current).Doc_Date,
                    DepartureID = ((BusinessTripsJournalDTO)businessTripsBS.Current).DepartureID,
                    EmployeesID = ((BusinessTripsJournalDTO)businessTripsBS.Current).EmployeesID,
                    CityID = ((BusinessTripsJournalDTO)businessTripsBS.Current).CityID,
                    ContractorsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).ContractorsID,
                    AgreementsID = ((BusinessTripsJournalDTO)businessTripsBS.Current).AgreementsID,
                    PurposeID = ((BusinessTripsJournalDTO)businessTripsBS.Current).PurposeID,
                    StartDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).StartDate,
                    EndDate = ((BusinessTripsJournalDTO)businessTripsBS.Current).EndDate,
                    AmountDays = ((BusinessTripsJournalDTO)businessTripsBS.Current).AmountDays,
                    UserId = _userTasksDTO.UserId
                };

                using (BusinessTripsRenameFm businessTripsRenameFm = new BusinessTripsRenameFm(newModel, modelJournal.ID))
                {
                    if (businessTripsRenameFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        int return_Id = businessTripsRenameFm.Return();

                        businessTripsGridView.BeginDataUpdate();
                        LoadData((DateTime)firstDateBusinessTripEdit.EditValue, (DateTime)lastDateBusinessTripEdit.EditValue);
                        businessTripsGridView.EndDataUpdate();

                        int rowHandle = businessTripsGridView.LocateByValue("BusinessTripsID", return_Id);
                        businessTripsGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        #endregion

       
    }
}