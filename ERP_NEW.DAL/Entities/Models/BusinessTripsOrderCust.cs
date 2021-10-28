using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsOrderCust
    {
        [Key]
        public int ID { get; set; }
        public int? UserId { get; set; }
        public int CustomerOrderId { get; set; }
        public int BusinessTripsId { get; set; }
    }
}
