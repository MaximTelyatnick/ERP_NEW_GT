using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   public  class CityDTO : ObjectBase
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityName_UA { get; set; }
        public int Country_Id { get; set; }
        public string CountryName { get; set; }
        public string CountryName_UA { get; set; }
        public string FullName { get; set; }
        public string FullName_UA { get; set; }
        public int? ParentId { get; set; }
        public DateTime? EndRegistrationDate { get; set; }
        public string Description { get; set; }
        public short SettlementTypeId { get; set; }
    }
}
