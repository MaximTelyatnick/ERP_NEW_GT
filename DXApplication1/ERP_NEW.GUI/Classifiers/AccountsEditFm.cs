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

namespace ERP_NEW.GUI.Classifiers
{
    public partial class AccountsEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IAccountsService accountsService;
        private BindingSource accountsBS = new BindingSource();
        private BindingSource typeAccountsBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;
        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return accountsBS.Current as ObjectBase; }
            set
            {
                accountsBS.DataSource = value;

                value.BeginEdit();
            }
        }

       

        public AccountsEditFm(Utils.Operation operation, AccountsDTO model)
        {
            InitializeComponent();
            LoadData();
            _operation = operation;

            accountsBS.DataSource = Item = model;
            typeAccountsBS.DataSource = accountsService.GetAccountsTypes();

            accountNumberEdit.DataBindings.Add("EditValue", accountsBS, "Num");

            accountDescriptionEdit.DataBindings.Add("EditValue", accountsBS, "Description");

            accountTypeEdit.DataBindings.Add("EditValue", accountsBS, "Type", true, DataSourceUpdateMode.OnPropertyChanged);
            accountTypeEdit.Properties.DataSource = typeAccountsBS.DataSource;
            accountTypeEdit.Properties.ValueMember = "Id";
            accountTypeEdit.Properties.DisplayMember = "TypeName";
            accountTypeEdit.Properties.NullText = "Відсутні данні";

            if (_operation == Utils.Operation.Update)
            {
                accountNumberEdit.EditValue = ((AccountsDTO)Item).Num;
                accountDescriptionEdit.EditValue = ((AccountsDTO)Item).Description;
                
            }
            else
            {
                accountNumberEdit.EditValue = null;
                accountDescriptionEdit.EditValue = null;
                Item = model;
                ((AccountsDTO)Item).Type = 1;
            }

        }




        #region Method's

        private void LoadData()
        {
            accountsService = Program.kernel.Get<IAccountsService>();
            accountsBS.DataSource = accountsService.GetAccounts();
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();

            if (FindDublicate((AccountsDTO)this.Item))
            {
                MessageBox.Show("Рахунок з таким номеров вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                accountsService = Program.kernel.Get<IAccountsService>();

                if (_operation == Utils.Operation.Add)
                    ((AccountsDTO)Item).Id = accountsService.AccountsCreate((AccountsDTO)Item);
                else
                    accountsService.AccountsUpdate((AccountsDTO)Item);
                return true;
            }
            
        }

        private bool FindDublicate(AccountsDTO model)
        {
            accountsService = Program.kernel.Get<IAccountsService>();
            return accountsService.GetAccounts().Any(s => s.Num == model.Num && s.Id != model.Id);
        }

        public long Return()
        {
            return ((AccountsDTO)Item).Id;
        }

        #endregion

        #region Event's
        
        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveItem())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
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

        #region Validation's

        private bool ControlValidation()
        {
            return accountsValidationProvider.Validate();
        }

        private void accountsValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void accountsValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (accountsValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void accountNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountsValidationProvider.Validate((Control)sender);
        }

        

        #endregion
    }
}