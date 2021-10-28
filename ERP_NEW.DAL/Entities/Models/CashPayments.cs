using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CashPayments
    {
        [Key]
        public int Id { get; set; }
        public int CashPrepaymentId { get; set; }
        public int ReceiptId { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal? VatPrice { get; set; }
        public int? VatAccountId { get; set; }
        public int? CustomerOrderId { get; set; }

        public int UserId { get; set; }
    }
}
