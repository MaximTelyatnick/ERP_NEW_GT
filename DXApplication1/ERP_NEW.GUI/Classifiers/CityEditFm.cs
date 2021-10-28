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
    public partial class CityEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICityService cityService;
        private BindingSource cityBS = new BindingSource();
        private BindingSource countryBS = new BindingSource();
        private BindingSource settlementBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;
        private Utils.Operation _operation;
        private Utils.Operation operation;
        private CashBookContractorDTO cashBookContractorDTO;


        private ObjectBase Item
        {
            get { return cityBS.Current as ObjectBase; }
            set
            {
                cityBS.DataSource = value;

                value.BeginEdit();
            }
        }

        public CityEditFm(Utils.Operation operation, CityDTO model)
        {
            InitializeComponent();
            LoadData();
            _operation = operation;
            cityBS.DataSource = Item = model;

            countryBS.DataSource = cityService.GetCountries();
            settlementBS.DataSource = cityService.GetSettlementTypes();

            countryEdit.DataBindings.Add("EditValue", cityBS, "Country_Id", true, DataSourceUpdateMode.OnPropertyChanged);
            countryEdit.Properties.DataSource = countryBS.DataSource;
            countryEdit.Properties.ValueMember = "Country_Id";
            countryEdit.Properties.DisplayMember = "CountryName_UA";
            countryEdit.Properties.NullText = "Немає данних";

            cityUaNameEdit.DataBindings.Add("EditValue", cityBS, "CityName_UA");

            settlementEdit.DataBindings.Add("EditValue", cityBS, "SettlementTypeId", true, DataSourceUpdateMode.OnPropertyChanged);
            settlementEdit.Properties.DataSource = settlementBS;
            settlementEdit.Properties.ValueMember = "Id";
            settlementEdit.Properties.DisplayMember = "FullName";
            settlementEdit.Properties.NullText = "Немає данних";

            if (_operation == Utils.Operation.Update)
            {
                cityUaNameEdit.EditValue = ((CityDTO)Item).CityName_UA;
                countryEdit.EditValue = ((CityDTO)Item).CountryName_UA;
            }
            else
            {
                cityUaNameEdit.EditValue = null;
                countryEdit.EditValue = null;
                Item = model;
                ((CityDTO)Item).SettlementTypeId = 1;
            }

            cityValidationProvider.Validate();
        }

        public CityEditFm(Utils.Operation operation, CashBookContractorDTO cashBookContractorDTO)
        {
            // TODO: Complete member initialization
            this.operation = operation;
            this.cashBookContractorDTO = cashBookContractorDTO;
        }
        #region Metod's

        private void LoadData()
        {
            cityService = Program.kernel.Get<ICityService>();
            cityBS.DataSource = cityService.GetCountries();

        }
        private bool SaveItem()
        {
            this.Item.EndEdit();

            cityService = Program.kernel.Get<ICityService>();

            if (_operation == Utils.Operation.Add)
            {
                ((CityDTO)Item).Id = cityService.CityCreate((CityDTO)Item);
            }
            else
            {
                cityService.CityUpdate((CityDTO)Item);
            }
            return true;
        }

        public void LoadCountryData()
        {
            countryBS.DataSource = cityService.GetCountries();
            countryEdit.Properties.DataSource = countryBS.DataSource;
        }
        public long Return()
        {
            return ((CityDTO)Item).Id;
        }
        #endregion

        #region Event's

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
                    MessageBox.Show("При береженні заявки виникла помилка. " + ex.Message, "Збереження заявки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }  
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void countryEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            cityService = Program.kernel.Get<ICityService>();
            switch (e.Button.Index)
            {
                case 1: //ДОБАВИТЬ
                    {
                        new CountryEditFm(Utils.Operation.Add, new CountryDTO()).ShowDialog();
                        LoadCountryData();
                        break;
                    }
                case 2://РЕДАКТИРОВАТЬ
                    {
                        new CountryEditFm(Utils.Operation.Update, (CountryDTO)countryEdit.GetSelectedDataRow()).ShowDialog();
                        LoadCountryData();
                        break;
                    }
                case 3://УДАЛИТЬ
                    {
                        if (countryBS.Count != 0)
                        {
                            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (!cityService.CountryDelete(((CountryDTO)countryEdit.GetSelectedDataRow()).Country_Id))
                                    MessageBox.Show("Помилка видалення", "Оповіщення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                                LoadCountryData();
                                countryEdit.EditValue = null;
                                countryEdit.Properties.NullText = "Немає данних";
                            }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        #endregion

        #region Validation's

        private bool ControlValidation()
        {
            return cityValidationProvider.Validate();
        }

        private void countryEdit_EditValueChanged(object sender, EventArgs e)
        {
            cityValidationProvider.Validate((Control)sender);
        }

       
        private void cityUaNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            cityValidationProvider.Validate((Control)sender);
        }

        private void settlementEdit_EditValueChanged(object sender, EventArgs e)
        {
            cityValidationProvider.Validate((Control)sender);
        }

        private void cityValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void cityValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (cityValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        #endregion





    }
}