using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MtsNomenclaturesDTO : ObjectBase
    {
        public long Id { get; set; }
        public long MtsGostId { get; set; }
        public int UnitId { get; set; }
        public int MtsNomenclatureGroupId { get; set; }
        public string Name { get; set; }
        public string Gauge { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Price { get; set; }
        public string Note { get; set; }

        public decimal? Quantity { get; set; }
        public string UnitLocalName { get; set; }
        public string GroupName { get; set; }
        public string GostName { get; set; }
        public decimal? RatioOfWaste { get; set; }
        public int? AdditCalculationActive { get; set; }
        public string AdditUnitLocalName { get; set; }
        public bool CheckForSelected { get; set; }
    }
}
