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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using Ninject;
using System.IO;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ERP_NEW.BLL;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;
using ERP_NEW.BLL.DTO.ReportsDTO;
using System.Globalization;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingInvoicesFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;

        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();
        private List<MonthDetailsDTO> monthInSortedFilter = new List<MonthDetailsDTO>();

        private IAccountingInvoicesService accountingInvoicesService;
        private IBusinessTripsService businessTripsService;
        private IReportService reportService;
        private IPeriodService periodService;

        private BindingSource accountingInvoicesBS = new BindingSource();
        private BindingSource dateBS = new BindingSource();

        private DateTime curDate;
        private DateTime nullDate;
        
        private List<InvoicesDTO> invoicesInfoList = new List<InvoicesDTO>();
        private List<InvoicesSortDTO> invoicesSortList = new List<InvoicesSortDTO>();

        public static bool flagButMonth = false;

        private DateTime beginDate, endDate;

        public AccountingInvoicesFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
           
            this.userTasksDTO = userTasksDTO;

            beginMonthEditItem.EditValue =  DateTime.Now.Month;
            beginYearEditItem.EditValue = DateTime.Now;

            beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginDateEditItem.EditValue = beginDate;
            endDateEditItem.EditValue = endDate;

            beginDateEditItem.Links[0].Visible = false;
            endDateEditItem.Links[0].Visible = false;

            ShowInGridByFilter();

            LoadColorsPallete();

        }

       #region Method's
       
        private void LoadAccountingInvoicesData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            invoicesInfoList = accountingInvoicesService.GetInvoices(beginDate, endDate).OrderByDescending(sort => sort.Month_Current).ToList();
            
            List<DateTime> monthList = new List<DateTime>();

            for (int i = 0; i < invoicesInfoList.Count; ++i)
            {
                if(!monthList.Select(bdsm=>bdsm.Month).Contains(invoicesInfoList[i].Month_Invoice.Month))
                {
                    monthList.Add(invoicesInfoList[i].Month_Invoice);
                }
                else if (!monthList.Select(bdsm => bdsm.Month).Contains(invoicesInfoList[i].Month_Current.Month))
                {
                    monthList.Add(invoicesInfoList[i].Month_Current);
                }
            }

            monthInSortedFilter.Clear();
            monthFilterGridEdit.EditValue = null;

            for (int i = 0; i < monthList.Count; i++)
            {
                monthInSortedFilter.Add(new MonthDetailsDTO()
                {
                    Id = i,
                    DateMonth = monthList[i].Date,
                    NumberMonth = monthList[i].Month,
                    NameMonth = monthList[i].Date.ToString("MMMMMMMM", new CultureInfo("uk-UA"))
                });
            }

            repositoryItemGridLookUpEdit.DataSource = monthInSortedFilter;
            repositoryItemGridLookUpEdit.ValueMember = "Id";
            repositoryItemGridLookUpEdit.DisplayMember = "NumberMonth";
            repositoryItemGridLookUpEdit.Properties.NullText = "Немає данних";

            accountingInvoicesBS.DataSource = invoicesInfoList;
            accountingInvoicesGrid.DataSource = accountingInvoicesBS;

            invoicesSortList = invoicesInfoList.GroupBy(l => l.Balance_Account_Id).Select(cl => new InvoicesSortDTO
            {
                BalanceAccountName = cl.First().Bal_Name,
                SumPrice = cl.Sum(c => c.Price),
                SumVat = cl.Sum(cv => cv.Vat)
            }).ToList();


            additionalAccountingInvoicesGrid.DataSource = invoicesSortList;

            SetPeriodBtnImage();

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addBut.Enabled = (userTasksDTO.AccessRightId == 2);
            editBut.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBut.Enabled = (userTasksDTO.AccessRightId == 2);
            periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void SetPeriodBtnImage()
        {
            periodService = Program.kernel.Get<IPeriodService>();

            if (periodService.CheckPeriodTaxInvoicesAccess(beginDate) && (userTasksDTO.AccessRightId == 2))
            {
                periodBtn.Glyph = imageCollection.Images[1];
                periodBtn.LargeGlyph = imageCollection.Images[1];
                periodBtn.Caption = "Закрити період";
                addBut.Enabled = true;
                editBut.Enabled = true;
                deleteBut.Enabled = true;
                periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            }
            else
            {
                periodBtn.Glyph = imageCollection.Images[0];
                periodBtn.LargeGlyph = imageCollection.Images[0];
                periodBtn.Caption = "Відкрити період";
                addBut.Enabled = false;
                editBut.Enabled = false;
                deleteBut.Enabled = false;
                periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);

            }
        }

        private DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                Type t = GetCoreType(prop.PropertyType);
                tb.Columns.Add(prop.Name, t);
            }


            foreach (T item in items)
            {
                var values = new object[props.Length];

                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        public bool IsNullable(Type t)
        {
            return !t.IsValueType || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }

        public Type GetCoreType(Type t)
        {
            if (t != null && IsNullable(t))
            {
                if (!t.IsValueType)
                {
                    return t;
                }
                else
                {
                    return Nullable.GetUnderlyingType(t);
                }
            }
            else
            {
                return t;
            }
        }

        public DataTable CreateDataTable(IEnumerable source)
        {
            var table = new DataTable();
            int index = 0;
            var properties = new List<PropertyInfo>();
            foreach (var obj in source)
            {
                if (index == 0)
                {
                    foreach (var property in obj.GetType().GetProperties())
                    {
                        if (Nullable.GetUnderlyingType(property.PropertyType) != null)
                        {
                            continue;
                        }
                        properties.Add(property);
                        table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                    }
                }
                object[] values = new object[properties.Count];
                for (int i = 0; i < properties.Count; i++)
                {
                    values[i] = properties[i].GetValue(obj);
                }
                table.Rows.Add(values);
                index++;
            }
            return table;
        }

        private void ShowInGridByFilter()
        {

            if (ordersFilterEditItem.EditValue.ToString() == "1")
            {
                beginDate = (DateTime)beginDateEditItem.EditValue;
                endDate = (DateTime)endDateEditItem.EditValue;
                LoadAccountingInvoicesData(beginDate, endDate);
            }
            else
            {
                beginDate = new DateTime(((DateTime)beginYearEditItem.EditValue).Year, (int)beginMonthEditItem.EditValue, 1);
                endDate = new DateTime(((DateTime)beginYearEditItem.EditValue).Year, (int)beginMonthEditItem.EditValue, beginDate.AddMonths(1).AddDays(-1).Day);//.endDate.AddMonths(+1).AddDays(-1);
                LoadAccountingInvoicesData(beginDate, endDate);
            }
        }
       
        private void AddAccountingInvoices(Utils.Operation operation, InvoicesDTO model)
        {
            using (AccountingInvoicesEditFm accountingInvoicesEditFm = new AccountingInvoicesEditFm(operation, model))
            {
                if (accountingInvoicesEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    InvoicesDTO return_Id = accountingInvoicesEditFm.Return();
                    accountingInvoicesGridView.BeginDataUpdate();

                    ShowInGridByFilter();

                    accountingInvoicesGridView.EndDataUpdate();                    
               }
            }
        }

        private void EditAccountingInvoices(Utils.Operation operation, InvoicesDTO model)
        {
            if (accountingInvoicesBS.Count != 0)
            {
                using (AccountingInvoicesEditFm accountingInvoicesEditFm = new AccountingInvoicesEditFm(operation, model))
                {
                    if (accountingInvoicesEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = accountingInvoicesEditFm.Returnl();
                        accountingInvoicesGridView.BeginDataUpdate();
                        curDate = accountingInvoicesEditFm.foundCurDateEdit();
                        accountingInvoicesGridView.EndDataUpdate();
                        int rowHandle = accountingInvoicesGridView.LocateByValue("Id", return_Id);
                        accountingInvoicesGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
            curDate = nullDate;
            ShowInGridByFilter();        
        }

        private void DeleteAccountigInvoices()
        {
            if (accountingInvoicesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
                    int rowHandle = accountingInvoicesGridView.FocusedRowHandle - 1;
                    accountingInvoicesGridView.BeginDataUpdate();

                    if ((((InvoicesDTO)accountingInvoicesBS.Current).Contractor_Id) != 0)
                    {
                        int tempId = ((InvoicesDTO)accountingInvoicesBS.Current).Contractor_Id ?? 0;
                        accountingInvoicesService.AccountsInvoiceDelete(((InvoicesDTO)accountingInvoicesBS.Current).Id);
                        InvoicesDTO modelUpdate = accountingInvoicesService.GetInvoicesById(tempId);
                        accountingInvoicesService.AccountsInvoiceUpdate(modelUpdate);
                    }
                    else
                    {
                        accountingInvoicesService.AccountsInvoiceDelete(((InvoicesDTO)accountingInvoicesBS.Current).Id);
                    }
                    ShowInGridByFilter();

                    accountingInvoicesGridView.EndDataUpdate();
                    accountingInvoicesGridView.FocusedRowHandle = (accountingInvoicesGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
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

        public Bitmap Rgb2Bitmap(string HtmlRgb)
        {
            Bitmap bitmap = new Bitmap(16, 16);
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml(HtmlRgb));
            graphics.FillRectangle(brush, 0, 0, 16, 16);
            return bitmap;
        }
       
        #endregion

       #region Event's

       private void showBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            repositoryFilterMonthLookUpEdit.Dispose();
            ShowInGridByFilter();
        }

        private void addBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddAccountingInvoices(Utils.Operation.Add, new InvoicesDTO());
        }

        private void editBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditAccountingInvoices(Utils.Operation.Update, (InvoicesDTO)accountingInvoicesBS.Current);
        }

        private void deleteBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteAccountigInvoices();
        }

        private void invoicesToExcelBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            if (accountingInvoicesBS.Count != 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                //reportService.PrintAccountingInvoices(ViewToDataTable());
                reportService.PrintAccountingInvoices(invoicesInfoList);
            }

            splashScreenManager.CloseWaitForm();
        }

        

        private void repositoryDateCheckRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            if (ordersFilterEditItem.EditValue.ToString() == "1")
            {
                beginMonthEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "1");
                beginYearEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "1");
                beginDateEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "0");
                endDateEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "0");     
            }
            else
            {
                beginMonthEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "1");
                beginYearEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "1");
                beginDateEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "0");
                endDateEditItem.Links[0].Visible = (ordersFilterEditItem.EditValue.ToString() == "0");
            }
        }
    
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (accountingInvoicesBS.Count == 0 || accountingInvoicesGridView.FocusedRowHandle < 0)
                e.Cancel = true;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Додати колір в палітру") // проверить и дописать
            {
                ((InvoicesDTO)accountingInvoicesBS.Current).Color_Name = e.ClickedItem.ToolTipText;
                ((InvoicesDTO)accountingInvoicesBS.Current).Color_Id = (int)e.ClickedItem.Tag;

                accountingInvoicesBS.EndEdit();
                accountingInvoicesBS.CancelEdit();

                accountingInvoicesService.AccountsInvoiceUpdate((InvoicesDTO)accountingInvoicesBS.Current);
            }
        }

        private void accountingInvoicesGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            DateTime valueCur;
            DateTime valueInv;

            var valueCurrent = gv.GetRowCellValue(e.RowHandle, "Month_Current");
            var valueInvoices = gv.GetRowCellValue(e.RowHandle, "Month_Invoice");

            if (valueCurrent != null && valueInvoices != null)
            {
                DateTime.TryParse(valueCurrent.ToString(), out valueCur);
                DateTime.TryParse(valueInvoices.ToString(), out valueInv);


                if (valueCur > valueInv)
                    if ((e.Column.Name == "monthCurrentCol") || (e.Column.Name == "monthInvoiceCol"))
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        additionalAccountingInvoicesGrid.RefreshDataSource();

                    }

                DataRow Row = accountingInvoicesGridView.GetDataRow(e.RowHandle);
                if (Row == null)
                    return;

                if (Row["Color_Name"] != DBNull.Value && Row["Color_Name"].ToString() != "White")
                {
                    e.Appearance.BackColor = Color.FromName(Row["Color_Name"].ToString());
                }
            }    
        }

        private void accountingInvoicesGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                InvoicesDTO item = (InvoicesDTO)accountingInvoicesGridView.GetRow(e.RowHandle);
                if (item.Color_Id != null)
                    e.Appearance.BackColor = Color.FromName(item.Color_Name.ToString());
            }
        }

        private void LoadDataAdditionalAccountingInvoices(IEnumerable<InvoicesDTO> invoicesList)
        {
            invoicesSortList = invoicesList.GroupBy(l => l.Balance_Account_Id).Select(cl => new InvoicesSortDTO
            {
                BalanceAccountName = cl.First().Bal_Name,
                SumPrice = cl.Sum(c => c.Price),
                SumVat = cl.Sum(cv => cv.Vat)
            }).ToList();


            additionalAccountingInvoicesGrid.DataSource = invoicesSortList;
        }

        private void accountingInvoicesGridView_CustomFilterDisplayText(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {  
            
            CriteriaOperator op = accountingInvoicesGridView.ActiveFilterCriteria;
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op).ToString();

            string replace_string;
            string replaceable_string;

            string[] testCol = new string[] { "Month_Current", "Month_Invoice", "Invoice_Number", "Contractor_Id", "Bal_Name", "Price", "Vat", "Non_Taxable", "Total_Price", "Vat_Check", "Inv_Note_Name" };//, "tinCol", "priceCol", "vatCol", "nonTaxableCol", "totalPriceCol", "balNameCol", "vatCheckCol", "invNoteNameCol" };
            for (int i = 0; i < testCol.Length; i++)
            {
                replace_string = "Convert([" + testCol[i] + "], 'System.String') like";
                replaceable_string = "[" + testCol[i] + "] like";
                filterString = filterString.Replace(replaceable_string, replace_string);
            }

            IEnumerable<InvoicesDTO> lst = (IEnumerable<InvoicesDTO>)accountingInvoicesBS.DataSource;
            DataTable dt = ToDataTable<InvoicesDTO>(lst);
            DataView dv = new DataView(dt);

            List<InvoicesDTO> rows = new List<InvoicesDTO>();

            dv.RowFilter = filterString;

            DataTable table = dv.ToTable();

            List<InvoicesDTO> invoicesInfoSortList = (from DataRow row in table.Rows

                                                      select new InvoicesDTO
                                                      {
                                                          Id = Convert.ToInt32(row["Id"]),
                                                          Month_Current = Convert.ToDateTime(row["Month_Current"]),
                                                          Month_Invoice = Convert.ToDateTime(row["Month_Invoice"]),
                                                          Invoice_Number = Convert.ToString(row["Invoice_Number"]),
                                                          Contractor_Id = (row["Contractor_Id"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["Contractor_Id"]),
                                                          Balance_Account_Id = (row["Balance_Account_Id"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["Balance_Account_Id"]),
                                                          Price = (row["Price"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["Price"]),
                                                          Vat = (row["Vat"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["Vat"]),
                                                          Non_Taxable = (row["Non_Taxable"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["Non_Taxable"]),
                                                          Total_Price = (row["Total_Price"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["Total_Price"]),
                                                          Color_Id = (row["Color_Id"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["Color_Id"]),
                                                          Vat_Check = (row["Vat_Check"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["Vat_Check"]),
                                                          Note_Id = (row["Note_Id"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["Note_Id"]),
                                                          Registry_Id = (row["Registry_Id"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["Registry_Id"]),
                                                          Date_Of_Correction = (row["Date_Of_Correction"] is System.DBNull) ? (DateTime?)DateTime.Now : Convert.ToDateTime(row["Date_Of_Correction"]),
                                                          Number_Of_Correction = Convert.ToString(row["Number_Of_Correction"]),
                                                          Tin = Convert.ToString(row["Tin"]),
                                                          Contractor_Name = Convert.ToString(row["Contractor_Name"]),
                                                          Color_Name = Convert.ToString(row["Color_Name"]),
                                                          Bal_Name = Convert.ToString(row["Bal_Name"]),
                                                          Inv_Note_Name = Convert.ToString(row["Inv_Note_Name"]),
                                                          Region_Name = Convert.ToString(row["Region_Name"]),
                                                          Selected = Convert.ToBoolean(row["Selected"])

                                                      }).ToList();



            invoicesSortList = invoicesInfoSortList.GroupBy(l => l.Balance_Account_Id).Select(cl => new InvoicesSortDTO
                                                                        {
                                                                            BalanceAccountName = cl.First().Bal_Name,
                                                                            SumPrice = cl.Sum(c => c.Price),
                                                                            SumVat = cl.Sum(cv => cv.Vat)
                                                                        }).ToList();


            additionalAccountingInvoicesGrid.DataSource = invoicesSortList;
        }

        private void filterByMonthBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (accountingInvoicesBS.Count > 0)
            {
                List<InvoicesDTO> buffer = (List<InvoicesDTO>)accountingInvoicesBS.DataSource;

                int currentMonth = ((MonthDetailsDTO)repositoryItemGridLookUpEdit.GetRowByKeyValue((int)monthFilterGridEdit.EditValue)).NumberMonth;

                var lst = buffer.Where(bdsm => bdsm.Month_Invoice.Month == currentMonth).ToList();

                accountingInvoicesBS.DataSource = lst;

                LoadDataAdditionalAccountingInvoices(lst);
            }

        }

        private void invoicesAndPaymentToExcelBut_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();

            splashScreenManager.ShowWaitForm();

            var reportInvoisesDto = reportService.GetPayments(beginDate, endDate);

            var beginCredit = reportService.GetBeginCredit(beginDate);
            
            var invoices = new List<ReportInvoiceDTO>();

            List<InvoicesDTO> buffer = (List<InvoicesDTO>)accountingInvoicesBS.DataSource;

            int i = 0;

            foreach (var item in buffer)
            {
                ++i;
                invoices.Add(new ReportInvoiceDTO
                {
                    BalanceAccountName = item.Bal_Name.ToString(),
                    Month_Invoice = item.Month_Invoice.ToString(),
                    Invoice_Number = item.Invoice_Number.ToString(),
                    Vendor_Name = item.Contractor_Name.ToString(),
                    Vendor_Code = item.Tin.ToString(),
                    Bez_Nds = item.Price.ToString(),
                    Nds = item.Vat.ToString(),
                    Non_Taxable = item.Non_Taxable.ToString(),
                    TotalPrice = item.Total_Price.ToString(),
                    Month_Current = item.Month_Current.ToString(),
                    Contractor_Id = item.Contractor_Id
                });
                
            }

            reportService.GetPaymentsReport(invoices, reportInvoisesDto, beginCredit);

            splashScreenManager.CloseWaitForm();

        }

        //private void accountingInvoicesGridView_CustomDrawFilterPanel(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawObjectEventArgs e)
        //{
        //    int k = 0;
        //}

        private void accountingInvoicesGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            CriteriaOperator op = accountingInvoicesGridView.ActiveFilterCriteria;
            if (op == null)
            {
                ShowInGridByFilter();
            }

            
        }

        private void periodBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (periodService.CheckPeriodTaxInvoicesAccess(beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                        model.StateTaxInvoices = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (periodService.CheckPeriodTaxInvoicesExist(beginDate))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(beginDate.Year, beginDate.Month);
                            model.StateTaxInvoices = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else if (MessageBox.Show("Вказаного періода не існує в системі! Додати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = beginDate.Year,
                                Month = beginDate.Month,
                                State = false,
                                StateBank = false,
                                StateBusinesTrip = false,
                                StateTaxInvoices = true
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

        private void beginMonthEditItem_EditValueChanged(object sender, EventArgs e)
        {
            //beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            //repositoryFilterMonthLookUpEdit.Dispose();
            //ShowInGridByFilter();

        }

        private void monthDataExportToXlsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            splashScreenManager.ShowWaitForm();
            if (accountingInvoicesBS.Count != 0)
            {
                int? currentMonth = null;

                reportService = Program.kernel.Get<IReportService>();
                try
                {
                    currentMonth = ((MonthDetailsDTO)repositoryItemGridLookUpEdit.GetRowByKeyValue((int?)monthFilterGridEdit.EditValue)).NumberMonth;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не обрано номер місяця", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    splashScreenManager.CloseWaitForm();
                    return;
                }
               

                //reportService.PrintAccountingInvoices(ViewToDataTable());
                reportService.PrintAccountingInvoices(invoicesInfoList, currentMonth);
            }
            splashScreenManager.CloseWaitForm();

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
       #endregion
}