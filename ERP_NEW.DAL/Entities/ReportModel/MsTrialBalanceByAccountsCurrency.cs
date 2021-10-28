using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class MsTrialBalanceByAccountsCurrency
    {
        [Key]
        public int RecId { get; set; }
        public int Contractor_Id { get; set; }
        public string ContractorSrn { get; set; }
        public string ContractorName { get; set; }
        public int CurrencyId { get; set; }
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
        public string AccountNum { get; set; }
        public string Payment_Document { get; set; }
        public DateTime? Payment_Date { get; set; }
        public string Invoice_Num { get; set; }
        public DateTime? Invoice_Date { get; set; }
        public decimal? PeriodPriceCurrency { get; set; }
        public decimal? PeriodPrice { get; set; }
        public decimal? Rate { get; set; }
        public int FlagDebitCredit { get; set; }
    }
}
