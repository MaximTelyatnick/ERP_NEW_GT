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
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using ERP_NEW.BLL.Services;
using System.IO;
using DevExpress.XtraEditors.Repository;

namespace ERP_NEW.GUI.Accounting
{
    public partial class CalcWithBuyersSpecEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IAccountsService accountsService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource calcWithBuyersSpecBS = new BindingSource();

        private Utils.Operation _operation;

        private List<CustomerOrdersForCWBDTO> _customerOrderList;

        private ObjectBase Item
        {
            get { return calcWithBuyersSpecBS.Current as ObjectBase; }
            set
            {
                calcWithBuyersSpecBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CalcWithBuyersSpecEditFm(Utils.Operation operation, CalcWithBuyersSpecDTO model, List<CustomerOrdersForCWBDTO> customerOrderList)
        {
            InitializeComponent();

            _operation = operation;
            _customerOrderList = customerOrderList;

            calcWithBuyersSpecBS.DataSource = Item = model;

            accountsService = Program.kernel.Get<IAccountsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            paymentPriceTBox.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "PaymentPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            paymentPriceCurrencyTBox.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "PaymentPriceCurrency", true, DataSourceUpdateMode.OnPropertyChanged);
            quantityTBox.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "Quantity", true, DataSourceUpdateMode.OnPropertyChanged);
            detailsEdit.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "Details", true, DataSourceUpdateMode.OnPropertyChanged);
            vatPayment6412TBox.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "VatPayment6412", true, DataSourceUpdateMode.OnPropertyChanged);
            vatPayment643TBox.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "VatPayment643", true, DataSourceUpdateMode.OnPropertyChanged);

            cpvCodeEdit.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "CpvCode", true, DataSourceUpdateMode.OnPropertyChanged);
            uktvCodeEdit.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "UktvCode", true, DataSourceUpdateMode.OnPropertyChanged);
            dkppCodeEdit.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "DkppCode", true, DataSourceUpdateMode.OnPropertyChanged);
                        
            customerOrdersSpecEdit.DataBindings.Add("EditValue", calcWithBuyersSpecBS, "CustomerOrderSpecId", true, DataSourceUpdateMode.OnPropertyChanged);
            customerOrdersSpecEdit.Properties.DataSource = customerOrdersService.GetCustomerOrderSpecificationsByOrderList(_customerOrderList);
            customerOrdersSpecEdit.Properties.ValueMember = "Id";
            customerOrdersSpecEdit.Properties.DisplayMember = "Name";
            customerOrdersSpecEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Add)
            {
                ((CalcWithBuyersSpecDTO)Item).PaymentPrice = 0.00m;
                ((CalcWithBuyersSpecDTO)Item).PaymentPriceCurrency = 0.00m;
                ((CalcWithBuyersSpecDTO)Item).VatPayment6412 = 0.00m;
                ((CalcWithBuyersSpecDTO)Item).VatPayment643 = 0.00m;
                ((CalcWithBuyersSpecDTO)Item).Quantity = 0m;
            }
            else
            {
                ((CalcWithBuyersSpecDTO)Item).VatPayment6412 = ((CalcWithBuyersSpecDTO)Item).VatPayment6412 ?? 0.00m;
                ((CalcWithBuyersSpecDTO)Item).VatPayment643 = ((CalcWithBuyersSpecDTO)Item).VatPayment643 ?? 0.00m;
            }
        }

        public CalcWithBuyersSpecDTO Return()
        {
            return (CalcWithBuyersSpecDTO)Item;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ((CalcWithBuyersSpecDTO)Item).SpecificationName = (customerOrdersSpecEdit.EditValue != DBNull.Value) ? customerOrdersSpecEdit.Text : String.Empty;
            ((CalcWithBuyersSpecDTO)Item).VatSum = ((CalcWithBuyersSpecDTO)Item).VatPayment6412 + ((CalcWithBuyersSpecDTO)Item).VatPayment643;
            ((CalcWithBuyersSpecDTO)Item).TotalPrice = ((CalcWithBuyersSpecDTO)Item).PaymentPrice + ((CalcWithBuyersSpecDTO)Item).VatSum;
            ((CalcWithBuyersSpecDTO)Item).CustomerOrderNumber = (customerOrdersSpecEdit.EditValue != DBNull.Value) ? ((CustomerOrderSpecificationsDTO)customerOrdersSpecEdit.GetSelectedDataRow()).CustomerOrderNumber : String.Empty;

            this.Item.EndEdit();
                        
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cpvCodeEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0: 
                    {
                        using (CalcWithBuyersCpvSelectFm calcWithBuyersCpvSelectFm = new CalcWithBuyersCpvSelectFm())
                        {
                            if (calcWithBuyersCpvSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                var returnModel = calcWithBuyersCpvSelectFm.Return();

                                cpvCodeEdit.EditValue = returnModel.CodeCPV;
                                ((CalcWithBuyersSpecDTO)Item).CpvId = returnModel.Id;
                            }
                        }
                        break;
                    }
                case 1: //Очистити
                    {
                        cpvCodeEdit.EditValue = null;
                        ((CalcWithBuyersSpecDTO)Item).CpvCode = "";
                        break;                        
                    }
            }
        }

        private void uktvCodeEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    {
                        using (CalcWithBuyersUktvSelectFm calcWithBuyersUktvSelectFm = new CalcWithBuyersUktvSelectFm())
                        {
                            if (calcWithBuyersUktvSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                var returnModel = calcWithBuyersUktvSelectFm.Return();

                                uktvCodeEdit.EditValue = returnModel.CodeUKTV;
                                ((CalcWithBuyersSpecDTO)Item).UktvId = returnModel.Id;
                            }
                        }
                        break;
                    }
                case 1: //Очистити
                    {
                        uktvCodeEdit.EditValue = null;
                        ((CalcWithBuyersSpecDTO)Item).UktvCode = "";
                        break;
                    }
            }
        }

        private void dkppCodeEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    {
                        using (CalcWithBuyersDkppSelectFm calcWithBuyersDkppSelectFm = new CalcWithBuyersDkppSelectFm())
                        {
                            if (calcWithBuyersDkppSelectFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                var returnModel = calcWithBuyersDkppSelectFm.Return();

                                dkppCodeEdit.EditValue = returnModel.CodeDKPP;
                                ((CalcWithBuyersSpecDTO)Item).DkppId = returnModel.Id;
                            }
                        }
                        break;
                    }
                case 1: //Очистити
                    {
                        dkppCodeEdit.EditValue = null;
                        ((CalcWithBuyersSpecDTO)Item).DkppCode = "";
                        break;
                    }
            }
        }

        private void customerOrdersSpecEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }
        
        private void customerOrdersSpecEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        customerOrdersSpecEdit.EditValue = null;
                        break;
                    }
            }
        }
    }
}