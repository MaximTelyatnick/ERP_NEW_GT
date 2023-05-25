using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class PackingListsJournal
    {
        [Key]
        public int Id { get; set; }
        //public long? MtsAssemblyId { get; set; }
        public string PackingNumber { get; set; }
        public string PackingNumberPart { get; set; }
        public DateTime PackingDate { get; set; }
        public string Description { get; set; }
        public string DescriptionProject { get; set; }
        public int? OtkPersonId { get; set; }
        public string OtkPersonFullName { get; set; }
        public int? ResponsiblePersonId { get; set; }
        public string ResponsiblePersonFullName { get; set; }
        public int? PackingListMaterialsId { get; set; }
        public int? PackingListComplectId { get; set; }
        public int PackingListId { get; set; }
        //Assembliess

        //public string NumberDrawing { get; set; }
        //public string ProjectName { get; set; }
        

        //Contractor
        public int? ContractorId { get; set; }
        public string ContractorName { get; set; }

        //CustomerOrder
        public int? CustomerOrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }

        //City

        public int? CityId { get; set; }
        public string CityName { get; set; }

        //Country

        public int? CountryId { get; set; }
        public string CountryName { get; set; }

        //Agreement
        public string AgreementName { get; set; }

        public int ScanStatus { get; set; }
        public int ScanComplStatus { get; set; }
    }
}
