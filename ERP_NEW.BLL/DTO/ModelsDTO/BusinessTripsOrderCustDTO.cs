using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsOrderCustDTO
    {
        public int ID { get; set; }
        public int? UserId { get; set; }
        public int CustomerOrderId { get; set; }
        public int BusinessTripsId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ContractorName { get; set; }
        public bool Selected { get; set; }
    }
}
