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
    public class UnitsService : IUnitsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Units> units;

        private IMapper mapper;

        public UnitsService(IUnitOfWork uow)
        {
            Database = uow;
            units = Database.GetRepository<Units>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Units, UnitsDTO>();
                cfg.CreateMap<UnitsDTO, Units>();

            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<UnitsDTO> GetUnits()
        {
            return mapper.Map<IEnumerable<Units>, List<UnitsDTO>>(units.GetAll().OrderBy(s => s.UnitFullName));

        }
        
        public int UnitCreate(UnitsDTO unit)
        {
            var createrecord = units.Create(mapper.Map<Units>(unit));
            return (int)createrecord.UnitId;
        }

        public void UnitUpdate(UnitsDTO unit)
        {

            var eGroup = units.GetAll().SingleOrDefault(c => c.UnitId== unit.UnitId);
            units.Update((mapper.Map<UnitsDTO, Units>(unit, eGroup)));
        }

        public bool UnitDelete(int id)
        {
            try
            {
                units.Delete(units.GetAll().FirstOrDefault(c => c.UnitId == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
