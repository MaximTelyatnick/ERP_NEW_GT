using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class MsDebitCredit
    {
        [Key]
        public int RecId { get; set; }
        public decimal Price { get; set; }
        public string ContractorName { get; set; }
        public string ContractorSrn { get; set; }
        public string DebitCredit { get; set; }
    }
}
