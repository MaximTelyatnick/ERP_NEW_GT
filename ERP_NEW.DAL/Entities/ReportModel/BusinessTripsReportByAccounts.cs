using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BusinessTripsReportByAccounts
    {
        [Key]
        public int RecID { get; set; }
        public int EmployeesID { get; set; }
        public decimal DebitStart { get; set; }
        public decimal CreditStart { get; set; }
        public decimal DebitEnd { get; set; }
        public decimal CreditEnd { get; set; }
        public string Fio { get; set; }
        public int AccountID { get; set; }
        public string AccNum { get; set; }
        public decimal? Payment { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? VatPayment { get; set; }
        public int VatAccountID { get; set; }
        public DateTime? StartTripDate { get; set; }
        public DateTime? EndTripDate { get; set; }
        public string VatNum { get; set; }
        public int FlagDebitCredit { get; set; }
        
    }
}
