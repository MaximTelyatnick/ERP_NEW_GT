using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsDocuments
    {
        [Key]
        public int Id { get; set; }
        public long MtsSpecificationId { get; set; }
        public char[] DocumentScan { get; set; }
        public string FileName { get; set; }
    }
}
