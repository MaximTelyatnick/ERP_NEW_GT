using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class ExpenditureByOrders
    {
        [Key]
        public int RecID { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public string Measure { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNum { get; set; }
        public string VendorName { get; set; }
        public string VendorSrn { get; set; }

        public DateTime? CertificateDate { get; set; }
        public string CertificateNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public DateTime? CustomerOrderDate { get; set; }
        public string CustomerOrderNumberGroup { get; set; }
    }
}