using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class DetalsReportByOperationContractorsDTO
    {
        public int Id { get; set; }
        public int? RegId { get; set; }
        public string PaymentDocument { get; set; }
        public string Purpose { get; set; }
        public decimal? CreditPrice { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? VatPrice { get; set; }
        public DateTime? MonthCurrent { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal? InvTotalPrice { get; set; }
        public decimal? InvPrice { get; set; }
        public decimal? InvVat { get; set; }
        public int? BalanceAccountId { get; set; }
        public string BAName { get; set; }
        public string ContractorName { get; set; }
        public string ContractorSrn { get; set; }
        public decimal? BeginDebit { get; set; }
        public decimal? BeginCredit { get; set; }
        public decimal? EndDebit { get; set; }
        public decimal? EndCredit { get; set; }

        //public DateTime? InvoiceDate { get; set; }
        //public decimal? OrdTotalPrice { get; set; }
        //public decimal? OrdVat { get; set; }
        //public decimal? AllPrice { get; set; }
        //public string VatAccountNum { get; set; }
        //public string InvoiceNum { get; set; }
        
        
        
        
        
       



    }
}
