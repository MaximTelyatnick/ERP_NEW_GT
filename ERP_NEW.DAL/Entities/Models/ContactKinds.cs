using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
   public class ContactKinds
    {
        [Key]
        public int Id { get; set; }
        public string KindName { get; set; }
        public int? ContactTypeId { get; set; }
    }
}
