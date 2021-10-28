using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class InvoicesSortDTO
    {
        public int Id { get; set; }
        public string BalanceAccountName { get; set; }
        public decimal? SumPrice { get; set; }
        public decimal? SumVat { get; set; }
    }
}
