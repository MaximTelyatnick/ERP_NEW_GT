using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.ReportModel
{
    public class BeginCredit
    {
        [Key]
        public int RecId { get; set; }
        public string Contractor_Name { get; set; }
        public int? Contractor_Id { get; set; }
        public decimal? Begin_Credit { get; set; }
    }
}
