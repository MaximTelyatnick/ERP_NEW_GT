using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class InvoiceRequirementOrdersDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public short Responsible_Person_Id { get; set; }
        public string Responsible_Person_Name { get; set; }
        public DateTime Date { get; set; }
        public bool Type { get; set; }
        
    }
}
