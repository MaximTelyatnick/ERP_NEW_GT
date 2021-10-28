using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class WeldAttestationPersonsInfo
    {
        [Key]
        public int RecId { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int AttestationPersonId { get; set; }
        public string AttestationNumber { get; set; }
        public DateTime AttestationDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public string ResponsiblePersonName { get; set; }
        public int EmployeesID { get; set; }
        public string EmployeesFio { get; set; }
        public int AccountNumber { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StampNumber { get; set; }
        public DateTime? StampDate { get; set; }
        public DateTime? BeginStampDate { get; set; }
        public DateTime? EndStampDate { get; set; }
        public int EmployeeCertificateEntry { get; set; }

    }
}
