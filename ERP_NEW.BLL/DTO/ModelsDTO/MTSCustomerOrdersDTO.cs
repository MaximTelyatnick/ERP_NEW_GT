using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSCustomerOrdersDTO
    {
        public int Id { get; set; }
        public int? SpecificationId { get; set; }
        public int? CustomerOrderId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }

        public string OrderNumber { get; set; }
        public string SpecificationName { get; set; }
        public int Quantity { get; set; }
        public string Drawing { get; set; }
        public int? Assembly { get; set; }
        public string ContractorName { get; set; }
        public DateTime? DataCreateCustomerOrder { get; set; }
        public bool Check { get; set; }
    }
}
