using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
   public class OrderReceipFromQueryDTO
    {
        public int Id { get; set; }
        public decimal? Quantity { get; set; }
        public string ReceiptNum { get; set; }
        public string Srn { get; set; }
        public string ContractorName { get; set; }
        public string NomenclatureName { get; set; }
        public string Nomenclature { get; set; }
        public string BalansNum { get; set; }
        public string DebitNum { get; set; }
        public string UnitName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitCurrency { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TotalCurrency { get; set; }
        public decimal? CurrencyRate { get; set; }
        public int? Correction { get; set; }

        
    }
}
