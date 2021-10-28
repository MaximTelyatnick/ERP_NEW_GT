using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IStoreHouseService
    {
        IEnumerable<AccountClothesInfoDTO> GetAccountClothes();

        IEnumerable<DeliveryDTO> GetAllDelivery();
        
        IEnumerable<AccountClothesDTO> GetAllAccountClothes();

        IEnumerable<AccountClothesMaterialsDTO> GetAccountClothesMaterials(int id);

        IEnumerable<AccountClothesMaterialsDTO> GetAccountClothesMaterialsProc(int id);

        IEnumerable<StoreHouseRemainsDTO> GetStoreHouseRemainsByDate(DateTime startDate);

        IEnumerable<StoreHouseRemainsDTO> GetStoreHouseRemainsWithinvoicesByDate(DateTime startDate);
        
        IEnumerable<AccountClothesJournalDTO> GetAccountClothesByCard(DateTime beginDate, DateTime endDate);

        IEnumerable<AccountClothesJournalDTO> GetAccountClothesByCardProc(DateTime beginDate, DateTime endDate);

        IEnumerable<AccountClothesJournalDTO> GetAccountClothByDateOutputProc(DateTime beginDate, DateTime endDate);

        IEnumerable<AccountClothesJournalDTO> GetAccountClothByDateReturnProc(DateTime beginDate, DateTime endDate);
        
        IEnumerable<AccountClothesJournalDTO> GetAccountClothesByDateOutput(DateTime beginDate, DateTime endDate);
        
        IEnumerable<AccountClothesJournalDTO> GetAccountClothesByDateReturn(DateTime beginDate, DateTime endDate);

        IEnumerable<MaterialsForAccountClothesDTO> GetMaterialsForAccountClothes(DateTime beginDate, DateTime endDate);

        IEnumerable<InvoiceRequirementMaterialsInfoDTO> GetInvoiceMaterialsByOrderId(int id);

        IEnumerable<InvoiceRequirementMaterialsInfoDTO> GetInvoiceMaterialsForStoreHouseByOrderId(int id);

        IEnumerable<InvoiceRequirementOrdersDTO> GetAllInvoiceRequirementOrders(DateTime beginDate, DateTime endDate);

        IEnumerable<InvoiceRequirementOrdersDTO> GetAllInvoiceRequirementOrdersForProduction(DateTime beginDate, DateTime endDate);
        
        IEnumerable<NomenclaturesDTO> GetAllNomenclatures();

        IEnumerable<NomenclaturesDTO> GetNomenclatureWithAccountNumber(string nomenclature);

        IEnumerable<StorehousesDTO> GetAllStorehouses();

        IEnumerable<StorehousesDTO> GetAllStorehousesWithNumber();

        IEnumerable<InvoiceRequirementExpenditureInfoDTO> GetInvoiceRequirementExpenditureInfo(DateTime beginDate, DateTime endDate);

        IEnumerable<InvoiceRequirementSelectFixedAssetsDTO> GetAllInvoiceRequirementSelectFixedAssets();

        IEnumerable<NomenclatureGroupsDTO> GetAllNomenclaturesGroups();

        IEnumerable<NomenclaturesDTO> GetAllNomenclaturesMaterials(int id);

        string GetLastNomenclatureNumber(int accountId, string name);

        IEnumerable<OrdersInfoDTO> GetReceiptsByPeriod(DateTime beginDate, DateTime endDate);

        IEnumerable<ReceiptOrdersDTO> GetOrdersByPeriod(DateTime beginDate, DateTime endDate);

        IEnumerable<ReceiptsDTO> GetReceiptsByOrderId(int orderId);

        IEnumerable<ReceiptJournalDTO> GetReceiptByOrderIdProc(int orderId);

        IEnumerable<ToolActsDTO> GetAllToolActs(DateTime firstDate, DateTime lastDate);

        IEnumerable<ToolActMaterialsJournalDTO> GetToolActMaterialsById(int id);

        IEnumerable<MaterialsForToolActsDTO> GetMaterialsForToolActs(DateTime beginDate, DateTime endDate);

        IEnumerable<ReceiptHistoryOrdersDTO> GetReceiptsByNomenclaturesId(int nomenclatureId, DateTime beginDate, DateTime endDate);

        IEnumerable<InvoiceRequirementMaterialsDTO> GetInvoiceRequirementMaterial(int receiptId);

        IEnumerable<InvoiceRequirementMaterialsDTO> GetInvoiceRequirementMaterial(int receiptId, decimal quantity);

        IEnumerable<AccountOrdersDTO> GetAccountOrderJournal(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4);

        IEnumerable<DeliveryOrdersDetailsDTO> DeliveryOrdersDetails();
        IEnumerable<DeliveryOrderDTO> GetDeliveryOrder(DateTime beginDate, DateTime endDate);

        IEnumerable<DeliveryDTO> GetDelivery();

        IEnumerable<DeliveryPaymentTypeDTO> GetDeliveryPaymentType();

        IEnumerable<DeliveryOrdersDetailsDTO> GetDeliveryOrdersDetailsByOrderid(long orderId);

        IEnumerable<ExpenditureInfoDTO> GetExpenditureJournalByPeriod(DateTime beginDate, DateTime endDate);

        IEnumerable<RemainsNomenclatureDTO> GetRemainsByNomenclatureId(int nomenclatureId, DateTime startDate);

        IEnumerable<InvoiceRequirementMaterialsDTO> GetContainInvoiceRequirementMaterials(int idItem);
        IEnumerable<StoreHouseReceiptProjectDTO> GetStoreHouseReceiptProject(DateTime startDate);

        IEnumerable<ExpedinturesAccountantDTO> GetExpendituresAccountant();

        IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHouses();
        IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHousesMaterial(int receiptId, decimal quantity, string customerOrderNumber);
        IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHousesMaterial(int receiptId);

        //IEnumerable<ExpendituresStoreHousesInfoDTO> GetExpendituresStoreHousesInfoByPeriod(DateTime beginDate, DateTime endDate);
        IEnumerable<ExpenditureStoreHouseInfoDTO> GetExpendituresStoreHousesInfoByPeriod(DateTime beginDate, DateTime endDate);

        IEnumerable<ExpenditureInfoDTO> GetExpenditureByCustomerOrder(int customerOrderId);
        IEnumerable<ExpenditureInfoDTO> GetExpenditureByCustomerOrder(string customerOrderNumber);
        IEnumerable<ExpenditureTotalPriceDTO> GetExpenditureTotalPriceByCustomerOrderId(int customerOrderId);
        IEnumerable<ExpenditureTotalPriceDTO> GetExpenditureAccTotalPriceByCustomerOrderId(int customerOrderId, int flag = 0);

        IEnumerable<InvoicesFixedAssetsInfoDTO> GetInvoicesFixedAssetsInfo(DateTime startDate, DateTime endDate);
        IEnumerable<OrderReceipFromQueryDTO> GetOrderReceipFromQueryProc(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4);
        IEnumerable<OrderReceipFromQueryDTO> GetOrderReceipFromQuery(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4);
        //void FakseInsertOrders(int id);
        
        bool GetReceiptsByStoreHouseId(int id);

        int AccountClothesCreate(AccountClothesDTO accountClothesDTO);
        void AccountClothesUpdate(AccountClothesDTO accountClothesDTO);
        bool AccountClothesDelete(int id);

        int AccountClothesMaterialsCreate(AccountClothesMaterialsDTO accountClothesMaterialsDTO);
        void AccountClothesMaterialsCreateRange(List<AccountClothesMaterialsDTO> source);
        void AccountClothesMaterialsUpdate(AccountClothesMaterialsDTO accountClothesMaterialsDTO);
        bool AccountClothesMaterialsRemoveRange(List<AccountClothesMaterialsDTO> source);

        int InvoiceRequirementOrderCreate(InvoiceRequirementOrdersDTO invoiceRequirementOrderDTO);
        void InvoiceRequirementOrderUpdate(InvoiceRequirementOrdersDTO invoiceRequirementOrdersDTO);
       // void InvoiceRequirementOrderUpdate(InvoiceRequirementOrdersDTO iroDTO, bool afterCreate = false);
        bool InvoiceRequirementOrderDelete(int id);
        LastIdInvoicesReqGenDTO LastInvoicesRequirementId();
        int InvoiceRequirementCreateDirect(InvoiceRequirementOrdersDTO iroDTO);

        int InvoiceRequirementMaterialCreate(InvoiceRequirementMaterialsDTO invoiceRequirementMaterialsDTO);
        void InvoiceRequirementMaterialUpdate(InvoiceRequirementMaterialsDTO invoiceRequirementMaterialsDTO);
        void InvoiceRequirementMaterialCreateRange(List<InvoiceRequirementMaterialsDTO> source);
        bool InvoiceRequirementMaterialRemoveRange(List<InvoiceRequirementMaterialsDTO> source);
        LastIdInvoicesReqMatGenDTO LastInvoicesRequirementMatId();
        int InvoiceRequirementMaterialCreateDirect(InvoiceRequirementMaterialsDTO irmoDTO);
        IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHousesByPeriod(DateTime beginDate, DateTime endDate);

        int StoreHousesCreate(StorehousesDTO storehousesDTO);
        void StoreHousesUpdate(StorehousesDTO storehousesDTO);
        bool StoreHousesDelete(int id);

        int NomenclatureGroupCreate(NomenclatureGroupsDTO ngDTO);
        void NomenclatureGroupUpdate(NomenclatureGroupsDTO ngDTO);
        bool NomenclatureGroupDelete(int id);

        int NomenclatureMaterialsCreate(NomenclaturesDTO nmDTO);
        void NomenclatureMaterialsUpdate(NomenclaturesDTO nmDTO);
        bool NomenclatureMaterialsDelete(int id);

        int ToolActsCreate(ToolActsDTO taDTO);
        void ToolActsUpdate(ToolActsDTO taDTO);
        bool ToolActsDelete(int id);

        int ToolActMaterialCreate(ToolActMaterialsDTO tamDTO);
        void ToolActsMaterialUpdate(ToolActMaterialsDTO tamDTO);
        void ToolActMaterialCreateRange(List<ToolActMaterialsDTO> source);
        bool ToolActMaterialRemoveRange(List<ToolActMaterialsDTO> source);

        int OrderCreate(OrdersDTO oDTO);
        void OrderUpdate(OrdersDTO oDTO, bool afterCreate = false);
        LastIdOrderGenDTO OrderLastId();
        int OrderCreateDirect();

        bool OrderDelete(int id);

        int ReceiptCreate(ReceiptsDTO rDTO);
        int ReceiptCreateDirect();
        int ReceiptUpdateDirect(ReceiptsDTO receiptsDTO);
        LastIdReceiptGenDTO ReceiptLastId();
        void ReceiptUpdate(ReceiptsDTO rDTO);
        void ReceiptCreateRange(List<ReceiptsDTO> source);
        bool ReceiptRemoveRange(List<ReceiptsDTO> source);
        bool ReceiptDelete(int id);

        int DeliveryCreate(DeliveryDTO delDTO);
        void DeliveryUpdate(DeliveryDTO delDTO);
        bool DeliveryDelete(int id);

        int DeliveryOrderCreate(DeliveryOrderDTO docDTO);
        void DeliveryOrderUpdate(DeliveryOrderDTO docDTO);
        bool DeliveryOrderDelete(int id);

        int DeliveryOrdersDetailsCreate(DeliveryOrdersDetailsDTO dodDTO);
        void DeliveryOrdersDetailsUpdate(DeliveryOrdersDetailsDTO dodDTO);
        bool DeliveryOrdersDetailsDelete(int id);


        int VatCreate(VatDTO taDTO);
        int VatCreateDirect(int orderId);
        void VatUpdate(VatDTO taDTO);
        bool VatDelete(int id);

        int ExpendituresAccountantCreate(ExpedinturesAccountantDTO eaDTO);
        void ExpendituresAccountantUpdate(ExpedinturesAccountantDTO eaDTO);
        bool ExpendituresAccountantDelete(int id);

        int ExpendituresStoreHousesCreate(ExpendituresStoreHousesDTO eaDTO);
        void ExpendituresStoreHousesUpdate(ExpendituresStoreHousesDTO eaDTO);
        bool ExpendituresStoreHousesDelete(int id);

        int ExpenditureStoreHouseCreate(ExpenditureStoreHouseDTO eaDTO);
        void ExpenditureStoreHouseUpdate(ExpenditureStoreHouseDTO eaDTO);
        bool ExpenditureStoreHouseDelete(int id);

        void Dispose();



        
    }
}
