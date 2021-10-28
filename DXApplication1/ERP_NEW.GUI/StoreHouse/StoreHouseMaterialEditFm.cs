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
using Ninject;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class StoreHouseMaterialEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource materialsBS = new BindingSource();

        private List<MaterialsForAccountClothesDTO> returnMaterialList = new List<MaterialsForAccountClothesDTO>();

        public StoreHouseMaterialEditFm()
        {
            InitializeComponent();

            beginDateEdit.EditValue = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            endDateEdit.EditValue = DateTime.Now;

            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            materialsBS.DataSource = storeHouseService.GetMaterialsForAccountClothes(beginDate, endDate);
            materialsGrid.DataSource = materialsBS;  
        }

        public List<MaterialsForAccountClothesDTO> Return()
        {
            return returnMaterialList;
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            materialsGridView.PostEditor();

            returnMaterialList = ((List<MaterialsForAccountClothesDTO>)materialsBS.DataSource).Where(s => s.Selected).ToList();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}