using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class FixedAssetsMaterialsDTO : ObjectBase
    {
        [Key]
        public int Id { get; set; }
        public int? FixedAssetsOrder_Id { get; set; }
        public int? Expenditures_Id { get; set; }
        public int? Fixed_Account_Id { get; set; }
        public int? Flag { get; set; }
        public decimal FixedPrice { get; set; }
        public DateTime? MaterialsDate { get; set; }
        public string Description { get; set; }
        public decimal? SoldPrice { get; set; }
        public string Name { get; set; }
        public string Nomenclature { get; set; }
        public string FixedNum { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderNum { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? Price { get; set; }
        public string ExpenNum { get; set; }
        public int? ReceiptId { get; set; }
        public int? NomenclatureId { get; set; }
        public int? VendorId { get; set; }
        public string ContractorName { get; set; }
        public string Srn { get; set; }
        public int? DebitAccountId { get; set; }
        public string FlagNote { get; set; }

        public bool Selected { get; set; }
        public string AccountNum { get; set; }

    }
}
