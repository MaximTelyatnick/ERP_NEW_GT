using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class CustomerOrderPaymentsInfoDTO
    {
        public decimal CustomerOrderPrice{ get; set; }
        public decimal CustomerOrderPriceCurrency { get; set; }
        public decimal PaymentPrice { get; set; }
        public decimal PaymentPriceCurrency { get; set; }
        public decimal PrepaymentPrice { get; set; }
        public decimal PrepaymentPriceCurrency { get; set; }
        public decimal ExpenditureMaterialPrice { get; set; }
        public decimal ExpenditureMaterialPricePercent { get; set; }
    }
}
