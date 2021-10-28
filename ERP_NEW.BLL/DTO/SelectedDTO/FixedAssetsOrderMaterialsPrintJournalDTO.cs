using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class FixedAssetsOrderMaterialsPrintJournalDTO
    {
        public int Id { get; set; }
        public int FixedAssetsOrder_Id { get; set; }
        public int? Expenditures_Id { get; set; }
        public int Fixed_Account_Id { get; set; }
        public decimal FixedPrice { get; set; }
        public string FlagNote { get; set; }
        public string FixedNum { get; set; }
        public DateTime? Exp_Date { get; set; }
        public string ExpenNum { get; set; }
        public decimal? Price { get; set; }
        public int? ReceiptId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? NomenclatureId { get; set; }
        public string Nomenclature { get; set; }
        public string Nomen { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? VendorId { get; set; }
        public string ContractorName { get; set; }
        public string Srn { get; set; }
        public int? DebitAccountId { get; set; }
        public string OrderNum { get; set; }
        public string InventoryNumber { get; set; }
        public string InventoryName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndRecordDate { get; set; }
        public int UsefulMonth { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
    
}
