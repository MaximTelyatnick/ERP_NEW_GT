using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AccountClothesMaterialsDTO : ObjectBase
    {
        public int Id { get; set; }
        public int AccountClothesId { get; set; }
        public int InvoiceRequirementMaterialId { get; set; }
        public decimal? QuantityOutput { get; set; }
        public decimal? QuantityReturn { get; set; }
        public DateTime? DateOutput { get; set; }
        public DateTime? DateReturn { get; set; }
        public int? PercentageOutput { get; set; }
        public int? PercentageReturn { get; set; }
        public string BalanceAccountNum { get; set; }
        public string NomenclatureName { get; set; }
        public string NomenclatureNumber { get; set; }
        public int NomenclatureId { get; set; }
        public int BalanceAccountId{ get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        
        public string UnitLocalName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public bool Selection { get; set; }
    }
}
