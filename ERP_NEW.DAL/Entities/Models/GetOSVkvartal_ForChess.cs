using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class GetOSVkvartal_ForChess
    {
        [Key]
        public string PurposeAccountNum { get; set; }
        public int BankAccountId { get; set; }
        public decimal? Debit { get; set; }
        public decimal Credit { get; set; }
        public int RecId { get; set; }
    }
}
