using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IUserService
    {
        int GetEmployeeIdByUserId(int userId);
        bool TryAuthorize(decimal empNumber);

        IEnumerable<UsersInfoDTO> GetUsers();
        IEnumerable<UserRolesDTO> GetUserRoles();
        IEnumerable<UserTasksDTO> GetUserTasks(int userRoleId);
        IEnumerable<TasksDTO> GetTasks(int roleId);
        IEnumerable<TasksDTO> GetTasksAll();
        UsersDTO GetUserByNumber(decimal employeeNumber);
        int UserRoleCreate(UserRolesDTO urdto);
        void UserRoleUpdate(UserRolesDTO urdto);
        bool UserRoleDeleteById(int? id);

        void UsersUpdateRange(List<UsersDTO> users);
        int UserCreate(UsersDTO udto);
        void UserUpdate(UsersDTO udto);
        void UserUpdateState(int userId, bool state);
        bool UserDeleteById(int? id);

        void UserTasksCreateRange(List<UserTasksDTO> userTasks);
        void UserTasksUpdateRange(List<UserTasksDTO> task);
        bool UserTaskDeleteById(int? id);

        void TasksCreate(TasksDTO tskdto);
        void TasksUpdate(TasksDTO tskdto);
        bool TasksDeleteById(int? id);

        void Dispose();
    }
}
