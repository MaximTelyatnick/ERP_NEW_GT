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
using ERP_NEW.GUI.Production;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.OTK
{
    public partial class ControlCheckJournalFm : DevExpress.XtraEditors.XtraForm
    {

        private IProjectDetailsService projectDetailsService;
        private BindingSource actBS = new BindingSource();
        private BindingSource projectDetailExecutorsBS = new BindingSource();
        public UserTasksDTO userTasksDTO;

        public ControlCheckJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTasksDTO;
            AuthorizatedUserAccess();
            LoadData();

        }

        private void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

            splashScreenManager.ShowWaitForm();

            var actDetails = projectDetailsService.GetControlChecksJournal().OrderByDescending(srt => srt.ControlDate).ToList();
            actBS.DataSource = actDetails;
            actJournalGrid.DataSource = actBS;

            splashScreenManager.CloseWaitForm();

        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (actBS.Count > 0)
               EditAct(Utils.Operation.Add, new ControlChecksDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (actBS.Count > 0)
                EditAct(Utils.Operation.Update, ((ControlChecksDTO)actBS.Current));
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (actBS.Count > 0)
                DeleteControlMark();
        }

        private void AddControlMark()
        {
            using (ControlCheckEditFm controlCheckEditFm = new ControlCheckEditFm(Utils.Operation.Add, new ControlChecksDTO()))
            {
                if (controlCheckEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    actJournalGridView.BeginUpdate();
                    LoadData();
                    actJournalGridView.EndUpdate();
                }
            }
        }

        //private void EditControlMark()
        //{
        //    using (ControlCheckEditFm controlCheckEditFm = new ControlCheckEditFm(Utils.Operation.Update, new ControlChecksDTO()
        //    {
        //        ProjectDetailId = ((ProjectDetailsDTO)projectDetailsBS.Current).ProjectDetailId,
        //        ControlCheckId = ((ProjectDetailsDTO)projectDetailsBS.Current).ControlCheckId ?? 0,
        //        ControlDate = ((ProjectDetailsDTO)projectDetailsBS.Current).ControlDate ?? DateTime.Now,
        //        ControlPersonId = ((ProjectDetailsDTO)projectDetailsBS.Current).ControlPersonId ?? 0,
        //        Description = ((ProjectDetailsDTO)projectDetailsBS.Current).Description,
        //        MarkDocumentNumber = ((ProjectDetailsDTO)projectDetailsBS.Current).MarkDocumentNumber

        //    }))
        //    {
        //        if (controlCheckEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            projectDetailsGridView.BeginUpdate();
        //            LoadData();
        //            projectDetailsGridView.EndUpdate();

        //        }
        //    }
        //}

        private void DeleteControlMark()
        {
            if (MessageBox.Show("Видалити відмітку?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                projectDetailsService = Program.kernel.Get<IProjectDetailsService>();

                if (this.projectDetailsService.ControlCheckDelete(((ControlChecksDTO)actBS.Current).ControlCheckId))
                    LoadData();
            }
        }

        private void EditAct(Utils.Operation operation, ControlChecksDTO model)
        {
            using (ControlCheckEditFm controlCheckEditFm = new ControlCheckEditFm(operation, model))
            {
                if (controlCheckEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    ControlChecksDTO controlChecksDTO = controlCheckEditFm.Return();

                    actJournalGridView.BeginDataUpdate();

                    LoadData();

                    actJournalGridView.EndDataUpdate();

                }
            }
        }

    }
}