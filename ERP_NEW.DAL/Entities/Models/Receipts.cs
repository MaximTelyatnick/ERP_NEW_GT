using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class RECEIPTS
    {
        [Key]
        public int ID { get; set; }
        public int ORDER_ID { get; set; }
        public int? POS { get; set; }
        public decimal QUANTITY { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public decimal TOTAL_PRICE { get; set; }
        public int? NOMENCLATURE_ID { get; set; }
        public int? Storehouse_Id { get; set; }
        public decimal? TOTAL_CURRENCY { get; set; }
        //[ReadOnly(true)]
        //[NotMapped]
        //[ReadOnly(true)]
        //04.01.2021
        //[NotMapped]
        //public decimal? UNIT_PRICE { get; set; }

        //[IgnoreMap]
        //[NotMapped]
        //[ReadOnly(true)]
        //[NotMapped]
        //[ReadOnly(true)]
        

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [NotMapped]
        public decimal? UNIT_PRICE { get; set; }
        [NotMapped]
        public decimal? UNIT_CURRENCY { get; set; }

        
    }
}
