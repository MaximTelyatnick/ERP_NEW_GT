using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ERP_NEW.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Users> users;
        private IRepository<UserRoles> userRoles;
        private IRepository<UserDetails> userDetails;
        private IRepository<UsersInfo> usersInfo;
        private IRepository<UserTasks> userTasks;
        private IRepository<AccessRights> accessRights;
        private IRepository<Tasks> tasks;
        private IRepository<Departments> departments;

        private IMapper mapper;
        
        public static UserDetailsDTO AuthorizatedUser { get; internal set; }
        public static IEnumerable<UserTasksDTO> AuthorizatedUserAccess { get; internal set; }

        public UserService(IUnitOfWork uow)
        {
            Database = uow;
            users = Database.GetRepository<Users>();
            userRoles = Database.GetRepository<UserRoles>();
            userDetails = Database.GetRepository<UserDetails>();
            usersInfo = Database.GetRepository<UsersInfo>();
            userTasks = Database.GetRepository<UserTasks>();
            tasks = Database.GetRepository<Tasks>();
            accessRights = Database.GetRepository<AccessRights>();
            departments = Database.GetRepository<Departments>();
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Users, UsersDTO>();
                cfg.CreateMap<UsersDTO, Users>();
                cfg.CreateMap<UserRoles, UserRolesDTO>();
                cfg.CreateMap<UserRolesDTO, UserRoles>();
                cfg.CreateMap<UserDetails, UserDetailsDTO>();
                cfg.CreateMap<UsersInfo, UsersInfoDTO>();
                cfg.CreateMap<UserTasks, UserTasksDTO>();
                cfg.CreateMap<UserTasksDTO, UserTasks>();
                cfg.CreateMap<Tasks, TasksDTO>();
                cfg.CreateMap<TasksDTO, Tasks>();
                cfg.CreateMap<AccessRights, AccessRightsDTO>();
                cfg.CreateMap<Departments, DepartmentsDTO>();
            });

            mapper = config.CreateMapper();
        }

        public bool TryAuthorize(decimal empNumber)
        {
            UsersDTO user = GetUserByNumber(empNumber);

            if (user != null)
            {
                if (empNumber == 624)
                {
                    //AuthorizatedUser = GetUserDetailsCrutch(empNumber);
                    AuthorizatedUser = GetUserDetailsCrutch(690);
                    AuthorizatedUserAccess = GetAuthorizationUserTasks(user.UserId);
                }
                else if (empNumber == 579)
                {
                    //AuthorizatedUser = GetUserDetailsCrutch(empNumber);
                    AuthorizatedUser = GetUserDetailsCrutch(656);
                    AuthorizatedUserAccess = GetAuthorizationUserTasks(user.UserId);
                }
                else
                {
                    AuthorizatedUser = GetUserDetails(empNumber);
                    AuthorizatedUserAccess = GetAuthorizationUserTasks(user.UserId);
                }
                
                return true;
            }
            return false;
        }

        public UsersDTO GetUserByNumber(decimal employeeNumber)
        {
            var user = users.GetAll().SingleOrDefault(c => c.EmployeeNumber == employeeNumber);
            return mapper.Map<Users, UsersDTO>(user);        
        }

        private UserDetailsDTO GetUserDetails(decimal employeeNumber)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("Number", employeeNumber),
            };
            string procName = @"select * from ""GetUserDetails""(@Number)";

            return mapper.Map<UserDetailsDTO>(userDetails.SQLExecuteProc(procName, Parameters).SingleOrDefault()); 
        }

        private UserDetailsDTO GetUserDetailsCrutch(decimal employeeNumber) // процедура для возможности работы с учетки человека уволленого с предприятия
        {
            FbParameter[] Parameters =
            {
                new FbParameter("Number", employeeNumber),
            };
            string procName = @"select * from ""GetUserDetailsCrutch""(@Number)";

            return mapper.Map<UserDetailsDTO>(userDetails.SQLExecuteProc(procName, Parameters).SingleOrDefault());
        }

        private IEnumerable<UserTasksDTO> GetAuthorizationUserTasks(int userId)
        {
            var result = (from ut in userTasks.GetAll()
                          join ur in userRoles.GetAll() on ut.UserRoleId equals ur.RoleId
                          join u in users.GetAll() on ur.RoleId equals u.UserRoleId
                          join t in tasks.GetAll() on ut.TaskId equals t.TaskId
                          join a in accessRights.GetAll() on ut.AccessRightId equals a.RightId
                          where u.UserId == userId
                          select new UserTasksDTO
                          {
                              UserTaskId = ut.UserTaskId,
                              UserId = u.UserId,
                              TaskId = ut.TaskId,
                              TaskName = t.TaskName,
                              TaskCaption = t.TaskCaption,
                              UserRoleId = ur.RoleId,
                              RoleName = ur.RoleName,
                              AccessRightId = ut.AccessRightId,
                              RightAttribute = a.RightAttribute,
                              RightName = a.RightName,
                              PriceAttribute= ut.PriceAttribute
                          });

            return result.ToList();
        }

        public IEnumerable<UserTasksDTO> GetUserTasks(int userRoleId)
        {
            var result = (from u in userTasks.GetAll()
                          join t in tasks.GetAll() on u.TaskId equals t.TaskId
                          join a in accessRights.GetAll() on u.AccessRightId equals a.RightId
                          where u.UserRoleId == userRoleId
                          where t.ParentId != null
                          orderby t.TaskCaption
                          select new UserTasksDTO
                          {
                              UserTaskId = u.UserTaskId,
                              UserRoleId = u.UserRoleId,
                              TaskId = u.TaskId,
                              TaskName = t.TaskName,
                              TaskCaption = t.TaskCaption,
                              AccessRightId = u.AccessRightId,
                              RightAttribute = a.RightAttribute,
                              RightName = a.RightName,
                              PriceAttribute = u.PriceAttribute
                          });

            return result;
            
        }

        public IEnumerable<TasksDTO> GetTasksAll()
        {

            return mapper.Map<IEnumerable<Tasks>, List<TasksDTO>>(tasks.GetAll()).OrderBy(s => s.TaskId);
        }

        public IEnumerable<UsersInfoDTO> GetUsers()
        {
            string procName = @"select * from ""GetAllUsersInfo""";

            return mapper.Map<IEnumerable<UsersInfo>, List<UsersInfoDTO>>(usersInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<UserRolesDTO> GetUserRoles()
        {
            var query = (from t in userRoles.GetAll()
                         join dp in departments.GetAll() on t.DepartmentId equals dp.DepartmentID into dpp
                         from dp in dpp.DefaultIfEmpty()
                         select new UserRolesDTO
                         {
                              RoleId = t.RoleId,
                               DepartmentId = dp.DepartmentID,
                                RoleName = t.RoleName,
                                 DepartmentName = dp.Name
                         }).ToList();

            return query;
        }

        public IEnumerable<TasksDTO> GetTasks(int roleId)
        {
            var result = userTasks.GetAll().Where(s => s.UserRoleId == roleId);

            var query = (from t in tasks.GetAll()
                         join u in result on t.TaskId equals u.TaskId into sc
                         from u in sc.DefaultIfEmpty()
                         where (u == null) || (u != null && t.ParentId == null)
                         select new TasksDTO
                         {
                             TaskId = t.TaskId,
                             TaskName = t.TaskName,
                             TaskCaption = t.TaskCaption,
                             ParentId = t.ParentId,
                             UserTaskId = u.UserTaskId
                         }).ToList();

            return query;
        }

        public void UserTasksCreateRange(List<UserTasksDTO> source)
        {
            userTasks.CreateRange(mapper.Map<IEnumerable<UserTasks>>(source));
        }

         public void UserTasksUpdateRange(List<UserTasksDTO> tasks)
        {
            for (int i = 0; i <= tasks.Count - 1; i++)
            {
                userTasks.Update(mapper.Map<UserTasks>(tasks[i]));
            }
        }

        public bool UserTaskDeleteById(int? id)
        {
            try
            {
                var delTasks = userTasks.GetAll().SingleOrDefault(c => c.UserTaskId == id.Value);
                userTasks.Delete(delTasks);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void UsersUpdateRange(List<UsersDTO> source)
        {
            users.CreateRange(mapper.Map<IEnumerable<Users>>(source));
        }
                
        public bool UserDeleteById(int? id)
        {
            try
            {
                var delUser = users.GetAll().SingleOrDefault(c => c.UserId == id.Value);
                users.Delete(delUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int UserRoleCreate(UserRolesDTO urdto)
        {
            var newRole = userRoles.Create(mapper.Map<UserRoles>(urdto));
            return newRole.RoleId;
        }


        public void UserRoleUpdate(UserRolesDTO urdto)
        {
            var eRole = userRoles.GetAll().SingleOrDefault(c => c.RoleId == urdto.RoleId);

            userRoles.Update(mapper.Map<UserRolesDTO, UserRoles>(urdto, eRole));
        }

        public bool UserRoleDeleteById(int? id)
        {
            try
            {
                var delUserRole = userRoles.GetAll().SingleOrDefault(c => c.RoleId == id.Value);
                userRoles.Delete(delUserRole);
                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }
        }

        public int UserCreate(UsersDTO udto)
        {
            var newUser = users.Create(mapper.Map<Users>(udto));
            return newUser.UserId;
        }


        public void UserUpdate(UsersDTO udto)
        {
            var usersUpdate = users.GetAll().SingleOrDefault(c => c.UserId == udto.UserId);

            users.Update(mapper.Map<UsersDTO, Users>(udto, usersUpdate));
        }

        public void UserUpdateState(int userId, bool state)
        {
            var usersUpdate = users.GetAll().SingleOrDefault(c => c.UserId == userId);
            usersUpdate.Online = state;
            users.Update(usersUpdate);
        }



        public void Dispose()
        {
            Database.Dispose();
        }

     
        

        public void TasksCreate(TasksDTO tskdto)
        {
            var newtask = tasks.Create(mapper.Map<Tasks>(tskdto));
          //  return newtask.TaskId;
        }
        public void TasksUpdate(TasksDTO tskdto)
        {
            var etasks = tasks.GetAll().SingleOrDefault(t => t.TaskId == tskdto.TaskId);
            tasks.Update(mapper.Map<TasksDTO, Tasks>(tskdto, etasks));

        }
        public bool TasksDeleteById(int? tasksId)
        {
            try
            {
                var deltasks = tasks.GetAll().SingleOrDefault(c => c.TaskId == tasksId.Value);
                tasks.Delete(deltasks);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }

}
