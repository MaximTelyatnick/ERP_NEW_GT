using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class MsTrialBalanceDTO
    {
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
