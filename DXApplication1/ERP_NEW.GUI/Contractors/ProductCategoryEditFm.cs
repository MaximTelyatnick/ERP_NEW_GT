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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.Contractors
{
    public partial class ProductCategoryEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private BindingSource productCategoryBS = new BindingSource();

        private Utils.Operation operation;
        private ProductCategoriesDTO productCategory2;

        public ProductCategoryEditFm(Utils.Operation operation,ProductCategoriesDTO productCategory)
        {
            InitializeComponent();
            this.operation = operation;
            productCategory2 = productCategory;
            LoadData();
                      
            сategoryNameTBox.DataBindings.Add("EditValue", productCategoryBS, "CategoryName");
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            productCategoryBS.DataSource = productCategory2;
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if (сategoryNameTBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Не внесені дані!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.operation == Utils.Operation.Add)
            {
                productCategory2.Id = contractorsService.ProductCategotyCreate(productCategory2);
            }
            else
            {
                contractorsService.ProductCategoryUpdate(productCategory2);
            }

            this.Close();
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}