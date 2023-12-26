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
using ERP_NEW.BLL.DTO.ModelsDTO;
using Ninject;

namespace ERP_NEW.GUI.Contractors
{
    public partial class ContractorFindDuplicateFm : DevExpress.XtraEditors.XtraForm
    {
        private IContractorsService contractorsService;
        private IMtsSpecificationsService mtsSpecificationService;
        private IBankPaymentsService bankPaymentsService;
        private IBusinessTripsService businessTripsService;
        private ICalcWithBuyersService calcWithBuyersService;
        private ICustomerOrdersService customerOrdersService;
        private IPackingListsService packingListsService;
        private IAccountingInvoicesService accountingInvoicesService;
        private IStoreHouseService storeHouseService;
        private ILogService logService;


        private BindingSource contractorsMainBS = new BindingSource();
        private BindingSource contractorsReplaceBS = new BindingSource();
        private List<AgreementOrderDTO> agreementOrderByAgreementId = new List<AgreementOrderDTO>();
        private List<AgreementOrderDTO> agreementOrderByContractorId = new List<AgreementOrderDTO>();
        private List<AgreementsDTO> agreementByAgreementId = new List<AgreementsDTO>();
        private List<AgreementsDTO> agreementByContractorId = new List<AgreementsDTO>();
        private List<Bank_PaymentsDTO> bankPayments = new List<Bank_PaymentsDTO>();
        private List<BusinessTripsDTO> businessTripsByContractorId = new List<BusinessTripsDTO>();
        private List<BusinessTripsDTO> businessTripsByDepartureId = new List<BusinessTripsDTO>();
        private List<CustomerOrdersDTO> customerOrdersByContractorId = new List<CustomerOrdersDTO>();
        private List<CustomerOrdersDTO> customerOrdersByAgreementId = new List<CustomerOrdersDTO>();
        private List<CalcWithBuyersDTO> calcWithBuyersByContractorId = new List<CalcWithBuyersDTO>();
        private List<InvoicesDTO> invoicesByContractorId = new List<InvoicesDTO>();
        private List<OrdersDTO> ordersByContractorId = new List<OrdersDTO>();
        private List<PackingListsDTO> packingListsByContractorId = new List<PackingListsDTO>();
        private List<MtsAssembliesDTO> mtsAssembliesByContractorId = new List<MtsAssembliesDTO>();

        private UserTasksDTO userTasksDTO;
        public ContractorFindDuplicateFm(UserTasksDTO userTaskDTO)
        {
            InitializeComponent();
            this.userTasksDTO = userTaskDTO;

            LoadData();

            //contractorsMainEdit.DataBindings.Add("EditValue", contractorsMainBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsMainEdit.Properties.DataSource = contractorsMainBS;
            contractorsMainEdit.Properties.ValueMember = "Id";
            contractorsMainEdit.Properties.DisplayMember = "Name";
            contractorsMainEdit.Properties.NullText = "Немає данних";

            //contractorsReplaceEdit.DataBindings.Add("EditValue", contractorsReplaceBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsReplaceEdit.Properties.DataSource = contractorsReplaceBS;
            contractorsReplaceEdit.Properties.ValueMember = "Id";
            contractorsReplaceEdit.Properties.DisplayMember = "Name";
            contractorsReplaceEdit.Properties.NullText = "Немає данних";

        }

        private void LoadData()
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            //bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            //businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            //customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            //calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
            //accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            //storeHouseService = Program.kernel.Get<IStoreHouseService>();
            //packingListsService = Program.kernel.Get<IPackingListsService>();
            //mtsSpecificationService = Program.kernel.Get<IMtsSpecificationsService>();

            contractorsMainBS.DataSource = contractorsService.GetContractors(1); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            contractorsReplaceBS.DataSource = contractorsService.GetContractors(1);

            //agreementOrderByAgreementId = contractorsService.GetAgreementOrder().ToList();
            //agreementOrderByContractorId = contractorsService.GetAgreementOrder().ToList();
            //agreementByAgreementId = contractorsService.GetAgreements().ToList();
            //agreementByContractorId = contractorsService.GetAgreements().ToList();
            //bankPayments = bankPaymentsService.GetBankPayments().ToList();
            //businessTripsByContractorId = businessTripsService.GetBusinessTrips().ToList();
            //businessTripsByDepartureId = businessTripsService.GetBusinessTrips().ToList();
            //customerOrdersByContractorId = customerOrdersService.GetCustomerOrders().ToList();
            //customerOrdersByAgreementId = customerOrdersService.GetCustomerOrders().ToList();
            //calcWithBuyersByContractorId = calcWithBuyersService.GetCalcWithBuyers().ToList();
            //invoicesByContractorId = accountingInvoicesService.GetInvoices().Where(srch => srch.Month_Invoice!=null).ToList();
            //ordersByContractorId = storeHouseService.GetOrders().ToList();
            //packingListsByContractorId = packingListsService.GetPackingLists().ToList();
            //mtsAssembliesByContractorId = mtsSpecificationService.GetAllMtsAssemblies().ToList();

        }

        private void LoadFullDataByContractorId(int contractorId)
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            packingListsService = Program.kernel.Get<IPackingListsService>();
            mtsSpecificationService = Program.kernel.Get<IMtsSpecificationsService>();
            logService = Program.kernel.Get<ILogService>();
            textEdit.Text = "";
            //splashScreenManager.SetWaitFormDescription("dsdsdsd");
            splashScreenManager.ShowWaitForm();
            splashScreenManager.SetWaitFormCaption("Шукаємо");
            try
            {
                agreementOrderByAgreementId = contractorsService.GetAgreementOrder().Where(srch => srch.AgreementId == contractorId).ToList();
                if (agreementOrderByAgreementId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці AgreementsOrder");
                    textEdit.Text += "Знайдено записів у таблиці AgreementsOrder: " + agreementOrderByAgreementId.Count().ToString() + Environment.NewLine;
                }
                agreementOrderByContractorId = contractorsService.GetAgreementOrder().Where(srch => srch.ContractorId == contractorId).ToList();
                if (agreementOrderByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці AgreementsOrder");
                    textEdit.Text += "Знайдено записів у таблиці AgreementsOrder: " + agreementOrderByContractorId.Count().ToString() + Environment.NewLine;
                }
                    agreementByAgreementId = contractorsService.GetAgreements().Where(srch => srch.AgreementsIdFromContractor == contractorId).ToList();
                if (agreementByAgreementId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці Agreements");
                    textEdit.Text += "Знайдено записів у таблиці Agreements: " + agreementByAgreementId.Count().ToString() + Environment.NewLine;
                }
                agreementByContractorId = contractorsService.GetAgreements().Where(srch => srch.ContractorId == contractorId).ToList();
                if (agreementByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці Agreements");
                    textEdit.Text += "Знайдено записів у таблиці Agreements: " + agreementByContractorId.Count().ToString() + Environment.NewLine;
                }
                bankPayments = bankPaymentsService.GetBankPayments().Where(srch => srch.Contractor_Id == contractorId).ToList();
                if (bankPayments.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці BankPayments");
                    textEdit.Text += "Знайдено записів у таблиці BankPayments: " + bankPayments.Count().ToString() + Environment.NewLine;
                }
                businessTripsByContractorId = businessTripsService.GetBusinessTrips().Where(srch => srch.ContractorsID == contractorId).ToList();
                if (businessTripsByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці BusinessTrips");
                    textEdit.Text += "Знайдено записів у таблиці BusinessTrips: " + businessTripsByContractorId.Count().ToString() + Environment.NewLine;
                }
                businessTripsByDepartureId = businessTripsService.GetBusinessTrips().Where(srch => srch.DepartureID == contractorId).ToList();
                if (businessTripsByDepartureId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці BusinessTrips");
                    textEdit.Text += "Знайдено записів у таблиці BusinessTrips: " + businessTripsByDepartureId.Count().ToString() + Environment.NewLine;
                }
                customerOrdersByContractorId = customerOrdersService.GetCustomerOrders().Where(srch => srch.ContractorId == contractorId).ToList();
                if (customerOrdersByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці CustomerOrders");
                    textEdit.Text += "Знайдено записів у таблиці CustomerOrders: " + customerOrdersByContractorId.Count().ToString() + Environment.NewLine;
                }
                customerOrdersByAgreementId = customerOrdersService.GetCustomerOrders().Where(srch => srch.AgreementId == contractorId).ToList();
                if (customerOrdersByAgreementId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці CustomerOrders");
                    textEdit.Text += "Знайдено записів у таблиці CustomerOrders: " + customerOrdersByAgreementId.Count().ToString() + Environment.NewLine;
                }
                calcWithBuyersByContractorId = calcWithBuyersService.GetCalcWithBuyers().Where(srch => srch.ContractorsId == contractorId).ToList();
                if (calcWithBuyersByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці CalcWithBuyers");
                    textEdit.Text += "Знайдено записів у таблиці CalcWithBuyers: " + calcWithBuyersByContractorId.Count().ToString() + Environment.NewLine;
                }
                invoicesByContractorId = accountingInvoicesService.GetInvoices().Where(srch => srch.Contractor_Id == contractorId).ToList();
                if (invoicesByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці Invoices");
                    textEdit.Text += "Знайдено записів у таблиці Invoices: " + invoicesByContractorId.Count().ToString() + Environment.NewLine;
                }
                ordersByContractorId = storeHouseService.GetOrders().Where(srch => srch.VENDOR_ID == contractorId).ToList();
                if (ordersByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці Orders");
                    textEdit.Text += "Знайдено записів у таблиці Orders: " + ordersByContractorId.Count().ToString() + Environment.NewLine;
                }
                packingListsByContractorId = packingListsService.GetPackingLists().Where(srch => srch.ContractorId == contractorId).ToList();
                if (packingListsByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці PackingLists");
                    textEdit.Text += "Знайдено записів у таблиці PackingLists: " + packingListsByContractorId.Count().ToString() + Environment.NewLine;
                }
                mtsAssembliesByContractorId = mtsSpecificationService.GetAllMtsAssemblies().Where(srch => srch.ContractorId == contractorId).ToList();
                if (mtsAssembliesByContractorId.Count() > 0)
                {
                    splashScreenManager.SetWaitFormDescription("Таблиці MtsAssemblies");
                    textEdit.Text += "Знайдено записів у таблиці MtsAssemblies: " + mtsAssembliesByContractorId.Count().ToString() + Environment.NewLine;
                }
                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при пошуку "+ex.Message);
            }
            
            DialogResult = DialogResult.None;
        }

        private void UpdateDataByContractorId(int contractorId)
        {
            contractorsService = Program.kernel.Get<IContractorsService>();
            bankPaymentsService = Program.kernel.Get<IBankPaymentsService>();
            businessTripsService = Program.kernel.Get<IBusinessTripsService>();
            customerOrdersService = Program.kernel.Get<ICustomerOrdersService>();
            calcWithBuyersService = Program.kernel.Get<ICalcWithBuyersService>();
            accountingInvoicesService = Program.kernel.Get<IAccountingInvoicesService>();
            storeHouseService = Program.kernel.Get<IStoreHouseService>();
            packingListsService = Program.kernel.Get<IPackingListsService>();
            mtsSpecificationService = Program.kernel.Get<IMtsSpecificationsService>();
            logService = Program.kernel.Get<ILogService>();
            updateEdit.Text = "";
            //splashScreenManager.SetWaitFormDescription("dsdsdsd");
            splashScreenManager.ShowWaitForm();
            splashScreenManager.SetWaitFormCaption("Оновлюємо");

            try
            {
                int counter = 0;
                if (agreementOrderByAgreementId.Count() > 0)
                {
                    foreach (var item in agreementOrderByAgreementId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:AgreementOrder Id: " + item.Id + " OldAgreementId:" + item.AgreementId + " NewAgreementId:" + contractorId});
                        item.AgreementId = contractorId;
                        contractorsService.AgreementsOrderUpdate(item);
                        ++counter;
                        
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці AgreementsOrder");
                    updateEdit.Text += "Оновлено записів у таблиці AgreementsOrder: " + counter + Environment.NewLine;
                }
                //agreementOrderByContractorId = contractorsService.GetAgreementOrder().Where(srch => srch.ContractorId == contractorId).ToList();
                counter = 0;
                if (agreementOrderByContractorId.Count() > 0)
                {
                    foreach (var item in agreementOrderByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:AgreementOrder Id: " + item.Id + " OldContractorId:" + item.ContractorId + " NewContractorId:" + contractorId });
                        item.ContractorId = contractorId;
                        contractorsService.AgreementsOrderUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці AgreementsOrder");
                    updateEdit.Text += "Оновлено записів у таблиці AgreementsOrder: " + counter + Environment.NewLine;
                }
                counter = 0;
                if (agreementByAgreementId.Count() > 0)
                {
                    foreach (var item in agreementByAgreementId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:Agreement Id: " + item.Id + " OldAgreementsIdFromContractor:" + item.AgreementsIdFromContractor + " NewAgreementsIdFromContractor:" + contractorId });
                        item.AgreementsIdFromContractor = contractorId;
                        contractorsService.AgreementsUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці Agreements");
                    updateEdit.Text += "Оновлено записів у таблиці Agreements: " + counter + Environment.NewLine;
                }
                //agreementByContractorId = contractorsService.GetAgreements().Where(srch => srch.ContractorId == contractorId).ToList();
                counter = 0;
                if (agreementByContractorId.Count() > 0)
                {
                    foreach (var item in agreementByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:Agreement Id: " + item.Id + " OldContractorId:" + item.ContractorId + " NewContractorId:" + contractorId });
                        item.ContractorId = contractorId;
                        contractorsService.AgreementsUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці Agreements");
                    updateEdit.Text += "Оновлено записів у таблиці Agreements: " + counter + Environment.NewLine;
                }
                //bankPayments = bankPaymentsService.GetBankPayments().Where(srch => srch.Contractor_Id == contractorId).ToList();
                counter = 0;
                if (bankPayments.Count() > 0)
                {
                    foreach (var item in bankPayments)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:BankPayments Id: " + item.Id + " OldContractor_Id:" + item.Contractor_Id + " NewContractor_Id:" + contractorId });
                        item.Contractor_Id = contractorId;
                        bankPaymentsService.BankPaymentUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці BankPayments");
                    updateEdit.Text += "Оновлено записів у таблиці BankPayments: " + counter + Environment.NewLine;
                }
                //businessTripsByContractorId = businessTripsService.GetBusinessTrips().Where(srch => srch.ContractorsID == contractorId).ToList();
                counter = 0;
                if (businessTripsByContractorId.Count() > 0)
                {
                    foreach (var item in businessTripsByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:BusinessTrips Id: " + item.ID + " OldContractorsID:" + item.ContractorsID + " NewContractorsID:" + contractorId });
                        item.ContractorsID = contractorId;
                        businessTripsService.BusinessTripUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці BusinessTrips");
                    updateEdit.Text += "Оновлено записів у таблиці BusinessTrips: " + counter + Environment.NewLine;
                }
                //businessTripsByDepartureId = businessTripsService.GetBusinessTrips().Where(srch => srch.DepartureID == contractorId).ToList();
                counter = 0;
                if (businessTripsByDepartureId.Count() > 0)
                {
                    foreach (var item in businessTripsByDepartureId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:BusinessTrips Id: " + item.ID + " OldDepartureID:" + item.DepartureID + " NewDepartureID:" + contractorId });
                        item.DepartureID = contractorId;
                        businessTripsService.BusinessTripUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці BusinessTrips");
                    updateEdit.Text += "Оновлено записів у таблиці BusinessTrips: " + counter + Environment.NewLine;
                }
                //customerOrdersByContractorId = customerOrdersService.GetCustomerOrders().Where(srch => srch.ContractorId == contractorId).ToList();
                counter = 0;
                if (customerOrdersByContractorId.Count() > 0)
                {
                    foreach (var item in customerOrdersByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:CustomerOrders Id: " + item.Id + " OldContractorId:" + item.ContractorId + " NewContractorId:" + contractorId });
                        item.ContractorId = contractorId;
                        customerOrdersService.CustomerOrderUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці CustomerOrders");
                    updateEdit.Text += "Оновлено записів у таблиці CustomerOrders: " + counter + Environment.NewLine;
                }
                //customerOrdersByAgreementId = customerOrdersService.GetCustomerOrders().Where(srch => srch.AgreementId == contractorId).ToList();
                counter = 0;
                if (customerOrdersByAgreementId.Count() > 0)
                {
                    foreach (var item in customerOrdersByAgreementId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:CustomerOrders Id: " + item.Id + " OldAgreementId:" + item.AgreementId + " NewAgreementId:" + contractorId });
                        item.AgreementId = contractorId;
                        customerOrdersService.CustomerOrderUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці CustomerOrders");
                    updateEdit.Text += "Оновлено записів у таблиці CustomerOrders: " + counter + Environment.NewLine;
                }
                //calcWithBuyersByContractorId = calcWithBuyersService.GetCalcWithBuyers().Where(srch => srch.ContractorsId == contractorId).ToList();
                counter = 0;
                if (calcWithBuyersByContractorId.Count() > 0)
                {
                    foreach (var item in calcWithBuyersByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:CalcWithBuyers Id: " + item.Id + " OldContractorsId:" + item.ContractorsId + " NewContractorsId:" + contractorId });
                        item.ContractorsId = contractorId;
                        calcWithBuyersService.CalcWithBuyerUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці CalcWithBuyers");
                    updateEdit.Text += "Оновлено записів у таблиці CalcWithBuyers: " + counter + Environment.NewLine;
                }
                //invoicesByContractorId = accountingInvoicesService.GetInvoices().Where(srch => srch.Contractor_Id == contractorId).ToList();
                counter = 0;
                if (invoicesByContractorId.Count() > 0)
                {
                    foreach (var item in invoicesByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:Invoices Id: " + item.Id + " OldContractor_Id:" + item.Contractor_Id + " NewContractor_Id:" + contractorId });
                        item.Contractor_Id = contractorId;
                        accountingInvoicesService.AccountsInvoiceUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці Invoices");
                    updateEdit.Text += "Оновлено записів у таблиці Invoices: " + counter + Environment.NewLine;
                }
                //ordersByContractorId = storeHouseService.GetOrders().Where(srch => srch.VENDOR_ID == contractorId).ToList();
                counter = 0;
                if (ordersByContractorId.Count() > 0)
                {
                    foreach (var item in ordersByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:Orders Id: " + item.ID + " OldVENDOR_ID:" + item.VENDOR_ID + " NewVENDOR_ID:" + contractorId });
                        item.VENDOR_ID = contractorId;
                        storeHouseService.OrderUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці Orders");
                    updateEdit.Text += "Оновлено записів у таблиці Orders: " + counter + Environment.NewLine;
                }
                //packingListsByContractorId = packingListsService.GetPackingLists().Where(srch => srch.ContractorId == contractorId).ToList();
                counter = 0;
                if (packingListsByContractorId.Count() > 0)
                {
                    foreach (var item in packingListsByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:PackingLists Id: " + item.Id + " OldContractorId:" + item.ContractorId + " NewContractorId:" + contractorId });
                        item.ContractorId = contractorId;
                        packingListsService.PackingListUpdate(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці PackingLists");
                    updateEdit.Text += "Оновлено записів у таблиці PackingLists: " + counter + Environment.NewLine;
                }
                //mtsAssembliesByContractorId = mtsSpecificationService.GetAllMtsAssemblies().Where(srch => srch.ContractorId == contractorId).ToList();
                counter = 0;
                if (mtsAssembliesByContractorId.Count() > 0)
                {
                    foreach (var item in mtsAssembliesByContractorId)
                    {
                        logService.LogCreate(new LogDTO { UserId = userTasksDTO.UserId, Info = "Table:MtsAssemblies Id: " + item.Id + " OldContractorId:" + item.ContractorId + " NewContractorId:" + contractorId });
                        item.ContractorId = contractorId;
                        mtsSpecificationService.UpdateAssembly(item);
                        ++counter;
                    }
                    splashScreenManager.SetWaitFormDescription("Таблиці MtsAssemblies");
                    updateEdit.Text += "Оновлено записів у таблиці MtsAssemblies: " + counter + Environment.NewLine;
                }
                splashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Виникла помилка при оновленні " + ex.Message);
            }
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            if ((contractorsReplaceEdit.EditValue != null) & (contractorsMainEdit.EditValue != null))
            {
                UpdateDataByContractorId((int)contractorsMainEdit.EditValue);
                replaceBtn.Enabled = false;
                checkBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Не обрано одного з контрагентів");
            }
            DialogResult = DialogResult.None;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (contractorsReplaceEdit.EditValue != null)
            {
                LoadFullDataByContractorId((int)contractorsReplaceEdit.EditValue);
                replaceBtn.Enabled = true;
                //checkBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не обрано контрагента");
            }

            DialogResult = DialogResult.None;
        }
    }
}