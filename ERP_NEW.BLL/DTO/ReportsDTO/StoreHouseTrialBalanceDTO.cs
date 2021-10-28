using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class StoreHouseTrialBalanceDTO
    {
        public int RecId { get; set; }
        public string Nomenclature { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
        public decimal? RemainsQuantityBegin { get; set; }
        public decimal? RemainsPriceBegin { get; set; }
        public decimal? ReceiptTotalQuantity { get; set; }
        public decimal? ReceiptTotalPrice { get; set; }
        public decimal? ExpTotalQuantity { get; set; }
        public decimal? ExpTotalPrice { get; set; }
        public decimal RemainsQuantityEnd { get; set; }
        public decimal RemainsPriceEnd { get; set; }
        public string BalanceAccount { get; set; }
    }
}
