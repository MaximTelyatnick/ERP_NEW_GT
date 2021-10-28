using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CalcWithBuyersSpecDTO : ObjectBase
    {
        public int Id { get; set; }
        public int CalcWithBuyerId { get; set; }
        public decimal? PaymentPrice { get; set; }
        public decimal? Quantity { get; set; }
        public int? CustomerOrderSpecId { get; set; }
        public string Details { get; set; }
        public decimal? PaymentPriceCurrency { get; set; }
        public int? CpvId { get; set; }
        public int? DkppId { get; set; }
        public int? UktvId { get; set; }
        public int UserId { get; set; }

        public decimal? TotalPrice { get; set; }
        public string CpvCode { get; set; }
        public string DkppCode { get; set; }
        public string UktvCode { get; set; }
        public string SpecificationName { get; set; }
        public decimal? VatPayment643 { get; set; }
        public decimal? VatPayment6412 { get; set; }
        public decimal? VatSum { get; set; }
        public int? CalcWithBuyersPaymentVatId { get; set; }
        public bool Selected { get; set; }
        public string CustomerOrderNumber { get; set; }
        public int? CustomerOrderId { get; set; }
    }
}
