using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CashPrepaymentsDTO : ObjectBase
    {
        public int Id { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public decimal PrepaymentPrice { get; set; }
        public int AccountId { get; set; }
        public int EmployeesId { get; set; }
        public DateTime DateAdded { get; set; }
        public int UserId { get; set; }
    }
}
