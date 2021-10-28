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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.Services
{
    public class WeldStampsService : IWeldStampsService
    {
        private IUnitOfWork Database { get; set; }
        
        private IRepository<WeldWps> weldWps;
        private IRepository<WeldStamps> weldStamps;
        private IRepository<WeldStampJournal> weldStampJournal;
        private IRepository<WeldStampJournalInfo> weldStampJournalInfo;
        private IRepository<WeldAttestations> weldAttestations;
        private IRepository<WeldAttestationPersons> weldAttestationPersons;
        private IRepository<WeldPersonsWps> weldPersonsWps;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<EmployeesInfo> employeesInfo;
        private IRepository<EmployeesForWeld> employeesForWeld;
        private IRepository<Professions> professions;
        private IRepository<WeldAttestationPersonsInfo> weldAttestationPersonsInfo;
        private IRepository<WeldAttestationTreeInfo> weldAttestationTreeInfo;
        private IRepository<WeldCertificates> weldCertificates;
        private IRepository<EmployeeCertificates> employeeCertificates;
        private IRepository<DocumentTypes> documentTypes;

        private IMapper mapper;

        public WeldStampsService(IUnitOfWork uow)
        {
            Database = uow;

            weldWps = Database.GetRepository<WeldWps>();
            weldStamps = Database.GetRepository<WeldStamps>();
            weldStampJournal = Database.GetRepository<WeldStampJournal>();
            weldStampJournalInfo = Database.GetRepository<WeldStampJournalInfo>();
            weldAttestations = Database.GetRepository<WeldAttestations>();
            weldAttestationPersons = Database.GetRepository<WeldAttestationPersons>();
            weldPersonsWps = Database.GetRepository<WeldPersonsWps>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            employeesInfo = Database.GetRepository<EmployeesInfo>();
            employeesForWeld = Database.GetRepository<EmployeesForWeld>();
            professions = Database.GetRepository<Professions>();
            weldAttestationPersonsInfo = Database.GetRepository<WeldAttestationPersonsInfo>();
            weldAttestationTreeInfo = Database.GetRepository<WeldAttestationTreeInfo>();
            weldCertificates = Database.GetRepository<WeldCertificates>();
            employeeCertificates = Database.GetRepository<EmployeeCertificates>();
            documentTypes = Database.GetRepository<DocumentTypes>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<WeldWps, WeldWpsDTO>();
                cfg.CreateMap<WeldWpsDTO, WeldWps>();
                cfg.CreateMap<WeldStamps, WeldStampsDTO>();
                cfg.CreateMap<WeldStampsDTO, WeldStamps>();
                cfg.CreateMap<WeldStampJournal, WeldStampJournalDTO>();
                cfg.CreateMap<WeldStampJournalDTO, WeldStampJournal>();
                cfg.CreateMap<WeldAttestations, WeldAttestationsDTO>();
                cfg.CreateMap<WeldAttestationsDTO, WeldAttestations>();
                cfg.CreateMap<WeldAttestationPersons, WeldAttestationPersonsDTO>();
                cfg.CreateMap<WeldAttestationPersonsDTO, WeldAttestationPersons>();
                cfg.CreateMap<WeldPersonsWps, WeldPersonsWpsDTO>();
                cfg.CreateMap<WeldPersonsWpsDTO, WeldPersonsWps>();
                cfg.CreateMap<WeldAttestationPersonsInfo, WeldAttestationPersonsInfoDTO>();
                cfg.CreateMap<EmployeesInfo, EmployeesInfoDTO>();
                cfg.CreateMap<EmployeesForWeld, EmployeesForWeldDTO>();
                cfg.CreateMap<WeldStampJournalInfo, WeldStampJournalInfoDTO>();
                cfg.CreateMap<WeldAttestationTreeInfo, WeldAttestationTreeInfoDTO>();
                cfg.CreateMap<WeldCertificates, WeldCertificatesDTO>();
                cfg.CreateMap<WeldCertificatesDTO, WeldCertificates>();
                cfg.CreateMap<EmployeeCertificates, EmployeeCertificatesDTO>();
                cfg.CreateMap<EmployeeCertificatesDTO, EmployeeCertificates>();
                cfg.CreateMap<DocumentTypes, DocumentTypesDTO>();
            });

            mapper = config.CreateMapper();
        }

        #region Get method's

        public IEnumerable<WeldWpsDTO> GetWeldWps()
        {
            var query = mapper.Map<IEnumerable<WeldWps>, List<WeldWpsDTO>>(weldWps.GetAll());

            var result = (from w in query
                          select new WeldWpsDTO
                           {
                               Id = w.Id,
                               SeamSizeZ = w.SeamSizeZ,
                               SeamSizeA = w.SeamSizeA,
                               WireDiameter = w.WireDiameter,
                               MaterialThickness = w.MaterialThickness,
                               Wpqr = w.Wpqr,
                               Wps = w.Wps,
                               LayerMark = w.LayerMark,
                               ConnectionType = w.ConnectionType,
                               WeldPosition = w.WeldPosition,
                               EnumConnectionType = (Utils.ConnectionType)Enum.Parse(typeof(Utils.ConnectionType), w.ConnectionType),
                               EnumWeldPosition = (Utils.WeldPosition)Enum.Parse(typeof(Utils.WeldPosition), w.WeldPosition)
                           });

            return result.ToList();
        }

        public IEnumerable<WeldStampsDTO> GetWeldStamps()
        {
            return mapper.Map<IEnumerable<WeldStamps>, List<WeldStampsDTO>>(weldStamps.GetAll());
        }

        public IEnumerable<WeldWpsDTO> GetWeldWpsByAttestationPersonId(int weldAttestationPersonId)
        {
            var result = (from wp in weldPersonsWps.GetAll()
                          join wps in weldWps.GetAll() on wp.WeldWpsId equals wps.Id into wpwps
                          from wps in wpwps.DefaultIfEmpty()
                          where wp.WeldAttestationPersonId == weldAttestationPersonId
                          select new WeldWpsDTO()
                          {
                              Id = wps.Id,
                              WeldPosition = wps.WeldPosition,
                              ConnectionType = wps.ConnectionType,
                              LayerMark = wps.LayerMark,
                              MaterialThickness = wps.MaterialThickness,
                              SeamSizeA = wps.SeamSizeA,
                              SeamSizeZ = wps.SeamSizeZ,
                              WireDiameter = wps.WireDiameter,
                              Wpqr = wps.Wpqr,
                              Wps = wps.Wps,
                              CheckForDelete = false,
                              WeldPersonWpsId = wp.Id
                          }
                );
            
            return result.ToList();
        }

        public IEnumerable<WeldAttestationPersonsInfoDTO> GetWeldAttestationWithPersons()
        {
            string procName = @"select * from ""GetWeldAttestationsWithPersons""";

            return mapper.Map<IEnumerable<WeldAttestationPersonsInfo>, List<WeldAttestationPersonsInfoDTO>>(weldAttestationPersonsInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<WeldAttestationTreeInfoDTO> GetWeldAttestationForTree()
        {
            string procName = @"select * from ""GetWeldAttestations""";

            return mapper.Map<IEnumerable<WeldAttestationTreeInfo>, List<WeldAttestationTreeInfoDTO>>(weldAttestationTreeInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<WeldAttestationsDTO> GetWeldAttestations()
        {
            return mapper.Map<IEnumerable<WeldAttestations>, List<WeldAttestationsDTO>>(weldAttestations.GetAll());
        }

        public IEnumerable<WeldStampJournalInfoDTO> GetWeldStampJournalByPeriod(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("_BeginDate", beginDate),
                    new FbParameter("_EndDate", endDate)
                };

            string procName = @"select * from ""GetWeldStampJournalByPeriod""(@_BeginDate, @_EndDate)";

            return mapper.Map<IEnumerable<WeldStampJournalInfo>, List<WeldStampJournalInfoDTO>>(weldStampJournalInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<EmployeesForWeldDTO> GetEmployeesByWeldAttestations()
        {
            string procName = @"select * from ""GetEmployeesByWeldAttestations""";
            return mapper.Map<IEnumerable<EmployeesForWeld>, List<EmployeesForWeldDTO>>(employeesForWeld.SQLExecuteProc(procName));
        }

        public IEnumerable<WeldStampJournalDTO> GetWeldStampJournals()
        {
            return mapper.Map<IEnumerable<WeldStampJournal>, List<WeldStampJournalDTO>>(weldStampJournal.GetAll());
        }

        public WeldCertificatesDTO GetWeldCertificateById(int id)
        {
            return mapper.Map<WeldCertificates, WeldCertificatesDTO>(weldCertificates.GetAll().SingleOrDefault(w => w.Id == id)); 
        }

        public EmployeeCertificatesDTO GetEmployeesCertificateById(int id)
        {
            return mapper.Map<EmployeeCertificates, EmployeeCertificatesDTO>(employeeCertificates.GetAll().SingleOrDefault(w => w.Id == id)); 
        }

        public List<EmployeeCertificatesDTO> GetEmployeesDocuments(int employeeId)
        {
                var result = (from ep in employeeCertificates.GetAll()
                          join tp in documentTypes.GetAll() on ep.DocumentTypeId equals tp.DocumentTypeId into ect
                          from tp in ect.DefaultIfEmpty()
                          where ep.EmployeeId == employeeId
                          where tp.DocumentKind == 2

                          select new EmployeeCertificatesDTO()
                          {
                             Id = ep.Id,
                             EmployeeId = ep.EmployeeId,
                             FileName = ep.FileName,
                             DocumentTypeId = ep.DocumentTypeId,
                             DocumentTypeName = tp.DocumentTypeName,
                             CheckForDelete = false
                          }
               );

            return result.ToList();
        }


        #endregion

        #region WeldWps CRUD method's

        public int CreateWeldWps(WeldWpsDTO dtomodel)
        {
            var record = weldWps.Create(mapper.Map<WeldWps>(dtomodel));
            return record.Id;
        }

        public void UpdateWeldWps(WeldWpsDTO dtomodel)
        {
            var entity = weldWps.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            weldWps.Update(mapper.Map<WeldWpsDTO, WeldWps>(dtomodel, entity));
        }
        
        public bool RemoveWeldWpsById(int id)
        {
            try
            {
                var delEntity = weldWps.GetAll().SingleOrDefault(c => c.Id == id);
                weldWps.Delete(delEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region WeldCertificates CRUD method's

        public int CreateWeldCertificate(WeldCertificatesDTO dtomodel)
        {
            var record = weldCertificates.Create(mapper.Map<WeldCertificates>(dtomodel));
            return record.Id;
        }

        public void UpdateWeldCertificate(WeldCertificatesDTO dtomodel)
        {
            var entity = weldCertificates.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            weldCertificates.Update(mapper.Map<WeldCertificatesDTO, WeldCertificates>(dtomodel, entity));
        }

        public bool RemoveWeldCertificateById(int id)
        {
            try
            {
                var delEntity = weldCertificates.GetAll().SingleOrDefault(c => c.Id == id);
                weldCertificates.Delete(delEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region EmployeeCertificates CRUD method's

        public int CreateEmployeeCertificate(EmployeeCertificatesDTO dtomodel)
        {
            var record = employeeCertificates.Create(mapper.Map<EmployeeCertificates>(dtomodel));
            return record.Id;
        }

        public void UpdateEmployeeCertificate(EmployeeCertificatesDTO dtomodel)
        {
            var entity = employeeCertificates.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            employeeCertificates.Update(mapper.Map<EmployeeCertificatesDTO, EmployeeCertificates>(dtomodel, entity));
        }

        public bool RemoveEmployeeCertificateById(int id)
        {
            try
            {
                var delEntity = employeeCertificates.GetAll().SingleOrDefault(c => c.Id == id);
                employeeCertificates.Delete(delEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region WeldStamps CRUD method's

        public int CreateWeldStamps(WeldStampsDTO dtomodel)
        {
            var record = weldStamps.Create(mapper.Map<WeldStamps>(dtomodel));
            return record.Id;
        }

        public void UpdateWeldStamps(WeldStampsDTO dtomodel)
        {
            var entity = weldStamps.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            weldStamps.Update(mapper.Map<WeldStampsDTO, WeldStamps>(dtomodel, entity));
        }

        public bool RemoveWeldStampsById(int id)
        {
            try
            {
                var delEntity = weldStamps.GetAll().SingleOrDefault(c => c.Id == id);
                weldStamps.Delete(delEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region WeldStampJournal CRUD method's

        public int CreateWeldStampJournal(WeldStampJournalDTO dtomodel)
        {
            var record = weldStampJournal.Create(mapper.Map<WeldStampJournal>(dtomodel));
            return record.Id;
        }
        
        public void UpdateWeldStampJournal(WeldStampJournalDTO dtomodel)
        {
            var entity = weldStampJournal.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            weldStampJournal.Update(mapper.Map<WeldStampJournalDTO, WeldStampJournal>(dtomodel, entity));
        }
        
        public bool RemoveWeldStampJournalById(int id)
        {
            try
            {
                var delEntity = weldStampJournal.GetAll().SingleOrDefault(c => c.Id == id);
                weldStampJournal.Delete(delEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        #endregion

        #region WeldAttestations CRUD method's

        public int CreateWeldAttestations(WeldAttestationsDTO dtomodel)
        {
            var record = weldAttestations.Create(mapper.Map<WeldAttestations>(dtomodel));
            return record.Id;
        }

        public void UpdateWeldAttestations(WeldAttestationsDTO dtomodel)
        {
            var entity = weldAttestations.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            weldAttestations.Update(mapper.Map<WeldAttestationsDTO, WeldAttestations>(dtomodel, entity));
        }

        public bool RemoveWeldAttestationsById(int id)
        {
            try
            {
                var delEntity = weldAttestations.GetAll().SingleOrDefault(c => c.Id == id);
                weldAttestations.Delete(delEntity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            } 
        }

        #endregion

        #region WeldAttestationPersons CRUD method's

        public int CreateWeldAttestationPersons(WeldAttestationPersonsDTO dtomodel)
        {
            var record = weldAttestationPersons.Create(mapper.Map<WeldAttestationPersons>(dtomodel));
            return record.Id;
        }

        public void CreateRangeWeldAttestationPersons(List<WeldAttestationPersonsDTO> source)
        {
            weldAttestationPersons.CreateRange(mapper.Map<List<WeldAttestationPersonsDTO>, IEnumerable<WeldAttestationPersons>>(source)); 
        }

        public void UpdateWeldAttestationPersons(WeldAttestationPersonsDTO dtomodel)
        {
            var entity = weldAttestationPersons.GetAll().SingleOrDefault(c => c.Id == dtomodel.Id);
            weldAttestationPersons.Update(mapper.Map<WeldAttestationPersonsDTO, WeldAttestationPersons>(dtomodel, entity));
        }

        public bool RemoveRangeWeldAttestationsPersons(List<WeldAttestationPersonsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = weldAttestationPersons.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    weldAttestationPersons.Delete(deleteModel);
                }
                
                
                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }
         }

        #endregion

        #region WeldPersonsWps CRUD method's

        public void CreateRangeWeldPersonsWps(List<WeldPersonsWpsDTO> source)
        {
            weldPersonsWps.CreateRange(mapper.Map<List<WeldPersonsWpsDTO>, IEnumerable<WeldPersonsWps>>(source)); 
        }

        public bool RemoveRangeWeldPersonsWps(List<WeldPersonsWpsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = weldPersonsWps.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    weldPersonsWps.Delete(deleteModel);
                }

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
