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
    public class EmployeesService : IEmployeesService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<AccessScheduleEntity> accessScheduleEntity;
        private IRepository<EmployeesInfo> employeesInfo;
        private IRepository<EmployeesInfoOnlyWithWeldStamp> employeesInfoOnlyWithWeldStamp;
        private IRepository<EmployeesInfoNonPhoto> employeesInfoNonPhoto;
        private IRepository<Employees> employees;
        private IRepository<EmployeeVisitSchedule> employeeVisitSchedule;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<EmployeesDetailsStandart> employeesDetailsStandart;
        private IRepository<EmployeePhoto> employeePhoto;
        private IRepository<Departments> departments;
        private IRepository<Professions> professions;
        private IRepository<EntityPhotos> entityPhotos;
        private IMapper mapper;
        


        public EmployeesService(IUnitOfWork uow)
        {
            Database = uow;
            accessScheduleEntity = Database.GetRepository<AccessScheduleEntity>();
            employeesInfo = Database.GetRepository<EmployeesInfo>();
            employeesInfoOnlyWithWeldStamp = Database.GetRepository<EmployeesInfoOnlyWithWeldStamp>();
            employeesInfoNonPhoto = Database.GetRepository<EmployeesInfoNonPhoto>();
            employees = Database.GetRepository<Employees>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            employeesDetailsStandart = Database.GetRepository<EmployeesDetailsStandart>();
            employeePhoto = Database.GetRepository<EmployeePhoto>();
            employeeVisitSchedule = Database.GetRepository<EmployeeVisitSchedule>();
            entityPhotos = Database.GetRepository<EntityPhotos>();
            departments = Database.GetRepository<Departments>();
            professions = Database.GetRepository<Professions>();
            
            var config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<EmployeesInfo, EmployeesInfoDTO>();
                 cfg.CreateMap<EmployeesInfoOnlyWithWeldStamp, EmployeesInfoOnlyWithWeldStampDTO>();
                 cfg.CreateMap<EmployeesInfoNonPhoto, EmployeesInfoNonPhotoDTO>();
                 cfg.CreateMap<EmployeePhoto, EmployeePhotoDTO>();
                 cfg.CreateMap<Departments, DepartmentsDTO>();
                 cfg.CreateMap<DepartmentsDTO, Departments>();
                 cfg.CreateMap<Professions, ProfessionsDTO>();
                 cfg.CreateMap<ProfessionsDTO, Professions>();
                 cfg.CreateMap<EmployeeVisitSchedule, EmployeeVisitScheduleDTO>();
                 cfg.CreateMap<Employees, EmployeesDTO>();
                 cfg.CreateMap<EmployeesDTO, Employees>();
                 cfg.CreateMap<EmployeesDetails, EmployeesDetailsDTO>();
                 cfg.CreateMap<EmployeesDetailsDTO, EmployeesDetails>();
                 cfg.CreateMap<EmployeesDetailsStandart, EmployeesDetailsStandartDTO>();
                 cfg.CreateMap<EmployeesDetailsStandartDTO, EmployeesDetailsStandart>();
                 cfg.CreateMap<AccessScheduleEntity, AccessScheduleEntityDTO>();
                 cfg.CreateMap<AccessScheduleEntityDTO, AccessScheduleEntity>();
                 cfg.CreateMap<EntityPhotos, EntityPhotosDTO>();
                 cfg.CreateMap<EntityPhotosDTO, EntityPhotos>();

             });

            mapper = config.CreateMapper();
        }

        public IEnumerable<EmployeesDTO> GetEmployees()
        {
            return mapper.Map<IEnumerable<Employees>, List<EmployeesDTO>>(employees.GetAll());
        }

        public IEnumerable<EmployeesDetailsDTO> GetEmployeesDetails()
        {
            return mapper.Map<IEnumerable<EmployeesDetails>, List<EmployeesDetailsDTO>>(employeesDetails.GetAll());
        }

        public IEnumerable<EmployeesDetailsStandartDTO> GetEmployeesDetailsStandart()
        {
            return mapper.Map<IEnumerable<EmployeesDetailsStandart>, List<EmployeesDetailsStandartDTO>>(employeesDetailsStandart.GetAll());
        }

        public int GetLastEmployeesId()
        {
            return mapper.Map<IEnumerable<Employees>, List<EmployeesDTO>>(employees.GetAll()).OrderByDescending(sort => sort.EmployeeID).FirstOrDefault().EmployeeID;
        }

        public int GetLastEmployeesDetailsRecordId()
        {
            return mapper.Map<IEnumerable<EmployeesDetails>, List<EmployeesDetailsDTO>>(employeesDetails.GetAll()).OrderByDescending(sort => sort.RecordID).FirstOrDefault().RecordID;
        }

        public int GetAccessScheduleEntityEntityId()
        {
            return mapper.Map<IEnumerable<AccessScheduleEntity>, List<AccessScheduleEntityDTO>>(accessScheduleEntity.GetAll()).OrderByDescending(sort => sort.EntityID).FirstOrDefault().EntityID;
        }

        public int GetLastProfessionId()
        {
            return mapper.Map<IEnumerable<Professions>, List<ProfessionsDTO>>(professions.GetAll()).OrderByDescending(sort => sort.ProfessionID).FirstOrDefault().ProfessionID;
        }

        public int GetLastDepartmentId()
        {
            return mapper.Map<IEnumerable<Departments>, List<DepartmentsDTO>>(departments.GetAll()).OrderByDescending(sort => sort.DepartmentID).FirstOrDefault().DepartmentID;
        }

        public bool CheckEntityPhotos(int EntityID)
        {
            return mapper.Map<IEnumerable<EntityPhotos>, List<EntityPhotosDTO>>(entityPhotos.GetAll()).Any(srch => srch.EntityID == EntityID);
        }

        public IEnumerable<EmployeesInfoDTO> GetEmployeeHistory(decimal employeeNumber)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("Number", employeeNumber),
            };
            
            string procName = @"select * from ""GetEmployeeHistory""(@Number)";

            return mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<EmployeesInfoDTO> GetEmployeesWorking()
        {
            string procName = @"select * from ""GetEmployeesWorking""";


            return mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<EmployeesInfoDTO> GetEmployeesWorkingAll()
        {
            string procName = @"select * from ""GetEmployeesWorkingAll""";

            return mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<EmployeesInfoDTO> GetEmployeesWorkingOnline()
        {
            string procName = @"select * from ""GetEmployeesWorkingOnline""";

            return mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName));
        }
        public IEnumerable<EmployeesInfoDTO> GetEmployeesNotWorking()
        {
            string procName = @"select * from ""GetEmployeesNotWorking""";

            return mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<EmployeesInfoDTO> GetEmployeesWorkingByDeparmentId(int departmentId)
        {
            string procName = @"select * from ""GetEmployeesWorking""";

            return mapper.Map<IEnumerable<EmployeesInfo>, List<EmployeesInfoDTO>>(employeesInfo.SQLExecuteProc(procName).Where(bdsm => bdsm.DepartmentID == departmentId));
        }

        public IEnumerable<EmployeesInfoOnlyWithWeldStampDTO> GetEmployeesWorkingWithWeldStamp()
        {
            string procName = @"select * from ""GetEmployeesWithWeldStamp""";

            return mapper.Map<IEnumerable<EmployeesInfoOnlyWithWeldStamp>, List<EmployeesInfoOnlyWithWeldStampDTO>>(employeesInfoOnlyWithWeldStamp.SQLExecuteProc(procName));
        }

        public IEnumerable<EmployeesInfoNonPhotoDTO> GetEmployeesWorkingNonPhoto()
        {
            string procName = @"select * from ""GetEmployeeInfoNonPhoto""";

            return mapper.Map<IEnumerable<EmployeesInfoNonPhoto>, List<EmployeesInfoNonPhotoDTO>>(employeesInfoNonPhoto.SQLExecuteProc(procName));
        }

        public EmployeePhotoDTO GetPhotoById(int EmployeesId)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EmployeeId", EmployeesId)
                };

            string procName = @"select * from ""GetEmployeePhotoById""(@EmployeeId)";

            return (mapper.Map<IEnumerable<EmployeePhoto>, List<EmployeePhotoDTO>>(employeePhoto.SQLExecuteProc(procName, Parameters))).SingleOrDefault();
        }


        public IEnumerable<DepartmentsDTO> GetDepartments()
        {
            return mapper.Map<IEnumerable<Departments>, List<DepartmentsDTO>>(departments.GetAll());
        }

        public IEnumerable<ProfessionsDTO> GetProfessions()
        {
            return mapper.Map<IEnumerable<Professions>, List<ProfessionsDTO>>(professions.GetAll());
        }
        


        public IEnumerable<EmployeeVisitScheduleDTO> GetEmployeeVisitScheduleProc(int employeeId, DateTime startDate, DateTime endDate)
        {
            FbParameter[] Parametrs =
            {
                new FbParameter("Id",employeeId),
                new FbParameter("StartDate",startDate),
                new FbParameter("EndDate",endDate)
            
            };
            string procName = @"select * from ""GetEmployeeVisitScheduleProc""(@Id, @StartDate, @EndDate)";

            return mapper.Map<IEnumerable<EmployeeVisitSchedule>, List<EmployeeVisitScheduleDTO>>(employeeVisitSchedule.SQLExecuteProc(procName,Parametrs));
        }



        #region CRUD Employees

        public int EmployeesCreate(EmployeesDTO employeesDTO)
        {
            var createEmployees = employees.Create(mapper.Map<Employees>(employeesDTO));
            return (int)createEmployees.EmployeeID;
        }

        public void EmployeesUpdate(EmployeesDTO employeesDTO)
        {
            var updateEmployees = employees.GetAll().SingleOrDefault(c => c.EmployeeID == employeesDTO.EmployeeID);
            employees.Update((mapper.Map<EmployeesDTO, Employees>(employeesDTO, updateEmployees)));
        }

        public bool EmployeesDelete(int id)
        {
            try
            {
                employees.Delete(employees.GetAll().FirstOrDefault(c => c.EmployeeID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        #endregion

        #region CRUD EmployeesDetails

        public int EmployeesDetailsCreate(EmployeesDetailsDTO employeesDetailsDTO)
        {
            var createEmployeesDetails = employeesDetails.Create(mapper.Map<EmployeesDetails>(employeesDetailsDTO));
            return (int)createEmployeesDetails.RecordID;
        }

        public void EmployeesDetailsUpdate(EmployeesDetailsDTO employeesDetailsDTO)
        {
            var updateEmployeesDetails = employeesDetails.GetAll().SingleOrDefault(c => c.RecordID == employeesDetailsDTO.RecordID);
            employeesDetails.Update((mapper.Map<EmployeesDetailsDTO, EmployeesDetails>(employeesDetailsDTO, updateEmployeesDetails)));
        }

        public bool EmployeesDetailsDelete(int id)
        {
            try
            {
                employeesDetails.Delete(employeesDetails.GetAll().FirstOrDefault(c => c.RecordID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region CRUD EmployeesDetailsStandart

        public int EmployeesDetailsStandartCreate(EmployeesDetailsStandartDTO employeesDetailsStandartDTO)
        {
            var createEmployeesDetailsStandart = employeesDetailsStandart.Create(mapper.Map<EmployeesDetailsStandart>(employeesDetailsStandartDTO));
            return (int)createEmployeesDetailsStandart.RecordID;
        }

        public void EmployeesDetailsStandartUpdate(EmployeesDetailsStandartDTO employeesDetailsStandartDTO)
        {
            var updateEmployeesDetails = employeesDetailsStandart.GetAll().SingleOrDefault(c => c.RecordID == employeesDetailsStandartDTO.RecordID);
            employeesDetailsStandart.Update((mapper.Map<EmployeesDetailsStandartDTO, EmployeesDetailsStandart>(employeesDetailsStandartDTO, updateEmployeesDetails)));
        }

        public bool EmployeesDetailsStandartDelete(int id)
        {
            try
            {
                employeesDetailsStandart.Delete(employeesDetailsStandart.GetAll().FirstOrDefault(c => c.RecordID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region CRUD EmployeesPhoto

        public int EntityPhotosCreate(EntityPhotosDTO entityPhotosDTO)
        {
            var createEmployeePhoto = entityPhotos.Create(mapper.Map<EntityPhotos>(entityPhotosDTO));
            return (int)createEmployeePhoto.EntityID;
        }

        public void EntityPhotosUpdate(EntityPhotosDTO employeePhotoDTO)
        {
            var updateEmployeePhoto = entityPhotos.GetAll().SingleOrDefault(c => c.EntityID == employeePhotoDTO.EntityID);
            entityPhotos.Update((mapper.Map<EntityPhotosDTO, EntityPhotos>(employeePhotoDTO, updateEmployeePhoto)));
        }

        public bool EntityPhotosDelete(int id)
        {
            try
            {
                employeePhoto.Delete(employeePhoto.GetAll().FirstOrDefault(c => c.EmployeeID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region CRUD AccesScheduleEntity

        public int AccessScheduleEntityCreate(AccessScheduleEntityDTO accessScheduleEntityDTO)
        {
            var createAccesScheduleEntity = accessScheduleEntity.Create(mapper.Map<AccessScheduleEntity>(accessScheduleEntityDTO));
            return (int)createAccesScheduleEntity.EntityID;
        }

        public void AccessScheduleEntityUpdate(AccessScheduleEntityDTO accessScheduleEntityDTO)
        {
            var updateAccessScheduleEntity = accessScheduleEntity.GetAll().SingleOrDefault(c => c.EntityID == accessScheduleEntityDTO.EntityID);
            accessScheduleEntity.Update((mapper.Map<AccessScheduleEntityDTO, AccessScheduleEntity>(accessScheduleEntityDTO, updateAccessScheduleEntity)));
        }

        public bool AccessScheduleEntityDelete(int id)
        {
            try
            {
                accessScheduleEntity.Delete(accessScheduleEntity.GetAll().FirstOrDefault(c => c.EntityID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region CRUD Departments

        public int DepartmentsCreate(DepartmentsDTO departmentsDTO)
        {
            var createDepartments = departments.Create(mapper.Map<Departments>(departmentsDTO));
            return (int)createDepartments.DepartmentID;
        }

        public void DepartmentUpdate(DepartmentsDTO departmentsDTO)
        {
            var updateDepartment = departments.GetAll().SingleOrDefault(c => c.DepartmentID == departmentsDTO.DepartmentID);
            departments.Update((mapper.Map<DepartmentsDTO, Departments>(departmentsDTO, updateDepartment)));
        }

        public bool DepartmentsDelete(int id)
        {
            try
            {
                departments.Delete(departments.GetAll().FirstOrDefault(c => c.DepartmentID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region CRUD Profession

        public int ProfessionCreate(ProfessionsDTO professionsDTO)
        {
            var createProfession = professions.Create(mapper.Map<Professions>(professionsDTO));
            return (int)createProfession.ProfessionID;
        }

        public void ProfessionUpdate(ProfessionsDTO professionsDTO)
        {
            var updateProfession = professions.GetAll().SingleOrDefault(c => c.ProfessionID == professionsDTO.ProfessionID);
            professions.Update((mapper.Map<ProfessionsDTO, Professions>(professionsDTO, updateProfession)));
        }

        public bool ProfessionDelete(int id)
        {
            try
            {
                professions.Delete(professions.GetAll().FirstOrDefault(c => c.ProfessionID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
        

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
