using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public short? Type { get; set; }
        public string Description { get; set; }
    }
}
