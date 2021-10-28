using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public class AccessRights
    {
        [Key]
        public int RightId { get; set; }
        public string RightAttribute { get; set; }
        public string RightName { get; set; }
    }
}
