using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CalcWithBuyersPaymentVat
    {
        [Key]        
        public int Id { get; set; }
        public int CalcWithBuyerSpecId { get; set; }
        public decimal? VatPayment643 { get; set; }
        public decimal? VatPayment6412 { get; set; }
    }
}
