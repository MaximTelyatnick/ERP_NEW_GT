using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsPrepaymentDTO : ObjectBase
    {
        public int ID { get; set; }
        public int BusinessTripsDetailsID { get; set; }
        public int EmployeesID { get; set; }
        public decimal Prepayment { get; set; }
        public int? AccountsID { get; set; }
        public DateTime Prepayment_Date { get; set; }
        public DateTime Doc_Date { get; set; }
        public int? UserId { get; set; }
        public string AccountsNum { get; set; }

        public bool Selected { get; set; }
        public bool? Check { get; set; }
    }
}
