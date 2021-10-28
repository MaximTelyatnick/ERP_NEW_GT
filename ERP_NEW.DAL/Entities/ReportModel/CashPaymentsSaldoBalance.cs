using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class CashPaymentsSaldoBalance
    {
        [Key]
        public int RecId { get; set; }
        public decimal CreditStart { get; set; }
        public decimal DebitStart { get; set; }
        public decimal CreditEnd { get; set; }
        public decimal DebitEnd { get; set; }
    }
}
