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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;

namespace ERP_NEW.GUI.Production
{
    public partial class StoreHouseProjectExpendituresFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource expendituresBS = new BindingSource();
        private BindingSource receiptsBS = new BindingSource();

        //private List<ExpenditureStoreHouseDTO> expenditureStoreHouseList = new List<ExpenditureStoreHouseDTO>();
        //private List<ExpenditureStoreHouseInfoDTO> expenditureStoreHouseInfoList = new List<ExpenditureStoreHouseInfoDTO>();
        private List<ExpedinturesAccountantDTO> expedinturesAccountantList = new List<ExpedinturesAccountantDTO>();
        private List<ExpenditureInfoDTO> expenditureInfoList = new List<ExpenditureInfoDTO>();


        private IStoreHouseService storeHouseService;
        private ICustomerOrdersService customerOrderService;
        private IReportService reportService;
        private IPeriodService periodService;

        private UserTasksDTO userTasksDTO;
        private DateTime beginDate;
        private DateTime endDate;

        public StoreHouseProjectExpendituresFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            beginDateReportLastPrintEdit.EditValue = Properties.Settings.Default.ExpStoreHouseBeginDatePrint;
            endDateReportLastPrintEdit.EditValue = Properties.Settings.Default.ExpStoreHouseEndDatePrint;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;
            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            this.beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            beginDateReportEdit.EditValue = beginDate;
            endDateReportEdit.EditValue = endDate;

            LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
            LoadCustomerOrder();
        }

        #region Method's


        private List<ExpedinturesAccountantDTO> ConvertToExpendituresAccountantList(List<ExpenditureInfoDTO> convertList)
        {
            List<ExpedinturesAccountantDTO> expendituresAccountantList = new List<ExpedinturesAccountantDTO>();
            foreach (var item in convertList)
            {
                expendituresAccountantList.Add(new ExpedinturesAccountantDTO()
                    {
                        ID = item.Id,
                        BalanceAccountId = item.BalanceAccountId,
                        BalanceAccountNum = item.BalanceAccountNum,
                        CustomerOrderId = item.CustomerOrderId,
                        CustomerOrderNumber = item.CustomerOrderNumber,
                        EmployeeId = item.EmployeeId,
                        ExpenditureType = item.ExpenditureType,
                        ExpenditureCheckDate = item.ExpenditureCheckDate,
                        CREDIT_ACCOUNT_ID = (int?)item.CreditAccountId,
                        EXP_DATE = item.ExpDate,
                        Nomenclature = item.Nomenclature,
                        NomenclatureName = item.Name,
                        PRICE = (decimal)item.ExpPrice,
                        UnitPrice = (decimal)item.UnitPrice,
                        ProdCustomerOrderId = item.ProdCustomerOrderId,
                        PROJECT_NUM = item.ProjectNum,
                        QUANTITY = (decimal)item.Quantity,
                        RECEIPT_ID = item.ReceiptId,
                        UnitLocalName = item.UnitLocalName,
                        UserId = item.UserId,
                        ReceiptNum = item.ReceiptNum,
                        RealExpDate = item.RealExpDate,
                        ProdCustomerNumber = item.ProdCustomerNumber,
                        Selected = false,
                        Remains=item.Remains
                        
                    });  
            }
            return expendituresAccountantList;
        }
        


        private void LoadExpendituresProjectJournalByPeriod(DateTime beginDate, DateTime endDate)
        {      
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            periodService = Program.kernel.Get<IPeriodService>();

            splashScreenManager.ShowWaitForm();


            expenditureInfoList = storeHouseService.GetExpenditureJournalByPeriod(beginDate, endDate).Where(srch => srch.ExpenditureType == true).ToList();
            //expenditureInfoList = storeHouseService.GetExpendituresStoreHousesInfoByPeriod(beginDate, endDate).ToList();
            expedinturesAccountantList = ConvertToExpendituresAccountantList(expenditureInfoList);

            //expendituresStoreHouseList = storeHouseService.GetExpendituresStoreHousesByPeriod(beginDate, endDate).ToList();
            expendituresBS.DataSource = expedinturesAccountantList;
            expendituresGrid.DataSource = expendituresBS;

            //expenditureFullGrid

            //repositoryCustomerOrderEdit.DataSource = customerOrderService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            //repositoryCustomerOrderEdit.ValueMember = "Id";
            //repositoryCustomerOrderEdit.DisplayMember = "OrderNumber";
            //repositoryCustomerOrderEdit.Properties.NullText = "";



            expendituresGridView.ExpandAllGroups();

            SetPeriodBtnImage();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadCustomerOrder()
        {
            customerOrderService = Program.kernel.Get<ICustomerOrdersService>();
            
            splashScreenManager.ShowWaitForm();
            
            repositoryCustomerOrderEdit.DataSource = customerOrderService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            repositoryCustomerOrderEdit.ValueMember = "Id";
            repositoryCustomerOrderEdit.DisplayMember = "OrderNumber";
            repositoryCustomerOrderEdit.NullText = "Немає данних";

            repositoryItemGridLookUpEdit1.DataSource = customerOrderService.GetCustomerOrdersFull().OrderByDescending(sort => sort.OrderDate).ToList();
            repositoryItemGridLookUpEdit1.ValueMember = "Id";
            repositoryItemGridLookUpEdit1.DisplayMember = "OrderNumber";
            repositoryItemGridLookUpEdit1.NullText = "Немає данних";

            splashScreenManager.CloseWaitForm();
        }



        public void SelectDate()
        {
            beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
        }

        private void SetPeriodBtnImage()
        {
            if (periodService.CheckPeriodAccess(beginDate))
            {
                periodBtn.Glyph = imageCollection.Images[1];
                periodBtn.LargeGlyph = imageCollection.Images[1];
                periodBtn.Caption = "Закрити період";

                addExpendituresBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                checkItemBtn.Enabled = (userTasksDTO.AccessRightId == 2);
                periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            }
            else
            {
                periodBtn.Glyph = imageCollection.Images[0];
                periodBtn.LargeGlyph = imageCollection.Images[0];
                periodBtn.Caption = "Відкрити період";
                addExpendituresBtn.Enabled = false;
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
                checkItemBtn.Enabled = false;
                periodBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            }
        }

        private void DeleteExpenditure()
        {
            periodService = Program.kernel.Get<IPeriodService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            if (expendituresBS.Count == 0)
                return;
            if (MessageBox.Show("Видалити списання?", "Підтверждення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((ExpedinturesAccountantDTO)expendituresBS.Current).CREDIT_ACCOUNT_ID != null)
                {
                    MessageBox.Show("Матеріал знаходиться у бухгалтерському списанні!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (periodService.CheckPeriodAccess((DateTime)((ExpedinturesAccountantDTO)expendituresBS.Current).RealExpDate) != true)
                {
                    MessageBox.Show("Період закритий або не існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    storeHouseService.ExpendituresAccountantDelete(((ExpedinturesAccountantDTO)expendituresBS.Current).ID);
                    expendituresBS.RemoveCurrent();
                    expendituresBS.EndEdit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при видаленні списання " + ex.Message, "Помилка. Дію відмінено.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void EditExpedintures(ExpedinturesAccountantDTO model, Utils.Operation operation, UserTasksDTO userTaskDTO)
        {
            using (StoreHouseProjectExpendituresEditFm storeHouseProjectExpendituresEditFm = new StoreHouseProjectExpendituresEditFm(operation, model, userTaskDTO))
            {
                if (storeHouseProjectExpendituresEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ExpedinturesAccountantDTO returnItem = storeHouseProjectExpendituresEditFm.Return();
                    expendituresGridView.BeginDataUpdate();
                    LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
                    expendituresGridView.EndDataUpdate();
                    int rowHandle = expendituresGridView.LocateByValue("ID", returnItem.ID);
                    expendituresGridView.FocusedRowHandle = rowHandle;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void AddExpedintures(ExpedinturesAccountantDTO model, Utils.Operation operation, UserTasksDTO userTaskDTO, DateTime beginDate, DateTime endDate)
        {
            using (StoreHouseProjectExpendituresEditAdditionalFm storeHouseProjectExpendituresEditAdditionalFm = new StoreHouseProjectExpendituresEditAdditionalFm(model, operation, userTaskDTO, beginDate, endDate))
            {
                if (storeHouseProjectExpendituresEditAdditionalFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ExpedinturesAccountantDTO returnItem = storeHouseProjectExpendituresEditAdditionalFm.Return();
                    expendituresGridView.BeginDataUpdate();
                    LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
                    expendituresGridView.EndDataUpdate();
                    int rowHandle = expendituresGridView.LocateByValue("Id", returnItem.ID);
                    expendituresGridView.FocusedRowHandle = rowHandle;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        #endregion


        #region Event's

        private void checkItemBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //using (StoreHouseProjectExpendituresEditSelectFm storeHouseProjectExpendituresEditSelectFm = new StoreHouseProjectExpendituresEditSelectFm(expenditureStoreHouseList.Where(bdsm => bdsm.ExpenditureId == null).ToList()))
            //{
            //    if (storeHouseProjectExpendituresEditSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        expendituresGridView.BeginDataUpdate();
            //        LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
            //        expendituresGridView.EndDataUpdate();
            //    }
            //    else
            //    {
            //        DialogResult = DialogResult.Cancel;
            //    }
            //}
        }
        
        #endregion


        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                SelectDate();
                LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
            }
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
        }

        private void periodBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що бажаєте редагувати період?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
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
                    MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }   

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteExpenditure();
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((ExpedinturesAccountantDTO)expendituresBS.Current).CREDIT_ACCOUNT_ID != null)
            {
                MessageBox.Show("Матеріал знаходиться у списанні бухгалтера!", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EditExpedintures(((ExpedinturesAccountantDTO)expendituresBS.Current), Utils.Operation.Update, userTasksDTO);
        }

        private void reportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expedinturesAccountantList.Count == 0)
            {
                MessageBox.Show("Відсутні списання!", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                var reportList = expedinturesAccountantList.Where(bdsm => bdsm.RealExpDate >= (DateTime)beginDateReportEdit.EditValue && bdsm.RealExpDate <= (DateTime)endDateReportEdit.EditValue && bdsm.CREDIT_ACCOUNT_ID == null).ToList();

                if (!reportService.ExpendituresForProject(reportList, (DateTime)beginDateReportEdit.EditValue, (DateTime)endDateReportEdit.EditValue))
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);

                beginDateReportLastPrintEdit.EditValue = (DateTime)beginDateReportEdit.EditValue;
                endDateReportLastPrintEdit.EditValue = (DateTime)endDateReportEdit.EditValue;
                Properties.Settings.Default.ExpStoreHouseBeginDatePrint = (DateTime)beginDateReportEdit.EditValue;
                Properties.Settings.Default.ExpStoreHouseEndDatePrint = (DateTime)endDateReportEdit.EditValue;
                Properties.Settings.Default.Save();

                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashScreenManager.CloseWaitForm();
                return;
            }
        }

        private void expendituresGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && (e.Column.Name == "accCheckCol"))
            {
                var model = (ExpedinturesAccountantDTO)expendituresGridView.GetRow(e.RowHandle);

                if (model.CREDIT_ACCOUNT_ID == null)
                {
                    e.Appearance.BackColor2 = Color.FromArgb(255, 192, 192);
                    e.Appearance.BackColor = Color.FromArgb(255, 192, 192);
                }
                else
                {
                    e.Appearance.BackColor2 = Color.PaleGreen;
                    e.Appearance.BackColor = Color.LightGreen;
                }
            }
        }

        private void addExpendituresBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddExpedintures(new ExpedinturesAccountantDTO(), Utils.Operation.Add, userTasksDTO, beginDate, endDate);
        } 

        private void saldoBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();
                if (!reportService.GetTrialBalanceReport(beginDate, endDate))
                {
                    splashScreenManager.CloseWaitForm();
                    MessageBox.Show("За вибраний період немає даних.", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      
            }
            catch (Exception ex)
            {
                splashScreenManager.CloseWaitForm();
                MessageBox.Show("При формуванні звіту виникла помилка: " + ex.Message, "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void fullReportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (expedinturesAccountantList.Count == 0)
            {
                MessageBox.Show("Відсутні списання!", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                var reportList = expedinturesAccountantList.Where(bdsm => bdsm.RealExpDate >= (DateTime)beginDateReportEdit.EditValue && bdsm.RealExpDate <= (DateTime)endDateReportEdit.EditValue ).ToList();

                if (!reportService.ExpendituresForProject(reportList, (DateTime)beginDateReportEdit.EditValue, (DateTime)endDateReportEdit.EditValue))
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

        private void orderCostPrintBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var expendituresInfoListReport = storeHouseService.GetExpenditureJournalByPeriod((DateTime)beginDateReportEdit.EditValue, (DateTime)endDateReportEdit.EditValue).Where(srch => srch.ExpenditureType).ToList();

            if (expendituresInfoListReport.Count == 0)
            {
                MessageBox.Show("Відсутні списання!", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                var expendituresStoreHouseListReport = ConvertToExpendituresAccountantList(expendituresInfoListReport);

                ////var reportList = expendituresStoreHouseList.Where(bdsm => bdsm.ExpDate >= (DateTime)beginDateReportEdit.EditValue && bdsm.ExpDate <= (DateTime)endDateReportEdit.EditValue).ToList();

                if (!reportService.ExpendituresForProjectWithTotalPrice(expendituresStoreHouseListReport, (DateTime)beginDateReportEdit.EditValue, (DateTime)endDateReportEdit.EditValue, false))
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

        private void orderCostPrintDetailBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var expendituresStoreHouseInfoListReport = storeHouseService.GetExpenditureJournalByPeriod((DateTime)beginDateReportEdit.EditValue, (DateTime)endDateReportEdit.EditValue).Where(srch => srch.ExpenditureType).ToList();

            if (expendituresStoreHouseInfoListReport.Count == 0)
            {
                MessageBox.Show("Відсутні списання!", "Формування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                splashScreenManager.ShowWaitForm();

                reportService = Program.kernel.Get<IReportService>();

                var expendituresStoreHouseListReport = ConvertToExpendituresAccountantList(expendituresStoreHouseInfoListReport);

                //var reportList = expendituresStoreHouseList.Where(bdsm => bdsm.ExpDate >= (DateTime)beginDateReportEdit.EditValue && bdsm.ExpDate <= (DateTime)endDateReportEdit.EditValue).ToList();

                if (!reportService.ExpendituresForProjectWithTotalPrice(expendituresStoreHouseListReport, (DateTime)beginDateReportEdit.EditValue, (DateTime)endDateReportEdit.EditValue, true))
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

        private void customerOrderChangeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerOrderSetEdit.EditValue != null && (String)customerOrderSetEdit.EditValue != String.Empty)
            {
                var expenditureCustomerOrderUpdate = expedinturesAccountantList.Where(srch => (bool)srch.Selected);

                if (expenditureCustomerOrderUpdate.Count() == 0)
                {
                    MessageBox.Show("Необхідно відмітити списання, яким потрібно змінити заказ!", "Зміна заказу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Ви впевнені що бажаєте змінити номер заказа?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in expenditureCustomerOrderUpdate)
                    {
                        item.ProdCustomerOrderId = (int?)customerOrderSetEdit.EditValue;
                        storeHouseService.ExpendituresAccountantUpdate(item);
                    }
                    LoadExpendituresProjectJournalByPeriod(beginDate, endDate);
                }

            }
            else
                MessageBox.Show("Необхідно обрати заказ!", "Зміна заказу", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void repositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (((ExpedinturesAccountantDTO)expendituresBS.Current).CREDIT_ACCOUNT_ID != null)
            {
                repositoryItemCheckEdit.CheckedChanged -= repositoryItemCheckEdit_CheckedChanged;
                
                expendituresGridView.BeginDataUpdate();
                MessageBox.Show("Неможливо редагувати заказ у вже списаного бухгалтером матеріалу", "Зміна заказу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((ExpedinturesAccountantDTO)expendituresBS.Current).Selected = false;
                expendituresGridView.EndDataUpdate();

                repositoryItemCheckEdit.CheckedChanged += repositoryItemCheckEdit_CheckedChanged;
            } 
        }

        private void repositoryItemCheckEdit_CheckStateChanged(object sender, EventArgs e)
        {


        }
    }
}