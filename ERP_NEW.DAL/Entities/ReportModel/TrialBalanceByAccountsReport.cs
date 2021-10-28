using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class TrialBalanceByAccountsReport
    {
        [Key]
        public int RecId { get; set; }
        public short? BalanceAccountId { get; set; }
        public string BalanceAccountNum { get; set; }
        public decimal BeginRemains { get; set; }
        public decimal EndRemains { get; set; }
        public int? PeriodAccountId { get; set; }
        public string PeriodAccountNum { get; set; }
        public decimal PeriodPrice { get; set; }
        public int FlagDebitCredit { get; set; }
    }
}
