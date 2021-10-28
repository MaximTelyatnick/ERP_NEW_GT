using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AccountClothesDTO : ObjectBase
    {
        public int Id { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int EmployeeId { get; set; }
        public string Profession { get; set; }
        public string EmployeeFullName { get; set; }
        public string ResponsibleFullName { get; set; }
        public string Department { get; set; }
       
    }
}
