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
using DevExpress.XtraPrinting;
using System.IO;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class AgreementOrderJournalFm : DevExpress.XtraEditors.XtraForm
    {

        private IContractorsService contractorService;

        private BindingSource agreementOrdersBS = new BindingSource();
        private UserTasksDTO _userTaskDTO;

        public AgreementOrderJournalFm(UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            _userTaskDTO = userTaskDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            firstDateEdit.EditValue = firstDay;
            lastDateEdit.EditValue = lastDay.AddMonths(1).AddDays(-1);

            AuthorizatedUserAccess();

            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        #region Method's

        private void EditAgreementOrder(Utils.Operation operation, AgreementOrderDTO model)
        {
            using (AgreementOrderEditFm agreementOrderEditFm = new AgreementOrderEditFm(operation, model, _userTaskDTO))
            {
                if (agreementOrderEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AgreementOrderDTO return_agreementOrderId = agreementOrderEditFm.Return();
                    agreementOrderGridView.BeginUpdate();
                    LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
                    agreementOrderGridView.EndUpdate();
                    int rowHandle = agreementOrderGridView.LocateByValue("Id", return_agreementOrderId.Id);
                    agreementOrderGridView.FocusedRowHandle = rowHandle;

                }
            }
        }

        private void DeleteAgreementOrder()
        {
            if (MessageBox.Show("Видалити рахунок під номером " + ((AgreementOrderJournalDTO)agreementOrdersBS.Current).AgreementOrderNumber + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (contractorService.AgreementOrderDelete(((AgreementOrderJournalDTO)agreementOrdersBS.Current).Id))
                {
                    agreementOrderGrid.BeginUpdate();
                    LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
                    agreementOrderGrid.EndUpdate();
                    agreementOrderGrid.Refresh();
                }
            }
        }

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            splashScreenManager.ShowWaitForm();

            contractorService = Program.kernel.Get<IContractorsService>();
            agreementOrdersBS.DataSource = contractorService.GetAgreementOrderJournal(beginDate, endDate).OrderByDescending(bdsm=>bdsm.AgreementOrderDate);
            agreementOrderGrid.DataSource = agreementOrdersBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {

        }
        #endregion

        #region Event's

        private void exportToExcelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                            agreementOrderGrid.ExportToXls(exportFilePath, optionXls);
                            break;
                        case ".xlsx":
                            agreementOrderGrid.ExportToXlsx(exportFilePath, optionXlsx);
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

        private void agreementOrderGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (agreementOrdersBS.Count > 1)
            {
                AgreementOrderJournalDTO item = (AgreementOrderJournalDTO)agreementOrdersBS[e.ListSourceRowIndex];

                if (e.Column == scanCol && e.IsGetData)
                {
                    if (item.AgreementOrderScanId != null)
                        e.Value = imageCollection.Images[0];
                    else
                        e.Value = imageCollection.Images[1];
                }
            }
        }

        private void repositoryItemPictureEdit_DoubleClick(object sender, EventArgs e)
        {
            if (((AgreementOrderJournalDTO)agreementOrdersBS.Current).AgreementOrderScanId != null)
            {
                AgreementOrderScanDTO model = contractorService.GetAgreementOrderScanById(((AgreementOrderJournalDTO)agreementOrdersBS.Current).AgreementOrderScanId);

                string path = Utils.HomePath + @"\Temp";

                System.IO.File.WriteAllBytes(path + model.FileName, model.Scan);

                System.Diagnostics.Process.Start(path + model.FileName);
            }
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)firstDateEdit.EditValue, (DateTime)lastDateEdit.EditValue);
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAgreementOrder(Utils.Operation.Add, new AgreementOrderDTO());
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (agreementOrdersBS.Count > 0)
                DeleteAgreementOrder();
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (agreementOrdersBS.Count > 0)
            {
                AgreementOrderJournalDTO agreementOrderJournal = ((AgreementOrderJournalDTO)agreementOrdersBS.Current);
                AgreementOrderDTO newModel = new AgreementOrderDTO()
                {
                    Id = agreementOrderJournal.Id,
                    AgreementOrderNumber = agreementOrderJournal.AgreementOrderNumber,
                    AgreementOrderDate = agreementOrderJournal.AgreementOrderDate,
                    AgreementId = agreementOrderJournal.AgreementId,
                    ContractorId = agreementOrderJournal.ContractorId,
                    PurposeId = agreementOrderJournal.PurposeId,
                    AgreementOrderScanId = agreementOrderJournal.AgreementOrderScanId,
                    Price = agreementOrderJournal.Price,
                    CurrencyId = agreementOrderJournal.CurrencyId,
                    ResponsibleId = agreementOrderJournal.ResponsibleId

                };

                EditAgreementOrder(Utils.Operation.Update, newModel);
            }
        }

        #endregion

        private void agreementOrderGridView_DoubleClick(object sender, EventArgs e)
        {
            if (agreementOrdersBS.Count > 0)
            {
                AgreementOrderJournalDTO agreementOrderJournal = ((AgreementOrderJournalDTO)agreementOrdersBS.Current);
                AgreementOrderDTO newModel = new AgreementOrderDTO()
                {
                    Id = agreementOrderJournal.Id,
                    AgreementOrderNumber = agreementOrderJournal.AgreementOrderNumber,
                    AgreementOrderDate = agreementOrderJournal.AgreementOrderDate,
                    AgreementId = agreementOrderJournal.AgreementId,
                    ContractorId = agreementOrderJournal.ContractorId,
                    PurposeId = agreementOrderJournal.PurposeId,
                    AgreementOrderScanId = agreementOrderJournal.AgreementOrderScanId,
                    Price = agreementOrderJournal.Price,
                    CurrencyId = agreementOrderJournal.CurrencyId,
                    ResponsibleId = agreementOrderJournal.ResponsibleId

                };

                EditAgreementOrder(Utils.Operation.Update, newModel);
            }
        }

        

    }
}