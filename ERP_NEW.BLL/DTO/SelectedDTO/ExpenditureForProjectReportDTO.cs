using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ExpenditureForProjectReportDTO
    {
        public int Id { get; set; }
        public string Nomenclature { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
        public string ProjectNum { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
