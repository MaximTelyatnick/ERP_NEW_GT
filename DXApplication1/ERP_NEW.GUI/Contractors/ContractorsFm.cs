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

        public UserTasksDTO _userTasksDTO;

        public ContractorsFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            _userTasksDTO = userTasksDTO;

            AuthorizatedUserAccess();
            LoadData();

            contractorsGridView.ExpandAllGroups();
            contractorsGrid.Focus();
            

            splitContainerControl1.SplitterPosition = this.Width - (this.Width / 10);
        }

        #region Method's

        public void AuthorizatedUserAccess()
        {
            addBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadData()
        {
            splashScreenManager.ShowWaitForm();
            contractorsService = Program.kernel.Get<IContractorsService>();
            if (orderCheckItem.Checked)
            {
                var allData = contractorsService.GetContractors(1); // 1 - все данные, 2 - только контрагенты без договоров}
                contractorsBS.DataSource = allData;
                contractorsGrid.DataSource = contractorsBS;
                contractorsGridView.ExpandAllGroups();
            }
            else
            {
                var contractors = contractorsService.GetContractors(2); // 1 - все данные, 2 - только контрагенты без договоров
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
            if (_userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
                 EditContractor();
        }

        private void contractorsGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (_userTasksDTO.AccessRightId == 2) //1 - доступ чтение (2- запись, 3 - просмотр цен)
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
    }
}