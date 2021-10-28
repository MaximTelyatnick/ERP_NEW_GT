using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class Invoice_Requirement_Orders
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public short Responsible_Person_Id { get; set; }
        public DateTime Date { get; set; }
        public bool Type { get; set; }
    
    }
}
