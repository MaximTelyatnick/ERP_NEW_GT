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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseRemainForProjectFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private List<StoreHouseRemainsDTO> storeHouseRemainsCheckList = new List<StoreHouseRemainsDTO>();
        private List<StoreHouseRemainsDTO> storeHouseRemainsList = new List<StoreHouseRemainsDTO>();

        private BindingSource storeHouseRemainsBS = new BindingSource();

        public UserTasksDTO userTasksDTO;

        public StoreHouseRemainForProjectFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            this.userTasksDTO = userTasksDTO;

            currentDateEdit.EditValue = DateTime.Now;

            AuthorizatedUserAccess();

            LoadStoreHouseRemainsData((DateTime)currentDateEdit.EditValue);
        }

        public List<StoreHouseRemainsDTO> Return()
        {
            return storeHouseRemainsCheckList;
        }

        public void AuthorizatedUserAccess()
        {
            dateEdit.Enabled = (userTasksDTO.AccessRightId == 2);
            showBtn.Enabled = (userTasksDTO.AccessRightId == 2);
            printBtn.Enabled = (userTasksDTO.AccessRightId == 2);

            unitPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);
            remainsSumCol.Visible = (userTasksDTO.PriceAttribute == 1);
            totalPriceCol.Visible = (userTasksDTO.PriceAttribute == 1);

        }

        private void LoadStoreHouseRemainsData(DateTime dateTime)
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            storeHouseRemainsList = storeHouseService.GetStoreHouseRemainsWithinvoicesByDate(dateTime).ToList();
            storeHouseRemainsBS.DataSource = storeHouseRemainsList;
            storeHouseRemainsGrid.DataSource = storeHouseRemainsBS;

            splashScreenManager.CloseWaitForm();
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadStoreHouseRemainsData((DateTime)dateEdit.EditValue);
        }

        private void storeHouseRemainsGridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == remainsQuantityCol)
            {
                RepositoryItemSpinEdit de = new RepositoryItemSpinEdit();

                var objMyClassDto = storeHouseRemainsGridView.GetRow(e.RowHandle) as StoreHouseRemainsDTO;

                de.MinValue = 0.00m;
                de.MaxValue = ((StoreHouseRemainsDTO)objMyClassDto).RemainsQuantity;

                e.RepositoryItem = de;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            storeHouseRemainsGridView.PostEditor();

            var vvv = ((List<StoreHouseRemainsDTO>)storeHouseRemainsBS.DataSource).Where(s => s.Selected).ToList();
            storeHouseRemainsCheckList.AddRange(vvv);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}