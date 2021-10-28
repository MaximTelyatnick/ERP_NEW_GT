using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class InvoiceRequirementExpenditureInfoDTO
    {
        [Key]
        public int Id { get; set; }
        public decimal Setkol { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpDate { get; set; }
        public int NomenclatureId { get; set; }
        public int ReceiptId { get; set; }
        public decimal UnitPrice { get; set; }
        public string CreditAccount { get; set; }
        public string DebitNum { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        public string Nomenclature { get; set; }
        public string UnitLocalName { get; set; }
        public string BalanceNum { get; set; }
        public int? CreditAccountId { get; set; }
        public string CustomerOrderNumbers { get; set; }

        public bool Selected { get; set; }
    }
}
