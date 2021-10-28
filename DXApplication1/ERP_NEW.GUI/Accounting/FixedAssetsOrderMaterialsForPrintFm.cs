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


namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderMaterialsForPrintFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedAssetsOrderService;
        private BindingSource materialsJournalBS = new BindingSource();
        public FixedAssetsOrderMaterialsForPrintFm(DateTime endDate)
        {
            InitializeComponent();

            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            materialsJournalBS.DataSource = fixedAssetsOrderService.GetFixedAssetsMateriaslForPrint(endDate);
            materialsGrid.DataSource = materialsJournalBS;
            materialsGrid.EndUpdate();
        }

        private void printBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                materialsGrid.ExportToXls(Utils.HomePath + "Основні засоби.xls");

                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.Arguments = "\"" + Utils.HomePath + "Основні засоби.xls" + "\"";
                process.StartInfo.FileName = "Excel.exe";
                process.Start();
            }
            catch (System.IO.IOException) { MessageBox.Show("Документ уже открыт!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (System.ComponentModel.Win32Exception) { MessageBox.Show("Не найден Microsoft Excel!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch { MessageBox.Show("Документ уже открыт!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }
    }
}