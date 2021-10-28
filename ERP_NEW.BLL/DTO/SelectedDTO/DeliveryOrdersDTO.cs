using System;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
   public  class DeliveryOrdersDTO
    {
       public int RecId { get; set; }
       public int ReceiptID { get; set; } 
       public string Nomenclature { get; set; }
       public string NomenclatureName { get; set; }
       public string Measure { get; set; }
       public decimal? Quantity { get; set; }
       public decimal? UnitPrice { get; set; }
       public decimal? TotalPrice { get; set; }
       public DateTime? OrderDate { get; set; }
       public string ReceiptNum { get; set; }
       public DateTime? InvoiceDate { get; set; }
       public string InvoiceNum { get; set; }
       public string VendorName { get; set; }
       public string VendorSrn { get; set; }
       public string CurrencyCode { get; set; }
       public string SupplierName { get; set; }
       public string SupplierProxy { get; set; }
       public string StorehouseName { get; set; }
       public short? TaxInvoice { get; set; }
       public short? TransportInvoice { get; set; }
       public int? CustomerOrderId { get; set; }
       public string OrderNumber { get; set; }
       public string Drawing { get; set; }
       public int OrderId { get; set; }

       public bool Selected { get; set; }
       
    }
}
