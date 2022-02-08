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
using DevExpress.XtraPrinting;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderArchiveFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private IAccountsService accountsService;
        private IReportService reportService;
        private BindingSource fixedAssetsOrderArchiveBS = new BindingSource();
        private BindingSource fixedAssetsOrderMaterialsBS = new BindingSource();

        private DateTime beginDateArchive, endDateArchive;
        private UserTasksDTO userTasksDTO;

        private List<FixedAssetsMaterialsDTO> fixedAssetsOrderMaterialList = new List<FixedAssetsMaterialsDTO>();

        public FixedAssetsOrderArchiveFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            beginDateArchive = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            endDateArchive = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            beginDateArchiveEdit.EditValue = beginDateArchive;
            endDateArchiveEdit.EditValue = endDateArchive;
            
            LoadFixedAssetsOrderArchive();
        }

        private void LoadFixedAssetsOrderArchive()
        {
            splashScreenManager.ShowWaitForm();
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            fixedAssetsArchiveGridView.BeginDataUpdate();
            fixedAssetsOrderArchiveBS.DataSource = fixedAssetsOrderService.GetFixedAssetsOrderArchive((DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue).ToList();
            fixedAssetsArchiveGrid.DataSource = fixedAssetsOrderArchiveBS;
            fixedAssetsArchiveGridView.EndDataUpdate();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadMaterials(int fixedAssetsOrderId)
        {

            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            fixedAssetsOrderMaterialsBS.DataSource = fixedAssetsOrderService.GetFixedAssestMaterials(fixedAssetsOrderId, endDateArchive);
            fixedAssetsOrderMaterialList = fixedAssetsOrderMaterialsBS.DataSource as List<FixedAssetsMaterialsDTO>;
        }
        private void showArchiveBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadFixedAssetsOrderArchive();        
        }
        private void printCardBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            printArchive( (DateTime)beginDateArchiveEdit.EditValue, (DateTime)endDateArchiveEdit.EditValue);
        }
        
        public void printArchive( DateTime beginDate, DateTime endDate)
        {
            string periodArchiveStr = beginDate.ToShortDateString() + " - " + endDate.ToShortDateString();
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
            string exportFilePath = "ОЗ_Архів_" + periodArchiveStr + ".xls";
            try
            {
                fixedAssetsArchiveGrid.ExportToXls(exportFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Збереження файлу неможливе, документ вже відкритий! \n Закрийте документ і спробуйте ще.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (File.Exists(exportFilePath))
            {
                try
                {
                    //Try to open the file and let windows decide how to open it.
                    System.Diagnostics.Process.Start(exportFilePath);
                }
                catch
                {
                    String msg = "Неможливо відкрити файл." + Environment.NewLine + Environment.NewLine + "Путь: " + exportFilePath;
                    MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

        //    if (fixedAssetsOrderArchiveBS.Count > 0)
        //    {

        //        FixedAssetsOrderRegistrationDTO currentFixedAssetsOrderReg = fixedAssetsOrderService.GetByFixedAssetsOrderId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id, 4);
        //        if (currentFixedAssetsOrderReg == null)
        //        {
        //            if (MessageBox.Show("Не сформовано наказ, створити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                try
        //                {
        //                    FixedAssetsOrderJournalDTO newModel = ConvertArchiveJournalToJournal();
        //currentFixedAssetsOrderReg = RegistrationArchive(newModel, (FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }

        //                PrintFixedAssetsOrderExpenditureAct(currentFixedAssetsOrderReg);
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //        else
        //            PrintFixedAssetsOrderExpenditureAct(currentFixedAssetsOrderReg);
        //    }
        //    else MessageBox.Show("Оберіть основний засіб! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private FixedAssetsOrderRegistrationDTO RegistrationArchive(FixedAssetsOrderJournalDTO model, FixedAssetsOrderArchiveJournalDTO modelArchive, List<FixedAssetsMaterialsDTO> fixedAssetsOrderMaterialsBS)
        {
            using (FixedAssetsOrderAddJournalFm fixedAssetsOrderAddJournalFm = new FixedAssetsOrderAddJournalFm(model, modelArchive, "2", fixedAssetsOrderMaterialsBS, beginDateArchive, endDateArchive))
            {
                if (fixedAssetsOrderAddJournalFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    return fixedAssetsOrderAddJournalFm.Return();
                else
                    return null;
            }
        }

        private void printActExpenBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            reportService = Program.kernel.Get<IReportService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            if (fixedAssetsOrderArchiveBS.Count > 0)
            {
                short group = (short)(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).GroupId);

                // получаем счет списания материалов 
                string expenditureAccount="";
                int? expenditureAccountId = fixedAssetsOrderService.GetFixedAssetsMaterialsByFixedAssetsId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id).First().Fixed_Account_Id;
                if (expenditureAccountId != null)
                    expenditureAccount = accountsService.GetAllAccounts().FirstOrDefault(srch => srch.Id == expenditureAccountId).Num;
                ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).ExpenditureAccount = expenditureAccount;

                FixedAssetsOrderRegistrationDTO currentFixedAssetsOrderReg = fixedAssetsOrderService.GetByFixedAssetsOrderId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id, 4);
                if (currentFixedAssetsOrderReg == null)
                {
                    // currentFixedAssetsOrderReg = fixedAssetsOrderService.GetByFixedAssetsOrderId(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id, 4);
                    if (MessageBox.Show("Не сформовано наказ, створити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            FixedAssetsOrderJournalDTO newModel = ConvertArchiveJournalToJournal();
                            currentFixedAssetsOrderReg = RegistrationArchive(newModel, (FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, (List<FixedAssetsMaterialsDTO>)fixedAssetsOrderMaterialsBS.DataSource);
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        PrintFixedAssetsOrderExpenditureAct(currentFixedAssetsOrderReg);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                    PrintFixedAssetsOrderExpenditureAct(currentFixedAssetsOrderReg);
                
            }
            else MessageBox.Show("Оберіть основний засіб! ", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void PrintFixedAssetsOrderExpenditureAct(FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistration)
        {
            reportService = Program.kernel.Get<IReportService>();
            short group = (short)(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).GroupId);
            switch (group)
            {
                case 10:
                case 2:
                    reportService.PrintFixedAssetsOrderExpenditureAct((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, fixedAssetsOrderRegistration);
                    break;
                default:
                    reportService.PrintFixedAssetsOrderExpenditureAct((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current, fixedAssetsOrderRegistration);
                    break;
            }
        }

        public FixedAssetsOrderJournalDTO ConvertArchiveJournalToJournal()
        {
            FixedAssetsOrderJournalDTO newModel = new FixedAssetsOrderJournalDTO()
            {
                Balance_Account_Id = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Balance_Account_Id,
                BalanceAccountNum = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).BalanceAccountNum,
                FixedCardStatus = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).FixedCardStatus,
                GroupId = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).GroupId,
                GroupName = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).GroupName,
                InventoryName = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).InventoryName,
                InventoryNumber = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).InventoryNumber,
                Id = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id,
                BeginRecordDate = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).BeginRecordDate,
                BeginDate = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).BeginDate,
                EndRecordDate = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).EndRecordDate,
                SupplierName = ((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).SupplierName
            };

            return newModel;
        }

        private void fixedAssetsArchiveGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (fixedAssetsOrderArchiveBS.Count > 0 && fixedAssetsOrderArchiveBS != null)
                LoadMaterials(((FixedAssetsOrderArchiveJournalDTO)fixedAssetsOrderArchiveBS.Current).Id);
        }

        private void fixedAssetsArchiveGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gv = sender as GridView;
            if (e.Column.Name == "operationNameCol")
            {
                if (gv.GetRowCellValue(e.RowHandle, "OperationStatus") != null && gv.GetRowCellValue(e.RowHandle, "OperationStatus").Equals(2))//sale
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.Green;
                }
                if (gv.GetRowCellValue(e.RowHandle, "OperationStatus") != null && gv.GetRowCellValue(e.RowHandle, "OperationStatus").Equals(1))//transfer
                {
                    e.Appearance.BackColor = Color.LightBlue;
                    e.Appearance.BackColor2 = Color.SteelBlue;
                }
                if (gv.GetRowCellValue(e.RowHandle, "OperationStatus") != null && gv.GetRowCellValue(e.RowHandle, "OperationStatus").Equals(4))//expenditure
                {
                    e.Appearance.BackColor = Color.LightSalmon;
                    e.Appearance.BackColor2 = Color.LightYellow;
                }

            }
        }
    }
}