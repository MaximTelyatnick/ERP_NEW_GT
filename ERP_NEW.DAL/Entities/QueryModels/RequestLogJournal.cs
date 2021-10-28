using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class RequestLogJournal
    {
        [Key]
        public int Id { get; set; }
        public int SeqNum { get; set; }
        public string Name { get; set; }
        public string InformationDoc { get; set; }
        public string Task { get; set; }
        public string Spesification { get; set; }
        public DateTime DateRegistration { get; set; }
        public string Address { get; set; }
        public string StageRegistration { get; set; }
        public string DocForTender { get; set; }
        public string OrderInfo { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Detals { get; set; }
        public int? ColorId { get; set; }
        public string Color { get; set; }
        public int? RequestLogContractorId { get; set; }
        public bool? ColorDetals { get; set; }
    }
}
