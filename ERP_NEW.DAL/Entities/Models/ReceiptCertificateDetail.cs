using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ReceiptCertificateDetail
    {
        [Key]
        public long ReceiptCertificateDetailId { get; set; }
        public long? ReceiptCertificateId { get; set; }
        public int? ReceiptId { get; set; }
    }
}
