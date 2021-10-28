using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class ExpenditureInfo
    {
        [Key]
        public int Id { get; set; }
        public DateTime? OrderDate  { get; set; }
        public string ReceiptNum { get; set; }
        public string Nomenclature { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? ReceiptQuantity { get; set; }
        public decimal? Remains { get; set; }
        public decimal? ExpPrice { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? ExpDate { get; set; }
        public string ProjectNum { get; set; }
        public decimal? ExpSumQuantity { get; set; }
        public string DebitAccountNum { get; set; }
        public string BalanceAccountNum { get; set; }
        public string CreditAccountNum { get; set; }
        public short? CreditAccountId { get; set; }
        public string CurrencyName { get; set; }
        public string UnitLocalName { get; set; }
        public int ReceiptId { get; set; }
        //public decimal? ExpStorehouseQuantity { get; set; }
        //public decimal? ExpStorehousePrice { get; set; }
        //public DateTime? ExpStorehouseDate { get; set; }
        //public string ExpStorehouseOrderNumber { get; set; }
        public int? CustomerOrderId { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string InvoiceNum { get; set; }

        public short? BalanceAccountId { get; set; }
        public int? ProdCustomerOrderId { get; set; }
        public string ProdCustomerNumber { get; set; }
        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public bool ExpenditureType { get; set; }
        public DateTime? ExpenditureCheckDate { get; set; }
        public DateTime? RealExpDate { get; set; }

    }
}
