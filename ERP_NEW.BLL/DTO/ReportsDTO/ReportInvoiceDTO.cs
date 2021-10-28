using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ReportsDTO
{
    public class ReportInvoiceDTO
    {
        public string Id { get; set; }
        public string Month_Current { get; set; }
        public string Month_Invoice { get; set; }
        public string Invoice_Number { get; set; }
        public string Vendor_Name { get; set; }
        public string Vendor_Code { get; set; }
        public string Bez_Nds { get; set; }
        public string Nds { get; set; }
        public string Non_Taxable { get; set; }
        public string TotalPrice { get; set; }
        public string BalanceAccountName { get; set; }
        public int? Contractor_Id { get; set; }
        public int? Branch_Id { get; set; }
        


    }
}
