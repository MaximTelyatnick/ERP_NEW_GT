using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AgreementOrderScan
    {
        [Key]
        public int Id { get; set; }
        //public int AgreementOrderId { get; set; }
        public byte[] Scan { get; set; }
        public string FileName { get; set; }

    }
}
