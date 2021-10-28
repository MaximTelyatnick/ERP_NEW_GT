using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class FixedAssetsReportRegisterCh1DTO
    {
        public int RecId { get; set; }
        public int Id { get; set; }
        public decimal CurrentAmortizationForPeriod { get; set; }
        public string FamNum { get; set; }        
    }
}
