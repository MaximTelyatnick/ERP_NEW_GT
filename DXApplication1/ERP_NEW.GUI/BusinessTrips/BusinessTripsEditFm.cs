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
using ERP_NEW.GUI.Classifiers;
using ERP_NEW.GUI.Contractors;

namespace ERP_NEW.GUI.BusinessTrips
{
    public partial class BusinessTripsEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IBusinessTripsService businessTripsService;
        private IContractorsService contractorService;
        private ICityService cityService;
        private IEmployeesService employeesService;
                
        private BindingSource businessTripsBS = new BindingSource();
        private BindingSource citiesBS = new BindingSource();
        private BindingSource organisationBS = new BindingSource();
        private BindingSource contractorBS = new BindingSource();
        private BindingSource purposeBS = new BindingSource();
        private BindingSource employeesBS = new BindingSource();

        private Utils.Operation _operation;

        private ObjectBase Item
        {
            get { return businessTripsBS.Current as ObjectBase; }
            set
            {
                businessTripsBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public BusinessTripsEditFm(Utils.Operation operation, BusinessTripsDTO model)
        {
            InitializeComponent();

            splashScreenManager.ShowWaitForm();

            LoadData();

            _operation = operation;
            businessTripsBS.DataSource = Item = model;

            docNumberEdit.DataBindings.Add("EditValue", businessTripsBS,"Doc_Number");
                
            departureEdit.DataBindings.Add("EditValue", businessTripsBS, "DepartureID");
            departureEdit.Properties.DataSource = contractorService.GetOwnContractor();
            departureEdit.Properties.ValueMember = "Id";
            departureEdit.Properties.DisplayMember = "Name";
            departureEdit.Properties.NullText = "Немає данних";
   
            employeesEdit.DataBindings.Add("EditValue", businessTripsBS, "EmployeesID", true, DataSourceUpdateMode.OnPropertyChanged);
            employeesBS.DataSource = employeesService.GetEmployeesWorking();
            employeesEdit.Properties.DataSource = employeesBS;
            employeesEdit.Properties.ValueMember = "EmployeeID";
            employeesEdit.Properties.DisplayMember = "Fio";
            employeesEdit.Properties.NullText = "Немає данних";

            destinationEdit.DataBindings.Add("EditValue", businessTripsBS, "CityID", true, DataSourceUpdateMode.OnPropertyChanged);
            citiesBS.DataSource = cityService.GetCities();
            destinationEdit.Properties.DataSource = citiesBS;
            destinationEdit.Properties.ValueMember = "Id";
            destinationEdit.Properties.DisplayMember = "FullName_UA";
            destinationEdit.Properties.NullText = "Немає данних";

            contractorEdit.DataBindings.Add("EditValue", businessTripsBS, "AgreementsID", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorBS.DataSource = contractorService.GetContractors(3);
            contractorEdit.Properties.DataSource = contractorBS;
            contractorEdit.Properties.ValueMember = "Id";
            contractorEdit.Properties.DisplayMember = "Name";
            contractorEdit.Properties.NullText = "Немає данних";

            organisationEdit.DataBindings.Add("EditValue", businessTripsBS, "ContractorsID", true, DataSourceUpdateMode.OnPropertyChanged);
            organisationBS.DataSource = contractorService.GetContractors(2);
            organisationEdit.Properties.DataSource = organisationBS;
            organisationEdit.Properties.ValueMember = "Id";
            organisationEdit.Properties.DisplayMember = "Name";
            organisationEdit.Properties.NullText = "Немає данних";

            purposeEdit.DataBindings.Add("EditValue", businessTripsBS, "PurposeID", true, DataSourceUpdateMode.OnPropertyChanged);
            purposeBS.DataSource = businessTripsService.GetBusinessTripsPurpose();
            purposeEdit.Properties.DataSource = purposeBS;
            purposeEdit.Properties.ValueMember = "PurposeID";
            purposeEdit.Properties.DisplayMember = "Purpose";
            purposeEdit.Properties.NullText = "Немає данних";

            docDateEdit.DataBindings.Add("EditValue", businessTripsBS, "Doc_Date");
            startDateEdit.DataBindings.Add("EditValue", businessTripsBS, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged);
            endDateEdit.DataBindings.Add("EditValue", businessTripsBS, "EndDate", true, DataSourceUpdateMode.OnPropertyChanged);
            amountDaysEdit.DataBindings.Add("EditValue", businessTripsBS, "AmountDays");
           
            if (operation == Utils.Operation.Add)
            {
                ((BusinessTripsDTO)Item).Doc_Number = GetLastNumber();
                ((BusinessTripsDTO)Item).DepartureID = -1;
                ((BusinessTripsDTO)Item).Doc_Date = DateTime.Now;
                ((BusinessTripsDTO)Item).StartDate = DateTime.Now;
                ((BusinessTripsDTO)Item).EndDate = DateTime.Now;
                ((BusinessTripsDTO)Item).AmountDays = 1;
            }
            
            ControlValidation();
            splashScreenManager.CloseWaitForm();

        }

        #region Method's                                            
                                    
        private void LoadData()
        {
            employeesService = Program.kernel.Get<IEmployeesService>();
            cityService = Program.kernel.Get<ICityService>();
            contractorService = Program.kernel.Get<IContractorsService>();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();

        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            try
            {
                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                
                if (FindDublicate((BusinessTripsDTO)this.Item))
                {
                    MessageBox.Show("Заявка з таким номером вже існує!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (FindCurrentTrip((BusinessTripsDTO)this.Item))
                {
                    MessageBox.Show("Працівник вже знаходиться у відрядженні! Перевірте дату початку відрядження.", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (_operation == Utils.Operation.Add)
                    {
                        ((BusinessTripsDTO)Item).ID = businessTripsService.BusinessTripCreate((BusinessTripsDTO)Item);
                        BusinessTripsDetailsDTO modelBusinessTripsDetails = new BusinessTripsDetailsDTO();
                        modelBusinessTripsDetails.BusinessTripsID = ((BusinessTripsDTO)Item).ID;
                        modelBusinessTripsDetails.EmployeesID = ((BusinessTripsDTO)Item).EmployeesID ?? 0;
                        businessTripsService.BusinessTripsDetailsCreate(modelBusinessTripsDetails);
                        return true;
                    }
                    else
                    {

                        businessTripsService.BusinessTripUpdate((BusinessTripsDTO)Item);
                        BusinessTripsDetailsDTO modelBusinessTripsDetails = businessTripsService.GetBusinessTripsDetailsId(((BusinessTripsDTO)Item).ID);
                        modelBusinessTripsDetails.EmployeesID = ((BusinessTripsDTO)Item).EmployeesID ?? 0;

                        businessTripsService.BusinessTripsDetailsUpdate(modelBusinessTripsDetails);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }        

        }

        public BusinessTripsDTO Return()
        {
            return ((BusinessTripsDTO)Item);
        }

        private bool FindDublicate(BusinessTripsDTO model)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            return businessTripsService.GetBusinessTrips().Any(s => s.Doc_Number == model.Doc_Number && s.Doc_Date.Year == model.Doc_Date.Year
                && s.ID != model.ID);
        }

        private bool FindCurrentTrip(BusinessTripsDTO model)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            bool result = businessTripsService.GetBusinessTripsForEmployee(model.EmployeesID ?? 0).Any(s => (s.StartDate <= model.StartDate.Value.Date && s.EndDate >= model.StartDate.Value.Date) && s.ID != model.ID);
            return result;
        }

        private string GetLastNumber()
        {
            var allNumberBusinessTrips = businessTripsService.GetBusinessTrips().OrderByDescending(x => Decimal.
                Parse(x.Doc_Number.Replace('/', ','))).FirstOrDefault(x => x.Doc_Date.Year == DateTime.Now.Year);

            if (allNumberBusinessTrips != null)
            {
                decimal lastNumberBusinessTrips = Decimal.Parse(allNumberBusinessTrips.Doc_Number.Replace('/', ','));
                allNumberBusinessTrips.Doc_Number = (Math.Truncate(lastNumberBusinessTrips) + 1).ToString();
                return allNumberBusinessTrips.Doc_Number;
            }
            else
            {
                return "1";
            }
        }


        private int CalcAmountDay(DateTime dataStart, DateTime dataEnd)
        {
            return (dataEnd - dataStart).Days + 1;
        }
        #endregion

        #region Event's                                             

        private void startDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void endDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (startDateEdit.EditValue != null && endDateEdit.EditValue != null)
            {
                if ((DateTime)startDateEdit.EditValue <= (DateTime)endDateEdit.EditValue)
                {
                    ((BusinessTripsDTO)Item).AmountDays = CalcAmountDay((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                    amountDaysEdit.EditValue = ((BusinessTripsDTO)Item).AmountDays;
                    ((BusinessTripsDTO)Item).EndDate = (DateTime)endDateEdit.EditValue;
                }
                else
                {
                    MessageBox.Show("Не вірно задана дата. Початкова дата більша за кінцеву", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            businessTripValidationProvider.Validate((Control)sender);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (startDateEdit.EditValue != null && endDateEdit.EditValue != null)
            {
                if ((DateTime)startDateEdit.EditValue <= (DateTime)endDateEdit.EditValue)
                {
                    ((BusinessTripsDTO)Item).AmountDays = CalcAmountDay((DateTime)startDateEdit.EditValue, (DateTime)endDateEdit.EditValue);
                    amountDaysEdit.EditValue = ((BusinessTripsDTO)Item).AmountDays;
                    ((BusinessTripsDTO)Item).StartDate = (DateTime)startDateEdit.EditValue;
                }
                else
                {
                    MessageBox.Show("Не вірно задана дата. Початкова дата більша за кінцеву", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            
            if (_operation != Utils.Operation.Custom)
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
            else
            {
                this.Item.EndEdit();
                DialogResult = DialogResult.Retry;
                this.Close();
            }  
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void destinationEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
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

        private void organisationEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            contractorService = Program.kernel.Get<IContractorsService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Add, new ContractorsDTO()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorService = Program.kernel.Get<IContractorsService>();
                                organisationEdit.Properties.DataSource = contractorService.GetContractors(2);
                                organisationEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
            }
        }

        private void contractorEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            contractorService = Program.kernel.Get<IContractorsService>();
            switch (e.Button.Index)
            {
                case 1: //Очистити
                    {
                        contractorEdit.EditValue = null;
                        contractorEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        private void purposeEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (BusinessTripsPurposeEditFm purposeEditFm = new BusinessTripsPurposeEditFm(Utils.Operation.Add, new BusinessTripsPurposeDTO()))
                        {
                            if (purposeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = purposeEditFm.Return();
                                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                                purposeEdit.Properties.DataSource = businessTripsService.GetBusinessTripsPurpose();
                                purposeEdit.EditValue = return_Id;


                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (purposeEdit.EditValue == DBNull.Value)
                            return;

                        using (BusinessTripsPurposeEditFm purposeEditFm = new BusinessTripsPurposeEditFm(Utils.Operation.Update, (BusinessTripsPurposeDTO)purposeEdit.GetSelectedDataRow()))
                        {
                            if (purposeEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = purposeEditFm.Return();
                                businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                                purposeEdit.Properties.DataSource = businessTripsService.GetBusinessTripsPurpose();
                                purposeEdit.EditValue = return_Id;


                            }
                        }
                        break;
                    }
                case 3://Видалити
                    {
                        if (purposeEdit.EditValue == DBNull.Value)
                            return;
                     
                        if (MessageBox.Show("Видалити?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            businessTripsService.BusinessTripsPurposeDelete(((BusinessTripsPurposeDTO)purposeEdit.GetSelectedDataRow()).PurposeID);
                            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
                            purposeEdit.Properties.DataSource = businessTripsService.GetBusinessTripsPurpose();
                            purposeEdit.EditValue = null;
                            purposeEdit.Properties.NullText = "Немає данних";
                        }

                        break;
                    }
                case 4://Очистити
                    {
                        purposeEdit.EditValue = null;
                        purposeEdit.Properties.NullText = "Немає данних";
                        break;
                    }
            }
        }

        #endregion

        #region Validation                                          

        private bool ControlValidation()
        {
            return businessTripValidationProvider.Validate();
        }

        private void businessTripValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        private void businessTripValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (businessTripValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }
        
        private void docNumberEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void docDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void departureEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void employeesEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void destinationEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void contractorEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void amountDaysEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        private void organisationEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }
       
        private void purposeEdit_EditValueChanged(object sender, EventArgs e)
        {
            businessTripValidationProvider.Validate((Control)sender);
        }

        #endregion

    }
}