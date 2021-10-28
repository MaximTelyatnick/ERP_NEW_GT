using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   public  class ContractorsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short_Name { get; set; }
        public string Srn { get; set; }
        public string Tin { get; set; }
        public int? OwnType { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ContractorTypeId { get; set; }

        public string CategoryName { get; set; }
        public string OwnName { get; set; }
        public string TypeName { get; set; }
    }
}
