using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class ContractPayments
    {
        [Key]
        public int RecId { get; set; }
        public int BankPaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDocument { get; set; }
        public string VendorName { get; set; }
        public string VendorSrn { get; set; }
        public string CurrencyCode { get; set; }
        public decimal PaymentPrice { get; set; }
        public decimal PaymentPriceCurrency { get; set; }
        public string Purpose { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public int Direction { get; set; }
        public decimal? Payment { get; set; }
        public decimal? PaymentCurrency { get; set; }
        public decimal? Prepayment { get; set; }
        public decimal? PrepaymentCurrency { get; set; }
    }
}
