using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class EmployeesInfoNonPhotoDTO
    {

        public int EmployeeID { get; set; }
        public decimal AccountNumber { get; set; }
        public string IdentNumber { get; set; }
        public string Fio { get; set; }
        public string FullName { get; set; }
        public int? ProfessionID { get; set; }
        public int? DepartmentID { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }

        public int? SupplierId { get; set; }

        public bool Selected { get; set; }

    }
}
