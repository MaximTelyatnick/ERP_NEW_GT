using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AccountClothes
    {
        [Key]
        public int Id { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int EmployeeId { get; set; }
    }
}
