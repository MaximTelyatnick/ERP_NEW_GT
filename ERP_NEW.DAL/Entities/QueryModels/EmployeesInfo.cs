using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
   public  class EmployeesInfo
    {
        [Key] 
        public int EmployeeID { get; set; }
        public decimal AccountNumber { get; set; }
        public string Fio { get; set; }
        public string FullName { get; set; }
        public int? ProfessionID { get; set; }
        public int? DepartmentID { get; set; }
        public string ProfessionName { get; set; }
        public string DepartmentName { get; set; }
        public byte[] UserPhoto { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string CreditCardNumber { get; set; }
        public string Gender { get; set; }
        public int EntityID { get; set; }
        public int RecordID { get; set; }
        //public int? SupplierId { get; set; }
    }
}
