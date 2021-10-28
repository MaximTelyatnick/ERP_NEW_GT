using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ExpenditureTotalPriceDTO
    {
        public int Id { get; set; }
        public DateTime? CustomerOrderDate { get; set; }
        public decimal? ExpendituresTotalPrice { get; set; }
        public decimal? CustomerOrderPrice { get; set; }
        public decimal? CustomerOrderCurrencyPrice { get; set; }
        public string CurrencyCode { get; set; }
    }
}
