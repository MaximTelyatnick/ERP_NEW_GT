using System;
using System.ComponentModel.DataAnnotations;


namespace ERP_NEW.DAL.Entities.Models
{
    public class Units
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitCode{ get; set; }
        public string UnitFullName { get; set; }
        public string UnitLocalName { get; set; }
    }
}
