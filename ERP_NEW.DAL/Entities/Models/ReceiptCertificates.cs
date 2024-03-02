using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ReceiptCertificates
    {
        [Key]
        public long ReceiptCertificateId { get; set; }
        public int? ReceiptId { get; set; }
        public DateTime CertificateDate { get; set; }
        public DateTime CertificateDateEnd { get; set; }
        public string CertificateNumber { get; set; }
        public byte[] CertificateScan { get; set; }
        public string FileName { get; set; }
        public string ManufacturerInfo { get; set; }
        public string Description { get; set; }
        public byte[] CertificateScanTwo { get; set; }
        public string FileNameTwo { get; set; }
        public int? ColorId { get; set; }
        public int? UserId { get; set; }
        public bool CertificateExpiration { get; set; }
    }
}
