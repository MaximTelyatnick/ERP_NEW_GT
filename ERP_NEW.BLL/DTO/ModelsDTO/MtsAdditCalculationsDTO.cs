using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MtsAdditCalculationsDTO
    {
        public int Id { get; set; }
        public int UnitId { get; set; }

        public int MtsNomenclatureGroupId { get; set; }
        public string GroupName { get; set; }
        public string AdditUnitLocalName { get; set; }
    }
}
