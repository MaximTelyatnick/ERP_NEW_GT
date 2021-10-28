using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class RequestLogContractors
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
