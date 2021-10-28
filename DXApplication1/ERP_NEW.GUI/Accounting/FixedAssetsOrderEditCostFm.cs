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
    public partial class FixedAssetsOrderEditCostFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource editCostBS = new BindingSource();
        private Utils.Operation operation;
        private IFixedAssetsOrderService fixedAssetsOrderService;

        private ObjectBase Item
        {
            get { return editCostBS.Current as ObjectBase; }
            set
            {
                editCostBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public FixedAssetsOrderEditCostFm(Utils.Operation operation, FixedAssetsMaterialsDTO model)
        {
            InitializeComponent();
            this.operation = operation;

            editCostBS.DataSource = Item = model;
            fixedAssetsOrderService = Program.kernel.Get<IFixedAssetsOrderService>();
            dateEdit.DataBindings.Add("EditValue", editCostBS, "ExpDate", true, DataSourceUpdateMode.OnPropertyChanged);

            if (operation == Utils.Operation.Add)
            {
                ((FixedAssetsMaterialsDTO)Item).ExpDate = DateTime.Now;               
            }
            else
            {
                reasonEdit.Text = model.Description;
                sumaEdit.EditValue = model.FixedPrice;
       
                if (model.Flag == 1)
                    increaseCostCheckBox.Checked = true;
                else
                    increaseCostCheckBox.Checked = false;
            }
        }
        

        private bool SaveItem()
        {
            this.Item.EndEdit();
            if (operation == Utils.Operation.Add)
            {
                if (sumaEdit.Text.Length <= 0)
                {
                    MessageBox.Show("Поле сума порожнє!");
                    return false;
                }
                ((FixedAssetsMaterialsDTO)Item).Description = reasonEdit.Text;
                ((FixedAssetsMaterialsDTO)Item).Name = reasonEdit.Text;
                ((FixedAssetsMaterialsDTO)Item).MaterialsDate = (DateTime)dateEdit.EditValue;
                ((FixedAssetsMaterialsDTO)Item).FixedPrice = (decimal)sumaEdit.EditValue;
            }
            if (operation == Utils.Operation.Update)
            {
                ((FixedAssetsMaterialsDTO)Item).Id = ((FixedAssetsMaterialsDTO)Item).Id;
                ((FixedAssetsMaterialsDTO)Item).Description = reasonEdit.Text;
                ((FixedAssetsMaterialsDTO)Item).Name = reasonEdit.Text;
                ((FixedAssetsMaterialsDTO)Item).MaterialsDate = (DateTime)dateEdit.EditValue;
                ((FixedAssetsMaterialsDTO)Item).FixedPrice = (decimal)sumaEdit.EditValue;
            }
            if (increaseCostCheckBox.Checked)
                ((FixedAssetsMaterialsDTO)Item).Flag = 1;
            else
                ((FixedAssetsMaterialsDTO)Item).Flag = 2;
            return true;
        }

        public FixedAssetsMaterialsDTO Return()
        {
            return ((FixedAssetsMaterialsDTO)Item);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
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
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}