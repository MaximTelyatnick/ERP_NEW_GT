using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AgreementOrder
    {
        [Key]
        public int Id { get; set; }
        public string AgreementOrderNumber { get; set; }
        public DateTime? AgreementOrderDate { get; set; }
        public int? ContractorId { get; set; }
        public int? AgreementId { get; set; }
        public int? PurposeId { get; set; }
        public decimal Price { get; set; }
        public int? CurrencyId { get; set; }
        public int? ResponsibleId { get; set; }
        public int? AgreementOrderScanId { get; set; }
    }
}
