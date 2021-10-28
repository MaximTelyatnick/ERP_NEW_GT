using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IDocumentTypesService
    {
        IEnumerable<DocumentTypesDTO> GetDocumentTypes();
        DocumentTypesDTO GetDocumentTypeById(int id);

        int DocumentTypeCreate(DocumentTypesDTO documentType);
        void DocumentTypeUpdate(DocumentTypesDTO documentType);
        bool DocumentTypeDelete(int id);
        
        void Dispose();

    }
}
