using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class StoreHouseRemainsDTO
    {
        public int ReceiptId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public decimal RemainsQuantity { get; set; }
        public string UnitLocalName { get; set; }
        public decimal RemainsSum { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string DebitNum { get; set; }
        public string Name { get; set; }
        public string Nomenclatures { get; set; }
        public bool Selected { get; set; }
        
    }
}
