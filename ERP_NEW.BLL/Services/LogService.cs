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


        public LogService(IUnitOfWork uow)
        {
            Database = uow;
            log = Database.GetRepository<Log>();


            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Log, LogDTO>();
                cfg.CreateMap<LogDTO, Log>();


            });

            mapper = config.CreateMapper();
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
