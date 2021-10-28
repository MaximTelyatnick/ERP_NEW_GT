using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsPrepayment
    {
        [Key]
        public int ID { get; set; }
        public int BusinessTripsDetailsID { get; set; }
        public int EmployeesID { get; set; }
        public decimal Prepayment { get; set; }
        public int? AccountsID { get; set; }
        public DateTime Prepayment_Date { get; set; }
        public int? UserId { get; set; }
        public DateTime Doc_Date { get; set; }

        public bool? Check { get; set; }
    }
}
