using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class CashPaymentsPeriodBalance
    {
        [Key]
        public int RecId { get; set; }
        public decimal PeriodPayment { get; set; }
        public int PeriodAccountId { get; set; }
        public string PeriodAccountNum { get; set; }
        public int FlagDebitCredit { get; set; }
    }
}
