using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class NomenclatureGroupsDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent_Id { get; set; }
        public int? Balance_Account_Id { get; set; }
    }
}
