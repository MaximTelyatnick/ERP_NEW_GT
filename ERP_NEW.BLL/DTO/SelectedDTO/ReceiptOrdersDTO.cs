using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ReceiptOrdersDTO
    {
        public int Id { get; set; }
        public string ReceiptNum { get; set; }
        public int? VendorId { get; set; }
        public string VendorSrn { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNum { get; set; }
        public string AccountNum { get; set; }
        public string SupplierProxy { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TotalWithVat { get; set; }
        public DateTime? EnterDate { get; set; }
        public int? DebitAccountId { get; set; }
        public string DebitAccountNum { get; set; }
        public int TaxInvoice { get; set; }
        public int TransportInvoice { get; set; }
        public int? Correction { get; set; }
        public int? ColorId { get; set; }
        public int? Checked { get; set; }
        public int? Flag1 { get; set; }
        public int? Flag2 { get; set; }
        public int? Flag3 { get; set; }
        public int? Flag4 { get; set; }
        public int? Otk_Id { get; set; }
        public int? Storekeeper_Id { get; set; }
        public int? Supplier_Id { get; set; }
        public int? OtkId { get; set; }
        public int? StorekeeperId { get; set; }
        public int? SupplierId { get; set; }
        public string OtkName { get; set; }
        public string StorekeeperName { get; set; }
        public string SupplierName { get; set; }
        public int? CurrencyId { get; set; }
        public int? TotalCurrency { get; set; }
        public decimal? CurrencyRate { get; set; }
        public decimal? Vat { get; set; }
        

        public bool TaxInvoiceStatus { get; set; }
        public bool TransportInvoiceStatus { get; set; }
        public bool IsSelect { get; set; }
        public int? UserId { get; set; }
    }
}
