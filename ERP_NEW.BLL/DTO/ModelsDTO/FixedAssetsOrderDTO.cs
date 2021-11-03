using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class FixedAssetsOrderDTO : ObjectBase, ICloneable
    {
        public int Id { get; set; }
        public int Id_Parent { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public int Balance_Account_Id { get; set; }//
        public int? Supplier_Id { get; set; }
        public DateTime BeginDate { get; set; }//
        public DateTime BeginRecordDate { get; set; }//
        public DateTime? EndRecordDate { get; set; }
        public int Group_Id { get; set; }//
        public int UsefulMonth { get; set; }
        public int? Region_Id { get; set; }
        public int? OperatingPerson_Id { get; set; }
        public int? FixedCardStatus { get; set; }
        public string BalanceAccountNum { get; set; } //??
        public string SupplierName { get; set; }
        public string OperatingPersonName { get; set; }
        public decimal? BeginPrice { get; set; }
        public decimal? IncreasePrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? PeriodAmortization { get; set; }
        public decimal? PeriodYearAmortization { get; set; }
        public decimal? CurrentAmortization { get; set; }
        public string GroupName { get; set; }
        public string RegionName { get; set; }
        public int? FixedAccountId { get; set; }
        public string FixedAccountNum { get; set; }

        public string BalAccountNum { get; set; }
        public string DebitNum { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
