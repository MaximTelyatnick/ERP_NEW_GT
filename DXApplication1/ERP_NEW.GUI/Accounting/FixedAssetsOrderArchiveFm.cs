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
        private BindingSource fixedAssetsOrderArchiveBS = new BindingSource();    
        private DateTime beginDateArchive, endDateArchive;
        private UserTasksDTO userTasksDTO;

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
            }
        }
    }
}