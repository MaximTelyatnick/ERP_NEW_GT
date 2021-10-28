using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class LastIdOrderGen
    {
        [Key]
        public int RecId { get; set; }
        public int GenId { get; set; }
    }
}
