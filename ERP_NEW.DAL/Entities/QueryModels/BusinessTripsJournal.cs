using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class BusinessTripsJournal
    {
        [Key]
        public int ID { get; set; }
        public int BusinessTripsID { get; set; }
        public String Doc_Number { get; set; }
        public DateTime Doc_Date { get; set; }
        public int? DepartureID { get; set; }
        public int? ContractorsID { get; set; }
        public string ContractorName { get; set; }
        public int? AgreementsID { get; set; }
        public int? CityID { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string FullCityName { get; set; }
        public string ProfessionNameDative { get; set; }
        public string ProfessionNameGenitive { get; set; }
        public int? DecreeId { get; set; }
        public int? DecreeDetailId { get; set; }
        public int? PurposeID { get; set; }
        public string PurposeName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AmountDays { get; set; }
        public int? UserId { get; set; }
        public int EmployeesID { get; set; }
        public string FullName { get; set; }
        public string Fio { get; set; }
        public string ProfessionName { get; set; }
        public int AccountNumber { get; set; }
        public String DecreeNumber { get; set; }
        public DateTime? DecreeDate { get; set; }
        public int PrepaymentStatus { get; set; }
        public int PaymentStatus { get; set; }
        public int DecreeProlongStatus { get; set; }
        public int DecreeAvoidanceStatus { get; set; }
        //public string IdentNumber { get; set; }
    }
}
