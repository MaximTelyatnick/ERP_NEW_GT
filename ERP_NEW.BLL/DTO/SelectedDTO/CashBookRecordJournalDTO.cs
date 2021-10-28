using ERP_NEW.BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class CashBookRecordJournalDTO : ObjectBase
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public int CashBookPageId { get; set; }
        public int BalanceAccountId { get; set; }
        public string BalanceAccountNumber { get; set; }
        public int? CurrencyTypeId { get; set; }
        public string CurrencyTypeName { get; set; }
        public int? BasisId { get; set; }
        public string BasisType { get; set; }
        public int? ContractorId { get; set; }
        public string CashBookContractorName { get; set; }
        public int? AdditionalId { get; set; }
        public string NameAdditionalType { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Payment { get; set; }

        public bool Selection { get; set; }
    }
}
