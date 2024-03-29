﻿using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ReceiptCertificatesDTO
    {
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
        public bool ScanCheck { get; set; }
        public int? UserId { get; set; }
        public string UserFio { get; set; }
        public bool CertificateExpiration { get; set; }
    }
}
