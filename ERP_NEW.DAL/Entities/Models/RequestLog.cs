using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class RequestLog
    {
        [Key]
        public int Id { get; set; }
        public int SeqNum { get; set; }
        public string InformationDoc { get; set; }
        public string Spesification { get; set; }
        public DateTime DateRegistration { get; set; }
        public string StageRegistration { get; set; }
        public string DocForTender { get; set; }
        public string Detals { get; set; }
        public int? RequestLogContractorId { get; set; }
        public string Task { get; set; }
        public string ContactAddress { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? ColorId { get; set; }
        public bool? ColorDetals { get; set; }
    }
}
