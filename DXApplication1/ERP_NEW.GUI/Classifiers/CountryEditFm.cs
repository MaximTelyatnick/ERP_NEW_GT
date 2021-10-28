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
    public partial class CountryEditFm : DevExpress.XtraEditors.XtraForm
    {
        private  ICityService countryService;

        private BindingSource countriesBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return countriesBS.Current as ObjectBase; }
            set
            {
                countriesBS.DataSource = value;
                value.BeginEdit();
            }
        }
        
        public CountryEditFm(Utils.Operation operation, CountryDTO model)
        {
            InitializeComponent();
            _operation = operation;
            countriesBS.DataSource = Item = model;
            nameEdit.DataBindings.Add("EditValue", countriesBS, "CountryName_UA");
            countryValidationProvider.Validate();
        }

        #region Method's

        private bool SaveCountry()
        {
            this.Item.EndEdit();

            countryService = Program.kernel.Get<ICityService>();

            if (_operation == Utils.Operation.Add)
                ((CountryDTO)Item).Country_Id = countryService.CountryCreate((CountryDTO)Item);
            else
                countryService.CountryUpdate((CountryDTO)Item);

            return true;
        }

        private bool FindDublicate(CountryDTO model)
        {
            return countryService.GetCountries().Any(s => s.CountryName_UA.Trim() == model.CountryName_UA.Trim());
        }

        public long Return()
        {
            return ((CountryDTO)Item).Country_Id;
        }

        #endregion

        #region Event's


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveCountry())
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
            return countryValidationProvider.Validate();
        }

        private void countryValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void countryValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (countryValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void nameEdit_EditValueChanged(object sender, EventArgs e)
        {
            countryValidationProvider.Validate((Control)sender);
        }

        #endregion

        


    }
}