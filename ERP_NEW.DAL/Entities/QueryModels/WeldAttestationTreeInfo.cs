using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class WeldAttestationTreeInfo
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string AttestationNumber { get; set; }
        public DateTime AttestationDate { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public string ResponsiblePersonName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WeldCertificateId { get; set; }
    }
}
