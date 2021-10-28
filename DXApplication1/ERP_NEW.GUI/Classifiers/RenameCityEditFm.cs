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
    public partial class RenameCityEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICityService cityService;
        private BindingSource cityBS = new BindingSource();
        private UserTasksDTO _userTasksDTO;
        private Utils.Operation _operation;
        private CityDTO newModel;

        private ObjectBase Item
        {
            get { return cityBS.Current as ObjectBase; }
            set
            {
                cityBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public RenameCityEditFm(CityDTO model)
        {
            InitializeComponent();
            LoadData();
            cityBS.DataSource = Item = model;

            oldNameCityEdit.DataBindings.Add("EditValue", cityBS, "CityName_UA");
            renameDateEdit.DataBindings.Add("EditValue", cityBS, "EndRegistrationDate", true, DataSourceUpdateMode.OnPropertyChanged);
            cityDescriptionEdit.DataBindings.Add("EditValue", cityBS, "Description");

            ((CityDTO)Item).EndRegistrationDate = DateTime.Now;  
            renameCityEditValidationProvider.Validate(); 
        }


        #region Method's

        private bool SaveAndUpdate()
        {
            this.Item.EndEdit();
            try
            {
                cityService.CityUpdate((CityDTO)Item);
                newModel = new CityDTO()
                {
                    ParentId = ((CityDTO)Item).Id,
                    Country_Id = ((CityDTO)Item).Country_Id,
                    CityName_UA = (string)newNameCityEdit.EditValue,
                    SettlementTypeId = ((CityDTO)Item).SettlementTypeId
                };
                newModel.Id = cityService.CityCreate(newModel);
            }
            catch (Exception e)
            {
                return false;
            }
                
            return true;
        }

        private void LoadData()
        {
            cityService = Program.kernel.Get<ICityService>();

        }

       

        public long Return()
        {
            return newModel.Id;
        }

        #endregion

        #region Event's
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveAndUpdate())
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
            return renameCityEditValidationProvider.Validate();
        }

        private void renameCityEditValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void renameCityEditValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (renameCityEditValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void newNameCityEdit_EditValueChanged(object sender, EventArgs e)
        {
            renameCityEditValidationProvider.Validate((Control)sender);
        }

        #endregion

        private void RenameCityEditFm_Load(object sender, EventArgs e)
        {

        }
    }
}