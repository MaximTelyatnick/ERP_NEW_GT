using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class AccountingOperationsDTO:ObjectBase
    {
        public int Id { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string OperateDocument { get; set; }
        public decimal? PaymentPrice { get; set; }
        public decimal? DebitPrice { get; set; }
        public decimal? CreditPrice { get; set; }
        public int? OperatingAccountId { get; set; }
        public string OperationAccountNum { get; set; }
        public int? PurposeAccountId { get; set; }
        public string PurposeAccountNum { get; set; }
        public int? ContractorId { get; set; }
        public string ContractorName { get; set; }
        public string ContractorSrn { get; set; }
        public int? Direction { get; set; }
        public string Purpose { get; set; }
        public int? PaymentBankAccountId { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int AccountingOperationId { get; set; }
        public int? ColorId { get; set; }
        public string ColorName { get; set; }

        //property for check
        public bool Check { get; set; }
    }
}
