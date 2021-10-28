using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CashBookRecord
    {
        [Key]
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public int AccountId { get; set; }
        public int? CurrencyTypeId { get; set; }
        public int CashBookPageId { get; set; }
        public int? BasisId { get; set; }
        public int? ContractorId { get; set; }
        public int? AdditionalId { get; set; }
        public decimal Payment { get; set; }
    }
}
