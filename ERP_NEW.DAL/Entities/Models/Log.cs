using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
        public string FormName { get; set; }
        public int UserId { get; set; }
        public DateTime LogTime { get; set; }
    }
}
