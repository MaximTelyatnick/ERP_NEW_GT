using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IAccountingOperationService
    {
        IEnumerable<AccountingOperationDTO> GetAccountingOperation();
        
        void Dispose();
    }
}
