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
using DevExpress.XtraEditors.Repository;
using DevExpress.Export;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class CustomerOrdersFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;
        private IStoreHouseService storeHouseService;
        private IReportService reportService;
        private ICurrencyService currencyService;

        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource customerOrdersSpecBS = new BindingSource();
        private BindingSource customerOrdersAssemblyBS = new BindingSource();
        private BindingSource customerOrderPrepaymentsBS = new BindingSource();
        private BindingSource customerOrderPaymentsBS = new BindingSource();
        private BindingSource expenditureMaterialBS = new BindingSource();
        private BindingSource paymentsInfoBS = new BindingSource();

        private CustomerOrderPaymentsInfoDTO paymentsInfo = new CustomerOrderPaymentsInfoDTO();

        private UserTasksDTO userTasksDTO;
        private decimal customerOrderCurrencyRate;

        public CustomerOrdersFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            splitContainerControl2.SplitterPosition = this.Width - (this.Width / 10);
            splitContainerControl3.SplitterPosition = ribbonControl1.Height + splitContainerControl1.Height + groupControl2.Height;
            splitContainerControl4.SplitterPosition = ribbonControl1.Height + splitContainerControl1.Height + groupControl2.Height+50;
            
            this.userTasksDTO = userTasksDTO;
            
            beginDateEditItem.EditValue = new DateTime(DateTime.Now.AddYears(-1).Year, 1, 1);
            endDateEditItem.EditValue = DateTime.Now;
            LoadCustomerOrdersData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);

            AuthorizatedUserAccess();
           
        }
                
        #region Method's

        private void LoadCustomerOrdersData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrdersBS.DataSource = ((int)orderFilterTypeItem.EditValue == 0) ?
                customerOrdersService.GetCustomerOrdersByPeriod(beginDate, endDate):
                customerOrdersService.GetCustomerOrdersWithoutSign();
            customerOrdersGrid.DataSource = customerOrdersBS;

            if (customerOrdersBS.Count > 0)
            {
                LoadCustomerOrderSpecificationsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCustomerOrderPaymentsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCustomerOrderPrepaymentsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCustomerOrderMaterialExpenditure(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCurrencyInformation();

                SetCustomerOrderSummary();
            }
            else
            {
                specificationGrid.DataSource = null;
                assembliesGrid.DataSource = null;
                prepaymentsGrid.DataSource = null;
                paymentsGrid.DataSource = null;
                paymentsVGrid.DataSource = null;
                expendituresGrid.DataSource = null;
            }

            splashScreenManager.CloseWaitForm();
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

        private void LoadCustomerOrderPrepaymentsData(int customerOrderId)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrderPrepaymentsBS.DataSource = customerOrdersService.GetCustomerOrderPrepaymentsById(customerOrderId);
            prepaymentsGrid.DataSource = customerOrderPrepaymentsBS;
        }

        private void LoadCustomerOrderPaymentsData(int customerOrderId)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            customerOrderPaymentsBS.DataSource = customerOrdersService.GetCustomerOrderPaymentsById(customerOrderId);
            paymentsGrid.DataSource = customerOrderPaymentsBS;
        }

        private void LoadCustomerOrderMaterialExpenditure(int customerOrderId)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            expenditureMaterialBS.DataSource = storeHouseService.GetExpenditureByCustomerOrder(customerOrderId).Where(srch => srch.CreditAccountId!=null).ToList();
            expendituresGrid.DataSource = expenditureMaterialBS;
        }

        private void LoadCurrencyInformation()
        {
            currencyService = Program.kernel.Get<ICurrencyService>();

            if (((CustomerOrdersDTO)customerOrdersBS.Current).OrderDate != null && ((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyId != null && ((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyId != 1)
                customerOrderCurrencyRate = currencyService.GetCurrencyRateByDate(((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyName, (DateTime)((CustomerOrdersDTO)customerOrdersBS.Current).OrderDate);
            else
                customerOrderCurrencyRate = 1;
        }

        private void AuthorizatedUserAccess()
        {
            addItem.Enabled = (userTasksDTO.AccessRightId == 2);
            editItem.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteItem.Enabled = (userTasksDTO.AccessRightId == 2);

            addPaymentBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deletePaymentBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            addPrepaymentBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deletePrepaymentBtn.Enabled = (userTasksDTO.AccessRightId == 2);

            addAssBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editAssBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteAssBtn.Enabled = (userTasksDTO.AccessRightId == 2);

            orderPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            orderPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            currencyPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            currencyPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            currencyCol.Visible = (userTasksDTO.PriceAttribute == 1);
            singlePrice.Visible = (userTasksDTO.PriceAttribute == 1);
            sumPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            singleCurrencyPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            sumCurrencyPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            paymentsVGrid.Visible = (userTasksDTO.PriceAttribute == 1);
            prepaymentCol.Visible = (userTasksDTO.PriceAttribute == 1);
            prepaymentVatCol.Visible = (userTasksDTO.PriceAttribute == 1);
            prepaymentCurrencyCol.Visible = (userTasksDTO.PriceAttribute == 1);
            paymentCol.Visible = (userTasksDTO.PriceAttribute == 1);
            paymentVatCol.Visible = (userTasksDTO.PriceAttribute == 1);
            paymentCurrencyCol.Visible = (userTasksDTO.PriceAttribute == 1);

        //    editOrderEdit. = (userTasksDTO.PriceAttribute == 1);

            if (userTasksDTO.UserRoleId == 9 && (((CustomerOrdersDTO)customerOrdersBS.Current).Enable == 0))
            {
                editItem.Enabled = (userTasksDTO.AccessRightId == 1);
                addAssBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                editAssBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                deleteAssBtn.Enabled = (userTasksDTO.AccessRightId == 1);
                editOrderEdit.Enabled = (userTasksDTO.AccessRightId == 1);
            }
            if (userTasksDTO.UserRoleId == 12 || userTasksDTO.UserRoleId == 14 || userTasksDTO.UserRoleId == 1)
                editOrderBtn.Enabled = true;
            else 
                editOrderBtn.Enabled = false;

        }
        
        private void EditCustomerOrder(Utils.Operation operation, CustomerOrdersDTO model)
        {
            using (CustomerOrderEditFm customerOrderEditFm = new CustomerOrderEditFm(operation, model, userTasksDTO))
            {
                if (customerOrderEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_OrderId = customerOrderEditFm.Return();
                    
                    customerOrdersGridView.BeginDataUpdate();
                    LoadCustomerOrdersData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                    customerOrdersGridView.EndDataUpdate();
                    
                    int rowHandle = customerOrdersGridView.LocateByValue("Id", return_OrderId);
                    customerOrdersGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void EditCustomerOrderAssembly(Utils.Operation operation, CustomerOrderAssembliesDTO model)
        {
            using (CustomerOrderAssemblyEditFm customerOrderAssemblyEditFm = new CustomerOrderAssemblyEditFm(operation, model))
            {
                if (customerOrderAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int returnAssId = customerOrderAssemblyEditFm.Return();
                    
                    assembliesGridView.BeginDataUpdate();
                    LoadCustomerOrderAssembliesData(((CustomerOrderSpecificationsDTO)customerOrdersSpecBS.Current).Id);
                    assembliesGridView.EndDataUpdate();

                    int rowHandle = assembliesGridView.LocateByValue("Id", returnAssId);
                    assembliesGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void DeleteCustomerOrder()
        {
            if (MessageBox.Show("Видалити заказ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
                
                if (customerOrdersService.CustomerOrderDelete(((CustomerOrdersDTO)customerOrdersBS.Current).Id))
                {
                    int rowHandle = customerOrdersGridView.FocusedRowHandle - 1;
                    customerOrdersGridView.BeginDataUpdate();
                    LoadCustomerOrdersData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
                    customerOrdersGridView.EndDataUpdate();
                    customerOrdersGridView.FocusedRowHandle = (customerOrdersGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void DeleteCustomerOrderAssembly()
        {
            if (MessageBox.Show("Видалити складальну одиницю?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

                if (customerOrdersService.CustomerOrderAssemblyDelete(((CustomerOrderAssembliesDTO)customerOrdersAssemblyBS.Current).Id))
                {
                    int rowHandle = customerOrdersGridView.FocusedRowHandle - 1;

                    assembliesGridView.BeginDataUpdate();
                    LoadCustomerOrderAssembliesData(((CustomerOrderSpecificationsDTO)customerOrdersSpecBS.Current).Id);
                    assembliesGridView.EndDataUpdate();

                    assembliesGridView.FocusedRowHandle = (assembliesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void AddCustomerOrderPayments(int paymentStatus, int customerOrderId)
        {
            using (BankPaymentsSelectFm bankPaymentsSelectFm = new BankPaymentsSelectFm(paymentStatus, customerOrderId))
            {
                if (bankPaymentsSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    paymentsGridView.BeginDataUpdate();
                    LoadCustomerOrderPaymentsData(customerOrderId);
                    SetCustomerOrderSummary();
                    paymentsGridView.EndDataUpdate();
                }
            }
        }

        private void AddCustomerOrderPrepayments(int paymentStatus, int customerOrderId)
        {
            using (BankPaymentsSelectFm bankPaymentsSelectFm = new BankPaymentsSelectFm(paymentStatus, customerOrderId))
            {
                if (bankPaymentsSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    prepaymentsGridView.BeginDataUpdate();
                    LoadCustomerOrderPrepaymentsData(customerOrderId);
                    SetCustomerOrderSummary();
                    prepaymentsGridView.EndDataUpdate();
                }
            }
        }

        private void DeleteCustomerOrderPrepayments(List<CustomerOrderPrepaymentsDTO> source)
        {
            if (MessageBox.Show("Видалити надходження?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

                foreach (var item in source)
                {
                    customerOrdersService.CustomerOrderPrepaymentDelete(item.Id);
                }

                prepaymentsGridView.BeginDataUpdate();
                LoadCustomerOrderPrepaymentsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                SetCustomerOrderSummary();
                prepaymentsGridView.EndDataUpdate();
            }
        }

        private void DeleteCustomerOrderPayments(List<CustomerOrderPaymentsDTO> source)
        {
            if (MessageBox.Show("Видалити виплату?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
                
                foreach (var item in source)
                {
                    customerOrdersService.CustomerOrderPaymentDelete(item.Id);
                }
                
                prepaymentsGridView.BeginDataUpdate();
                LoadCustomerOrderPaymentsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                SetCustomerOrderSummary();
                prepaymentsGridView.EndDataUpdate();
            }
        }

        private void SetCustomerOrderSummary()
        {
            paymentsInfo.CustomerOrderPrice = ((CustomerOrdersDTO)customerOrdersBS.Current).OrderPrice ?? 0.00m;
            paymentsInfo.CustomerOrderPriceCurrency = ((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyPrice ?? 0.00m;
            paymentsInfo.PaymentPrice = ((List<CustomerOrderPaymentsDTO>)customerOrderPaymentsBS.DataSource).Sum(s => s.Payment) ?? 0.00m;
            paymentsInfo.PaymentPriceCurrency = ((List<CustomerOrderPaymentsDTO>)customerOrderPaymentsBS.DataSource).Sum(s => s.PaymentCurrency) ?? 0.00m;
            paymentsInfo.PrepaymentPrice = ((List<CustomerOrderPrepaymentsDTO>)customerOrderPrepaymentsBS.DataSource).Sum(s => s.Prepayment) ?? 0.00m;
            paymentsInfo.PrepaymentPriceCurrency = ((List<CustomerOrderPrepaymentsDTO>)customerOrderPrepaymentsBS.DataSource).Sum(s => s.PrepaymentCurrency) ?? 0.00m;
            paymentsInfo.ExpenditureMaterialPrice = ((List<ExpenditureInfoDTO>)expenditureMaterialBS.DataSource).Sum(s => s.ExpPrice) ?? 0.00m;
            if (((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyId > 1)
            {
                if (paymentsInfo.ExpenditureMaterialPrice != 0 && ((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyPrice != 0)
                    paymentsInfo.ExpenditureMaterialPricePercent = (decimal?)Math.Round((decimal)((paymentsInfo.ExpenditureMaterialPrice * 100.00m)/(customerOrderCurrencyRate * ((CustomerOrdersDTO)customerOrdersBS.Current).CurrencyPrice)), 2) ?? 0.00m;
                else
                    paymentsInfo.ExpenditureMaterialPricePercent = 0.00m;
            }
            else
            {
                if (paymentsInfo.ExpenditureMaterialPrice != 0 && ((CustomerOrdersDTO)customerOrdersBS.Current).OrderPrice != 0)
                    paymentsInfo.ExpenditureMaterialPricePercent = (decimal?)Math.Round((decimal)((paymentsInfo.ExpenditureMaterialPrice * 100.00m)/(customerOrderCurrencyRate * ((CustomerOrdersDTO)customerOrdersBS.Current).OrderPrice)), 2) ?? 0.00m;
                else
                    paymentsInfo.ExpenditureMaterialPricePercent = 0.00m;
            }

            paymentsVGrid.BeginDataUpdate();
            paymentsInfoBS.DataSource = paymentsInfo;
            paymentsVGrid.DataSource = paymentsInfoBS;
            paymentsVGrid.EndDataUpdate();
         }

        #endregion

        #region Event's

        private void addItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditCustomerOrder(Utils.Operation.Add, new CustomerOrdersDTO() { UserId = userTasksDTO.UserId, DateCreate = DateTime.Now});
        }

        private void editItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersBS.Count > 0)
            {
                if (userTasksDTO.UserRoleId != 9)
                    ((CustomerOrdersDTO)customerOrdersBS.Current).UserId = userTasksDTO.UserId;
                customerOrdersBS.EndEdit();
                EditCustomerOrder(Utils.Operation.Update, (CustomerOrdersDTO)customerOrdersBS.Current);
            }
        }

        private void deleteItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersBS.Count > 0)
                DeleteCustomerOrder();
        }
                
        private void printItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersBS.Count != 0)
            {
                reportService = Program.kernel.Get<IReportService>();
                reportService.PrintCustomerOrderInfo((CustomerOrdersDTO)customerOrdersBS.Current);
            }
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCustomerOrdersData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
        }

        private void showItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadCustomerOrdersData((DateTime)beginDateEditItem.EditValue, (DateTime)endDateEditItem.EditValue);
        }

        private void customerOrdersGridView_DoubleClick(object sender, EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2 && (((CustomerOrdersDTO)customerOrdersBS.Current).Enable == 0))
                EditCustomerOrder(Utils.Operation.Update, (CustomerOrdersDTO)customerOrdersBS.Current);
        }
        
        private void customerOrdersGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //--
            if (((CustomerOrdersDTO)customerOrdersBS.Current).Enable == 1)
            {
                editItem.Enabled = false;
                deleteItem.Enabled = false;
                editAssBtn.Enabled = false;
                addAssBtn.Enabled = false;
               // addPaymentBtn.Enabled = false;
               // deletePaymentBtn.Enabled = false;

                //editOrderBtn.Glyph = imageCollection.Images[4];
                editOrderBtn.LargeGlyph = imageCollection1.Images[1];
                editOrderBtn.Caption = "Прибрати зі складу готової продукції";
            }
            else
            {

                editItem.Enabled = (userTasksDTO.AccessRightId == 2);
                deleteItem.Enabled = (userTasksDTO.AccessRightId == 2);
                editAssBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                addAssBtn.Enabled = (userTasksDTO.AccessRightId == 2);
              //  addPaymentBtn.Enabled = true;
              //  deletePaymentBtn.Enabled = true;

                //editOrderBtn.Glyph = imageCollection.Images[5];
                editOrderBtn.LargeGlyph = imageCollection1.Images[0];
                editOrderBtn.Caption = "Відправити на склад готової продукції";
            }
            //---
            if (customerOrdersBS.Count > 0)
            {
                LoadCustomerOrderSpecificationsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCustomerOrderPaymentsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCustomerOrderPrepaymentsData(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCustomerOrderMaterialExpenditure(((CustomerOrdersDTO)customerOrdersBS.Current).Id);
                LoadCurrencyInformation();


                SetCustomerOrderSummary();

            }
            else
            {
                specificationGrid.DataSource = null;
                paymentsGrid.DataSource = null;
                prepaymentsGrid.DataSource = null;
                expendituresGrid.DataSource = null;
            }
        }

        private void specofocationGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(customerOrdersSpecBS.Count > 0)
                LoadCustomerOrderAssembliesData(((CustomerOrderSpecificationsDTO)customerOrdersSpecBS.Current).Id);
        }
                
        private void addAssBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersSpecBS.Count > 0)
                EditCustomerOrderAssembly(Utils.Operation.Add, new CustomerOrderAssembliesDTO() { CustomerOrderSpecId = ((CustomerOrderSpecificationsDTO)customerOrdersSpecBS.Current).Id });
        }

        private void editAssBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(customerOrdersAssemblyBS.Count > 0)
                EditCustomerOrderAssembly(Utils.Operation.Update, (CustomerOrderAssembliesDTO)customerOrdersAssemblyBS.Current);
        }

        private void deleteAssBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersAssemblyBS.Count > 0)
                DeleteCustomerOrderAssembly();
        }

        private void addPaymentBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersBS.Count > 0)
                AddCustomerOrderPayments(2, ((CustomerOrdersDTO)customerOrdersBS.Current).Id);
        }

        private void deletePaymentBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrderPaymentsBS.Count > 0)
            {
                paymentsGridView.PostEditor();

                List<CustomerOrderPaymentsDTO> checkItems = ((List<CustomerOrderPaymentsDTO>)customerOrderPaymentsBS.DataSource).Where(w => w.Selected).ToList();

                if (checkItems.Count > 0)
                    DeleteCustomerOrderPayments(checkItems);
            }
        }

        private void addPrepaymentBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrdersBS.Count > 0)
                AddCustomerOrderPrepayments(1, ((CustomerOrdersDTO)customerOrdersBS.Current).Id);
        }

        private void deletePrepaymentBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (customerOrderPrepaymentsBS.Count > 0)
            {
                prepaymentsGridView.PostEditor();

                List<CustomerOrderPrepaymentsDTO> checkItems = ((List<CustomerOrderPrepaymentsDTO>)customerOrderPrepaymentsBS.DataSource).Where(w => w.Selected).ToList();

                if (checkItems.Count > 0)
                    DeleteCustomerOrderPrepayments(checkItems);
            }
        }

        private void customerOrdersGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "orderNumberCol")
            {
                var cellValue = customerOrdersGridView.GetRowCellValue(e.RowHandle, orderNumberCol);

                if (cellValue == null || (string)cellValue == String.Empty)
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.Tomato;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "orderDateCol")
            {
                var cellValue = customerOrdersGridView.GetRowCellValue(e.RowHandle, orderDateCol);

                if (cellValue == null)
                {
                    e.Appearance.BackColor = Color.Tomato;
                    e.Appearance.BackColor2 = Color.LightSalmon;
                }
            }
        }
        
        private void orderFilterTypeEdit_EditValueChanged(object sender, EventArgs e)
        {                
            printItem.Enabled = ((int)orderFilterTypeItem.EditValue == 1);
        }

        private void editOrderBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            CustomerOrdersDTO update = (CustomerOrdersDTO)customerOrdersBS.Current;
            customerOrdersGridView.BeginDataUpdate();

            if ((((CustomerOrdersDTO)customerOrdersBS.Current).Enable == 0))
            {
                update.Enable = 1;
                customerOrdersService.CustomerOrderUpdate(update);
                editItem.Enabled = false;
                deleteItem.Enabled = false;
                editAssBtn.Enabled = false;
                addAssBtn.Enabled = false;
                deleteAssBtn.Enabled = false;
              //  addPaymentBtn.Enabled = false;
              //  deletePaymentBtn.Enabled = false;

                //editOrderBtn.Glyph = imageCollection.Images[4];

                editOrderBtn.LargeGlyph = imageCollection1.Images[1];
                // editOrderBtn.ButtonStyle = imageCollection.Images[4];
                editOrderBtn.Caption = "Прибрати зі складу готової продукції";
            }
            else
            {
                update.Enable = 0;
                customerOrdersService.CustomerOrderUpdate(update);
                editItem.Enabled = true;
                deleteItem.Enabled = true;
                editAssBtn.Enabled = true;
                deleteAssBtn.Enabled = true;
                addAssBtn.Enabled = true;
             //   addPaymentBtn.Enabled = true;
             //   deletePaymentBtn.Enabled = true;

                //editOrderBtn.Glyph = imageCollection.Images[5];
                editOrderBtn.LargeGlyph = imageCollection1.Images[0];
                editOrderBtn.Caption = "Відправити на склад готової продукції";
            }
            customerOrdersGridView.EndDataUpdate();
        }

        private void customerOrdersGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            CustomerOrdersDTO item = (CustomerOrdersDTO)customerOrdersBS[e.ListSourceRowIndex];

            if (e.Column == enableColumn)
            {
                if (item.Enable == 1)
                    e.Value = imageCollection.Images[4];
                else
                    e.Value = imageCollection.Images[5];
            }
        }

        RepositoryItem newRepositoryItem = new RepositoryItem();
        private void customerOrdersGridView_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsFilterRow(e.RowHandle) && e.Column.FieldName == "enableColumn")
                e.RepositoryItem = newRepositoryItem;
        }

        #endregion

        private void expenditureByCustomerOrderRepBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (expenditureMaterialBS.Count == 0)
            {
                MessageBox.Show("Відсутні списання!", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                var reportList = ((List<ExpenditureInfoDTO>)expenditureMaterialBS.DataSource).Where(bdsm => bdsm.CreditAccountId!=null).ToList();

                

                if (!reportService.ExpendituresForProject(reportList))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashScreenManager.CloseWaitForm();
                return;
            }
        }

        private void exportToXlsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            string exportFilePath = Utils.HomePath + @"\Temp\Закази за період з "+ ((DateTime)beginDateEditItem.EditValue).ToShortDateString() + " по "+ ((DateTime)endDateEditItem.EditValue).ToShortDateString() + ".xls";
            var optionXls = new XlsExportOptionsEx();

            optionXls.SheetName = "Закази";
            optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
            optionXls.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            optionXls.ExportType = ExportType.WYSIWYG;
            customerOrdersGridView.OptionsPrint.AutoWidth = false;
            customerOrdersGridView.BestFitColumns();

            string fileExtenstion = new FileInfo(exportFilePath).Extension;

            try
            {
                customerOrdersGrid.ExportToXls(exportFilePath, optionXls);

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
            catch (Exception)
            {
                MessageBox.Show("Файл вже відкрито! Закрийте файл!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}