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
    public class MtsNomenclaturesService : IMtsNomenclaturesService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<MtsNomenclatures> mtsNomenclatures;
        private IRepository<MtsNomenclatureGroups> mtsNomenclatureGroups;
        private IRepository<MtsGosts> mtsGosts;
        private IRepository<Units> units;
        private IRepository<MtsAdditCalculations> mtsAdditCalculations;
        private IRepository<MtsSpecifications> mtsSpecifications;

        private IMapper mapper;

        public MtsNomenclaturesService(IUnitOfWork uow)
        {
            Database = uow;
            mtsNomenclatures = Database.GetRepository<MtsNomenclatures>();
            mtsNomenclatureGroups = Database.GetRepository<MtsNomenclatureGroups>();
            mtsAdditCalculations = Database.GetRepository<MtsAdditCalculations>();
            mtsGosts = Database.GetRepository<MtsGosts>();
            units = Database.GetRepository<Units>();
            mtsSpecifications = Database.GetRepository<MtsSpecifications>();

            var config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<MtsNomenclatures, MtsNomenclaturesDTO>();
                 cfg.CreateMap<MtsNomenclaturesDTO, MtsNomenclatures>();
                 cfg.CreateMap<MtsNomenclatureGroups, MtsNomenclatureGroupsDTO>();
                 cfg.CreateMap<MtsNomenclatureGroupsDTO, MtsNomenclatureGroups>();
                 cfg.CreateMap<MtsGosts, MtsGostsDTO>();
                 cfg.CreateMap<MtsGostsDTO, MtsGosts>();
                 cfg.CreateMap<Units, UnitsDTO>();
                 cfg.CreateMap<MtsAdditCalculations, MtsAdditCalculationsDTO>();

             });

            mapper = config.CreateMapper();
        }

        #region Get method's

        public IEnumerable<MtsNomenclaturesDTO> GetNomenclarures()
        {
            var result = (from g in mtsNomenclatureGroups.GetAll()
                          join a in mtsAdditCalculations.GetAll() on g.MtsAdditCalculationId equals a.Id into na
                          from a in na.DefaultIfEmpty()
                          join ua in units.GetAll() on a.UnitId equals ua.UnitId into aua
                          from ua in aua.DefaultIfEmpty()
                          join n in mtsNomenclatures.GetAll() on g.Id equals n.MtsNomenclatureGroupId
                          join c in mtsGosts.GetAll() on n.MtsGostId equals c.Id into nc
                          from c in nc.DefaultIfEmpty()
                          join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                          from u in nu.DefaultIfEmpty()
                          select new MtsNomenclaturesDTO
                          {
                              Id = n.Id,
                              MtsNomenclatureGroupId = n.MtsNomenclatureGroupId,
                              MtsGostId = n.MtsGostId,
                              UnitId = n.UnitId,
                              Note = n.Note,
                              Name = n.Name,
                              Gauge = n.Gauge,
                              Weight = n.Weight,
                              Price = n.Price,
                              AdditCalculationActive = g.AdditCalculationActive,
                              GostName = c.Name,
                              GroupName = g.Name,
                              RatioOfWaste = g.RatioOfWaste,
                              UnitLocalName = u.UnitLocalName,
                              AdditUnitLocalName = ua.UnitLocalName
                          });

            return result.ToList();
        }

        public IEnumerable<MtsGostsDTO> GetGosts()
        {
            return mapper.Map<IEnumerable<MtsGosts>, List<MtsGostsDTO>>(mtsGosts.GetAll().OrderBy(s => s.Name));
        }

        public IEnumerable<UnitsDTO> GetUnits()
        {
            return mapper.Map<IEnumerable<Units>, List<UnitsDTO>>(units.GetAll().OrderBy(s => s.UnitLocalName));
        }

        public IEnumerable<MtsAdditCalculationsDTO> GetAdditCalculationUnits()
        {
            var result = (from g in mtsAdditCalculations.GetAll()
                          join ua in units.GetAll() on g.UnitId equals ua.UnitId into aua
                          from ua in aua.DefaultIfEmpty()
                          select new MtsAdditCalculationsDTO
                          {
                              Id = g.Id,
                              UnitId = ua.UnitId,
                              AdditUnitLocalName = ua.UnitLocalName
                          });

            return result.ToList();
        }

        public IEnumerable<MtsNomenclatureGroupsDTO> GetNomenclatureGroups()
        {
            var result = (from g in mtsNomenclatureGroups.GetAll()
                          join a in mtsAdditCalculations.GetAll() on g.MtsAdditCalculationId equals a.Id into na
                          from a in na.DefaultIfEmpty()
                          join ua in units.GetAll() on a.UnitId equals ua.UnitId into aua
                          from ua in aua.DefaultIfEmpty()
                          orderby g.Name
                          select new MtsNomenclatureGroupsDTO
                          {
                              Id = g.Id,
                              Name = g.Name,
                              AdditCalculationActive = g.AdditCalculationActive,
                              RatioOfWaste = g.RatioOfWaste,
                              AdditUnitLocalName = ua.UnitLocalName,
                              MtsAdditCalculationId = g.MtsAdditCalculationId
                          });

            return result.ToList();
        }

        public IEnumerable<MtsNomenclaturesDTO> GetMaterialsBySpecificationId(long specId, short materialStatus) //1 - PurchasedProducts, 2 - Materials
        {
            var result = (from n in mtsNomenclatures.GetAll()
                          join s in mtsSpecifications.GetAll() on n.Id equals s.MtsMaterialId
                          join ng in mtsNomenclatureGroups.GetAll() on n.MtsNomenclatureGroupId equals ng.Id into nng
                          from ng in nng.DefaultIfEmpty()
                          join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                          from u in nu.DefaultIfEmpty()
                          join go in mtsGosts.GetAll() on n.MtsGostId equals go.Id into ngo
                          from go in ngo.DefaultIfEmpty()
                          where s.ParentId == specId && s.MaterialStatus == materialStatus
                          select new MtsNomenclaturesDTO()
                          {
                              Id = n.Id,
                              AdditCalculationActive = ng.AdditCalculationActive,
                              Gauge = n.Gauge,
                              GostName = go.Name,
                              GroupName = ng.Name,
                              MtsGostId = n.MtsGostId,
                              MtsNomenclatureGroupId = n.MtsNomenclatureGroupId,
                              Name = n.Name,
                              Note = n.Note,
                              Price = n.Price,
                              RatioOfWaste = ng.RatioOfWaste,
                              UnitId = n.UnitId,
                              UnitLocalName = u.UnitLocalName,
                              Weight = n.Weight,
                              Quantity = s.Quantity,
                              CheckForSelected = false
                          }
                );

            return result.ToList();
        }

        #endregion

        #region Nomenclatures CRUD method's

        public long NomenclarureCreate(MtsNomenclaturesDTO mtsNomenclature)
        {
            var createrecord = mtsNomenclatures.Create(mapper.Map<MtsNomenclatures>(mtsNomenclature));
            return (long)createrecord.Id;
        }

        public void NomenclarureUpdate(MtsNomenclaturesDTO mtsNomenclature)
        {
            var eGroup = mtsNomenclatures.GetAll().SingleOrDefault(c => c.Id == mtsNomenclature.Id);
            mtsNomenclatures.Update((mapper.Map<MtsNomenclaturesDTO, MtsNomenclatures>(mtsNomenclature, eGroup)));
        }

        public bool NomenclarureDelete(long id)
        {
            try
            {
                mtsNomenclatures.Delete(mtsNomenclatures.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MtsNomenclatureGroups CRUD method's

        public int NomenclarureGroupCreate(MtsNomenclatureGroupsDTO mtsNomenclatureGroup)
        {
            var createrecord = mtsNomenclatureGroups.Create(mapper.Map<MtsNomenclatureGroups>(mtsNomenclatureGroup));
            return (int)createrecord.Id;
        }

        public void NomenclarureGroupUpdate(MtsNomenclatureGroupsDTO mtsNomenclatureGroup)
        {
            var eGroup = mtsNomenclatureGroups.GetAll().SingleOrDefault(c => c.Id == mtsNomenclatureGroup.Id);
            mtsNomenclatureGroups.Update((mapper.Map<MtsNomenclatureGroupsDTO, MtsNomenclatureGroups>(mtsNomenclatureGroup, eGroup)));
        }

        public bool NomenclarureGroupDelete(int id)
        {
            try
            {
                mtsNomenclatureGroups.Delete(mtsNomenclatureGroups.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MtsGosts CRUD method's
        
        public long GostCreate(MtsGostsDTO mtsGost)
        {
            var createrecord = mtsGosts.Create(mapper.Map<MtsGosts>(mtsGost));
            return (long)createrecord.Id;
        }

        public void GostUpdate(MtsGostsDTO mtsGost)
        {

            var eGroup = mtsGosts.GetAll().SingleOrDefault(c => c.Id == mtsGost.Id);
            mtsGosts.Update((mapper.Map<MtsGostsDTO, MtsGosts>(mtsGost, eGroup)));
        }

        public bool GostDelete(long id)
        {
            try
            {
                mtsGosts.Delete(mtsGosts.GetAll().FirstOrDefault(c => c.Id == id));
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
