using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
   public class DeliveryContractorDebts
    {
        [Key]
        public int VendorId { get; set; }
        public string VendorSrn { get; set; }
        public string VendorName { get; set; }
        public decimal Price { get; set; }
        public string DebtStatus { get; set; }
    }
}
