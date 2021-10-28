using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessCardPhotosDTO
    {

        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public int BusinessCardId { get; set; }
        public bool Selected { get; set; }
    }
}
