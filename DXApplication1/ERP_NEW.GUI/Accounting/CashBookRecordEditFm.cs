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
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Interfaces;
using Ninject;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.GUI.Classifiers;

namespace ERP_NEW.GUI.Accounting
{
    public partial class CashBookRecordEditFm : DevExpress.XtraEditors.XtraForm
    {

        private ICashBookService cashBookService;
        private IAccountsService accountsService;

        private BindingSource accountsBS = new BindingSource();

        private BindingSource cashBookRecordBS = new BindingSource();

        private Utils.Operation operation;

        private DateTime pageDate;

        private List<CashBookRecordJournalDTO> models;

        private CashBookRecordJournalDTO model;
        private int cashBookId;

        private ObjectBase Item
        {
            get { return cashBookRecordBS.Current as ObjectBase; }
            set
            {
                cashBookRecordBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public CashBookRecordEditFm(Utils.Operation operation, CashBookRecordJournalDTO model, List<CashBookRecordJournalDTO> models, DateTime pageDate, int cashBookId)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            this.operation = operation;
            this.pageDate = pageDate;
            this.models = models;
            this.model = model;
            this.cashBookId = cashBookId;

            cashBookRecordBS.DataSource = Item = model;

            cashBookService = Program.kernel.Get<ICashBookService>();
            accountsService = Program.kernel.Get<IAccountsService>();

            cashBookRecordCurrencyTBox.DataBindings.Add("EditValue", cashBookRecordBS, "Payment", true, DataSourceUpdateMode.OnPropertyChanged);


            cashBookOperationEdit.DataBindings.Add("EditValue", cashBookRecordBS, "CurrencyTypeId", true, DataSourceUpdateMode.OnPropertyChanged);
            cashBookOperationEdit.Properties.DataSource = cashBookService.GetCashBookRecordType();
            cashBookOperationEdit.Properties.ValueMember = "Id";
            cashBookOperationEdit.Properties.DisplayMember = "CurrencyTypeName";
            cashBookOperationEdit.Properties.NullText = "Немає данних";

            bankAccountEdit.DataBindings.Add("EditValue", cashBookRecordBS, "BalanceAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            bankAccountEdit.Properties.DataSource = accountsService.GetAccounts();
            bankAccountEdit.Properties.ValueMember = "Id";
            bankAccountEdit.Properties.DisplayMember = "Num";
            bankAccountEdit.Properties.NullText = "Немає данних";

            cashBookContractorEdit.DataBindings.Add("EditValue", cashBookRecordBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            cashBookContractorEdit.Properties.DataSource = cashBookService.GetContractors();
            cashBookContractorEdit.Properties.ValueMember = "Id";
            cashBookContractorEdit.Properties.DisplayMember = "CashBookContractorName";
            cashBookContractorEdit.Properties.NullText = "Немає данних";

            cashBookBasisEdit.DataBindings.Add("EditValue", cashBookRecordBS, "BasisId", true, DataSourceUpdateMode.OnPropertyChanged);
            cashBookBasisEdit.Properties.DataSource = cashBookService.GetBasis();
            cashBookBasisEdit.Properties.ValueMember = "Id";
            cashBookBasisEdit.Properties.DisplayMember = "BasisType";
            cashBookBasisEdit.Properties.NullText = "Немає данних";

            cashBookAdditionalEdit.DataBindings.Add("EditValue", cashBookRecordBS, "AdditionalId", true, DataSourceUpdateMode.OnPropertyChanged);
            cashBookAdditionalEdit.Properties.DataSource = cashBookService.GetCashBookAdditional();
            cashBookAdditionalEdit.Properties.ValueMember = "Id";
            cashBookAdditionalEdit.Properties.DisplayMember = "NameAdditionalType";
            cashBookAdditionalEdit.Properties.NullText = "Немає данних";

            if (this.operation == Utils.Operation.Add)
            {
                ((CashBookRecordJournalDTO)Item).Payment = 0.00m;
                ((CashBookRecordJournalDTO)Item).CurrencyTypeId = null;
                ((CashBookRecordJournalDTO)Item).Id = 0;

            }
            else
            {
                ((CashBookRecordJournalDTO)Item).Id = model.Id;
                ((CashBookRecordJournalDTO)Item).BasisId = model.BasisId;
                ((CashBookRecordJournalDTO)Item).AdditionalId = model.AdditionalId;
                ((CashBookRecordJournalDTO)Item).ContractorId = model.ContractorId;
                ((CashBookRecordJournalDTO)Item).CurrencyTypeId = model.CurrencyTypeId;
                ((CashBookRecordJournalDTO)Item).BalanceAccountId = model.BalanceAccountId;
                ((CashBookRecordJournalDTO)Item).DocumentNumber = model.DocumentNumber;
                
            }

            splashScreenManager.CloseWaitForm();
        }

        #region Method's

        public CashBookRecordJournalDTO Return()
        {
            return ((CashBookRecordJournalDTO)Item);
        }

        #endregion

        #region Event's

        private void cashBookOperationEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (((CashBookRecordTypeDTO)cashBookOperationEdit.GetSelectedDataRow()) != null && operation == Utils.Operation.Add)
            {
                if (((CashBookRecordTypeDTO)cashBookOperationEdit.GetSelectedDataRow()).Id == 0)
                    cashBookRecordDocumentTBox.EditValue = cashBookService.GetLatestRecordDocumentNumber(pageDate, Utils.CurencyOperationType.Debit, models.Where(w => w.CurrencyTypeId == 0).ToList(), cashBookId);
                else
                    cashBookRecordDocumentTBox.EditValue = cashBookService.GetLatestRecordDocumentNumber(pageDate, Utils.CurencyOperationType.Credit, models.Where(w => w.CurrencyTypeId == 1).ToList(), cashBookId);
            }
            else
            {
                cashBookRecordDocumentTBox.EditValue = model.DocumentNumber;
            }

            cashBookRecordValidationProvider.Validate((Control)sender);
        }

        private void cashBookBasisEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            cashBookService = Program.kernel.Get<ICashBookService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (BasisJournalEditFM basisJournalEditFm = new BasisJournalEditFM(Utils.Operation.Add, new CashBookBasisTypeDTO()))
                        {
                            if (basisJournalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = basisJournalEditFm.Return();
                                cashBookService = Program.kernel.Get<ICashBookService>();
                                cashBookBasisEdit.Properties.DataSource = cashBookService.GetBasis();
                                cashBookBasisEdit.EditValue = return_Id;
                                //((CashBookRecordJournalDTO)Item).BasisId = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (cashBookBasisEdit.EditValue == DBNull.Value)
                            return;

                        using (BasisJournalEditFM basisJournalEditFm = new BasisJournalEditFM(Utils.Operation.Update, (CashBookBasisTypeDTO)cashBookBasisEdit.GetSelectedDataRow()))
                        {
                            if (basisJournalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = basisJournalEditFm.Return();
                                cashBookService = Program.kernel.Get<ICashBookService>();
                                cashBookBasisEdit.Properties.DataSource = cashBookService.GetBasis();
                                cashBookBasisEdit.EditValue = return_Id;


                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (cashBookBasisEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cashBookService.CashBookBasisDelete(((CashBookBasisTypeDTO)cashBookBasisEdit.GetSelectedDataRow()).Id);
                            cashBookService = Program.kernel.Get<ICashBookService>();
                            cashBookBasisEdit.Properties.DataSource = cashBookService.GetBasis();
                            cashBookBasisEdit.EditValue = null;
                            cashBookBasisEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        cashBookBasisEdit.EditValue = null;
                        cashBookBasisEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void cashBookContractorEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            cashBookService = Program.kernel.Get<ICashBookService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (CashBookContractorEditFm cashBookContractorEditFm = new CashBookContractorEditFm(Utils.Operation.Add, new CashBookContractorDTO()))
                        {
                            if (cashBookContractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cashBookContractorEditFm.Return();
                                cashBookService = Program.kernel.Get<ICashBookService>();
                                cashBookContractorEdit.Properties.DataSource = cashBookService.GetContractors();
                                cashBookContractorEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (cashBookContractorEdit.EditValue == DBNull.Value)
                            return;

                        using (CashBookContractorEditFm cashBookContractorEditFm = new CashBookContractorEditFm(Utils.Operation.Update, (CashBookContractorDTO)cashBookContractorEdit.GetSelectedDataRow()))
                        {
                            if (cashBookContractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cashBookContractorEditFm.Return();
                                cashBookService = Program.kernel.Get<ICashBookService>();
                                cashBookContractorEdit.Properties.DataSource = cashBookService.GetContractors();
                                cashBookContractorEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (cashBookContractorEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cashBookService.CashBookContractorDelete(((CashBookContractorDTO)cashBookContractorEdit.GetSelectedDataRow()).Id);
                            cashBookService = Program.kernel.Get<ICashBookService>();
                            cashBookContractorEdit.Properties.DataSource = cashBookService.GetContractors();
                            cashBookContractorEdit.EditValue = null;
                            cashBookContractorEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        cashBookContractorEdit.EditValue = null;
                        cashBookContractorEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void cashBookAdditionalEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            cashBookService = Program.kernel.Get<ICashBookService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (CashBookAdditionalEditFm cashBookAdditionalEditFm = new CashBookAdditionalEditFm(Utils.Operation.Add, new CashBookAdditionalTypeDTO()))
                        {
                            if (cashBookAdditionalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cashBookAdditionalEditFm.Return();
                                cashBookService = Program.kernel.Get<ICashBookService>();
                                cashBookAdditionalEdit.Properties.DataSource = cashBookService.GetCashBookAdditional();
                                cashBookAdditionalEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (cashBookAdditionalEdit.EditValue == DBNull.Value)
                            return;

                        using (CashBookAdditionalEditFm cashBookAdditionalEditFm = new CashBookAdditionalEditFm(Utils.Operation.Update, (CashBookAdditionalTypeDTO)cashBookAdditionalEdit.GetSelectedDataRow()))
                        {
                            if (cashBookAdditionalEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                cashBookService = Program.kernel.Get<ICashBookService>();
                                long return_Id = cashBookAdditionalEditFm.Return();
                                cashBookAdditionalEdit.Properties.DataSource = cashBookService.GetCashBookAdditional();
                                cashBookAdditionalEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (cashBookContractorEdit.EditValue == DBNull.Value)
                            return;

                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cashBookService = Program.kernel.Get<ICashBookService>();
                            cashBookService.CashBookAdditionalTypeDelete(((CashBookAdditionalTypeDTO)cashBookAdditionalEdit.GetSelectedDataRow()).Id); 
                            cashBookAdditionalEdit.Properties.DataSource = cashBookService.GetContractors();
                            cashBookAdditionalEdit.EditValue = null;
                            cashBookAdditionalEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        cashBookAdditionalEdit.EditValue = null;
                        cashBookAdditionalEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //this.Item.CancelEdit();

            ((CashBookRecordJournalDTO)Item).BalanceAccountNumber = bankAccountEdit.Text;
            ((CashBookRecordJournalDTO)Item).BasisType = cashBookBasisEdit.Text;
            ((CashBookRecordJournalDTO)Item).CashBookContractorName = cashBookContractorEdit.Text;
            ((CashBookRecordJournalDTO)Item).CurrencyTypeName = cashBookOperationEdit.Text;
            ((CashBookRecordJournalDTO)Item).DocumentNumber = cashBookRecordDocumentTBox.Text;
            ((CashBookRecordJournalDTO)Item).NameAdditionalType = cashBookAdditionalEdit.Text;
            
            ((CashBookRecordJournalDTO)Item).Selection = false;

            if (((CashBookRecordJournalDTO)Item).CurrencyTypeId == 0)
                ((CashBookRecordJournalDTO)Item).Debit = ((CashBookRecordJournalDTO)Item).Payment;
            else
                ((CashBookRecordJournalDTO)Item).Credit = ((CashBookRecordJournalDTO)Item).Payment;

            this.Item.EndEdit();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return cashBookRecordValidationProvider.Validate();
        }

        private void cashBookRecordValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void cashBookRecordValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cashBookRecordValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void cashBookRecordDocumentTBox_EditValueChanged(object sender, EventArgs e)
        {
            cashBookRecordValidationProvider.Validate((Control)sender);
        }


        private void bankAccountEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashBookRecordValidationProvider.Validate((Control)sender);
        }

        private void cashBookRecordCurrencyTBox_EditValueChanged(object sender, EventArgs e)
        {
            cashBookRecordValidationProvider.Validate((Control)sender);
        }

        private void cashBookContractorEdit_EditValueChanged(object sender, EventArgs e)
        {
            cashBookRecordValidationProvider.Validate((Control)sender);
        }

        #endregion

    }
}