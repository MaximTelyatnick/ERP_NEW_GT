using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Internal;
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
    public class DefectActsService : IDefectActsService
    {
        private IUnitOfWork Database { get; set; }
        private IMapper mapper;

        private IRepository<DefectActs> defectActs;
        private IRepository<DefectActReplies> defectActReplies;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<DocumentTypes> documentTypes;
        private IRepository<MtsAssemblies> mtsAssemblies;

        public DefectActsService(IUnitOfWork uow)
        {
            Database = uow;
            defectActs = Database.GetRepository<DefectActs>();
            defectActReplies = Database.GetRepository<DefectActReplies>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            documentTypes = Database.GetRepository<DocumentTypes>();
            mtsAssemblies = Database.GetRepository<MtsAssemblies>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DefectActs, DefectActsDTO>();
                cfg.CreateMap<DefectActsDTO, DefectActs>();
                cfg.CreateMap<DocumentTypes, DocumentTypesDTO>();
                cfg.CreateMap<DocumentTypesDTO, DocumentTypesDTO>();
                cfg.CreateMap<DefectActReplies, DefectActRepliesDTO>();
                cfg.CreateMap<DefectActRepliesDTO, DefectActReplies>();
            });

            mapper = config.CreateMapper();
        }

        #region GET method`s

        public IEnumerable<DefectActsDTO> GetDefectActs(DateTime beginDate, DateTime endDate)
        {
            var result = (from d in defectActs.GetAll()
                          join a in mtsAssemblies.GetAll() on d.MtsAssemblyId equals a.Id into da
                          from a in da.DefaultIfEmpty()
                          join c in customerOrders.GetAll() on d.CustomerOrderId equals c.Id into ac
                          from c in ac.DefaultIfEmpty()
                          where (d.ActDate >= beginDate && d.ActDate <= endDate)
                          select new DefectActsDTO
                          {
                              Id = d.Id,
                              MtsAssemblyId = d.MtsAssemblyId,
                              ActDate = d.ActDate,
                              ActNumber = d.ActNumber,
                              Description = d.Description,
                              Details = d.Details,
                              FileName = d.FileName,
                              ActScan = d.ActScan,
                              AssemblyDrawing = a.Drawing,
                              AssemblyName = a.Name,
                              OrderDate = c.OrderDate,
                              OrderNumber = c.OrderNumber
                          }).ToList();

            return result.Select(s => { s.ScanPersence = (s.ActScan.Length > 0 ? 1 : 0); return s; }).ToList();
        }

        public IEnumerable<DefectActRepliesDTO> GetDefectActReplies(int id)
        {
            var result = (from d in defectActReplies.GetAll()
                          join dt in documentTypes.GetAll() on d.DocumentTypeId equals dt.DocumentTypeId into ddt
                          from dt in ddt.DefaultIfEmpty()
                          where d.DefectActId == id
                          select new DefectActRepliesDTO
                          {
                              Id = d.Id,
                              DocumentNumber = d.DocumentNumber,
                              DocumentDate = d.DocumentDate,
                              DocumentScan = d.DocumentScan,
                              FileName = d.FileName,
                              DefectActId = d.DefectActId,
                              Description = d.Description,
                              Details = d.Details,
                              DocumentTypeId = dt.DocumentTypeId,
                              DocumentTypeName = dt.DocumentTypeName
                          }).ToList();

            return result.Select(s => { s.ScanPersence = (s.DocumentScan.Length > 0 ? 1 : 0); return s; }).ToList();
        }

        #endregion

        #region DefectActs CRUD method`s

        public int CreateDefectAct(DefectActsDTO dtomodel)
        {
            var record = defectActs.Create(mapper.Map<DefectActs>(dtomodel));
            return record.Id;
        }

        public void UpdateDefectAct(DefectActsDTO dtomodel)
        {
            var entity = defectActs.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            defectActs.Update(mapper.Map<DefectActsDTO, DefectActs>(dtomodel, entity));
        }

        public bool RemoveDefectActById(long id)
        {
            try
            {
                var delEntity = defectActs.GetAll().SingleOrDefault(c => c.Id == id);
                defectActs.Delete(delEntity);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region DefectActsReplies CRUD method's

        public int CreateDefectActReplie(DefectActRepliesDTO dtomodel)
        {
            var record = defectActReplies.Create(mapper.Map<DefectActReplies>(dtomodel));
            return record.Id;
        }

        public void UpdateDefectActReplie(DefectActRepliesDTO dtomodel)
        {
            var entity = defectActReplies.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            defectActReplies.Update(mapper.Map<DefectActRepliesDTO, DefectActReplies>(dtomodel, entity));
        }

        public bool RemoveDefectActReplieById(long id)
        {
            try
            {
                var delEntity = defectActReplies.GetAll().SingleOrDefault(c => c.Id == id);
                defectActReplies.Delete(delEntity);
                return true;

            }
            catch (Exception)
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
