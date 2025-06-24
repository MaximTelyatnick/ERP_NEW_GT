using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSDetailsDTO : ObjectBase
    {
        public int ID { get; set; }
        public int SPECIFICATIONS_ID { get; set; }
        public int? CREATED_DETAILS_ID { get; set; }
        public decimal? QUANTITY_OF_BLANKS { get; set; }
        public int? CODZAK { get; set; }
        public decimal? QUANTITY { get; set; }
        public int? CHANGES { get; set; }
        public DateTime? TIME_OF_ADD { get; set; }

        public int? NOMENCLATURE_ID { get; set; }
        public decimal? NOMENCLATURESWEIGHT { get; set; }
        public string NOMENCLATURESNAME { get; set; }
        public string NOMENCLATURESNOTE { get; set; }
        public decimal NOMENCLATURESPRICE { get; set; }

        public int NOM_GROUP_ID { get; set; }
        public string NOM_GROUP_NAME { get; set; }
        public int? NOM_GROUP_PARENT_ID { get; set; }
        public decimal? NOM_GROUP_RATIO_OF_WASTE { get; set; }
        public int? NOM_GROUP_ADDIT_CALCULATION_ID { get; set; }
        public bool? NOM_GROUP_ADDIT_CALCULATION_ACTIVE { get; set; }
        public string NOM_GROUP_ADDIT_CALCULATION_MEASURE { get; set; }

        public int? NOM_GROUP_CODPROD { get; set; }
        public int NOM_GROUP_SORTPOSITION { get; set; }

        public string MEASURE_NAME { get; set; }

        public int? PROCESSING_ID { get; set; }
        public string PROCCESINGNAME { get; set; }

        public int GUAEGESORT { get; set; }
        public string GUAEGENAME { get; set; }

        public int? GOSTID { get; set; }
        public string GOSTNAME { get; set; }

        public string NAME { get; set; }
        public string DRAWING { get; set; }
        public decimal? WIDTH { get; set; }
        public decimal? HEIGHT { get; set; }
        public string CREATEDETALSNAME { get; set; }
        public string DETALSPROCESSING { get; set; }


        public bool lastFocusedRov { get; set; }








    }
}
