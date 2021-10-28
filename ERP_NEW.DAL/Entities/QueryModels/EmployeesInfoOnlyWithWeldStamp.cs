using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class EmployeesInfoOnlyWithWeldStamp
    {
        [Key]
        public int EmployeeId { get; set; }
        public decimal AccountNumber { get; set; }
        public string Fio { get; set; }
        public int? ProfessionId { get; set; }
        public int? DepartmentId { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public DateTime? BeginDate { get; set; }
        public string StampNumber { get; set; }
    }
}
