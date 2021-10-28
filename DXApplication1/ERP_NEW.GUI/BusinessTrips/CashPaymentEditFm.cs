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
using DevExpress.XtraEditors.Repository;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.SelectedDTO;
using Ninject;
using ERP_NEW.BLL.Services;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class CashPaymentEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IAccountsService accountsService;
        private ICustomerOrdersService customerOrdersService;

        private BindingSource cashPaymentBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return cashPaymentBS.Current as ObjectBase; }
            set
            {
                cashPaymentBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CashPaymentEditFm(Utils.Operation operation, CashPaymentsDTO model)
        {
            InitializeComponent();

            _operation = operation;

            cashPaymentBS.DataSource = Item = model;

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

            accountEdit.DataBindings.Add("EditValue", cashPaymentBS, "VatAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountEdit.Properties.DataSource = accountsService.GetAccounts();
            accountEdit.Properties.ValueMember = "Id";
            accountEdit.Properties.DisplayMember = "Num";
            accountEdit.Properties.NullText = "Немає данних";

            customerOrdersEdit.DataBindings.Add("EditValue", cashPaymentBS, "CustomerOrderId", true, DataSourceUpdateMode.OnPropertyChanged);
            customerOrdersEdit.Properties.DataSource = customerOrdersService.GetCustomerOrdersFull();
            customerOrdersEdit.Properties.ValueMember = "Id";
            customerOrdersEdit.Properties.DisplayMember = "OrderNumber";
            customerOrdersEdit.Properties.NullText = "Немає данних";
        }

        #region Method's

        private bool SaveItem()
        {
            this.Item.EndEdit();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                        
            businessTripsService.CashPaymentUpdate((CashPaymentsDTO)Item);
            
            return true;
        }

        public CashPaymentsDTO Return()
        {
            return ((CashPaymentsDTO)Item);
        }

        #endregion

        #region Event's

        private void accountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
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
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження інформації про звіт", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void customerOrdersEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 1)
            {
                customerOrdersEdit.EditValue = null;
                customerOrdersEdit.Properties.NullText = "Немає данних";
            }
        }

        #endregion
    }
}