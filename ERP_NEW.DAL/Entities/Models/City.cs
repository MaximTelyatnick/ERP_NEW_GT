using System;
using System.ComponentModel.DataAnnotations;


namespace ERP_NEW.DAL.Entities.Models
{
   public class City
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }
        public int Country_Id { get; set; }
        public string CityName_UA { get; set; }
        public int? ParentId { get; set; }
        public DateTime? EndRegistrationDate { get; set; }
        public string Description { get; set; }
        public short SettlementTypeId { get; set; }

    }
}
