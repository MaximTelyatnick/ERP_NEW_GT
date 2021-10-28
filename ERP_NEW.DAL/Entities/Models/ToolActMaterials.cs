using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ToolActMaterials
    {
        [Key]
        public int Id { get; set; }
        public int ToolActId { get; set; }
        public int InvoiceRequirementId { get; set; }
        public decimal? Quantity { get; set; }
    }
}
