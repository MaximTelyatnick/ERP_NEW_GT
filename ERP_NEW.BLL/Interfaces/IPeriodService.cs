using ERP_NEW.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERP_NEW.BLL.Interfaces
{
    public interface IPeriodService
    {
        IEnumerable<PeriodsDTO> GetAllPeriods();

        PeriodsDTO GetPeriodByKey(int year, int month);

        bool CheckPeriodAccess(DateTime currentDate);
        
        bool CheckPeriodExist(DateTime currentDate);

        bool CheckPeriodTaxInvoicesAccess(DateTime currentDate);
        bool CheckPeriodTaxInvoicesExist(DateTime currentDate);

        int PeriodsCreate(PeriodsDTO pdto);
        void PeriodsUpdate(PeriodsDTO pdto);

        void Dispose();
    }

}
