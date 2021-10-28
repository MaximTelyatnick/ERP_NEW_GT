using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BankPaymentsReportTrialBalanceFull
    {
        [Key]
        public int RecId { get; set; }
        public int Bank_Account_Id { get; set; }
        public int Purpose_Account_Id { get; set; }
        public string BankNum { get; set; }
        public string PurposeNum { get; set; }
        public decimal DebitFromPeriod { get; set; }
        public decimal CreditFromPeriod { get; set; }
        public int AccountingOperationId { get; set; }
    }
}
