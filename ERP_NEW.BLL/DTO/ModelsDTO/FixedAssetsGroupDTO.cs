using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class FixedAssetsGroupDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? AmortizationFactor { get; set; }
        public int? UsefulPeriod { get; set; }
    }
}
