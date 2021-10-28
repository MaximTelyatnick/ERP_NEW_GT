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
using Ninject;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraBars;
using System;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.GUI.Contractors;

namespace ERP_NEW.GUI.CustomerOrders
{
    public partial class CustomerOrderEditFm : DevExpress.XtraEditors.XtraForm
    {
        private ICustomerOrdersService customerOrdersService;
        private IContractorsService contractorsService;
        private ICurrencyService currencyService;
        private IMtsSpecificationsService mtsSpecificationService;

        private BindingSource customerOrdersBS = new BindingSource();
        private BindingSource specificationsBS = new BindingSource();
        private BindingSource assembliesBS = new BindingSource();
        private BindingSource currencyBS = new BindingSource();
        private BindingSource contractorsBS = new BindingSource();
        private BindingSource agreementsBS = new BindingSource();

        private UserTasksDTO userTasksDTO;

        List<CustomerOrderSpecificationsDTO> specificationsList = new List<CustomerOrderSpecificationsDTO>();
        List<CustomerOrderSpecificationsDTO> specificationsDeleteList = new List<CustomerOrderSpecificationsDTO>();
        
        private Utils.Operation _operation;
        
        private ObjectBase Item
        {
            get { return customerOrdersBS.Current as ObjectBase; }
            set
            {
                customerOrdersBS.DataSource = value;
                //set in edit mode
                value.BeginEdit();
            }
        }

        public CustomerOrderEditFm(Utils.Operation operation, CustomerOrdersDTO model, UserTasksDTO userTaskDTO)
        {
            InitializeComponent();
            
            _operation = operation;
            this.userTasksDTO = userTaskDTO;
            customerOrdersBS.DataSource = Item = model;

            LoadData();

            orderNumberTBox.DataBindings.Add("EditValue", customerOrdersBS, "OrderNumber");
            orderDateEdit.DataBindings.Add("EditValue", customerOrdersBS, "OrderDate", true);
            orderPriceTBox.DataBindings.Add("EditValue", customerOrdersBS, "OrderPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyPriceTBox.DataBindings.Add("EditValue", customerOrdersBS, "CurrencyPrice", true, DataSourceUpdateMode.OnPropertyChanged);
            detailsTBox.DataBindings.Add("EditValue", customerOrdersBS, "Details");

            currencyEdit.DataBindings.Add("EditValue", customerOrdersBS, "CurrencyId", true, DataSourceUpdateMode.OnPropertyChanged);
            currencyEdit.Properties.DataSource = currencyBS;
            currencyEdit.Properties.ValueMember = "Id";
            currencyEdit.Properties.DisplayMember = "Code";
            currencyEdit.Properties.NullText = "Немає данних";

            assemblyEdit.DataBindings.Add("EditValue", customerOrdersBS, "AssemblyId", true, DataSourceUpdateMode.OnPropertyChanged);
            assemblyEdit.Properties.DataSource = assembliesBS;
            assemblyEdit.Properties.ValueMember = "AssemblyId";
            assemblyEdit.Properties.DisplayMember = "Drawing";
            assemblyEdit.Properties.NullText = "Немає данних";

            contractorsEdit.DataBindings.Add("EditValue", customerOrdersBS, "ContractorId", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsEdit.Properties.DataSource = contractorsBS;
            contractorsEdit.Properties.ValueMember = "Id";
            contractorsEdit.Properties.DisplayMember = "Name";
            contractorsEdit.Properties.NullText = "Немає данних";

            agreementEdit.DataBindings.Add("EditValue", customerOrdersBS, "AgreementId", true, DataSourceUpdateMode.OnPropertyChanged);
            agreementEdit.Properties.DataSource = agreementsBS;
            agreementEdit.Properties.ValueMember = "Id";
            agreementEdit.Properties.DisplayMember = "Name";
            agreementEdit.Properties.NullText = "Немає данних";

            if (operation == Utils.Operation.Update)
            {
                if (userTaskDTO.UserRoleId == 9)
                {
                    agreementEdit.Enabled = false;
                    contractorsEdit.Enabled = false;
                    currencyEdit.Enabled = false;
                    orderNumberTBox.Enabled = false;
                    orderDateEdit.Enabled = false;
                    orderPriceTBox.Enabled = false;
                    currencyPriceTBox.Enabled = false;
                    detailsTBox.Enabled = false;
                    addSpecBtn.Enabled = false;
                    editSpecBtn.Enabled = false;
                    deleteSpecBtn.Enabled = false;
                }

                bool isCurrency = (((CustomerOrdersDTO)Item).CurrencyId > 1);
                currencyPriceTBox.Enabled = isCurrency;
            }
            else
            {
                currencyPriceTBox.Enabled = false;
                
                ((CustomerOrdersDTO)Item).CurrencyId = 1; //UAH
                //((CustomerOrdersDTO)Item).OrderDate = DateTime.Today;
                ((CustomerOrdersDTO)Item).OrderPrice = 0.00m;
                ((CustomerOrdersDTO)Item).CurrencyPrice = 0.00m;
            }
            
            orderValidationProvider.Validate();
        }

        #region Method's

        private void LoadData()
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            currencyService = Program.kernel.Get<ICurrencyService>();
            contractorsService = Program.kernel.Get<IContractorsService>();
            mtsSpecificationService = Program.kernel.Get<IMtsSpecificationsService>();

            currencyBS.DataSource = currencyService.GetCurrency();
            contractorsBS.DataSource = contractorsService.GetContractors(2); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            agreementsBS.DataSource = contractorsService.GetContractors(3);
            assembliesBS.DataSource = mtsSpecificationService.GetMtsAssembliesAll(DateTime.MinValue, DateTime.MaxValue).OrderByDescending(bdsm=>bdsm.DateCreated).ToList();

            specificationsBS.DataSource = customerOrdersService.GetCustomerOrderSpecificationsByOrderId(((CustomerOrdersDTO)Item).Id).ToList();
            specificationGrid.DataSource = specificationsBS;
        }
        
        private bool IsDuplicateRecord(string orderNumber)
        {
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            return customerOrdersService.GetCustomerOrders().Any(s => s.OrderNumber == orderNumber);
        }

        private bool SaveOrder()
        {
            ((CustomerOrdersDTO)Item).DateUpdate = DateTime.Now;
            
            this.Item.EndEdit();
            
            try
            {
                customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();

                specificationsList = (List<CustomerOrderSpecificationsDTO>)specificationsBS.DataSource;
                
                if (_operation == Utils.Operation.Add)
                {
                    ((CustomerOrdersDTO)Item).Id = customerOrdersService.CustomerOrderCreate(((CustomerOrdersDTO)Item));

                    specificationsList.Select(s => { s.CustomerOrderId = ((CustomerOrdersDTO)Item).Id; return s; }).ToList();
                    
                    customerOrdersService.CustomerOrderSpecificationCreateRange(specificationsList);
                }
                else
                {
                    customerOrdersService.CustomerOrderUpdate(((CustomerOrdersDTO)Item));
                    specificationsList.Select(s => { s.CustomerOrderId = ((CustomerOrdersDTO)Item).Id; return s; }).ToList();

                    foreach (var item in specificationsList)
                    {
                        if (item.Id == 0)
                            customerOrdersService.CustomerOrderSpecificationCreate(item);
                        else
                            customerOrdersService.CustomerOrderSpecificationUpdate(item);
                    }

                    if (specificationsDeleteList.Count > 0)
                    {
                        foreach (var item in specificationsDeleteList)
                        {
                            if (item.Id > 0)
                                customerOrdersService.CustomerOrderSpecificationDelete(item.Id);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При збереженні виникла помилка. " + ex.Message, "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool ControlValidation()
        {
            return orderValidationProvider.Validate();
        }
        
        public int Return()
        {
            return ((CustomerOrdersDTO)Item).Id;
        }

        private void EditSpecification(Utils.Operation operation, CustomerOrderSpecificationsDTO model, bool isCurrency)
        {
            using (CustomerOrderSpecEditFm customerOrderSpecEditFm = new CustomerOrderSpecEditFm(operation, model, isCurrency))
            {
                if (customerOrderSpecEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnModel = customerOrderSpecEditFm.Return();

                    specificationGridView.BeginDataUpdate();

                    if (operation == Utils.Operation.Add)
                    {
                        specificationsBS.Add(returnModel);
                        specificationGrid.DataSource = specificationsBS;
                    }
                    else
                    {
                        ((CustomerOrderSpecificationsDTO)specificationsBS.Current).Name = returnModel.Name;
                        ((CustomerOrderSpecificationsDTO)specificationsBS.Current).Quantity = returnModel.Quantity;
                        ((CustomerOrderSpecificationsDTO)specificationsBS.Current).SinglePrice = returnModel.SinglePrice;
                        ((CustomerOrderSpecificationsDTO)specificationsBS.Current).SingleCurrencyPrice = returnModel.SingleCurrencyPrice;
                    }

                    specificationsBS.EndEdit();
                    specificationsBS.ResetCurrentItem();
                    specificationGridView.BeginSummaryUpdate();
                    specificationGridView.EndSummaryUpdate();

                    specificationGridView.EndDataUpdate();

                    CalculationPrice();
                }
            }
        }

        private void CalculationPrice()
        {
            specificationsList = (List<CustomerOrderSpecificationsDTO>)specificationsBS.DataSource;
            
            decimal allSumPrice = specificationsList.Sum(s => s.SumPrice) ?? 0.00m;
            decimal allSumCurrencyPrice = specificationsList.Sum(s => s.SumCurrencyPrice) ?? 0.00m;

            orderPriceTBox.EditValue = allSumPrice;
            currencyPriceTBox.EditValue = allSumCurrencyPrice;
        }

        private void EditAssembly(Utils.Operation operation, CustomerOrderAssembliesDTO model)
        {
            using (CustomerOrderAssemblyEditFm customerOrderAssemblyEditFm = new CustomerOrderAssemblyEditFm(operation, model))
            {
                if (customerOrderAssemblyEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var returnId = customerOrderAssemblyEditFm.Return();

                }
            }
        }

        #endregion

        #region Event's

        private void contractorsEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Add, new ContractorsDTO()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                contractorsEdit.Properties.DataSource = contractorsService.GetContractors(2);
                                contractorsEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (contractorsEdit.EditValue == DBNull.Value)
                            return;

                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Update, (ContractorsDTO)contractorsEdit.GetSelectedDataRow()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                contractorsEdit.Properties.DataSource = contractorsService.GetContractors(2);
                                contractorsEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3: //Очистить
                    {
                        contractorsEdit.EditValue = null;
                        contractorsEdit.Properties.NullText = "Немає данних";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void agreementEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Додати
                    {
                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Add, new ContractorsDTO()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                agreementEdit.Properties.DataSource = contractorsService.GetContractors(3);
                                agreementEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 2://Редагувати
                    {
                        if (agreementEdit.EditValue == DBNull.Value)
                            return;

                        using (ContractorEditFm contractorEditFm = new ContractorEditFm(Utils.Operation.Update, (ContractorsDTO)agreementEdit.GetSelectedDataRow()))
                        {
                            if (contractorEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                long return_Id = contractorEditFm.Return();
                                contractorsService = Program.kernel.Get<IContractorsService>();
                                agreementEdit.Properties.DataSource = contractorsService.GetContractors(3);
                                agreementEdit.EditValue = return_Id;
                            }
                        }
                        break;
                    }
                case 3: //Очистить
                    {
                        agreementEdit.EditValue = null;
                        agreementEdit.Properties.NullText = "Немає данних";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void assemblyEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1: //Очистить
                    {
                        assemblyEdit.EditValue = null;
                        assemblyEdit.Properties.NullText = "Немає данних";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void orderNumberTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = '.';
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            if (!ControlValidation()) return;

            if (specificationsBS.Count == 0)
            {
                MessageBox.Show("До заказу не додано жодної специфікації!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_operation == Utils.Operation.Add && IsDuplicateRecord(orderNumberTBox.EditValue.ToString()))
                {
                    MessageBox.Show("Введений номер заказу вже існує в базі!", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    orderNumberTBox.Focus();
                    return;
                }

                if (SaveOrder())
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Item.CancelEdit();

            this.Close();
        }

        private void currencyEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (currencyEdit.ItemIndex > -1)
            {
                if (((CurrencyDTO)currencyEdit.GetSelectedDataRow()).Id == 1)
                {
                    currencyPriceTBox.Enabled = false;
                    ((CustomerOrdersDTO)Item).CurrencyPrice = 0.00m;
                }
                else
                {
                    currencyPriceTBox.Enabled = true; 
                }
            }
        }

        private void addSpecBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool isCurrency = (((CustomerOrdersDTO)Item).CurrencyId > 1);
            EditSpecification(Utils.Operation.Add, new CustomerOrderSpecificationsDTO(), isCurrency);
        }

        private void editSpecBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (specificationsBS.Count > 0)
            {
                bool isCurrency = (((CustomerOrdersDTO)Item).CurrencyId > 1);
                EditSpecification(Utils.Operation.Update, (CustomerOrderSpecificationsDTO)specificationsBS.Current, isCurrency);
            }
        }

        private void deleteSpecBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (specificationsBS.Count > 0)
            {
                specificationGridView.BeginDataUpdate();

                specificationsDeleteList.Add((CustomerOrderSpecificationsDTO)specificationsBS.Current);
                specificationsBS.RemoveCurrent();
                
                specificationGridView.EndDataUpdate();

                specificationGridView.BeginSummaryUpdate();
                specificationGridView.EndSummaryUpdate();

                CalculationPrice();
            }
        }
                
        #endregion
        
        #region Validate event's

        private void orderNumberTBox_TextChanged(object sender, EventArgs e)
        {
            //orderValidationProvider.Validate((Control)sender);
        }

        private void contractorsEdit_EditValueChanged(object sender, EventArgs e)
        {
            orderValidationProvider.Validate((Control)sender);
        }
                
        private void orderDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            //orderValidationProvider.Validate((Control)sender);
        }

        private void orderValidationProvider_ValidationSucceeded(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventArgs e)
        {
            bool isValidate = (orderValidationProvider.GetInvalidControls().Count == 0);
            this.saveBtn.Enabled = isValidate;
            this.validateLbl.Visible = !isValidate;
        }

        private void orderValidationProvider_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            this.saveBtn.Enabled = false;
            this.validateLbl.Visible = true;
        }

        #endregion
        
    }
}