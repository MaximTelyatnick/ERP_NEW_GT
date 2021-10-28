using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
   public class OrderReceipFromQuery
    {
        [Key]
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

        //public int? Flag1 { get; set; }
        //public int? Flag2 { get; set; }
        //public int? Flag3 { get; set; }
        //public int? Flag4 { get; set; }



    }
}
