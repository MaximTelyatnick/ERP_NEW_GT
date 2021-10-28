using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ColorsDTO : ObjectBase
    {
        [Key]
        public int Id { get; set; }
        public string Name_Rus { get; set; }
        public string Color_Code { get; set; }
        public string Name { get; set; }
    }
}
