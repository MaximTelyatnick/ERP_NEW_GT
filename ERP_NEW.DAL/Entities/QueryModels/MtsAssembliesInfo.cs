using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class MtsAssembliesInfo
    {
        [Key]
        public int RecId { get; set; }
        public long AssemblyId { get; set; }
        public long SpecificationId { get; set; }
        public int? DesignerId { get; set; }
        public string Drawing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DesignerName { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public DateTime DateCreated { get; set; }

        public int? UserId { get; set; }
        public int AssemblyStatus { get; set; }

        public int? ContractorId { get; set; }
        public string ContractorName { get; set; }
        public string UserName { get; set; }
        
        public int? CityId { get; set; }
        public string CityName_UA { get; set; }
        public string CountryName_UA { get; set; }
        public short DesignerCompanyId { get; set; }

        //public int? CustomerOrderId { get; set; }
        public string CustomerOrderNumber { get; set; }
    }
}
