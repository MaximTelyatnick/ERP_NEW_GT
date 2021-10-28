using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsReport
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
