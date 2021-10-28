using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class DeliveryDTO : ObjectBase
    {
        public int Id { get; set; }
        public string DeliveryName { get; set; }
    }
}
