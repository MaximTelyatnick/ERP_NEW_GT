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
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.StoreHouse
{
    public partial class DeliveryTTNEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource deliveryTTNBS = new BindingSource();
        private BindingSource deliveryBS = new BindingSource();

        private IStoreHouseService storeHouseService;
        private Utils.Operation operation;

        private ObjectBase Item
        {
            get { return deliveryTTNBS.Current as ObjectBase; }
            set
            {
                deliveryTTNBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public DeliveryTTNEditFm(Utils.Operation operation, DeliveryOrderDTO model)
        {
            InitializeComponent();
            splashScreenManager.ShowWaitForm();

            this.operation = operation;
            deliveryTTNBS.DataSource = Item = model;
            LoadData();         

            ttnEdit.DataBindings.Add("EditValue", deliveryTTNBS, "TTN", true, DataSourceUpdateMode.OnPropertyChanged);
            sumaEdit.DataBindings.Add("EditValue", deliveryTTNBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            dateEdit.DataBindings.Add("EditValue", deliveryTTNBS, "OrderDate", true, DataSourceUpdateMode.OnPropertyChanged);

            typePaymentLookUpEdit.DataBindings.Add("EditValue", deliveryTTNBS, "DeliveryPriceTypeId", true, DataSourceUpdateMode.OnPropertyChanged);
            List<DeliveryPaymentTypeDTO> typeList = storeHouseService.GetDeliveryPaymentType().ToList();
            typePaymentLookUpEdit.Properties.DataSource = typeList;
            typePaymentLookUpEdit.Properties.ValueMember = "Id";
            typePaymentLookUpEdit.Properties.DisplayMember = "DeliveryPaymentName";
            typePaymentLookUpEdit.Properties.NullText = "Немає данних";

            transferLookUpEdit.DataBindings.Add("EditValue", deliveryTTNBS, "DeliveryId", true, DataSourceUpdateMode.OnPropertyChanged);
            List<DeliveryDTO> transferList = storeHouseService.GetDelivery().ToList();
            transferLookUpEdit.Properties.DataSource = transferList;
            transferLookUpEdit.Properties.ValueMember = "Id";
            transferLookUpEdit.Properties.DisplayMember = "DeliveryName";
            transferLookUpEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {
                ((DeliveryOrderDTO)Item).OrderDate = DateTime.Now;
                ((DeliveryOrderDTO)Item).Price = 0.00m;
            }
          
            splashScreenManager.CloseWaitForm();
        }

        #region Method's

        public DeliveryOrderDTO Return()
        {
            return ((DeliveryOrderDTO)Item);
        }

        public int ReturnItem()
        {
            return ((DeliveryOrderDTO)Item).Id;
        }
        private void LoadData()
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();

            if (operation == Utils.Operation.Add)
            {
                ((DeliveryOrderDTO)Item).Id = storeHouseService.DeliveryOrderCreate((DeliveryOrderDTO)Item);
            }
            else
                storeHouseService.DeliveryOrderUpdate((DeliveryOrderDTO)Item);
            return true;
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
                    else
                    {
                        //MessageBox.Show("Не вірний номер", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message, "Збереження ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void transferEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            switch (e.Button.Index)
            {
                case 1: //ДОБАВИТЬ
                    {
                        using (DeliveryEditFm deliveryEditFm = new DeliveryEditFm(Utils.Operation.Add, new DeliveryDTO()))
                        {
                            if (deliveryEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int return_Id = deliveryEditFm.ReturnItem();
                                storeHouseService = Program.kernel.Get<IStoreHouseService>();
                                transferLookUpEdit.Properties.DataSource = storeHouseService.GetDelivery();
                                transferLookUpEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }


                case 2://УДАЛИТЬ
                    {
                        if (deliveryTTNBS.Count != 0)
                        {
                            if (transferLookUpEdit.EditValue == DBNull.Value)
                                return;
                            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                storeHouseService.DeliveryDelete(((DeliveryDTO)transferLookUpEdit.GetSelectedDataRow()).Id);
                                storeHouseService = Program.kernel.Get<IStoreHouseService>();
                                transferLookUpEdit.Properties.DataSource = storeHouseService.GetDelivery();
                                transferLookUpEdit.EditValue = null;
                                transferLookUpEdit.Properties.NullText = "Немає данних";
                            }
                        }
                        break;
                    }
            }
        }
        private void ttnEdit_EditValueChanged(object sender, EventArgs e)
        {

            deliveryTTNValidationProvider.Validate((Control)sender);
        }
        private void transferLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            deliveryTTNValidationProvider.Validate((Control)sender);
        }

        private void typePaymentLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            
                deliveryTTNValidationProvider.Validate((Control)sender);
        }


        #endregion

        #region Validation's
        private bool ControlValidation()
        {
            return deliveryTTNValidationProvider.Validate();
        }

        private void deliveryTTNValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void deliveryTTNValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (deliveryTTNValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }


        #endregion

 




    }
}