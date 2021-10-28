using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class SUPPLIERS
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public int? ACTIVE { get; set; }
        public int? GROUP_ID { get; set; }
    }
}
