using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class ORDERS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string RECEIPT_NUM { get; set; }
        public int? VENDOR_ID { get; set; }
        public string INVOICE_NUM { get; set; }
        public short? SUPPLIER_ID { get; set; }
        public string SUPPLIER_PROXY { get; set; }
        public DateTime? INVOICE_DATE { get; set; }
        public DateTime? ORDER_DATE { get; set; }

        
        public decimal? TOTAL_WITH_VAT { get; set; }
        public DateTime? ENTER_DATE { get; set; }
        public short DEBIT_ACCOUNT_ID { get; set; }
        public short? TAX_INVOICE { get; set; }
        public short? TRANSPORT_INVOICE { get; set; }
        public short CORRECTION { get; set; }
        public short? Color_Id { get; set; }
        public short CHECKED { get; set; }
        public short? Flag1 { get; set; }
        public short? Flag2 { get; set; }
        public short? Flag3 { get; set; }
        public short? Flag4 { get; set; }
        public short? Otk_Id { get; set; }
        public short? Storekeeper_Id { get; set; }
        public short? CURRENCY_ID { get; set; }
        public string ACCOUNT_NUM { get; set; }
        
        public decimal? CURRENCY_RATE { get; set; }

        //все что ниже комментить перед паблишингом

        public int? UserId { get; set; }
        public int? OtkId { get; set; }
        public int? SupplierId { get; set; }
        public int? StorekeeperId { get; set; }

        //[NotMapped]
        //public decimal? TOTAL_CURRENCY { get; set; }
        //[NotMapped]
        //public decimal? TOTAL_PRICE { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public decimal? TOTAL_CURRENCY { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public decimal? TOTAL_PRICE { get; set; }

    }
}
