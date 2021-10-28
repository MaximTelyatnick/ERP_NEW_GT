using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class BusinessTripsReportPrepaymentsByAccountShortDTO
    {
        public int EmployeesId { get; set; }
        public decimal PrepaymentSum { get; set; }
        public string Fio { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
    }
}
