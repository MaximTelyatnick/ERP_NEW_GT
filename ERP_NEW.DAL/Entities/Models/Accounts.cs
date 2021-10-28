using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ACCOUNTS
    {
        [Key]
        public int ID { get; set; }
        public string NUM { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
        public int? VatMark { get; set; }
    }
}
