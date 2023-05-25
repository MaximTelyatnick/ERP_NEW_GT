using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class PackingLists
    {
        [Key]
        public int Id { get; set; }
        public string PackingNumber { get; set; }
        public string PackingNumberPart { get; set; }
        public DateTime PackingDate { get; set; }
        public int? OtkPersonId { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public string Description { get; set; }
        public int? PackingListComplectId { get; set; }
        public int? PackingListMaterialsId { get; set; }
        public string DescriptionProject { get; set; }
        public int? ContractorId { get; set; }
        public int? CityId { get; set; }
    }
}