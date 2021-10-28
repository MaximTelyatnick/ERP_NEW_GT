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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class InvoiceRequirementSelectFixedAssetsFm : DevExpress.XtraEditors.XtraForm
    {
        private IStoreHouseService storeHouseService;

        private BindingSource fixedAssetsBS = new BindingSource(); 

        private InvoiceRequirementSelectFixedAssetsDTO returnModel;

        public InvoiceRequirementSelectFixedAssetsFm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            fixedAssetsBS.DataSource = storeHouseService.GetAllInvoiceRequirementSelectFixedAssets();
            invoiceRequirementSelectFixedAssetsGrid.DataSource = fixedAssetsBS;
        }

        public InvoiceRequirementSelectFixedAssetsDTO Return()
        {
            return returnModel;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            returnModel = (InvoiceRequirementSelectFixedAssetsDTO)fixedAssetsBS.Current;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void invoiceRequirementSelectFixedAssetsGridView_DoubleClick(object sender, EventArgs e)
        {
            returnModel = (InvoiceRequirementSelectFixedAssetsDTO)fixedAssetsBS.Current;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}