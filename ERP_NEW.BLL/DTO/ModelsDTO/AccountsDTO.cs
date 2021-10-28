using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AccountsDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public int? Type { get; set; }
        public string Description { get; set; }
        public int? VatMark { get; set; }
        public string TypeName { get; set; }
    }
}
