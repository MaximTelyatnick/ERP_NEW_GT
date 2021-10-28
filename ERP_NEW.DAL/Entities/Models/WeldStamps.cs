using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class WeldStamps
    {
        [Key]
        public int Id { get; set; }
        public string StampNumber { get; set; }
        public DateTime StampDate { get; set; }
        //public int UserId { get; set; }
        //public DateTime DateAdded { get; set; }
    }
}
