using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class AccountClothesInfo
    {
        public int Id { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int EmployeeID { get; set; }
        public string Profession { get; set; }
        public decimal AccountNumber { get; set; }
        public string EmployeeFullName { get; set; }
        public string ResponsibleFullName { get; set; }
        public string Department { get; set; }
    }
}
