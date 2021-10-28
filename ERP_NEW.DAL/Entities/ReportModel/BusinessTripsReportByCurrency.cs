using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BusinessTripsReportByCurrency
    {
        [Key]
        public int RecID { get; set; }
        public int ReportId { get; set; }
        public String ReportName { get; set; }
        public decimal PaymentSum { get; set; }
        public decimal PaymentCurrencySum { get; set; }
        public int CurrencyId { get; set; }
        public String CurrencyName { get; set; }
        public String CurrencyCode { get; set; }
        public String CurrencyNum { get; set; }
        public int CountryId { get; set; }
        public String CountryName { get; set; }
        public String Description { get; set; }
    }
}
