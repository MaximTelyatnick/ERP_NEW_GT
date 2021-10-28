using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ExpedinturesAccountantDTO : ObjectBase
    {
        [Key]

        public int ID { get; set; }
        public int RECEIPT_ID { get; set; }
        public decimal QUANTITY { get; set; }
        public decimal PRICE { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? EXP_DATE { get; set; }
        public DateTime? RealExpDate { get; set; }
        public string PROJECT_NUM { get; set; }
        public int? CREDIT_ACCOUNT_ID { get; set; }
        public int? CustomerOrderId { get; set; }
        public int? ProdCustomerOrderId { get; set; }
        public int? EmployeeId { get; set; }
        public int? UserId { get; set; }
        public bool ExpenditureType { get; set; }
        public DateTime? ExpenditureCheckDate { get; set; }

        public string Nomenclature { get; set; }
        public string NomenclatureName { get; set; }
        public int? UnitId { get; set; }
        public string UnitLocalName { get; set; }
        public int? BalanceAccountId { get; set; }
        public string BalanceAccountNum { get; set; }
        public int? NomenclatureGroupId { get; set; }
        public int? NomenclatureId { get; set; }
        public string ReceiptNum { get; set; }

        //потом удалить
        public string CustomerOrderNumber { get; set; }
        public string ProdCustomerNumber { get; set; }

        public bool? Selected { get; set; }

      
    }
}
