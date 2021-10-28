using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class EmployeeCertificatesDTO : ObjectBase
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public byte[] CertificateScan { get; set; }
        public string FileName { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }

        public bool CheckForDelete { get; set; }
    }
}
