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
using DevExpress.XtraBars;
using System;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class CustomerOrderSpecEditFm : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource customerOrdersSpecBS = new BindingSource();
        
        private Utils.Operation _operation;
        private bool _isCurrency;

        private ObjectBase Item
        {
            get { return customerOrdersSpecBS.Current as ObjectBase; }
            set
            {
                customerOrdersSpecBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public CustomerOrderSpecEditFm(Utils.Operation operation, CustomerOrderSpecificationsDTO model, bool isCurrency)
        {
            InitializeComponent();

            _isCurrency = isCurrency;
            _operation = operation;
            customerOrdersSpecBS.DataSource = Item = model;

            nameTBox.DataBindings.Add("EditValue", customerOrdersSpecBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityTBox.DataBindings.Add("EditValue", customerOrdersSpecBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            singlePriceTBox.DataBindings.Add("EditValue", customerOrdersSpecBS, "SinglePrice", true, DataSourceUpdateMode.OnPropertyChanged);
            singleCurrencyPriceTBox.DataBindings.Add("EditValue", customerOrdersSpecBS, "SingleCurrencyPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            sumPriceTBox.DataBindings.Add("EditValue", customerOrdersSpecBS, "SumPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            sumCurrencyPriceTBox.DataBindings.Add("EditValue", customerOrdersSpecBS, "SumCurrencyPrice", true, DataSourceUpdateMode.OnPropertyChanged);

            if (_operation == Utils.Operation.Add)
            {
                model.Quantity = 0;
                model.SinglePrice= 0.0000m;
                model.SingleCurrencyPrice = 0.0000m;
                model.SumPrice = 0.0000m;
                model.SumCurrencyPrice = 0.0000m;
                Item = model;
            }

            singleCurrencyPriceTBox.Enabled = _isCurrency;
            sumCurrencyPriceTBox.Enabled = _isCurrency;

            nameTBox.Focus();
            specificationValidationProvider.Validate();
        }

        #region Metod's
                
        public CustomerOrderSpecificationsDTO Return()
        {
            return ((CustomerOrderSpecificationsDTO)Item);
        }

        private void SaveSpec()
        {
            this.Item.EndEdit();
           
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveSpec();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            this.Close();
        }
               

        #endregion

        #region Validate event's

        private void nameTBox_TextChanged(object sender, EventArgs e)
        {
            specificationValidationProvider.Validate((Control)sender);
        }

        private void quantityTBox_TextChanged(object sender, EventArgs e)
        {
            var rezultSnglePrice = (decimal)((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SinglePrice;

            if (rezultSnglePrice != null)
                sumPriceTBox.EditValue = Decimal.Round((decimal)rezultSnglePrice, 2);

            var rezultSngleCurrencyPrice = (decimal)((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SingleCurrencyPrice;

            if (rezultSngleCurrencyPrice != null)
                sumCurrencyPriceTBox.EditValue = Decimal.Round((decimal)rezultSngleCurrencyPrice, 2);

            //sumPriceTBox.EditValue = ((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SinglePrice;
            //sumCurrencyPriceTBox.EditValue = ((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SingleCurrencyPrice;

            specificationValidationProvider.Validate((Control)sender);
        }

        private void singlePriceTBox_TextChanged(object sender, EventArgs e)
        {
            var rezultSngleCurrencyPrice = (decimal)((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SinglePrice;

            if (rezultSngleCurrencyPrice != null)
                sumPriceTBox.EditValue = Decimal.Round((decimal)rezultSngleCurrencyPrice, 2);

            //sumPriceTBox.EditValue = ((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SinglePrice;


        }

        private void specificationGroupValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (specificationValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void specificationGroupValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void singleCurrencyPriceTBox_TextChanged(object sender, EventArgs e)
        {

            var rezultSnglePrice = (decimal)((CustomerOrderSpecificationsDTO)Item).Quantity * ((CustomerOrderSpecificationsDTO)Item).SingleCurrencyPrice;

            if (rezultSnglePrice != null)
                sumCurrencyPriceTBox.EditValue = Decimal.Round((decimal)rezultSnglePrice, 2);
        }

        #endregion
    }
}