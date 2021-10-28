using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class PackingListDetailDTO
    {
        [Key]
        public int Id { get; set; }
        public int PackingListId { get; set; }
        public int PackingListNumber { get; set; }
        public int? CustomerOrderId { get; set; }
        public string CustomerOrdersNumber { get; set; }
        public string ContractorName { get; set; }
        public DateTime? OrderDate { get; set; }
        
        public bool Selected { get; set; }

    }
}
