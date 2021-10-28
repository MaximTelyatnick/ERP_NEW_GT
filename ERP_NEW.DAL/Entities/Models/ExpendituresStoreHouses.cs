using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ExpendituresStoreHouses
    {
        [Key]
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? ExpDate { get; set; }
        public int? CustomerOrderId { get; set; }
        public int? ExpenditureId { get; set; }
        public int? EmployeeId { get; set; }
        public bool Check { get; set; }
    }
}
