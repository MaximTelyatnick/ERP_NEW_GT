using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class EmployeesDetailsDTO
    {
        public int RecordID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int DepartmentID { get; set; }
        public int ProfessionID { get; set; }
    }
}
