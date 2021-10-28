using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class CashPaymentsReportByAccountsDTO
    {
        public int RecID { get; set; }
        public int EmployeesId { get; set; }
        public int CashPrepaymentId { get; set; }
        public decimal DebitStart { get; set; }
        public decimal CreditStart { get; set; }
        public decimal DebitEnd { get; set; }
        public decimal CreditEnd { get; set; }
        public string Fio { get; set; }
        public int PrepaymentAccountId { get; set; }
        public string PrepaymentAccountNum { get; set; }
        public decimal? PrepaymentPrice { get; set; }
        public DateTime? PrepaymentDate { get; set; }
        public decimal? PaymentPrice { get; set; }
        public int PaymentAccountId { get; set; }
        public string PaymentAccountNum { get; set; }
        public decimal? VatPrice { get; set; }
        public int VatAccountId { get; set; }
        public string VatAccountNum { get; set; }
    }
}
