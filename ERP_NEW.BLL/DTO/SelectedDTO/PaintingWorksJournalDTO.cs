using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class PaintingWorksJournalDTO:ObjectBase
    {
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
        public string Drawing { get; set; }
        public string NameProduct { get; set; }
        public string ResponsiblePerson { get; set; }
        public string FinalResponsiblePerson { get; set; }
    }
}
