using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CalcWithBuyersPaymentVatDTO
    {
        public int Id { get; set; }
        public int CalcWithBuyerSpecId { get; set; }
        public decimal? VatPayment643 { get; set; }
        public decimal? VatPayment6412 { get; set; }
    }
}
