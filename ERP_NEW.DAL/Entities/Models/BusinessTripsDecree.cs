using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsDecree
    {
        [Key]
        public int ID { get; set; }
        public int? ParentId { get; set; }
        public String Number { get; set; }
        public DateTime DecreeDate { get; set; }
        public int DecreeType { get; set; }
    }
}
