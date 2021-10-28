using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class CashPaymentsPeriodBalanceDTO
    {
        public int RecId { get; set; }
        public decimal PeriodPayment { get; set; }
        public int PeriodAccountId { get; set; }
        public string PeriodAccountNum { get; set; }
        public int FlagDebitCredit { get; set; }
    }
}
