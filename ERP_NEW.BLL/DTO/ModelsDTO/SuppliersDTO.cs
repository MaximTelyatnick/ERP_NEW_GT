using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class SuppliersDTO
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int? ACTIVE { get; set; }
        public int? GROUP_ID { get; set; }
    }
}
