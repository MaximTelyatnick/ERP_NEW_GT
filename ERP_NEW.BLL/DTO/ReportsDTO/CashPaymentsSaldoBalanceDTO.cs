using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class CashPaymentsSaldoBalanceDTO
    {
        public int RecId { get; set; }
        public decimal CreditStart { get; set; }
        public decimal DebitStart { get; set; }
        public decimal CreditEnd { get; set; }
        public decimal DebitEnd { get; set; }
    }
}
