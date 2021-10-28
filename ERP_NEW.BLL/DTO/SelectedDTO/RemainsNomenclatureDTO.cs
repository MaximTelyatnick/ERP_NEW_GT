using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class RemainsNomenclatureDTO
    {
        public int RecId { get; set; }
        public int ReceiptId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public decimal? RemainsQuantity { get; set; }
        public decimal? RemainsSum { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public string DebitNum { get; set; }
        public string Correction { get; set; }
    }
}
