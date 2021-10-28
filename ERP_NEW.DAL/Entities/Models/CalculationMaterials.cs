using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CalculationMaterials
    {
        [Key]
        public int Id { get; set; }
        public int CalcId { get; set; }
        public int ExpAccId { get; set; }
        public String MaterialType { get; set; }
    }
}
