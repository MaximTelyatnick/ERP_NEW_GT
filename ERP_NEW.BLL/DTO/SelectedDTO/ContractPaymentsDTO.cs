using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ContractPaymentsDTO
    {
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
