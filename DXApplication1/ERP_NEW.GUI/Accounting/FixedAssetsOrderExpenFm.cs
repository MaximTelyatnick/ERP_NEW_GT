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
using ERP_NEW.BLL.Infrastructure;
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderExpenFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedAssetsOrderService;

        private List<FixedAssetsMaterialsDTO> materialsList = new List<FixedAssetsMaterialsDTO>();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource fixedAssetsOrderBS = new BindingSource();

        private ObjectBase ItemMaterial
        {
            get { return materialsBS.Current as ObjectBase; }
            set
            {
                materialsBS.DataSource = value;
                value.BeginEdit();
            }
        }
        private ObjectBase Item
        {
            get { return fixedAssetsOrderBS.Current as ObjectBase; }
            set
            {
                fixedAssetsOrderBS.DataSource = value;
                value.BeginEdit();
            }
        }


        public FixedAssetsOrderExpenFm(FixedAssetsOrderDTO model, List<FixedAssetsMaterialsDTO> sourceMaterials)
        {
            InitializeComponent();
            materialsList = sourceMaterials;
            fixedAssetsOrderBS.DataSource = Item = model;

            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();

            materialsBS.DataSource = materialsList;
            soldFixedAssetsOrderGrid.DataSource = materialsBS;
            foreach (var test in materialsList)
            {
                ((FixedAssetsMaterialsDTO)test).SoldPrice = ((FixedAssetsMaterialsDTO)test).FixedPrice;
            }
            fixedCardNameLabel.Text = model.InventoryName;
            dateEdit1.EditValue = DateTime.Now.Date;

        }

        public FixedAssetsOrderDTO ReturnInt()
        {
            return ((FixedAssetsOrderDTO)Item);
        }

        #region Method's


        private bool SaveItem()
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            ((FixedAssetsOrderDTO)Item).EndRecordDate = (DateTime)dateEdit1.EditValue;
            ((FixedAssetsOrderDTO)Item).FixedCardStatus = 4;
            fixedAssetsOrderService.FixedAssetsOrderUpdate((FixedAssetsOrderDTO)Item);
            decimal sum = 0;
            foreach (var test in materialsList)
            {
                sum += test.FixedPrice;
            }
            ((FixedAssetsMaterialsDTO)ItemMaterial).SoldPrice = sum;
            fixedAssetsOrderService.FixedAssetsOrderMaterialsUpdate((FixedAssetsMaterialsDTO)ItemMaterial);
            return true;
        }
        #endregion

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
                    else
                    {
                        // MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}