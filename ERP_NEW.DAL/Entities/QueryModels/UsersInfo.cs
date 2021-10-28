using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class UsersInfo
    {
        [Key]
        public decimal EmployeeNumber { get; set; }
        public int EmployeeId { get; set; }
        public int? UserId { get; set; }
        public int? UserRoleId { get; set; }
        public string Fio { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
    }
}
