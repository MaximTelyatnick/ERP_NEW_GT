using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class EXPENDITURES_ACCOUNTANT
    {
        [Key]
        public int ID { get; set; }
        public int RECEIPT_ID { get; set; }
        public decimal? QUANTITY { get; set; }
        public decimal PRICE { get; set; }
        public DateTime? EXP_DATE { get; set; }
        public DateTime? RealExpDate { get; set; }
        public string PROJECT_NUM { get; set; }
        public int? CREDIT_ACCOUNT_ID { get; set; }
        public int? CustomerOrderId { get; set; }
        public int? ProdCustomerOrderId { get; set; }
        public int? EmployeeId { get; set; }
        public int? UserId { get; set; }
        public bool ExpenditureType { get; set; }
        public DateTime? ExpenditureCheckDate { get; set; }

    }
}
