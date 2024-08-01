using AutoMapper;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.Infrastructure;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ERP_NEW.BLL.Services
{
    public class LogService : ILogService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Log> log;
        private IRepository<SearchTable> searchTable;
        private IMapper mapper;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<Tasks> task;
        
        public LogService(IUnitOfWork uow)
        {
            Database = uow;
            log = Database.GetRepository<Log>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            task = Database.GetRepository<Tasks>();
            searchTable = Database.GetRepository<SearchTable>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Log, LogDTO>();
                cfg.CreateMap<LogDTO, Log>();
                cfg.CreateMap<SearchTable, SearchTableDTO>();
                cfg.CreateMap<SearchTableDTO, SearchTable>();

            });

            mapper = config.CreateMapper();
        }
        //public IEnumerable<LogDTO> GetLogs()
        //{

        //    var result = (from c in log.GetAll()
        //                  join co in employeesDetails.GetAll() on c.EmployeeId equals co.EmployeeID into coo
        //                  from co in coo.DefaultIfEmpty()
        //                  join t in task.GetAll() on c.TaskId equals t.TaskId into to
        //                  from t in to.DefaultIfEmpty()
        //                  select new LogDTO
        //                  {
        //                      Id = c.Id,
        //                      EmployeeId = c.EmployeeId,
        //                      TaskId = t.TaskId,
        //                      TaskCaption = t.TaskCaption,

        //                      EmployeeName = (co.LastName + " " + co.FirstName + " " + co.MiddleName),
        //                      RecDate = c.RecDate,
        //                      RecTime = c.RecTime,
        //                      OperationType = c.OperationType
        //                  });
        //    return result.ToList();
        //}

        public int CreateTable()
        {
            try
            {
                string procName = "CREATE TABLE \"Log\" ( " +
                               "\"Id\" INT NOT NULL PRIMARY KEY, " +
                               "\"Level\" VARCHAR(10), " +
                               "\"Info\" VARCHAR(1024), " +
                               "\"FormName\" VARCHAR(50), " +
                               "\"UserId\" INT, " +
                               "\"LogTime\" TIME, " +
                               "\"LogDate\" DATE);";

                log.SQLExecute(procName);
            }
            catch (Exception)
            {

            }

            string generatorCreate = "CREATE GENERATOR \"Seq_LogId\"";

            try
            {
                log.SQLExecute(generatorCreate);
            }
            catch (Exception)
            {

            }

            string trgiCreate = "CREATE OR ALTER TRIGGER \"Log_BI0\" FOR \"Log\"" +
                                        "ACTIVE BEFORE INSERT POSITION 0 " +
                                        "AS " +
                                        "begin " +
                                        "NEW.\"Id\" = NEXT VALUE FOR \"Seq_LogId\";" +
                                        "end";
            try
            {
                log.SQLExecute(trgiCreate);
            }
            catch (Exception)
            {

            }
            
            
           
            return 0;
            //return mapper.Map<IEnumerable<MtsAssembliesInfo>, List<MtsAssembliesInfoDTO>>(mtsAssembliesInfo.SQLExecuteProc(procName, Parameters));
        }

        public bool CheckTable(string tableName)
        {
            string searchTableSQL = "SELECT rdb$relation_name as \"Table\", 1 as \"RecId\" FROM rdb$relations WHERE rdb$relation_name = '"+ tableName + "'";
            List<SearchTableDTO> ssearchTable = mapper.Map<IEnumerable<SearchTable>, List<SearchTableDTO>>(searchTable.SQLExecute(searchTableSQL));
            if (ssearchTable.Count > 0)
                return true;
            else
                return false;
        }

        public int CreateLogRecord(string message, Utils.Level level, UserTasksDTO user, string formName)
        {
            LogDTO logRecord = new LogDTO();

            switch (level)
            {
                case Utils.Level.Error:
                    logRecord.Level = "Error";
                    break;
                case Utils.Level.Info:
                    logRecord.Level = "Info";
                    break;
                case Utils.Level.Warning:
                    logRecord.Level = "Warning";
                    break;
                default:
                    break;
            }

            logRecord.FormName = formName;
            logRecord.Info = message;
            logRecord.LogTime = DateTime.Now;
            logRecord.LogDate = DateTime.Now;
            logRecord.UserId = user.UserId;
            return LogCreate(logRecord);
        }


        public bool CheckDatabase()
        {
            if (Database.CheckDB())
                return true;
            else
                return false;
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
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
        
    }
}
