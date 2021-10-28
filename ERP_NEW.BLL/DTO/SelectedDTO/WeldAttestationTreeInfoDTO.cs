using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class WeldAttestationTreeInfoDTO
    {
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
