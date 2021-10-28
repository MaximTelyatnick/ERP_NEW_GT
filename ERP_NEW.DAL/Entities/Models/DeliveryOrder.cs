using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class DeliveryOrder
    {
        [Key]
        public int Id { get; set; }
        public int DeliveryId { get; set; }
        public string TTN { get; set; }
        public decimal? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public short DeliveryPriceTypeId { get; set; }
    }
}
