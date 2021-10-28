using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MtsNomenclatureGroupsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? MtsAdditCalculationId { get; set; }
        public string Name { get; set; }
        public decimal? RatioOfWaste { get; set; }
        public short? AdditCalculationActive { get; set; }

        public string AdditUnitLocalName { get; set; }
    }
}
