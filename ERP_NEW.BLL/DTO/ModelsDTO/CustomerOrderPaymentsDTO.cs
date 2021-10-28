using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CustomerOrderPaymentsDTO
    {
        public int Id { get; set; }
        public int CustomerOrderId { get; set; }
        public int BankPaymentId { get; set; }
        public decimal? Payment { get; set; }
        public decimal? PaymentCurrency { get; set; }

        public decimal? PaymentVatPrice { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentNumber { get; set; }
        public string ContractorName { get; set; }
        public string CurrencyCode { get; set; }
        public bool Selected { get; set; }
    }
}
