using System;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class OrdersInfoDTO
    {
        public int ReceiptId { get; set; }
        public decimal? Quantity { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public string Measure { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNum { get; set; }
        public string SupplierName { get; set; }
        public string VendorName { get; set; }
        public string VendorSrn { get; set; }
        public string OtkName { get; set; }
        public string StorekeeperName { get; set; }
        public string StorehouseName { get; set; }
        public long? ReceiptCertificateId { get; set; }
        public DateTime? CertificateDate { get; set; }
        public string CertificateNumber { get; set; }
        public short ScanPersence { get; set; }
        public string FileName { get; set; }
        public string ManufacturerInfo { get; set; }
        public string Description { get; set; }

        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string ColorName { get; set; }
        public int? ReceiptCertificateDetailId { get; set; }
    }
}
