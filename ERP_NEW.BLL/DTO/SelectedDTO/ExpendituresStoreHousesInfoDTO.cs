using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class ExpendituresStoreHousesInfoDTO
    {
        [Key]
        public int Id { get; set; }
        public int? BalanceAccountId { get; set; }
        public string BalanceAccountNum { get; set; }
        public int? CustomerOrderId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public DateTime? ExpDate { get; set; }
        public int? NomenclatureId { get; set; }
        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public int ReceiptId { get; set; }
        public string ReceiptNum { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Price { get; set; }
        public int? UnitId { get; set; }
        public string UnitLocalName { get; set; }
        public int? ExpenditureId { get; set; }
        public decimal? ExpendituresQuantity { get; set; }
        public DateTime? ExpenditureAccountDate { get; set; }
        public int? EmployeeId { get; set; }
        public bool Check { get; set; }
        public string ExpenditureCustomerOrder { get; set; }
    }
}
