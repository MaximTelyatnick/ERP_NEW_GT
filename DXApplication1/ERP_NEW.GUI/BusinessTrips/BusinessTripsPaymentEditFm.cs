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
    public partial class BusinessTripsPaymentEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IAccountsService accountsService;
        private IEmployeesService employeesService;
        private ICurrencyService currencyService;
        private IPeriodService periodService;

        private BindingSource businessTripsPaymentBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();
        private BindingSource currencyBS = new BindingSource();
        private BindingSource currencyRateBS = new BindingSource();
        private BindingSource vatBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return businessTripsPaymentBS.Current as ObjectBase; }
            set
            {
                businessTripsPaymentBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BusinessTripsPaymentEditFm(Utils.Operation operation, BusinessTripsPaymentDTO model, BusinessTripsPrepaymentJournalDTO currentModel)
        {
            InitializeComponent();

            _operation = operation;

            businessTripsPaymentBS.DataSource = Item = model;

            LoadData();

            employeesBS.DataSource = currentModel;
            userInfoVGrid.DataSource = employeesBS;
            userFotoEdit.EditValue = PhotoSource(employeesService.GetPhotoById(currentModel.EmployeesID));
            
            paymentDateEdit.DataBindings.Add("EditValue", businessTripsPaymentBS, "Payment_Date");
            commentTBox.DataBindings.Add("EditValue", businessTripsPaymentBS, "Comment");
            paymentTBox.DataBindings.Add("EditValue", businessTripsPaymentBS, "Payment");

            dateRateEdit.DataBindings.Add("EditValue", currencyRateBS, "Date");
            rateTBox.DataBindings.Add("EditValue", currencyRateBS, "Rate", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyPaymentTBox.DataBindings.Add("EditValue", currencyRateBS, "CurrencyPayment", true, DataSourceUpdateMode.OnPropertyChanged);

            vatPaymentTBox.DataBindings.Add("EditValue", vatBS, "VatPayment", true, DataSourceUpdateMode.OnPropertyChanged);

            accountEdit.DataBindings.Add("EditValue", businessTripsPaymentBS, "AccountsID", true, DataSourceUpdateMode.OnPropertyChanged);
            accountEdit.Properties.DataSource = accountsService.GetAccounts();
            accountEdit.Properties.ValueMember = "Id";
            accountEdit.Properties.DisplayMember = "Num";
            accountEdit.Properties.NullText = "Немає данних";

            reportEdit.DataBindings.Add("EditValue", businessTripsPaymentBS, "BusinessTripsReportID", true, DataSourceUpdateMode.OnPropertyChanged);
            reportEdit.Properties.DataSource = businessTripsService.GetBusinessTripsReports().OrderBy(r => r.Name);
            reportEdit.Properties.ValueMember = "ID";
            reportEdit.Properties.DisplayMember = "Name";
            reportEdit.Properties.NullText = "Немає данних";
            
            currencyEdit.DataBindings.Add("EditValue", currencyRateBS, "Currency_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyService.GetAllCurrency().ToList();
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Code";
            currencyEdit.Properties.NullText = "Немає данних";

            accountVatEdit.DataBindings.Add("EditValue", vatBS, "VatAccountId", true, DataSourceUpdateMode.OnPropertyChanged);
            accountVatEdit.Properties.DataSource = accountsService.GetAccounts();
            accountVatEdit.Properties.ValueMember = "Id";
            accountVatEdit.Properties.DisplayMember = "Num";
            accountVatEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Add)
            {
                ((BusinessTripsPaymentDTO)Item).EmployeesID = currentModel.EmployeesID;
                ((BusinessTripsPaymentDTO)Item).UserId = UserService.AuthorizatedUser.UserId;
                ((BusinessTripsPaymentDTO)Item).BusinessTripsDetailsID = currentModel.BusinessTripsDetailsID;

                ((Currency_RatesDTO)currencyRateBS.Current).Currency_Id = 1;
                ((Currency_RatesDTO)currencyRateBS.Current).Date = DateTime.Now;
                ((Currency_RatesDTO)currencyRateBS.Current).Multiplicity = 1;
            }

            ((BusinessTripsPaymentDTO)Item).Doc_Date = DateTime.Now;

            if (((BusinessTripsPaymentDTO)Item).CurrencyRatesID != null)
            {
                currencyCheck.Checked = true;
                dateRateEdit.Enabled = true;
                rateTBox.Enabled = true;
                currencyPaymentTBox.Enabled = true;
            }
            else
            {
                currencyCheck.Checked = false;
                dateRateEdit.Enabled = false;
                rateTBox.Enabled = false;
                currencyPaymentTBox.Enabled = false; 
            }

            if (((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID != null)
            {
                vatCheck.Checked = true;
                accountVatEdit.Enabled = true;
                vatPaymentTBox.Enabled = true;
            }
            else
            {
                vatCheck.Checked = false;
                accountVatEdit.Enabled = false;
                vatPaymentTBox.Enabled = false; 
            }

            ControlValidation();
        }

        #region Method's

        private void LoadData()
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            accountsService = Program.kernel.Get<IAccountsService>();
            employeesService = Program.kernel.Get<IEmployeesService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            
            currencyRateBS.DataSource = ((BusinessTripsPaymentDTO)Item).CurrencyRatesID == null ?
                new Currency_RatesDTO() {  Currency_Id = 1, Multiplicity = 1} :
                currencyService.GetCurrencyRates().Where(s => s.Id == ((BusinessTripsPaymentDTO)Item).CurrencyRatesID).SingleOrDefault();
            
            vatBS.DataSource = ((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID == null ?
                new BusinessTripsPaymentVatDTO() :
                businessTripsService.GetBusinessTripsPaymentVat().Where(v => v.VatID == ((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID).SingleOrDefault();
        }

        private byte[] PhotoSource(EmployeePhotoDTO source)
        {
            if (source.Photo == null || source.Photo.Length == 0)
            {
                MemoryStream ms = new MemoryStream();
                Image.FromFile("Images/happy-face.png").Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                source.Photo = ms.ToArray();
            }
            return source.Photo;
        }

        private bool SaveItem()
        {
            bool currencyRateDelete = false;
            bool vatDelete = false;

            this.Item.EndEdit();
            vatBS.EndEdit();
            currencyRateBS.EndEdit();

            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            currencyService = Program.kernel.Get<ICurrencyService>();

            if (_operation == Utils.Operation.Add)
            {
                if (currencyCheck.Checked)
                {
                    int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRateBS.Current);
                    ((BusinessTripsPaymentDTO)Item).CurrencyRatesID = currencyRatesId;
                }

                if (vatCheck.Checked)
                {
                    int vatId = businessTripsService.BusinessTripsPaymentVatCreate((BusinessTripsPaymentVatDTO)vatBS.Current);
                    ((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID = vatId;
                }

                ((BusinessTripsPaymentDTO)Item).ID = businessTripsService.BusinessTripsPaymentCreate((BusinessTripsPaymentDTO)Item);

                return true;
            }
            else
            {
                //currency
                if (currencyCheck.Checked)
                {
                    if (((BusinessTripsPaymentDTO)Item).CurrencyRatesID == null)
                    {
                        int currencyRatesId = currencyService.CurrencyRatesCreate((Currency_RatesDTO)currencyRateBS.Current);
                        ((BusinessTripsPaymentDTO)Item).CurrencyRatesID = currencyRatesId;
                    }
                    else
                    {
                        currencyService.CurrencyRatesUpdate((Currency_RatesDTO)currencyRateBS.Current);
                    }
                }
                else
                {
                    if (((BusinessTripsPaymentDTO)Item).CurrencyRatesID != null)
                    {
                        currencyRateDelete = true;
                    }
                }

                //vat
                if (vatCheck.Checked)
                {
                    if (((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID == null)
                    {
                        int vatId = businessTripsService.BusinessTripsPaymentVatCreate((BusinessTripsPaymentVatDTO)vatBS.Current);
                        ((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID = vatId;
                    }
                    else
                    {
                        businessTripsService.BusinessTripsPaymentVatUpdate((BusinessTripsPaymentVatDTO)vatBS.Current);
                    }
                }
                else
                {
                    if (((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID != null)
                    {
                        vatDelete = true;
                    }
                }

                if(currencyRateDelete)
                    ((BusinessTripsPaymentDTO)Item).CurrencyRatesID = null;
                if(vatDelete)
                    ((BusinessTripsPaymentDTO)Item).BusinessTripsPaymentVatID = null;
                
                businessTripsService.BusinessTripsPaymentUpdate((BusinessTripsPaymentDTO)Item);

                if(currencyRateDelete)
                    currencyService.CurrencyRatesDelete(((Currency_RatesDTO)currencyRateBS.Current).Id);    
                if(vatDelete)
                    businessTripsService.BusinessTripsPaymentVatDelete(((BusinessTripsPaymentVatDTO)vatBS.Current).VatID);
                                
                return true;
            }
        }

        public BusinessTripsPaymentDTO Return()
        {
            return ((BusinessTripsPaymentDTO)Item);
        }

        private bool CheckPeriodAccess(DateTime currentDate)
        {
            periodService = Program.kernel.Get<IPeriodService>();

            return periodService.GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateBusinesTrip);
        }

        #endregion

        #region Event's

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Item.EndEdit();

                    if (!CheckPeriodAccess(((BusinessTripsPaymentDTO)Item).Payment_Date))
                    {
                        MessageBox.Show("Період закритий або не існує!", "Редагування звіту", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
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
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void reportEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (BusinessTripsReportEditFm businessTripsReportEditFm = new BusinessTripsReportEditFm(Utils.Operation.Add, new BusinessTripsReportDTO()))
                        {
                            if (businessTripsReportEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int returnId = businessTripsReportEditFm.Return();
                                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                                reportEdit.Properties.DataSource = businessTripsService.GetBusinessTripsReports();
                                reportEdit.EditValue = returnId;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (reportEdit.EditValue == DBNull.Value)
                            return;

                        using (BusinessTripsReportEditFm businessTripsReportEditFm = new BusinessTripsReportEditFm(Utils.Operation.Add, (BusinessTripsReportDTO)reportEdit.GetSelectedDataRow()))
                        {
                            if (businessTripsReportEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                int returnId = businessTripsReportEditFm.Return();
                                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                                reportEdit.Properties.DataSource = businessTripsService.GetBusinessTripsReports();
                                reportEdit.EditValue = returnId;
                            }
                        }
                        break;
                    }
                case 3: //Видалити
                    {
                        if (MessageBox.Show("Ви впевнені що бажаєте видалити найменування документу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                                businessTripsService.BusinessTripReportDelete(((BusinessTripsReportDTO)reportEdit.GetSelectedDataRow()).ID);
                                reportEdit.Properties.DataSource = businessTripsService.GetBusinessTripsReports();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("При видаленні виникла помилка. " + ex.Message, "Видалення найменування документу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        reportEdit.EditValue = null;
                        reportEdit.Properties.NullText = "Немає данних";

                        break;
                    }
            }
        }

        private void rateTBox_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            splashScreenManager.ShowWaitForm();

            currencyService = Program.kernel.Get<CurrencyService>();

            rateTBox.EditValue = currencyService.GetCurrencyRateByDate(((CurrencyDTO)currencyEdit.GetSelectedDataRow()).Code, (DateTime)dateRateEdit.EditValue);

            splashScreenManager.CloseWaitForm();
        }

        private void currencyEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void reportEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void accountVatEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void accountEdit_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit editor = (LookUpEdit)sender;
            RepositoryItemLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(editor.Width - 4, properties.PopupFormSize.Height);
        }

        private void currencyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (currencyCheck.Checked)
            {
                dateRateEdit.Enabled = true;
                rateTBox.Enabled = true;
                currencyPaymentTBox.Enabled = true;
            }
            else
            {
                dateRateEdit.Enabled = false;
                rateTBox.Enabled = false;
                currencyPaymentTBox.Enabled = false;
            }
        }

        private void vatCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (vatCheck.Checked)
            {
                accountVatEdit.Enabled = true;
                vatPaymentTBox.Enabled = true;
            }
            else
            {
                accountVatEdit.Enabled = false;
                vatPaymentTBox.Enabled = false;
            }
        }

        #endregion

        #region Validation

        private bool ControlValidation()
        {
            return businessTripsPaymentValidationProvider.Validate();
        }
        
        private void paymentDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPaymentValidationProvider.Validate((Control)sender);
        }

        private void reportEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPaymentValidationProvider.Validate((Control)sender);
        }

        private void accountEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPaymentValidationProvider.Validate((Control)sender);
        }

        private void currencyEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPaymentValidationProvider.Validate((Control)sender);
        }

        private void paymentTBox_EditValueChanged(object sender, EventArgs e)
        {
            businessTripsPaymentValidationProvider.Validate((Control)sender);
        }

        private void businessTripsPaymentValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void businessTripsPaymentValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (businessTripsPaymentValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        #endregion

    }
}