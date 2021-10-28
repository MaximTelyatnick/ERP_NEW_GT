using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class MsTrialBalanceCurrencyDTO
    {
        public int RecId { get; set; }
        public int Contractor_Id { get; set; }
        public string ContractorSrn { get; set; }
        public string ContractorName { get; set; }
        public string DebitCurrencyName { get; set; }
        public string BankCurrencyName { get; set; }
        public decimal StartDebit { get; set; }
        public decimal StartCredit { get; set; }
        public decimal StartDebitCurrency { get; set; }
        public decimal StartCreditCurrency { get; set; }
        public decimal PeriodDebit { get; set; }
        public decimal PeriodCredit { get; set; }
        public decimal PeriodDebitCurrency { get; set; }
        public decimal PeriodCreditCurrency { get; set; }
        public decimal EndDebit { get; set; }
        public decimal EndCredit { get; set; }
        public decimal EndDebitCurrency { get; set; }
        public decimal EndCreditCurrency { get; set; }
    }
}
