using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class CustomerOrderForWelding
    {
        [Key]
        public int RecId { get; set; }
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? ContractorId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Drawing { get; set; }
        public int? MtsId { get; set; }
        public string DrawingName { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }

    }
}
