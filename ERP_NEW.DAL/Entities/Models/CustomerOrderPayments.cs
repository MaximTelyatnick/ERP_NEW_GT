using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CustomerOrderPayments
    {
        [Key]
        public int Id { get; set; }
        public int CustomerOrderId { get; set; }
        public int BankPaymentId { get; set; }
        public decimal? Payment { get; set; }
        public decimal? PaymentCurrency { get; set; }
    }
}
