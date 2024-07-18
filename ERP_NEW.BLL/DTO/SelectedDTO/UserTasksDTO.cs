using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class UserTasksDTO
    {
        public int UserTaskId { get; set; }
        public int TaskId { get; set; }
        public int UserRoleId { get; set; }
        public string RoleName { get; set; }
        public string TaskName { get; set; }
        public string TaskCaption { get; set; }
        public int UserId { get; set; }
        public int AccessRightId { get; set; }
        public string RightName { get; set; }
        public string RightAttribute { get; set; }
        public int PriceAttribute { get; set; }
        public int AccountNumber { get; set; }


    }
}
