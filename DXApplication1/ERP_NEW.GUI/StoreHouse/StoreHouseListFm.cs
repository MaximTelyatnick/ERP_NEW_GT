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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseListFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource storeHousesBS = new BindingSource();

        private UserTasksDTO _userTasksDTO;

        public StoreHouseListFm(UserTasksDTO userTasksDTO)
        {
            InitializeComponent();
            LoadDataStoreHouses();
            _userTasksDTO = userTasksDTO;
        }

        private void EditStoreHouses(Utils.Operation operation, StorehousesDTO model)
        {
            using (StoreHouseListEditFm storeHouseListEditFm = new StoreHouseListEditFm(operation, model))
            {
                if (storeHouseListEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StorehousesDTO storehousesDTO = storeHouseListEditFm.Return();
                    storeHouseListGridView.BeginDataUpdate();

                    LoadDataStoreHouses();

                    storeHouseListGridView.EndDataUpdate();
                }
                else
                {

                    LoadDataStoreHouses();

                }
            }
        }

        private void AuthorizatedUserAccess()
        {
            showBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            addStoreHouseBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            editStoreHouseBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            deleteStoreHouseBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
            updateStoreHouseBtn.Enabled = (_userTasksDTO.AccessRightId == 2);
        }

        private void LoadDataStoreHouses()
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            storeHousesBS.DataSource = storeHouseService.GetAllStorehouses();
            storeHouseListGrid.DataSource = storeHousesBS;

            splashScreenManager.CloseWaitForm();
        }

        private void DeleteStoreHouses()
        {
            if (storeHousesBS.Count != 0)
            {
                if (MessageBox.Show("Видалити склад?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    storeHouseService = Program.kernel.Get<IStoreHouseService>();
                    int rowHandle = storeHouseListGridView.FocusedRowHandle - 1;
                    storeHouseListGridView.BeginDataUpdate();
                    storeHouseService.StoreHousesDelete(((StorehousesDTO)storeHousesBS.Current).Id);
                    LoadDataStoreHouses();
                    storeHouseListGridView.EndDataUpdate();
                    storeHouseListGridView.FocusedRowHandle = (storeHouseListGridView.IsValidRowHandle(rowHandle)) ? rowHandle : -1;
                }
            }
        }

        private void addStoreHouseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditStoreHouses(Utils.Operation.Add, new StorehousesDTO());
        }

        private void editStoreHouseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (storeHousesBS.Count > 0)
                EditStoreHouses(Utils.Operation.Update, (StorehousesDTO)storeHousesBS.Current);
        }

        private void updateStoreHouseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataStoreHouses();
        }

        private void deleteStoreHouseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            splashScreenManager.ShowWaitForm();

            bool flag = storeHouseService.GetReceiptsByStoreHouseId(((StorehousesDTO)storeHousesBS.Current).Id);

            splashScreenManager.CloseWaitForm();

            if (!flag)
            {
                try
                {
                    DeleteStoreHouses();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("При видаленні виникла помилка." + ex.Message, "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("При видаленні виникла помилка.", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }

        private void storeHouseListGridView_DoubleClick(object sender, EventArgs e)
        {
            if (storeHousesBS.Count > 0)
                EditStoreHouses(Utils.Operation.Update, (StorehousesDTO)storeHousesBS.Current);
        
        }


    }
}