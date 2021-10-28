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
    public partial class CashBookContractorFm : System.Windows.Forms.Form
    {

        private UserTasksDTO userTasksDTO;

        private ICashBookService contractorService;
        private BindingSource contractorBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;

        public CashBookContractorFm(UserTasksDTO userTasksDTO)
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

            contractorService = Program.kernel.Get<ICashBookService>();
            contractorBS.DataSource = contractorService.GetContractors();
            cashBookContractorGrid.DataSource = contractorBS;

            splashScreenManager.CloseWaitForm();
        }

        private void AuthorizatedUserAccess()
        {
            addCashBookContractorBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editCashBookContractorBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteCashBookContractorBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void AddContragent() 
        {
            using (CashBookContractorEditFm cashBookContractorEditFM = new CashBookContractorEditFm(Utils.Operation.Add, new CashBookContractorDTO()))
            {
                if (cashBookContractorEditFM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    long return_Id = cashBookContractorEditFM.Return();
                    cashBookContractorGridView.BeginDataUpdate();
                    LoadData();
                    cashBookContractorGridView.EndDataUpdate();
                    int rowHandle = cashBookContractorGridView.LocateByValue("Id", return_Id);
                    cashBookContractorGridView.FocusedRowHandle = rowHandle;
                }
            }
       
        }
        private void EditContragent()
        {
            if (contractorBS.Count != 0)
            {
                using (CashBookContractorEditFm cashBookContractorEditFM = new CashBookContractorEditFm(Utils.Operation.Update, (CashBookContractorDTO)contractorBS.Current))
                {
                    if (cashBookContractorEditFM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        long return_Id = cashBookContractorEditFM.Return();
                        cashBookContractorGridView.BeginDataUpdate();
                        LoadData();
                        cashBookContractorGridView.EndDataUpdate();
                        int rowHandle = cashBookContractorGridView.LocateByValue("Id", return_Id);
                        cashBookContractorGridView.FocusedRowHandle = rowHandle;
                    }
                }
            }
        }

        private void DeleteContragent()
        {
            if (contractorBS.Count != 0)
            {
                if (MessageBox.Show("Видалити контрагента?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contractorService = Program.kernel.Get<ICashBookService>();
                    int rowHandle = cashBookContractorGridView.FocusedRowHandle - 1;
                    cashBookContractorGridView.BeginDataUpdate();

                    if ((((CashBookContractorDTO)contractorBS.Current).Id) != null)
                    {
                        contractorService.CashBookContractorDelete(((CashBookContractorDTO)contractorBS.Current).Id);
                    }

                    LoadData();
                    cashBookContractorGridView.EndDataUpdate();
                    cashBookContractorGridView.FocusedRowHandle = (cashBookContractorGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }




        #endregion

        #region Event's

        private void AddCashBookContractorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddContragent();
        }
           
        private void DeleteCashBookContractorBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteContragent();
        }

        private void EditCashBookContractorBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditContragent();
        }

        #endregion




    }

}

