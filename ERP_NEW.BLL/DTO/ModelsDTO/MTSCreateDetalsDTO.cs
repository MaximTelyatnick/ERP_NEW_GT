using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSCreateDetalsDTO :ObjectBase
    {
        public int ID { get; set; }
        public int? NOMENCLATURE_ID { get; set; }
        public int? PROCESSING_ID { get; set; }
        public string NAME { get; set; }
        public string DRAWING { get; set; }
        public decimal? WIDTH { get; set; }
        public decimal? HEIGHT { get; set; }

        //public string CREATEDETALSNAME { get; set; }
        public string GOSTNAME { get; set; }
        public string NOMENCLATURESNOTE { get; set; }
        public string DETALSPROCESSING { get; set; }
        public string NOMENCLATURESNAME { get; set; }
        public string GUAEGENAME { get; set; }
        public decimal? NOMENCLATURESWEIGHT { get; set; }
        public decimal? QUANTITY { get; set; }
        public decimal? QUANTITY_OF_BLANKS { get; set; }
        public int? GOSTID { get; set; }
        public string PROCCESINGNAME { get; set; }
    }
}
