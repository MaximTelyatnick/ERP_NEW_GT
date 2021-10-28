using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AgreementsTypeDTO : ObjectBase
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}
