using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ReportsDTO;
using ERP_NEW.DAL.Entities.ReportModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IFixedAssetsOrderService
    {
        IEnumerable<FixedAssetsOrderJournalDTO> GetFixedAssetsOrderJournal(DateTime startDate);
        IEnumerable<FixedAssetsGroupDTO> GetFixedAssestGroup();
        IEnumerable<FixedAssetsMaterialsDTO> GetFixedAssestMaterials(int fixedAssetsOrderId, DateTime endDate);
        IEnumerable<RegionDTO> GetRegion();
        IEnumerable<FixedAssetsOrderListMaterialsJournalDTO> GetExpendituresForFixedAssetsMaterials(DateTime startDate, DateTime endDate);
        IEnumerable<FixedAssetsOrderArchiveJournalDTO> GetFixedAssetsOrderArchive(DateTime startDate, DateTime endDate);
        bool GetContainFixedAssetsMaterials(int idItem);
        IEnumerable<FixedAssetsOrderJournalPrintDTO> GetFixedAssetsOrderJournalPrint(DateTime endDate);
        IEnumerable<FixedAssetsOrderDTO> GetFixedAssestsOrder();
        IEnumerable<FixedAssetsMaterialsDTO> GetAllFixedAssetsMaterials();
        IEnumerable<FixedAssetsOrderMaterialsPrintJournalDTO> GetFixedAssetsMateriaslForPrint(DateTime endDate);
        IEnumerable<FixedAssetsOrderRegJournalDTO> GetFixedAssetsOrderRegistration(DateTime startDate, DateTime endDate);

        IEnumerable<FixedAssetsOrderReportStraitDTO> GetFixedAssetsReportStrait(DateTime endDate);
        IEnumerable<FixedAssetsOrderReportStraitDTO> GetFixedAssetsOrderByGroupAmortization(DateTime endDate);
        IEnumerable<FixedAssetsOrderByGroupShortReportDTO> GetFixedAssetsByGroupShort(DateTime beginDate, DateTime endDate);
        IEnumerable<FixedAssetsReportRegisterCh1DTO> GetFixedAssetsReportRegisterCh1(DateTime endDate);
        IEnumerable<FixedAssetsReportRegisterCh2DTO> GetFixedAssetsReportRegisterCh2(DateTime beginDate, DateTime endDate);
        IEnumerable<InputFixedAssetsForGroupDTO> GetInputFixedAssetsForGroup(DateTime beginDate, DateTime endDate);
        IEnumerable<InputFixedAssetsForQuarterDTO> GetInputFixedForQuarter(DateTime beginDate, DateTime endDate);
        IEnumerable<FixedAssetsOrderReportStraitDTO> GetInventoryFixedAssetsForGroups(DateTime endDate);

        FixedAssetsOrderRegistrationDTO GetByFixedAssetsOrderId(int id, int type);

        IEnumerable<FixedAssetsMaterialsDTO> GetFixedAssetsMaterialsByFixedAssetsId(int fixedAssetsId);

        IEnumerable<FixedAssetsNoAmortDTO> GetFixedAssestAmortizationDateById(int fixedAssetsOrderId);

        int FixedAssetsOrderCreate(FixedAssetsOrderDTO fixedAssetsOrderDTO);
        void FixedAssetsOrderUpdate(FixedAssetsOrderDTO fixedAssetsOrderDTO);
        bool FixedAssetsOrderDelete(int id);

        int FixedAssetsOrderMaterialsCreate(FixedAssetsMaterialsDTO fixedAssetsMaterialsDTO);
        void FixedAssetsOrderMaterialsUpdate(FixedAssetsMaterialsDTO fixedAssetsMaterialsDTO);
        bool FixedAssetsOrderMaterialsDelete(int id);

        int FixedAssetsOrderRegistrationCreate(FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistrationDTO);
        void FixedAssetsOrderRegistrationUpdate(FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistrationDTO);
        bool FixedAssetsOrderRegistrationDelete(int id);

        int FixedAssetsNoAmortCreate(FixedAssetsNoAmortDTO fixedAssetsNoAmortDTO);
        void FixedAssetsNoAmortUpdate(FixedAssetsNoAmortDTO fixedAssetsNoAmortDTO);
        bool FixedAssetsNoAmortDelete(int id);

        int FixedAssetsOrderGroupCreate(FixedAssetsGroupDTO fixedAssetsOrderGroupDTO);
        void FixedAssetsOrderGroupUpdate(FixedAssetsGroupDTO fixedAssetsOrderGroupDTO);
        bool FixedAssetsOrderGroupDelete(int id);

        int RegionCreate(RegionDTO regionDTO);
        void RegionUpdate(RegionDTO regionDTO);
        bool RegionDelete(int id);


        IEnumerable<ResponsibleDTO> GetResponsible();

        void Dispose();
    }
}
