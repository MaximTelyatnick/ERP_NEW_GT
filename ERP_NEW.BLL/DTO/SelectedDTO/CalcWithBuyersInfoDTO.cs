using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class CalcWithBuyersInfoDTO
    {
        public int RecId { get; set; }
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? Payment { get; set; }
        public int? BalanceAccountId { get; set; }
        public int? PurposeAccountId { get; set; }
        public int? ContractorsId { get; set; }
        public int? EmployeesId { get; set; }
        public int? CurrencyRatesId { get; set; }
        public int? AccountingOperationId { get; set; }
        public int? CustomerOrderId { get; set; }
        public int UserId { get; set; }

        public string ContractorSrn { get; set; }
        public string ContractorName { get; set; }
        public string OrderNumber { get; set; }
        public string BalanceNum { get; set; }
        public string PurposeNum { get; set; }
        public decimal? PaymentDebit { get; set; }
        public decimal? PaymentDebitCurrency { get; set; }
        public decimal? PaymentCredit { get; set; }
        public decimal? PaymentCreditCurrency { get; set; }
        public string CurrencyName { get; set; }
        public decimal? Rate { get; set; }
        public decimal? PaymentVatPrice { get; set; }
    }
}
