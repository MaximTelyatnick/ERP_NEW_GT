using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   public  class ContactPersonsDTO
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Profession { get; set; }
        public string AdditionInfo { get; set; }

        public string Fio { get; set; }
    }
}
