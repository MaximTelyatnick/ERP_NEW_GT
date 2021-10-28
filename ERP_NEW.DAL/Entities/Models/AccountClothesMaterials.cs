using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AccountClothesMaterials
    {
        [Key]
        public int Id { get; set; }
        public int AccountClothesId { get; set; }
        public int InvoiceRequirementMaterialId { get; set; }
        public decimal? QuantityOutput { get; set; }
        public decimal? QuantityReturn { get; set; }
        public DateTime? DateOutput { get; set; }
        public DateTime? DateReturn { get; set; }
        public int? PercentageOutput { get; set; }
        public int? PercentageReturn { get; set; }
    }
}
