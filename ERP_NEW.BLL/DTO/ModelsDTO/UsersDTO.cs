using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   public class UsersDTO
    {
        public int UserId { get; set; }
        public decimal EmployeeNumber { get; set; }
        public int EmployeeId { get; set; }
        public int UserRoleId { get; set; }

        public bool? Online { get; set; }
    }
}
