using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class FixedAssetsMaterials
    {
        public int Id { get; set; }
        public int? FixedAssetsOrder_Id { get; set; }//??? ==0
        public int? Expenditures_Id { get; set; }
        public int? Fixed_Account_Id { get; set; }
        public int? Flag { get; set; }
        public decimal FixedPrice { get; set; }
        public DateTime? MaterialsDate { get; set; }
        public string Description { get; set; }
        public decimal? SoldPrice { get; set; }
    }
}
