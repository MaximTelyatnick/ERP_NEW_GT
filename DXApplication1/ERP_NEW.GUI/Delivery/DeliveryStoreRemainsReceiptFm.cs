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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using DevExpress.XtraPrinting;
using System.IO;

namespace ERP_NEW.GUI.Delivery
{
    public partial class DeliveryStoreRemainsReceiptFm : DevExpress.XtraEditors.XtraForm
    {
        private IDeliveryService deliveryService;
        private BindingSource storeRemainsReceiptBS = new BindingSource();


        public DeliveryStoreRemainsReceiptFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            DateTime end_Date = DateTime.Today;// год - месяц - день
            dateEdit.EditValue = DateTime.Today;
            LoadData(end_Date);
        }

        private void searchBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void LoadData(DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            deliveryService = Program.kernel.Get<IDeliveryService>();
            var storeRemains = deliveryService.GetDeliveryStoreRemainsWithReceipt(endDate);
            storeRemainsReceiptBS.DataSource = storeRemains;
            storeRemainGrid.DataSource = storeRemainsReceiptBS;

            splashScreenManager.CloseWaitForm();
            
            storeRemainGrid.Focus();
        }

        private void reportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010)(.xlsx)|*.xlsx|Excel (2003) (.xls)|*.xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string exportFilePath = saveDialog.FileName;

                    var optionXls = new XlsExportOptions();
                    optionXls.ExportMode = XlsExportMode.SingleFilePageByPage;
                    optionXls.SheetName = "Залишки за надходженнями";
                    optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    var optionXlsx = new XlsxExportOptions();
                    optionXlsx.ExportMode = XlsxExportMode.SingleFilePageByPage;
                    optionXlsx.SheetName = "Залишки за надходженнями";
                    optionXlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            storeRemainGrid.ExportToXls(exportFilePath, optionXls);
                            break;
                        case ".xlsx":
                            storeRemainGrid.ExportToXlsx(exportFilePath, optionXlsx);
                            break;
                        default:
                            break;
                    }

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
            }
        }
    }
}