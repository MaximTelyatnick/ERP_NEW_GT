using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class NomenclaturesDTO : ObjectBase
    {
        [Key]
        public int ID { get; set; }
        public int? Nomencl_Group_Id { get; set; }
        //public string GroupName { get; set; }
        public string Nomenclature { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
        public int? BALANCE_ACCOUNT_ID { get; set; }
        public string Num { get; set; }
        public int? Measure_Id { get; set; }
        public int? UnitId { get; set; }
        public string UnitLocalName { get; set; }
    }
}
