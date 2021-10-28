using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class ReceiptStoreHouses
    {
        public int RecId { get; set; }
        public string ReceiptNum { get; set; }
        public string NomenclatureName { get; set; }
        public string Nomenclature { get; set; }
        public string UnitLocalName { get; set; }
        public string DebitNum { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerOrder { get; set; }
        public decimal RemainsQuantity { get; set; }
        public decimal ReceiptQuantity { get; set; }
        public string Correction { get; set; }
    }
}
