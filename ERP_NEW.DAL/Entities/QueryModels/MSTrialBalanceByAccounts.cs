using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class MSTrialBalanceByAccounts
    {
        [Key]
        public int RecId { get; set; }
        public int Contractor_Id { get; set; }
        public string ContractorSrn { get; set; }
        public string ContractorName { get; set; }
        public decimal StartDebit { get; set; }
        public decimal StartCredit { get; set; }
        public decimal EndDebit { get; set; }
        public decimal EndCredit { get; set; }
        public int AccountId { get; set; }
        public string AccountNum { get; set; }
        public int? OrderId { get; set; }
        public string Payment_Document { get; set; }
        public DateTime? Payment_Date { get; set; }
        public string Invoice_Num { get; set; }
        public DateTime? Invoice_Date { get; set; }
        public decimal? PeriodPrice { get; set; }
        public int FlagDebitCredit { get; set; }

    }
}
