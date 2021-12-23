using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public decimal EmployeeNumber { get; set; }
        public int EmployeeId { get; set; }
        public int UserRoleId { get; set; }

        public bool? Online { get; set; }

        [ForeignKey("UserRoleId")]
        public UserRoles UserRoles { get; set; }
    }
}
