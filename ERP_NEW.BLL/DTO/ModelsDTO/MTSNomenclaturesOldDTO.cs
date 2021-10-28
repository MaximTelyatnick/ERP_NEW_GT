using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSNomenclaturesOldDTO:ObjectBase
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string GUAGE { get; set; }
        public decimal WEIGHT { get; set; }
        public decimal PRICE { get; set; }
        public int MEASURE_ID { get; set; }
        public string NOTE { get; set; }
        public int NOMENCLATUREGROUPS_ID { get; set; }
        public int? COD_PROD_ID { get; set; }
        public int? KODZAK { get; set; }
        public int GUAGE_ID { get; set; }
        public int? GOST_ID { get; set; }

        public string GOST { get; set; }
        public string MEASURE { get; set; }


    }
}
