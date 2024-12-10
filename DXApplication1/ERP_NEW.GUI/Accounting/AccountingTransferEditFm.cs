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
using Ninject;

namespace ERP_NEW.GUI.Accounting
{
    public partial class AccountingTransferEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        private IContractorsService contractorsService;
        private IPeriodService periodService;
        private IAccountingOperationService accountingOperationService;
        private ILogService logService;

        private BindingSource accountsBS = new BindingSource();
        private BindingSource accountOperationsBS = new BindingSource();

        private Utils.Operation operation;
        private UserTasksDTO userTasksDTO;

        private const string NameForm = "AccountingTransferEditFm";

        private ObjectBase Item
        {
            get { return accountOperationsBS.Current as ObjectBase; }
            set
            {
                accountOperationsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public AccountingTransferEditFm(Utils.Operation operation, AccountingOperationsDTO model, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();
            splashScreenManager.ShowWaitForm();

            this.operation = operation;
            this.userTasksDTO = userTaskDTO;

            accountOperationsBS.DataSource = Item = model;

            employeesService = Program.kernel.Get<IEmployeesService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            accountingOperationService = Program.kernel.Get<IAccountingOperationService>();
            logService = Program.kernel.Get<ILogService>();

            if (operation == Utils.Operation.Add)
            {
                ((AccountingOperationsDTO)Item).PaymentDate = DateTime.Now;
                ((AccountingOperationsDTO)Item).PaymentPrice = 0.00m;
                ((AccountingOperationsDTO)Item).AccountingOperationId = 1;
            }
            else
            {

            }

            #region DataBinding's

            paymentDateEdit.DataBindings.Add("EditValue", accountOperationsBS, "PaymentDate", true, DataSourceUpdateMode.OnPropertyChanged);
            paymentDocumentTBox.DataBindings.Add("EditValue", accountOperationsBS, "OperateDocument", true, DataSourceUpdateMode.OnPropertyChanged);
            paymentPriceTBox.DataBindings.Add("EditValue", accountOperationsBS, "PaymentPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeEdit.DataBindings.Add("EditValue", accountOperationsBS, "Purpose", true, DataSourceUpdateMode.OnPropertyChanged);

            accountsBS.DataSource = accountsService.GetAccounts();

            contractorsEdit.DataBindings.Add("EditValue", accountOperationsBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsEdit.Properties.DataSource = contractorsService.GetContractors(1);
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            accountEdit.DataBindings.Add("EditValue", accountOperationsBS, "OperatingAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountEdit.Properties.DataSource = accountsBS;
            accountEdit.Properties.ValueMember = "Id";
            accountEdit.Properties.DisplayMember = "Num";
            accountEdit.Properties.NullText = "Немає данних";

            purposeAccountEdit.DataBindings.Add("EditValue", accountOperationsBS, "PurposeAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeAccountEdit.Properties.DataSource = accountsBS;
            purposeAccountEdit.Properties.ValueMember = "Id";
            purposeAccountEdit.Properties.DisplayMember = "Num";
            purposeAccountEdit.Properties.NullText = "Немає данних";

            accountingOperationEdit.DataBindings.Add("EditValue", accountOperationsBS, "AccountingOperationId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountingOperationEdit.Properties.DataSource = accountingOperationService.GetAccountingOperation();
            accountingOperationEdit.Properties.ValueMember = "Id";
            accountingOperationEdit.Properties.DisplayMember = "Name";
            accountingOperationEdit.Properties.NullText = "Немає данних";



            #endregion

            ControlValidation();

            splashScreenManager.CloseWaitForm();
        }

        public AccountingOperationsDTO Return()
        {
            return ((AccountingOperationsDTO)Item);
        }

        private void vatAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void vatAccountEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void accountingOperationEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void contractorsEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void purposeAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void bankAccountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void AccountingTransferEditFm_Load(object sender, EventArgs e)
        {

        }

        #region Validation

        private bool ControlValidation()
        {
            return accountTransferValidationProvider.Validate();
        }






        private void accountTransferValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void accountTransferValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (accountTransferValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        #endregion

        private void paymentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountTransferValidationProvider.Validate((Control)sender);
        }

        private void accountingOperationEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountTransferValidationProvider.Validate((Control)sender);
        }

        private void paymentDocumentTBox_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void accountEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountTransferValidationProvider.Validate((Control)sender);
        }

        private void purposeAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountTransferValidationProvider.Validate((Control)sender);
        }

        private void paymentPriceTBox_EditValueChanged(object sender, EventArgs e)
        {
            accountTransferValidationProvider.Validate((Control)sender);
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBank);
        }

        private bool CheckPeriodExist(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }

        private void OpenPeriodAccess(DateTime periodDate)
        {
            try
            {
                periodService = Program.kernel.Get<IPeriodService>();

                if (CheckPeriodAccess(periodDate))
                {
                    PeriodsDTO model = periodService.GetPeriodByKey(periodDate.Year, periodDate.Month);
                    model.StateBank = false;

                    periodService.PeriodsUpdate(model);
                }
                else
                {
                    if (CheckPeriodExist(periodDate))
                    {
                        PeriodsDTO model = periodService.GetPeriodByKey(periodDate.Year, periodDate.Month);
                        model.StateBank = true;

                        periodService.PeriodsUpdate(model);
                    }
                    else
                    {
                        PeriodsDTO model = new PeriodsDTO()
                        {
                            Year = periodDate.Year,
                            Month = periodDate.Month,
                            State = false,
                            StateBank = true,
                            StateBusinesTrip = false
                        };

                        periodService.PeriodsCreate(model);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні періоду виникла помилка. " + ex.Message, "Збереження періоду", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logService.CreateLogRecord("Error", BLL.Infrastructure.Utils.Level.Error, userTasksDTO, NameForm);
                return;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Item.EndEdit();

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    if (!CheckPeriodAccess(((AccountingOperationsDTO)Item).PaymentDate ?? DateTime.Now))
                    {
                        if (MessageBox.Show("Період закритий або не існує! Відкрити період?", "Редагування", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            OpenPeriodAccess(((AccountingOperationsDTO)Item).PaymentDate ?? DateTime.Now);
                        }
                        else
                        {
                            return;
                        }
                    }

                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logService.CreateLogRecord(ex.Message, BLL.Infrastructure.Utils.Level.Error, userTasksDTO, NameForm);
                }
            }
        }

        private bool SaveItem()
        {


            accountingOperationService = Program.kernel.Get<IAccountingOperationService>();

            switch (operation)
            {
                case Utils.Operation.Add:


                    ((AccountingOperationsDTO)Item).DateCreate = DateTime.Now;
                    ((AccountingOperationsDTO)Item).DateUpdate = DateTime.Now;

                    ((AccountingOperationsDTO)Item).Id = accountingOperationService.AccountOperationsCreate((AccountingOperationsDTO)Item);

                    return true;



                case Utils.Operation.Update:
                    //currency


                    accountingOperationService.AccountOperationsUpdate((AccountingOperationsDTO)Item);

                    return true;

                

                default:
                    return false;
            }
        }

        private void contractorsEdit_EditValueChanged(object sender, EventArgs e)
        {
            accountTransferValidationProvider.Validate((Control)sender);
        }
    }
}