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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using DevExpress.XtraGrid.Views.Grid;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;

namespace ERP_NEW.GUI.Classifiers
{
    public partial class DeliveryEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource deliveryBS = new BindingSource();
        private IStoreHouseService storeHouseService;
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return deliveryBS.Current as ObjectBase; }
            set
            {
                deliveryBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DeliveryEditFm(Utils.Operation operation, DeliveryDTO model)
        {
            InitializeComponent();
            this.operation = operation;
            deliveryBS.DataSource = Item = model;
            LoadData();
            
            nameDeliveryEdit.DataBindings.Add("EditValue", deliveryBS, "DeliveryName", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #region Method's

        private void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

        }

        public int ReturnItem()
        {
            return ((DeliveryDTO)Item).Id;
        }

        public DeliveryDTO Return()
        {
            return ((DeliveryDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            if (!IsDuplicateDelivery(nameDeliveryEdit.EditValue.ToString()))
            {
                if (operation == Utils.Operation.Add)
                {
                    
                    ((DeliveryDTO)Item).Id = storeHouseService.DeliveryCreate((DeliveryDTO)Item);
                }

                else
                    storeHouseService.DeliveryUpdate((DeliveryDTO)Item);
                return true;      
            }
            else
            { 
                MessageBox.Show("Введений перевізник вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
         }

        private bool IsDuplicateDelivery(string deliveryName)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            return storeHouseService.GetDelivery().Any(s => s.DeliveryName == deliveryName);
        }
        #endregion

        #region Event's

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
                    MessageBox.Show("error" + ex.Message, "Збереження ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return deliveryValidationProvider.Validate();
        }      

        private void deliveryValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void deliveryValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (deliveryValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void nameDeliveryEdit_EditValueChanged(object sender, EventArgs e)
        {
            deliveryValidationProvider.Validate((Control)sender);
        }

        #endregion

    }    
}
