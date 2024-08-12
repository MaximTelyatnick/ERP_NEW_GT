using ERP_NEW.BLL.Infrastructure;
using System;
using System.Windows.Forms;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
   public  class ContractorsDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short_Name { get; set; }
        public string Srn { get; set; }
        public string Tin { get; set; }
        public int? OwnType { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ContractorTypeId { get; set; }

        public bool Active { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? ParentId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string AgreementNumber { get; set; }
        public DateTime? AgreementDate { get; set; }
        public int? UserId { get; set; }

        public string CategoryName { get; set; }
        public string OwnName { get; set; }
        public string TypeName { get; set; }

        public static explicit operator ContractorsDTO(BindingSource v)
        {
            throw new NotImplementedException();
        }
    }
}
