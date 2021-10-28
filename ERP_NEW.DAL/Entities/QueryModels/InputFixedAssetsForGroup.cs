using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class InputFixedAssetsForGroup
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public int Group_Id { get; set; }
        public string GroupName { get; set; }
        public string Num { get; set; }
        public int MonthSet { get; set; }
        public int YearSet { get; set; }
        public decimal FYearPrice { get; set; }
        public decimal LYearPrice { get; set; }
        public decimal? Difference { get; set; }
    }
}
