using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BusinessTripsPaymentStatement
    {
        [Key]
        public int RecID { get; set; }
        public int EmployeesID { get; set; }
        public decimal DebitStart { get; set; }
        public decimal CreditStart { get; set; }
        public decimal DebitEnd { get; set; }
        public decimal CreditEnd { get; set; }
        public string Fio { get; set; }
        public string IdentNumber { get; set; }
        public string AccountNumber { get; set; }
    }
}
