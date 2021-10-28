using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class CashBookBalanceDTO
    {
        public int Id { get; set; }
        public decimal FullSaldo { get; set; }
        public decimal SumBeginDay { get; set; }
        public decimal SumEndDay { get; set; }
    }
}
