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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Delivery
{
    public partial class DeliveryOrdersFm : DevExpress.XtraEditors.XtraForm
    {
        private IDeliveryService deliveryService;
        private IStoreHouseService storeHouseService;
        private BindingSource ordersBS = new BindingSource();
        private UserTasksDTO userTasksDTO;
        private List<DeliveryOrdersDTO> allItemsList = new List<DeliveryOrdersDTO>(); 
        private List<DeliveryOrdersDTO> selectedItemsList = new List<DeliveryOrdersDTO>(); 

        public DeliveryOrdersFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            ribbonControl.DrawGroupsBorder = false;
            this.userTasksDTO = userTasksDTO;
            DateTime begin_Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // год - месяц - день
            DateTime end_Date = DateTime.Today;
            beginDateEdit.EditValue = begin_Date;
            endDateEdit.EditValue = end_Date;

            LoadData(begin_Date, end_Date);
            AuthorizatedUserAccess();
        }

       
        #region Method's

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            deliveryService = Program.kernel.Get<IDeliveryService>();
            var orders = deliveryService.GetDeliveryOrders(beginDate, endDate);
            ordersBS.DataSource = orders;
            deliveryOrdersGrid.DataSource = ordersBS;

            repositoryItemLookUpEdit.DataSource = ordersBS;
            repositoryItemLookUpEdit.ValueMember = "RecId";
            repositoryItemLookUpEdit.DisplayMember = "ReceiptNum";
            repositoryItemLookUpEdit.Properties.NullText = "";



            splashScreenManager.CloseWaitForm();
            deliveryOrdersGridView.ExpandAllGroups();
            deliveryOrdersGrid.Focus();
        }

        public void AuthorizatedUserAccess()
        {

            unitPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            totalPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            currencyCodeCol.Visible = (userTasksDTO.PriceAttribute == 1);
            gridBand6.Visible = (userTasksDTO.PriceAttribute == 1);

            addCustomerOrdersBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editСustomerOrdersBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteOrdersFromReceiptBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            receiptNumberEdit.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void EditCustomerOrders(Utils.Operation operation, List<DeliveryOrdersDTO> deliveryOrdersList)
        {
            using (DeliveryOrdersEditFm deliveryOrdersEditFm = new DeliveryOrdersEditFm(operation, deliveryOrdersList))
            {
                if (deliveryOrdersEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    List<DeliveryOrdersDTO> returnItems = deliveryOrdersEditFm.Return();

                    deliveryOrdersGridView.BeginUpdate();

                    LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);

                    int rowHandle = deliveryOrdersGridView.LocateByValue("Id", returnItems[0].ReceiptID);
                    deliveryOrdersGridView.FocusedRowHandle = rowHandle;

                    deliveryOrdersGridView.EndUpdate();

                }
            }
        }

        #endregion

        #region Event's

        private void showOrdersForDate_Click(object sender, EventArgs e)
        {
            DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
            DateTime end_Date = (DateTime)endDateEdit.EditValue;
            LoadData(begin_Date, end_Date);
        }

        private void deliveryOrdersGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            DeliveryOrdersDTO Row = (DeliveryOrdersDTO)View.GetRow(e.RowHandle);

            if (Row == null) return;

            if (e.Column.Name == "orderDateCol" || e.Column.Name == "invoiceDateCol")
            {
                if (e.CellValue == null) return;

                if (Row.OrderDate != Row.InvoiceDate)
                {
                    e.Appearance.BackColor = Color.Yellow;
                    e.Appearance.BackColor2 = Color.LightYellow;
                }
            }
        }

        private void xlsBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010)(.xlsx)|*.xlsx|Excel (2003) (.xls)|*.xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string exportFilePath = saveDialog.FileName;
                    deliveryOrdersGridView.OptionsPrint.PrintBandHeader = false;

                    var optionXls = new XlsExportOptions();
                    optionXls.ExportMode = XlsExportMode.SingleFilePageByPage;
                    optionXls.SheetName = "Надходження матеріалів";
                    optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    var optionXlsx = new XlsxExportOptions();
                    optionXlsx.ExportMode = XlsxExportMode.SingleFilePageByPage;
                    optionXlsx.SheetName = "Надходження матеріалів";
                    optionXlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            deliveryOrdersGrid.ExportToXls(exportFilePath, optionXls);
                            break;
                        case ".xlsx":
                            deliveryOrdersGrid.ExportToXlsx(exportFilePath, optionXlsx);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void searchBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
            DateTime end_Date = (DateTime)endDateEdit.EditValue;
            LoadData(begin_Date, end_Date);
        }

        private void printBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010)(.xlsx)|*.xlsx|Excel (2003) (.xls)|*.xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string exportFilePath = saveDialog.FileName;
                    deliveryOrdersGridView.OptionsPrint.PrintBandHeader = true;

                    var optionXls = new XlsExportOptions();
                    optionXls.ExportMode = XlsExportMode.SingleFilePageByPage;
                    optionXls.SheetName = "Надходження матеріалів";
                    optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    var optionXlsx = new XlsxExportOptions();
                    optionXlsx.ExportMode = XlsxExportMode.SingleFilePageByPage;
                    optionXlsx.SheetName = "Надходження матеріалів";
                    optionXlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            deliveryOrdersGrid.ExportToXls(exportFilePath, optionXls);
                            break;
                        case ".xlsx":
                            deliveryOrdersGrid.ExportToXlsx(exportFilePath, optionXlsx);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deliveryOrdersGridView_CellMerge(object sender, CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            DeliveryOrdersDTO model1 = (DeliveryOrdersDTO)view.GetRow(e.RowHandle1);
            DeliveryOrdersDTO model2 = (DeliveryOrdersDTO)view.GetRow(e.RowHandle2);

            if (e.Column.FieldName != "OrderNumber" && e.Column.FieldName != "Drawing")
            {
                if (model2 != null)//-----------
                {
                    e.Merge = (model1.ReceiptID == model2.ReceiptID);
                    e.Handled = true;
                }
            }
        }

        private void beginDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginDateEdit.EditValue != null && endDateEdit.EditValue != null)
            {
                DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
                DateTime end_Date = (DateTime)endDateEdit.EditValue;
                LoadData(begin_Date, end_Date);
            }


        }

        private void endDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginDateEdit.EditValue != null && endDateEdit.EditValue != null)
            {
                DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
                DateTime end_Date = (DateTime)endDateEdit.EditValue;
                LoadData(begin_Date, end_Date);
            }
        }

        private void addCustomerOrdersBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deliveryOrdersGridView.PostEditor();
            deliveryOrdersGridView.BeginDataUpdate();

            var checkItems = ((List<DeliveryOrdersDTO>)ordersBS.List).Where(t => t.Selected);
            if (checkItems == null)
            {
                MessageBox.Show("Не обрано надходження. ", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deliveryOrdersGridView.EndDataUpdate();
                return;
            }
            EditCustomerOrders(Utils.Operation.Add, checkItems.ToList());

            deliveryOrdersGridView.EndDataUpdate();

        }

        private void editСustomerOrdersBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deliveryOrdersGridView.PostEditor();
            deliveryOrdersGridView.BeginDataUpdate();

            var checkItems = ((DeliveryOrdersDTO)ordersBS.Current);
            selectedItemsList.Clear();
            selectedItemsList.Add(checkItems);
            EditCustomerOrders(Utils.Operation.Update, selectedItemsList);

            deliveryOrdersGridView.EndDataUpdate();
        }

        private void deliveryOrdersGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView currentView = (sender as GridView);
            string bbb = (string)currentView.GetRowCellValue(currentView.FocusedRowHandle, currentView.Columns["OrderNumber"]);

            if ((string)currentView.GetRowCellValue(currentView.FocusedRowHandle, currentView.Columns["OrderNumber"]) != null)
                e.Cancel = true;
            else
                e.Cancel = false;

        }

        #endregion

        private void deliveryOrdersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            receiptNumberEdit.EditValue = ((DeliveryOrdersDTO)ordersBS.Current).RecId;
        }

        private void deleteOrdersFromReceiptBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            deliveryService = Program.kernel.Get<IDeliveryService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            List<ReceiptDetailsDTO> receiptDetailsDeleteList = new List<ReceiptDetailsDTO>();

            int m = ((DeliveryOrdersDTO)ordersBS.Current).OrderId;

            var receiptByOrderId = storeHouseService.GetReceiptsByOrderId(((DeliveryOrdersDTO)ordersBS.Current).OrderId).ToList();

            foreach (var item in receiptByOrderId)
            {
                var deleteReceiptDetails = deliveryService.GetReceiptDetails().Where(bdsm => bdsm.ReceiptId == item.ID).ToList();
                if (deleteReceiptDetails.Count() > 0)
                    receiptDetailsDeleteList.AddRange(deleteReceiptDetails);
            }

            if (receiptDetailsDeleteList.Count() > 0)
            {
                foreach (var item in receiptDetailsDeleteList)
                {
                    deliveryService.ReceiptDetailsDelete(item.Id);
                }

                LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            }
            else
            {
                MessageBox.Show("У надходження відсутня привязка до заказу ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}