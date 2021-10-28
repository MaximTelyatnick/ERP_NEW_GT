using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Storehouses
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public string Note { get; set; }
    }
}
