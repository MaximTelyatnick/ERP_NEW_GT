using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class MTSAuthorizationUsers
    {
        [Key]
        public int ID { get; set; }
        public string NAME { get; set; }
        public string PWD { get; set; }
        public int USER_GROUPS_ID { get; set; }
        public string LOGIN { get; set; }
        public int ONLINE { get; set; }
    }
}
