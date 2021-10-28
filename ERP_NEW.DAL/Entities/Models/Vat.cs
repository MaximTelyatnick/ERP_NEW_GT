using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class VAT
    {
        [Key]
        public int ID { get; set; }
        public decimal? PRICE { get; set; }
        public int? ACCOUNT_ID { get; set; }
    }
}
