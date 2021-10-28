using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class WeldAttestationsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string AttestationNumber { get; set; }
        public DateTime AttestationDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }

        public string AttestationInfo { get; set; }
        public string ResponsiblePersonName { get; set; }
        public string EmployeesFio { get; set; }
        public int AccountNumber { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public string StampNumber { get; set; }
        public DateTime StampDate { get; set; }
        public DateTime BeginStampDate { get; set; }
        public DateTime EndStampDate { get; set; }
    }
}
