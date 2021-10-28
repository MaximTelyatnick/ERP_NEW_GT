using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class BusinessTripsDTO : ObjectBase
    {
        public int ID { get; set; }
        public String Doc_Number { get; set; }
        public DateTime Doc_Date { get; set; }
        public int? DepartureID { get; set; }
        public int? ContractorsID { get; set; }
        public int? AgreementsID { get; set; }
        public int? CityID { get; set; }
        public int? PurposeID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AmountDays { get; set; }
        public int? UserId { get; set; }
        public int? CustomerOrderId { get; set; }

        public int BusinessTripDetailId { get; set; }
        public int? EmployeesID { get; set; }
    }
}
