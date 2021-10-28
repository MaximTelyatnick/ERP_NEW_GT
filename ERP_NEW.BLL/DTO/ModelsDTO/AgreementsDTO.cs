using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AgreementsDTO : ObjectBase
    {
        [Key]
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
