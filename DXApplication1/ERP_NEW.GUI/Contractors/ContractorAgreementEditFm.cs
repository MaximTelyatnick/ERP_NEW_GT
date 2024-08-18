
using System.Windows.Forms;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Infrastructure;
using Ninject;
using System;

namespace ERP_NEW.GUI.Contractors
{
    public partial class ContractorAgreementEditFm : DevExpress.XtraEditors.XtraForm
    {

        private IContractorsService contractorsService;

        private BindingSource contractorBS = new BindingSource();
        private BindingSource agreementBS = new BindingSource();
        //private BindingSource productCategoryBS = new BindingSource();
        //private BindingSource contractorTypeBS = new BindingSource();
        //private BindingSource contractorContactAddressBS = new BindingSource();
        //private BindingSource contactPersonAddressBS = new BindingSource();
        private Utils.Operation operation;
        private UserTasksDTO userTasksDTO;
        private string OldName;
        private ObjectBase Item
        {
            get { return agreementBS.Current as ObjectBase; }
            set
            {
                agreementBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }
        public ContractorAgreementEditFm(Utils.Operation operation, ContractorsDTO model, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();

            if (Properties.Settings.Default.SuperUser)
                fixedBtn.Visible = true;
            else
                fixedBtn.Visible = false;


            this.operation = operation;
            this.userTasksDTO = userTaskDTO;
            model.AutoAgreement = true;
            agreementBS.DataSource = Item = model;

            LoadData();

            this.OldName = model.Name;
            this.operation = operation;

            //contractorsEdit.DataBindings.Add("EditValue", agreementBS, "Branch", true, DataSourceUpdateMode.OnPropertyChanged);

            agreementNumberEdit.DataBindings.Add("EditValue", agreementBS, "AgreementNumber", true, DataSourceUpdateMode.OnPropertyChanged);

            agreementDateEdit.DataBindings.Add("EditValue", agreementBS, "AgreementDate", true, DataSourceUpdateMode.OnPropertyChanged);

            contractorsEdit.DataBindings.Add("EditValue", agreementBS, "ParentId", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsEdit.Properties.DataSource = contractorBS;
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            autoGenerateAgreementNameCheck.DataBindings.Add("EditValue", agreementBS, "AutoAgreement", true, DataSourceUpdateMode.OnPropertyChanged);

            




            ControlValidation();
        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            contractorBS.DataSource = contractorsService.GetContractors(2);
            //productCategoryBS.DataSource = contractorsService.GetProductCategories();
            //contractorTypeBS.DataSource = contractorsService.GetContractorTypes();
            //contractorContactAddressBS.DataSource = contractorsService.GetContractorContactAddress(contractor2.Id);
            //contactPersonAddressBS.DataSource = contractorsService.GetContactPersonAddress(contractor2.Id);
        }

        public ContractorsDTO Return()
        {
            return ((ContractorsDTO)Item);
        }

        private bool ControlValidation()
        {
            return dxValidationProvider.Validate();
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void contractorsEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (autoGenerateAgreementNameCheck.Checked)
            {
                if (agreementDateEdit.DateTime.Year > 2000)
                    agreementFinalNameEdit.Text = "Дог. №" + agreementNumberEdit.Text + " від. " + agreementDateEdit.DateTime.ToShortDateString() + " " + contractorsEdit.Text;
                else
                    agreementFinalNameEdit.Text = "Дог. №" + agreementNumberEdit.Text + " " + contractorsEdit.Text;

            }
            dxValidationProvider.Validate((Control)sender);
        }

        private void agreementNumberEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (autoGenerateAgreementNameCheck.Checked)
            {
                if (agreementDateEdit.DateTime.Year > 2000)
                    agreementFinalNameEdit.Text = "Дог. №" + agreementNumberEdit.Text + " від. " + agreementDateEdit.DateTime.ToShortDateString() + " " + contractorsEdit.Text;
                else
                    agreementFinalNameEdit.Text = "Дог. №" + agreementNumberEdit.Text + " " + contractorsEdit.Text;
            }
            dxValidationProvider.Validate((Control)sender);
        }

        private void agreementDateEdit_EditValueChanged(object sender, System.EventArgs e)
        {
            if (autoGenerateAgreementNameCheck.Checked)
            {
                if (agreementDateEdit.DateTime.Year > 2000)
                    agreementFinalNameEdit.Text = "Дог. №" + agreementNumberEdit.Text + " від. " + agreementDateEdit.DateTime.ToShortDateString() + " " + contractorsEdit.Text;
                else
                    agreementFinalNameEdit.Text = "Дог. №" + agreementNumberEdit.Text + " " + contractorsEdit.Text;
            }
            dxValidationProvider.Validate((Control)sender);
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Item.EndEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
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
                MessageBox.Show("При береженні виникла помилка. " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveItem()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();


            if (contractorsService.CheckContractor(((ContractorsDTO)agreementBS.Current)))
            {
                MessageBox.Show("Контрагент з таким іменем вже існує.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            ((ContractorsDTO)agreementBS.Current).Active = true;
            ((ContractorsDTO)agreementBS.Current).ChangeDate = DateTime.Now;
            ((ContractorsDTO)agreementBS.Current).Srn = ((ContractorsDTO)contractorBS.Current).Srn;
            ((ContractorsDTO)agreementBS.Current).Tin = ((ContractorsDTO)contractorBS.Current).Tin;
            ((ContractorsDTO)agreementBS.Current).Name = agreementFinalNameEdit.Text;
            ((ContractorsDTO)agreementBS.Current).UserId = userTasksDTO.UserId;

            if (this.operation == Utils.Operation.Add)
            {
                ((ContractorsDTO)agreementBS.Current).RegistrationDate = DateTime.Now;
                contractorsService.ContractorCreate(((ContractorsDTO)agreementBS.Current));
            }
            else 
            {
                contractorsService.ContractorUpdate(((ContractorsDTO)agreementBS.Current));
            }



            return true;
        }

        private void autoGenerateAgreementNameCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!autoGenerateAgreementNameCheck.Checked)
            {
                agreementFinalNameEdit.ReadOnly = false;
            }
            else
            {
                agreementFinalNameEdit.ReadOnly = true;
            }
        }

        private void fixedBtn_Click(object sender, EventArgs e)
        {
            string oldName = OldName;

            string searchNumber = "";

            // Поиск позиции символа №
            int startIndex = oldName.IndexOf("№");
            if (startIndex == -1)
            {
                MessageBox.Show("Символ № не найден", "Пошук номера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Сдвигаем индекс для начала подстроки сразу после символа №
            startIndex += 1;

            // Поиск позиции слов "від" или "от"
            int endIndex = oldName.IndexOf(" від", startIndex);
            if (endIndex == -1) endIndex = oldName.IndexOf(" от", startIndex);
            if (endIndex == -1)
            {
                MessageBox.Show("Слова 'від' или 'от' не найдены", "Пошук номера", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Извлечение подстроки между символом № и словами "від" или "от"
            string substring = oldName.Substring(startIndex, endIndex - startIndex).Trim();

            // Вставка подстроки в str2
            searchNumber += substring;

            MessageBox.Show("Найден номер договора: "+ searchNumber, "Пошук номера", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}