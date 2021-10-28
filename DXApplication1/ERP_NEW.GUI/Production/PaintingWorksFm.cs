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
using Ninject;
using System.IO;
using ERP_NEW.BLL.Infrastructure;


namespace ERP_NEW.GUI.Production
{
    public partial class PaintingWorksFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;
        private IProjectDetailsService projectDetailsService;
        private BindingSource paintingWorksBS = new BindingSource();
        int countPaint;
        DateTime firstDay, lastDay;

        private ObjectBase ItemJournal
        {
            get { return paintingWorksBS.Current as ObjectBase; }
            set
            {
                paintingWorksBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public PaintingWorksFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;

            firstDay = new DateTime(DateTime.Now.Year, 1, 1);
            lastDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            beginDateItem.EditValue = firstDay;
            endDateItem.EditValue = lastDay.AddMonths(1).AddDays(-1);

            Load();
            
        }
        private void Load()
        {
            paintingWorksGridView.BeginDataUpdate();
            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();
            paintingWorksBS.DataSource = projectDetailsService.GetPaintingWorks((DateTime)beginDateItem.EditValue, (DateTime)endDateItem.EditValue);
            paintingWorksGrid.DataSource = paintingWorksBS;
            paintingWorksGridView.EndDataUpdate();

            countPaint = paintingWorksBS.Count;
        }

        private void AddPaintWorks(Utils.Operation operation, PaintingWorksDTO model, UserTasksDTO userTaskDTO, int countPaint)
        {
            using (PaintingWorksEditFm paintingWorksEditFm = new PaintingWorksEditFm(operation, model, userTaskDTO, countPaint))
            {
                if (paintingWorksEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int return_Id = paintingWorksEditFm.Return();
                    Load();                    
                    int rowHandle = paintingWorksGridView.LocateByValue("Id", return_Id);
                    paintingWorksGridView.FocusedRowHandle = rowHandle;
                }
            }
        }

       
        private void DeletetPaintingWorks()
        {
            if (paintingWorksBS.Count != 0)
            {
                if (MessageBox.Show("Видалити роботу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (projectDetailsService.PaintingWorksDelete(((PaintingWorksJournalDTO)paintingWorksBS.Current).Id))
                    {
                        int rowHandle = paintingWorksGridView.FocusedRowHandle - 1;
                        paintingWorksGridView.BeginDataUpdate();
                        Load();
                        paintingWorksGridView.EndDataUpdate();
                        paintingWorksGridView.FocusedRowHandle = (paintingWorksGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    }
                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddPaintWorks(Utils.Operation.Add, new PaintingWorksDTO(), userTasksDTO, countPaint);
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (paintingWorksBS.Count != 0)
            {
                //PaintingWorksJournalDTO paint = ((PaintingWorksDTO)paintingWorksBS.Current);
                PaintingWorksDTO model = new PaintingWorksDTO()
                {
                    CauseReturn = ((PaintingWorksJournalDTO)ItemJournal).CauseReturn,
                    CheckQuantityOfExecution = ((PaintingWorksJournalDTO)ItemJournal).CheckQuantityOfExecution,
                    Drawing = ((PaintingWorksJournalDTO)ItemJournal).Drawing,
                    Date = ((PaintingWorksJournalDTO)ItemJournal).Date,
                    QuantityOfExecution = ((PaintingWorksJournalDTO)ItemJournal).QuantityOfExecution,
                    CorrectiveAction = ((PaintingWorksJournalDTO)ItemJournal).CorrectiveAction,
                    ResponsiblePerson = ((PaintingWorksJournalDTO)ItemJournal).ResponsiblePerson,
                    Note = ((PaintingWorksJournalDTO)ItemJournal).Note,
                //    FinalResponsibePerson = ((PaintingWorksJournalDTO)ItemJournal).FinalResponsibePerson,
                    FinalResponsiblePersonId = ((PaintingWorksJournalDTO)ItemJournal).FinalResponsiblePersonId,
                    Id = ((PaintingWorksJournalDTO)ItemJournal).Id,
                    MtsAssembliesId = ((PaintingWorksJournalDTO)ItemJournal).MtsAssembliesId,
                    NameCheckProduct = ((PaintingWorksJournalDTO)ItemJournal).NameCheckProduct,
                    NameProduct = ((PaintingWorksJournalDTO)ItemJournal).NameProduct,
                    ResponsiblePersonId = ((PaintingWorksJournalDTO)ItemJournal).ResponsiblePersonId,
                    Result = ((PaintingWorksJournalDTO)ItemJournal).Result,
                    SeqNum = ((PaintingWorksJournalDTO)ItemJournal).SeqNum,
                     FinalResponsiblePerson=((PaintingWorksJournalDTO)ItemJournal).FinalResponsiblePerson
                };
                AddPaintWorks(Utils.Operation.Update, (PaintingWorksDTO)model, this.userTasksDTO, model.SeqNum);
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeletetPaintingWorks();
        }

        private void exportToExcelBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
            string periodStr = firstDay.ToShortDateString() + " - " + lastDay.ToShortDateString();
            string exportFilePath = "Журнал малярних робіт за період " + periodStr + ".xls";
            try
            {
                paintingWorksGrid.ExportToXls(exportFilePath);
                System.Diagnostics.Process.Start(exportFilePath);
            }
            catch (Exception)
            {
                MessageBox.Show("Збереження файлу неможливе, документ вже відкритий! \n Закрийте документ і спробуйте ще.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPaintWorks(Utils.Operation.Add, new PaintingWorksDTO(), userTasksDTO, countPaint);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paintingWorksBS.Count != 0)
            {
                //PaintingWorksJournalDTO paint = ((PaintingWorksDTO)paintingWorksBS.Current);
                PaintingWorksDTO model = new PaintingWorksDTO()
                {
                    CauseReturn = ((PaintingWorksJournalDTO)ItemJournal).CauseReturn,
                    CheckQuantityOfExecution = ((PaintingWorksJournalDTO)ItemJournal).CheckQuantityOfExecution,
                    Drawing = ((PaintingWorksJournalDTO)ItemJournal).Drawing,
                    Date = ((PaintingWorksJournalDTO)ItemJournal).Date,
                    QuantityOfExecution = ((PaintingWorksJournalDTO)ItemJournal).QuantityOfExecution,
                    CorrectiveAction = ((PaintingWorksJournalDTO)ItemJournal).CorrectiveAction,
                    ResponsiblePerson = ((PaintingWorksJournalDTO)ItemJournal).ResponsiblePerson,
                    Note = ((PaintingWorksJournalDTO)ItemJournal).Note,
                    //    FinalResponsibePerson = ((PaintingWorksJournalDTO)ItemJournal).FinalResponsibePerson,
                    FinalResponsiblePersonId = ((PaintingWorksJournalDTO)ItemJournal).FinalResponsiblePersonId,
                    Id = ((PaintingWorksJournalDTO)ItemJournal).Id,
                    MtsAssembliesId = ((PaintingWorksJournalDTO)ItemJournal).MtsAssembliesId,
                    NameCheckProduct = ((PaintingWorksJournalDTO)ItemJournal).NameCheckProduct,
                    NameProduct = ((PaintingWorksJournalDTO)ItemJournal).NameProduct,
                    ResponsiblePersonId = ((PaintingWorksJournalDTO)ItemJournal).ResponsiblePersonId,
                    Result = ((PaintingWorksJournalDTO)ItemJournal).Result,
                    SeqNum = ((PaintingWorksJournalDTO)ItemJournal).SeqNum,
                    FinalResponsiblePerson = ((PaintingWorksJournalDTO)ItemJournal).FinalResponsiblePerson
                };
                AddPaintWorks(Utils.Operation.Update, (PaintingWorksDTO)model, this.userTasksDTO, model.SeqNum);
            }
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletetPaintingWorks();
        }

    }
}