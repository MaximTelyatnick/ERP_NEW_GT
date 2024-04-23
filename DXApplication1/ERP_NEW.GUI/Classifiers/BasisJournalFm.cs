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


namespace ERP_NEW.GUI.Classifiers
{
    public partial class BasisJournalFm : DevExpress.XtraEditors.XtraForm
    {
        private ICashBookService cashBookService;
        private UserTasksDTO userTasksDTO;
        private BindingSource basisBS = new BindingSource();

        public BasisJournalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();

            LoadData();
        }
        

        #region Method's

        private void AuthorizatedUserAccess()
        {
            addbasistypeBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editbasistypeBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deletebasistypeBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            //splashScreenManager.ShowWaitForm();
            cashBookService = Program.kernel.Get<ICashBookService>();
            basisBS.DataSource = cashBookService.GetBasis();
            basisJournalGrid.DataSource = basisBS;
           // splashScreenManager.CloseWaitForm();
        }


        private void EditBasisType()
        {
            if (basisBS.Count != 0)
            {
                using (BasisJournalEditFM basisJournalEditFM = new BasisJournalEditFM(Utils.Operation.Update, (CashBookBasisTypeDTO)basisBS.Current))
                {
                    if (basisJournalEditFM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = basisJournalEditFM.Return();
                        basisJournalGrid.BeginUpdate();
                        LoadData();
                        basisJournalGrid.EndUpdate();
                        int rowHandle = basisJournalGridView.LocateByValue("Id", return_Id);
                        basisJournalGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

       

        private void AddBasisType()
        {
            using (BasisJournalEditFM basisJournalEditFM = new BasisJournalEditFM(Utils.Operation.Add, new CashBookBasisTypeDTO()))
            {
                if (basisJournalEditFM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = basisJournalEditFM.Return();
                    basisJournalGridView.BeginDataUpdate();
                    LoadData();
                    basisJournalGridView.EndDataUpdate();
                    int rowHandle = basisJournalGridView.LocateByValue("Id", return_Id);
                    basisJournalGridView.FocusedRowHandle = rowHandle;
                }
            }
        }



        private void DeleteBasisType()
        {
            if (basisBS.Count != 0)
            {
                if (MessageBox.Show("Видалити підставу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cashBookService = Program.kernel.Get<ICashBookService>();
                    int rowHandle = basisJournalGridView.FocusedRowHandle - 1;
                    basisJournalGridView.BeginDataUpdate();

                    if ((((CashBookBasisTypeDTO)basisBS.Current).Id) != -1)
                    {
                        cashBookService.CashBookBasisDelete(((CashBookBasisTypeDTO)basisBS.Current).Id);
                    }

                    LoadData();
                    basisJournalGridView.EndDataUpdate();
                    basisJournalGridView.FocusedRowHandle = (basisJournalGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
        
        #endregion






        #region Event's

        private void addbasistypeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddBasisType();
        }

        private void deletebasistypeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteBasisType();
        }

        private void editbasistypeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditBasisType();
        }
        #endregion

    }
}