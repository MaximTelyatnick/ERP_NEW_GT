using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsPaymentDTO : ObjectBase
    {
        public int ID { get; set; }
        public int BusinessTripsDetailsID { get; set; }
        public int EmployeesID { get; set; }
        public int BusinessTripsReportID { get; set; }
        public int AccountsID { get; set; }
        public decimal Payment { get; set; }
        public DateTime Payment_Date { get; set; }
        public string Comment { get; set; }
        public DateTime Doc_Date { get; set; }
        public int? BusinessTripsPaymentVatID { get; set; }
        public int? CurrencyRatesID { get; set; }
        public int? UserId { get; set; }
        
        public string AccountNum { get; set; }
        public decimal? VatPayment { get; set; }
        public int? VatAccountId { get; set; }
        public string VatAccountNum { get; set; }
        public int? CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public decimal? CurrencyRate { get; set; }
        public DateTime? CurrencyDate { get; set; }
        public decimal? CurrencyPayment { get; set; }
        public string ReportName { get; set; }

        public string Fio { get; set; }

        public bool Selected { get; set; }
    }
}
