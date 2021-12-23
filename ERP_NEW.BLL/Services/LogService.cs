using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Services
{
    public class LogService : ILogService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Log> log;
        private IMapper mapper;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<Tasks> task;
        
        public LogService(IUnitOfWork uow)
        {
            Database = uow;
            log = Database.GetRepository<Log>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            task = Database.GetRepository<Tasks>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Log, LogDTO>();
                cfg.CreateMap<LogDTO, Log>();


            });

            mapper = config.CreateMapper();
        }
        public IEnumerable<LogDTO> GetLogs()
        {

            var result = (from c in log.GetAll()
                          join co in employeesDetails.GetAll() on c.EmployeeId equals co.EmployeeID into coo
                          from co in coo.DefaultIfEmpty()
                          join t in task.GetAll() on c.TaskId equals t.TaskId into to
                          from t in to.DefaultIfEmpty()
                          select new LogDTO
                          {
                              Id = c.Id,
                              EmployeeId = c.EmployeeId,
                              TaskId = t.TaskId,
                              TaskCaption = t.TaskCaption,
                              EmployeeName =( co.LastName + ' ' + co.FirstName+' ' + co.MiddleName),
                              RecDate = c.RecDate,
                              RecTime = c.RecTime,
                              OperationType = c.OperationType
                          });
            return result.ToList();
            //var result = (from c in accounts.GetAll()
            //              join co in accountsType.GetAll() on c.Type equals co.ID into coo
            //              from co in coo.DefaultIfEmpty()
            //              select new AccountsDTO
            //              {
            //                  Id = c.ID,
            //                  Num = c.NUM,
            //                  Description = c.Description,
            //                  TypeName = co.TypeName,
            //                  Type = co.ID,
            //                  VatMark = c.VatMark
            //              });
            //return result.ToList();

        }

        #region Log CRUD method's

        public int LogCreate(LogDTO logDTO)
        {
            var createLog = log.Create(mapper.Map<Log>(logDTO));
            return (int)createLog.Id;
        }

        public void LogUpdate(LogDTO logDTO)
        {
            var updateLog = log.GetAll().SingleOrDefault(c => c.Id == logDTO.Id);
            log.Update((mapper.Map<LogDTO, Log>(logDTO, updateLog)));
        }

        public bool LogDelete(int id)
        {
            try
            {
                log.Delete(log.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
        
    }
}
