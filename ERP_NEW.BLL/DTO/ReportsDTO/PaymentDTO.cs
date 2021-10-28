using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Invoice_Num { get; set; }
        public int? Contractor_Id { get; set; }
        public string Contractor_Name { get; set; }
        public string Contractor_Srn { get; set; }
        public decimal? Price { get; set; }
        public string Purpose_Account { get; set; }
    }
}
