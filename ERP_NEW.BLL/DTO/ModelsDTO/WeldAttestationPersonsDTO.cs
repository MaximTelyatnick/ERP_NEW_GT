using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class WeldAttestationPersonsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int WeldAttestationId { get; set; }
        public int EmployeeId { get; set; }
    }
}
