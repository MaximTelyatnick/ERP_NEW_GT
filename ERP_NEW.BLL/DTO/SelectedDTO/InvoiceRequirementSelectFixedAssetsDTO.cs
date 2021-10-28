using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class InvoiceRequirementSelectFixedAssetsDTO
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public DateTime BeginDate { get; set; }
        public string FullName { get; set; }
        public string GroupName { get; set; }

    }
}
