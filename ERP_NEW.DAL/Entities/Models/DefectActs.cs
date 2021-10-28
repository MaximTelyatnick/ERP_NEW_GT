using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class DefectActs
    {
        [Key]
        public int Id { get; set; }
        public int MtsAssemblyId { get; set; }
        public int? CustomerOrderId { get; set; }
        public string ActNumber { get; set; }
        public DateTime ActDate { get; set; }
        public string Description { get; set; }
        public byte[] ActScan { get; set; }
        public string FileName { get; set; }
        public string Details { get; set; }  
    }
}