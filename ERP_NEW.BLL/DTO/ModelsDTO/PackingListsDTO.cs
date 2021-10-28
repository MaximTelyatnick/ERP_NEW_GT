using ERP_NEW.BLL.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class PackingListsDTO : ObjectBase
    {

        public int Id { get; set; }
        public string PackingNumber { get; set; }
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