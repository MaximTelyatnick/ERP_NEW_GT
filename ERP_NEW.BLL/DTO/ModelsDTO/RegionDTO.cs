using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class RegionDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short? Type { get; set; }
        public string Description { get; set; }
    }
}
