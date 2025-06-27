using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FirebirdSql.Data.FirebirdClient;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.ReportModel;
using System;

namespace ERP_NEW.DAL.EF
{
    public static class Connection
    {
        public static string ConnectionString;
    }
    
    public class ERP_Context : DbContext
    {
        #region DBSet`s
        //A
        public DbSet<AccessScheduleEntity> AccessScheduleEntity { get; set; }
        public DbSet<ACCOUNTS> Accounts { get; set; }
        public DbSet<AccountsType> AccountsType { get; set; }
        public DbSet<AccountClothes> AccountClothes { get; set; }
        public DbSet<AccountClothesInfo> AccountClothesInfo { get; set; }
        public DbSet<AccountClothesMaterials> AccountClothesMaterials { get; set; }
        public DbSet<AccountClothesJournal> AccountClothesJournal { get; set; }
        public DbSet<AccessRights> AccessRights { get; set; }
        public DbSet<AccountingOperations> AccountingOperations { get; set; }
        public DbSet<AccountingOperation> AccountingOperation { get; set; }
        public DbSet<AccountOrders> AccountOrders { get; set; }
        public DbSet<AgreementJournal> AgreementJournal { get; set; }
        public DbSet<AgreementsType> AgreementsType { get; set; }
        public DbSet<AgreementDocuments> AgreementDocuments { get; set; }
        public DbSet<Agreements> Agreements { get; set; }
        //public DbSet<Agreements> AgreementsScan{ get; set; }
        public DbSet<AgreementTypeDocuments> AgreementTypeDocuments { get; set; }
        public DbSet<AgreementOrder> AgreementOrder { get; set; }
        public DbSet<AgreementOrderScan> AgreementOrderScan { get; set; }
        public DbSet<AgreementOrderPurpose> AgreementOrderPurpose { get; set; }
        public DbSet<AgreementOrderJournal> AgreementOrderJournal { get; set; }

        //B
        public DbSet<BeginCredit> BeginCredit { get; set; }
        public DbSet<BusinessCards> BusinessCards { get; set; }
        public DbSet<BusinessCardsFactory> BusinessCardsFactory { get; set; }
        public DbSet<BusinessCardPhotos> BusinessCardPhotos { get; set; }
        public DbSet<BusinessTrips> BusinessTrips { get; set; }
        public DbSet<BusinessTripsDecree> BusinessTripsDecree { get; set; }
        public DbSet<BusinessTripsDetails> BusinessTripsDetails { get; set; }
        public DbSet<BusinessTripsJournal> BusinessTripsJournal { get; set; }
        public DbSet<BusinessTripsOrderCust> BusinessTripsOrderCust { get; set; }
        public DbSet<BusinessTripsPurpose> BusinessTripsPurpose { get; set; }
        public DbSet<BusinessTripsPrepayment> BusinessTripsPrepayment { get; set; }
        public DbSet<BusinessTripsPayment> BusinessTripsPayment { get; set; }
        public DbSet<BusinessTripsPaymentVat> BusinessTripsPaymentVat { get; set; }
        public DbSet<BusinessTripsDecreeDetails> BusinessTripsDecreeDetails { get; set; }
        public DbSet<BusinessTripsReport> BusinessTripsReport { get; set; }
        public DbSet<Bank_Payments> Bank_Payments { get; set; }
        public DbSet<Balance_Account> Balance_Account { get; set; }

        public DbSet<BusinessTripsPaymentStatement> BusinessTripsPaymentStatement { get; set; }
        public DbSet<BusinessTripsReportByAccounts> BusinessTripsReportByAccounts { get; set; }
        public DbSet<BusinessTripsReportByCurrency> BusinessTripsReportByCurrency { get; set; }
        public DbSet<BusinessTripsReportByEmployees> BusinessTripsReportByEmployees { get; set; }
        public DbSet<BusinessTripsReportByDepartments> BusinessTripsReportByDepartments { get; set; }
        public DbSet<BusinessTripsPrepaymentJournal> BusinessTripsPrepaymentJournal { get; set; }
        public DbSet<BusinessTripsReportPaymentsByAccountId> BusinessTripsReportPaymentsByAccountId { get; set; }
        public DbSet<BusinessTripsReportPrepaymentsByAccountId> BusinessTripsReportPrepaymentsByAccountId { get; set; }
        public DbSet<BusinessTripsReportPrepaymentsByAccountShort> BusinessTripsReportPrepaymentsByAccount313 { get; set; }
        public DbSet<BusinessTripsReportPaymentsByPeriod> BusinessTripsReportPaymentsByPeriod { get; set; }
        public DbSet<BankPaymentsInfo> BankPaymentsInfo { get; set; }
        public DbSet<BankPaymentsSelect> BankPaymentsSelect { get; set; }

        //DeliveryStoreRemainsReceiptDTO

        public DbSet<BankPaymentsReportTrialBalance> BankPaymentsReportTrialBalance { get; set; }
        public DbSet<BankPaymentsReportForCustomBill> BankPaymentsReportForCustomBill { get; set; }
        public DbSet<BankPaymentsReportTrialBalanceQuarter> BankPaymentsReportTrialBalanceQuarter { get; set; }
        public DbSet<BankPaymentsReportTrialBalanceFull> BankPaymentsReportTrialBalanceFull { get; set; }
        public DbSet<BankPaymentsReportTrialBalanceAll313> BankPaymentsReportTrialBalanceAll313 { get; set; }
        public DbSet<TrialBalanceByAccountsReport> TrialBalanceByAccountsReport { get; set; }
        public DbSet<DetalsReportByOperationContractors> DetalsReportByOperationContractors { get; set; }
        public DbSet<OrderForDetalsContractor> OrderForDetalsContractor { get; set; }
        public DbSet<GetBPDetalsReportByCon> GetBPDetalsReportByCon { get; set; }
        //C
        public DbSet<Calculation> Calculation { get; set; }
        public DbSet<CalculationMaterials> CalculationMaterials { get; set; }
        public DbSet<Contractors> Contractors { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<ContractorTypes> ContractorTypes { get; set; }
        public DbSet<ContractorContactAddress> ContactorContactAddress { get; set; }
        public DbSet<ContractorContactPersons> ContractorContactPersons { get; set; }
        public DbSet<ContactPersons> ContactPersons { get; set; }
        public DbSet<ContactPersonAddress> ContactPersonAddress { get; set; }
        public DbSet<ContactKinds> ContactKinds { get; set; }
        public DbSet<ContactTypes> ContactTypes { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CustomerOrders> CustomerOrders { get; set; }
        public DbSet<CustomerOrderForWelding> CustomerOrderFowWelding { get; set; }
        public DbSet<CustomerOrderSpecifications> CustomerOrderSpecifications { get; set; }
        public DbSet<CustomerOrderAssemblies> CustomerOrderAssemblies { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Currency_Rates> Currency_Rates { get; set; }
        public DbSet<ControlChecks> ControlChecks { get; set; }
        public DbSet<CashPrepayments> CashPrepayments { get; set; }
        public DbSet<CashPayments> CashPayments { get; set; }
        public DbSet<CashPrepaymentsInfo> CashPrepaymentsInfo { get; set; }
        public DbSet<CashBooks> CashBooks { get; set; }
        public DbSet<CashPaymentsInfo> CashPaymentsInfo { get; set; }
        public DbSet<CalcWithBuyers> CalcWithBuyers { get; set; }
        public DbSet<CalcWithBuyersSpec> CalcWithBuyersSpec { get; set; }
        public DbSet<CalcWithBuyersInfo> CalcWithBuyersInfo { get; set; }
        public DbSet<CalcWithBuyersPaymentVat> CalcWithBuyersPaymentVat { get; set; }
        public DbSet<CashBookBasisType> CashBookBasisType { get; set; }
        public DbSet<CashBookPage> CashBookPage { get; set; }
        public DbSet<CashBookRecordType> CashBookRecordType { get; set; }
        public DbSet<CashBookRecord> CashBookRecord { get; set; }
        public DbSet<CashBookRecordJournal> CashBookRecordJournal { get; set; }
        public DbSet<CashBookBalance> CashBookBalance { get; set; }
        public DbSet<CashBookContractor> CashBookContractor { get; set; }
        public DbSet<CashBookRecordJournalByYear> CashBookRecordJournalByYear { get; set; }

        public DbSet<CashBookAdditionalType> CashBookAdditionalType { get; set; }

        public DbSet<CustomerOrdersForCWB> CustomerOrdersForCWB { get; set; }
        public DbSet<CustomerOrderPayments> CustomerOrderPayments { get; set; }
        public DbSet<CustomerOrderPrepayments> CustomerOrderPrepayments { get; set; }

        public DbSet<ContractorVat> ContractorVat { get; set; }
        public DbSet<CashPaymentsReportByAccounts> CashPaymentsReportByAccounts { get; set; }
        public DbSet<CashPaymentsSaldoBalance> CashPaymentsSaldoBalance { get; set; }
        public DbSet<CashPaymentsPeriodBalance> CashPaymentsPeriodBalance { get; set; }
        public DbSet<CalcWithBuyersReport> CalcWithBuyersReport { get; set; }
        public DbSet<CalcWithBuyersShortReport> CalcWithBuyersShortReport { get; set; }
        public DbSet<ContractPayments> ContractPayments { get; set; }
        //D
        public DbSet<Departments> Department { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<DeliveryOrders> DeliveryOrders { get; set; }
        public DbSet<DeliveryOrder> DeliveryOrder { get; set; }
        public DbSet<DeliveryOrdersDetails> DeliveryOrdersDetails { get; set; }
        public DbSet<DeliveryPayments> DeliveryPayments { get; set; }
        public DbSet<DeliveryPaymentType> DeliveryPaymentType { get; set; }
        public DbSet<DeliveryContractorDebts> DeliveryContractorDebts { get; set; }
        public DbSet<DeliveryStoreRemains> DeliveryStoreRemains { get; set; }
        public DbSet<DeliveryStoreRemainsReceipt> DeliveryStoreRemainsReceipt {get;set;}
        public DbSet<DefectActs> DefectActs { get; set; }
        public DbSet<DocumentTypes> DocumentTypes { get; set; }
        public DbSet<DefectActReplies> DefectService { get; set; }
        public DbSet<DictionaryUKTV> DictionaryUKTV { get; set; }
        public DbSet<DictionaryCPV> DictionaryCPV { get; set; }
        public DbSet<DictionaryDKPP> DictionaryDKPP { get; set; }
        //E
        public DbSet<Employees> Employee { get; set; }
        public DbSet<EmployeesDetails> EmployeesDetails { get; set; }
        public DbSet<EmployeePhoto> EmployeePhoto { get; set; }
        public DbSet<EntityPhotos> EntityPhoto { get; set; }
        public DbSet<EmployeesInfo> EmployeesInfo { get; set; }
        public DbSet<EmployeesInfoOnlyWithWeldStamp> EmployeesInfoOnlyWithWeldStamp { get; set; }
        public DbSet<EmployeesInfoNonPhoto> EmployeesInfoNonPhoto { get; set; }
        public DbSet<ExpenditureByOrders> ExpenditureByOrders { get; set; }
        public DbSet<EmployeesForWeld> EmployeesForWeld { get; set; }
        public DbSet<EmployeeCertificates> EmployeeCertificates { get; set; }
        public DbSet<EmployeesDetailsStandart> EmployeesDetailsStandart { get; set; }
        public DbSet<EmployeeVisitSchedule> EmployeeVisitSchedules { get; set; }
        public DbSet<EXPENDITURES_ACCOUNTANT> ExpedinturesAccountant { get; set; }
        public DbSet<ExpenditureInfo> ExpenditureInfo{ get; set; }
        public DbSet<ExpenditureForProjectReport> ExpenditureForProjectReport { get; set; }
        public DbSet<ExpenditureTotalPrice> ExpenditureTotalPrice { get; set; }
        public DbSet<ExpendituresStoreHouses> ExpendituresStoreHouses { get; set; }
        public DbSet<ExpenditureStoreHouse> ExpenditureStoreHouse { get; set; }
        public DbSet<ExpendituresStoreHousesInfo> ExpendituresStoreHousesInfo { get; set; }
        public DbSet<ExpenditureStoreHouseInfo> ExpenditureStoreHouseInfo { get; set; }
        public DbSet<ExpenditureForProjectReportByContractor> ExpenditureForProjectReportByContractor { get; set; }

        //F
        public DbSet<FixedAssetsGroup> FixedAssetsGroup { get; set; }
        public DbSet<FixedAssetsOrder> FixedAssetsOrder { get; set; }
        public DbSet<FixedAssetsOrderJournal> FixedAssetsOrderJournal { get; set; }
        public DbSet<FixedAssetsNoAmort> FixedAssetsNoAmort { get; set; }
        public DbSet<FixedAssetsMaterials> FixedAssetsMaterials { get; set; }
        public DbSet<FixedAssetsOrderListMaterialsJournal> FixedAssetsOrderListMaterialsJournal { get; set; }
        public DbSet<FixedAssetsOrderArchiveJournal> FixedAssetsOrderArchiveJournal { get; set; }
        public DbSet<FixedAssetsOrderJournalPrint> FixedAssetsOrderJournalPrint { get; set; }
        public DbSet<FixedAssetsOrderMaterialsPrintJournal> FixedAssetsOrderMaterialsPrintJournal { get; set; }
        public DbSet<FixedAssetsOrderRegistration> FixedAssetsOrderRegistration { get; set; }
        public DbSet<FixedAssetsOrderRegJournal> FixedAssetsOrderRegJournal { get; set; }
        public DbSet<FixedAssetsOrderReportStrait> FixedAssetsOrderReportStraitJournal { get; set; }
        public DbSet<FixedAssetsOrderByGroupShortReport> FixedAssetsOrderByGroupShortReport { get; set; }
        public DbSet<FixedAssetsReportRegisterCh1> FixedAssetsReportRegisterCh1 { get; set; }
        public DbSet<FixedAssetsReportRegisterCh2> FixedAssetsReportRegisterCh2 { get; set; }
        public DbSet<InputFixedAssetsForGroup> InputFixedAssetsForGroup { get; set; }
        public DbSet<InputFixedAssetsForQuarter> InputFixedAssetsForQuarter { get; set; }

        
        //I
        public DbSet<InvoicesInfo> InvoicesInfo { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Invoices_Notes> Invoices_Notes { get; set; }
        public DbSet<Invoice_Requirement_Materials> InvoiceRequirementMaterials { get; set; }
        public DbSet<Invoice_Requirement_Orders> InvoiceRequirementOrders { get; set; }
        public DbSet<InvoiceRequirementMaterialsInfo> InvoiceRequirementMaterialsInfo { get; set; }
        public DbSet<InvoiceRequirementExpenditureInfo> InvoiceRequirementExpenditureInfo { get; set; }
        public DbSet<InvoicesFixedAssetsInfo> InvoicesFixedAssetsInfo { get; set; }


        public DbSet<GetOSVkvartal_ForChess> GetOSVkvartal_ForChess { get; set; }
        //L
        public DbSet<LastIdOrderGen> LastIdOrderGen { get; set; }
        public DbSet<LastIdInvoicesReqGen> LastIdInvoicesReqGen { get; set; }
        public DbSet<LastIdInvoicesReqMatGen> LastIdInvoicesReqMatGen { get; set; }
        public DbSet<Log> Log { get; set; }

        //M
        //public DbSet<MaterialsForAccountClothes> MaterialsForAccountClothes { get; set; }

        public DbSet<MtsAdditCalculations> MtsAdditCalculations { get; set; }
        public DbSet<MtsAssemblies> MtsAssemblies { get; set; }
        public DbSet<MtsSpecifications> MtsSpecifications { get; set; }
        public DbSet<MtsNomenclatures> MtsNomenclatures { get; set; }
        public DbSet<MtsNomenclatureGroups> MtsNomenclatureGroups { get; set; }
        public DbSet<MtsGosts> MtsGosts { get; set; }
       // public DbSet<MTSDetailsProcessing> MtsDetailProcessings { get; set; }
        //public DbSet<MTSDetails> MtsDetails { get; set; }
        public DbSet<MtsModifications> MtsModifications { get; set; }
        public DbSet<MtsCreatedDetails> MtsCreatedDetails { get; set; }
        public DbSet<MtsAssemblyDetails> MtsAssemblyDetails { get; set; }
        public DbSet<MtsAssembliesInfo> MtsAssembliesInfo { get; set; }
        public DbSet<MtsAssembliesCustomerInfo> MtsAssembliesCustomerInfo { get; set; }
        public DbSet<MtsDocuments> MtsSpeciications { get; set; }
        public DbSet<MtsSpecificationTreeInfo> MtsSpeciicationTreeInfo { get; set; }
        public DbSet<MtsDetailsInfo> MtsDetailsInfo { get; set; }
        public DbSet<MaterialsForAccountClothes> MaterialsForAccountClothes { get; set; }
        public DbSet<MSPaymentsWithoutVat> MSPaymentsWithoutVat { get; set; }
        public DbSet<MSTrialBalanceByAccounts> MSTrialBalanceByAccounts { get;set; }
        

        public DbSet<MTSSpecificationss> MTSSpecificationsOld { get; set; }
        public DbSet<MTSAuthorizationUsers> MTSAuthorizationUsers { get; set; }
        public DbSet<MTSCreateDetals> MTSCreateDetals { get; set; }
        public DbSet<MTSGost> MTSGost { get; set; }
        public DbSet<MTSNomenclaturesOld> MTSNomenclaturesOld { get; set; }
        public DbSet<MTSGuages> MTSGuages { get; set; }
        public DbSet<MTSDetalsProcessing> MTSDetailsProcessing { get; set; }
        public DbSet<MTSDetails> MTSDetails { get; set; }
        public DbSet<MTSMeasure> MTSMeasure { get; set; }
        public DbSet<MTSPurchasedProducts> MTSPurchasedProducts { get; set; }
        public DbSet<MTSNomenclatureGroupsOld> MTSNomenclatureGroupsOld { get; set; }

        public DbSet<MTS_DETAILS> MTS_DETAILS { get; set; }
        public DbSet<MTS_MATERIALS> MTS_MATERIALS { get; set; }
        public DbSet<MTS_PURCHASED_PRODUCTS> MTS_PURCHASED_PRODUCTS { get; set; }
        public DbSet<MTS_CUSTOMERORDERS> MTSCustomerOrders { get; set; }
        public DbSet<MTS_SPECIFICATIONS> MTS_SPECIFICATIONS { get; set; }



        public DbSet<MsTrialBalanceCurrency> MsTrialBalanceCurrency { get; set; }
        public DbSet<MsTrialBalance> MsTrialBalance { get; set; }
        public DbSet<MsDebitCredit> MsDebitCredit { get; set; }
        public DbSet<MsTrialBalanceByAccountsCurrency> MsTrialBalanceByAccountsCurrency { get; set; }
        public DbSet<MsReconciliation> MsReconciliation { get; set; }
        public DbSet<MsReconciliation681_36> MsReconciliation681_36 { get; set; }
        public DbSet<MTSMaterials> MTSMaterials { get; set; }

        //N
        public DbSet<NOMENCLATURES> Nomenclatures { get; set; }
        public DbSet<Nomenclature_Groups> Nomenclature_Groups { get; set; }
        
        //O
        public DbSet<ORDERS> Orders { get; set; }
        public DbSet<OrdersInfo> OrdersInfo { get; set; }
        public DbSet<OrderReceipFromQuery> OrderReceipFromQuery { get; set;}
        //P
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<PackingLists> PackingLists { get; set; }
        public DbSet<PackingListDetail> PackingListDetail { get; set; }
        public DbSet<PackingListsJournal> PackingListsJournal { get; set; }
        public DbSet<PackingListMaterials> PackingListMaterials { get; set; }
        public DbSet<Periods> Periods { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }
        public DbSet<ProjectDetailExecutors> ProjectDetailExecutors { get; set; }
        public DbSet<Professions> Professions { get; set; }
        public DbSet<ProfessionsCases> ProfessionsCases { get; set; }
        public DbSet<PaintingWorks> PaintingWorks { get; set; }
        public DbSet<PaintingWorksJournal> PaintingWorksJournal { get; set; }

        //R
        public DbSet<ReceiptCertificates> ReceiptCertificates { get; set; }
        public DbSet<ReceiptCertificateDetail> ReceiptCertificateDetail { get; set; }
        public DbSet<RECEIPTS> Receipts { get; set; }
        public DbSet<ReceiptDetails> ReceiptDetails { get; set; }
        public DbSet<ReceiptOrders> ReceiptOrders { get; set; }
        public DbSet<ReceiptJournal> ReceiptJournal { get; set; }
        public DbSet<Registries> Registries { get; set; }
        public DbSet<LastIdReceiptGen> LastIdReceiptGen { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<RemainsNomenclature> RemainsNomenclature { get; set; }
        public DbSet<RequestLog> RequestLog { get; set; }
        public DbSet<RequestLogContractors> RequestLogContractors { get; set; }
        public DbSet<RequestLogJournal> RequestLogJournal { get; set; }
        public DbSet<Responsible> Responsible { get; set; }

        //S
        public DbSet<ShipmentLists> ShipmentLists { get; set; }
        public DbSet<Storehouses> Storehouses { get; set; }
        public DbSet<SettlementTypes> SettlementTypes { get; set; }
        public DbSet<StoreHouseTrialBalance> StoreHouseTrialBalance { get; set; }
        public DbSet<StoreHouseReceiptProject> ReceiptStoreHouseProject { get; set; }
        public DbSet<StoreHouseRemains> StoreHouseRemains { get; set; }
        public DbSet<StoreHouseInventory> StoreHouseInventory { get; set; }
        public DbSet<SearchTable> SearchTable { get; set; }

        public DbSet<SUPPLIERS> Suppliers { get; set; }
        //T
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<ToolActs> ToolActs { get; set; }
        public DbSet<ToolActMaterials> ToolActMaterials { get; set; }
        public DbSet<ToolActMaterialsJournal> ToolActMaterialsJournal { get; set; }
        public DbSet<MaterialsForToolActs> MaterialsForToolActs { get; set; }
        
        //U
        public DbSet<Users> Users { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<UserTasks> UserTasks { get; set; }
        public DbSet<UsersInfo> UsersInfo { get; set; }        
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<Units> Units { get; set; }

        //V
        public DbSet<VAT> Vat { get; set; }

        //W
        public DbSet<WeldWps> WeldWps { get; set; }
        public DbSet<WeldStamps> WeldStamps { get; set; }
        public DbSet<WeldPersonsWps> WeldPersonsWps { get; set; }
        public DbSet<WeldAttestations> WeldAttestations { get; set; }
        public DbSet<WeldAttestationPersons> WeldAttestationPersons { get; set; }
        public DbSet<WeldStampJournal> WeldStampJournal { get; set; }
        public DbSet<WeldStampJournalInfo> WeldStampJournalInfo { get; set; }
        public DbSet<WeldAttestationPersonsInfo> WeldAttestationPersonsInfo { get; set; }
        public DbSet<WeldAttestationTreeInfo> WeldAttestationTreeInfo { get; set; }
        public DbSet<WeldCertificates> WeldCertificates { get; set; }

        #endregion


        static ERP_Context()
        {
            FbConnectionStringBuilder csb;

            csb = new FbConnectionStringBuilder()
            {
                //DataSource = "localhost",
                //Database = "TVM_DB",
                //UserID = "sysdba",
                //Password = "masterkey",
                //Charset = "UTF8",
                //Pooling = true,
                //ConnectionLifeTime = 900,
                DataSource = "10.0.0.50",
                Database = "TVM_DB",
                UserID = "sysdba",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900

            };

#if DEBUG
            //csb = new FbConnectionStringBuilder()
            //{
            //    DataSource = "10.0.0.50",
            //    Database = "TVM_DB_TEST",
            //    UserID = "sysdba",
            //    Password = "masterkey",
            //    Charset = "UTF8",
            //    Pooling = true,
            //    ConnectionLifeTime = 900
            //};
            csb = new FbConnectionStringBuilder()
            {
                DataSource = "localhost",
                //Database = "TVM_DB",
                //UserID = "sysdba",
                //Password = "masterkey",
                //Charset = "UTF8",
                //Pooling = true,
                //ConnectionLifeTime = 900,
                //DataSource = "10.0.0.50",
                Database = "TVM_DB",
                UserID = "sysdba",
                Password = "masterkey",
                Charset = "UTF8",
                Pooling = true,
                ConnectionLifeTime = 900

            };

#endif

            Connection.ConnectionString = csb.ConnectionString;

            //using (var connection = new FbConnection(csb.ConnectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new InvalidOperationException("Unable to connect to the database. Please check the connection string and ensure the database server is running.", ex);
            //    }
            //}

            Database.SetInitializer<ERP_Context>(null); 
        }

        public ERP_Context(): base(new FbConnection(Connection.ConnectionString), true)
        {
 



            Configuration.LazyLoadingEnabled = false;
        }

        public bool CheckConnect()
        {
            using (var connection = new FbConnection(Connection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    //throw new InvalidOperationException("Unable to connect to the database. Please check the connection string and ensure the database server is running.", ex);
                    return false;
                }
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(15, 6));
        }
    }
}
