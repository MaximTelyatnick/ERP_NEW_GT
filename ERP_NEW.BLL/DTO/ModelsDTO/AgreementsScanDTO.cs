using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AgreementsScanDTO
    {
        [Key]
        public int Id { get; set; }
        //public int AgreementOrderId { get; set; }
        public byte[] Scan { get; set; }
        public string FileName { get; set; }
    }
}
