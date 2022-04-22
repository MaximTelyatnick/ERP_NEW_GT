using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class FixedAssetsNoAmortDTO
    {
        public int Id { get; set; }
        public int FixedAssetId { get; set; }
        public DateTime DateNoAmortization { get; set; }
        public int Count { get; set; }
        public string DateNoAmortizationMonth { get; set; }
        public string DateNoAmortizationYear { get; set; }
    }
}
