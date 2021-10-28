using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class FixedAssetsReportRegisterCh2
    {
        [Key]
        public int GroupId { get; set; }
        public decimal FixedPrice { get; set; }
        public string FaoNum { get; set; }
    }
}
