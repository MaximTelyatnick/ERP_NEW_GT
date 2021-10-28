using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ReceiptHistoryOrdersDTO
    {
        public int? VendorId { get; set; }

        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public string UnitLocalName { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public string StoreHouseName { get; set; }
        public string VendorName { get; set; }//поставщик
        public DateTime? OrderDate { get; set; }
       
        
        
       

    }
}
