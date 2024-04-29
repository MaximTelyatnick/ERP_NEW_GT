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
    public partial class AccountingInvoicesEditFm : DevExpress.XtraEditors.XtraForm 
    {
        private BindingSource accountingInvoicesServiceBS = new BindingSource();
        
        private IAccountingInvoicesService accountingInvoicesService;
        private IAccountsService accountsService;
        private IPeriodService periodService;
        private ILogService logService;
        private UserTasksDTO userTasksDTO;
        private const string NameForm = "AccountingInvoicesEditFm";
        
        private Utils.Operation operation;

        private BindingSource accountInvoicesBS = new BindingSource();
        private BindingSource contractorBS = new BindingSource();

     
        decimal? rezNonVat =0;
        decimal? rezVat =0;
        decimal? rezUnTax = 0;
        decimal? rezVatFormula = 0;

        private ObjectBase Item
        {
            get { return accountInvoicesBS.Current as ObjectBase; }
            set
            {
                accountInvoicesBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AccountingInvoicesEditFm(Utils.Operation operation, InvoicesDTO model, UserTasksDTO userTasksDTO)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;
            this.userTasksDTO = userTasksDTO;

            accountInvoicesBS.DataSource = Item = model;
            LoadData();

            statementDateEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Month_Invoice", true, DataSourceUpdateMode.OnPropertyChanged);
            currentDateEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Month_Current", true, DataSourceUpdateMode.OnPropertyChanged);
            numberAccountingEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Invoice_Number", true, DataSourceUpdateMode.OnPropertyChanged);
            vatEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Vat", true, DataSourceUpdateMode.OnPropertyChanged);
            untaxedEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Non_Taxable", true, DataSourceUpdateMode.OnPropertyChanged);
            nonVatEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            allRezultEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Total_Price", true, DataSourceUpdateMode.OnPropertyChanged);
            checkEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Vat_Check", true, DataSourceUpdateMode.OnPropertyChanged);
            numberEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Number_Of_Correction", true, DataSourceUpdateMode.OnPropertyChanged);
            editdateEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Date_Of_Correction", true, DataSourceUpdateMode.OnPropertyChanged);
            balAccountlookUpEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Balance_Account_Id", true, DataSourceUpdateMode.OnPropertyChanged);

            var balanceAccountList = accountingInvoicesService.GetBalaneAccount().ToList();
            balAccountlookUpEdit.Properties.DataSource = balanceAccountList;//GetAccounts();
            balAccountlookUpEdit.Properties.ValueMember = "Id";
            balAccountlookUpEdit.Properties.DisplayMember = "Name";
            balAccountlookUpEdit.Properties.NullText = "Немає данних";

            invNoteNamelookUpEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Note_Id", true, DataSourceUpdateMode.OnPropertyChanged); //same invoicesDTO ""
            List<Invoices_NotesDTO> invNoteNameList = accountingInvoicesService.GetInvNoteName().ToList();
            invNoteNamelookUpEdit.Properties.DataSource = invNoteNameList;
            invNoteNamelookUpEdit.Properties.ValueMember = "Id";
            invNoteNamelookUpEdit.Properties.DisplayMember = "Name";
            invNoteNamelookUpEdit.Properties.NullText = "Немає данних";

            regionNamelookUpEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Registry_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            List<RegistriesDTO> regisrtyList = accountingInvoicesService.GetRegistriesName().ToList();
            regionNamelookUpEdit.Properties.DataSource = regisrtyList;
            regionNamelookUpEdit.Properties.ValueMember = "Id";
            regionNamelookUpEdit.Properties.DisplayMember = "Name";
            regionNamelookUpEdit.Properties.NullText = "Немає данних";

            nameContaractorlookUpEdit.DataBindings.Add("EditValue", accountInvoicesBS, "Contractor_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorBS.DataSource = accountingInvoicesService.GetContractorName().ToList();
            nameContaractorlookUpEdit.Properties.DataSource = contractorBS;
            nameContaractorlookUpEdit.Properties.ValueMember = "Id";
            nameContaractorlookUpEdit.Properties.DisplayMember = "Name";
            nameContaractorlookUpEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {
                ((InvoicesDTO)Item).Month_Current = DateTime.Now;
                ((InvoicesDTO)Item).Month_Invoice = DateTime.Now;
                ((InvoicesDTO)Item).Vat = 0.00m;
                ((InvoicesDTO)Item).Non_Taxable = 0.00m;
                ((InvoicesDTO)Item).Price = 0.00m;
                ((InvoicesDTO)Item).Total_Price = 0.00m;
                ((InvoicesDTO)Item).Vat_Check = 0.00m;
                ((InvoicesDTO)Item).Balance_Account_Id = 7;
                ((InvoicesDTO)Item).Registry_Id = 2;
                ((InvoicesDTO)Item).Note_Id = 3;
            }

            splashScreenManager.CloseWaitForm();
        }

        #region Method's
        
        public DateTime foundCurDateEdit()
        {
            DateTime curData = (DateTime)currentDateEdit.EditValue;
            return curData;
        }

        private void LoadData()
        {
            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            periodService = Program.kernel.Get<IPeriodService>();
            logService = Program.kernel.Get<ILogService>();
        }

        public InvoicesDTO Return()
        {
            return ((InvoicesDTO)Item);
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            periodService = Program.kernel.Get<IPeriodService>();

            if (!periodService.CheckPeriodTaxInvoicesAccess((DateTime)((InvoicesDTO)Item).Month_Current))
            {
                MessageBox.Show("Період закрит або не існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (operation == Utils.Operation.Add)
            {
                if (CheckInvoicesNum())
                    return false;
                ((InvoicesDTO)Item).Contractor_Id = accountingInvoicesService.AccountsInvoiceCreate((InvoicesDTO)Item);

            }
            else
            {
                if (CheckInvoicesNum())
                    return false;
                accountingInvoicesService.AccountsInvoiceUpdate((InvoicesDTO)Item);
                    
            }
            return true;
        }

        public bool CheckInvoicesNum()
        {
            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();

            DateTime firstDate = new DateTime(((InvoicesDTO)Item).Month_Current.Year, ((InvoicesDTO)Item).Month_Current.Month, 1);
            DateTime lastDate = firstDate.AddMonths(1).AddDays(-1);

            var allInvoices = accountingInvoicesService.GetInvoices(firstDate, lastDate).Where(bdsm => bdsm.Contractor_Id == ((InvoicesDTO)Item).Contractor_Id).ToList();

            bool checkInvoicesNumber = allInvoices.Any(bdsm => bdsm.Invoice_Number == ((InvoicesDTO)Item).Invoice_Number && bdsm.Total_Price == ((InvoicesDTO)Item).Total_Price && bdsm.Number_Of_Correction == ((InvoicesDTO)Item).Number_Of_Correction && bdsm.Id != ((InvoicesDTO)Item).Id);

            return checkInvoicesNumber;
        }

        public long Returnl()
        {
            return ((InvoicesDTO)Item).Id;
        }

        #endregion

        #region Event's
  
        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBut_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Не вірний номер податкової.Такий номер вже існує.", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        numberAccountingEdit.Focus();
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("error" + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTasksDTO, NameForm);
                }
            }
        }

        private void nameContaractorlookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (((ContractorsDTO)nameContaractorlookUpEdit.GetSelectedDataRow()) != null && ((ContractorsDTO)nameContaractorlookUpEdit.GetSelectedDataRow()).Tin == null)
                MessageBox.Show("Відсутній ІНН у контрагента ", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            accountingInvoicesValidationProvider.Validate((Control)sender);
        }

        private void nonVatEdit_TextChanged(object sender, EventArgs e)
        {
            rezNonVat = ((InvoicesDTO)Item).Price;

            if (nonVatEdit.EditValue != null)
            {
                allRezultEdit.EditValue = ((InvoicesDTO)Item).Vat + ((InvoicesDTO)Item).Price + ((InvoicesDTO)Item).Non_Taxable;
                rezVatFormula =  ((InvoicesDTO)Item).Vat - (((InvoicesDTO)Item).Price * 20 / 100);
                checkEdit.EditValue = rezVatFormula;
            }
        }

        private void vatEdit_TextChanged(object sender, EventArgs e)
        {
            rezVat = ((InvoicesDTO)Item).Vat;

            if (vatEdit.EditValue != null)
            {

                allRezultEdit.EditValue = ((InvoicesDTO)Item).Vat + ((InvoicesDTO)Item).Price + ((InvoicesDTO)Item).Non_Taxable;
                checkEdit.EditValue = ((InvoicesDTO)Item).Vat - (((InvoicesDTO)Item).Price * 20 / 100);
            }
        }

        private void untaxedEdit_TextChanged(object sender, EventArgs e)
        {
            rezUnTax = ((InvoicesDTO)Item).Non_Taxable;
            if (untaxedEdit.EditValue != null)
                allRezultEdit.EditValue = ((InvoicesDTO)Item).Vat + ((InvoicesDTO)Item).Price + ((InvoicesDTO)Item).Non_Taxable;

        }

        private void nameContagentEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountingInvoicesValidationProvider.Validate((Control)sender);
        }

        private void numberAccountingEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountingInvoicesValidationProvider.Validate((Control)sender);
        }

        private void numberEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountingInvoicesValidationProvider.Validate((Control)sender);
        }

        private void untaxedEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountingInvoicesValidationProvider.Validate((Control)sender);
        }

        private void nonVatEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountingInvoicesValidationProvider.Validate((Control)sender);
        }

        public bool a, c, s, o, k, l, m;
        private void nameContaractorlookUpEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                a = false;
                if (c)
                    numberAccountingEdit.Focus();
                c = true;
            }
        }

        private void numberAccountingEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c = false;
                if (s)
                    balAccountlookUpEdit.Focus();
                s = true;
            }
        }

        private void balAccountlookUpEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                s = false;
                if (o)
                    nonVatEdit.Focus();
                o = true;
            }
        }

        private void nonVatEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                o = false;
                if (k)
                    vatEdit.Focus();
                k = true;
            }
        }

        private void vatEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                k = false;
                if (l)
                    untaxedEdit.Focus();
                l = true;
            }
        }

        private void untaxedEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                l = false;
                if (m)
                    saveBut.Focus();
                m = true;
            }
        }

        #endregion

        #region Validation's
        private bool ControlValidation()
        {
            return accountingInvoicesValidationProvider.Validate();
        }
        private void accountingInvoicesValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBut.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void accountingInvoicesValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (accountingInvoicesValidationProvider.GetInvalidControls().Count == 0);
            this.saveBut.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

    }
}
