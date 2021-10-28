using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CalculationDTO
    {
        public int Id { get; set; }
        public DateTime CalcDate { get; set; }
        public String CalcNumber { get; set; }
        public int? CustomerOrderId { get; set; }
        public string CustonerOrderNumber { get; set; }
        public string ContractorName { get; set; }
    }
}
