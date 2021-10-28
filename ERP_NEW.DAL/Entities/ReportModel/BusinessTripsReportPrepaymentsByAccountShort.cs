using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BusinessTripsReportPrepaymentsByAccountShort
    {
        [Key]
        public int EmployeesId { get; set; }
        public decimal PrepaymentSum { get; set; }
        public string Fio { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
    }
}
