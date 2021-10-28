using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class CashBookRecordJournalByYearDTO
    {
        public int Id { get; set; }
        public string PageNumber { get; set; }
        public DateTime PageDate { get; set; }
        public string DocumentNumber { get; set; }
        public int CashBookPageId { get; set; }
        public int? CurrencyTypeId { get; set; }
        public decimal Payment { get; set; }
        public string BasisType { get; set; }
        public string CashBookContractorName { get; set; }
    }
}
