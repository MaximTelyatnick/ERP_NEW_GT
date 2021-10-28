using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CalcWithBuyers
    {
        [Key]
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public DateTime DocumentDate { get; set; }
        public decimal Payment { get; set; }
        public int BalanceAccountId { get; set; }
        public int PurposeAccountId { get; set; }
        public int? ContractorsId { get; set; }
        public int? EmployeesId { get; set; }
        public int? CurrencyRatesId { get; set; }
        public int AccountingOperationId { get; set; }
        public int UserId { get; set; }
    }
}
