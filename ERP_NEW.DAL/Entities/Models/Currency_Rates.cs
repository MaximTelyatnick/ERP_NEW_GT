using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
   public class Currency_Rates
    {
        [Key]
        public int Id { get; set; }
        public int Currency_Id { get; set; }
        public DateTime Date { get; set; }
        public decimal? CurrencyPayment { get; set; }
        public decimal? CurrencyPrice { get; set; }
        public decimal? Rate { get; set; }
        public int Multiplicity { get; set; }
    }
}
