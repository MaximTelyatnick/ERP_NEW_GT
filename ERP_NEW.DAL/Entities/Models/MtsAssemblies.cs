using System;
using System.ComponentModel.DataAnnotations;


namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsAssemblies
    {
        [Key]
        public long Id { get; set; }
        public string Drawing { get; set; }
        public string Name { get; set; }
        public int? DesignerId { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int AssemblyStatus { get; set; }
        public int? ContractorId { get; set; }
        public int? CityId { get; set; }
        public int DesignerCompanyId { get; set; }
    }
}
