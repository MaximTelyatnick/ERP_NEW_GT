using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class CalcWithBuyersReportDTO
    {
        public int RecId { get; set; }
        public int ContractorsId { get; set; }
        public int EmployeesId { get; set; }
        public int CurrencyId { get; set; }
        public string PartnerSrn { get; set; }
        public string PartnerName { get; set; }
        public string Purpose { get; set; }
        public string CurrencyName { get; set; }
        public decimal StartDebit { get; set; }
        public decimal StartDebitCurrency { get; set; }
        public decimal StartCredit { get; set; }
        public decimal StartCreditCurrency { get; set; }
        public decimal EndDebit { get; set; }
        public decimal EndDebitCurrency { get; set; }
        public decimal EndCredit { get; set; }
        public decimal EndCreditCurrency { get; set; }
        public int AccountId { get; set; }
        public string Num { get; set; }
        public string Payment_Document { get; set; }
        public DateTime? Payment_Date { get; set; }
        public decimal PeriodPriceCurrency { get; set; }
        public decimal PeriodPrice { get; set; }
        public decimal? Rate { get; set; }
        public decimal? VatPayment643 { get; set; }
        public decimal? VatPayment6412 { get; set; }
        public decimal? VatTotalSum { get; set; }
        public decimal? PeriodTotalPriceWithVat { get; set; }
        public int FlagDebitCredit { get; set; }
    }
}
