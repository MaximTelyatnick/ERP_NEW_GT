using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CashPaymentsDTO : ObjectBase
    {
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
