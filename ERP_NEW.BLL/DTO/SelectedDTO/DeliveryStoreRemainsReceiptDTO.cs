using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class DeliveryStoreRemainsReceiptDTO
    {
        public int RecId { get; set; }
        public int ReceiptId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public decimal Quantity { get; set; }
        public string Measure { get; set; }
        public decimal RemainsSum { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string DebitNum { get; set; }
        public string Name { get; set; }
        public string Nomenclature { get; set; }
        public string N1 { get; set; }
    }
}
