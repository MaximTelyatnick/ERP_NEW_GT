using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class MtsSpecificationTreeInfo
    {
        [Key]
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long RootId { get; set; }
        public int? UserId { get; set; }
        public int? DesignerId { get; set; }
        public long? AssemblyId { get; set; }
        public string Drawing { get; set; }
        public string Name { get; set; }
        public string MaterialName { get; set; }
        public string Gauge { get; set; }
        public string Note { get; set; }
        public string GostName { get; set; }
        public string UnitLocalName { get; set; }
        public string GroupName { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public short? MaterialStatus { get; set; }
        public string ProcessingName { get; set; }
        public decimal? QuantityOfBlanks { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Quantity { get; set; }
        public string UserName { get; set; }
        public long? MtsCreatedDetailId { get; set; }
        public long? MtsMaterialId { get; set; }
        public long? MtsNomenclatureId { get; set; }
        public string Description { get; set; }
        public decimal WeightForAssembly { get; set; }
        public decimal QuantityForAssembly { get; set; }
    }
}
