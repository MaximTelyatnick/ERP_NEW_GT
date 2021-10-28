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
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ERP_NEW.BLL.DTO.ModelsDTO;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class CashBookAdditionalFm : DevExpress.XtraEditors.XtraForm
    {
        private UserTasksDTO userTasksDTO;

        private ICashBookService cashBookService;
        private BindingSource additionalBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public CashBookAdditionalFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();

            LoadData();
        }

        #region Method's

        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();

            cashBookService = Program.kernel.Get<ICashBookService>();
            additionalBS.DataSource = cashBookService.GetCashBookAdditional();
            cashBookAdditionalGrid.DataSource = additionalBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addCashBookAdditionalBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editCashBookAdditionalBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteCashBookAdditionalBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }


        private void AddAdditional()
        {
            using (CashBookAdditionalEditFm cashBookAdditionalEditFm = new CashBookAdditionalEditFm(Utils.Operation.Add, new CashBookAdditionalTypeDTO()))
            {
                if (cashBookAdditionalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = cashBookAdditionalEditFm.Return();
                    cashBookAdditionalGridView.BeginDataUpdate();
                    LoadData();
                    cashBookAdditionalGridView.EndDataUpdate();
                    int rowHandle = cashBookAdditionalGridView.LocateByValue("Id", return_Id);
                    cashBookAdditionalGridView.FocusedRowHandle = rowHandle;
                }
            }

        }

        private void EditAdditional()
        {
            if (additionalBS.Count != 0)
            {
                using (CashBookAdditionalEditFm cashBookAdditionalEditFm = new CashBookAdditionalEditFm(Utils.Operation.Update, (CashBookAdditionalTypeDTO)additionalBS.Current))
                {
                    if (cashBookAdditionalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = cashBookAdditionalEditFm.Return();
                        cashBookAdditionalGridView.BeginDataUpdate();
                        LoadData();
                        cashBookAdditionalGridView.EndDataUpdate();
                        int rowHandle = cashBookAdditionalGridView.LocateByValue("Id", return_Id);
                        cashBookAdditionalGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        private void DeleteAdditional()
        {
            if (additionalBS.Count != 0)
            {
                if (MessageBox.Show("Видалити додаток?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cashBookService = Program.kernel.Get<ICashBookService>();
                    int rowHandle = cashBookAdditionalGridView.FocusedRowHandle - 1;
                    cashBookAdditionalGridView.BeginDataUpdate();

                    if ((((CashBookAdditionalTypeDTO)additionalBS.Current).Id) != null)
                    {
                        cashBookService.CashBookAdditionalTypeDelete(((CashBookAdditionalTypeDTO)additionalBS.Current).Id);
                    }

                    LoadData();
                    cashBookAdditionalGridView.EndDataUpdate();
                    cashBookAdditionalGridView.FocusedRowHandle = (cashBookAdditionalGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        #endregion


        #region Event's

        private void addCashBookAdditionalBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddAdditional();
        }

        private void editCashBookAdditionalBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditAdditional();
        }

        private void deleteCashBookAdditionalBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteAdditional();
        }




        #endregion


    }









 
}