using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
   public class ShipmentLists
    {
        [Key]
        public int ShipmentListId { get; set; }
        public int CustomerOrderId { get; set; }
        public string ShipmentNumber { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int? DocumentTypeId { get; set; }
        public string Description { get; set; }
        public byte[] ShipmentScan { get; set; }
        public string FileName { get; set; }
    }
}
