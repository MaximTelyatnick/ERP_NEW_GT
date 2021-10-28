using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsPayment
    {
        [Key]
        public int ID { get; set; }
        public int BusinessTripsDetailsID { get; set; }
        public int EmployeesID { get; set; }
        public int BusinessTripsReportID { get; set; }
        public int AccountsID { get; set; }
        public decimal Payment { get; set; }
        public DateTime Payment_Date { get; set; }
        public string Comment { get; set; }
        public DateTime Doc_Date { get; set; }
        public int? BusinessTripsPaymentVatID { get; set; }
        public int? CurrencyRatesID { get; set; }
        public int? UserId { get; set; }
    }
}
