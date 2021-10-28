using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class MSPaymentsWithoutVat
    {
        [Key]
        public int RecId { get; set; }
        public int ContractorId { get; set; }
        public string Name { get; set; }
        public string Srn { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentDocument { get; set; }
        public decimal? PaymentPrice { get; set; }
        public string PaymentPurposeNum { get; set; }
    }
}
