using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class InvoiceRequirementMaterialsInfo
    {
        [Key]
        public int Id { get; set; }
        public String ReceiptNum { get; set; }
        public int ReceiptId { get; set; }
        public int InvoiceRequirementOrderId { get; set; }
        public string BalanceAccountNum { get; set; }
        public string NomenclatureName { get; set; }
        public string Nomenclature { get; set; }
        public string UnitLocalName { get; set; }
        public decimal? RequiredQuantity { get; set; }
        public decimal? ExpenQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string ExpenAccountNum { get; set; }
        public int? CreditAccountId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? ExpendituresId { get; set; }
        public string Description { get; set; }
        public int? FixedAssetsId { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public string CustomerOrder { get; set; }
        public string CustomerOrderExp { get; set; }
        public int? CustomerOrderExpId { get; set; }


    }
}
