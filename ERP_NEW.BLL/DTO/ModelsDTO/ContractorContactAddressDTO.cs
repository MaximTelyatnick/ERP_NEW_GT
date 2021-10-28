using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class ContractorContactAddressDTO
    {
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public int? ContractorContactKindId { get; set; }
        public string Details { get; set; }

        public string Name { get; set; }
        public int? TypeId { get; set; }
    }
}
