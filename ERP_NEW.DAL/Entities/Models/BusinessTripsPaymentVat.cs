using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessTripsPaymentVat
    {
        [Key]
        public int VatID { get; set; }
        public int VatAccountID { get; set; }
        public decimal VatPayment { get; set; }
    }
}
