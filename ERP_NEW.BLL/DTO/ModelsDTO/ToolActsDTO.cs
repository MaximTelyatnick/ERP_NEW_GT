using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ToolActsDTO : ObjectBase
    {
        [Key]
        public int Id { get; set; }
        public string ActNumber { get; set; }
        public DateTime ActDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public string ResponsiblePersonFullName { get; set; }
    }
}
