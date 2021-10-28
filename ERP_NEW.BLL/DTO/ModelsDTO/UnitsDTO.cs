using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class UnitsDTO : ObjectBase
    {
        public int UnitId { get; set; }
        public string UnitCode { get; set; }
        public string UnitFullName { get; set; }
        public string UnitLocalName { get; set; }
    }
}
