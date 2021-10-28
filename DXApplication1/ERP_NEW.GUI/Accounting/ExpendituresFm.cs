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
using Ninject;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System.Diagnostics;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.Export;
using DevExpress.XtraGrid.Views.Grid;

namespace ERP_NEW.GUI.Accounting
{
    public partial class ExpendituresFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource expendituresBS = new BindingSource();
        private BindingSource receiptsBS = new BindingSource();

        private IStoreHouseService storeHouseService;
        private IPeriodService periodService;
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private ICustomerOrdersService customerOrdersService;

        private UserTasksDTO userTasksDTO;
        private DateTime beginDate;
        private DateTime endDate;

        private LoggerInfo loger = new LoggerInfo();


        public ExpendituresFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            beginYearEdit.EditValue = DateTime.Now;
            endYearEdit.EditValue = DateTime.Now;
            beginMonthEdit.EditValue = DateTime.Now.Month;
            endMonthEdit.EditValue = DateTime.Now.Month;

            this.beginDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            LoadExpendituresjournalByPeriod(beginDate, endDate);
        }

        #region Method's

        private void LoadExpendituresjournalByPeriod(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            periodService = Program.kernel.Get<IPeriodService>();

            expendituresBS.DataSource = storeHouseService.GetExpenditureJournalByPeriod(beginDate, endDate);
            expendituresGrid.DataSource = expendituresBS;
            SetPeriodBtnImage();

            splashScreenManager.CloseWaitForm();
        }

        public void SelectDate()
        {
            beginDate = new DateTime(((DateTime)beginYearEdit.EditValue).Year, (int)beginMonthEdit.EditValue, 1);
            endDate = new DateTime(((DateTime)endYearEdit.EditValue).Year, (int)endMonthEdit.EditValue, 1).AddMonths(1).AddDays(-1);
        }

        private void EditExpedintures(ExpedinturesAccountantDTO model, Utils.Operation operation, UserTasksDTO userTaskDTO)
        {
            using (ExpendituresEditFm expendituresEditFm = new ExpendituresEditFm(model, operation, userTaskDTO))
            {
                if (expendituresEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ExpedinturesAccountantDTO returnItem = expendituresEditFm.Return();
                    expenditureBandedGridView.BeginDataUpdate();
                    LoadExpendituresjournalByPeriod(beginDate, endDate);
                    expenditureBandedGridView.EndDataUpdate();
                    int rowHandle = expenditureBandedGridView.LocateByValue("Id", returnItem.ID);
                    expenditureBandedGridView.FocusedRowHandle = rowHandle;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void DeleteExpenditure()
        {
            periodService = Program.kernel.Get<IPeriodService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            if (expendituresBS.Count == 0)
                return;
            if (MessageBox.Show("Видалити списання?", "Підтверждення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (periodService.CheckPeriodAccess((DateTime)((ExpenditureInfoDTO)expendituresBS.Current).ExpDate) != true)
                {
                    MessageBox.Show("Період закритий або не існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {

                    if (customerOrdersService.CheckCustomerOrderEnable((int?)((ExpenditureInfoDTO)expendituresBS.Current).CustomerOrderId))
                    {
                        MessageBox.Show("Матеріал знаходиться на складі!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (fixedAssetsOrderService.GetContainFixedAssetsMaterials(((ExpenditureInfoDTO)expendituresBS.Current).Id))
                    {
                        MessageBox.Show("Видалення відмінено! \nМатеріал знаходиться на обліку в основних засобах. Спочатку треба видалити матеріал з облікової карточки основного засобу.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (storeHouseService.GetContainInvoiceRequirementMaterials(((ExpenditureInfoDTO)expendituresBS.Current).Id).Count() > 0)
                    {
                        if (MessageBox.Show("Увага! \nМатеріал знаходиться у вимогах. Матеріал буде видалено з вимог?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            try
                            {
                                var updateModel = storeHouseService.GetContainInvoiceRequirementMaterials(((ExpenditureInfoDTO)expendituresBS.Current).Id);

                                foreach (var item in updateModel)
                                {
                                    item.Credit_Account_Id = null;
                                    item.Expenditures_Id = null;

                                    storeHouseService.InvoiceRequirementMaterialUpdate(item);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("При оновленні вимог виникла помилка " + ex, "Помилка при збереженні. Дію відмінено.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else
                            return;
                    }

                    try
                    {
                        storeHouseService.ExpendituresAccountantDelete(((ExpenditureInfoDTO)expendituresBS.Current).Id);

                        expendituresBS.RemoveCurrent();
                        expendituresBS.EndEdit();
                    }
                    catch (Exception ex)
                    {
                        loger.Error("Помилка при видаленні списання " + ex.Message);
                        MessageBox.Show("Помилка при видаленні списання " + ex.Message, "Помилка. Дію відмінено.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    loger.Error("Помилка при роботі з базою даних" + ex.Message);
                    MessageBox.Show("Помилка при роботі з базою даних", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void SetPeriodBtnImage()
        {
            if (periodService.CheckPeriodAccess(beginDate))
            {
                periodBtn.Glyph = imageCollection.Images[1];
                periodBtn.LargeGlyph = imageCollection.Images[1];
                periodBtn.Caption = "Закрити період";
                addBtn.Enabled = true;
                editBtn.Enabled = true;
                editOrderBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
            else
            {
                periodBtn.Glyph = imageCollection.Images[0];
                periodBtn.LargeGlyph = imageCollection.Images[0];
                periodBtn.Caption = "Відкрити період";
                addBtn.Enabled = false;
                editBtn.Enabled = false;
                editOrderBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
        }

        #endregion

        #region Event's

        private void expenditureBandedGridView_DoubleClick(object sender, EventArgs e)
        {
            if (expendituresBS.Count > 0)
            {
                ExpedinturesAccountantDTO model = new ExpedinturesAccountantDTO()
                {
                    ID = ((ExpenditureInfoDTO)expendituresBS.Current).Id,
                    BalanceAccountId = null,
                    BalanceAccountNum = ((ExpenditureInfoDTO)expendituresBS.Current).BalanceAccountNum,
                    CREDIT_ACCOUNT_ID = (int?)((ExpenditureInfoDTO)expendituresBS.Current).CreditAccountId,
                    EXP_DATE = ((ExpenditureInfoDTO)expendituresBS.Current).ExpDate,
                    Nomenclature = ((ExpenditureInfoDTO)expendituresBS.Current).Nomenclature,
                    NomenclatureName = ((ExpenditureInfoDTO)expendituresBS.Current).Name,
                    PRICE = (decimal)((ExpenditureInfoDTO)expendituresBS.Current).ExpPrice,
                    QUANTITY = (decimal)((ExpenditureInfoDTO)expendituresBS.Current).Quantity,
                    PROJECT_NUM = ((ExpenditureInfoDTO)expendituresBS.Current).ProjectNum,
                    CustomerOrderId = ((ExpenditureInfoDTO)expendituresBS.Current).CustomerOrderId,
                    CustomerOrderNumber = ((ExpenditureInfoDTO)expendituresBS.Current).CustomerOrderNumber,
                    UnitLocalName = ((ExpenditureInfoDTO)expendituresBS.Current).UnitLocalName,
                    RECEIPT_ID = ((ExpenditureInfoDTO)expendituresBS.Current).ReceiptId,
                    ProdCustomerOrderId = ((ExpenditureInfoDTO)expendituresBS.Current).ProdCustomerOrderId,
                    ExpenditureType = ((ExpenditureInfoDTO)expendituresBS.Current).ExpenditureType,
                    EmployeeId = ((ExpenditureInfoDTO)expendituresBS.Current).EmployeeId,
                    RealExpDate = ((ExpenditureInfoDTO)expendituresBS.Current).RealExpDate
                };

                EditExpedintures(model, Utils.Operation.Update, userTasksDTO);
            }
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (beginYearEdit.EditValue != null && beginMonthEdit.EditValue != null && endYearEdit.EditValue != null && endMonthEdit.EditValue != null)
            {
                SelectDate();
                LoadExpendituresjournalByPeriod(beginDate, endDate);
            }
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadExpendituresjournalByPeriod(beginDate, endDate);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditExpedintures(new ExpedinturesAccountantDTO() { EXP_DATE = endDate }, Utils.Operation.Add, userTasksDTO);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExpedinturesAccountantDTO model = new ExpedinturesAccountantDTO()
            {
                ID = ((ExpenditureInfoDTO)expendituresBS.Current).Id,
                BalanceAccountId = null,
                BalanceAccountNum = ((ExpenditureInfoDTO)expendituresBS.Current).BalanceAccountNum,
                CREDIT_ACCOUNT_ID = (int?)((ExpenditureInfoDTO)expendituresBS.Current).CreditAccountId,
                EXP_DATE = ((ExpenditureInfoDTO)expendituresBS.Current).ExpDate,
                Nomenclature = ((ExpenditureInfoDTO)expendituresBS.Current).Nomenclature,
                NomenclatureName = ((ExpenditureInfoDTO)expendituresBS.Current).Name,
                PRICE = (decimal)((ExpenditureInfoDTO)expendituresBS.Current).ExpPrice,
                QUANTITY = (decimal)((ExpenditureInfoDTO)expendituresBS.Current).Quantity,
                PROJECT_NUM = ((ExpenditureInfoDTO)expendituresBS.Current).ProjectNum,
                UnitLocalName = ((ExpenditureInfoDTO)expendituresBS.Current).UnitLocalName,
                RECEIPT_ID = ((ExpenditureInfoDTO)expendituresBS.Current).ReceiptId,
                CustomerOrderId = ((ExpenditureInfoDTO)expendituresBS.Current).CustomerOrderId,
                CustomerOrderNumber = ((ExpenditureInfoDTO)expendituresBS.Current).CustomerOrderNumber,
                ProdCustomerOrderId = ((ExpenditureInfoDTO)expendituresBS.Current).ProdCustomerOrderId,
                ExpenditureType = ((ExpenditureInfoDTO)expendituresBS.Current).ExpenditureType,
                EmployeeId = ((ExpenditureInfoDTO)expendituresBS.Current).EmployeeId,
                RealExpDate = ((ExpenditureInfoDTO)expendituresBS.Current).RealExpDate
            };

            EditExpedintures(model, Utils.Operation.Update, userTasksDTO);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteExpenditure();
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

        private void reportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string exportFilePath = Utils.HomePath + @"\Temp\Списання матеріалів.xls";
            var optionXls = new XlsExportOptionsEx();

            optionXls.SheetName = "Списання матеріалів";
            optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            optionXls.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            optionXls.ExportType = ExportType.WYSIWYG;
            expenditureBandedGridView.OptionsPrint.AutoWidth = false;
            expenditureBandedGridView.BestFitColumns();

            string fileExtenstion = new FileInfo(exportFilePath).Extension;

            try
            {
                expendituresGrid.ExportToXls(exportFilePath, optionXls);

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

        private void expenditureBandedGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            Decimal valueCur;
            Decimal valueInv;

            var valueCurrentCreditAcc = gv.GetRowCellValue(e.RowHandle, "CreditAccountNum");
            var valueCurrentCheckDate = gv.GetRowCellValue(e.RowHandle, "ExpenditureCheckDate");

            if (valueCurrentCreditAcc == null && valueCurrentCheckDate == null && e.RowHandle >= 0)
            {
                if ((e.Column.Name == "creditAccountNumCol"))
                    e.Appearance.BackColor = Color.LightCoral;
                if ((e.Column.Name == "dateCheckCol"))
                    e.Appearance.BackColor = Color.LightCoral;
            }
        }

        private void editOrderBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExpedinturesAccountantDTO model = new ExpedinturesAccountantDTO()
            {
                ID = ((ExpenditureInfoDTO)expendituresBS.Current).Id,
                BalanceAccountId = null,
                BalanceAccountNum = ((ExpenditureInfoDTO)expendituresBS.Current).BalanceAccountNum,
                CREDIT_ACCOUNT_ID = (int?)((ExpenditureInfoDTO)expendituresBS.Current).CreditAccountId,
                EXP_DATE = ((ExpenditureInfoDTO)expendituresBS.Current).ExpDate,
                Nomenclature = ((ExpenditureInfoDTO)expendituresBS.Current).Nomenclature,
                NomenclatureName = ((ExpenditureInfoDTO)expendituresBS.Current).Name,
                PRICE = (decimal)((ExpenditureInfoDTO)expendituresBS.Current).ExpPrice,
                QUANTITY = (decimal)((ExpenditureInfoDTO)expendituresBS.Current).Quantity,
                PROJECT_NUM = ((ExpenditureInfoDTO)expendituresBS.Current).ProjectNum,
                UnitLocalName = ((ExpenditureInfoDTO)expendituresBS.Current).UnitLocalName,
                RECEIPT_ID = ((ExpenditureInfoDTO)expendituresBS.Current).ReceiptId,
                ProdCustomerOrderId = ((ExpenditureInfoDTO)expendituresBS.Current).ProdCustomerOrderId,
                ExpenditureType = ((ExpenditureInfoDTO)expendituresBS.Current).ExpenditureType,
                EmployeeId = ((ExpenditureInfoDTO)expendituresBS.Current).EmployeeId,
                RealExpDate = ((ExpenditureInfoDTO)expendituresBS.Current).RealExpDate
            };

            EditExpedintures(model, Utils.Operation.Custom, userTasksDTO);
        }

        #endregion    
    }
}