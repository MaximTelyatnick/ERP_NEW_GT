using System;
using System.ComponentModel.DataAnnotations;

namespace ERP_NEW.DAL.Entities.Models
{
   public  class ContactPersons
    {
        [Key]
        public int Id { get; set; }
        public string  LastName { get; set; }
        public string FirstName { get; set; }
        public string  MiddleName { get; set; }
        public string Profession{ get; set; }
        public string  AdditionInfo { get; set; }

    }
}
