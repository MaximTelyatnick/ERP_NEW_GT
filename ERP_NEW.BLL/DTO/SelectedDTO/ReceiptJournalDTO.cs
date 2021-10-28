using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ReceiptJournalDTO
    {
        public int Id { get; set; }
        public string ReceiptName { get; set; }
        public int OrderId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitCurrency { get; set; }
        public decimal TotalPrice { get; set; }
        public int? TotalCurrency { get; set; }
        public int? NomenclatureId { get; set; }
        public int? Pos { get; set; }
        public int? StorehouseId { get; set; }
        public int? BalanceAccountId { get; set; }
        public string BalanceAccountNum { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public int? NomenclatureGroupId { get; set; }
        public string StorehouseName { get; set; }
        public int? UnitId { get; set; }
        public string UnitLocalName { get; set; }
        public string Measure { get; set; }
    }
}
