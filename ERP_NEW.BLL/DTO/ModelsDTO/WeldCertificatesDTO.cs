using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class WeldCertificatesDTO : ObjectBase
    {
        public int Id { get; set; }
        public int WeldAttestationId { get; set; }
        public byte[] CertificateScan { get; set; }
        public string FileName { get; set; }
    }
}
