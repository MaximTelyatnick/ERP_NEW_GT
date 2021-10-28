using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.Collections;

using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.Services;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using System;
using ERP_NEW.GUI;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.GUI.Marketing;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_NEW.BLL.Marketing
{
    public partial class PackingListsFm : DevExpress.XtraEditors.XtraForm
    {
        private IPackingListsService packingListsService;
        private IReportService reportService;
        private IStoreHouseService storeHouseService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource packingListsBS = new BindingSource();
        private BindingSource packingListMaterialsBS = new BindingSource();
        private BindingSource customerOrdersSpecBS = new BindingSource();
        private BindingSource customerOrdersAssemblyBS = new BindingSource();
        private BindingSource expenditureMaterialBS = new BindingSource();

        private UserTasksDTO userTasksDTO;


        public PackingListsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            showCustomerOrderInfoCheck.CheckedChanged -= showCustomerOrderInfoCheck_CheckedChanged;

            showCustomerOrderInfoCheck.Checked = ERP_NEW.GUI.Properties.Settings.Default.PackingListCustonerOrderInfo;
            if (showCustomerOrderInfoCheck.Checked)
                splitControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;
            else
                splitControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            

            showCustomerOrderInfoCheck.CheckedChanged += showCustomerOrderInfoCheck_CheckedChanged;


            beginDateEditItem.EditValue = new DateTime(DateTime.Now.Year, 1, 1).AddYears(-1); // год - месяц - день
            endDateEditItem.EditValue = DateTime.Today;

            AuthorizatedUserAccess();
            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
            
        }
        #region Metod's                                                

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            packingListsService = Program.kernel.Get<IPackingListsService>();

            var source = packingListsService.GetPackingJournal(beginDate, endDate);

            packingListsBS.DataSource = source;
            packingListsGrid.DataSource = packingListsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void LoadAdditionalData()
        {
            if (packingListsBS.Count > 0 && ((PackingListsJournalDTO)packingListsBS.Current).CustomerOrderId != null)
            {
                LoadCustomerOrderSpecificationsData((int)((PackingListsJournalDTO)packingListsBS.Current).CustomerOrderId);
                LoadCustomerOrderMaterialExpenditure((int)((PackingListsJournalDTO)packingListsBS.Current).CustomerOrderId);
            }
            else
            {
                specificationGrid.DataSource = null;
                expendituresGrid.DataSource = null;
            }
        }

        public void AuthorizatedUserAccess()
        {
            addPackageBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editPackageBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deletePackageBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void EditPackingList(Utils.Operation operation, PackingListsDTO model)
        {
            using (PackingListEditFm packingListEditFm = new PackingListEditFm(operation, model))
            {
                if (packingListEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PackingListsDTO return_packingId = packingListEditFm.Return();

                    packingListsGridView.BeginUpdate();

                    LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                    
                    int rowHandle = packingListsGridView.LocateByValue("Id", return_packingId.Id);
                    packingListsGridView.FocusedRowHandle = rowHandle;

                    packingListsGridView.EndUpdate();

                }
            }
        }

        private void DeletePackingList()
        {
            if (MessageBox.Show("Видалити пакувальний лист під номером " + ((PackingListsJournalDTO)packingListsBS.Current).PackingNumber +"?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (packingListsService.PackingListDeleteById(((PackingListsJournalDTO)packingListsBS.Current).PackingListId))
                {
                    packingListsGridView.BeginUpdate();
                    LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                    packingListsGridView.EndUpdate();
                    packingListsGrid.Refresh();
                }
            }
        }
        #endregion

        #region Event's                                                

        private void addOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditPackingList(Utils.Operation.Add, new PackingListsDTO());
        }

        private void createTmplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (packingListsBS.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();
                reportService.CreatePackingListTemplate((PackingListsJournalDTO)packingListsBS.Current);
            }
        }

        private void editOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (packingListsBS.Count > 0)
            {
                PackingListsJournalDTO modelJournal = ((PackingListsJournalDTO)packingListsBS.Current);
                PackingListsDTO newModel = new PackingListsDTO()
                {
                    Id = modelJournal.PackingListId,
                    Description = modelJournal.Description,
                    OtkPersonId = modelJournal.OtkPersonId,
                    ResponsiblePersonId = modelJournal.ResponsiblePersonId,
                    PackingDate = modelJournal.PackingDate,
                    PackingNumber = modelJournal.PackingNumber,
                    PackingListMaterialsId = modelJournal.PackingListMaterialsId,
                    PackingListComplectId = modelJournal.PackingListComplectId,
                    DescriptionProject = modelJournal.DescriptionProject,
                    CityId = modelJournal.CityId,
                    ContractorId = modelJournal.ContractorId
                };

                EditPackingList(Utils.Operation.Update, newModel);
            }
        }

        private void deleteOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(packingListsBS.Count > 0)
                DeletePackingList();
        }

        private void showItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
        }

        private void packingListsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            PackingListsJournalDTO item = (PackingListsJournalDTO)packingListsBS[e.ListSourceRowIndex];

            if (e.Column == transportListScanCol)
            {
                if (item.ScanComplStatus != null)
                {
                    if (item.ScanComplStatus == 1)
                        e.Value = columnCollection.Images[0];
                    else
                        e.Value = columnCollection.Images[1];
                }
            }

            if (e.Column == scanStatusCol)
            {
                if (item.ScanStatus != null)
                {
                    if (item.ScanStatus == 1)
                        e.Value = columnCollection.Images[0];
                    else
                        e.Value = columnCollection.Images[1];
                }
            }           
        }

        private void repositoryItemPictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(((PackingListsJournalDTO)packingListsBS.Current).ScanStatus))
            {
                PackingListMaterialsDTO model = packingListsService.GetPackingListMaterialsById(((PackingListsJournalDTO)packingListsBS.Current).PackingListMaterialsId);

                string path = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(path + model.FileName, model.Scan);

                System.Diagnostics.Process.Start(path + model.FileName);
            }
        }


        private void packingListsGridView_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            PackingListsJournalDTO model1 = (PackingListsJournalDTO)view.GetRow(e.RowHandle1);
            PackingListsJournalDTO model2 = (PackingListsJournalDTO)view.GetRow(e.RowHandle2);

            if (e.Column.FieldName != "OrderNumber" && e.Column.FieldName != "OrderDate" && e.Column.FieldName != "CityName" && e.Column.FieldName != "CountryName"/* && e.Column.FieldName != "scanStatusCol" && e.Column.FieldName != "scanStatusCol" && e.Column.FieldName != "Description"*/)
            {
                e.Merge = (model1.PackingNumber == model2.PackingNumber);
                e.Handled = true;
            }
        }

        private void packingListsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(((PackingListsJournalDTO)packingListsBS.Current).ScanStatus))
            {
                splashScreenManager.ShowWaitForm();

                PackingListMaterialsDTO model = packingListsService.GetPackingListMaterialsById(((PackingListsJournalDTO)packingListsBS.Current).PackingListMaterialsId);
                string path = Utils.HomePath + @"\Temp";
                System.IO.File.WriteAllBytes(path + model.FileName, model.Scan);
                System.Diagnostics.Process.Start(path + model.FileName);

                splashScreenManager.CloseWaitForm();
            }
        }

        private void showCustomerOrderInfoCheck_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (showCustomerOrderInfoCheck.Checked)
            {
                ERP_NEW.GUI.Properties.Settings.Default.PackingListCustonerOrderInfo = true;
                splitControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both;

                LoadAdditionalData();
            }
            else
            {
                ERP_NEW.GUI.Properties.Settings.Default.PackingListCustonerOrderInfo = false;
                splitControl.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1;
            }

            ERP_NEW.GUI.Properties.Settings.Default.Save();
        }

        #endregion

        private void packingListsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (showCustomerOrderInfoCheck.Checked)
            {
                LoadAdditionalData();
            }
        }

        private void LoadCustomerOrderSpecificationsData(int orderId)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrdersSpecBS.DataSource = customerOrdersService.GetCustomerOrderSpecificationsByOrderId(orderId);
            specificationGrid.DataSource = customerOrdersSpecBS;

            if (customerOrdersSpecBS.Count > 0)
                LoadCustomerOrderAssembliesData(((CustomerOrderSpecificationsDTO)customerOrdersSpecBS.Current).Id);
            else
                assembliesGrid.DataSource = null;
        }

        private void LoadCustomerOrderAssembliesData(int specId)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrdersAssemblyBS.DataSource = customerOrdersService.GetCustomerOrderAssembliesBySpecId(specId);
            assembliesGrid.DataSource = customerOrdersAssemblyBS;
        }


        private void LoadCustomerOrderMaterialExpenditure(int customerOrderId)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            expenditureMaterialBS.DataSource = storeHouseService.GetExpenditureByCustomerOrder(customerOrderId);
            expendituresGrid.DataSource = expenditureMaterialBS;
        }
    }
}