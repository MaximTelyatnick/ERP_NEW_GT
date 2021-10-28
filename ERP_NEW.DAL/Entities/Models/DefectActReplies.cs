using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class DefectActReplies
    {
        [Key]
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public int DocumentTypeId { get; set; }
        public string Description { get; set; }
        public byte[] DocumentScan { get; set; }
        public string FileName { get; set; }
        public string Details { get; set; }
        public int DefectActId { get; set; }
    }
}
