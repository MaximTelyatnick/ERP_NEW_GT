using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class MaterialsForAccountClothesDTO
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public decimal RequiredQuantity { get; set; }
        public int ReceiptId { get; set; }
        public decimal UnitPrice { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime OrderDate { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public string UnitLocalName { get; set; }
        public int NomenclatureId { get; set; }
        public string BalanceAccountNum { get; set; }

        public bool Selected { get; set; }
    }
}
