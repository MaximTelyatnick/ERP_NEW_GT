using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
    public  class ProductCategories
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
