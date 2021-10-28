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
    public class RequestLogService : IRequestLogService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<RequestLogJournal> requestLogJournal;
        private IRepository<RequestLog> requestLog;
        private IRepository<RequestLogContractors> requestLogContractors;
        private IRepository<Colors> colors;


        private IMapper mapper;

        public RequestLogService(IUnitOfWork uow)
        {
            Database = uow;
            requestLogJournal = Database.GetRepository<RequestLogJournal>();
            requestLog = Database.GetRepository<RequestLog>();
            requestLogContractors = Database.GetRepository<RequestLogContractors>();
            colors = Database.GetRepository<Colors>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RequestLogJournal, RequestLogJournalDTO>();
                cfg.CreateMap<RequestLogJournalDTO, RequestLogJournal>();
                cfg.CreateMap<RequestLog, RequestLogDTO>();
                cfg.CreateMap<RequestLogDTO, RequestLog>();
                cfg.CreateMap<RequestLogContractors, RequestLogContractorsDTO>();
                cfg.CreateMap<RequestLogContractorsDTO, RequestLogContractors>();
                cfg.CreateMap<Colors, ColorsDTO>();

            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<RequestLogJournalDTO> GetRequestLogProc(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parametrs =
            {
                new FbParameter("StartDate",beginDate),
                new FbParameter("EndDate",endDate)
            
            };
            string procName = @"select * from ""GetRequestLogProc""( @StartDate, @EndDate)";

            return mapper.Map<IEnumerable<RequestLogJournal>, List<RequestLogJournalDTO>>(requestLogJournal.SQLExecuteProc(procName, Parametrs));
        }

        public IEnumerable<RequestLogContractorsDTO> GetRequestLogContractors()
        {
            return mapper.Map<IEnumerable<RequestLogContractors>, List<RequestLogContractorsDTO>>(requestLogContractors.GetAll());
        }

       
        public IEnumerable<RequestLogDTO> GetRequestLog()
        {
            return mapper.Map<IEnumerable<RequestLog>, List<RequestLogDTO>>(requestLog.GetAll());
        }

        public IEnumerable<ColorsDTO> GetColors()
        {
            return mapper.Map<IEnumerable<Colors>, List<ColorsDTO>>(colors.GetAll());
        }

        #region RequestLog CRUD method's

        public int RequestLogCreate(RequestLogDTO requestLogDTO)
        {
            var createRequestLog = requestLog.Create(mapper.Map<RequestLog>(requestLogDTO));
            return (int)createRequestLog.Id;
        }
        public void RequestLogUpdate(RequestLogDTO requestLogDTO)
        {
            var updateRequestLog = requestLog.GetAll().SingleOrDefault(c => c.Id == requestLogDTO.Id);
            requestLog.Update((mapper.Map<RequestLogDTO, RequestLog>(requestLogDTO, updateRequestLog)));
        }
        public bool RequestLogDelete(int id)
        {
            try
            {
                requestLog.Delete(requestLog.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //-----------------
        public int RequestLogConractorCreate(RequestLogContractorsDTO requestLogContractorDTO)
        {
            var createRequestLogContractor = requestLogContractors.Create(mapper.Map<RequestLogContractors>(requestLogContractorDTO));
            return (int)createRequestLogContractor.Id;
        }
        public void RequestLogContractorUpdate(RequestLogContractorsDTO requestLogContractorDTO)
        {
            var updateRequestLogContractor = requestLogContractors.GetAll().SingleOrDefault(c => c.Id == requestLogContractorDTO.Id);
            requestLogContractors.Update((mapper.Map<RequestLogContractorsDTO, RequestLogContractors>(requestLogContractorDTO, updateRequestLogContractor)));
        }
        public bool RequestLogContractorDelete(int id)
        {
            try
            {
                requestLogContractors.Delete(requestLogContractors.GetAll().FirstOrDefault(c => c.Id == id));
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
