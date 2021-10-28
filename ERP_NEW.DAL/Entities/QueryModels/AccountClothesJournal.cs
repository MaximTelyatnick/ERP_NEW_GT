using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class AccountClothesJournal
    {
        [Key]
        public int Id { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public int AccountNumber { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFullName { get; set; }
        public int AccountClothesId { get; set; }
        public int InvoiceRequirementMaterialId { get; set; }
        public decimal? QuantityOutput { get; set; }
        public decimal? QuantityReturn { get; set; }
        public DateTime? DateOutput { get; set; }
        public DateTime? DateReturn { get; set; }
        public string UnitLocalName { get; set; }
        public string UnitCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int? PercentageOutput { get; set; }
        public int? PercentageReturn { get; set; }
        public string BalanceAccountNum { get; set; }
        public string NomenclatureName { get; set; }
        public string NomenclatureNumber { get; set; }
        public int NomenclatureId { get; set; }
        public int BalanceAccountId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
