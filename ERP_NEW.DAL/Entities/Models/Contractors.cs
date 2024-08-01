using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_NEW.DAL.Entities.Models
{
   public class Contractors
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short_Name{ get; set; }
        public string Srn { get; set; }
        public string Tin { get; set; }
        public int? OwnType { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ContractorTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
