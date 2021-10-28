using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class OrderForDetalsContractor
    {
        [Key]
        public int Id { get; set; }
        public int? VendorId { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? OrdTotalPrice { get; set; }
        public decimal? OrdVat { get; set; }
        public decimal? AllPrice { get; set; }
        public string VatAccountNum { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
