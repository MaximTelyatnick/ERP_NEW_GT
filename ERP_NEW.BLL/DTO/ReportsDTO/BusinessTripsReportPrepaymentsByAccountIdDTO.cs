using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class BusinessTripsReportPrepaymentsByAccountIdDTO
    {
        public int Id { get; set; }
        public int BusinessTripsDetailsID { get; set; }
        public int EmployeesId { get; set; }
        public decimal Prepayment { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public int AccountsId { get; set; }
        public int ContractorsID { get; set; }
        public int CityID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public string Fio { get; set; }
        public string CountryName_UA { get; set; }
        public string CityName_UA { get; set; }
        public string OrderNumber { get; set; }
    }
}
