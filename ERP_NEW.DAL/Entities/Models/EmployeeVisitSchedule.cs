using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERP_NEW.DAL.Entities.Models
{
    public class EmployeeVisitSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime FalseId { get; set; }
        public DateTime Date { get; set; }
        public int DayNumber { get; set; }
        public int EmployeeId { get; set; }
        public DateTime EmployeeCome { get; set; }
        public DateTime EmployeeOut { get; set; }
    }
}
