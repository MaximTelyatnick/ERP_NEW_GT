using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsNomenclatureGroups
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? MtsAdditCalculationId { get; set; }
        public string Name { get; set; }
        public decimal? RatioOfWaste { get; set; }
        public short? AdditCalculationActive { get; set; }
    }
}
