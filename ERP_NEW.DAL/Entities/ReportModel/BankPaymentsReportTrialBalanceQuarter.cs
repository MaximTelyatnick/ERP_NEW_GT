using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BankPaymentsReportTrialBalanceQuarter
    {
        [Key]
        public int RecId { get; set; }
        public string MonthName { get; set; }
        public string PurposeAccountNum { get; set; }
        public int BankAccountId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int? QuarterNumber { get; set; }
        public int? MonthNumber { get; set; }
        public int? YearNumber { get; set; }
        public int Pr { get; set; }
    }
}
