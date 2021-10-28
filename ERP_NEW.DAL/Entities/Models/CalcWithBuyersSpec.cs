using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CalcWithBuyersSpec
    {
        [Key]
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
    }
}
