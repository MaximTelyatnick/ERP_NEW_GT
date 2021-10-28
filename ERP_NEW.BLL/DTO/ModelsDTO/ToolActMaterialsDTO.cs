using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ToolActMaterialsDTO
    {
        [Key]
        public int Id { get; set; }
        public int? ToolActId { get; set; }
        public int? InvoiceRequirementId { get; set; }
        public decimal? Quantity { get; set; }
        
    }
}
