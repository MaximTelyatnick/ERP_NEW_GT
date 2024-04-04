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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;
using System.Globalization;
using ERP_NEW.GUI.StoreHouse;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingOrdersFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource ordersBS = new BindingSource();
        private BindingSource receiptsBS = new BindingSource();

        private IStoreHouseService storeHouseService;
        private IPeriodService periodService;
        private IBusinessTripsService businessTripsService;

        private List<AccountOrdersDTO> orderJournalList = new List<AccountOrdersDTO>();
        private List<ReceiptJournalDTO> receiptsJournalList = new List<ReceiptJournalDTO>();
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();

        private bool isCurrencyOrder;

        private UserTasksDTO userTasksDTO;
        private DateTime beginDate;
        private DateTime endDate;

        public AccountingOrdersFm(UserTasksDTO userTaskDTO, bool isCurrencyOrder = false)
        {
            InitializeComponent();

            this.userTasksDTO = userTaskDTO;

            beginYearEdit.EditValueChanged -= dateEdit_EditValueChanged;
            endYearEdit.EditValueChanged -= dateEdit_EditValueChanged;
            beginMonthEdit.EditValueChanged -= dateEdit_EditValueChanged;
            endMonthEdit.EditValueChanged -= dateEdit_EditValueChanged;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;
            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            beginYearEdit.EditValueChanged += dateEdit_EditValueChanged;
            endYearEdit.EditValueChanged += dateEdit_EditValueChanged;
            beginMonthEdit.EditValueChanged += dateEdit_EditValueChanged;
            endMonthEdit.EditValueChanged += dateEdit_EditValueChanged;

            this.beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            
            this.isCurrencyOrder = isCurrencyOrder;

            storehouseCheckItem.CheckedChanged -= storehouseCheckItem_CheckedChanged;
            storehouseAccountingCheckItem.CheckedChanged -= storehouseCheckItem_CheckedChanged;
            account63CheckItem.CheckedChanged -= storehouseCheckItem_CheckedChanged;
            account631CheckItem.CheckedChanged -= storehouseCheckItem_CheckedChanged;

            storehouseCheckItem.Checked = Properties.Settings.Default.Flag1;
            storehouseAccountingCheckItem.Checked = Properties.Settings.Default.Flag2;

            if (isCurrencyOrder)
            {
                account63CheckItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                account631CheckItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                account63CheckItem.Checked = false;
                account631CheckItem.Checked = false;

                //account631CheckItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                account63CheckItem.Checked = Properties.Settings.Default.Flag3;
                account631CheckItem.Checked = Properties.Settings.Default.Flag4;

                ordersGridView.Columns[4].Visible = false;
                ordersGridView.Columns[5].Visible = false;
                ordersGridView.Columns[6].Visible = false;
                receiptsGridView.Columns[6].Visible = false;
                receiptsGridView.Columns[7].Visible = false;
            }

            storehouseCheckItem.CheckedChanged += storehouseCheckItem_CheckedChanged;
            storehouseAccountingCheckItem.CheckedChanged += storehouseCheckItem_CheckedChanged;
            account63CheckItem.CheckedChanged += storehouseCheckItem_CheckedChanged;
            account631CheckItem.CheckedChanged += storehouseCheckItem_CheckedChanged;

            this.Text = (isCurrencyOrder) ? "Надходження (валюта)" : "Надходження";

            SelectDate();

            LoadOrdersDataByPeriod(beginDate, endDate);

            LoadColorsPallete();

            splitContainerControl.SplitterPosition = (this.Height - ribbonControl.Height);
        }



        private int InsertPeriod(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            int createPeriod = periodService.PeriodsCreate(new PeriodsDTO()
            {
                Month = currentDate.Month,
                State = true,
                Year = currentDate.Year,
                StateBank = false,
                StateBusinesTrip = false
            });

            return createPeriod;
        }

        #region Method's

        private void LoadOrdersDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            periodService = Program.kernel.Get<IPeriodService>();

            short? fl1 = Properties.Settings.Default.Flag1 ? Convert.ToInt16(Properties.Settings.Default.Flag1) : (short?)null;
            short? fl2 = Properties.Settings.Default.Flag2 ? Convert.ToInt16(Properties.Settings.Default.Flag2) : (short?)null;
            short? fl3 = Properties.Settings.Default.Flag3 ? Convert.ToInt16(Properties.Settings.Default.Flag3) : (short?)null;
            short? fl4 = Properties.Settings.Default.Flag4 ? Convert.ToInt16(Properties.Settings.Default.Flag4) : (short?)null;

            orderJournalList = storeHouseService.GetAccountOrderJournal(beginDate, endDate,fl1, fl2, fl3, fl4).ToList();

            if (isCurrencyOrder)
                ordersBS.DataSource = orderJournalList.Where(sort => sort.DebitAccountId == 60).ToList();
            else
                ordersBS.DataSource = orderJournalList.Where(sort => sort.DebitAccountId != 60).ToList();

            ordersGrid.DataSource = ordersBS;

            if (userTasksDTO.AccessRightId == 2)
                SetPeriodBtnImage();
            else
                receiptsGridView.GroupCount = 0;

            if (ordersBS.Count > 0)
                LoadReceiptsDataByOrderId(((AccountOrdersDTO)ordersBS.Current).Id);

            AuthorizatedUserAccess();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadReceiptsDataByOrderId(int id)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            receiptsJournalList = storeHouseService.GetReceiptByOrderIdProc(id).ToList();
            receiptsBS.DataSource = receiptsJournalList;
            receiptsGrid.DataSource = receiptsBS;
        }

        private void EditOrder(bool isCurrencyOrder, Utils.Operation operation, OrdersDTO model, List<ReceiptsDTO> source, UserTasksDTO userTaskDTO)
        {
            // Модальное окно
            //using (AccountingOrdersEditFm accountingOrderEditFm = new AccountingOrdersEditFm(isCurrencyOrder, operation, model, source, userTaskDTO))
            //{
            //    if (accountingOrderEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        OrdersDTO returnItem = accountingOrderEditFm.Return();
            //        ordersGridView.BeginDataUpdate();
            //        LoadOrdersDataByPeriod(beginDate, endDate);
            //        ordersGridView.EndDataUpdate();
            //        int rowHandle = ordersGridView.LocateByValue("Id", returnItem.ID);
            //        ordersGridView.FocusedRowHandle = rowHandle;
            //    }
            //}

            // Не модальное окно
            Cursor = Cursors.WaitCursor;
            AccountingOrdersEditFm accountingOrderEditFm = new AccountingOrdersEditFm(isCurrencyOrder, operation, model, source, userTaskDTO);
            accountingOrderEditFm.FormClosing += new FormClosingEventHandler(accountingOrderEditFm_FormClosing);
            //accountingOrderEditFm.MdiParent = this;
            accountingOrderEditFm.Show();
            Cursor = Cursors.Default;

        }

        void accountingOrderEditFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frm = sender as AccountingOrdersEditFm;
            ordersGridView.BeginDataUpdate();
            LoadOrdersDataByPeriod(beginDate, endDate);
            ordersGridView.EndDataUpdate();
        }

        private void LoadColorsPallete()
        {
            splashScreenManager.ShowWaitForm();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            colorsPallete = businessTripsService.GetColors().ToList();
            for (int i = contextMenuStrip.Items.Count; i > 2; i--)
            {
                contextMenuStrip.Items.RemoveAt(i - 1);
            }
            for (int i = 0; i < colorsPallete.Count; i++)
            {
                           
                ToolStripMenuItem MenuItem = new ToolStripMenuItem()
                {
                    Text = colorsPallete[i].Name_Rus.ToString(),
                    Image = Rgb2Bitmap(colorsPallete[i].Color_Code.ToString()),
                    ToolTipText = colorsPallete[i].Name.ToString(),
                    Tag = colorsPallete[i].Id
                };

                contextMenuStrip.Items.Add(MenuItem);
                
            }

            splashScreenManager.CloseWaitForm();
        }

        public void SelectDate()
        {
            beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
        }

        public Bitmap Rgb2Bitmap(string HtmlRgb)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(HtmlRgb));
            graphics.FillRectangle(brush, 0, 0, 16, 16);
            return bitmap;
        }

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void SetPeriodBtnImage()
        {
            if (CheckPeriodAccess(beginDate))
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

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.State);
        }

        private bool CheckPeriodExist(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }

        #endregion

        #region TransformData

        private OrdersDTO AccountOrdersToOrder(AccountOrdersDTO accountOrderDTO)
        {
            OrdersDTO model = new OrdersDTO
            {
                CHECKED = (short)Convert.ToInt16(accountOrderDTO.Checked),
                Color_Id = (short?)accountOrderDTO.ColorId,
                CORRECTION = (short)Convert.ToInt16(accountOrderDTO.Correction),
                CURRENCY_ID = (short?)accountOrderDTO.CurrencyId,
                CURRENCY_RATE = accountOrderDTO.CurrencyRate,
                DEBIT_ACCOUNT_ID = (short)accountOrderDTO.DebitAccountId,
                ENTER_DATE = accountOrderDTO.EnterDate,
                Flag1 = (short)accountOrderDTO.Flag1,
                Flag2 = (short)accountOrderDTO.Flag2,
                Flag3 = (short)accountOrderDTO.Flag3,
                Flag4 = (short)accountOrderDTO.Flag4,
                ID = accountOrderDTO.Id,
                INVOICE_DATE = accountOrderDTO.InvoiceDate,
                INVOICE_NUM = accountOrderDTO.InvoiceNum,
                ORDER_DATE = accountOrderDTO.OrderDate,
                Otk_Id = (short?)accountOrderDTO.Otk_Id,
                OtkId = accountOrderDTO.OtkId,
                RECEIPT_NUM = accountOrderDTO.ReceiptNum,
                Storekeeper_Id = (short?)accountOrderDTO.Storekeeper_Id,
                StorekeeperId = accountOrderDTO.StorekeeperId,
                SUPPLIER_ID = (short?)accountOrderDTO.Supplier_Id,
                SUPPLIER_PROXY = accountOrderDTO.SupplierProxy,
                SupplierId = accountOrderDTO.SupplierId,
                TAX_INVOICE = (short?)Convert.ToInt16(accountOrderDTO.TaxInvoice),
                TOTAL_CURRENCY = accountOrderDTO.TotalCurrency,
                TOTAL_PRICE = accountOrderDTO.TotalPrice,
                TOTAL_WITH_VAT = accountOrderDTO.TotalWithVat,
                TRANSPORT_INVOICE = (short?)Convert.ToInt16(accountOrderDTO.TransportInvoice),
                UserId = accountOrderDTO.UserId,
                Vat = accountOrderDTO.Vat,
                VatAccountId = accountOrderDTO.VatAccountId,
                VENDOR_ID = accountOrderDTO.VendorId,
                ACCOUNT_NUM = accountOrderDTO.AccountNum
            };
            return model;
        }

        private List<ReceiptsDTO> ReceiptsJournalListToReceiptList(List<ReceiptJournalDTO> accountOrderList)
        {
            List<ReceiptsDTO> receiptsList = new List<ReceiptsDTO>();

            foreach (var item in accountOrderList)
            {
                ReceiptsDTO model = new ReceiptsDTO
                {
                    ID = item.Id,
                    BalanceAccountId = item.BalanceAccountId,
                    BalanceAccountNum = item.BalanceAccountNum,
                    Nomenclature = item.Nomenclature,
                    NOMENCLATURE_ID = item.NomenclatureId,
                    NomenclatureGroupId = item.NomenclatureGroupId,
                    NomenclatureName = item.NomenclatureName,
                    ORDER_ID = item.OrderId,
                    POS = item.Pos,
                    QUANTITY = item.Quantity,
                    Storehouse_Id = item.StorehouseId,
                    StoreHouseName = item.StorehouseName,
                    TOTAL_CURRENCY = item.TotalCurrency,
                    TOTAL_PRICE = item.TotalPrice,
                    UNIT_CURRENCY = item.UnitCurrency,
                    UNIT_PRICE = item.UnitPrice,
                    UnitId = item.UnitId,
                    UnitLocalName = item.UnitLocalName
                };

                receiptsList.Add(model);
            }

            return receiptsList;
        }

        

        #endregion

        #region Event's

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            OrdersDTO model = new OrdersDTO
            {
                INVOICE_DATE = beginDate,
                ORDER_DATE = beginDate,
                Flag1 = Convert.ToInt16(Properties.Settings.Default.Flag1),
                Flag2 = Convert.ToInt16(Properties.Settings.Default.Flag2),
                Flag3 = Convert.ToInt16(Properties.Settings.Default.Flag3),
                Flag4 = Convert.ToInt16(Properties.Settings.Default.Flag4)
            };

            EditOrder(isCurrencyOrder, Utils.Operation.Add, model, new List<ReceiptsDTO>(), userTasksDTO);
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            OrdersDTO ordersModel = AccountOrdersToOrder((AccountOrdersDTO)ordersBS.Current);
            List<ReceiptsDTO> receiptsModelList = ReceiptsJournalListToReceiptList((List<ReceiptJournalDTO>)receiptsBS.DataSource);

            EditOrder(isCurrencyOrder, Utils.Operation.Update, ordersModel, receiptsModelList, userTasksDTO);
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ordersBS.Count != 0)
            {
                if (MessageBox.Show("Видалити надходження?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = ordersGridView.FocusedRowHandle - 1;
                    ordersGridView.BeginDataUpdate();
                    storeHouseService.OrderDelete(((AccountOrdersDTO)ordersBS.Current).Id);
                    LoadOrdersDataByPeriod(beginDate, endDate);
                    ordersGridView.EndDataUpdate();
                    ordersGridView.FocusedRowHandle = (ordersGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectDate();
            LoadOrdersDataByPeriod(beginDate, endDate);
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectDate();
            LoadOrdersDataByPeriod(beginDate, endDate);
        }

        private void ordersGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //if (e.RowHandle > -1)
            //{
            //    AccountOrdersDTO item = (AccountOrdersDTO)ordersGridView.GetRow(e.RowHandle);
            //    if (item.ColorId != null)
            //    {
            //        e.Appearance.BackColor = Color.FromName(item.ColorName.ToString());
            //        e.Appearance.BackColor2 = Color.SeaShell;
            //    }
            //}
        }

        private void periodBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (CheckPeriodAccess(beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                        model.State = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (CheckPeriodExist(beginDate))
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
                    MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ordersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (ordersBS.Count > 0 && ordersBS != null)
                LoadReceiptsDataByOrderId(((AccountOrdersDTO)ordersBS.Current).Id);
            else
                receiptsBS.DataSource = null;
        }

        private void storehouseCheckItem_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarCheckItem ch = ((BarCheckItem)sender);
            switch (ch.Name)
            {
                case "storehouseCheckItem":
                    if (ch.Checked)
                        Properties.Settings.Default.Flag1 = true;
                    else
                        Properties.Settings.Default.Flag1 = false;
                    break;

                case "storehouseAccountingCheckItem":
                    if (ch.Checked)
                        Properties.Settings.Default.Flag2 = true;
                    else
                        Properties.Settings.Default.Flag2 = false;
                    break;

                

                case "account631CheckItem":
                    if (ch.Checked)
                        Properties.Settings.Default.Flag3 = true;
                    else
                        Properties.Settings.Default.Flag3 = false;
                    break;

                case "account63CheckItem":
                    if (ch.Checked)
                        Properties.Settings.Default.Flag4 = true;
                    else
                        Properties.Settings.Default.Flag4 = false;
                    break;
            }

            if (account63CheckItem.Checked || account631CheckItem.Checked && (userTasksDTO.AccessRightId == 2))
                balanceNumCol.Group();
            else
                receiptsGridView.GroupCount = 0;

            Properties.Settings.Default.Save();

            SelectDate();

            LoadOrdersDataByPeriod(beginDate, endDate);
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                SelectDate();
                LoadOrdersDataByPeriod(beginDate, endDate);
            }
        }

        private void ordersGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (gv.GetRowCellValue(e.RowHandle, "ColorName")!= null)
            {
                string currentRowColor = gv.GetRowCellValue(e.RowHandle, "ColorName").ToString();
                e.Appearance.BackColor = Color.FromName(currentRowColor);
            }


            

            //if (gv.GetRowCellValue(e.RowHandle, "Color_Name") != null)

            //if (Row["Color_Name"] != DBNull.Value && Row["Color_Name"].ToString() != "White")
            //{
            //    e.Appearance.BackColor = Color.FromName(Row["Color_Name"].ToString());
            //}

            if ((e.Column.Name == "orderDateCol" || e.Column.Name == "invoiceDateCol") && (gv.GetRowCellValue(e.RowHandle, "OrderDate") != null && gv.GetRowCellValue(e.RowHandle, "InvoiceDate") != null))
            {
                if (gv.GetRowCellValue(e.RowHandle, "OrderDate").ToString().Substring(2) != gv.GetRowCellValue(e.RowHandle, "InvoiceDate").ToString().Substring(2))
                    e.Appearance.BackColor = Color.Yellow;

            }

            if ((e.Column.Name == "totalPriceCol" || e.Column.Name == "vatCol" || e.Column.Name == "totalWithVatCol") && (gv.GetRowCellValue(e.RowHandle, "TotalPrice") != null && gv.GetRowCellValue(e.RowHandle, "Vat") != null && gv.GetRowCellValue(e.RowHandle, "TotalWithVat") != null))
            {
                //if (gv.GetRowCellValue(e.RowHandle, "OrderDate").ToString().Substring(2) != gv.GetRowCellValue(e.RowHandle, "InvoiceDate").ToString().Substring(2))
                //{
                    double Total_Price = Convert.ToDouble(gv.GetRowCellValue(e.RowHandle, "TotalPrice"));
                    if (Math.Round(Total_Price * 1.2, 2) != Convert.ToDouble(gv.GetRowCellValue(e.RowHandle, "TotalWithVat")))
                        e.Appearance.BackColor = Color.SandyBrown;
                //}
            }

            if (e.Column.Name == "correctionCol")
            {
                bool? cellValue = Convert.ToBoolean(gv.GetRowCellValue(e.RowHandle, "Correction"));
                if (cellValue == true)
                    e.Appearance.BackColor = Color.Orange;
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (ordersBS.Count == 0 || ordersGridView.FocusedRowHandle < 0)
                e.Cancel = true;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Додати колір в палітру") // проверить и дописать
            {
            OrdersDTO updateModel = AccountOrdersToOrder((AccountOrdersDTO)ordersBS.Current);

            var per = Convert.ToInt16(e.ClickedItem.Tag);
            updateModel.Color_Id = Convert.ToInt16(e.ClickedItem.Tag);
            ((AccountOrdersDTO)ordersBS.Current).ColorName = e.ClickedItem.ToolTipText;
            //((AccountOrdersDTO)ordersBS.Current).ColorId = (int)e.ClickedItem.Tag;
            ordersBS.EndEdit();
            storeHouseService.OrderUpdate(updateModel);
        }


            
        }


        #endregion

        private void printBtn_ItemClick(object sender, ItemClickEventArgs e)
        {

            string exportFilePath = Utils.HomePath + @"\Temp\Надходження.xls";
            var optionXls = new XlsExportOptionsEx();

            optionXls.SheetName = "Надходження";
            optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            optionXls.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            optionXls.ExportType = ExportType.WYSIWYG;
            ordersGridView.OptionsPrint.AutoWidth = false;
            ordersGridView.BestFitColumns();

            string fileExtenstion = new FileInfo(exportFilePath).Extension;

            try
            {
                ordersGridView.ExportToXls(exportFilePath, optionXls);

                if (File.Exists(exportFilePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(exportFilePath);
                    }
                    catch
                    {
                        String msg = "Не можливо відкрити файл." + Environment.NewLine + Environment.NewLine + "Шлях: " + exportFilePath;
                        MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String msg = "Не можливо відкрити файл." + Environment.NewLine + Environment.NewLine + "Шлях: " + exportFilePath;
                    MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Файл вже відкрито! Закрийте файл!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccountingOrdersFm_Load(object sender, EventArgs e)
        {
            splitContainerControl.SplitterPosition = (int)Math.Round(splitContainerControl.Height / 1.3);
        }

        private void showTTNBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeliveryTTNFm deliveryTTNFm = new DeliveryTTNFm(userTasksDTO, beginDate, endDate);
            deliveryTTNFm.Show();
        }

        private void showReceiptBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AccountingOrderReceiptFm orderReciepFm = new AccountingOrderReceiptFm(beginDate, endDate, 1, 1, 0, 0);
            orderReciepFm.Show();
        }
   
        private void AddColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PalitraEditFm palitraEditFm = new PalitraEditFm(Utils.Operation.Add, new ColorsDTO()))
            {
                if (palitraEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LoadColorsPallete();
                    contextMenuStrip.Show();
                }
            }
        }


   
    }
}