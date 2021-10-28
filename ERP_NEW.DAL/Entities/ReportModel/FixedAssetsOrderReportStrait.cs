using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    
    public class FixedAssetsOrderReportStrait
    {
        [Key]
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int? OperatingPersonId { get; set; }
        public string OperatingPersonName { get; set; }
        public decimal? BeginPrice { get; set; }
        public decimal? TotalPriceFull { get; set; }
        public decimal? IncreasePrice { get; set; }
        public string RegionName { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? PeriodAmortization { get; set; }
        public decimal? PeriodYearAmortization { get; set; }
        public decimal? CurrentAmortization { get; set; }
        public string FAONum { get; set; }
        public string FAMNum { get; set; }
        public DateTime? BeginDate { get; set; }             
    }
}
