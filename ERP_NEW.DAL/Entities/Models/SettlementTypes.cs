using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class SettlementTypes
    {
        [Key]
        public short Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }

    }
}
