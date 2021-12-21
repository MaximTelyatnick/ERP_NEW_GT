using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class LogDTO
    {
       
        public int Id { get; set; }
        public int EmployeesId { get; set; }
        public string FormName { get; set; }
        public string EmployeeName { get; set; }
        public string OperationType { get; set; }
        public DateTime RecDate { get; set; }
        public DateTime RecTime { get; set; }
    }
}
