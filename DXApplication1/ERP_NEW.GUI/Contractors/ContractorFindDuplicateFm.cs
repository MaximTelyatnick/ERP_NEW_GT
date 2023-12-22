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

            contractorsMainEdit.DataBindings.Add("EditValue", contractorsMainBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsMainEdit.Properties.DataSource = contractorsMainBS;
            contractorsMainEdit.Properties.ValueMember = "Id";
            contractorsMainEdit.Properties.DisplayMember = "Name";
            contractorsMainEdit.Properties.NullText = "Немає данних";

            contractorsReplaceEdit.DataBindings.Add("EditValue", contractorsReplaceBS, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            contractorsReplaceEdit.Properties.DataSource = contractorsReplaceBS;
            contractorsReplaceEdit.Properties.ValueMember = "Id";
            contractorsReplaceEdit.Properties.DisplayMember = "Name";
            contractorsReplaceEdit.Properties.NullText = "Немає данних";

        }

        private void LoadData()
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
            invoicesByContractorId = accountingInvoicesService.GetInvoices().Where(srch => srch.Month_Invoice!=null).ToList();
            ordersByContractorId = storeHouseService.GetOrders().ToList();
            packingListsByContractorId = packingListsService.GetPackingLists().ToList();
            mtsAssembliesByContractorId = mtsSpecificationService.GetAllMtsAssemblies().ToList();

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

            //знаходимо усі договори по цьому контрагенту
            agreementOrderByAgreementId = contractorsService.GetAgreementOrder().Where(srch => srch.AgreementId == contractorId).ToList();

            if (agreementOrderByAgreementId.Count() > 0)
                textEdit.Text +=agreementOrderByAgreementId.Count().ToString() + "\n";


            agreementOrderByContractorId = contractorsService.GetAgreementOrder().Where(srch => srch.ContractorId == contractorId).ToList();
            if (agreementOrderByContractorId.Count() > 0)
                textEdit.Text += agreementOrderByContractorId.Count().ToString() + "\n";
            agreementByAgreementId = contractorsService.GetAgreements().Where(srch => srch.AgreementsIdFromContractor == contractorId).ToList();
            if (agreementByAgreementId.Count() > 0)
                textEdit.Text += agreementByAgreementId.Count().ToString() + "\n";
            agreementByContractorId = contractorsService.GetAgreements().Where(srch => srch.ContractorId == contractorId).ToList();
            if (agreementByContractorId.Count() > 0)
                textEdit.Text += agreementByContractorId.Count().ToString() + "\n";
            bankPayments = bankPaymentsService.GetBankPayments().Where(srch => srch.Contractor_Id == contractorId).ToList();
            if (bankPayments.Count() > 0)
                textEdit.Text += bankPayments.Count().ToString() + "\n";
            businessTripsByContractorId = businessTripsService.GetBusinessTrips().Where(srch => srch.ContractorsID == contractorId).ToList();
            if (businessTripsByContractorId.Count() > 0)
                textEdit.Text += businessTripsByContractorId.Count().ToString() + "\n";
            businessTripsByDepartureId = businessTripsService.GetBusinessTrips().Where(srch => srch.DepartureID == contractorId).ToList();
            if (businessTripsByDepartureId.Count() > 0)
                textEdit.Text += businessTripsByDepartureId.Count().ToString() + "\n";
            customerOrdersByContractorId = customerOrdersService.GetCustomerOrders().Where(srch => srch.ContractorId == contractorId).ToList();
            if (customerOrdersByContractorId.Count() > 0)
                textEdit.Text += customerOrdersByContractorId.Count().ToString() + "\n";
            customerOrdersByAgreementId = customerOrdersService.GetCustomerOrders().Where(srch => srch.AgreementId == contractorId).ToList();
            if (customerOrdersByAgreementId.Count() > 0)
                textEdit.Text += customerOrdersByAgreementId.Count().ToString() + "\n";
            calcWithBuyersByContractorId = calcWithBuyersService.GetCalcWithBuyers().Where(srch => srch.ContractorsId == contractorId).ToList();
            if (calcWithBuyersByContractorId.Count() > 0)
                textEdit.Text += calcWithBuyersByContractorId.Count().ToString() + "\n";
            invoicesByContractorId = accountingInvoicesService.GetInvoices().Where(srch => srch.Contractor_Id == contractorId).ToList();
            if (invoicesByContractorId.Count() > 0)
                textEdit.Text += invoicesByContractorId.Count().ToString() + "\n";
            ordersByContractorId = storeHouseService.GetOrders().Where(srch => srch.VENDOR_ID == contractorId).ToList();
            if (ordersByContractorId.Count() > 0)
                textEdit.Text += ordersByContractorId.Count().ToString() + "\n";
            packingListsByContractorId = packingListsService.GetPackingLists().Where(srch => srch.ContractorId == contractorId).ToList();
            if (packingListsByContractorId.Count() > 0)
                textEdit.Text += packingListsByContractorId.Count().ToString() + "\n";
            mtsAssembliesByContractorId = mtsSpecificationService.GetAllMtsAssemblies().Where(srch => srch.ContractorId == contractorId).ToList();
            if (mtsAssembliesByContractorId.Count() > 0)
                textEdit.Text += mtsAssembliesByContractorId.Count().ToString() + "\n";

            contractorsMainBS.DataSource = contractorsService.GetContractors(1); // 1 - все данные, 2 - только контрагенты без договоров, 3 - только договора
            contractorsReplaceBS.DataSource = contractorsService.GetContractors(1);

        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}