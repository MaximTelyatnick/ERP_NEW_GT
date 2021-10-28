using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using Ninject;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using DevExpress.XtraPrinting;
using System.IO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseRemainFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private List<StoreHouseRemainsDTO> storeHouseRemainsCheckList = new List<StoreHouseRemainsDTO>();
        private List<StoreHouseRemainsDTO> storeHouseRemainsList =  new List<StoreHouseRemainsDTO>();

        private BindingSource storeHouseRemainsBS = new BindingSource();

        public UserTasksDTO _userTasksDTO;


        public StoreHouseRemainFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            dateEdit.EditValue = DateTime.Now;

            AuthorizatedUserAccess();

            LoadStoreHouseRemainsData((DateTime)dateEdit.EditValue);

        }

        private void LoadStoreHouseRemainsData(DateTime dateTime)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            storeHouseRemainsList = storeHouseService.GetStoreHouseRemainsByDate(dateTime).ToList();
            storeHouseRemainsBS.DataSource = storeHouseRemainsList;
            storeHouseRemainsGrid.DataSource = storeHouseRemainsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStoreHouseRemainsData((DateTime)dateEdit.EditValue);
        }

        public List<StoreHouseRemainsDTO> Return()
        {
            return storeHouseRemainsCheckList;
        }

        public void AuthorizatedUserAccess()
        {
            dateEdit.Enabled = (_userTasksDTO.AccessRightId == 2);
            showBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            printBtn.Enabled = (_userTasksDTO.AccessRightId == 2);

            unitPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);
            remainsSumCol.Visible = (_userTasksDTO.PriceAttribute == 1);
            totalPriceCol.Visible = (_userTasksDTO.PriceAttribute == 1);

        }

        private void printBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010)(.xlsx)|*.xlsx|Excel (2003) (.xls)|*.xls";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string exportFilePath = saveDialog.FileName;

                    var optionXls = new XlsExportOptions();
                    optionXls.ExportMode = XlsExportMode.SingleFilePageByPage;
                    optionXls.SheetName = "Залишки на складі";
                    optionXls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    var optionXlsx = new XlsxExportOptions();
                    optionXlsx.ExportMode = XlsxExportMode.SingleFilePageByPage;
                    optionXlsx.SheetName = "Залишки на складі";
                    optionXlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;

                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            storeHouseRemainsGrid.ExportToXls(exportFilePath, optionXls);
                            break;
                        case ".xlsx":
                            storeHouseRemainsGrid.ExportToXlsx(exportFilePath, optionXlsx);
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
                            String msg = "Файл не було створено." + Environment.NewLine + Environment.NewLine + "Шлях: " + exportFilePath;
                            MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "Файл не було сбережено." + Environment.NewLine + Environment.NewLine + "Шлях: " + exportFilePath;
                        MessageBox.Show(msg, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //private void storeHouseRemainsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    if (storeHouseRemainsBS.Count > 0)
        //    {
        //        decimal TotalQuantity = Convert.ToDecimal(((StoreHouseRemainsDTO)storeHouseRemainsBS.Current).RemainsQuantity);

        //    }
        //}

    }
}