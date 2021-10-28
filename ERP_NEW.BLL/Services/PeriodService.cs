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
    public class PeriodService : IPeriodService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Periods> periods;
   
        private IMapper mapper;
       
        public static IEnumerable<UserTasksDTO> AuthorizatedUserAccess { get; internal set; }

        public PeriodService(IUnitOfWork uow)
        {
            Database = uow;
            periods = Database.GetRepository<Periods>();
           
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Periods, PeriodsDTO>();
                cfg.CreateMap<PeriodsDTO, Periods>();
            });
            mapper = config.CreateMapper();
        }

        public IEnumerable<PeriodsDTO> GetAllPeriods()
        {
            return mapper.Map<IEnumerable<Periods>, List<PeriodsDTO>>(periods.GetAll().OrderByDescending(y => y.Year).ThenByDescending(m => m.Month));
        }

        public PeriodsDTO GetPeriodByKey(int year, int month)
        {
            return (mapper.Map<IEnumerable<Periods>, List<PeriodsDTO>>(periods.GetAll().Where(p => p.Year == year && p.Month == month))).SingleOrDefault();
        }

        public bool CheckPeriodAccess(DateTime currentDate)
        {
            return GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.State);
        }

        public bool CheckPeriodExist(DateTime currentDate)
        {
            return GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }

        public bool CheckPeriodTaxInvoicesAccess(DateTime currentDate)
        {
            return GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month && p.StateTaxInvoices);
        }

        public bool CheckPeriodTaxInvoicesExist(DateTime currentDate)
        {
            return GetAllPeriods().Any(p => p.Year == currentDate.Year && p.Month == currentDate.Month);
        }


        #region Periods CRUD method's                                  

        public int PeriodsCreate(PeriodsDTO pdto)
        {
            var createPeriod = periods.Create(mapper.Map<Periods>(pdto));
            return (int)createPeriod.Id;
        }

        public void PeriodsUpdate(PeriodsDTO pdto)
        {
            var updatePeriod = periods.GetAll().SingleOrDefault(c => c.Id == pdto.Id);
            periods.Update((mapper.Map<PeriodsDTO, Periods>(pdto, updatePeriod)));
        }

        #endregion

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
