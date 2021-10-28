using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class PaintingWorks
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public long? MtsAssembliesId { get; set; }
        public string NameCheckProduct { get; set; }
        public string Result { get; set; }
        public string QuantityOfExecution { get; set; }
        public int ResponsiblePersonId { get; set; }
        public string CheckQuantityOfExecution { get; set; }
        public string CauseReturn { get; set; }
        public string CorrectiveAction { get; set; }
        public int? FinalResponsiblePersonId { get; set; }
        public string Note { get; set; }
        public int SeqNum { get; set; }
    }
}
