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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Contractors
{
    public partial class ContractorsFm : DevExpress.XtraEditors.XtraForm
    {
        public IContractorsService contractorsService;
        
        public BindingSource contractorsBS = new BindingSource();
        public BindingSource contractorContactAddressBS = new BindingSource();
        public BindingSource contactPersonAddressBS = new BindingSource();

        public UserTasksDTO userTasksDTO;

        public ContractorsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();
            LoadData();

            contractorsGridView.ExpandAllGroups();
            contractorsGrid.Focus();
            

            splitContainerControl1.SplitterPosition = this.Width - (this.Width / 10);
        }

        #region Method's

        public void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();
            contractorsService = Program.kernel.Get<IContractorsService>();
            if (orderCheckItem.Checked)
            {
                var allData = contractorsService.GetContractors(3); // 1 - все данные(только активные), 2 - только контрагенты без договоров (только активные) }
                                                                    // 3 - все данные(и неактивные), 4 - только контрагенты без договоров (и неактивные тоже)
                contractorsBS.DataSource = allData;
                contractorsGrid.DataSource = contractorsBS;
                contractorsGridView.ExpandAllGroups();
            }
            else
            {
                var contractors = contractorsService.GetContractors(4); // 1 - все данные, 2 - только контрагенты без договоров
                contractorsBS.DataSource = contractors;
                contractorsGrid.DataSource = contractorsBS;
                contractorsGridView.ExpandAllGroups();
            }
            LoadDetails();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadDetails()
        {
            var contractorId = ((ContractorsDTO)contractorsBS.Current).Id;

            var contractorContactAddress = contractorsService.GetContractorContactAddress(contractorId);
            var contactPersonAddress = contractorsService.GetContactPersonAddress(contractorId);

            if (contractorContactAddress.Count() > 0)
            {
                contractorContactAddressBS.DataSource = contractorContactAddress;
                contractorContactAddressGrid.DataSource = contractorContactAddressBS;
            }
            else
            {
                contractorContactAddressBS.DataSource = null;
                contractorContactAddressGrid.DataSource = contractorContactAddressBS;
            }

            if (contactPersonAddress.Count() > 0)
            {
                contactPersonAddressBS.DataSource = contactPersonAddress;
                contactPersonAddressGrid.DataSource = contactPersonAddressBS;
            }
            else
            {
                contactPersonAddressBS.DataSource = null;
                contactPersonAddressGrid.DataSource = contactPersonAddressBS;
            }
        }

        private void EditContractor()
        {
            if (contractorsBS.Count > 0)
            {
                new ContractorEditFm(Utils.Operation.Update, (ContractorsDTO)contractorsBS.Current).ShowDialog();
                LoadData();
                contractorsGridView.ExpandAllGroups();
                contractorsGrid.Focus();
            }
        }

        private void AddContractor()
        {
            new ContractorEditFm(Utils.Operation.Add, new ContractorsDTO()).ShowDialog();
            
            contractorsGridView.ExpandAllGroups();
            contractorsGrid.Focus();
            LoadData();
        }

        private void DeleteContractor()
        {
            if (contractorsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити контрагента?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (this.contractorsService.ContractorDelete(((ContractorsDTO)contractorsBS.Current).Id))
                    {
                        LoadData();
                        contractorsGridView.ExpandAllGroups();
                        contractorsGrid.Focus();
                    }
                }
            }
        }

        #endregion

        #region Event's

        private void contractorsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           if (contractorsGridView.FocusedRowHandle != -1)
               LoadDetails();
        }

        private void contractorsContactAddressGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column == imageCol && e.IsGetData)
            {
                int flag = (int)((ContractorContactAddressDTO)contractorContactAddressBS[e.ListSourceRowIndex]).TypeId - 1;

                e.Value = imageCollection.Images[flag];
            }
        }
        
        private void contractorsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
                 EditContractor();
        }

        private void contractorsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
            {
                if (e.KeyCode == Keys.Delete && ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount > 0)
                {
                    DeleteContractor();
                }
                if (e.KeyCode == Keys.Insert && ((DevExpress.XtraGrid.Views.Grid.GridView)sender).RowCount > 0)
                {
                    AddContractor();
                }
            }
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddContractor();
        }

        private void editBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(contractorsBS.Count > 0)
                EditContractor();
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (contractorsBS.Count > 0)
                DeleteContractor();
        }

        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void contractorsGridView_DoubleClick_1(object sender, System.EventArgs e)
        {
            if (contractorsBS.Count > 0)
                EditContractor();
        }    

        private void orderCheckItem_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            LoadData();
            contractorsGridView.ExpandAllGroups();
        }
        #endregion

        private void dublicateSearchBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (ContractorFindDuplicateFm contractorFindDuplicateFm = new ContractorFindDuplicateFm(userTasksDTO))
            {
                if (contractorFindDuplicateFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }
        }


        private void contractorAgreementsEdit(Utils.Operation operation, ContractorsDTO model, UserTasksDTO userTasksDTO)
        {
            using (ContractorAgreementEditFm contractorAgreementEditFm = new ContractorAgreementEditFm(operation, model, userTasksDTO))
            {
                if (contractorAgreementEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //AgreementsDTO return_Id = agreementJournalEditFm.Return();
                    //contractorGridView.BeginDataUpdate();
                    //LoadData();
                    //contractorGridView.EndDataUpdate();
                }
            }
        }

        private void DeleteAgreementsJournal()
        {
            if (contractorsBS.Count != 0)
            {
                if (MessageBox.Show("Видалити запис?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //contractorsService = Program.kernel.Get<IContractorsService>();

                    //DeleteFileJournal();
                    //if (checkDeleteFileJournal == 0)
                    //{
                    //    if (contractorsService.AgreementsDelete(((AgreementJournalDTO)agreementJournalBS.Current).AgreementId))
                    //    {
                    //        int rowHandle = contractorGridView.FocusedRowHandle - 1;
                    //        contractorGridView.BeginDataUpdate();
                    //        LoadData();
                    //        contractorGridView.EndDataUpdate();
                    //        contractorGridView.FocusedRowHandle = (contractorGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                    //    }
                    //}
                }
            }
        }

        private void addAgreementBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            contractorAgreementsEdit(Utils.Operation.Add, new ContractorsDTO(), userTasksDTO);
        }

        private void contractorViewDetailInfoCheck_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (contractorViewDetailInfoCheck.Checked)
                splitContainerControl1.SplitterPosition = splitContainerControl1.Size.Width;
            else
                splitContainerControl1.SplitterPosition = splitContainerControl1.Panel1.Width - 400;
        }

        private void editAgreementBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            contractorAgreementsEdit(Utils.Operation.Add, ((ContractorsDTO)contractorsBS.Current), userTasksDTO);
        }
    }
}