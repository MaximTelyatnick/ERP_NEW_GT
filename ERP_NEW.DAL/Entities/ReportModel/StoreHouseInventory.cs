using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class StoreHouseInventory
    {
        [Key]
        public int RecId { get; set; }
        public string BalanceNum { get; set; }
        public string Nomenclature { get; set; }
        public string Name { get; set; }
        public decimal RemainsQuantity { get; set; }
        public decimal RemainsSum { get; set; }
    }
}
