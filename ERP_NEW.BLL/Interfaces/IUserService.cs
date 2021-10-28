using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IUserService
    {
        bool TryAuthorize(decimal empNumber);

        IEnumerable<UsersInfoDTO> GetUsers();
        IEnumerable<UserRolesDTO> GetUserRoles();
        IEnumerable<UserTasksDTO> GetUserTasks(int userRoleId);
        IEnumerable<TasksDTO> GetTasks(int roleId);
        UsersDTO GetUserByNumber(decimal employeeNumber);
        int UserRoleCreate(UserRolesDTO urdto);
        void UserRoleUpdate(UserRolesDTO urdto);
        bool UserRoleDeleteById(int? id);

        void UsersUpdateRange(List<UsersDTO> users);
        bool UserDeleteById(int? id);

        void UserTasksCreateRange(List<UserTasksDTO> userTasks);
        void UserTasksUpdateRange(List<UserTasksDTO> tasks);
        bool UserTaskDeleteById(int? id);

        void Dispose();
    }
}
