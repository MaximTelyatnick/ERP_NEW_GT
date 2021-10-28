using System;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
   public class DeliveryPaymentsDTO
    {
       public int RecId { get; set; }
       public int BankPaymentId { get; set; }
       public DateTime? PaymentDate { get; set; }
       public string PaymentDocument { get; set; }
       public string VendorName { get; set; }
       public string VendorSrn { get; set; }
       public string CurrencyCode { get; set; }
       public decimal PaymentPrice { get; set; }
       public decimal PaymentPriceCurrency { get; set; }
       public string Purpose { get; set; }
       public string CustomerOrderNumber { get; set; }
       public DateTime? CustomerOrderDate { get; set; }
       public decimal CustomerOrderPrice { get; set; }
       public decimal CustomerOrderCurrencyPrice { get; set; }
    }
}
