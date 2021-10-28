using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ToolActs
    {
        [Key]
        public int Id { get; set; }
        public string ActNumber { get; set; }
        public DateTime ActDate { get; set; }
        public int ResponsiblePersonId { get; set; }
    }
}
