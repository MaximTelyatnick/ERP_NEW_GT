using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Bank_Payments
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Payment_Date { get; set; }
        public string Payment_Document { get; set; }
        public decimal? Payment_Price { get; set; }
        public int? Bank_Account_Id { get; set; }
        public int? Purpose_Account_Id { get; set; }
        public int? Contractor_Id { get; set; }
        public int? Direction { get; set; }
        public string Purpose { get; set; }
        public int? Payment_Bank_Account_Id { get; set; }
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Payment_Price_Eq { get; set; }
        public int? EmployeesId { get; set; }
        public decimal? Payment_PriceCurrency { get; set; }
        public int? CurrencyRatesConvertId { get; set; }
        public decimal? VatPrice { get; set; }
        public int? VatAccountId { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int AccountingOperationId { get; set; }
        public int? ColorId { get; set; }
    }
}
