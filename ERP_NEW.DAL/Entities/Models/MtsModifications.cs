using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsModifications
    {
        [Key]
        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int ResponsiblePersonId { get; set; }
    }
}
