using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IBusinessTripsService
    {

        IEnumerable<ColorsDTO> GetColors();
        IEnumerable<BusinessTripsDTO> GetBusinessTrips();
        IEnumerable<BusinessTripsDTO> GetBusinessTripsForEmployee(int employeeId);
        IEnumerable<BusinessTripsDecreeDTO> GetBusinessTripsDecrees();
        IEnumerable<BusinessTripsPurposeDTO> GetBusinessTripsPurpose();
        IEnumerable<BusinessTripsJournalDTO> GetBusinessTripsJournal(DateTime beginDate, DateTime endDate);
        IEnumerable<BusinessTripsDecreeDTO> GetBusinessTripsDecreeByPeriod(DateTime beginDate, DateTime endDate);
        IEnumerable<BusinessTripsJournalDTO> GetBusinessTripsByDecree(int decreeId);
        IEnumerable<BusinessTripsJournalDTO> GetBusinessTripsWithoutDecree();
        IEnumerable<BusinessTripsPrepaymentJournalDTO> GetBusinessTripsPrepaymentJournalByPeriod(DateTime beginDate, DateTime endDate);
        IEnumerable<BusinessTripsPrepaymentDTO> GetBusinessTripsPrepaymentList(int btdId);
        IEnumerable<BusinessTripsPaymentDTO> GetBusinessTripsPaymentList(int btdId);
        IEnumerable<BusinessTripsReportDTO> GetBusinessTripsReports();
        IEnumerable<BusinessTripsPaymentVatDTO> GetBusinessTripsPaymentVat();
        BusinessTripsPrepaymentDTO GetBusinessTripsPrepaymentGetId(int id);
        IEnumerable<CashPrepaymentsInfoDTO> GetCashPrepaymentsByPeriod(DateTime beginDate, DateTime endDate);
        IEnumerable<CashPaymentsInfoDTO> GetCashPaymentsById(int id);
        IEnumerable<CashPaymentsInfoDTO> GetReceiptsForCashPayment(DateTime firstDateEdit, DateTime lastDateEdit);
        IEnumerable<BusinessTripsOrderCustDTO> GetBusinessOrderCustByBTId(int id);
        BusinessTripsDetailsDTO GetBusinessTripsDetailsId(int id);
        BusinessTripsDetailsDTO GetBusinessTripsDetailById(int id);
        BusinessTripsPurposeDTO GetBusinessTripsPurposeId(int id);
        BusinessTripsDTO GetBusinessTripsId(int id);
        BusinessTripsDTO GetBusinessTripsByDetailId(int id);

        string GetLatestDocNumber();
        string GetLatestDecreeNumber();

        int BusinessTripCreate(BusinessTripsDTO businessTripsDTO);
        void BusinessTripUpdate(BusinessTripsDTO businessTripsDTO);
        bool BusinessTripDelete(int id);

        int BusinessTripDecreeCreate(BusinessTripsDecreeDTO btdDTO);
        void BusinessTripDecreeUpdate(BusinessTripsDecreeDTO btdDTO);
        bool BusinessTripDecreeDelete(int id);

        int BusinessTripDecreeDetailCreate(BusinessTripsDecreeDetailsDTO btddDTO);
        void BusinessTripDecreeDetailCreateRange(List<BusinessTripsDecreeDetailsDTO> source);
        void BusinessTripDecreeDetailUpdate(BusinessTripsDecreeDetailsDTO btddDTO);
        bool BusinessTripDecreeDetailRemoveRange(List<BusinessTripsDecreeDetailsDTO> source);

        int BusinessTripsDetailsCreate(BusinessTripsDetailsDTO businessTripsDetailsDTO);
        void BusinessTripsDetailsUpdate(BusinessTripsDetailsDTO businessTripsDetailsDTO);
        bool BusinessTripsDetailsDelete(int id);

        int BusinessTripsPurposeCreate(BusinessTripsPurposeDTO businessTripsPurposeDTO);
        void BusinessTripsPurposeUpdate(BusinessTripsPurposeDTO businessTripsPurposeDTO);
        bool BusinessTripsPurposeDelete(int id);

        int BusinessTripsPrepaymentCreate(BusinessTripsPrepaymentDTO businessTripsPrepaymentDTO);
        void BusinessTripsPrepaymentCreateRange(List<BusinessTripsPrepaymentDTO> source);
        void BusinessTripsPrepaymentUpdate(BusinessTripsPrepaymentDTO businessTripsPrepaymentDTO);
        bool BusinessTripsPrepaymentDelete(int id);
        bool BusinessTripPrepaymentRemoveRange(List<BusinessTripsPrepaymentDTO> source);

        int BusinessTripsPaymentCreate(BusinessTripsPaymentDTO businessTripsPaymentDTO);
        void BusinessTripsPaymentCreateRange(List<BusinessTripsPaymentDTO> source);
        void BusinessTripsPaymentUpdate(BusinessTripsPaymentDTO businessTripsPaymentDTO);
        bool BusinessTripsPaymentDelete(int id);
        bool BusinessTripPaymentRemoveRange(List<BusinessTripsPaymentDTO> source);

        int BusinessTripsPaymentVatCreate(BusinessTripsPaymentVatDTO businessTripsPaymentVatDTO);
        void BusinessTripsPaymentVatUpdate(BusinessTripsPaymentVatDTO businessTripsPaymentVatDTO);
        bool BusinessTripsPaymentVatDelete(int id);
        
        int BusinessTripReportCreate(BusinessTripsReportDTO btdDTO);
        void BusinessTripReportUpdate(BusinessTripsReportDTO btdDTO);
        bool BusinessTripReportDelete(int id);

        int BusinessTripsOrderCustCreate(BusinessTripsOrderCustDTO businessTripsOrderCustDTO);
        void BusinessTripsOrderCustUpdate(BusinessTripsOrderCustDTO businessTripsOrderCustDTO);
        bool BusinessTripsOrderCustDelete(int id);
        bool BusinessTripsOrderCustRemoveRange(List<BusinessTripsOrderCustDTO> source);

        int CashPrepaymentCreate(CashPrepaymentsDTO cpDTO);
        void CashPrepaymentUpdate(CashPrepaymentsDTO cpDTO);
        bool CashPrepaymentDelete(int id);

        void CashPaymentCreateRange(List<CashPaymentsDTO> source);
        void CashPaymentUpdate(CashPaymentsDTO cpDTO);
        bool CashPaymentRemoveRange(List<CashPaymentsDTO> source);

        void Dispose();
    }
}
