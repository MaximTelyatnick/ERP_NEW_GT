using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class ExpenditureTotalPrice
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CustomerOrderDate { get; set; }
        public decimal? ExpendituresTotalPrice { get; set; }
        public decimal? CustomerOrderPrice { get; set; }
        public decimal? CustomerOrderCurrencyPrice { get; set; }
        public string CurrencyCode { get; set; }
    }
}
