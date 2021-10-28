using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class BankPaymentsSelect
    {
        [Key]
        public int Id { get; set; }
        public string ContractorSrn { get; set; }
        public string ContractorName { get; set; }
        public DateTime? BankPaymentDate { get; set; }
        public string BankPaymentNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string BankAccountNum { get; set; }
        public string PurposeAccountNum { get; set; }
        public string Purpose { get; set; }
        public decimal? PaymentPrice { get; set; }
        public decimal? PaymentPriceCurrency { get; set; }
        public decimal? PaymentPriceRemains { get; set; }
        public decimal? PaymentPriceCurrencyRemains { get; set; }
        public decimal? PaymentPriceAdded { get; set; }
        public decimal? PaymentPriceCurrencyAdded { get; set; }
        public bool Selected { get; set; }
    }
}
