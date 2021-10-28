using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   
    public class InvoiceRequirementMaterialsDTO
    {
        public int Id { get; set; }
        public int Invoice_Requirement_Order_Id { get; set; }
        public int Receipt_Id { get; set; }
        public int? Credit_Account_Id { get; set; }
        public int? Expenditures_Id { get; set; }
        public int? FixedAssets_Id { get; set; }
        public int? CustomerOrderId { get; set; }
        public decimal Required_Quantity { get; set; }
        public string Description { get; set; }
    }
}
