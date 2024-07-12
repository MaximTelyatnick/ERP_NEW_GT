using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.ReportsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Entities.ReportModel;
using ERP_NEW.BLL.DTO;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IReportService
    {
        bool GetBSTReportByAccounts(DateTime startDate, DateTime endDate);
        bool GetBSTReportCurrencyPeriod(DateTime startDate, DateTime endDate);
        bool GetBSTReportDocumentsPeriod(DateTime startDate, DateTime endDate);
        bool GetBSTReportEmployeesByPeriod(DateTime startDate, DateTime endDate);
        bool GetBSTReportByDepartments(DateTime startDate, DateTime endDate);
        bool GetBSTReportPaymentsByAccountId(DateTime startDate, DateTime endDate, int accountId, string accountNum);
        bool GetBSTReportPrepaymentsSumByAccount313(DateTime startDate, DateTime endDate);
        bool GetBSTReportPrepaymentsSumByAccountShort(DateTime startDate, DateTime endDate, short accountId, string accountNumber);

        bool GetBSTReportPaymentsByVatAccountId(DateTime startDate, DateTime endDate, int accountId, string accountNum);
        bool GetBSTReportPrepaymentsByAccountId(DateTime startDate, DateTime endDate, int accountId, string accountNum);
        bool GetBSTReportPaymentsByPeriod(DateTime startDate, DateTime endDate);
        IEnumerable<BusinessTripsPaymentStatementDTO> GetBSTPaymentStatement(DateTime startDate, DateTime endDate);
        bool PrintBSTPaymentStatement(List<BusinessTripsPaymentStatementDTO> source, DateTime start, DateTime end);


        bool GetCPReportByAccounts(DateTime startDate, DateTime endDate);
        
        bool GetCWBReport(DateTime startDate, DateTime endDate, int accountId, string accountNum);
        bool GetCWBShortReport(DateTime startDate, DateTime endDate, int accountId, string accountNum);

        bool GetBPReportTrialBalance(DateTime startDate, DateTime endDate, int accountId, string accountNum, string bankName);
        bool GetBPReportForCustomBill(DateTime startDate, DateTime endDate, int accountId, string accountNum);
        bool GetBPReportTrialBalanceQuarter(DateTime startDate, DateTime endDate, int accountId, string accountNum, string bankName);
        bool GetBPReportTrialBalanceFull(DateTime startDate, DateTime endDate);
        void GetExportPaymentsList(List<BankPaymentsInfoDTO> dataSource, DateTime startDate, DateTime endDate);

        bool GetContractorVat(DateTime startDate, DateTime endDate);
        bool GetMSPaymentsWithoutVat(DateTime startDate, DateTime endDate, string pflag3, string pflag4, string accountNum);
        bool GetMSTrialBalanceCurrency(DateTime startDate, DateTime endDate, string accountNum);
        bool GetMSTrialBalanceCurrency681(DateTime startDate, DateTime endDate, string accountNum);
        bool GetMSTrialBalance(DateTime startDate, DateTime endDate, string Flag1, string Flag3, string Flag4, string PFlag3, string PFlag4, string accountNum);
        bool GetMSTrialBalanceByAccountsCurrency(DateTime startDate, DateTime endDate, string accountNum);
        bool GetMSTrialBalanceByAccountsCurrency681(DateTime startDate, DateTime endDate, string accountNum);
        //bool GetMSTrialBalanceByAccounts39(DateTime startDate, DateTime endDate, string accountNum);
        //bool GetMSTrialBalanceByAccounts(DateTime startDate, DateTime endDate, string Flag1, string Flag3, string Flag4, string PFlag3, string PFlag4, string accountNum);
        bool GetMSReconciliation(DateTime startDate, DateTime endDate, int contractorId, string PFlag3, string PFlag4, string accountNum, string contractorName, string contractorSrnCode);
        bool GetMSReconsiliation681_36(DateTime startDate, DateTime endDate, int contractorId, int accountId, string accountNum, string contractorName, string contractorSrnCode);
        List<BankPaymentsReportTrialBalanceAll313DTO> GetBPReportTrialBalanceShort(DateTime startDate, DateTime endDate, int accountId);
        bool PrintBPReportTrialBalanceShortAllAccount313(List<BankPaymentsReportTrialBalanceAll313DTO> dataSource, DateTime startDate, DateTime endDate);

        bool PrintMSReconciliation362_681(IEnumerable<BankPaymentsInfoDTO> bp, IEnumerable<CalcWithBuyersInfoDTO> calcWithBuyers, IEnumerable<CalcWithBuyersShortReportDTO> calcWithBuyersSaldo, DateTime startDate, DateTime endDate);
        List<BusinessTripsOrderCustDTO> GetBusinessOrderCustByBTId(int id);

        void PrintBusinessTrip(BusinessTripsJournalDTO source);
        void PrintBusinessTripDecree(List<BusinessTripsJournalDTO> source);
        void PrintBusinessTripDecreeCancel(List<BusinessTripsJournalDTO> source);
        void PrintBusinessTripDecreeProlong(List<BusinessTripsJournalDTO> source);


        


        void PrintCustomerOrderInfo(CustomerOrdersDTO curRecord);

        void PrintAccountClothesCard(AccountClothesInfoDTO model, List<AccountClothesMaterialsDTO> source);

        void PrintAccountClothesJournalCard(List<AccountClothesJournalDTO> source, DateTime startDate, DateTime endDate);

        void PrintAccountClothesJournalWriteOff(List<AccountClothesJournalDTO> source, DateTime startDate, DateTime endDate);

        void PrintToolMaterialsJournalWriteOff(List<ToolActMaterialsJournalDTO> source, DateTime startDate, DateTime endDate);

        void InvoiceRequirement(List<InvoiceRequirementMaterialsInfoDTO> source, string number, string date, string responsiblePerson);
        void InvoicesForFixedAssets(List<InvoicesFixedAssetsInfoDTO> SourseDataTable, string startDate, string endDate);
        //bool ExpendituresForProject(List<ExpendituresStoreHousesDTO> source, DateTime startDate, DateTime endDate);

        //bool InvoiceForProject(List<InvoiceRequirementMaterialsInfoDTO> source, InvoiceRequirementOrdersDTO invoiceOrderDTO, DateTime startDate, DateTime endDate);

        void PrintCashBookCreditAct(CashBookPageDTO cashBookPageDTO, CashBookRecordJournalDTO cashBookRecordJournalDTO);
        void PrintCashBookDebitAct(CashBookPageDTO cashBookPageDTO, CashBookRecordJournalDTO cashBookRecordJournalDTO);
        void PrintCashBookPage(CashBookPageDTO cashBookPageDTO, List<CashBookRecordJournalDTO> source, CashBookBalanceDTO cashBookBalanceDTO);
        bool GetCashBookJournalRegistrationByPeriod(DateTime startDate, DateTime endDate, decimal saldo);
        bool PrintCashBookJournalRegistrationByPeriod(List<CashBookRecordJournalByYearDTO> cashBookRecordJournalByYear, DateTime startDate, DateTime endDate, decimal saldo);
        void PrintCashBookTittle(List<CashBookPageDTO> cashBookPaheList);

        void PrintTimeSheet(List<EmployeesInfoDTO> list, DateTime dateTime);

        void PrintAccountingInvoices(List<InvoicesDTO> sourceList, int? month = null);

         List<PaymentDTO> GetPayments(DateTime startDate, DateTime endDate);

        IEnumerable<BeginCreditDTO> GetBeginCredit(DateTime date);

        List<ReportInvoiceDTO> GetInvoicesDuplicates(InvoicesDTO invoice);

        void GetPaymentsReport(List<ReportInvoiceDTO> invoices, List<PaymentDTO> payments, IEnumerable<BeginCreditDTO> beginCredit);

        bool GetExpenditureForProjectByPeriod(DateTime startDate, DateTime endDate);

        bool GetExpenditureByContractorByPeriod(DateTime startDate, DateTime endDate);
        bool ExpendituresForProject(List<ExpedinturesAccountantDTO> source, DateTime startDate, DateTime endDate);
        bool ExpendituresForProject(List<ExpenditureInfoDTO> source);
        bool ExpendituresForProjectWithTotalPrice(List<ExpedinturesAccountantDTO> source, DateTime startDate, DateTime endDate, bool materialPrint);

        bool GetStoreHouseInventoryReport(DateTime endDate);
        bool PrintStoreHouseInventory(List<StoreHouseInventoryDTO> reportList, string reportDate);

        bool GetTrialBalanceReport(DateTime startDate, DateTime endDate);
        bool PrintStoreHouseTrialBalance(List<StoreHouseTrialBalanceDTO> reportList, string StartDate, string EndDate);

        bool GetTrialBalanceByAccountsReport(DateTime startDate, DateTime endDate);
        bool PrintTrialBalanceAccounts(List<TrialBalanceByAccountsReportDTO> reportList, string StartDate, string EndDate);

        void PrintFixedAssetsOder(FixedAssetsOrderJournalDTO model, List<FixedAssetsMaterialsDTO> materialsListSource, DateTime endDate, DateTime startDate);
        void PrintFixedAssetsOderNew(FixedAssetsOrderJournalDTO model, List<FixedAssetsMaterialsDTO> materialsListSource, DateTime endDate, DateTime firstDay);
        void PrintInventoryCardForSoftware(FixedAssetsOrderJournalDTO model);
        void PrintFixedAssetsOrderAct(FixedAssetsOrderJournalDTO model, List<FixedAssetsMaterialsDTO> materialsListSource);
        void PrintFixedAssetsOrderActWriteOff(FixedAssetsOrderJournalDTO model, List<FixedAssetsMaterialsDTO> materialsListSource, int monthSource, int yearSource);

        void PrintFixedAssetsOrderExpenditureAct(FixedAssetsOrderArchiveJournalDTO model, FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistration = null);
        void PrintFixedAssetsOrderActForSoftware(FixedAssetsOrderJournalDTO model);
        void FixedAssetsDecreeInput(FixedAssetsOrderRegJournalDTO model, List<FixedAssetsMaterialsDTO> modelMaterials);
        void FixedAssetsDecreeAddedPrice(FixedAssetsOrderRegJournalDTO model, FixedAssetsMaterialsDTO modelMaterials);
        void PrintFixedAssetsOrderActForSaleSoftWare(FixedAssetsOrderRegJournalDTO model);
        void PrintFixedAssetsDecreeSold(FixedAssetsOrderRegJournalDTO model);
        void PrintFixedAssetsDecreeExpenditure(FixedAssetsOrderRegJournalDTO model);
        void PrintAllJournalFixedAssetsOder(List<FixedAssetsOrderRegJournalDTO> modelList, DateTime beginDate, DateTime endDate);
        void FixedAssetsReportStrait(List<FixedAssetsOrderReportStraitDTO> model, DateTime startDate, DateTime endDate, Boolean Zero);
        void FixedAssetsReportGroupShort(List<FixedAssetsOrderByGroupShortReportDTO> model, DateTime startDate, DateTime endDate);
        void FixedAssetsRegisterCh1(List<FixedAssetsReportRegisterCh1DTO> model, DateTime startDate, DateTime endDate);
        void FixedAssetsRegisterCh2(List<FixedAssetsReportRegisterCh2DTO> model, DateTime startDate, DateTime endDate);
        void InputFixedAssetsForGroup(List<InputFixedAssetsForGroupDTO> model, DateTime startDate, DateTime endDate);
        void InputFixedAssetsForQuarterReport(List<InputFixedAssetsForQuarterDTO> model, string reportYear);
        void InventoryFixedAssetsForGroups(List<FixedAssetsOrderReportStraitDTO> model, DateTime endDate);
        void InventoryForFixedAssets(List<FixedAssetsOrderReportStraitDTO> model, DateTime endDate);

        bool GetOperationActByPeriod(DateTime startDate, DateTime endDate, IEnumerable<InvoicesDTO> invoicesData);
        //bool PrintOperationActByPeriod(IEnumerable<Bank_PaymentsDTO> bankPaymantData, IEnumerable<InvoicesDTO> invoicesData, IEnumerable<OrdersDTO> ordersData);
        //bool PrintOperationActByPeriod(IEnumerable<Bank_PaymentsDTO> bankPaymantData, IEnumerable<InvoicesDTO> invoicesData, IEnumerable<AccountOrdersDTO> ordersData);
        bool PrintOperationActByPeriod(IEnumerable<Bank_PaymentsDTO> bankPaymantData, IEnumerable<InvoicesDTO> invoicesData, IEnumerable<AccountOrdersDTO> ordersData, List<DateTime> monthFromPeriod);

        bool GetDetalsReportByOperationContractors(DateTime StartDateSaldo, int FLAF1, int FLAG3, int FLAG4, int PFLAG3, int PFLAG4,
            DateTime EndDateSaldo, int ContractorId, DateTime BeginDatePayment, DateTime EndDatePayment);

        bool PrintDetalsByOperationContractor(List<DetalsReportByOperationContractorsDTO> reportList,List<OrderForDetalsContractorDTO> reportListOrd, string StartDate, string EndDate);
        bool PrintDetalsBPByOperationContractor(List<GetBPDetalsReportByConDTO> reportBankPay, List<OrderForDetalsContractorDTO> reportListOrd,string StartDate, string EndDate);

        bool PrintRequstLog(List<RequestLogJournalDTO> dataSource, string path);
        IEnumerable<CalcWithBuyersShortReportDTO> GetCWBShortForSaldo(DateTime startDate, DateTime endDate, int accountId, string accountNum);

        bool MapTechProcess(MTSSpecificationssDTO mtsSpecification, List<MTSDetailsDTO> mtsDetailsList, bool sortByDrawing, int quantity = 1);
        bool PrintMapRouteTechProcess(MTSSpecificationssDTO mtsSpecification, List<MTSDetailsDTO> dataSource);
        bool SpecificationProcess(MTSSpecificationssDTO mtsSpecification, List<MTSDetailsDTO> mtsDetailsList, List<MTSPurchasedProductsDTO> mtsBuyDetailsList, List<MTSMaterialsDTO> mtsMaterialsList);

        void CreatePackingListTemplate(PackingListsJournalDTO source);

        //  bool GetMSTrialBalanceByAccounts(DateTime startDate, DateTime endDate, string PFlag1, string Flag3, string Flag4, string PFlag3, string PFlag4);
        void GetMSTrialBalanceByAccounts(DateTime startDate, DateTime endDate, string PFlag1, string Flag3, string Flag4, string PFlag3, string PFlag4, bool report531=false);
        void GetCashBookTrialBalanceByAccounts(DateTime startDate, DateTime endDate);

     //   bool PrintMSTrialBalanceByAccounts(IEnumerable<MSTrialBalanceByAccountsDTO> model, DateTime startDate, DateTime endDate);
        IEnumerable<MSTrialBalanceByAccountsDTO> GetCreditDebit63ForChess(DateTime startDate, DateTime endDate, string PFlag1, string Flag3, string Flag4, string PFlag3, string PFlag4);
        bool PrintChessAccount(List<AccountsDTO> accountModel, DateTime beginData, DateTime endDate, List<FixedAssetsReportRegisterCh1DTO> faGroupShort103,
        List<InvoicesDTO> invoiceSortList, List<CalcWithBuyersInfoDTO> calcWithBayersInfoList36_1);
        IEnumerable<CalcWithBuyersReportDTO> GetCWB(DateTime startDate, DateTime endDate, int accountId);
        IEnumerable<MsTrialBalanceByAccountsCurrencyDTO> GetMSTrialBalanceByAccounts632_ForChess(DateTime startDate, DateTime endDate);
        IEnumerable<MSTrialBalanceByAccountsDTO> GetMSTrialBalanceByAccounts631_ForChess(DateTime startDate, DateTime endDate);
        IEnumerable<MsTrialBalanceByAccountsCurrencyDTO> GetMSTrialBalanceByAccounts681_ForChess(DateTime startDate, DateTime endDate);
        IEnumerable<ContractorVatDTO> GetContractorVatForChess(DateTime startDate, DateTime endDate);
        IEnumerable<CashPaymentsPeriodBalanceDTO> GetEconomicsNeeds_ForChess(DateTime startDate, DateTime endDate);
        IEnumerable<GetOSVkvartal_ForChessDTO> GetOSVkvartal_ForChess(DateTime startDate, DateTime endDate, int accountId);

        bool GetMSDebitCredit(DateTime startDate, DateTime endDate, string flag1, string flag3, string flag4, string pflag3, string pflag4);
        bool PrintMSDebitCredit(List<MsDebitCreditDTO> reportTable, DateTime EndDate);
        void Dispose();



    }
}
