using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_NEW.DAL.Entities.Models
{
   public class UserTasks
    {
       [Key]
       public int UserTaskId { get; set; }
       public int TaskId { get; set; }
       public int UserRoleId { get; set; }
       public int AccessRightId { get; set; }
       public int PriceAttribute { get; set; }

       //[ForeignKey("UserId")]
       //public Users Users { get; set; }
       //[ForeignKey("TaskId")]
       //public Tasks Tasks { get; set; }
       //[ForeignKey("AccessRightId")]
       //public AccessRights AccessRights { get; set; }
    }
}
