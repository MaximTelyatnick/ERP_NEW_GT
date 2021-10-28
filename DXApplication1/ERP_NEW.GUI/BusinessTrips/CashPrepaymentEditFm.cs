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

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class CashPrepaymentEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        
        private BindingSource cashPrepaymentBS = new BindingSource();
        
        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return cashPrepaymentBS.Current as ObjectBase; }
            set
            {
                cashPrepaymentBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CashPrepaymentEditFm(Utils.Operation operation, CashPrepaymentsDTO model)
        {
            InitializeComponent();

            _operation = operation;

            cashPrepaymentBS.DataSource = Item = model;

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            employeesService = Program.kernel.Get<IEmployeesService>();

            prepaymentDateEdit.DataBindings.Add("EditValue", cashPrepaymentBS, "PrepaymentDate");
            prepaymentPriceTBox.DataBindings.Add("EditValue", cashPrepaymentBS, "PrepaymentPrice");

            accountEdit.DataBindings.Add("EditValue", cashPrepaymentBS, "AccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountEdit.Properties.DataSource = accountsService.GetAccounts();
            accountEdit.Properties.ValueMember = "Id";
            accountEdit.Properties.DisplayMember = "Num";
            accountEdit.Properties.NullText = "Немає данних";

            employeesEdit.DataBindings.Add("EditValue", cashPrepaymentBS, "EmployeesId", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesEdit.Properties.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "Fio";
            employeesEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {                
                ((CashPrepaymentsDTO)cashPrepaymentBS.Current).PrepaymentDate = DateTime.Now;
            }

            ((CashPrepaymentsDTO)Item).DateAdded = DateTime.Now;
                        
            ControlValidation();
        }

        #region Method's

        private bool SaveItem()
        {
            this.Item.EndEdit();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

            if (_operation == Utils.Operation.Add)
            {
                ((CashPrepaymentsDTO)Item).Id = businessTripsService.CashPrepaymentCreate((CashPrepaymentsDTO)Item);

                return true;
            }
            else
            {
                businessTripsService.CashPrepaymentUpdate((CashPrepaymentsDTO)Item);

                return true;
            }
        }

        public CashPrepaymentsDTO Return()
        {
            return ((CashPrepaymentsDTO)Item);
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
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження інформації про аванс", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Validation

        private bool ControlValidation()
        {
            return cashPrepaymentValidationProvider.Validate();
        }

        private void employeesEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void prepaymentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void accountEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void prepaymentPriceTBox_EditValueChanged(object sender, EventArgs e)
        {
            cashPrepaymentValidationProvider.Validate((Control)sender);
        }

        private void cashPrepaymentValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void cashPrepaymentValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cashPrepaymentValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion
    }
}