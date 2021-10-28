using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class NOMENCLATURES
    {
        [Key]
        public int ID { get; set; }
        public int? Nomencl_Group_Id { get; set; }
        public string NOMENCLATURE { get; set; }
        public string NAME { get; set; }
        public string MEASURE { get; set; }
        public int? BALANCE_ACCOUNT_ID { get; set; }
        public int? Measure_Id { get; set; }
        public int? UnitId { get; set; }
        
    }
}
