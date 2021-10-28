using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MTSGuages
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public int SORTING { get; set; }
    }
}
