using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ShipmentListsDTO : ObjectBase
    {
        public int ShipmentListId { get; set; }
        public int CustomerOrderId { get; set; }
        public string ShipmentNumber { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int? DocumentTypeId { get; set; }
        public string Description { get; set; }
        public byte[] ShipmentScan { get; set; }
        public string FileName { get; set; }

        public string DocumentTypeName { get; set; }
        public int ScanPersence { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
