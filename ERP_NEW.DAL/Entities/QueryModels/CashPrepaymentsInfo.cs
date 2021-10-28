using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class CashPrepaymentsInfo
    {
        [Key]
        public int Id { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public decimal PrepaymentPrice { get; set; }
        public int AccountId { get; set; }
        public int EmployeesId { get; set; }
        public DateTime DateAdded { get; set; }
        public int UserId { get; set; }

        public string PersonName { get; set; }
        public decimal AccountNumber { get; set; }
        public string BalanceAccountNum { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public decimal PaymentSum { get; set; }
        public decimal SaldoDebit { get; set; }
        public decimal SaldoCredit { get; set; }
    }
}
