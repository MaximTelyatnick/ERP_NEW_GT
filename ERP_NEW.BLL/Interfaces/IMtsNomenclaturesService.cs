using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
   public interface IMtsNomenclaturesService
    {
       IEnumerable<MtsNomenclaturesDTO> GetNomenclarures();
       IEnumerable<MtsGostsDTO> GetGosts();
       IEnumerable<UnitsDTO> GetUnits();
       IEnumerable<MtsNomenclatureGroupsDTO> GetNomenclatureGroups();
       IEnumerable<MtsAdditCalculationsDTO> GetAdditCalculationUnits();
       IEnumerable<MtsNomenclaturesDTO> GetMaterialsBySpecificationId(long specId, short materialStatus); //1 - PurchasedProducts, 2 - Materials

       long NomenclarureCreate(MtsNomenclaturesDTO mtsNomenclature);
       void NomenclarureUpdate(MtsNomenclaturesDTO mtsNomenclature);
       bool NomenclarureDelete(long id);
       
       long GostCreate(MtsGostsDTO mtsGost);
       void GostUpdate(MtsGostsDTO mtsGost);
       bool GostDelete(long id);
       
       int NomenclarureGroupCreate(MtsNomenclatureGroupsDTO mtsNomenclatureGroup);
       void NomenclarureGroupUpdate(MtsNomenclatureGroupsDTO mtsNomenclatureGroup);
       bool NomenclarureGroupDelete(int id);

       void Dispose();
    }
}
