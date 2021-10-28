using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class DeliveryOrderDTO : ObjectBase
    {
        public int Id { get; set; }
        public int DeliveryId { get; set; }
        public string TTN { get; set; }
        public decimal? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public int DeliveryPriceTypeId { get; set; }
        public string DeliveryName { get; set; }
        public string ReceiptNumber { get; set; }
        public string DeliveryPaymentName { get; set; }
        public int? DeliveryOrderId { get; set; }
   
    }
}
