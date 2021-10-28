using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Periods
    {
        [Key]
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool State { get; set; }
        public bool StateBank { get; set; }
        public bool StateBusinesTrip { get; set; }
        public bool StateTaxInvoices { get; set; }
    }
}
