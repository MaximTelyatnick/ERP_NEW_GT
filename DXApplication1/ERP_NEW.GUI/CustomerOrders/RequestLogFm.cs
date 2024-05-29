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
using DevExpress.XtraPrinting;


namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class RequestLogFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;
        private IRequestLogService requestLogService;
        private IReportService reportService;
        private BindingSource requestLogJournalBS = new BindingSource();
        private BindingSource requestLogBS = new BindingSource();
        private BindingSource colorBS = new BindingSource();
        private List<RequestLogJournalDTO> requestLogJournalList = new List<RequestLogJournalDTO>();
        private List<ColorsDTO> colorsPallete = new List<ColorsDTO>();


        public RequestLogFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime lastDay = firstDay.AddYears(1).AddDays(-1);

            beginDateItem.EditValue = firstDay;
            endDateItem.EditValue = lastDay;
            LoadData();
            LoadColorsPallete();
            AuthorizatedUserAccess();


        }

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            sendDataToExcel.Enabled = (userTasksDTO.AccessRightId == 2);
            colorDetalsBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            requestLogGridView.BeginDataUpdate();
            requestLogService = Program.kernel.Get<IRequestLogService>();
            requestLogJournalList = requestLogService.GetRequestLogProc((DateTime)beginDateItem.EditValue, (DateTime)endDateItem.EditValue).ToList();
            requestLogJournalBS.DataSource = requestLogJournalList;
            requestLogGrid.DataSource = requestLogJournalBS;
            requestLogBS.DataSource = requestLogService.GetRequestLog().ToList();
            requestLogGridView.EndDataUpdate();
        }
        private void AddRequestLog(Utils.Operation operation, RequestLogDTO model, List<RequestLogDTO> requestList)
        {
            using (RequestLogEditFm requestLogEditFm = new RequestLogEditFm(operation, model, requestList))
            {
                if (requestLogEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    RequestLogDTO return_Id = requestLogEditFm.Return();
                    LoadData();
                }
            }
        }

        private void DeleteRequestLog()
        {
            List<RequestLogJournalDTO> rezList = new List<RequestLogJournalDTO>();
            List<RequestLogJournalDTO> firstElementList = new List<RequestLogJournalDTO>();
            if (requestLogJournalBS.Count != 0)
            {
                if (MessageBox.Show("Видалити замовника " + ((RequestLogJournalDTO)requestLogJournalBS.Current).SeqNum + " " + ((RequestLogJournalDTO)requestLogJournalBS.Current).Name + "?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    firstElementList = requestLogJournalBS.DataSource as List<RequestLogJournalDTO>;
                    requestLogService = Program.kernel.Get<IRequestLogService>();
                    if (((RequestLogJournalDTO)requestLogJournalBS.Current).Id == firstElementList[0].Id)//if select first element
                    {
                        if (requestLogService.RequestLogDelete(((RequestLogJournalDTO)requestLogJournalBS.Current).Id))
                        {
                            int rowHandle = requestLogGridView.FocusedRowHandle - 1;
                            LoadData();
                            requestLogGridView.FocusedRowHandle = (requestLogGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                        }
                    }
                    else //if don't 1s element, all elements in grid, whole bigest current element SeqNum-1
                    {
                        rezList = requestLogJournalBS.DataSource as List<RequestLogJournalDTO>;
                        foreach (var re in rezList.TakeWhile(a => a.SeqNum > (((RequestLogJournalDTO)requestLogJournalBS.Current).SeqNum)))
                        {
                            RequestLogDTO model = new RequestLogDTO()
                            {
                                Id = re.Id,
                                ContactAddress = re.Address,
                                DateRegistration = re.DateRegistration,
                                Detals = re.Detals,
                                DocForTender = re.DocForTender,
                                InformationDoc = re.InformationDoc,
                                OrderDate = re.OrderDate,
                                OrderNumber = re.OrderNumber,
                                SeqNum = re.SeqNum - 1,
                                Spesification = re.Spesification,
                                StageRegistration = re.StageRegistration,
                                RequestLogContractorId = re.RequestLogContractorId,
                                NameContractor = re.Name,
                                Task = re.Task,
                                ColorId = re.ColorId,
                                Color = re.Color

                            };
                            requestLogService.RequestLogUpdate(model);
                        }
                        if (requestLogService.RequestLogDelete(((RequestLogJournalDTO)requestLogJournalBS.Current).Id))
                        {
                            int rowHandle = requestLogGridView.FocusedRowHandle - 1;

                            requestLogGridView.FocusedRowHandle = (requestLogGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                            LoadData();
                        }
                    }
                }
            }
        }

        private void LoadColorsPallete()
        {
            splashScreenManager.ShowWaitForm();

            requestLogService = Program.kernel.Get<IRequestLogService>();

            colorsPallete = requestLogService.GetColors().ToList();
            for (int i = 0; i < colorsPallete.Count; i++)
            {
                ToolStripMenuItem MenuItem = new ToolStripMenuItem()
                {
                    Text = colorsPallete[i].Name_Rus.ToString(),
                    Image = Rgb2Bitmap(colorsPallete[i].Color_Code.ToString()),
                    ToolTipText = colorsPallete[i].Name.ToString(),
                    Tag = colorsPallete[i].Id
                };
                contextMenuStrip.Items.Add(MenuItem);
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
        #endregion

        #region Event's

        private void showBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddRequestLog(Utils.Operation.Add, new RequestLogDTO(), (List<RequestLogDTO>)requestLogBS.DataSource);
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (requestLogJournalBS.Count > 0)
            {
                RequestLogJournalDTO requestLogJournal = ((RequestLogJournalDTO)requestLogJournalBS.Current);

                RequestLogDTO model = new RequestLogDTO()
                {
                    Id = requestLogJournal.Id,
                    ContactAddress = requestLogJournal.Address,
                    DateRegistration = requestLogJournal.DateRegistration,
                    Detals = requestLogJournal.Detals,
                    DocForTender = requestLogJournal.DocForTender,
                    InformationDoc = requestLogJournal.InformationDoc,
                    OrderDate = requestLogJournal.OrderDate,
                    OrderNumber = requestLogJournal.OrderNumber,
                    SeqNum = requestLogJournal.SeqNum,
                    Spesification = requestLogJournal.Spesification,
                    StageRegistration = requestLogJournal.StageRegistration,
                    RequestLogContractorId = requestLogJournal.RequestLogContractorId,
                    NameContractor = requestLogJournal.Name,
                    Task = requestLogJournal.Task,
                    ColorId = requestLogJournal.ColorId,
                    Color = requestLogJournal.Color

                };
                AddRequestLog(Utils.Operation.Update, (RequestLogDTO)model, (List<RequestLogDTO>)requestLogBS.DataSource);
            }
            else MessageBox.Show("Помилка редагування! Створіть спочатку запит!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (requestLogJournalBS.Count > 0)
                DeleteRequestLog();
            else MessageBox.Show("Помилка видалення замовлення! Створіть спочатку замовлення!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        #region StripMenuColor
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (requestLogJournalBS.Count == 0 || requestLogGridView.FocusedRowHandle < 0)
                e.Cancel = true;
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RequestLogJournalDTO requestLogJournal = ((RequestLogJournalDTO)requestLogJournalBS.Current);

            RequestLogDTO model = new RequestLogDTO()
            {
                ColorId = requestLogJournal.ColorId,
                Color = requestLogJournal.Color,
                Id = requestLogJournal.Id,
                SeqNum = requestLogJournal.SeqNum,
                DateRegistration = requestLogJournal.DateRegistration,
                RequestLogContractorId = requestLogJournal.RequestLogContractorId,
                Spesification = requestLogJournal.Spesification,
                Detals = requestLogJournal.Detals,
                DocForTender = requestLogJournal.DocForTender,
                InformationDoc = requestLogJournal.InformationDoc,
                NameContractor = requestLogJournal.Name,
                Task = requestLogJournal.Task,
                OrderDate = requestLogJournal.OrderDate,
                OrderNumber = requestLogJournal.OrderNumber,
                StageRegistration = requestLogJournal.StageRegistration,
                ContactAddress = requestLogJournal.Address,
                ColorDetals = requestLogJournal.ColorDetals
            };

            model.Color = e.ClickedItem.ToolTipText;
            model.ColorId = (int)e.ClickedItem.Tag;
            requestLogService.RequestLogUpdate(model);
            requestLogJournalBS.EndEdit();
            requestLogJournalBS.CancelEdit();
            LoadData();
        }

        private void requestLogGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (requestLogJournalBS.Count > 1)
            {
                if (e.RowHandle > -1)
                {
                    RequestLogDTO requestLog = ((RequestLogDTO)requestLogBS.Current);

                    RequestLogDTO model = new RequestLogDTO()
                    {
                        ColorId = requestLog.ColorId,
                        Color = requestLog.Color,
                        Id = requestLog.Id,
                        SeqNum = requestLog.SeqNum,
                        DateRegistration = requestLog.DateRegistration,
                        RequestLogContractorId = requestLog.RequestLogContractorId,
                        Spesification = requestLog.Spesification,
                        Detals = requestLog.Detals,
                        DocForTender = requestLog.DocForTender,
                        InformationDoc = requestLog.InformationDoc,
                        NameContractor = requestLog.NameContractor,
                        Task = requestLog.Task,
                        OrderDate = requestLog.OrderDate,
                        OrderNumber = requestLog.OrderNumber,
                        StageRegistration = requestLog.StageRegistration,
                        ContactAddress = requestLog.ContactAddress,
                        ColorDetals = requestLog.ColorDetals
                    };
                    requestLogService.RequestLogUpdate(model);
                    RequestLogJournalDTO models = (RequestLogJournalDTO)requestLogGridView.GetRow(e.RowHandle);

                }
            }
        }

        private void requestLogGridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            RequestLogJournalDTO models = (RequestLogJournalDTO)requestLogGridView.GetRow(e.RowHandle);

            if (models != null)
            {
                if (e.Column.Name == "seqNumCol")
                {
                    e.Appearance.BackColor = Color.FromName(models.Color);

                }
            }
        }

        private void Options_CustomizeCell(DevExpress.Export.CustomizeCellEventArgs e)
        {
            if (e.Value.ToString() == "4")
            {
                e.Formatting.Font.Color = Color.Red;
                e.Handled = true;
            }
        }

        private void requestLogGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            RequestLogJournalDTO model = (RequestLogJournalDTO)requestLogGridView.GetRow(e.RowHandle);

            if (model != null)
            {
                if (model.ColorDetals == true)
                    if (e.Column.Name == "detalsCol")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    }
            }
        }

        private void colorDetalsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            requestLogService = Program.kernel.Get<IRequestLogService>();
            if (requestLogJournalBS.Count > 0)
            {
                RequestLogJournalDTO requestLogJournal = ((RequestLogJournalDTO)requestLogJournalBS.Current);
                if (requestLogJournal.ColorDetals == false || requestLogJournal.ColorDetals == null)
                {
                    RequestLogDTO model = new RequestLogDTO()
                    {
                        ColorDetals = true,
                        Id = requestLogJournal.Id,
                        SeqNum = requestLogJournal.SeqNum,
                        DateRegistration = requestLogJournal.DateRegistration,
                        RequestLogContractorId = requestLogJournal.RequestLogContractorId,
                        Spesification = requestLogJournal.Spesification,
                        Detals = requestLogJournal.Detals,
                        DocForTender = requestLogJournal.DocForTender,
                        InformationDoc = requestLogJournal.InformationDoc,
                        NameContractor = requestLogJournal.Name,
                        Task = requestLogJournal.Task,
                        OrderDate = requestLogJournal.OrderDate,
                        OrderNumber = requestLogJournal.OrderNumber,
                        StageRegistration = requestLogJournal.StageRegistration,
                        ContactAddress = requestLogJournal.Address,
                        ColorId = requestLogJournal.ColorId,
                        Color = requestLogJournal.Color

                    };
                    requestLogService.RequestLogUpdate(model);
                    LoadData();
                }
                else
                {
                    RequestLogDTO model = new RequestLogDTO()
                    {
                        ColorDetals = false,
                        Id = requestLogJournal.Id,
                        SeqNum = requestLogJournal.SeqNum,
                        DateRegistration = requestLogJournal.DateRegistration,
                        RequestLogContractorId = requestLogJournal.RequestLogContractorId,
                        Spesification = requestLogJournal.Spesification,
                        Detals = requestLogJournal.Detals,
                        DocForTender = requestLogJournal.DocForTender,
                        InformationDoc = requestLogJournal.InformationDoc,
                        NameContractor = requestLogJournal.Name,
                        Task = requestLogJournal.Task,
                        OrderDate = requestLogJournal.OrderDate,
                        OrderNumber = requestLogJournal.OrderNumber,
                        StageRegistration = requestLogJournal.StageRegistration,
                        ContactAddress = requestLogJournal.Address,
                        ColorId = requestLogJournal.ColorId,
                        Color = requestLogJournal.Color

                    };
                    requestLogService.RequestLogUpdate(model);
                    LoadData();
                }

            }
        }

        #endregion

        private void sendDataToExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            ////////DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
            ////////;

            //////////XlsExportOptionsEx op = new XlsExportOptionsEx();
            //////////op.CustomizeCell += op_CustomizeCell;
            //////////requestLogGridView.ExportToXls(exportFilePath, op);
            //////////System.Diagnostics.Process.Start(exportFilePath);
            ////////try
            ////////{
            ////////    requestLogGridView.ExportToXlsx(exportFilePath);//,options);
            ////////    MessageBox.Show("Файл успішно оновлен! ", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////////}
            ////////catch (Exception)
            ////////{
            ////////    MessageBox.Show("Збереження файлу неможливе, документ вже відкритий! \n Закрийте документ і спробуйте ще.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ////////    return;
            ////////}

            //string exportFilePath = @"\\SERVER-TFS\Data\RequestLog\Журнал реєстрації запитів клієнтів" + ".xlsx";
            string exportFilePath;
            exportFilePath = DefinitionPathToServer.DefinitionPath();
            if (exportFilePath == "SBD1")
                exportFilePath = @"\\SBD1\Data\RequestLog\";
            else exportFilePath = @"\\SBD1\Data\DebugRequestLog\";

            if (requestLogJournalList.Count > 0)
            {
                reportService = Program.kernel.Get<IReportService>();

                reportService.PrintRequstLog(requestLogJournalList, exportFilePath);
            }







        }
        void op_CustomizeCell(DevExpress.Export.CustomizeCellEventArgs ea)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;

            //if (ea.ColumnFieldName == "Detals")
            //{
            //    if (models.ColorDetals == true)
            //    {
            //        ea.Formatting.Font.Color = Color.Red;
            //        ea.Formatting.Font.Bold = true;
            //        ea.Handled = true;
            //    }
            //}
        }
       
        #endregion

        private void requestLogGrid_Click(object sender, EventArgs e)
        {

        }

    }
}