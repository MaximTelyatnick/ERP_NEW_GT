using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CustomerOrderPrepaymentsDTO
    {
        public int Id { get; set; }
        public int CustomerOrderId { get; set; }
        public int BankPaymentId { get; set; }
        public decimal? Prepayment { get; set; }
        public decimal? PrepaymentCurrency { get; set; }

        public decimal? PrepaymentVatPrice { get; set; }
        public DateTime? PrepaymentDate { get; set; }
        public string PrepaymentNumber { get; set; }
        public string ContractorName { get; set; }
        public string CurrencyCode { get; set; }
        public bool Selected { get; set; }
    }
}
