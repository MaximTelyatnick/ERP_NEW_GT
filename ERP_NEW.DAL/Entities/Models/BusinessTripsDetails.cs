using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsDetails
    {
        [Key]
        public int ID { get; set; }
        public int BusinessTripsID { get; set; }
        public int EmployeesID { get; set; }
    }
}
