using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AccountingOperations
    {
        [Key]
        public int Id { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string OperateDocument { get; set; }
        public decimal? PaymentPrice { get; set; }
        public int? OperatingAccountId { get; set; }
        public int? PurposeAccountId { get; set; }
        public int? ContractorId { get; set; }
        public int? Direction { get; set; }
        public string Purpose { get; set; }
        public int? PaymentBankAccountId { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int AccountingOperationId { get; set; }
        public int? ColorId { get; set; }
    }
}
