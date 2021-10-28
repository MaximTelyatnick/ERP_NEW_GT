using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsDecreeDTO : ObjectBase
    {
        public int ID { get; set; }
        public int? ParentId { get; set; }
        public String Number { get; set; }
        public DateTime DecreeDate { get; set; }
        public int DecreeType { get; set; }
    }
}
