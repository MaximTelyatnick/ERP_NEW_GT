using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class FixedAssetsGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? AmortizationFactor { get; set; }
        public int? UsefulPeriod { get; set; }
    }
}
