using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CustomerOrders
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int? ContractorId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Details { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal? CurrencyPrice { get; set; }
        public long? AssemblyId { get; set; }
        public int? AgreementId { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int UserId { get; set; }
        public int Enable { get; set; }
    }
}
