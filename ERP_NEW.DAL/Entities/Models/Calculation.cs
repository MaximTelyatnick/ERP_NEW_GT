using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Calculation
    {
        [Key]
        public int Id { get; set; }
        public DateTime CalcDate { get; set; }
        public String CalcNumber { get; set; }
        public int? CustomerOrderId { get; set; }
    }
}
