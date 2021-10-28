using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AccessScheduleEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EntityID { get; set; }
        public int OwnerID { get; set; }
        public int OwnerType { get; set; }
        public DateTime StartDate { get; set; }
        public int Override { get; set; }
        public int? ParentID { get; set; }
    }
}
