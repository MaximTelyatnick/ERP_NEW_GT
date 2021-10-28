using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class BankPaymentsInfo
    {
        [Key]
        public int RecId { get; set; }
        public int Id { get; set; }
        public int? Contractor_Id { get; set; }
        public int? EmployeesId { get; set; }
        public string PartnerSrn { get; set; }
        public string PartnerName { get; set; }
        public string Payment_Document { get; set; }
        public DateTime? Payment_Date { get; set; }
        public decimal? Payment_Price { get; set; }
        public decimal? Payment_PriceCurrency { get; set; }
        public int? Direction { get; set; }
        public decimal? DebitPrice { get; set; }
        public decimal? DebitPriceCurrency { get; set; }
        public decimal? CreditPrice { get; set; }
        public decimal? CreditPriceCurrency { get; set; }
        public int? Bank_Account_Id { get; set; }
        public string BankAccountNum { get; set; }
        public int? Purpose_Account_Id { get; set; }
        public string PurposeAccountNum { get; set; }
        public string Purpose { get; set; }
        public decimal? Rate { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public int? CustomerOrderId { get; set; }
        public string OrderNumber { get; set; }
        public decimal CustomerOrderPrice { get; set; }
        public decimal CustomerOrderCurrencyPrice { get; set; }
        public int? CurrencyRatesConvertId { get; set; }
        public decimal? VatPrice { get; set; }
        public int? VatAccountId { get; set; }
        public string VatAccountNum { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int AccountingOperationId { get; set; }
        public int? ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
