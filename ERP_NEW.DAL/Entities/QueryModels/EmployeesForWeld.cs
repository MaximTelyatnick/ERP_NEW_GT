using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class EmployeesForWeld
    {
        [Key]
        public int EmployeeID { get; set; }
        public decimal AccountNumber { get; set; }
        public string Fio { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
    }
}
