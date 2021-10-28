using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class EmployeeCertificates
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte[] CertificateScan { get; set; }
        public string FileName { get; set; }
        public int DocumentTypeId { get; set; }
    }
}
