using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsNomenclatures
    {
        [Key]
        public long Id { get; set; }
        public long MtsGostId { get; set; }
        public int UnitId { get; set; }
        public int MtsNomenclatureGroupId { get; set; }
        public string Name { get; set; }
        public string Gauge { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }
        public string Note { get; set; }
    }
}
