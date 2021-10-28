using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ControlChecksDTO : ObjectBase
    {
        public int ControlCheckId { get; set; }
        public int? ProjectDetailId { get; set; }
        public DateTime ControlDate { get; set; }
        public int ControlPersonId { get; set; }
        public string Description { get; set; }
        public string MarkDocumentNumber { get; set; }
        public int? CustomerOrderId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string ContractorName { get; set; }
        public string ControlPersonName { get; set; }
    }
}
