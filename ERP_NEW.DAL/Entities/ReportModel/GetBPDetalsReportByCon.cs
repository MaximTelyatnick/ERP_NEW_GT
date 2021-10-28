using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class GetBPDetalsReportByCon
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ConId { get; set; }
        public string ContractorSrn { get; set; }
        public string PaymentDoc { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentPrice { get; set; }
        public decimal? CreditPrice { get; set; }
        public int? BankAccountId { get; set; }
        public string Purpose { get; set; }
        public decimal? VatPrice { get; set; }
        public decimal? BeginDebit { get; set; }
        public decimal? BeginCredit { get; set; }
        public decimal? EndDebit { get; set; }
        public decimal? EndCredit { get; set; }
    }
}
