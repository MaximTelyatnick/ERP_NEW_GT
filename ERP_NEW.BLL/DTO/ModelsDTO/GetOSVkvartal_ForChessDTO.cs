using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class GetOSVkvartal_ForChessDTO
    {
        public string PurposeAccountNum { get; set; }
        public int BankAccountId { get; set; }
        public decimal? Debit { get; set; }
        public decimal Credit { get; set; }
        public int RecId { get; set; }
    }
}
