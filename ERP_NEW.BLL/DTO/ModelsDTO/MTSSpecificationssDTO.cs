using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class MTSSpecificationssDTO : ObjectBase
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int? DEVICE_ID { get; set; }
        public decimal WEIGHT { get; set; }
        public DateTime CREATION_DATE { get; set; }
        public int? USERS_ID { get; set; }
        public int AUTHORIZATION_USERS_ID { get; set; }
        public string DRAWING { get; set; }
        public DateTime? LAST_MODIFICATION_DATE { get; set; }
        public string COMPILATION_NAMES { get; set; }
        public string COMPILATION_DRAWINGS { get; set; }
        public int? CODIZD { get; set; }
        public string COMPILATION_QUANTITIES { get; set; }
        public int QUANTITY { get; set; }
        public int? SET_COLOR { get; set; }
        public string AUTHORIZATION_USERS_NAME { get; set; }
        public int test { get; set; }
        public bool Selected { get; set; }


    }
}
