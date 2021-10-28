using System;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class UserDetailsDTO
    {
        public int UserId { get; set; }
        public int EmployeeID { get; set; }
        public decimal AccountNumber { get; set; }
        public string Fio { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public byte[] UserPhoto { get; set; }
    }
}
