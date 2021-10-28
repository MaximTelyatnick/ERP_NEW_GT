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
using ERP_NEW.BLL.Services;
using ERP_NEW.BLL.DTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using DevExpress.XtraEditors.Controls;
using Ninject;
using System.Web;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL;

namespace ERP_NEW.GUI.Accounting
{
    public partial class FixedAssetsOrderSoldFm : DevExpress.XtraEditors.XtraForm
    {
        private IFixedAssetsOrderService fixedAssetsOrderService;

        private List<FixedAssetsMaterialsDTO> materialsList = new List<FixedAssetsMaterialsDTO>();
        private BindingSource materialsBS = new BindingSource();
        private BindingSource fixedAssetsOrderBS = new BindingSource();

        const short sold = 2;
        //const short partialSold = 3;
        const short removal = 4;

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

        public FixedAssetsOrderSoldFm(FixedAssetsOrderDTO model,List<FixedAssetsMaterialsDTO> sourceMaterials)
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


        #region Method's
       
        public FixedAssetsOrderDTO ReturnInt()
        {
            return ((FixedAssetsOrderDTO)Item);
        }

        private bool SaveItem()
        {
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            ((FixedAssetsOrderDTO)Item).EndRecordDate = (DateTime)dateEdit1.EditValue;
            short group = (short)((FixedAssetsOrderDTO)Item).Group_Id;
            switch (group)
            {
                case 10:
                case 2:
                    ((FixedAssetsOrderDTO)Item).FixedCardStatus = removal;
                    break;
                default:
                    ((FixedAssetsOrderDTO)Item).FixedCardStatus = sold;

                    break;
            }
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

        #region Event's
       
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


        #endregion

    }
}