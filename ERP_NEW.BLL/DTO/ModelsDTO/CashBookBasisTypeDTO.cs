using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CashBookBasisTypeDTO : ObjectBase
    {
        [Key]
        public int Id { get; set; }
        public string BasisType { get; set; }
    }
}
