using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IMtsSpecificationsService
    {
        List<MtsSpecificationTreeInfoDTO> GetMtsSpecificationTreeInfoByRootId(long id);
        IEnumerable<MtsAssembliesInfoDTO> GetJournalAssemblies();
        IEnumerable<MtsAssembliesInfoDTO> GetMtsAssemblies(DateTime beginDate, DateTime endDate);
        

        IEnumerable<MtsAssembliesDTO> GetMtsAssembliesByRoot(long rootId);
        IEnumerable<MtsDetailsInfoDTO> GetDetailsBySpecificationId(long specId);
        IEnumerable<MtsAssembliesDTO> GetAllMtsAssemblies();
        MtsAssembliesDTO GetMtsAssemblyById(long id);
        MtsAssembliesInfoDTO GetSingleMtsAssemblyInfo(long id);
        IEnumerable<MtsAssembliesInfoDTO> GetMtsAssembliesAll(DateTime beginDate, DateTime endDate);
        IEnumerable<MtsAssembliesCustomerInfoDTO> GetJournalAssembliesWithCustomerOrders();


        IEnumerable<MTSSpecificationssDTO> GetAllSpecificationOld();
        IEnumerable<MTSSpecificationssDTO> GetAllSpecificationOldByPeriod(DateTime startDate, DateTime endDate);
        //IEnumerable<MTSCreateDetalsDTO> GetAllDetailsSpecific(int spesificId);
        IEnumerable<MTSDetailsDTO> GetAllDetailsSpecific(int spesificId);
        IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecific(int spesificId);
        IEnumerable<MTSMaterialsDTO> GetMaterialsSpecific(int spesificId);

        IEnumerable<MTSNomenclatureGroupsOldDTO> GetAllNomenclatureGroupsOld();
        IEnumerable<MTSNomenclaturesOldDTO> GetAllNomenclatures(int nomenGroupId);
        IEnumerable<MTSDetalsProcessingDTO> GetDetailsProccesing();
        IEnumerable<MTSCreateDetalsDTO> GetAllCreateDetals();
        MTSCreateDetalsDTO GetCreateDetalsByDrawingNumber(string drawignNumber);

        IEnumerable<MTSDetailsDTO> GetAllDetailsSpecificShort(int specificId);
        IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecificShort(int specificId);
        IEnumerable<MTSMaterialsDTO> GetMaterialsSpecificShort(int specificId);
        

        long CreateAssembly(MtsAssembliesDTO mtsAssembly);
        void UpdateAssembly(MtsAssembliesDTO mtsAssembly);
        void UpdateAssemblyDesignerCompany(int mtsAssemblyId, int designerCompanyId);
        bool DeleteAssembly(long id);
        
        long CreateSpecification(MtsSpecificationsDTO mtsSpecification);
        void UpdateSpecification(MtsSpecificationsDTO mtsSpecification);
        bool DeleteSpecification(long id);

        int MTSSpecificationCreate(MTSSpecificationssDTO mtsSpecificationDTO);
        void MTSSpecificationUpdate(MTSSpecificationssDTO mtsSpecificationDTO);

        bool MTSSpecificationDelete(int id);

        int MTSCreateDetailsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        void MTSCreateDetailsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        bool MTSCreateDetailsDelete(int id);

        int MTSDetailCreate(MTSDetailsDTO mtsDetalsDTO);
        void MTSDetailUpdate(MTSDetailsDTO mtsDetalsDTO);
        bool MTSDetailDelete(int id);

        int MTSPurchasedProductsCreate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO);
        void MTSPurchasedProductsCreateRange(List<MTSPurchasedProductsDTO> source);
        void MTSPurchasedProductsUpdate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO);
        bool MTSPurchasedProductsDelete(int id);

        int MTSMaterialCreate(MTSMaterialsDTO mtsMaterialsDTO);
        void MTSMaterialCreateRange(List<MTSMaterialsDTO> source);
        void MTSMaterialUpdate(MTSMaterialsDTO mtsMaterialsDTO);
        bool MTSMaterialDelete(int id);

        int MTSDetailsCreate(MTSDetailsDTO mtsDetailsDTO);
        void MTSDetailsCreateRange(List<MTSDetailsDTO> source);
        void MTSDetailsUpdate(MTSDetailsDTO mtsDetailsDTO);
        //bool MTSDetailDelete(int id);

        int MTSCreateDetalsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        void MTSCreateDetalsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO);
        bool MTSCreateDetalDelete(int id);
        

        void Dispose();
    }
}
