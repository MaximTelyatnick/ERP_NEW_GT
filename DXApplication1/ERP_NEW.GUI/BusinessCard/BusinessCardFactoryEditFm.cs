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
using Ninject;
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.GUI.Contractors;

namespace ERP_NEW.GUI.BusinessCard
{
    public partial class BusinessCardFactoryEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessCardService businessCardService;
        private ICityService cityService;
        private IContractorsService contractorsService;

        private BindingSource businessCardsFactoryBS = new BindingSource();
        private BindingSource citiesBS = new BindingSource();
        private BindingSource productCategoryBS = new BindingSource();

        private Utils.Operation operation;


        private ObjectBase Item
        {
            get { return businessCardsFactoryBS.Current as ObjectBase; }
            set
            {
                businessCardsFactoryBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BusinessCardFactoryEditFm(Utils.Operation operation, BusinessCardsFactoryDTO model)
        {
            InitializeComponent();

            LoadData();

            this.operation = operation;

            businessCardsFactoryBS.DataSource = Item = model;

            organisationEdit.DataBindings.Add("EditValue", businessCardsFactoryBS, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            categoryEdit.DataBindings.Add("EditValue", businessCardsFactoryBS, "ProductCategoriesId", true, DataSourceUpdateMode.OnPropertyChanged);
            destinationEdit.DataBindings.Add("EditValue", businessCardsFactoryBS, "CityId", true, DataSourceUpdateMode.OnPropertyChanged);

            categoryEdit.Properties.DataSource = contractorsService.GetProductCategories();
            categoryEdit.Properties.ValueMember = "Id";
            categoryEdit.Properties.DisplayMember = "CategoryName";
            categoryEdit.Properties.NullText = "Немає данних";

            citiesBS.DataSource = cityService.GetCities();
            destinationEdit.Properties.DataSource = citiesBS;
            destinationEdit.Properties.ValueMember = "Id";
            destinationEdit.Properties.DisplayMember = "FullName_UA";
            destinationEdit.Properties.NullText = "Немає данних";
        }

        #region Method's

        private void LoadData()
        {
            businessCardService = Program.kernel.Get<IBusinessCardService>();
            cityService = Program.kernel.Get<ICityService>();
            contractorsService = Program.kernel.Get<IContractorsService>();

        }

        public BusinessCardsFactoryDTO Return()
        {
            return ((BusinessCardsFactoryDTO)Item);
        }

        private bool SaveBusinessCardFactory()
        {
            businessCardService = Program.kernel.Get<IBusinessCardService>();

            this.Item.EndEdit();

            try
            {
                if (this.operation == Utils.Operation.Add)
                {
                    businessCardService = Program.kernel.Get<IBusinessCardService>();
                    businessCardService.BusinessCardFactoryCreate((BusinessCardsFactoryDTO)Item);

                }
                else
                {
                    businessCardService = Program.kernel.Get<IBusinessCardService>();
                    businessCardService.BusinessCardFactoryUpdate((BusinessCardsFactoryDTO)Item);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("При додаванні виникла помилка. " + ex.Message, "Долавання", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return true;
        }

        #endregion

        #region Event's

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveBusinessCardFactory())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void destinationEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (CityEditFm cityEditFm = new CityEditFm(Utils.Operation.Add, new CityDTO()))
                        {
                            if (cityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cityEditFm.Return();
                                cityService = Program.kernel.Get<ICityService>();
                                destinationEdit.Properties.DataSource = cityService.GetCities();
                                destinationEdit.EditValue = return_Id;


                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (destinationEdit.EditValue == DBNull.Value)
                            return;

                        using (CityEditFm cityEditFm = new CityEditFm(Utils.Operation.Update, (CityDTO)destinationEdit.GetSelectedDataRow()))
                        {
                            if (cityEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = cityEditFm.Return();
                                cityService = Program.kernel.Get<ICityService>();
                                destinationEdit.Properties.DataSource = cityService.GetCities();
                                destinationEdit.EditValue = return_Id;


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

        private void categoryEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистить
                    {
                        organisationEdit.EditValue = null;
                        organisationEdit.Properties.NullText = "Немає данних";
                        //ProductCategoryEditBtnEnabled(false);
                        break;
                    }
                case 2: //ДОБАВИТЬ
                    {
                        new ProductCategoryEditFm(Utils.Operation.Add, new ProductCategoriesDTO()).ShowDialog();
                        LoadData();
                        break;
                    }
                case 3://РЕДАКТИРОВАТЬ
                    {
                        new ProductCategoryEditFm(Utils.Operation.Update, (ProductCategoriesDTO)categoryEdit.GetSelectedDataRow()).ShowDialog();
                        LoadData();
                        break;
                    }
                case 4://УДАЛИТЬ
                    {
                        if (productCategoryBS.Count != 0)
                        {
                            if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                contractorsService.ProductCategotyDelete(((ProductCategoriesDTO)categoryEdit.GetSelectedDataRow()).Id);
                                LoadData();
                                categoryEdit.EditValue = null;
                                categoryEdit.Properties.NullText = "Немає данних";
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

        #region Validation

        private void dxValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void dxValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (dxValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void organisationEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void categoryEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        private void destinationEdit_EditValueChanged(object sender, EventArgs e)
        {
            dxValidationProvider.Validate((Control)sender);
        }

        #endregion

    }
}