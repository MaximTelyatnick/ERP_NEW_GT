using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class StoreHouseRemains
    {
        [Key]
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
        

    }
}
