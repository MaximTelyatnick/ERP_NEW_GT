using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   public class ContactPersonAddressDTO
    {
        public int Id { get; set; }
        public int? ContactPersonId { get; set; }
        public int? ContactKindId { get; set; }
        public string Details { get; set; }

        public int ContractorId { get; set; }
        public string TypeName { get; set; }
        public string KindName { get; set; }
        public int? TypeId { get; set; }

        public string Fio { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Profession { get; set; }
        public string AdditionInfo { get; set; }
    }
}
