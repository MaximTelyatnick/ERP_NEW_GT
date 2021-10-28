using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class InvoicesDTO : ObjectBase
    {
        public int Id { get; set; }
        public DateTime Month_Current { get; set; }
        public DateTime Month_Invoice { get; set; }
        public string Invoice_Number { get; set; }
        public int? Contractor_Id { get; set; }
        public int? Balance_Account_Id { get; set; }
        public decimal? Price { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Non_Taxable { get; set; }
        public decimal? Total_Price { get; set; }
        public int? Color_Id { get; set; }
        public decimal? Vat_Check { get; set; }
        public int? Note_Id { get; set; }
        public int? Registry_Id { get; set; }
        public DateTime? Date_Of_Correction { get; set; }
        public string Number_Of_Correction { get; set; }
        public string Tin { get; set; }
        public string Contractor_Name { get; set; }
        public string Color_Name { get; set; }
        public string Bal_Name { get; set; }
        public string Inv_Note_Name { get; set; }
        public string Region_Name { get; set; }
        public bool Selected { get; set; }
       
    }
}
