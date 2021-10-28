using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsPurposeDTO : ObjectBase
    {
        public int PurposeID { get; set; }
        public string Purpose { get; set; }
    }
}
