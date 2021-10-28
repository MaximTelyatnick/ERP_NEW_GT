using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class EmployeesDetailsStandartDTO : ObjectBase
    {
        public int RecordID { get; set; }
        public string Gender { get; set; }
        public string WorkingPhone { get; set; }
        public string HomePhone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
