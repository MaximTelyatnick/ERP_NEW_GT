using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class CashPaymentsInfo
    {
        [Key]
        public int Id { get; set; }
        public int CashPrepaymentId { get; set; }
        public int ReceiptId { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal? VatPrice { get; set; }
        public int? VatAccountId { get; set; }
        public int UserId { get; set; }
        public int? CustomerOrderId { get; set; }

        public String ReceiptNum { get; set; }
        public DateTime OrderDate { get; set; }
        public string NomenclatureNumber { get; set; }
        public string NomenclatureName { get; set; }
        public string UnitLocalName { get; set; }
        public string BalanceAccountNum { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string VatAccountNum { get; set; }
        public string CustomerOrderNumber { get; set; }
    }
}
