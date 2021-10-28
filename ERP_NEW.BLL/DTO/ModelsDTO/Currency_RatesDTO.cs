using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class Currency_RatesDTO
    {
        public int Id { get; set; }
        public int? Currency_Id { get; set; }
        public DateTime Date { get; set; }
        public decimal? CurrencyPayment { get; set; }
        public decimal? CurrencyPrice { get; set; }
        public decimal? Rate { get; set; }
        public int? Multiplicity { get; set; }
    }
}
