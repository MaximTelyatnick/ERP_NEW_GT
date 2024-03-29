﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class FixedAssetsOrderRegistration
    {
        [Key]
        public int Id { get; set; }
        public int FixedAssetsOrderId { get; set; }
        public string NumberOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public string TypeOrder { get; set; }
        public int StatusTypeOrder { get; set; }
        public decimal? BeginPrice { get; set; }
        public int Supplier_Id { get; set; }
        public decimal? SoldPrice { get; set; }
        public DateTime BeginDate { get; set; }
        public int Pos { get; set; }
        
        
    }
}
