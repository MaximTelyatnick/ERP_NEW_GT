using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_NEW.DAL.Entities.Models
{
   public class ContractorContactAddress
    {
        [Key]
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int? ContractorContactKindId { get; set; }
        public string Details { get; set; }

    }
}
