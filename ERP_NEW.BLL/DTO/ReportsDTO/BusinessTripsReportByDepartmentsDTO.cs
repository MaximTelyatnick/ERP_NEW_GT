using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class BusinessTripsReportByDepartmentsDTO
    {
        public int Id { get; set; }
        public DateTime DecreeDate { get; set; }
        public int EmployeeID { get; set; }
        public int AccountNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Fio { get; set; }
        public string Profession { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public int AmountDays { get; set; }
        public int ProfessionID { get; set; }
        public int DepartmentID { get; set; }
    }
}
