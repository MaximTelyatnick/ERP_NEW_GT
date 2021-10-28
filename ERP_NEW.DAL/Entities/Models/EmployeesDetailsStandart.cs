using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class EmployeesDetailsStandart
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecordID { get; set; }
        public string Gender { get; set; }
        public string WorkingPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
