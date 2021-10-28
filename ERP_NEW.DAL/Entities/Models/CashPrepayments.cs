using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CashPrepayments
    {
        [Key]
        public int Id { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public decimal PrepaymentPrice { get; set; }
        public int AccountId { get; set; }
        public int EmployeesId { get; set; }
        public DateTime DateAdded { get; set; }
        public int UserId { get; set; }
    }
}
