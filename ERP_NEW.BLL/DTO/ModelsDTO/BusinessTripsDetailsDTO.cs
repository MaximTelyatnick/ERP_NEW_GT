using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsDetailsDTO
    {
        public int ID { get; set; }
        public int BusinessTripsID { get; set; }
        public int EmployeesID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Profession { get; set; }
        public int ProfessionId { get; set; }
    }
}
