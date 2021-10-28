using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSNomenclatureGroupsOldDTO:ObjectBase
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int? PARENT_ID { get; set; }
        public decimal RATIO_OF_WASTE { get; set; }
        public int? ADDIT_CALCULATION_ID { get; set; }
        public int ADDIT_CALCULATION_ACTIVE { get; set; }
        public int? CODPROD { get; set; }
        public int SORTPOSITION { get; set; }
    }
}
