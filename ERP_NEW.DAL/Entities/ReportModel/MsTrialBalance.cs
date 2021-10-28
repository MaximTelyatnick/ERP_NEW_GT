using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class MsTrialBalance
    {
        [Key]
        public int RecId { get; set; }
        public string Contractor_Name { get; set; }
        public string Contractor_Srn { get; set; }
        public decimal? Begin_Debit { get; set; }
        public decimal? Begin_Credit { get; set; }
        public decimal? Period_Debit { get; set; }
        public decimal? Period_Credit { get; set; }
        public decimal? End_Debit { get; set; }
        public decimal? End_Credit { get; set; }
    }
}
