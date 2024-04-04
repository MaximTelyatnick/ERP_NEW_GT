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
using Spire.Pdf.Exporting.XPS.Schema;
using DevExpress.XtraGrid.Views.Grid;





namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsPaymentJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private IAccountsService accountsService;
        private IBusinessTripsService businessTripsService;
        private ICustomerOrdersService customerOrdersService;
        private IReportService reportService;
        private IPeriodService periodService;
        
        private BindingSource businessTripsBS = new BindingSource();
        private BindingSource prepaymentsBS = new BindingSource();
        private BindingSource paymentsBS = new BindingSource();

        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();
        private List<BusinessTripsOrderCustDTO> businessTripsCustOrderList = new List<BusinessTripsOrderCustDTO>();

        private UserTasksDTO _userTasksDTO;
        private DateTime _beginDate;
        private DateTime _endDate;

        private LoggerInfo logg = new LoggerInfo();
        

        public BusinessTripsPaymentJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            
            
      

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            //splashScreenManager.ShowWaitForm();

            _userTasksDTO = userTasksDTO;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;

            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            paymentStatementDateEdit.EditValue = DateTime.Now;

            _beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            _endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginReportDateEdit.EditValue = _beginDate;
            endReportDateEdit.EditValue = _endDate;

            saldoDebitEdit.DataBindings.Add("EditValue", businessTripsBS, "SaldoDebit");
            saldoCreditEdit.DataBindings.Add("EditValue", businessTripsBS, "SaldoCredit");

            AuthorizatedUserAccess();

            LoadColorsPallete();

            LoadDataByPeriod(_beginDate, _endDate);

            repositoryItemGridLookUpEdit.DataSource = customerOrdersService.GetCustomerOrders(); 
            repositoryItemGridLookUpEdit.ValueMember = "Id";
            repositoryItemGridLookUpEdit.DisplayMember = "OrderNumber";
            //repositoryItemGridLookUpEdit.Properties.NullText = "Немає данних";

            //splashScreenManager.CloseWaitForm();

            //MergedRowsHelper helper = new MergedRowsHelper();
            //helper.Register(businessTripsGridView);
        }

        #region Method's                                           

        private void AuthorizatedUserAccess()
        {
            addPrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editPrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deletePrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addTemplatePrepaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addPaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editPaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deletePaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addTemplatePaymentBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            var fdf = businessTripsService.GetBusinessTripsPrepaymentJournalByPeriod(_beginDate, _endDate);
            businessTripsBS.DataSource = fdf;
            За.DataSource = businessTripsBS;

            if (businessTripsBS.Count > 0)
            {
                LoadPrepaymentDateByBTDId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsDetailsID);
                LoadPaymentDateByBTDId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsDetailsID);
            }
            else
            {
                prepaymentsBS.DataSource = null;
                paymentsBS.DataSource = null;
            }

            SetPeriodBtnImage();

            saldoCaption.Caption = "Сальдо на " + DateTime.Today.ToShortDateString();

            splashScreenManager.CloseWaitForm();
        }

        private void LoadColorsPallete()
        {
            splashScreenManager.ShowWaitForm();

            colorsPallete = businessTripsService.GetColors().ToList();
            for (int i = 0; i < colorsPallete.Count; i++)
            {
                ToolStripMenuItem MenuItem = new ToolStripMenuItem()
                {
                    Text = colorsPallete[i].Name_Rus.ToString(),
                    Image = Rgb2Bitmap(colorsPallete[i].Color_Code.ToString()),
                    ToolTipText = colorsPallete[i].Name.ToString(),
                    Tag = colorsPallete[i].Id
                };
                colorContextMenu.Items.Add(MenuItem);
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

        private void LoadPrepaymentDateByBTDId(int btdId)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            prepaymentsBS.DataSource = businessTripsService.GetBusinessTripsPrepaymentList(btdId);
            prepaymentsGrid.DataSource = prepaymentsBS;
        }

        private void LoadPaymentDateByBTDId(int btdId)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            paymentsBS.DataSource = businessTripsService.GetBusinessTripsPaymentList(btdId);
            paymentsGrid.DataSource = paymentsBS;
        }

        private void EditPrepayment(Utils.Operation operation, BusinessTripsPrepaymentDTO model, BusinessTripsPrepaymentJournalDTO currentModel)
        {
            if (!CheckPeriodAccess(_beginDate))
            {
                MessageBox.Show("Період закритий або не існує!", "Редагування авансу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (BusinessTripsPrepaymentEditFm businessTripsPrepaymentEditFm = new BusinessTripsPrepaymentEditFm(operation, model, currentModel))
            {
                if (businessTripsPrepaymentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BusinessTripsPrepaymentDTO return_Id = businessTripsPrepaymentEditFm.Return();
                    prepaymentsGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);

                    prepaymentsGridView.EndDataUpdate();

                    int rowHandle = prepaymentsGridView.LocateByValue("ID", return_Id.ID);

                    prepaymentsGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

        private void EditPayment(Utils.Operation operation, BusinessTripsPaymentDTO model, BusinessTripsPrepaymentJournalDTO currentModel)
        {
            if (!CheckPeriodAccess(_beginDate))
            {
                MessageBox.Show("Період закритий або не існує!", "Редагування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (BusinessTripsPaymentEditFm businessTripsPaymentEditFm = new BusinessTripsPaymentEditFm(operation, model, currentModel))
            {
                if (businessTripsPaymentEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    BusinessTripsPaymentDTO return_Id = businessTripsPaymentEditFm.Return();
                    paymentsGridView.BeginDataUpdate();

                    LoadDataByPeriod(_beginDate, _endDate);

                    paymentsGridView.EndDataUpdate();

                    int rowHandle = paymentsGridView.LocateByValue("ID", return_Id.ID);

                    paymentsGridView.FocusedRowHandle = rowHandle;
                }
            }
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

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBusinesTrip);
        }

        private bool CheckPeriodExist(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }

        #endregion

        #region Event's                                            

        private void addPrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();   
            if(businessTripsBS.Count > 0)
                EditPrepayment(Utils.Operation.Add, new BusinessTripsPrepaymentDTO(), (BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current);
           
        }

        private void editPrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (prepaymentsBS.Count > 0)
                EditPrepayment(Utils.Operation.Update, (BusinessTripsPrepaymentDTO)prepaymentsBS.Current, (BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current);
        }

        private void deletePrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            prepaymentsGridView.PostEditor();

            if (!((List<BusinessTripsPrepaymentDTO>)prepaymentsBS.DataSource).Any(c => c.Selected))
                return;

            if (!CheckPeriodAccess(_beginDate))
            {
                MessageBox.Show("Період закритий або не існує!", "Видалення авансу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Ви впевнені що бажаєте видалити елементи?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    List<BusinessTripsPrepaymentDTO> list = (List<BusinessTripsPrepaymentDTO>)prepaymentsBS.DataSource;

                    var checkItems = list.Where(l => l.Selected).ToList();
                                        
                    prepaymentsGridView.BeginDataUpdate();

                    businessTripsService.BusinessTripPrepaymentRemoveRange(checkItems);

                    LoadDataByPeriod(_beginDate, _endDate);
                    
                    prepaymentsGridView.EndDataUpdate();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення авансу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addTemplatePrepaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (businessTripsBS.Count > 0)
            {
                using (BusinessTripsPrepaymentTemplateFm businessTripsPrepaymentTemplateFm = new BusinessTripsPrepaymentTemplateFm((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current))
                {
                    if (businessTripsPrepaymentTemplateFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        prepaymentsGridView.BeginDataUpdate();

                        _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                        _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

                        LoadDataByPeriod(_beginDate, _endDate);

                        prepaymentsGridView.EndDataUpdate();
                    }
                }
            }
        }

        private void addPaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (businessTripsBS.Count > 0)
            {
                DateTime defaultDate = (paymentsBS.Count > 0) ?
                    ((List<BusinessTripsPaymentDTO>)paymentsBS.DataSource)[0].Payment_Date :
                    DateTime.Now;

                EditPayment(Utils.Operation.Add, new BusinessTripsPaymentDTO() { Payment_Date = defaultDate}, (BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current);
            }
        }

        private void editPaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (paymentsBS.Count > 0)
                EditPayment(Utils.Operation.Update, (BusinessTripsPaymentDTO)paymentsBS.Current, (BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current);
        }

        private void deletePaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            paymentsGridView.PostEditor();

            if (!((List<BusinessTripsPaymentDTO>)paymentsBS.DataSource).Any(c => c.Selected))
                return;

            if (!CheckPeriodAccess(_beginDate))
            {
                MessageBox.Show("Період закритий або не існує!", "Видалення звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Ви впевнені що бажаєте видалити елементи?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    List<BusinessTripsPaymentDTO> list = (List<BusinessTripsPaymentDTO>)paymentsBS.DataSource;

                    var checkItems = list.Where(l => l.Selected).ToList();

                    paymentsGridView.BeginDataUpdate();

                    businessTripsService.BusinessTripPaymentRemoveRange(checkItems);

                    LoadDataByPeriod(_beginDate, _endDate);
                    
                    paymentsGridView.EndDataUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення звіту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addTemplatePaymentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (businessTripsBS.Count > 0)
            {
                using (BusinessTripsPaymentTemplateFm businessTripsPaymentTemplateFm = new BusinessTripsPaymentTemplateFm((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current))
                {
                    if (businessTripsPaymentTemplateFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        paymentsGridView.BeginDataUpdate();

                        _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
                        _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

                        LoadDataByPeriod(_beginDate, _endDate);

                        paymentsGridView.EndDataUpdate();
                    }
                }
            }
        }

        private void paymentsGridView_DoubleClick(object sender, EventArgs e)
        {
            logg.Info();
            if (_userTasksDTO.AccessRightId == 1)
                return;

            if (businessTripsBS.Count > 0)
                EditPayment(Utils.Operation.Update, (BusinessTripsPaymentDTO)paymentsBS.Current, (BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current);
        }
        
        private void prepaymentsGridView_DoubleClick(object sender, EventArgs e)
        {
            logg.Info();
            if (_userTasksDTO.AccessRightId == 1)
                return;

            if (businessTripsBS.Count > 0)
                EditPrepayment(Utils.Operation.Update, (BusinessTripsPrepaymentDTO)prepaymentsBS.Current, (BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current);
        }
        
        private void businessTripsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //if (businessTripsBS.Count > 0)
            //{
            //    LoadPrepaymentDateByBTDId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsDetailsID);
            //    LoadPaymentDateByBTDId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsDetailsID);
            //}

            var model = (BusinessTripsPrepaymentJournalDTO)businessTripsGridView.GetRow(e.FocusedRowHandle) ?? null;

            if (model != null)
            {
                    LoadPrepaymentDateByBTDId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsDetailsID);
                    LoadPaymentDateByBTDId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsDetailsID);
            }
        }

        private void periodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    periodService = Program.kernel.Get<IPeriodService>();

                    if (CheckPeriodAccess(_beginDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(_beginDate.Year, _beginDate.Month);
                        model.StateBusinesTrip = false;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        if (CheckPeriodExist(_beginDate))
                        {
                            PeriodsDTO model = periodService.GetPeriodByKey(_beginDate.Year, _beginDate.Month);
                            model.StateBusinesTrip = true;

                            periodService.PeriodsUpdate(model);
                        }
                        else
                        {
                            PeriodsDTO model = new PeriodsDTO()
                            {
                                Year = _beginDate.Year,
                                Month = _beginDate.Month,
                                State = false,
                                StateBank = false,
                                StateBusinesTrip = true
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

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();

            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void refreshBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            _beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            _endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);

            LoadDataByPeriod(_beginDate, _endDate);
        }

        private void customerOrderEditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (businessTripsBS.Count > 0)
            {
                businessTripsService = Program.kernel.Get<IBusinessTripsService>();

                BusinessTripsDTO model = businessTripsService.GetBusinessTripsId(((BusinessTripsPrepaymentJournalDTO)businessTripsBS.Current).BusinessTripsID);

                using (BusinessTripsCustomerOrderEditFm businessTripsCustomerOrderEditFm = new BusinessTripsCustomerOrderEditFm(model, _userTasksDTO))
                {
                    if (businessTripsCustomerOrderEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //splashScreenManager.ShowWaitForm();

                        BusinessTripsDTO returnModel = businessTripsCustomerOrderEditFm.Return();

                        businessTripsGridView.PostEditor();

                        businessTripsGridView.BeginDataUpdate();

                        LoadDataByPeriod(_beginDate, _endDate);

                        int rowHandle = businessTripsGridView.LocateByValue("BusinessTripsID", returnModel.ID);

                        businessTripsGridView.EndDataUpdate();

                        businessTripsGridView.FocusedRowHandle = rowHandle;

                        //splashScreenManager.CloseWaitForm();
                    }
                }
            }
        }


        private void markedBusinessTripsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            if (prepaymentsBS.Count > 0)
            {
                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                BusinessTripsPrepaymentDTO model = businessTripsService.GetBusinessTripsPrepaymentGetId(((BusinessTripsPrepaymentDTO)prepaymentsBS.Current).ID);

                if (model.Check == false || model.Check == null)
                {
                    if (MessageBox.Show("Ви впевнені що бажаєте поставити мітку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        model.Check = true;
                        businessTripsService.BusinessTripsPrepaymentUpdate(model);
                        LoadDataByPeriod(_beginDate, _endDate);
                    }
                }
                else
                {
                    if (MessageBox.Show("Ви впевнені що бажаєте видалити мітку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        model.Check = false;
                        businessTripsService.BusinessTripsPrepaymentUpdate(model);
                        LoadDataByPeriod(_beginDate, _endDate);
                    }
                }
            }
                }
            //    else
            //    {
            //        if (MessageBox.Show("Ви впевнені що бажаєте видалити мітку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            model.Check = false;
            //            businessTripsService.BusinessTripsPrepaymentUpdate(model);
            //            LoadDataByPeriod(_beginDate, _endDate);
            //        }
            //    }
            //}
            //else
            //    MessageBox.Show("Відсутні аванси у відрядженої персони. ", "Інформація", MessageBoxButtons.OK);
        

        private void businessTripsGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //if (e.RowHandle > -1)
            //{
            //    BusinessTripsPrepaymentJournalDTO item = (BusinessTripsPrepaymentJournalDTO)businessTripsGridView.GetRow(e.RowHandle);
            //    if (item.Check == true)
            //        e.Appearance.BackColor = Color.PaleTurquoise;

                
            //}


        }

        private void prepaymentsGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
           BusinessTripsPrepaymentDTO item = (BusinessTripsPrepaymentDTO)prepaymentsGridView.GetRow(e.RowHandle);

            if (item != null)
            {
                if (item.Check == true)
                    e.Appearance.BackColor = Color.PaleTurquoise;
            }
        }

        private void businessTripsGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            BusinessTripsPrepaymentJournalDTO item = (BusinessTripsPrepaymentJournalDTO)businessTripsGridView.GetRow(e.RowHandle);

            if (item != null)
            {
                if (item.Check == true)
                    e.Appearance.BackColor = Color.PaleTurquoise;
            }
        }



        #endregion

        #region Report event's

        private void bstOSVReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportByAccounts((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
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

        private void bstCurrencyPeriodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportCurrencyPeriod((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
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

        private void bstDocumentsReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportDocumentsPeriod((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
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

        private void bstEmployeesReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportEmployeesByPeriod((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
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
        
        private void bstReportPaymentsBy23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByAccountId((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 18,"23"))
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

        private void bstReportPaymentsBy63_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPrepaymentsByAccountId((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 16, "63"))
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
        
        private void bstReportPaymentsBy6412_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByVatAccountId((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 38, "641.2"))
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
        
        private void bstPaymentsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByPeriod((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
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


        private void bstReportPaymentsBy313_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPrepaymentsSumByAccount313((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue))
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

        private void bstReportPaymentsBy3112_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPrepaymentsSumByAccountShort((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 49, "311_2".ToString()))
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

        #endregion

        private void paymentStatementBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            using (BusinessTripsStatementPaymentSelectFm businessTripsStatementPaymentSelectFm = new BusinessTripsStatementPaymentSelectFm((DateTime)paymentStatementDateEdit.EditValue, (DateTime)paymentStatementDateEdit.EditValue))
            {
                if (businessTripsStatementPaymentSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //CalcWithBuyersDTO returnItem = calcWithBuyersEditFm.Return();
                    //calcWithBuyersGridView.BeginDataUpdate();

                    //LoadDataByPeriod(_beginDate, _endDate);

                    //calcWithBuyersGridView.EndDataUpdate();

                    //int rowHandle = calcWithBuyersGridView.LocateByValue("Id", returnItem.Id);

                    //calcWithBuyersGridView.FocusedRowHandle = rowHandle;

                }

            }
        }

        private void businessTripsGridView_CellMerge(object sender, CellMergeEventArgs e)
        {
          
            GridView view = sender as GridView;
            BusinessTripsPrepaymentJournalDTO model1 = (BusinessTripsPrepaymentJournalDTO)view.GetRow(e.RowHandle1);
            BusinessTripsPrepaymentJournalDTO model2 = (BusinessTripsPrepaymentJournalDTO)view.GetRow(e.RowHandle2);

            if (e.Column.FieldName != "CustomerOrderNumber")
            {
                e.Merge = (model1.BusinessTripsID == model2.BusinessTripsID);
                e.Handled = true;
            }
        }

        private void businessTripsGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {

        }

        private void businessTripsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
           
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
                e.Appearance.BackColor = Color.Lavender;
        }

        private void prepaymentsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
          
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
                e.Appearance.BackColor = Color.Lavender;
        }

        private void paymentsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
          
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
                e.Appearance.BackColor = Color.Lavender;
        }

        private void editPaymantAccountBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logg.Info();
            paymentsGridView.PostEditor();

            if (!((List<BusinessTripsPaymentDTO>)paymentsBS.DataSource).Any(c => c.Selected))
                return;

            if (!CheckPeriodAccess(_beginDate))
            {
                MessageBox.Show("Період закритий або не існує!", "Редагування рахунку", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                List<BusinessTripsPaymentDTO> list = (List<BusinessTripsPaymentDTO>)paymentsBS.DataSource;

                var checkItems = list.Where(l => l.Selected).ToList();

                using (BusinessTripsPaymentSelectAccountEditFm businessTripsPaymentSelectAccountEditFm = new BusinessTripsPaymentSelectAccountEditFm((List<BusinessTripsPaymentDTO>)checkItems))
                {
                    if (businessTripsPaymentSelectAccountEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //paymentsGridView.PostEditor();

                        LoadDataByPeriod(_beginDate, _endDate);

                    }
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення звіту", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bstReportPaymentsBy473_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByAccountId((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 176, "473"))
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

        private void bstReportPaymentsBy474_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                if (!reportService.GetBSTReportPaymentsByAccountId((DateTime)beginReportDateEdit.EditValue, (DateTime)endReportDateEdit.EditValue, 134, "474"))
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

        private void customerOrderAtachEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerOrderEdit.EditValue != null)
            {

                //splashScreenManager.ShowWaitForm();

                businessTripsGridView.PostEditor();

                businessTripsGridView.BeginDataUpdate();

                List<BusinessTripsPrepaymentJournalDTO> businessTripsPrepaymentJournalDTO = (List<BusinessTripsPrepaymentJournalDTO>)businessTripsBS.DataSource;
                var customerOrder = repositoryItemGridLookUpEdit.GetRowByKeyValue((int)customerOrderEdit.EditValue);
                var checkItems = businessTripsPrepaymentJournalDTO.Where(t => t.Check == true);

                //List<BusinessTripsPrepaymentJournalDTO> selectedItem  = ((List<BusinessTripsPrepaymentJournalDTO>)businessTripsBS.DataSource).Where(s => (bool)s.Check == true).ToList();
                if (checkItems.Count() > 0)
                {
                    foreach (var item in checkItems)
                    {
                        BusinessTripsOrderCustDTO businessTripsOrderCustDTO = new BusinessTripsOrderCustDTO()
                        {
                            ID = 0,
                            BusinessTripsId = item.BusinessTripsID,
                            CustomerOrderId = (int)((CustomerOrdersDTO)customerOrder).Id,
                            UserId = _userTasksDTO.UserId
                        };

                        businessTripsService.BusinessTripsOrderCustCreate(businessTripsOrderCustDTO);

                    }

                    LoadDataByPeriod(_beginDate, _endDate);
                }

                else { MessageBox.Show("Не обрано відрядження!"); }


                

                decimal d = 0;

                businessTripsGridView.EndDataUpdate();
            }
            else
            {
                MessageBox.Show("Не обрано співробітника або не додано суму!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }






        //try
        //{
        //    splashScreenManager.ShowWaitForm();

        //    reportService = Program.kernel.Get<IReportService>();

        //    if (!reportService.GetBSTPaymentStatement((DateTime)paymentStatementDateEdit.EditValue, (DateTime)paymentStatementDateEdit.EditValue))
        //        MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    splashScreenManager.CloseWaitForm();
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    splashScreenManager.CloseWaitForm();

        //    return;
        //}
        //}

        //private void businessTripsGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        //{
        //    //if (e.RowHandle > -1)
        //    //{
        //    //    BusinessTripsPrepaymentJournalDTO item = (BusinessTripsPrepaymentJournalDTO)businessTripsGridView.GetRow(e.RowHandle);
        //    //    if (item.Check == true)
        //    //        e.Appearance.BackColor = Color.PaleTurquoise;
        //    //}
        //}

        //private void prepaymentsGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        //{
        //    //if (e.RowHandle > -1)
        //    //{
        //    //    BusinessTripsPrepaymentDTO item = (BusinessTripsPrepaymentDTO)prepaymentsGridView.GetRow(e.RowHandle);
        //    //    if (item.Check == true)
        //    //        e.Appearance.BackColor = Color.PaleTurquoise;
        //    //}
        //}


    }
}