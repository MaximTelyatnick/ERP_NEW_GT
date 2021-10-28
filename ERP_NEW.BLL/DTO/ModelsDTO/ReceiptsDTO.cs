using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ReceiptsDTO : ObjectBase
    {
        public int ID { get; set; }
        public int ORDER_ID { get; set; }
        public int? POS { get; set; }
        public decimal QUANTITY { get; set; }
   
        public decimal? UNIT_PRICE { get; set; }
        public decimal TOTAL_PRICE { get; set; }
        public int? NOMENCLATURE_ID { get; set; }
        public int? Storehouse_Id { get; set; }
        public decimal? TOTAL_CURRENCY { get; set; }
        public decimal? UNIT_CURRENCY { get; set; }

        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public int? UnitId { get; set; }
        public string UnitLocalName { get; set; }
        public int? NomenclatureGroupId { get; set; }
        public string StoreHouseName { get; set; }
        public int? BalanceAccountId { get; set; }
        public string BalanceAccountNum { get; set; }
        public short? CURRENCY_ID { get; set; }
        public decimal? CURRENCY_RATE { get; set; }

        public bool Selected { get; set; }
        public bool InsertNomenclature { get; set; }
    }
}
