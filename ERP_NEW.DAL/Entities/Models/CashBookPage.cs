﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class CashBookPage
    {
        [Key]
        public int Id { get; set; }
        public DateTime PageDate { get; set; }
        public string PageNumber { get; set; }
        public int CashBookId { get; set; }
    }
}
