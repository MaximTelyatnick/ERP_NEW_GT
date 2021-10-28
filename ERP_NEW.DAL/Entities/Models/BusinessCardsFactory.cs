using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class BusinessCardsFactory
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int? CityId { get; set; }
        public int? ProductCategoriesId { get; set; }
    }
}
