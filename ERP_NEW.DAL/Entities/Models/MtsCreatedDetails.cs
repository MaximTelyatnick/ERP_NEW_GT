using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MtsCreatedDetails
    {
        [Key]
        public long Id { get; set; }
        public long MtsNomenclatureId { get; set; }
        public int ProcessingId { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public long MtsDetailId { get; set; }
    }
}
