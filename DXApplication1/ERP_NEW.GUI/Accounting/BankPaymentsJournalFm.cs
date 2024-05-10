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
using ERP_NEW.BLL.Infrastructure;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using System.Reflection;
using System.Collections;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using ERP_NEW.BLL.DTO.ReportsDTO;
using ERP_NEW.GUI.Classifiers;
using System.Runtime.InteropServices;
//[DllImport(«user32.dll», CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

namespace ERP_NEW.GUI.Accounting
{
    public partial class BankPaymentsJournalFm : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("User32.dll")]
        public static extern void mouse_event(ERP_NEW.BLL.Infrastructure.Utils.MouseEvent dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        //[DllImport("User32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //[DllImport(user32.dll, ]
        //public static extern void mouse_event(ERP_NEW.BLL.Infrastructure.Utils.MouseEvent dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();

        private const string NameForm = "BankPaymentsJournalFm";

        private IBankPaymentsService bankPaymentsService;
        private IPeriodService periodService;
        private IReportService reportService;
        private IAccountsService accountsService;
        private IBusinessTripsService businessTripsService;
        private ILogService logService;

        private BindingSource bankPaymentsBS = new BindingSource();
        
        private UserTasksDTO _userTasksDTO;
        private DateTime _beginDate;
        private DateTime _endDate;

        private decimal debitPrice = 0.00m;
        private decimal debitPriceCurrency = 0.00m;
        private decimal creditPrice = 0.00m;
        private decimal creditPriceCurrency = 0.00m;
        private decimal vatPrice = 0.00m;
        private int rowId = 0;

        public BankPaymentsJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();



            _userTasksDTO = userTasksDTO;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            _beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            _endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginReportDateEdit.EditValue = _beginDate;
            endReportDateEdit.EditValue = _endDate;

            AuthorizatedUserAccess();

            LoadDataByPeriod(_beginDate, _endDate);

            accountsService = Program.kernel.Get<IAccountsService>();
            bankAccountRepository.DataSource = accountsService.GetBankPaymentAccounts();
            bankAccountRepository.ValueMember = "Id";
            bankAccountRepository.DisplayMember = "Num";

            LoadColorsPallete();
        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            periodBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            logService = Program.kernel.Get<ILogService>();

            bankPaymentsBS.DataSource = bankPaymentsService.GetBankPaymentsJournal(_beginDate, _endDate);
            bankPaymentsGrid.DataSource = bankPaymentsBS;

            SetPeriodBtnImage();

            splashScreenManager.CloseWaitForm();
        }

        private void SetPeriodBtnImage()
        {
            if (CheckPeriodAccess(_beginDate))
            {
                periodBtn.Glyph = imageCollection.Images[1];
                periodBtn.LargeGlyph = imageCollection.Images[1];
                periodBtn.Caption = "Закрити період";
            }
            else
            {
                periodBtn.Glyph = imageCollection.Images[0];
                periodBtn.LargeGlyph = imageCollection.Images[0];
                periodBtn.Caption = "Відкрити період";
            }

        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBank);
        }

        private bool CheckPeriodExist(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }

        private void EditBankPayment(Utils.Operation operation, Bank_PaymentsDTO model)
        {
            using (BankPaymentEditFm bankPaymentEditFm = new BankPaymentEditFm(operation, model, _userTasksDTO))
            {
                if (bankPaymentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bank_PaymentsDTO returnItem = bankPaymentEditFm.Return();
                    bankPaymentsGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);

                    bankPaymentsGridView.EndDataUpdate();

                    int rowHandle = bankPaymentsGridView.LocateByValue("Id", returnItem.Id);

                    bankPaymentsGridView.FocusedRowHandle = rowHandle;
                }
            }
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

        private void LoadColorsPallete()
        {
            splashScreenManager.ShowWaitForm();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            colorsPallete = businessTripsService.GetColors().ToList();


            for (int i = contextMenuStrip.Items.Count; i >2; i--)
			{
                contextMenuStrip.Items.RemoveAt(i-1);
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
        
        #endregion

        #region Event's
        
        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditBankPayment(Utils.Operation.Add, new Bank_PaymentsDTO() { UserId = _userTasksDTO.UserId });
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankPaymentsBS.Count > 0)
            {
                BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentsBS.Current;
                Bank_PaymentsDTO model = new Bank_PaymentsDTO()
                {
                    Id = item.Id,
                    Bank_Account_Id = item.Bank_Account_Id,
                    Contractor_Id = item.Contractor_Id,
                    CurrencyId = item.CurrencyId,
                    CurrencyRatesConvertId = item.CurrencyRatesConvertId,
                    DateCreate = item.DateCreate,
                    DateUpdate = item.DateUpdate,
                    Direction = item.Direction,
                    EmployeesId = item.EmployeesId,
                    Payment_Date = item.Payment_Date,
                    Payment_Document = item.Payment_Document,
                    Payment_Price = item.Payment_Price ?? 0.00m,
                    Payment_PriceCurrency = item.Payment_PriceCurrency ?? 0.00m,
                    Purpose = item.Purpose,
                    Purpose_Account_Id = item.Purpose_Account_Id,
                    Rate = item.Rate ?? 0.000000m,
                    VatAccountId = item.VatAccountId,
                    VatPrice = item.VatPrice ?? 0.00m,
                    UserId = _userTasksDTO.UserId,
                    AccountingOperationId = item.AccountingOperationId,
                    ColorId = item.ColorId
                };

                EditBankPayment(Utils.Operation.Update, model);
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankPaymentsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити документ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
                    int rowHandle = bankPaymentsGridView.FocusedRowHandle - 1;
                    bankPaymentsGridView.BeginDataUpdate();
                    bankPaymentsService.BankPaymentDelete(((BankPaymentsInfoDTO)bankPaymentsBS.Current).Id);
                    LoadDataByPeriod(_beginDate, _endDate);
                    bankPaymentsGridView.EndDataUpdate();
                    bankPaymentsGridView.FocusedRowHandle = (bankPaymentsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void periodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (CheckPeriodAccess(_beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(_beginDate.Year, _beginDate.Month);
                        model.StateBank = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (CheckPeriodExist(_beginDate))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(_beginDate.Year, _beginDate.Month);
                            model.StateBank = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = _beginDate.Year,
                                Month = _beginDate.Month,
                                State = false,
                                StateBank = true,
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
                    logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                    return;
                }
            }
        }

        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BankPaymentsImportFm bankPaymentsImportFm = new BankPaymentsImportFm(_userTasksDTO))
            {
                if (bankPaymentsImportFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    bankPaymentsGridView.BeginDataUpdate();
                    LoadDataByPeriod(_beginDate, _endDate);
                    bankPaymentsGridView.EndDataUpdate();
                }
            }
        }

        

        private void excelExportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            splashScreenManager.ShowWaitForm();
            
            CriteriaOperator op = bankPaymentsGridView.ActiveFilterCriteria;
            string filterString = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(op).ToString();

            string replace_string_date = "Convert([Payment_Date], 'System.String') like";
            string replaceable_string_date = "[Payment_Date] like";
            string replace_string_debitprice = "Convert([DebitPrice], 'System.String') like";
            string replaceable_string_debitprice = "[DebitPrice] like";
            string replace_string_debitpricecurrency = "Convert([DebitPriceCurrency], 'System.String') like";
            string replaceable_string_debitpricecurrency = "[DebitPriceCurrency] like";
            string replace_string_creditprice = "Convert([CreditPrice], 'System.String') like";
            string replaceable_string_creditprice = "[CreditPrice] like";
            string replace_string_creditPriceCurrency = "Convert([CreditPriceCurrency], 'System.String') like";
            string replaceable_string_creditPriceCurrency = "[CreditPriceCurrency] like";
            string replace_string_vatprice = "Convert([VatPrice], 'System.String') like";
            string replaceable_string_vatprice = "[VatPrice] like";
            string replace_string_customerorderprice = "Convert([CustomerOrderPrice], 'System.String') like";
            string replaceable_string_customerorderprice = "[CustomerOrderPrice] like";
            string replace_string_customerordercurrencyprice = "Convert([CustomerOrderCurrencyPrice], 'System.String') like";
            string replaceable_string_customerordercurrencyprice = "[CustomerOrderCurrencyPrice] like";



            filterString = filterString.Replace(replaceable_string_date, replace_string_date);
            filterString = filterString.Replace(replaceable_string_debitprice, replace_string_debitprice);
            filterString = filterString.Replace(replaceable_string_debitpricecurrency, replace_string_debitpricecurrency);
            filterString = filterString.Replace(replaceable_string_creditprice, replace_string_creditprice);
            filterString = filterString.Replace(replaceable_string_creditPriceCurrency, replace_string_creditPriceCurrency);
            filterString = filterString.Replace(replaceable_string_vatprice, replace_string_vatprice);
            filterString = filterString.Replace(replaceable_string_customerorderprice, replace_string_customerorderprice);
            filterString = filterString.Replace(replaceable_string_customerordercurrencyprice, replace_string_customerordercurrencyprice);



            IEnumerable<BankPaymentsInfoDTO> lst = (IEnumerable<BankPaymentsInfoDTO>)bankPaymentsBS.DataSource;
            DataTable dt = ToDataTable<BankPaymentsInfoDTO>(lst);
            DataView dv = new DataView(dt);

            List<BankPaymentsInfoDTO> rows = new List<BankPaymentsInfoDTO>();
            
            dv.RowFilter = string.Format(filterString);
            
            DataTable table = dv.ToTable();
                        
            List<BankPaymentsInfoDTO> bankPaymentinfo = (from DataRow row in table.Rows

                               select new BankPaymentsInfoDTO
                               {
                                   Contractor_Id = (row["Contractor_Id"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["Contractor_Id"]),
                                   VatAccountNum = Convert.ToString(row["VatAccountNum"]),
                                   VatPrice = (row["VatPrice"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["VatPrice"]),
                                   PartnerSrn = Convert.ToString(row["PartnerSrn"]),
                                   OrderNumber = Convert.ToString(row["OrderNumber"]),
                                   PartnerName = Convert.ToString(row["PartnerName"]),
                                   Payment_Date = Convert.ToDateTime(row["Payment_Date"]),
                                   Payment_Document = Convert.ToString(row["Payment_Document"]),
                                   BankAccountNum = Convert.ToString(row["BankAccountNum"]),
                                   PurposeAccountNum = Convert.ToString(row["PurposeAccountNum"]),
                                   DebitPrice = (row["DebitPrice"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["DebitPrice"]),
                                   DebitPriceCurrency = (row["DebitPriceCurrency"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["DebitPriceCurrency"]),
                                   CreditPrice = (row["CreditPrice"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["CreditPrice"]),
                                   CreditPriceCurrency = (row["CreditPriceCurrency"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["CreditPriceCurrency"]),
                                   CurrencyName = Convert.ToString(row["CurrencyName"]),
                                   CustomerOrderId = (row["CustomerOrderId"] is System.DBNull) ? (int?)0 : Convert.ToInt32(row["CustomerOrderId"]),
                                   CustomerOrderPrice = (row["CustomerOrderPrice"] is System.DBNull) ? (Decimal)0.00m : Convert.ToDecimal(row["CustomerOrderPrice"]),
                                   Rate = (row["Rate"] is System.DBNull) ? (Decimal?)0.00m : Convert.ToDecimal(row["Rate"]),
                                   Id = Convert.ToInt32(row["Id"]),
                                   Purpose = Convert.ToString(row["Purpose"])

                               }).ToList();

            reportService = Program.kernel.Get<IReportService>();

            reportService.GetExportPaymentsList(bankPaymentinfo, _beginDate, _endDate);

            splashScreenManager.CloseWaitForm();

        }
                
        private void bankPaymentsGridView_DoubleClick(object sender, EventArgs e)
        {
            if (bankPaymentsBS.Count > 0 && _userTasksDTO.AccessRightId == 2)
            {
                BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentsBS.Current;
                Bank_PaymentsDTO model = new Bank_PaymentsDTO()
                {
                    Id = item.Id,
                    Bank_Account_Id = item.Bank_Account_Id,
                    Contractor_Id = item.Contractor_Id,
                    CurrencyId = item.CurrencyId,
                    CurrencyRatesConvertId = item.CurrencyRatesConvertId,
                    DateCreate = item.DateCreate,
                    DateUpdate = item.DateUpdate,
                    Direction = item.Direction,
                    EmployeesId = item.EmployeesId,
                    Payment_Date = item.Payment_Date,
                    Payment_Document = item.Payment_Document,
                    Payment_Price = item.Payment_Price ?? 0.00m,
                    Payment_PriceCurrency = item.Payment_PriceCurrency ?? 0.00m,
                    Purpose = item.Purpose,
                    Purpose_Account_Id = item.Purpose_Account_Id,
                    Rate = item.Rate ?? 0.000000m,
                    VatAccountId = item.VatAccountId,
                    VatPrice = item.VatPrice ?? 0.00m,
                    UserId = _userTasksDTO.UserId,
                    AccountingOperationId = item.AccountingOperationId
                };

                EditBankPayment(Utils.Operation.Update, model);
            }
        }

        private void bankPaymentsGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentsGridView.GetRow(e.RowHandle);
                if (item.CurrencyRatesConvertId != null)
                    e.Appearance.BackColor = Color.PaleTurquoise;

                if (item.ColorId != null)
                        e.Appearance.BackColor = Color.FromName(item.ColorName.ToString());
                

            }
        }

        private void bankPaymentsGridView_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            BankPaymentsInfoDTO model1 = (BankPaymentsInfoDTO)view.GetRow(e.RowHandle1);
            BankPaymentsInfoDTO model2 = (BankPaymentsInfoDTO)view.GetRow(e.RowHandle2);

            

            if (e.Column.FieldName != "OrderNumber" && e.Column.FieldName != "CustomerOrderPrice" && e.Column.FieldName != "CustomerOrderCurrencyPrice")
            {
                e.Merge = (model1.Id == model2.Id);
                e.Handled = true;
            }
        }

        private void bankPaymentsGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            int itemId = 0;

            if (e.IsTotalSummary)
            {
                GridView view = sender as GridView;
                string fieldName = ((GridSummaryItem)e.Item).FieldName;

                switch (e.SummaryProcess)
                {
                    //calculation entry point 
                    case CustomSummaryProcess.Start:
                        rowId = 0;
                        debitPrice = 0;
                        creditPrice = 0;
                        debitPriceCurrency = 0;
                        creditPriceCurrency = 0;
                        vatPrice = 0;
                        break;
                    //consequent calculations 
                    case CustomSummaryProcess.Calculate:
                        itemId = ((BankPaymentsInfoDTO)view.GetRow(e.RowHandle)).Id;

                        if (itemId != rowId)
                        {
                            rowId = itemId;

                            if (fieldName == "DebitPrice")
                                debitPrice += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "DebitPriceCurrency")
                                debitPriceCurrency += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "CreditPrice")
                                creditPrice += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "CreditPriceCurrency")
                                creditPriceCurrency += Convert.ToDecimal(e.FieldValue);

                            if (fieldName == "VatPrice")
                                vatPrice += Convert.ToDecimal(e.FieldValue);
                        }
                        break;
                    //final summary value 
                    case CustomSummaryProcess.Finalize:

                        if (fieldName == "DebitPrice")
                            e.TotalValue = debitPrice;

                        if (fieldName == "DebitPriceCurrency")
                            e.TotalValue = debitPriceCurrency;

                        if (fieldName == "CreditPrice")
                            e.TotalValue = creditPrice;

                        if (fieldName == "CreditPriceCurrency")
                            e.TotalValue = creditPriceCurrency;

                        if (fieldName == "VatPrice")
                            e.TotalValue = vatPrice;

                        break;
                }
            }
        }

        private void addTemplateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bank_PaymentsDTO tempItem = new Bank_PaymentsDTO()
            {
                AccountingOperationId = 1,
                Bank_Account_Id = 24,
                Contractor_Id = -1,
                CurrencyId = 1,
                DateCreate = DateTime.Now,
                DateUpdate = DateTime.Now,
                Payment_Date = DateTime.Now,
                Payment_Document = DateTime.Now.ToString("ddMM"),
                Payment_Price = 0.00m,
                Payment_PriceCurrency = 0.00m,
                Purpose = "Послуга їдальні",
                Purpose_Account_Id = 86,
                Rate = 0.00m,
                UserId = _userTasksDTO.UserId,
                VatAccountId = 38,
                VatPrice = 0.00m
            };

            EditBankPayment(Utils.Operation.Custom, tempItem);
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bankPaymentsBS.Count > 0)
            {
                BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentsBS.Current;
                Bank_PaymentsDTO model = new Bank_PaymentsDTO()
                {
                    Bank_Account_Id = item.Bank_Account_Id,
                    Contractor_Id = item.Contractor_Id,
                    CurrencyId = item.CurrencyId,
                    CurrencyRatesConvertId = item.CurrencyRatesConvertId,
                    DateCreate = item.DateCreate,
                    DateUpdate = item.DateUpdate,
                    Direction = item.Direction,
                    EmployeesId = item.EmployeesId,
                    Payment_Date = item.Payment_Date,
                    Payment_Document = item.Payment_Document,
                    Payment_Price = item.Payment_Price ?? 0.00m,
                    Payment_PriceCurrency = item.Payment_PriceCurrency ?? 0.00m,
                    Purpose = item.Purpose,
                    Purpose_Account_Id = item.Purpose_Account_Id,
                    Rate = item.Rate ?? 0.000000m,
                    VatAccountId = item.VatAccountId,
                    VatPrice = item.VatPrice ?? 0.00m,
                    UserId = _userTasksDTO.UserId,
                    AccountingOperationId = item.AccountingOperationId,
                    ColorId = item.ColorId

                };

                EditBankPayment(Utils.Operation.Template, model);
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (bankPaymentsBS.Count == 0 || bankPaymentsGridView.FocusedRowHandle < 0)
                e.Cancel = true;
        }

        private void bankPaymentsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle > -1)
            {
                //InvoicesDTO item = (InvoicesDTO)accountingInvoicesGridView.GetRow(e.RowHandle);
                //if (item.Color_Id != null)
                //    e.Appearance.BackColor = Color.FromName(item.Color_Name.ToString());
            }
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text != "Копировать" && e.ClickedItem.Text != "Додати колір в палітру")
            {
                ((BankPaymentsInfoDTO)bankPaymentsBS.Current).ColorName = e.ClickedItem.ToolTipText;
                ((BankPaymentsInfoDTO)bankPaymentsBS.Current).ColorId = (int)e.ClickedItem.Tag;

                bankPaymentsBS.EndEdit();
                bankPaymentsBS.CancelEdit();


                BankPaymentsInfoDTO item = (BankPaymentsInfoDTO)bankPaymentsBS.Current;
                Bank_PaymentsDTO model = new Bank_PaymentsDTO()
                {
                    Id = item.Id,
                    Bank_Account_Id = item.Bank_Account_Id,
                    Contractor_Id = item.Contractor_Id,
                    CurrencyId = item.CurrencyId,
                    CurrencyRatesConvertId = item.CurrencyRatesConvertId,
                    DateCreate = item.DateCreate,
                    DateUpdate = item.DateUpdate,
                    Direction = item.Direction,
                    EmployeesId = item.EmployeesId,
                    Payment_Date = item.Payment_Date,
                    Payment_Document = item.Payment_Document,
                    Payment_Price = item.Payment_Price ?? 0.00m,
                    Payment_PriceCurrency = item.Payment_PriceCurrency ?? 0.00m,
                    Purpose = item.Purpose,
                    Purpose_Account_Id = item.Purpose_Account_Id,
                    Rate = item.Rate ?? 0.000000m,
                    VatAccountId = item.VatAccountId,
                    VatPrice = item.VatPrice ?? 0.00m,
                    UserId = _userTasksDTO.UserId,
                    AccountingOperationId = item.AccountingOperationId,
                    ColorId = item.ColorId
                };

                bankPaymentsService.BankPaymentUpdate(model);
            }
        }

        private void bankTrialBalance333ReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBPReportForCustomBill((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 241, "333"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }


        private void addColorToolStripMenuItem_Click(object sender, EventArgs e)
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
               
        #endregion

        #region Report's
        
        private void bankTrialBalanceReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankAccountEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                //string accountNum = bankAccountRepository.GetDisplayText((int)bankAccountEdit.EditValue);

                AccountsDTO item = (AccountsDTO)bankAccountRepository.GetDataSourceRowByKeyValue((int)bankAccountEdit.EditValue);

                if (!reportService.GetBPReportTrialBalance((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, item.Id, item.Num, item.Description))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalance334ReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                
                if (!reportService.GetBPReportForCustomBill((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 79, "334"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalance373ReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBPReportForCustomBill((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 125, "373"))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalanceQurtalReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankAccountEdit.EditValue == null)
            {
                MessageBox.Show("Виберіть балансовий рахунок.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                
                AccountsDTO item = (AccountsDTO)bankAccountRepository.GetDataSourceRowByKeyValue((int)bankAccountEdit.EditValue);

                if (!reportService.GetBPReportTrialBalanceQuarter((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, item.Id, item.Num, item.Description))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        private void bankTrialBalanceFullReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBPReportTrialBalanceFull((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }


        private void bankTrialBalance313ReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                accountsService = Program.kernel.Get<IAccountsService>();

                List<AccountsDTO> allAccounts313 = accountsService.GetAccounts().Where(bdsm => bdsm.Num.Contains("313") && bdsm.Num.Length > 6).ToList();

                List<BankPaymentsReportTrialBalanceAll313DTO> trialBalanceShortAcount313 = new List<BankPaymentsReportTrialBalanceAll313DTO>();

                for (int i = 0; i < allAccounts313.Count; ++i)
                {
                    reportService = Program.kernel.Get<IReportService>();

                    List<BankPaymentsReportTrialBalanceAll313DTO> bufferList = reportService.GetBPReportTrialBalanceShort((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, allAccounts313[i].Id);

                    for (int j = 0; j < bufferList.Count; ++j)
                    {

                        bufferList[j].RecId = i + j;
                        trialBalanceShortAcount313.Add(bufferList[j]);
                    }

                }

                reportService.PrintBPReportTrialBalanceShortAllAccount313(trialBalanceShortAcount313, (DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue);

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, _userTasksDTO, NameForm);
                splashScreenManager.CloseWaitForm();

                return;
            }
        }

        #endregion

        private void addTemplateKursBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bank_PaymentsDTO tempItem = new Bank_PaymentsDTO()
            {
                AccountingOperationId = 1,
                Bank_Account_Id = 24,
                Contractor_Id = -1,
                CurrencyId = 1,
                DateCreate = DateTime.Now,
                DateUpdate = DateTime.Now,
                Payment_Date = DateTime.Now,
                Payment_Document = "Курс",
                Payment_Price = 0.00m,
                Payment_PriceCurrency = 0.00m,
                Purpose = "Курсова різниця",
                Purpose_Account_Id = 41,
                Rate = 0.00m,
                UserId = _userTasksDTO.UserId,
                VatAccountId = null,
                VatPrice = 0.00m
            };

            EditBankPayment(Utils.Operation.Info, tempItem);
        }

        private void addTemplateCorrect644Btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bank_PaymentsDTO tempItem = new Bank_PaymentsDTO()
            {
                AccountingOperationId = 1,
                Bank_Account_Id = 26,
                Contractor_Id = -1,
                CurrencyId = 1,
                DateCreate = DateTime.Now,
                DateUpdate = DateTime.Now,
                Payment_Date = new DateTime(2021, 12, 01),
                Payment_Document = "644",
                Payment_Price = 0.00m,
                Payment_PriceCurrency = 0.00m,
                Purpose = "Корегування 644",
                Purpose_Account_Id = 26,
                Rate = 0.00m,
                UserId = _userTasksDTO.UserId,
                VatPrice = 0.00m,
                ColorId = 16
            };

            EditBankPayment(Utils.Operation.Info, tempItem);
        }
    }

    
}