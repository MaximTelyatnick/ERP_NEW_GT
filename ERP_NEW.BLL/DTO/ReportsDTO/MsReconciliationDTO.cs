using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class MsReconciliationDTO
    {
        public int RecId { get; set; }
        public decimal? StartDebit { get; set; }
        public decimal? StartCredit { get; set; }
        public decimal? EndDebit { get; set; }
        public decimal? EndCredit { get; set; }
        public DateTime? Order_Date { get; set; }
        public string Invoice_Num { get; set; }
        public string Purpose { get; set; }
        public decimal? Debit_Price { get; set; }
        public decimal? Credit_Price { get; set; }
    }
}
