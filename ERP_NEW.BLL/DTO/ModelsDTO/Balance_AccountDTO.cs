using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class Balance_AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AccountId { get; set; }
        public int? VatId { get; set; }
    }
}
