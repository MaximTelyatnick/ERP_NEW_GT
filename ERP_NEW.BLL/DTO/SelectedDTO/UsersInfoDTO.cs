
namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class UsersInfoDTO
    {
        public decimal EmployeeNumber { get; set; }
        public int EmployeeId { get; set; }
        public int? UserId { get; set; }
        public int? UserRoleId { get; set; }
        public string Fio { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }

        public string Checked { get; set; }
    }
}
