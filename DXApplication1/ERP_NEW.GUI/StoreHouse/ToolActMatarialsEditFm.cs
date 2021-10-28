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
using Ninject;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class ToolActMatarialsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource materialsBS = new BindingSource();

        private List<MaterialsForToolActsDTO> returnMaterialList = new List<MaterialsForToolActsDTO>();


        public ToolActMatarialsEditFm()
        {
            InitializeComponent();

            beginDateEdit.EditValue = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            endDateEdit.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
        }

        #region Method's                             

        private void LoadData(DateTime beginDate, DateTime endDate)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            materialsBS.DataSource = storeHouseService.GetMaterialsForToolActs(beginDate, endDate);
            materialsGrid.DataSource = materialsBS;
        }

        public List<MaterialsForToolActsDTO> Return()
        {
            return returnMaterialList;
        }

        #endregion

        #region Event's                              

        private void okBtn_Click(object sender, EventArgs e)
        {
            materialsGridView.PostEditor();

            returnMaterialList = ((List<MaterialsForToolActsDTO>)materialsBS.DataSource).Where(s => s.Selected).ToList();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void showBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (beginDateEdit.EditValue != null && endDateEdit.EditValue != null)
                LoadData((DateTime)beginDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
            else
                MessageBox.Show("Не вірно задана дата пошуку. ", "Не вірна дата", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        

        #endregion

        

    }
}