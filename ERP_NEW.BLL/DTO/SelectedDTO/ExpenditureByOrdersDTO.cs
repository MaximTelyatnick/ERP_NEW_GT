using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ExpenditureByOrdersDTO
    {
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public string Measure { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNum { get; set; }
        public string VendorName { get; set; }
        public string VendorSrn { get; set; }

        public DateTime? CertificateDate { get; set; }
        public string CertificateNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public DateTime? CustomerOrderDate { get; set; }
        public string CustomerOrderNumberGroup { get; set; }
        public int RecID { get; set; }
    }
}
