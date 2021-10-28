using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class FixedAssetsOrderListMaterialsJournalDTO : ObjectBase
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal? SetPrice { get; set; }
        public DateTime? Exp_Date { get; set; }
        public int? Nomenclature_Id { get; set; }
        public int? Receipt_Id { get; set; }
        public decimal? Unit_Price { get; set; }
        public string Credit_Account { get; set; }
        public string Debit_Num { get; set; }
        public string Receipt_Num { get; set; }
        public DateTime? Order_Date { get; set; }
        public string NameNomenclature { get; set; }
        public string Nomenclature { get; set; }
        public string Measure { get; set; }
        public string Balance_Num { get; set; }
        public int Credit_Account_Id { get; set; }


    }
}
