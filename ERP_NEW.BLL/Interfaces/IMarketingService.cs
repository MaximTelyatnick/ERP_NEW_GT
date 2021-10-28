using ERP_NEW.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IMarketingService
    {

        IEnumerable<CalculationDTO> GetCalculation();
        IEnumerable<CalculationMaterialsDTO> GetCalculationMaterials(int calcId);


        int CalculationCreate(CalculationDTO calculationDTO);
        void CalculationUpdate(CalculationDTO calculationDTO);
        bool CalculationDelete(int id);


        int CalculationMaterialsCreate(CalculationMaterialsDTO calculationMaterialsDTO);
        void CalculationMaterialsUpdate(CalculationMaterialsDTO calculationMaterialsDTO);
        bool CalculationMaterialsDelete(int id);


    }
}
