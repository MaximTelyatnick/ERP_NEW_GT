using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class FixedAssetsOrderByGroupShortReportDTO
    {
        public int RecId { get; set; }
        public decimal PeriodAmortization { get; set; }
        public int Group_Id { get; set; }
        public string Name { get; set; }
        public int? Fixed_Account_Id { get; set; }
        public int Balance_Account_Id { get; set; }
        public string Num { get; set; }
    }
}
