using ERP_NEW.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface ICityService
    {
        IEnumerable<CityDTO> GetCities();
        IEnumerable<CountryDTO> GetCountries();
        IEnumerable<SettlementTypesDTO> GetSettlementTypes();
        CityDTO GetCityById(int id);

        int CityCreate(CityDTO cityDTO);
        void CityUpdate(CityDTO cityDTO);
        bool CityDelete(int id);

        int CountryCreate(CountryDTO countryDTO);
        void CountryUpdate(CountryDTO countryDTO);
        bool CountryDelete(int id);

        void Dispose();
    }
}
