using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CustomerOrdersForCWBDTO
    {
        public int Id { get; set; }
        public int CustomerOrderId { get; set; }
        public int CalcWithBuyerId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public DateTime? CustomerOrderDate { get; set; }
    }
}
