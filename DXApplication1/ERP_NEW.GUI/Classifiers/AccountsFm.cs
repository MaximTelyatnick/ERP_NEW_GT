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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System;
using System.Diagnostics;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class AccountsFm : DevExpress.XtraEditors.XtraForm
    {

        private IAccountsService accountsService;
        private BindingSource accountsBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;
        
        public AccountsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            _userTasksDTO = userTasksDTO;
            LoadData();
            AuthorizatedUserAccess();
        }

        #region Method's
        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();

            accountsService = Program.kernel.Get<IAccountsService>();
            accountsBS.DataSource = accountsService.GetAccounts();
            accountsGrid.DataSource = accountsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addAccountBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editAccountBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteAccountBtn.Enabled = (_userTasksDTO.AccessRightId == 2);

        }


        private void DeleteAccounts()
        {
            if (accountsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити рахунок?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    accountsService = Program.kernel.Get<IAccountsService>();
                    int rowHandle = accountsGridView.FocusedRowHandle - 1;

                    accountsGridView.BeginDataUpdate();
                    if (!accountsService.AccountsDelete(((AccountsDTO)accountsBS.Current).Id))
                        MessageBox.Show("Не можливо видалити рахунок, він задіяний у Бпнківских операціях!", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadData();
                    accountsGridView.EndDataUpdate();

                    accountsGridView.FocusedRowHandle = (accountsGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }
        private void AddAccount()
        {
            using (AccountsEditFm accountsEditFm = new AccountsEditFm(Utils.Operation.Add, new AccountsDTO()))
            {
                if (accountsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = accountsEditFm.Return();
                    accountsGridView.BeginDataUpdate();
                    LoadData();
                    accountsGridView.EndDataUpdate();
                    int rowHandle = accountsGridView.LocateByValue("Id", return_Id);
                    accountsGridView.FocusedRowHandle = rowHandle;

                }
            }
        }
        private void EditAccount()
        {
            if (accountsBS.Count != 0)
            {
                using (AccountsEditFm accountsEditFm = new AccountsEditFm(Utils.Operation.Update, (AccountsDTO)accountsBS.Current))
                {
                    if (accountsEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = accountsEditFm.Return();
                        accountsGridView.BeginDataUpdate();
                        LoadData();
                        accountsGridView.EndDataUpdate();
                        int rowHandle = accountsGridView.LocateByValue("Id", return_Id);
                        accountsGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        #endregion

        #region Event's

        private void addAccountBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddAccount();
        }

        private void editAccountBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditAccount();
        }

        private void deleteAccountBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteAccounts();
        }

        private void updateAccountBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            accountsGridView.BeginDataUpdate();
            LoadData();
            accountsGridView.EndDataUpdate();
        }

        private void accountsGrid_DoubleClick(object sender, System.EventArgs e)
        {
            EditAccount();
        }
        #endregion

        

        



    }
}