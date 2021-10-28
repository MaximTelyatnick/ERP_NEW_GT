using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
   public class Currency
    {
       [Key] 
       public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Num { get; set; }
    }
}
