using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessCardsFactoryDTO : ObjectBase
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public int? CityId { get; set; }
        public String CityName { get; set; }
        public String CountryName { get; set; }

        public int? ProductCategoriesId { get; set; }
        public String CategoryName { get; set; }

        public bool Select { get; set; }
    }
}
