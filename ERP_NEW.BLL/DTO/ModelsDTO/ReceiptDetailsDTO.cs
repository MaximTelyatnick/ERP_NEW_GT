using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ReceiptDetailsDTO
    {
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public int CustomerOrderId { get; set; }

        public string CustomerOrderNumber { get; set; }
        public string ContractorName { get; set; }
        public string Drawing { get; set; }

        public bool Selected { get; set; }
    }
}
