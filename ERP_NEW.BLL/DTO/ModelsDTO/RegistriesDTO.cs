using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class RegistriesDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
