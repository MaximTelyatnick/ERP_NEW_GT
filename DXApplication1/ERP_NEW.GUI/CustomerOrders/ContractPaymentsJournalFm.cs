﻿using System;
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
using ERP_NEW.BLL.Infrastructure;
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System.IO;
using DevExpress.Data.Filtering;
using ERP_NEW.BLL.Interfaces;
using DevExpress.Export;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class ContractPaymentsJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;
        private BindingSource paymentsBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public ContractPaymentsJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;
            
            DateTime begin_Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); // год - месяц - день
            DateTime end_Date = DateTime.Today;
            beginDateEdit.EditValue = begin_Date;
            endDateEdit.EditValue = end_Date;

            LoadData(begin_Date, end_Date);
            AuthorizatedUserAccess();
        }

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            try
            {
                paymentsBS.DataSource = customerOrdersService.GetContractPaymentsByPeriod(beginDate, endDate).OrderBy(bdsm => bdsm.PaymentDate).ThenBy(bd => bd.PaymentDocument).ToList();
                paymentsGrid.DataSource = paymentsBS;
            }
            catch (Exception ex)
            {
                if(beginDate.Year <= 2015|| endDate.Year <= 2015)
                    MessageBox.Show("Помилка отримання даних. Оберіть рік більший за 2015.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Помилка отримання даних " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            splashScreenManager.CloseWaitForm();
        }

        public void AuthorizatedUserAccess()
        {
            paymentPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);
            paymentPriceCurrencyCol.Visible = (_userTasksDTO.PriceAttribute == 1);
            currencyCodeCol.Visible = (_userTasksDTO.PriceAttribute == 1);
        }

        private void paymentsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
           ContractPaymentsDTO item = (ContractPaymentsDTO)paymentsBS[e.ListSourceRowIndex];

            if (e.Column == directionCol && e.IsGetData)
            {
                if (item.Direction > 0)
                    e.Value = imageCollection.Images[0];
                else
                    e.Value = imageCollection.Images[1];
            }
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime begin_Date = (DateTime)beginDateEdit.EditValue;
            DateTime end_Date = (DateTime)endDateEdit.EditValue;
            LoadData(begin_Date, end_Date);
        }

        private void paymentsGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Column.Name == "paymentPriceCol")
            {
                var cellValue = paymentsGridView.GetRowCellValue(e.RowHandle, directionCol);

                if ((Image)cellValue == imageCollection.Images[0])
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.LightGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.LightSalmon;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "paymentPriceCurrencyCol")
            {
                var cellValue = paymentsGridView.GetRowCellValue(e.RowHandle, directionCol);

                if ((Image)cellValue == imageCollection.Images[0])
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.LightGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.LightSalmon;
                }
            }

            if (e.RowHandle >= 0 && e.Column.Name == "currencyCodeCol")
            {
                var cellValue = paymentsGridView.GetRowCellValue(e.RowHandle, directionCol);

                if ((Image)cellValue == imageCollection.Images[0])
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.LightGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.LightSalmon;
                }
            }
        }

        private void paymentsGridView_CellMerge(object sender, CellMergeEventArgs e)
        {
            GridView view = sender as GridView;
            ContractPaymentsDTO model1 = (ContractPaymentsDTO)view.GetRow(e.RowHandle1);
            ContractPaymentsDTO model2 = (ContractPaymentsDTO)view.GetRow(e.RowHandle2);



            if (e.Column.FieldName != "OrderNumber" && e.Column.FieldName != "OrderDate" && e.Column.FieldName != "Payment" && e.Column.FieldName != "PaymentCurrency" && e.Column.FieldName != "Prepayment" && e.Column.FieldName != "PrepaymentCurrency")
            {
                e.Merge = (model1.BankPaymentId == model2.BankPaymentId);
                e.Handled = true;
            }
        }

        private void exportToXlsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string exportFilePath = Utils.HomePath + @"\Temp\Надходження та витрати.xls";
            var optionXls = new XlsExportOptionsEx();

            optionXls.SheetName = "Надходження та витрати";
            optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
            optionXls.ShowColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            optionXls.ExportType = ExportType.WYSIWYG;
            paymentsGridView.OptionsPrint.AutoWidth = false;
            paymentsGridView.BestFitColumns();

            string fileExtenstion = new FileInfo(exportFilePath).Extension;

            try
            {
                paymentsGrid.ExportToXls(exportFilePath, optionXls);

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