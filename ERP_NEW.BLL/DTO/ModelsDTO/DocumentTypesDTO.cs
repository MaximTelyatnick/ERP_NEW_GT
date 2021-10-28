using ERP_NEW.BLL.Infrastructure;
using System;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class DocumentTypesDTO : ObjectBase
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public short DocumentKind { get; set; }
    }
}
