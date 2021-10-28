using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AccessScheduleEntityDTO
    {
        public int EntityID { get; set; }
        public int OwnerID { get; set; }
        public int OwnerType { get; set; }
        public DateTime StartDate { get; set; }
        public int Override { get; set; }
        public int? ParentID { get; set; }
    }
}
