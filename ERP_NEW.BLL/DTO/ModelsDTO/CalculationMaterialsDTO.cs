using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CalculationMaterialsDTO
    {
        public int Id { get; set; }
        public int CalcId { get; set; }
        public int ExpAccId { get; set; }
        public String MaterialType { get; set; }

        public string ReceiptNum { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ExpenditureDate { get; set; }
        public string ContractorOrderName { get; set; }
        public string ContractorOrderSrn { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public string UnitLocalName { get; set; }
        public string ReceiptCountry { get; set; }

    }
}
