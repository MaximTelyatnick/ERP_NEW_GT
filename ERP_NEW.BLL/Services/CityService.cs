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
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.Services
{
    public class CityService : ICityService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<City> city;
        private IRepository<Country> country;
        private IRepository<SettlementTypes> settlementTypes;

        private IMapper mapper;

        public CityService(IUnitOfWork uow)
        {
            Database = uow;
            city = Database.GetRepository<City>();
            country = Database.GetRepository<Country>();
            settlementTypes = Database.GetRepository<SettlementTypes>();
                                    
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityDTO>();
                cfg.CreateMap<CityDTO, City>();
                cfg.CreateMap<Country, CountryDTO>();
                cfg.CreateMap<CountryDTO, Country>();
                cfg.CreateMap<SettlementTypes, SettlementTypesDTO>();
                cfg.CreateMap<SettlementTypesDTO, SettlementTypes>(); 
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<CountryDTO> GetCountries()
        {
            return mapper.Map<IEnumerable<Country>, List<CountryDTO>>(country.GetAll());
        }

        public IEnumerable<SettlementTypesDTO> GetSettlementTypes()
        {
            return mapper.Map<IEnumerable<SettlementTypes>, List<SettlementTypesDTO>>(settlementTypes.GetAll());
        }

        public IEnumerable<CityDTO> GetCities()
        {
            var result = (from c in city.GetAll()
                          join co in country.GetAll() on c.Country_Id equals co.Country_Id
                          join t in settlementTypes.GetAll() on c.SettlementTypeId equals t.Id
                          select new CityDTO
                          {
                              Id = c.Id,
                              CityName = c.CityName,
                              CityName_UA = c.CityName_UA,
                              Country_Id = c.Country_Id,
                              CountryName = co.CountryName,
                              CountryName_UA = co.CountryName_UA,
                              FullName = t.FullName,
                              ParentId = c.ParentId,
                              EndRegistrationDate = c.EndRegistrationDate,
                              Description = c.Description,
                              SettlementTypeId = c.SettlementTypeId,
                              FullName_UA = c.CityName_UA + ", " + co.CountryName_UA
                          }).Where(c => c.EndRegistrationDate == null).OrderBy(s => s.CountryName_UA);
            return result.ToList();                    
        }

        public CityDTO GetCityById(int id)
        {
           return mapper.Map<City,CityDTO>(city.GetAll().SingleOrDefault(s => s.Id == id));
        }


        #region City CRUD method's

        public int CityCreate(CityDTO cityDTO)
        {
            var createCity = city.Create(mapper.Map<City>(cityDTO));
            return (int)createCity.Id;
        }
        
        public void CityUpdate(CityDTO cityDTO)
        {
            var updateCity = city.GetAll().SingleOrDefault(c => c.Id == cityDTO.Id);
            city.Update((mapper.Map<CityDTO, City>(cityDTO, updateCity)));
        }

        public bool CityDelete(int id)
        {
            try
            {
                city.Delete(city.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Country CRUD method's

        public int CountryCreate(CountryDTO countryDTO)
        {
            var createCountry = country.Create(mapper.Map<Country>(countryDTO));
            return (int)createCountry.Country_Id;
        }

        public void CountryUpdate(CountryDTO countryDTO)
        {
            var updateCountry = country.GetAll().SingleOrDefault(c => c.Country_Id == countryDTO.Country_Id);
            country.Update((mapper.Map<CountryDTO, Country>(countryDTO, updateCountry)));
        }

        public bool CountryDelete(int id)
        {
            try
            {
                country.Delete(country.GetAll().FirstOrDefault(c => c.Country_Id == id));
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
