using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ReceiptCertificateDetailDTO
    {
        public long ReceiptCertificateDetailId { get; set; }
        public long? ReceiptCertificateId { get; set; }
        public int? ReceiptId { get; set; }
    }
}
