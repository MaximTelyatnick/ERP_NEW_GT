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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Production
{
    public partial class StoreHouseProjectExpendituresEditSelectFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource expendituresBS = new BindingSource();
        private BindingSource receiptsBS = new BindingSource();

        private List<ExpendituresStoreHousesDTO> expendituresStoreHouseList = new List<ExpendituresStoreHousesDTO>();

        private IStoreHouseService storeHouseService;

        public StoreHouseProjectExpendituresEditSelectFm(List<ExpendituresStoreHousesDTO> expendituresStoreHouseList)
        {
            InitializeComponent();
            this.expendituresStoreHouseList = expendituresStoreHouseList;
            LoadExpendituresProjectJournal();
        }

        private void LoadExpendituresProjectJournal()
        {
            splashScreenManager.ShowWaitForm();

            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            expendituresBS.DataSource = expendituresStoreHouseList;
            expendituresGrid.DataSource = expendituresBS;
            expendituresGridView.ExpandAllGroups();

            splashScreenManager.CloseWaitForm();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool SaveItem()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            foreach (var item in expendituresStoreHouseList)
                storeHouseService.ExpendituresStoreHousesUpdate(item); 
            return true;
        }

        private void checkAllExpenditureBtn_Click(object sender, EventArgs e)
        {
            expendituresGridView.PostEditor();
            expendituresGridView.BeginDataUpdate();
            foreach (var item in expendituresStoreHouseList)
                item.Check = true;
            expendituresGridView.EndDataUpdate();
        }
    }
}