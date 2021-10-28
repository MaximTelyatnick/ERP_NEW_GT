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
using ERP_NEW.BLL.DTO.ModelsDTO;
using System.Threading;
using System.Globalization;
using DevExpress.XtraEditors.Controls;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseOrdersFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;
        private IPeriodService periodService;

        private BindingSource ordersBS = new BindingSource();
        private BindingSource receiptsBS = new BindingSource();

        private List<ReceiptOrdersDTO> orderJournalList = new List<ReceiptOrdersDTO>();
        private List<ReceiptJournalDTO> receiptsJournalList = new List<ReceiptJournalDTO>();

        private UserTasksDTO userTasksDTO;
        private DateTime beginDate;
        private DateTime endDate;

        private LoggerInfo loger = new LoggerInfo();

        private bool PeriodIsOpened;

        public StoreHouseOrdersFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            this.beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            LoadOrdersDataByPeriod(beginDate, endDate);

            splitContainerControl.SplitterPosition = (this.Height - ribbonControl1.Height);

            AuthorizatedUserAccess();

        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            addRequirementBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            insertRequirementBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);

        }

        private void LoadOrdersDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            periodService = Program.kernel.Get<IPeriodService>();
            orderJournalList = storeHouseService.GetOrdersByPeriod(beginDate, endDate).ToList();
            ordersBS.DataSource = orderJournalList;          
            //storeHouseService.GetOrdersByPeriod(beginDate, endDate);   
            ordersGrid.DataSource = ordersBS;

            if (ordersBS.Count > 0)
                LoadReceiptsDataByOrderId(((ReceiptOrdersDTO)ordersBS.Current).Id);

            //ShowPeriod();

            SetPeriodBtnImage();



            splashScreenManager.CloseWaitForm();
        }

        private void SetPeriodBtnImage()
        {
            if (periodService.CheckPeriodAccess(beginDate) && (userTasksDTO.AccessRightId == 2))
            {
                periodBtn.Glyph = imageCollection.Images[1];
                periodBtn.LargeGlyph = imageCollection.Images[1];
                periodBtn.Caption = "Закрити період";
                addBtn.Enabled = true;
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            else
            {
                periodBtn.Glyph = imageCollection.Images[0];
                periodBtn.LargeGlyph = imageCollection.Images[0];
                periodBtn.Caption = "Відкрити період";
                addBtn.Enabled = false;
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        /// <summary>
        ///проверяет закрытие периода при инициализации
        /// </summary>
        /// 
        private void ShowPeriod()
        {
            PeriodsDTO model = new PeriodsDTO();
            model = periodService.GetAllPeriods().FirstOrDefault(bdsm => bdsm.Month == beginDate.Month && bdsm.Year == beginDate.Year);
            if (model != null)
            {
                bool State = (bool)((PeriodsDTO)periodService.GetAllPeriods().FirstOrDefault(bdsm => bdsm.Month == beginDate.Month && bdsm.Year == beginDate.Year)).State;
                SetPeriodOpened(((State == true) || (State == null)) ? false : true);
            }
            else
            {
                if (MessageBox.Show("Такого періоду не існує. Створити період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    periodService.PeriodsCreate(new PeriodsDTO()
                    {
                        Month = beginDate.Date.Month,
                        Year = beginDate.Date.Year,
                        State = true

                    });
                }
                else
                {
                    SetPeriodOpened(false);
                }
            }  
        }

        /// <summary>
        /// изменение состояния кнопок при Закрытии периода
        /// </summary>

        private void SetPeriodOpened(bool checkState)
        {
            PeriodIsOpened = checkState;

            addBtn.Enabled = !PeriodIsOpened;
            editBtn.Enabled = !PeriodIsOpened;
            deleteBtn.Enabled = !PeriodIsOpened;
        }

        /// <summary>
        /// загрузка материалов по выбраному ордеру
        /// </summary>

        private void LoadReceiptsDataByOrderId(int id)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            receiptsJournalList = storeHouseService.GetReceiptByOrderIdProc(id).ToList();
            receiptsBS.DataSource = receiptsJournalList;
            receiptsGrid.DataSource = receiptsBS;
        }

        /// <summary>
        /// разделение прав пользоватея
        /// </summary>

       

        private void EditOrder(Utils.Operation operation, OrdersDTO model, List<ReceiptsDTO> source, UserTasksDTO userTaskDTO)
        {
            using (StoreHouseOrderEditFm storeHouseOrderEditFm = new StoreHouseOrderEditFm(operation, model, source, userTaskDTO))
            {
                if (storeHouseOrderEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    OrdersDTO returnItem = storeHouseOrderEditFm.Return();
                    ordersGridView.BeginDataUpdate();
                    LoadOrdersDataByPeriod(beginDate, endDate);
                    ordersGridView.EndDataUpdate();
                    int rowHandle = ordersGridView.LocateByValue("Id", returnItem.ID);
                    ordersGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void EditInvoiceRequirement(Utils.Operation operation, InvoiceRequirementOrdersDTO model, List<InvoiceRequirementMaterialsInfoDTO> invoiceRequirementMaterialsList)
        {
            switch (operation)
            {
                case Utils.Operation.Add:
                    using (InvoiceRequirementEditFm invoiceRequirementEditFm = new InvoiceRequirementEditFm(operation,Utils.InvoiceType.Storehouses,userTasksDTO, model, invoiceRequirementMaterialsList))
                    {
                        if (invoiceRequirementEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            InvoiceRequirementOrdersDTO invoiceRequirementOrdersDTO = invoiceRequirementEditFm.Return();
                            ordersGridView.BeginDataUpdate();
                            LoadOrdersDataByPeriod(beginDate, endDate);
                            ordersGridView.EndDataUpdate();
                            MessageBox.Show("Вимогу створено під номером " + invoiceRequirementOrdersDTO.Number, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                case Utils.Operation.Update:
                    using (InvoiceRequirementFm invoiceRequirementFm = new InvoiceRequirementFm(userTasksDTO,Utils.InvoiceType.Storehouses, true, invoiceRequirementMaterialsList))
                    {
                        if (invoiceRequirementFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            InvoiceRequirementOrdersDTO invoiceRequirementOrdersDTO = invoiceRequirementFm.Return();
                            ordersGridView.BeginDataUpdate();
                            LoadOrdersDataByPeriod(beginDate, endDate);
                            ordersGridView.EndDataUpdate();
                            MessageBox.Show("Доповнено вимогу під номером " + invoiceRequirementOrdersDTO.Number, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region Event's

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
            LoadOrdersDataByPeriod(beginDate, endDate);
        }

        private void ordersGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && (e.Column.Name == "orderDateCol" || e.Column.Name == "invoiceDateCol"))
            {
                ReceiptOrdersDTO item = (ReceiptOrdersDTO)ordersGridView.GetRow(e.RowHandle);

                if (item.OrderDate != item.InvoiceDate)
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
            }
        }

        private void ordersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (ordersBS.Count > 0)
                LoadReceiptsDataByOrderId(((ReceiptOrdersDTO)ordersBS.Current).Id);
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadOrdersDataByPeriod(beginDate, endDate);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOrder(Utils.Operation.Add, new OrdersDTO(), new List<ReceiptsDTO>(), userTasksDTO);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<ReceiptsDTO> receiptList = new List<ReceiptsDTO>();

            foreach (var item in receiptsJournalList)
            {
                receiptList.Add(new ReceiptsDTO()
                {
                    ID = item.Id,
                    ORDER_ID = item.OrderId,
                    POS = item.Pos,
                    QUANTITY = item.Quantity,
                    UNIT_PRICE = item.UnitPrice,
                    TOTAL_PRICE = item.TotalPrice,
                    NOMENCLATURE_ID = item.NomenclatureId,
                    Storehouse_Id = item.StorehouseId,
                    TOTAL_CURRENCY = item.TotalCurrency,
                    UNIT_CURRENCY = item.UnitCurrency,
                    Nomenclature = item.Nomenclature,
                    NomenclatureName = item.NomenclatureName,
                    UnitId = item.UnitId,
                    UnitLocalName = item.UnitLocalName,
                    NomenclatureGroupId = item.NomenclatureGroupId,
                    StoreHouseName = item.StorehouseName,
                    BalanceAccountId = item.BalanceAccountId,
                    BalanceAccountNum = item.BalanceAccountNum
                });
            }

            if (ordersBS.Count > 0)
            {
                var orderItem = (ReceiptOrdersDTO)ordersBS.Current;

                OrdersDTO model = new OrdersDTO()
                {
                    ID = orderItem.Id,
                    DEBIT_ACCOUNT_ID = (short)orderItem.DebitAccountId,
                    INVOICE_DATE = orderItem.InvoiceDate,
                    INVOICE_NUM = orderItem.InvoiceNum,
                    ORDER_DATE = orderItem.OrderDate,
                    Otk_Id = (short?)orderItem.Otk_Id,
                    RECEIPT_NUM = orderItem.ReceiptNum,
                    Storekeeper_Id = (short?)orderItem.Storekeeper_Id,
                    SUPPLIER_ID = (short?)orderItem.Supplier_Id,
                    SUPPLIER_PROXY = orderItem.SupplierProxy,
                    TAX_INVOICE = (short?)orderItem.TaxInvoice,
                    TOTAL_WITH_VAT = orderItem.TotalWithVat,
                    TOTAL_PRICE = orderItem.TotalPrice,
                    TRANSPORT_INVOICE = (short?)orderItem.TransportInvoice,
                    VENDOR_ID = orderItem.VendorId,
                    Vat = orderItem.Vat,
                    OtkId = orderItem.OtkId,
                    StorekeeperId = orderItem.StorekeeperId,
                    SupplierId = orderItem.SupplierId,
                    UserId = orderItem.UserId
                };

                EditOrder(Utils.Operation.Update, model, receiptList, userTasksDTO);

            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ordersBS.Count != 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();


                    int rowHandle = ordersGridView.FocusedRowHandle - 1;

                    //ordersGridView.BeginDataUpdate();

                    if (!storeHouseService.OrderDelete(((ReceiptOrdersDTO)ordersBS.Current).Id))
                    {
                        MessageBox.Show("Надходження не може бути видалено, так як знаходиться у вимогах чи списанні!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rowHandle = ordersGridView.FocusedRowHandle;
                        LoadOrdersDataByPeriod(beginDate, endDate);
                        ordersGridView.FocusedRowHandle = (ordersGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                        //ordersGridView.EndDataUpdate();

                        return;
                    }

                    LoadOrdersDataByPeriod(beginDate, endDate);

                    //ordersGridView.EndDataUpdate();

                    ordersGridView.FocusedRowHandle = (ordersGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void addRequirementBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ordersGridView.PostEditor();

            List<InvoiceRequirementMaterialsInfoDTO> addMaterialsToInvoice = new List<InvoiceRequirementMaterialsInfoDTO>();

            var checkRequirementinvoice = orderJournalList.Where(bdsm => bdsm.IsSelect == true);

            foreach (var orderItem in checkRequirementinvoice)
            {
                List<ReceiptJournalDTO> receiptOrder = storeHouseService.GetReceiptByOrderIdProc(orderItem.Id).ToList();

                foreach (var receiptItem in receiptOrder)
                {
                    addMaterialsToInvoice.Add(new InvoiceRequirementMaterialsInfoDTO()
                    {
                        ReceiptId = receiptItem.Id,
                        ReceiptNum = receiptItem.ReceiptName,
                        Nomenclature = receiptItem.Nomenclature,
                        NomenclatureName = receiptItem.NomenclatureName,
                        BalanceAccountNum = receiptItem.BalanceAccountNum,
                        UnitPrice = receiptItem.UnitPrice,
                        TotalPrice = receiptItem.TotalPrice,
                        RequiredQuantity = receiptItem.Quantity,
                        UnitLocalName = receiptItem.UnitLocalName
                    });
                }
            }

            EditInvoiceRequirement(Utils.Operation.Add, new InvoiceRequirementOrdersDTO(), addMaterialsToInvoice);
        }

        private void insertRequirementBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ordersGridView.PostEditor();

            List<InvoiceRequirementMaterialsInfoDTO> addMaterialsToInvoice = new List<InvoiceRequirementMaterialsInfoDTO>();

            var checkRequirementinvoice = orderJournalList.Where(bdsm => bdsm.IsSelect == true);

            foreach (var orderItem in checkRequirementinvoice)
            {
                List<ReceiptJournalDTO> receiptOrder = storeHouseService.GetReceiptByOrderIdProc(orderItem.Id).ToList();

                foreach (var receiptItem in receiptOrder)
                {
                    addMaterialsToInvoice.Add(new InvoiceRequirementMaterialsInfoDTO()
                    {
                        ReceiptId = receiptItem.Id,
                        ReceiptNum = receiptItem.ReceiptName,
                        Nomenclature = receiptItem.Nomenclature,
                        NomenclatureName = receiptItem.NomenclatureName,
                        BalanceAccountNum = receiptItem.BalanceAccountNum,
                        UnitPrice = receiptItem.UnitPrice,
                        TotalPrice = receiptItem.TotalPrice,
                        RequiredQuantity = receiptItem.Quantity,
                        UnitLocalName = receiptItem.UnitLocalName
                    });
                }
            }

            EditInvoiceRequirement(Utils.Operation.Update, new InvoiceRequirementOrdersDTO(), addMaterialsToInvoice);
        }

        private void StoreHouseOrdersFm_Load(object sender, EventArgs e)
        {

            splitContainerControl.SplitterPosition = (int)Math.Ceiling(splitContainerControl.Height / 1.5);
        }

        private void beginYearEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
                LoadOrdersDataByPeriod(beginDate, endDate);
            }
        }

        private void beginMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
                LoadOrdersDataByPeriod(beginDate, endDate);
            }
        }

        private void endYearEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
                LoadOrdersDataByPeriod(beginDate, endDate);
            }
        }

        private void endMonthEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
                LoadOrdersDataByPeriod(beginDate, endDate);
            }
        }

        #endregion 

        private void periodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loger.Info();

                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (periodService.CheckPeriodAccess(beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                        model.State = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (periodService.CheckPeriodExist(beginDate))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                            model.State = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else if (MessageBox.Show("Вказаного періода не існує в системі! Додати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = beginDate.Year,
                                Month = beginDate.Month,
                                State = true,
                                StateBank = false,
                                StateBusinesTrip = false
                            };

                            periodService.PeriodsCreate(model);
                        }
                    }

                    SetPeriodBtnImage();
                }
                catch (Exception ex)
                {
                    loger.Error("При збереженні періоду виникла помилка. " + ex.Message);
                    MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void updateOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<ReceiptsDTO> receiptList = new List<ReceiptsDTO>();

            foreach (var item in receiptsJournalList)
            {
                receiptList.Add(new ReceiptsDTO()
                {
                    ID = item.Id,
                    ORDER_ID = item.OrderId,
                    POS = item.Pos,
                    QUANTITY = item.Quantity,
                    UNIT_PRICE = item.UnitPrice,
                    TOTAL_PRICE = item.TotalPrice,
                    NOMENCLATURE_ID = item.NomenclatureId,
                    Storehouse_Id = item.StorehouseId,
                    TOTAL_CURRENCY = item.TotalCurrency,
                    UNIT_CURRENCY = item.UnitCurrency,
                    Nomenclature = item.Nomenclature,
                    NomenclatureName = item.NomenclatureName,
                    UnitId = item.UnitId,
                    UnitLocalName = item.UnitLocalName,
                    NomenclatureGroupId = item.NomenclatureGroupId,
                    StoreHouseName = item.StorehouseName,
                    BalanceAccountId = item.BalanceAccountId,
                    BalanceAccountNum = item.BalanceAccountNum
                });
            }

            if (ordersBS.Count > 0)
            {
                var orderItem = (ReceiptOrdersDTO)ordersBS.Current;

                OrdersDTO model = new OrdersDTO()
                {
                    ID = orderItem.Id,
                    DEBIT_ACCOUNT_ID = (short)orderItem.DebitAccountId,
                    INVOICE_DATE = orderItem.InvoiceDate,
                    INVOICE_NUM = orderItem.InvoiceNum,
                    ORDER_DATE = orderItem.OrderDate,
                    Otk_Id = (short?)orderItem.Otk_Id,
                    RECEIPT_NUM = orderItem.ReceiptNum,
                    Storekeeper_Id = (short?)orderItem.Storekeeper_Id,
                    SUPPLIER_ID = (short?)orderItem.Supplier_Id,
                    SUPPLIER_PROXY = orderItem.SupplierProxy,
                    TAX_INVOICE = (short?)orderItem.TaxInvoice,
                    TOTAL_WITH_VAT = orderItem.TotalWithVat,
                    TOTAL_PRICE = orderItem.TotalPrice,
                    TRANSPORT_INVOICE = (short?)orderItem.TransportInvoice,
                    VENDOR_ID = orderItem.VendorId,
                    Vat = orderItem.Vat,
                    OtkId = orderItem.OtkId,
                    StorekeeperId = orderItem.StorekeeperId,
                    SupplierId = orderItem.SupplierId,
                    UserId = orderItem.UserId
                };

                EditOrder(Utils.Operation.Custom, model, receiptList, userTasksDTO);
            }
        }
    }
}