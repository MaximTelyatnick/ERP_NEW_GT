using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSPurchasedProductsDTO : ObjectBase
    {
        public int ID { get; set; }
        public int? SPECIFICATIONS_ID { get; set; }
        public int? CODZAK { get; set; }
        public decimal? QUANTITY { get; set; }
        public int? CHANGES { get; set; }
        public DateTime? TIME_OF_ADD { get; set; }

        public int? NOMENCLATURES_ID { get; set; }
        public string NOMENCLATURESNAME { get; set; }
        public string NOMENCLATURESNOTE { get; set; }
        public decimal NOMENCLATURESPRICE { get; set; }

        public int NOM_GROUP_ID { get; set; }
        public int NOM_GROUP_SORTPOSITION { get; set; }

        public string GUAEGENAME { get; set; }

        public int? GOSTID { get; set; }
        public string GOSTNAME { get; set; }

        public string MEASURENAME { get; set; }
        public decimal? WEIGHT { get; set; }
    }
}
