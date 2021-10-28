using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Agreements
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Price { get; set; }
        public int? CurrencyId { get; set; }
        public int? AgreementsIdFromContractor { get; set; }
        public int? ContractorId { get; set; }
        public int? TypeId { get; set; }
        public string NumberWithTilda { get; set; }
        public string UrlNameJournal { get; set; }
    }
}
