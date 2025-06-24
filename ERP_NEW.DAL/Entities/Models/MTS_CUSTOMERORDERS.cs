using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MTS_CUSTOMERORDERS
    {
        [Key]
        public int Id { get; set; }
        public int? SpecificationId { get; set; }
        public int? CustomerOrderId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
