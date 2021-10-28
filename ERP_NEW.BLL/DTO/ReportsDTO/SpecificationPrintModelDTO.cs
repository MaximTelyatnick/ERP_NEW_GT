using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class SpecificationPrintModelDTO
    {
        public int Id { get; set; }
        public int Nomenclature_id { get; set; }
        public string Name { get; set; }
        public string Guage { get; set; }
        public string Gost { get; set; }
        public string Note { get; set; }
        public string Measure { get; set; }
        public decimal Quantity { get; set; }
        public decimal AdditCalculationQuantity { get; set; }
        public object AdditCalculationMeasure { get; set; }
        public decimal Price { get; set; }
        public decimal RatioOfWaste { get; set; }
        public int NomenclatureGroupId { get; set; }
        public decimal Weight { get; set; }
        public int SortPosition { get; set; }
        public int GuageId { get; set; }
        public int Color { get; set; }
        public int GuagesPos { get; set; }
    }
}
