using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class BusinessTripsReportByEmployeesDTO
    {
        public int RecID { get; set; }
        public int AccountNumber { get; set; }
        public string Fio { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
