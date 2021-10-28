using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsAssemblyDetails
    {
        [Key]
        public long Id { get; set; }
        public long MtsSpecificationId { get; set; }
        public long MtsCreatedDetails { get; set; }
        public decimal QuantityOfBlanks { get; set; }
        public decimal Quantity { get; set; }
        public short Changes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
