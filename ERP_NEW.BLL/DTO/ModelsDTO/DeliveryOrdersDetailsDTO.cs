using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class DeliveryOrdersDetailsDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? DeliveryOrderId { get; set; }

        public string TTN { get; set; }
        public decimal? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryPaymentName { get; set; }

        public bool Selected { get; set; }
    }
}
