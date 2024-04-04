using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities.Models;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ERP_NEW.BLL.Infrastructure;

namespace ERP_NEW.BLL.Services
{
    public class StoreHouseService : IStoreHouseService
    {
        private IUnitOfWork Database { get; set; }

        #region Repository

        private IRepository<AccountClothes> accountClothes;
        private IRepository<AccountClothesInfo> accountClothesInfo;
        private IRepository<AccountClothesMaterials> accountClothesMaterials;
        private IRepository<AccountClothesJournal> accountClothesJournal;
        private IRepository<AccountOrders> accountOrders;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<Delivery> delivery;
        private IRepository<DeliveryOrder> deliveryOrder;
        private IRepository<DeliveryOrdersDetails> deliveryOrdersDetails;
        private IRepository<DeliveryPaymentType> deliveryPaymentType;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<Employees> employees;
        private IRepository<EXPENDITURES_ACCOUNTANT> expenditureAccountant;
        private IRepository<ExpenditureStoreHouse> expenditureStoreHouse;
        private IRepository<ExpendituresStoreHouses> expendituresStoreHouses;
        private IRepository<ExpendituresStoreHousesInfo> expendituresStoreHousesInfo;
        private IRepository<ExpenditureTotalPrice> expenditureTotalPrice;
        private IRepository<ExpenditureInfo> expenditureInfo;
        private IRepository<Professions> professions;
        private IRepository<Departments> departments;
        private IRepository<FixedAssetsOrder> fixedAssetsOrder;
        private IRepository<FixedAssetsGroup> fixedAssetsGroup;
        private IRepository<RECEIPTS> receipts;
        private IRepository<ReceiptJournal> receiptJournal;
        private IRepository<RemainsNomenclature> remainsNomenclature;
        private IRepository<NOMENCLATURES> nomenclatures;
        private IRepository<Nomenclature_Groups> nomenclaturesGroups;
        private IRepository<ACCOUNTS> accounts;
        private IRepository<ACCOUNTS> accountss;
        private IRepository<Units> units;
        private IRepository<Invoice_Requirement_Orders> invoiceRequirementOrders;
        private IRepository<InvoiceRequirementMaterialsInfo> invoiceRequirementMaterialsInfo;
        private IRepository<MaterialsForAccountClothes> materialsForAccountsClothes;
        private IRepository<Invoice_Requirement_Materials> invoiceRequirementMaterials;
        private IRepository<InvoiceRequirementExpenditureInfo> invoiceRequirementExpenditureInfo;
        private IRepository<InvoicesFixedAssetsInfo> invoicesFixedAssetsInfo;
        private IRepository<StoreHouseRemains> storeHouseRemains;
        private IRepository<Storehouses> storeHouses;
        private IRepository<StoreHouseReceiptProject> storeHouseReceiptProject;
        private IRepository<ExpenditureStoreHouseInfo> expenditureStoreHouseInfo;
        private IRepository<ORDERS> orders;
        private IRepository<OrderReceipFromQuery> orderReceipFromQuery;
        private IRepository<Contractors> contractors;
        private IRepository<ReceiptOrders> receiptOrders;
        private IRepository<ReceiptCertificates> receiptCertificate;
        private IRepository<ReceiptCertificateDetail> receiptCertificateDetail;
        private IRepository<ToolActs> toolActs;
        private IRepository<ToolActMaterials> toolActMaterials;
        private IRepository<ToolActMaterialsJournal> toolActMaterialsJournal;
        private IRepository<MaterialsForToolActs> materialsForToolActs;
        private IRepository<LastIdOrderGen> lastIdOrderGen;
        private IRepository<LastIdReceiptGen> lastIdReceiptGen;
        private IRepository<LastIdInvoicesReqGen> lastIdInvoicesReqGen;
        private IRepository<LastIdInvoicesReqMatGen> lastIdInvoicesReqMatGen;
        private IRepository<VAT> vat;

        #endregion

        private IMapper mapper;

        public StoreHouseService(IUnitOfWork uow)
        {
            #region Repository
            
            Database = uow;
            accounts = Database.GetRepository<ACCOUNTS>();
            accountss = Database.GetRepository<ACCOUNTS>();
            accountOrders = Database.GetRepository<AccountOrders>();
            accountClothes = Database.GetRepository<AccountClothes>();
            accountClothesInfo = Database.GetRepository<AccountClothesInfo>();
            accountClothesJournal = Database.GetRepository<AccountClothesJournal>();
            accountClothesMaterials = Database.GetRepository<AccountClothesMaterials>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            employees = Database.GetRepository<Employees>();
            expenditureAccountant = Database.GetRepository<EXPENDITURES_ACCOUNTANT>();
            expenditureStoreHouse = Database.GetRepository<ExpenditureStoreHouse>();
            expendituresStoreHouses = Database.GetRepository<ExpendituresStoreHouses>();
            expendituresStoreHousesInfo = Database.GetRepository<ExpendituresStoreHousesInfo>();
            expenditureStoreHouseInfo = Database.GetRepository<ExpenditureStoreHouseInfo>();
            expenditureInfo = Database.GetRepository<ExpenditureInfo>();
            expenditureTotalPrice = Database.GetRepository<ExpenditureTotalPrice>();
            delivery = Database.GetRepository<Delivery>();
            deliveryOrder = Database.GetRepository<DeliveryOrder>();
            deliveryOrdersDetails = Database.GetRepository<DeliveryOrdersDetails>();
            deliveryPaymentType = Database.GetRepository<DeliveryPaymentType>();
            departments = Database.GetRepository<Departments>();
            fixedAssetsOrder = Database.GetRepository<FixedAssetsOrder>();
            fixedAssetsGroup = Database.GetRepository<FixedAssetsGroup>();
            professions = Database.GetRepository<Professions>();
            receipts = Database.GetRepository<RECEIPTS>();
            receiptJournal = Database.GetRepository<ReceiptJournal>();
            remainsNomenclature = Database.GetRepository<RemainsNomenclature>();
            nomenclatures = Database.GetRepository<NOMENCLATURES>();
            nomenclaturesGroups = Database.GetRepository<Nomenclature_Groups>();
            units = Database.GetRepository<Units>();
            invoiceRequirementOrders = Database.GetRepository<Invoice_Requirement_Orders>();
            invoiceRequirementMaterialsInfo = Database.GetRepository<InvoiceRequirementMaterialsInfo>();
            invoiceRequirementMaterials = Database.GetRepository<Invoice_Requirement_Materials>();
            invoiceRequirementExpenditureInfo = Database.GetRepository<InvoiceRequirementExpenditureInfo>();
            invoicesFixedAssetsInfo = Database.GetRepository<InvoicesFixedAssetsInfo>();
            materialsForAccountsClothes = Database.GetRepository<MaterialsForAccountClothes>();
            storeHouseRemains = Database.GetRepository<StoreHouseRemains>();
            storeHouses = Database.GetRepository<Storehouses>();
            storeHouseReceiptProject = Database.GetRepository<StoreHouseReceiptProject>();
            orders = Database.GetRepository<ORDERS>();
            orderReceipFromQuery = Database.GetRepository<OrderReceipFromQuery>();
            contractors = Database.GetRepository<Contractors>();
            receiptOrders = Database.GetRepository<ReceiptOrders>();
            receiptCertificate = Database.GetRepository<ReceiptCertificates>();
            receiptCertificateDetail = Database.GetRepository<ReceiptCertificateDetail>();
            toolActs = Database.GetRepository<ToolActs>();
            toolActMaterials = Database.GetRepository<ToolActMaterials>();
            toolActMaterialsJournal = Database.GetRepository<ToolActMaterialsJournal>();
            materialsForToolActs = Database.GetRepository<MaterialsForToolActs>();
            lastIdOrderGen = Database.GetRepository<LastIdOrderGen>();
            lastIdReceiptGen = Database.GetRepository<LastIdReceiptGen>();
            lastIdInvoicesReqGen = Database.GetRepository<LastIdInvoicesReqGen>();
            lastIdInvoicesReqMatGen = Database.GetRepository<LastIdInvoicesReqMatGen>();
            vat = Database.GetRepository<VAT>();

            #endregion

            #region Mapper's
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AccountClothes, AccountClothesDTO>();
                cfg.CreateMap<AccountClothesDTO, AccountClothes>();
                cfg.CreateMap<AccountOrdersDTO, AccountOrders>();
                cfg.CreateMap<AccountOrders, AccountOrdersDTO>();
                cfg.CreateMap<AccountClothesJournal, AccountClothesJournalDTO>();
                cfg.CreateMap<CustomerOrdersDTO, CustomerOrders>();
                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                cfg.CreateMap<EXPENDITURES_ACCOUNTANT, ExpedinturesAccountantDTO>();
                cfg.CreateMap<ExpedinturesAccountantDTO, EXPENDITURES_ACCOUNTANT>();
                cfg.CreateMap<ExpendituresStoreHouses, ExpendituresStoreHousesDTO>();
                cfg.CreateMap<ExpendituresStoreHousesDTO, ExpendituresStoreHouses>();
                cfg.CreateMap<ExpenditureStoreHouse, ExpenditureStoreHouseDTO>();
                cfg.CreateMap<ExpenditureStoreHouseDTO, ExpenditureStoreHouse>();
                cfg.CreateMap<ExpendituresStoreHousesInfo, ExpendituresStoreHousesInfoDTO>();
                cfg.CreateMap<ExpendituresStoreHousesInfoDTO, ExpendituresStoreHousesInfo>();
                cfg.CreateMap<ExpenditureStoreHouseInfo, ExpenditureStoreHouseInfoDTO>();
                cfg.CreateMap<ExpenditureStoreHouseInfoDTO, ExpenditureStoreHouseInfo>();
                cfg.CreateMap<ExpenditureTotalPrice, ExpenditureTotalPriceDTO>();
                cfg.CreateMap<EmployeesDetails, EmployeesDetailsDTO>();
                cfg.CreateMap<EmployeesDetailsDTO, EmployeesDetails>();
                cfg.CreateMap<Employees, EmployeesDTO>();
                cfg.CreateMap<EmployeesDTO, Employees>();
                cfg.CreateMap<ExpenditureInfo, ExpenditureInfoDTO>();
                cfg.CreateMap<Professions, ProfessionsDTO>();
                cfg.CreateMap<ProfessionsDTO, Professions>();
                cfg.CreateMap<Delivery, DeliveryDTO>();
                cfg.CreateMap<DeliveryDTO, Delivery>();
                cfg.CreateMap<DeliveryOrder, DeliveryOrderDTO>();
                cfg.CreateMap<DeliveryOrderDTO, DeliveryOrder>();
                cfg.CreateMap<DeliveryOrdersDetails, DeliveryOrdersDetailsDTO>();
                cfg.CreateMap<DeliveryOrdersDetailsDTO, DeliveryOrdersDetails>();
                cfg.CreateMap<DeliveryPaymentType, DeliveryPaymentTypeDTO>();
                cfg.CreateMap<DeliveryPaymentTypeDTO, DeliveryPaymentType>();
                cfg.CreateMap<Departments, DepartmentsDTO>();
                cfg.CreateMap<DepartmentsDTO, Departments>();
                cfg.CreateMap<AccountClothesInfo, AccountClothesInfoDTO>();
                cfg.CreateMap<AccountClothesInfoDTO, AccountClothesInfo>();
                cfg.CreateMap<AccountClothesMaterials, AccountClothesMaterialsDTO>();
                cfg.CreateMap<AccountClothesMaterialsDTO, AccountClothesMaterials>();
                cfg.CreateMap<NOMENCLATURES, NomenclaturesDTO>();
                cfg.CreateMap<NomenclaturesDTO, NOMENCLATURES>();
                cfg.CreateMap<Invoice_Requirement_Orders, InvoiceRequirementOrdersDTO>();
                cfg.CreateMap<InvoiceRequirementOrdersDTO, Invoice_Requirement_Orders>();
                cfg.CreateMap<Invoice_Requirement_Materials, InvoiceRequirementMaterialsDTO>();
                cfg.CreateMap<InvoiceRequirementMaterialsDTO, Invoice_Requirement_Materials>();
                cfg.CreateMap<InvoiceRequirementMaterialsInfo, InvoiceRequirementMaterialsInfoDTO>();
                cfg.CreateMap<InvoiceRequirementMaterialsInfoDTO, InvoiceRequirementMaterialsInfo>();
                cfg.CreateMap<MaterialsForAccountClothes, MaterialsForAccountClothesDTO>();
                cfg.CreateMap<InvoiceRequirementExpenditureInfoDTO, InvoiceRequirementExpenditureInfo>();
                cfg.CreateMap<InvoiceRequirementExpenditureInfo, InvoiceRequirementExpenditureInfoDTO>();
                cfg.CreateMap<InvoicesFixedAssetsInfo, InvoicesFixedAssetsInfoDTO>();
                cfg.CreateMap<InvoicesFixedAssetsInfoDTO, InvoicesFixedAssetsInfo>();
                cfg.CreateMap<StoreHouseRemainsDTO, StoreHouseRemains>();
                cfg.CreateMap<StoreHouseRemains, StoreHouseRemainsDTO>();
                cfg.CreateMap<Storehouses, StorehousesDTO>();
                cfg.CreateMap<StorehousesDTO, Storehouses>();
                cfg.CreateMap<StoreHouseReceiptProject, StoreHouseReceiptProjectDTO>();
                cfg.CreateMap<StoreHouseReceiptProjectDTO, StoreHouseReceiptProject>();
                cfg.CreateMap<ReceiptsDTO, RECEIPTS>().IgnoreAllPropertiesWithAnInaccessibleSetter().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                cfg.CreateMap<ReceiptJournalDTO, ReceiptJournal>();
                cfg.CreateMap<ReceiptJournal, ReceiptJournalDTO>();
                cfg.CreateMap<RemainsNomenclature, RemainsNomenclatureDTO>();
                cfg.CreateMap<Nomenclature_Groups, NomenclatureGroupsDTO>();
                cfg.CreateMap<NomenclatureGroupsDTO, Nomenclature_Groups>();
                cfg.CreateMap<ReceiptOrders, ReceiptOrdersDTO>();
                cfg.CreateMap<ReceiptCertificates, ReceiptCertificatesDTO>();
                cfg.CreateMap<ReceiptCertificateDetail, ReceiptCertificateDetailDTO>();
                cfg.CreateMap<ToolActs, ToolActsDTO>();
                cfg.CreateMap<ToolActsDTO, ToolActs>();
                cfg.CreateMap<ToolActMaterials,ToolActMaterialsDTO>();
                cfg.CreateMap<ToolActMaterialsDTO, ToolActMaterials>();
                cfg.CreateMap<ToolActMaterialsJournal, ToolActMaterialsJournalDTO>();
                cfg.CreateMap<ToolActMaterialsJournalDTO, ToolActMaterialsJournal>();
                cfg.CreateMap<MaterialsForToolActs, MaterialsForToolActsDTO>();
                cfg.CreateMap<MaterialsForToolActsDTO, MaterialsForToolActs>();
                cfg.CreateMap<ORDERS, OrdersDTO>();
                cfg.CreateMap<OrdersDTO, ORDERS>();
                cfg.CreateMap<OrderReceipFromQuery, OrderReceipFromQueryDTO>();
                cfg.CreateMap<OrderReceipFromQueryDTO, OrderReceipFromQuery>();
                cfg.CreateMap<LastIdOrderGen, LastIdOrderGenDTO>();
                cfg.CreateMap<LastIdOrderGenDTO, LastIdOrderGen>();
                cfg.CreateMap<LastIdReceiptGen, LastIdReceiptGenDTO>();
                cfg.CreateMap<LastIdReceiptGenDTO, LastIdReceiptGen>();
                cfg.CreateMap<LastIdInvoicesReqGen, LastIdInvoicesReqGenDTO>();
                cfg.CreateMap<LastIdInvoicesReqGenDTO, LastIdInvoicesReqGen>();
                cfg.CreateMap<LastIdInvoicesReqMatGen, LastIdInvoicesReqMatGenDTO>();
                cfg.CreateMap<LastIdInvoicesReqMatGenDTO, LastIdInvoicesReqMatGen>();
                cfg.CreateMap<VAT, VatDTO>();
                cfg.CreateMap<VatDTO, VAT>();

            });

            mapper = config.CreateMapper();

            #endregion
        }

        #region Method's
        
        public IEnumerable<AccountClothesDTO> GetAllAccountClothes()
        {
            return mapper.Map<IEnumerable<AccountClothes>, List<AccountClothesDTO>>(accountClothes.GetAll());
        }

        public IEnumerable<DeliveryDTO> GetAllDelivery()
        {
            return mapper.Map<IEnumerable<Delivery>, List<DeliveryDTO>>(delivery.GetAll());
        }

        public IEnumerable<AccountClothesInfoDTO> GetAccountClothes()
        {
            string procName = @"select * from ""GetAccountClothes""";
            return mapper.Map<IEnumerable<AccountClothesInfo>, List<AccountClothesInfoDTO>>(accountClothesInfo.SQLExecuteProc(procName));
        }

        public IEnumerable<AccountClothesMaterialsDTO> GetAccountClothesMaterials(int id)
        {
            var result = (from acm in accountClothesMaterials.GetAll()
                          join irm in invoiceRequirementMaterials.GetAll() on acm.InvoiceRequirementMaterialId equals irm.Id
                          join r in receipts.GetAll() on irm.Receipt_Id equals r.ID
                          join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID
                          join a in accounts.GetAll() on n.BALANCE_ACCOUNT_ID equals a.ID
                          where acm.AccountClothesId == id
                          
                          select new AccountClothesMaterialsDTO()
                          {
                              Id = acm.Id,
                              AccountClothesId = acm.AccountClothesId,
                              InvoiceRequirementMaterialId = irm.Id,
                              QuantityOutput = acm.QuantityOutput,
                              QuantityReturn = acm.QuantityReturn,
                              DateOutput = acm.DateOutput,
                              DateReturn = acm.DateReturn,
                              PercentageOutput = acm.PercentageOutput,
                              PercentageReturn = acm.PercentageReturn,
                              BalanceAccountNum = a.NUM,
                              NomenclatureName = n.NAME,
                              NomenclatureNumber = n.NOMENCLATURE,
                              NomenclatureId = n.ID,
                              BalanceAccountId = a.ID,
                              //UnitPrice = r.UNIT_PRICE,
                              //TotalPrice = r.UNIT_PRICE * acm.QuantityOutput,
                              TotalPrice = ((decimal)r.TOTAL_PRICE / (decimal)r.QUANTITY) * (decimal)acm.QuantityOutput,
                              UnitPrice = ((decimal)r.TOTAL_PRICE / (decimal)r.QUANTITY) 

                          });
            return result.ToList();
        }

        public IEnumerable<AccountClothesMaterialsDTO> GetAccountClothesMaterialsProc(int id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("MaterialId", id)
                };

            string procName = @"select * from ""GetAccountClothesMaterialsProc""(@MaterialId)";

            return mapper.Map<IEnumerable<AccountClothesMaterials>, List<AccountClothesMaterialsDTO>>(accountClothesMaterials.SQLExecuteProc(procName, Parameters));
        }


        public IEnumerable<AccountClothesJournalDTO> GetAccountClothesByCardProc(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetAccountClothesByCard""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<AccountClothesJournal>, List<AccountClothesJournalDTO>>(accountClothesJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<AccountClothesJournalDTO> GetAccountClothByDateOutputProc(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetAccountClothByDateOutputProc""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<AccountClothesJournal>, List<AccountClothesJournalDTO>>(accountClothesJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<AccountClothesJournalDTO> GetAccountClothByDateReturnProc(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetAccountClothByDateReturnProc""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<AccountClothesJournal>, List<AccountClothesJournalDTO>>(accountClothesJournal.SQLExecuteProc(procName, Parameters));
        }


        //public IEnumerable<AccountClothesJournalDTO> GetAccountClothesByCardProc(DateTime beginDate, DateTime endDate)
        //{
        //    FbParameter[] Parameters =
        //    {
        //        new FbParameter("BeginDate", beginDate),
        //        new FbParameter("EndDate", endDate)
        //    };
        //    string procName = @"select * from ""GetAccountClothesByCard""(@BeginDate,@EndDate)";

        //    return mapper.Map<IEnumerable<AccountClothesJournal>, List<AccountClothesJournalDTO>>(accountClothesJournal.SQLExecuteProc(procName, Parameters));
        //}

        public IEnumerable<AccountClothesJournalDTO> GetAccountClothesByCard(DateTime beginDate, DateTime endDate)
        {
            var result = (from acm in accountClothesMaterials.GetAll()
                          join ac in accountClothes.GetAll() on acm.AccountClothesId equals ac.Id
                          join e in employees.GetAll() on ac.EmployeeId equals e.EmployeeID
                          join irm in invoiceRequirementMaterials.GetAll() on acm.InvoiceRequirementMaterialId equals irm.Id
                          join iro in invoiceRequirementOrders.GetAll() on irm.Invoice_Requirement_Order_Id equals iro.Id
                          join r in receipts.GetAll() on irm.Receipt_Id equals r.ID
                          join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID
                          join u in units.GetAll() on n.UnitId equals u.UnitId
                          join a in accounts.GetAll() on n.BALANCE_ACCOUNT_ID equals a.ID
                          join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID
                          where (ac.DocDate >= beginDate && ac.DocDate <= endDate)
                          orderby ac.DocDate, ac.DocNumber

                          select new AccountClothesJournalDTO()
                          {
                              Id = acm.Id,
                              DocNumber = ac.DocNumber,
                              DocDate = ac.DocDate,
                              AccountNumber = e.AccountNumber,
                              EmployeeId = ac.EmployeeId,
                              EmployeeFullName = ed.LastName + " " + ed.FirstName + " " +  ed.MiddleName,
                              AccountClothesId = acm.AccountClothesId,
                              InvoiceRequirementMaterialId = irm.Id,
                              QuantityOutput = acm.QuantityOutput,
                              QuantityReturn = acm.QuantityReturn,
                              OrderDate = iro.Date,
                              OrderNumber = iro.Number,
                              UnitLocalName = u.UnitLocalName,
                              UnitCode = u.UnitCode,
                              DateOutput = acm.DateOutput,
                              DateReturn = acm.DateReturn,
                              PercentageOutput = acm.PercentageOutput,
                              PercentageReturn = acm.PercentageReturn,
                              BalanceAccountNum = a.NUM,
                              NomenclatureName = n.NAME,
                              NomenclatureNumber = n.NOMENCLATURE,
                              NomenclatureId = n.ID,
                              BalanceAccountId = a.ID,
                              UnitPrice = r.UNIT_PRICE,
                              TotalPrice = r.UNIT_PRICE * acm.QuantityOutput
                          });

            return result.ToList();
        }

       

        public IEnumerable<AccountClothesJournalDTO> GetAccountClothesByDateOutput(DateTime beginDate, DateTime endDate)
        {
            var result = (from acm in accountClothesMaterials.GetAll()
                          join ac in accountClothes.GetAll() on acm.AccountClothesId equals ac.Id
                          join e in employees.GetAll() on ac.EmployeeId equals e.EmployeeID
                          join irm in invoiceRequirementMaterials.GetAll() on acm.InvoiceRequirementMaterialId equals irm.Id
                          join iro in invoiceRequirementOrders.GetAll() on irm.Invoice_Requirement_Order_Id equals iro.Id
                          join r in receipts.GetAll() on irm.Receipt_Id equals r.ID
                          join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID
                          join u in units.GetAll() on n.UnitId equals u.UnitId
                          join a in accounts.GetAll() on n.BALANCE_ACCOUNT_ID equals a.ID
                          join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID
                          where (acm.DateOutput >= beginDate && acm.DateOutput <= endDate)
                          orderby ac.DocDate, ac.DocNumber

                          select new AccountClothesJournalDTO()
                          {
                              Id = acm.Id,
                              DocNumber = ac.DocNumber,
                              DocDate = ac.DocDate,
                              AccountNumber = e.AccountNumber,
                              EmployeeId = ac.EmployeeId,
                              EmployeeFullName = ed.LastName + " " + ed.MiddleName + " " + ed.FirstName,
                              AccountClothesId = acm.AccountClothesId,
                              InvoiceRequirementMaterialId = irm.Id,
                              QuantityOutput = acm.QuantityOutput,
                              QuantityReturn = acm.QuantityReturn,
                              OrderDate = iro.Date,
                              OrderNumber = iro.Number,
                              UnitLocalName = u.UnitLocalName,
                              UnitCode = u.UnitCode,
                              DateOutput = acm.DateOutput,
                              DateReturn = acm.DateReturn,
                              PercentageOutput = acm.PercentageOutput,
                              PercentageReturn = acm.PercentageReturn,
                              BalanceAccountNum = a.NUM,
                              NomenclatureName = n.NAME,
                              NomenclatureNumber = n.NOMENCLATURE,
                              NomenclatureId = n.ID,
                              BalanceAccountId = a.ID,
                              UnitPrice = r.UNIT_PRICE,
                              TotalPrice = r.UNIT_PRICE * acm.QuantityOutput
                          });

            return result.ToList();
        }

        public IEnumerable<AccountClothesJournalDTO> GetAccountClothesByDateReturn(DateTime beginDate, DateTime endDate)
        {
            var result = (from acm in accountClothesMaterials.GetAll()
                          join ac in accountClothes.GetAll() on acm.AccountClothesId equals ac.Id
                          join e in employees.GetAll() on ac.EmployeeId equals e.EmployeeID
                          join irm in invoiceRequirementMaterials.GetAll() on acm.InvoiceRequirementMaterialId equals irm.Id
                          join iro in invoiceRequirementOrders.GetAll() on irm.Invoice_Requirement_Order_Id equals iro.Id
                          join r in receipts.GetAll() on irm.Receipt_Id equals r.ID
                          join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID
                          join u in units.GetAll() on n.UnitId equals u.UnitId
                          join a in accounts.GetAll() on n.BALANCE_ACCOUNT_ID equals a.ID
                          join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID
                          where (acm.DateReturn >= beginDate && acm.DateReturn <= endDate)
                          orderby ac.DocDate, ac.DocNumber

                          select new AccountClothesJournalDTO()
                          {
                              Id = acm.Id,
                              DocNumber = ac.DocNumber,
                              DocDate = ac.DocDate,
                              AccountNumber = e.AccountNumber,
                              EmployeeId = ac.EmployeeId,
                              EmployeeFullName = ed.LastName + " " + ed.MiddleName + " " + ed.FirstName,
                              AccountClothesId = acm.AccountClothesId,
                              InvoiceRequirementMaterialId = irm.Id,
                              QuantityOutput = acm.QuantityOutput,
                              QuantityReturn = acm.QuantityReturn,
                              OrderDate = iro.Date,
                              OrderNumber = iro.Number,
                              UnitLocalName = u.UnitLocalName,
                              UnitCode = u.UnitCode,
                              DateOutput = acm.DateOutput,
                              DateReturn = acm.DateReturn,
                              PercentageOutput = acm.PercentageOutput,
                              PercentageReturn = acm.PercentageReturn,
                              BalanceAccountNum = a.NUM,
                              NomenclatureName = n.NAME,
                              NomenclatureNumber = n.NOMENCLATURE,
                              NomenclatureId = n.ID,
                              BalanceAccountId = a.ID,
                              UnitPrice = r.UNIT_PRICE,
                              TotalPrice = r.UNIT_PRICE * acm.QuantityOutput
                          });

            return result.ToList();
        }

        public IEnumerable<InvoiceRequirementOrdersDTO> GetAllInvoiceRequirementOrders(DateTime beginDate, DateTime endDate)
        {
            var query = (from d in invoiceRequirementOrders.GetAll()
                         join e in employees.GetAll() on d.Responsible_Person_Id equals e.EmployeeID
                         join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID
                         join p in professions.GetAll() on ed.ProfessionID equals p.ProfessionID into edp
                         from p in edp.DefaultIfEmpty()
                         where (d.Date >= beginDate && d.Date <= endDate)
                         select new InvoiceRequirementOrdersDTO()
                         {
                             Id = d.Id,
                             Date = d.Date,
                             Responsible_Person_Id = d.Responsible_Person_Id,
                             Number = d.Number,
                             Responsible_Person_Name = ed.LastName + " " + ed.FirstName + " " + ed.MiddleName + " (" + p.Name + ")",
                             Type = d.Type
                         });

            return query.ToList();
        }

        public IEnumerable<InvoiceRequirementOrdersDTO> GetAllInvoiceRequirementOrdersForProduction(DateTime beginDate, DateTime endDate)
        {
            var query = (from d in invoiceRequirementOrders.GetAll()
                         join e in employees.GetAll() on d.Responsible_Person_Id equals e.EmployeeID
                         join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID
                         join p in professions.GetAll() on ed.ProfessionID equals p.ProfessionID into edp
                         from p in edp.DefaultIfEmpty()
                         where ((d.Date >= beginDate && d.Date <= endDate) && ed.DepartmentID == 29)
                         select new InvoiceRequirementOrdersDTO()
                         {
                             Id = d.Id,
                             Date = d.Date,
                             Responsible_Person_Id = d.Responsible_Person_Id,
                             Number = d.Number,
                             Responsible_Person_Name = ed.LastName + " " + ed.FirstName + " " + ed.MiddleName + " (" + p.Name + ")"
                         });


            /*where (d.Date >= beginDate && d.Date <= endDate && ed.DepartmentID == 11)*/

            return query.ToList();
        }

        public IEnumerable<InvoiceRequirementSelectFixedAssetsDTO> GetAllInvoiceRequirementSelectFixedAssets()
        {
            var query = (from fao in fixedAssetsOrder.GetAll()
                         join e in employees.GetAll() on fao.Supplier_Id equals e.EmployeeID into faoe
                         from e in faoe.DefaultIfEmpty()
                         join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID into eed
                         from ed in eed.DefaultIfEmpty()
                         join fag in fixedAssetsGroup.GetAll() on fao.Group_Id equals fag.Id
                         where fao.EndRecordDate == null
                         select new InvoiceRequirementSelectFixedAssetsDTO()
                         {
                             Id = fao.Id,
                             InventoryNumber = fao.InventoryNumber,
                             InventoryName = fao.InventoryName,
                             BeginDate = fao.BeginDate,
                             FullName = ed.LastName + " " + ed.FirstName + " " + ed.MiddleName,
                             GroupName = fag.Name
                         });

            return query.ToList();
        }

        public IEnumerable<InvoiceRequirementMaterialsInfoDTO> GetInvoiceMaterialsByOrderId(int id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("OrderId", id)
                };

            string procName = @"select * from ""GetInvoiceMaterialsByOrderId""(@OrderId)";

            return mapper.Map<IEnumerable<InvoiceRequirementMaterialsInfo>, List<InvoiceRequirementMaterialsInfoDTO>>(invoiceRequirementMaterialsInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<InvoiceRequirementMaterialsInfoDTO> GetInvoiceMaterialsForStoreHouseByOrderId(int id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("OrderId", id)
                };

            string procName = @"select * from ""GetInvoiceMaterialsByOrderId""(@OrderId)";

            return mapper.Map<IEnumerable<InvoiceRequirementMaterialsInfo>, List<InvoiceRequirementMaterialsInfoDTO>>(invoiceRequirementMaterialsInfo.SQLExecuteProc(procName, Parameters).
                Where(zxc => zxc.CreditAccountId !=18 || zxc.CreditAccountId == null).ToList());


            //""Invoice_Requirement_Materials"".""Credit_Account_Id"" != 18 OR ""Invoice_Requirement_Materials"".""Credit_Account_Id"" is NULL
        }

        public IEnumerable<MaterialsForAccountClothesDTO> GetMaterialsForAccountClothes(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetMaterialsForAccountClothes""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<MaterialsForAccountClothes>, List<MaterialsForAccountClothesDTO>>(materialsForAccountsClothes.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<InvoiceRequirementExpenditureInfoDTO> GetInvoiceRequirementExpenditureInfo(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetExpenditureForInvoiceReq""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<InvoiceRequirementExpenditureInfo>, List<InvoiceRequirementExpenditureInfoDTO>>(invoiceRequirementExpenditureInfo.SQLExecuteProc(procName, Parameters));
        }


        public IEnumerable<ExpenditureInfoDTO> GetExpenditureByCustomerOrder(int customerOrderId)
        {
            //if (mapper.Map<IEnumerable<CustomerOrders>, List<CustomerOrdersDTO>>(customerOrders.GetAll()).Any(srch => srch.Id == customerOrderId))
            //{
                string customerOrderNumber = mapper.Map<IEnumerable<CustomerOrders>, List<CustomerOrdersDTO>>(customerOrders.GetAll()).First(srch => srch.Id == customerOrderId).OrderNumber;


                if (customerOrderNumber != "" && customerOrderNumber != null)
                {
                    customerOrderNumber = customerOrderNumber.Replace(".", "");
                    FbParameter[] Parameters =
                {
                    new FbParameter("CustomerOrderIdParam", customerOrderId)
                };
                    string procName = @"select * from ""GetExpenditureByCustomerOrder""(@CustomerOrderIdParam)";
                    return mapper.Map<IEnumerable<ExpenditureInfo>, List<ExpenditureInfoDTO>>(expenditureInfo.SQLExecuteProc(procName, Parameters));
                }
                else
                    return new List<ExpenditureInfoDTO>();
            //}
            
        }

        public IEnumerable<ExpenditureInfoDTO> GetExpenditureByCustomerOrder(string customerOrderNumber)
        {
            if (customerOrderNumber != "" && customerOrderNumber != null)
            {
                FbParameter[] Parameters =
                {
                    new FbParameter("CustomerOrderNumber", customerOrderNumber)
                };
                string procName = @"select * from ""GetExpenditureByCustomerOrder""(@CustomerOrderNumber)";
                return mapper.Map<IEnumerable<ExpenditureInfo>, List<ExpenditureInfoDTO>>(expenditureInfo.SQLExecuteProc(procName, Parameters));
            }
            else
                return new List<ExpenditureInfoDTO>();
        }

        public IEnumerable<StoreHouseRemainsDTO> GetStoreHouseRemainsByDate(DateTime startDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("StartDate", startDate),
            };
            string procName = @"select * from ""GetStoreHouseRemainsByDate""(@StartDate)";

            return mapper.Map<IEnumerable<StoreHouseRemains>, List<StoreHouseRemainsDTO>>(storeHouseRemains.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<StoreHouseRemainsDTO> GetStoreHouseRemainsWithinvoicesByDate(DateTime startDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("StartDate", startDate),
            };
            string procName = @"select * from ""GetStoreHouseRemainsByInvoice""(@StartDate)";

            return mapper.Map<IEnumerable<StoreHouseRemains>, List<StoreHouseRemainsDTO>>(storeHouseRemains.SQLExecuteProc(procName, Parameters));
        }
        
        public IEnumerable<NomenclaturesDTO> GetAllNomenclatures()
        {
            return mapper.Map<IEnumerable<NOMENCLATURES>, List<NomenclaturesDTO>>(nomenclatures.GetAll());
        }

        public IEnumerable<StorehousesDTO> GetAllStorehouses()
        {
            return mapper.Map<IEnumerable<Storehouses>, List<StorehousesDTO>>(storeHouses.GetAll());
        }

        public IEnumerable<StorehousesDTO> GetAllStorehousesWithNumber()
        {
            var query = (from stor in storeHouses.GetAll()
                         select new StorehousesDTO()
                         {
                             Id = stor.Id,
                             Note = stor.Note,
                             StoreHouseName = stor.Num + " - " + stor.Name,
                             Num = stor.Num,
                             Name = stor.Name

                         });

            return query.ToList();
        }

        public bool GetReceiptsByStoreHouseId(int id)
        {
            return mapper.Map<IEnumerable<RECEIPTS>, List<ReceiptsDTO>>(receipts.GetAll()).Any(r => r.Storehouse_Id == id);
        }

        public IEnumerable<NomenclatureGroupsDTO> GetAllNomenclaturesGroups()
        {
            return mapper.Map<IEnumerable<Nomenclature_Groups>, List<NomenclatureGroupsDTO>>(nomenclaturesGroups.GetAll());
        }

        public IEnumerable<NomenclaturesDTO> GetAllNomenclaturesMaterials(int id)
        {
            var query = (from nom in nomenclatures.GetAll()
                         join unt in units.GetAll() on nom.UnitId equals unt.UnitId into untt
                         from unt in untt.DefaultIfEmpty()
                         join ac in accounts.GetAll() on nom.BALANCE_ACCOUNT_ID equals ac.ID
                         where nom.Nomencl_Group_Id == id
                         select new NomenclaturesDTO()
                         {
                             ID = nom.ID,
                             BALANCE_ACCOUNT_ID = ac.ID,
                             Num = ac.NUM,
                             UnitId = unt.UnitId,
                             UnitLocalName = unt.UnitLocalName,
                             Nomenclature = nom.NOMENCLATURE,
                             Nomencl_Group_Id = nom.Nomencl_Group_Id,
                             Name = nom.NAME

                         });

            return query.ToList();
        }


        public IEnumerable<OrdersDTO> GetOrders()
        {
            return mapper.Map<IEnumerable<ORDERS>, List<OrdersDTO>>(orders.GetAll());
        }
        public IEnumerable<OrdersInfoDTO> GetReceiptsByPeriod(DateTime beginDate, DateTime endDate)
        {
            var query = (from r in receipts.GetAll()
                         join o in orders.GetAll() on r.ORDER_ID equals o.ID into ro
                         from o in ro.DefaultIfEmpty()
                         join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID into rn
                         from n in rn.DefaultIfEmpty()
                         join c in contractors.GetAll() on o.VENDOR_ID equals c.Id into oc
                         from c in oc.DefaultIfEmpty()
                         join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                         from u in nu.DefaultIfEmpty()
                         where (o.ORDER_DATE >= beginDate && o.ORDER_DATE <= endDate) && o.Flag1 == 1
                         select new OrdersInfoDTO()
                         {
                             ReceiptId = r.ID,
                             ReceiptNum = o.RECEIPT_NUM,
                             OrderDate = o.ORDER_DATE,
                             InvoiceDate = o.INVOICE_DATE,
                             VendorSrn = c.Srn,
                             VendorName = c.Name,
                             Nomenclature = n.NOMENCLATURE,
                             NomenclatureName = n.NAME,
                             Measure = u.UnitLocalName,
                             Quantity = r.QUANTITY,
                             TotalPrice = r.TOTAL_PRICE
                         });

            return query.ToList();
        }

        public string GetLastNomenclatureNumber(int accountId, string name)
        {
            List<NomenclaturesDTO> list = mapper.Map<IEnumerable<NOMENCLATURES>, List<NomenclaturesDTO>>(nomenclatures.GetAll().Where(w => w.BALANCE_ACCOUNT_ID == accountId).ToList());

            long lastNumber = 0;

            if (list.Count > 0)
            {
                lastNumber = list.Select(n => (n.Nomenclature.Length > 0) ? Convert.ToInt64(n.Nomenclature.Replace('/'.ToString(), String.Empty)) : 0).Max();  
                return lastNumber.ToString(); 
            }
            else
            { 
                return name + "0000";
            }
        }

        public IEnumerable<ReceiptOrdersDTO> GetOrdersByPeriod(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate),
            };

            string procName = @"select * from ""GetOrdersByPeriod""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<ReceiptOrders>, List<ReceiptOrdersDTO>>(receiptOrders.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<ReceiptsDTO> GetReceiptsByOrderId(int orderId)
        {
            var query = (from r in receipts.GetAll()
                         join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID into rn
                         from n in rn.DefaultIfEmpty()
                         join a in accounts.GetAll() on n.BALANCE_ACCOUNT_ID equals a.ID into na
                         from a in na.DefaultIfEmpty()
                         join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                         from u in nu.DefaultIfEmpty()
                         join s in storeHouses.GetAll() on r.Storehouse_Id equals s.Id into rs
                         from s in rs.DefaultIfEmpty()
                         where r.ORDER_ID == orderId
                         select new ReceiptsDTO()
                         {
                             ID = r.ID,
                             ORDER_ID = r.ORDER_ID,
                             QUANTITY = r.QUANTITY,
                             //UNIT_PRICE = r.UNIT_PRICE,
                             //UNIT_CURRENCY = r.UNIT_CURRENCY,
                             //TOTAL_PRICE = r.TOTAL_PRICE,
                             //TOTAL_CURRENCY = r.TOTAL_CURRENCY,
                             NOMENCLATURE_ID = r.NOMENCLATURE_ID,
                             POS = r.POS,
                             Storehouse_Id = r.Storehouse_Id,
                             BalanceAccountId = a.ID,
                             BalanceAccountNum = a.NUM,
                             Nomenclature = n.NOMENCLATURE,
                             NomenclatureName = n.NAME,
                             NomenclatureGroupId = n.Nomencl_Group_Id,
                             StoreHouseName = s.Num + " - " + s.Name,
                             UnitId = n.UnitId,
                             UnitLocalName = u.UnitLocalName
                         });

            return query;
        }

        public IEnumerable<DeliveryOrderDTO> GetDeliveryOrder(DateTime beginDate, DateTime endDate)
        {
            
            var query = (from dord in deliveryOrder.GetAll()
                         join dpt in deliveryPaymentType.GetAll() on dord.DeliveryPriceTypeId equals dpt.Id into dptt
                         from dpt in dptt.DefaultIfEmpty()
                         join dod in deliveryOrdersDetails.GetAll() on dord.Id equals dod.DeliveryOrderId into dodd
                         from dod in dodd.DefaultIfEmpty()
                         join de in delivery.GetAll() on dord.DeliveryId equals de.Id into dd
                         from de in dd.DefaultIfEmpty()

                         join o in orders.GetAll() on dod.OrderId equals o.ID into oo
                         from o in oo.DefaultIfEmpty()
                         where (dord.OrderDate >= beginDate && dord.OrderDate <= endDate)


                         select new DeliveryOrderDTO()
                         {
                             Id = dord.Id,
                             DeliveryId = de.Id,
                             ReceiptNumber = o.RECEIPT_NUM,
                             OrderDate = dord.OrderDate,
                             TTN = dord.TTN,
                             Price = dord.Price,
                             DeliveryPriceTypeId = dpt.Id,
                             DeliveryName = de.DeliveryName,
                             DeliveryPaymentName = dpt.DeliveryPaymentName,
                             DeliveryOrderId = dod.DeliveryOrderId
                              
                         }
                );
            return query.ToList();

            //string procName = @"select * from ""GetDeliveryOrderTestProc""";
            //return mapper.Map<IEnumerable<DeliveryOrder>, List<DeliveryOrderDTO>>(deliveryOrder.SQLExecuteProc(procName));
        }


    

        public IEnumerable<DeliveryDTO> GetDelivery()
        {
            return mapper.Map<IEnumerable<Delivery>, List<DeliveryDTO>>(delivery.GetAll());
        }

        public IEnumerable<DeliveryPaymentTypeDTO> GetDeliveryPaymentType()
        {
            return mapper.Map<IEnumerable<DeliveryPaymentType>, List<DeliveryPaymentTypeDTO>>(deliveryPaymentType.GetAll());
        }


        public IEnumerable<InvoiceRequirementMaterialsDTO> GetInvoiceRequirementMaterial(int receiptId)
        {
            var allInvoicesRequirement = mapper.Map<IEnumerable<Invoice_Requirement_Materials>, List<InvoiceRequirementMaterialsDTO>>(invoiceRequirementMaterials.GetAll());

            var searchInvoicesRequirement = allInvoicesRequirement.Where(whr => whr.Receipt_Id == receiptId);

            return searchInvoicesRequirement;
        }

        public IEnumerable<InvoiceRequirementMaterialsDTO> GetInvoiceRequirementMaterial(int receiptId, decimal quantity)
        {
            var allInvoicesRequirement = mapper.Map<IEnumerable<Invoice_Requirement_Materials>, List<InvoiceRequirementMaterialsDTO>>(invoiceRequirementMaterials.GetAll());

            var searchInvoicesRequirement = allInvoicesRequirement.Where(whr => whr.Receipt_Id == receiptId && whr.Required_Quantity == quantity && whr.Expenditures_Id == null);

            return searchInvoicesRequirement;
        }

        public IEnumerable<DeliveryOrdersDetailsDTO> DeliveryOrdersDetails()
        {
            return mapper.Map<IEnumerable<DeliveryOrdersDetails>, List<DeliveryOrdersDetailsDTO>>(deliveryOrdersDetails.GetAll());
        }

        public IEnumerable<ReceiptJournalDTO> GetReceiptByOrderIdProc(int orderId)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("Order_Id", orderId),
            };

            string procName = @"select * from ""GetReceiptByOrderId""(@Order_Id)";

            return mapper.Map<IEnumerable<ReceiptJournal>, List<ReceiptJournalDTO>>(receiptJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<ToolActsDTO> GetAllToolActs(DateTime beginDate, DateTime endDate)
        {
            var query = (from ta in toolActs.GetAll()
                         join ed in employeesDetails.GetAll() on ta.ResponsiblePersonId equals ed.EmployeeID
                         where (ta.ActDate >= beginDate && ta.ActDate <= endDate)
                         select new ToolActsDTO()
                         {
                             Id = ta.Id,
                             ActDate = ta.ActDate,
                             ActNumber = ta.ActNumber,
                             ResponsiblePersonId = ta.ResponsiblePersonId,
                             ResponsiblePersonFullName = ed.LastName + " " + ed.FirstName + " " + ed.MiddleName
                         });

            return query.ToList();
        }

        public IEnumerable<ToolActMaterialsJournalDTO> GetToolActMaterialsById(int id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("ToolActId", id)
                };

            string procName = @"select * from ""GetToolActMaterialsByActId""(@ToolActId)";

            return mapper.Map<IEnumerable<ToolActMaterialsJournal>, List<ToolActMaterialsJournalDTO>>(toolActMaterialsJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<MaterialsForToolActsDTO> GetMaterialsForToolActs(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetMaterialsForToolActs""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<MaterialsForToolActs>, List<MaterialsForToolActsDTO>>(materialsForToolActs.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<AccountOrdersDTO> GetAccountOrderJournal(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate),
                new FbParameter("FLAG1", flag1),
                new FbParameter("FLAG2", flag2),
                new FbParameter("FLAG3", flag3),
                new FbParameter("FLAG4", flag4)
            };
            string procName = @"select * from ""GetOrdersAccountByPeriod""(@BeginDate,@EndDate,@FLAG1, @FLAG2, @FLAG3, @FLAG4)";

            return mapper.Map<IEnumerable<AccountOrders>, List<AccountOrdersDTO>>(accountOrders.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<ReceiptHistoryOrdersDTO> GetReceiptsByNomenclaturesId(int nomenclatureId, DateTime beginDate, DateTime endDate)
        {
            var query = (from r in receipts.GetAll()
                         join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID into rn
                         from n in rn.DefaultIfEmpty()
                         join o in orders.GetAll() on r.ORDER_ID equals o.ID into ro
                         from o in ro.DefaultIfEmpty()
                         join c in contractors.GetAll() on o.VENDOR_ID equals c.Id into oc
                         from c in oc.DefaultIfEmpty()
                         join s in storeHouses.GetAll() on r.Storehouse_Id equals s.Id into rs
                         from s in rs.DefaultIfEmpty()
                         join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                         from u in nu.DefaultIfEmpty()
                         where (r.NOMENCLATURE_ID == nomenclatureId)

                         select new ReceiptHistoryOrdersDTO()
                         {
                             VendorId = c.Id,
                             Nomenclature = n.NOMENCLATURE,
                             NomenclatureName = n.NAME,
                             UnitLocalName = u.UnitLocalName,
                             Quantity = r.QUANTITY,
                             TotalPrice = r.TOTAL_PRICE,
                             UnitPrice = r.QUANTITY > 0 ? Math.Round((decimal)((decimal?)r.TOTAL_PRICE / (decimal)r.QUANTITY), 2) : r.TOTAL_PRICE,
                             //UnitPrice = Math.Round(r.UNIT_PRICE, 2),
                             VendorName = c.Name,
                             StoreHouseName = s.Name,
                             OrderDate = o.ORDER_DATE
                         }).OrderByDescending(o => o.OrderDate);
            
            return query.ToList();
        }

        public IEnumerable<NomenclaturesDTO> GetNomenclatureWithAccountNumber(string nomenclature)
        {
            var query = (from nom in nomenclatures.GetAll()
                         join acc in accounts.GetAll() on nom.BALANCE_ACCOUNT_ID equals acc.ID into accc
                         from acc in accc.DefaultIfEmpty()
                         join u in units.GetAll() on nom.UnitId equals u.UnitId into uu
                         from u in uu.DefaultIfEmpty()
                         where nom.NOMENCLATURE == nomenclature
                         select new NomenclaturesDTO()
                         {
                             ID = nom.ID,
                             Name = nom.NAME,
                             Nomenclature = nom.NOMENCLATURE,
                             UnitId = nom.UnitId,
                             BALANCE_ACCOUNT_ID = acc.ID,
                             Num = acc.NUM,
                             UnitLocalName = u.UnitLocalName,
                             Nomencl_Group_Id = nom.Nomencl_Group_Id

                         });

            return query.ToList();

        }

        public IEnumerable<DeliveryOrdersDetailsDTO> GetDeliveryOrdersDetailsByOrderid(long orderId)
        {
            var query = (from dod in deliveryOrdersDetails.GetAll()
                         join doo in deliveryOrder.GetAll() on dod.DeliveryOrderId equals doo.Id into dooo
                         from doo in dooo.DefaultIfEmpty()
                         join dpt in deliveryPaymentType.GetAll() on doo.DeliveryPriceTypeId equals dpt.Id into dptt
                         from dpt in dptt.DefaultIfEmpty()
                         join dd in delivery.GetAll() on doo.DeliveryId equals dd.Id into ddd
                         from dd in ddd.DefaultIfEmpty()
                         where dod.OrderId == orderId
                         select new DeliveryOrdersDetailsDTO()
                         {
                             Id = dod.Id,
                             OrderId = dod.OrderId,
                             DeliveryOrderId = dod.DeliveryOrderId,
                             TTN = doo.TTN,
                             Price = doo.Price,
                             OrderDate = doo.OrderDate,
                             DeliveryName = dd.DeliveryName,
                             DeliveryPaymentName = dpt.DeliveryPaymentName,
                             Selected = false
                         });

            return query.ToList();

        }

        public IEnumerable<ExpenditureInfoDTO> GetExpenditureJournalByPeriod(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate),
            };

            string procName = @"select * from ""GetExpenditureJournalProc""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<ExpenditureInfo>, List<ExpenditureInfoDTO>>(expenditureInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<RemainsNomenclatureDTO> GetRemainsByNomenclatureId(int nomenclatureId, DateTime startDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("NomenclatureId", nomenclatureId),
                new FbParameter("StartDate", startDate),
            };

            string procName = @"select * from ""GetRemainsByNomenclatureId""(@NomenclatureId, @StartDate)";

            return mapper.Map<IEnumerable<RemainsNomenclature>, List<RemainsNomenclatureDTO>>(remainsNomenclature.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<StoreHouseReceiptProjectDTO> GetStoreHouseReceiptProject(DateTime startDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("StartDate", startDate),
            };

            string procName = @"select * from ""GetStoreHouseProjectRemains""(@StartDate)";

            return mapper.Map<IEnumerable<StoreHouseReceiptProject>, List<StoreHouseReceiptProjectDTO>>(storeHouseReceiptProject.SQLExecuteProc(procName, Parameters));
        }

        //////public IEnumerable<InvoiceRequirementOrdersDTO> GetInvoiceRequirementOrderForProject(DateTime currentDate)
        //////{
        //////    var invoiceRequirement = mapper.Map<IEnumerable<Invoice_Requirement_Orders>, List<InvoiceRequirementOrdersDTO>>(invoiceRequirementOrders.GetAll().Where(w => w.Date.Month == currentDate.Month ).ToList());

        //////    return invoiceRequirement;
        //////}


        public IEnumerable<InvoiceRequirementMaterialsDTO> GetContainInvoiceRequirementMaterials(int idItem)
        {
            List<InvoiceRequirementMaterialsDTO> invoiceRequirement = mapper.Map<IEnumerable<Invoice_Requirement_Materials>, List<InvoiceRequirementMaterialsDTO>>(invoiceRequirementMaterials.GetAll().Where(w => w.Expenditures_Id == idItem).ToList());

            return invoiceRequirement;
        }

        public IEnumerable<ExpedinturesAccountantDTO> GetExpendituresAccountant()
        {
            return mapper.Map<IEnumerable<EXPENDITURES_ACCOUNTANT>, List<ExpedinturesAccountantDTO>>(expenditureAccountant.GetAll());
        }

        public IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHouses()
        {
            return mapper.Map<IEnumerable<ExpendituresStoreHouses>, List<ExpendituresStoreHousesDTO>>(expendituresStoreHouses.GetAll());
        }



        //Удалить то что ниже
        public IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHousesByPeriod(DateTime beginDate, DateTime endDate)
        {
            var query = (from esh in expendituresStoreHouses.GetAll()

                         join rec in receipts.GetAll() on esh.ReceiptId equals rec.ID into recc
                         from rec in recc.DefaultIfEmpty()
                         join ord in orders.GetAll() on rec.ORDER_ID equals ord.ID into ordd
                         from ord in ordd.DefaultIfEmpty()
                         join cus in customerOrders.GetAll() on esh.CustomerOrderId equals cus.Id into cuss
                         from cus in cuss.DefaultIfEmpty()
                         join nom in nomenclatures.GetAll() on rec.NOMENCLATURE_ID equals nom.ID into nomm
                         from nom in nomm.DefaultIfEmpty()
                         join acc in accounts.GetAll() on nom.BALANCE_ACCOUNT_ID equals acc.ID into accc
                         from acc in accc.DefaultIfEmpty()
                         join unt in units.GetAll() on nom.UnitId equals unt.UnitId into untt
                         from unt in untt.DefaultIfEmpty()
                         join exp in expenditureAccountant.GetAll() on esh.ExpenditureId equals exp.ID into expp
                         from exp in expp.DefaultIfEmpty()
                         join e in employees.GetAll() on esh.EmployeeId equals e.EmployeeID into ee
                         from e in ee.DefaultIfEmpty()
                         join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID into edd
                         from ed in edd.DefaultIfEmpty()
                         where (esh.ExpDate >= beginDate && esh.ExpDate <= endDate)
                         select new ExpendituresStoreHousesDTO()
                         {
                             Id = esh.Id,
                             BalanceAccountId = acc.ID,
                             BalanceAccountNum = acc.NUM,
                             CustomerOrderId = esh.CustomerOrderId,
                             CustomerOrderNumber = esh.CustomerOrderId != null ? cus.OrderNumber : e.EmployeeID != null ? "0 (" + ed.LastName + " " + ed.FirstName.Substring(0, 1) + ". " + ed.MiddleName.Substring(0, 1) + "." + ")" : "0",
                             ExpDate = esh.ExpDate,
                             NomenclatureId = nom.ID,
                             Nomenclature = nom.NOMENCLATURE,
                             NomenclatureName = nom.NAME,
                             ReceiptId = esh.ReceiptId,
                             ReceiptNum = ord.RECEIPT_NUM,
                             ReceiptDate = ord.ORDER_DATE,
                             Quantity = esh.Quantity,
                             Price = Math.Round((decimal)((decimal?)rec.TOTAL_PRICE / (decimal)rec.QUANTITY), 2),
                             UnitId = unt.UnitId,
                             UnitLocalName = unt.UnitLocalName,
                             ExpenditureId = exp.ID,
                             ExpendituresQuantity = exp.QUANTITY,
                             ExpenditureAccountDate = exp.EXP_DATE,
                             ExpenditureCustomerOrder = exp.PROJECT_NUM,
                             EmployeeId = esh.EmployeeId,
                             Check = esh.Check
                         });

            return query.ToList();
        }

        

        public IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresAllWithCustomerOrder()
        {
            var query = (from esh in expendituresStoreHouses.GetAll()
                         join cus in customerOrders.GetAll() on esh.CustomerOrderId equals cus.Id into cuss
                         from cus in cuss.DefaultIfEmpty()

                         select new ExpendituresStoreHousesDTO()
                         {
                             Id = esh.Id,
                              ReceiptId = esh.ReceiptId,
                             CustomerOrderId = esh.CustomerOrderId,
                             CustomerOrderNumber = esh.CustomerOrderId!=null?cus.OrderNumber.Replace(".", ""): "0",
                             ExpDate = esh.ExpDate,
                             Quantity = esh.Quantity,
                             EmployeeId = esh.EmployeeId,
                              ExpenditureId = esh.ExpenditureId
                              
                         });

            return query.ToList();
        }


        


        public IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHousesMaterial(int receiptId, decimal quantity, string customerOrderNumber)
        {
            //var allExpendituresStoreHousesMaterial = mapper.Map<IEnumerable<ExpendituresStoreHouses>, List<ExpendituresStoreHousesDTO>>(expendituresStoreHouses.GetAll()).ToList();

            var allExpendituresStoreHousesMaterial = GetExpendituresAllWithCustomerOrder().ToList();

            var searchExpendituresStoreHousesMaterial = allExpendituresStoreHousesMaterial.Where(whr => whr.ReceiptId == receiptId && whr.Quantity == quantity && whr.CustomerOrderNumber == customerOrderNumber && whr.ExpenditureId == null);

            return searchExpendituresStoreHousesMaterial;
        }

        public IEnumerable<ExpendituresStoreHousesDTO> GetExpendituresStoreHousesMaterial(int receiptId)
        {
            var allExpendituresStoreHousesMaterial = mapper.Map<IEnumerable<ExpendituresStoreHouses>, List<ExpendituresStoreHousesDTO>>(expendituresStoreHouses.GetAll()).ToList();

            var searchExpendituresStoreHousesMaterial = allExpendituresStoreHousesMaterial.Where(whr => whr.ReceiptId == receiptId);

            return searchExpendituresStoreHousesMaterial;
        }


        public IEnumerable<ExpenditureStoreHouseInfoDTO> GetExpendituresStoreHousesInfoByPeriod(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate),
            };

            string procName = @"select * from ""GetExpStoreHouseJournalProc""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<ExpenditureStoreHouseInfo>, List<ExpenditureStoreHouseInfoDTO>>(expenditureStoreHouseInfo.SQLExecuteProc(procName, Parameters));
        }


        public IEnumerable<ExpenditureTotalPriceDTO> GetExpenditureTotalPriceByCustomerOrderId(int customerOrderId)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("CustomerOrderId", customerOrderId)
            };

            string procName = @"select * from ""GetExpTotPriceByCO""(@CustomerOrderId)";

            return mapper.Map <IEnumerable<ExpenditureTotalPrice>, List<ExpenditureTotalPriceDTO>>(expenditureTotalPrice.SQLExecuteProc(procName, Parameters));
        }



        //flag - указывает считать ли списанния которые еще не подтверждены бухгалтером
        public IEnumerable<ExpenditureTotalPriceDTO> GetExpenditureAccTotalPriceByCustomerOrderId(int customerOrderId, int flag = 0)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("CustomerOrderId", customerOrderId),
                new FbParameter("Flag", flag),
            };

            string procName = @"select * from ""GetExpAccToPriceByCO""(@CustomerOrderId, @Flag)";

            return mapper.Map<IEnumerable<ExpenditureTotalPrice>, List<ExpenditureTotalPriceDTO>>(expenditureTotalPrice.SQLExecuteProc(procName, Parameters));
        }

        //flag - указывает считать ли списанния которые еще не подтверждены бухгалтером
        public IEnumerable<InvoicesFixedAssetsInfoDTO> GetInvoicesFixedAssetsInfo(DateTime startDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", startDate),
                new FbParameter("EndDate", endDate),
            };

            string procName = @"select * from ""GetInvoicesForFixedAssets""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<InvoicesFixedAssetsInfo>, List<InvoicesFixedAssetsInfoDTO>>(invoicesFixedAssetsInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<OrderReceipFromQueryDTO> GetOrderReceipFromQueryProc(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("StartDate", beginDate),
                new FbParameter("EndDate", endDate),
                new FbParameter("FLAG1", flag1),
                new FbParameter("FLAG2", flag2),
                new FbParameter("FLAG3", flag3),
                new FbParameter("FLAG4", flag4)
            };
            string procName = @"select * from ""AccountingOrderReceiptProc""(@StartDate,@EndDate,@FLAG1, @FLAG2, @FLAG3, @FLAG4)";

            return mapper.Map<IEnumerable<OrderReceipFromQuery>, List<OrderReceipFromQueryDTO>>(orderReceipFromQuery.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<OrderReceipFromQueryDTO> GetOrderReceipFromQuery(DateTime beginDate, DateTime endDate, short? flag1, short? flag2, short? flag3, short? flag4)
        {
            var query = (from rec in receipts.GetAll()
                         join ord in orders.GetAll() on rec.ORDER_ID equals ord.ID into ordd
                         from ord in ordd.DefaultIfEmpty()
                         join nom in nomenclatures.GetAll() on rec.NOMENCLATURE_ID equals nom.ID into nomm
                         from nom in nomm.DefaultIfEmpty()
                         join unit in units.GetAll() on nom.UnitId equals unit.UnitId into unitt
                         from unit in unitt.DefaultIfEmpty()
                         join con in contractors.GetAll() on ord.VENDOR_ID equals con.Id into conn
                         from con in conn.DefaultIfEmpty()
                         join acc in accounts.GetAll() on nom.BALANCE_ACCOUNT_ID equals acc.ID into accc
                         from acc in accc.DefaultIfEmpty()
                         join accs in accountss.GetAll() on ord.DEBIT_ACCOUNT_ID equals accs.ID into acccs
                         from accs in acccs.DefaultIfEmpty()
                         where ((ord.ORDER_DATE >= beginDate && ord.ORDER_DATE <= endDate) && (ord.Flag1 == flag1 || ord.Flag2 == flag2 || ord.Flag3 == flag3 || ord.Flag4 == flag4))

                         //(Ord."Flag1" = :Flag1 OR Ord."Flag2" = :Flag2 OR Ord."Flag3" = :Flag3 OR Ord."Flag4" = :Flag4)

                         select new OrderReceipFromQueryDTO()
                         {      
                             Id = rec.ID,
                            Quantity = rec.QUANTITY,
                             //UnitPrice = rec.UNIT_PRICE,
                             TotalPrice = rec.TOTAL_PRICE,
                             UnitPrice = rec.QUANTITY > 0 ? Math.Round((decimal)((decimal?)rec.TOTAL_PRICE / (decimal)rec.QUANTITY), 2) : rec.TOTAL_PRICE,
                             
                             ReceiptNum = ord.RECEIPT_NUM,
                             //UnitCurrency = rec.UNIT_CURRENCY,
                             
                             TotalCurrency = rec.TOTAL_CURRENCY,
                             UnitCurrency = rec.QUANTITY > 0 ? Math.Round((decimal)((decimal?)rec.TOTAL_CURRENCY / (decimal)rec.QUANTITY), 2) : rec.TOTAL_CURRENCY,
                             CurrencyRate = ord.CURRENCY_RATE,
                             OrderDate = ord.ORDER_DATE,
                             InvoiceDate = ord.INVOICE_DATE,
                             Correction = ord.CORRECTION,
                             Nomenclature = nom.NOMENCLATURE,
                             NomenclatureName = nom.NAME,
                             UnitName = unit.UnitLocalName,
                             ContractorName = con.Name,
                             Srn = con.Srn,
                             BalansNum = acc.NUM,
                             DebitNum = accs.NUM

                         });

            //var query = (from esh in expendituresStoreHouses.GetAll()

            //             join rec in receipts.GetAll() on esh.ReceiptId equals rec.ID into recc
            //             from rec in recc.DefaultIfEmpty()
            //             join ord in orders.GetAll() on rec.ORDER_ID equals ord.ID into ordd
            //             from ord in ordd.DefaultIfEmpty()
            //             join cus in customerOrders.GetAll() on esh.CustomerOrderId equals cus.Id into cuss
            //             from cus in cuss.DefaultIfEmpty()
            //             join nom in nomenclatures.GetAll() on rec.NOMENCLATURE_ID equals nom.ID into nomm
            //             from nom in nomm.DefaultIfEmpty()
            //             join acc in accounts.GetAll() on nom.BALANCE_ACCOUNT_ID equals acc.ID into accc
            //             from acc in accc.DefaultIfEmpty()
            //             join unt in units.GetAll() on nom.UnitId equals unt.UnitId into untt
            //             from unt in untt.DefaultIfEmpty()
            //             join exp in expenditureAccountant.GetAll() on esh.ExpenditureId equals exp.ID into expp
            //             from exp in expp.DefaultIfEmpty()
            //             join e in employees.GetAll() on esh.EmployeeId equals e.EmployeeID into ee
            //             from e in ee.DefaultIfEmpty()
            //             join ed in employeesDetails.GetAll() on e.EmployeeID equals ed.EmployeeID into edd
            //             from ed in edd.DefaultIfEmpty()
            //             where (esh.ExpDate >= beginDate && esh.ExpDate <= endDate)
            //             select new ExpendituresStoreHousesDTO()
            //             {
            //                 Id = esh.Id,
            //                 BalanceAccountId = acc.ID,
            //                 BalanceAccountNum = acc.NUM,
            //                 CustomerOrderId = esh.CustomerOrderId,
            //                 CustomerOrderNumber = esh.CustomerOrderId != null ? cus.OrderNumber : e.EmployeeID != null ? "0 (" + ed.LastName + " " + ed.FirstName.Substring(0, 1) + ". " + ed.MiddleName.Substring(0, 1) + "." + ")" : "0",
            //                 ExpDate = esh.ExpDate,
            //                 NomenclatureId = nom.ID,
            //                 Nomenclature = nom.NOMENCLATURE,
            //                 NomenclatureName = nom.NAME,
            //                 ReceiptId = esh.ReceiptId,
            //                 ReceiptNum = ord.RECEIPT_NUM,
            //                 ReceiptDate = ord.ORDER_DATE,
            //                 Quantity = esh.Quantity,
            //                 Price = Math.Round((decimal)((decimal?)rec.TOTAL_PRICE / (decimal)rec.QUANTITY), 2),
            //                 UnitId = unt.UnitId,
            //                 UnitLocalName = unt.UnitLocalName,
            //                 ExpenditureId = exp.ID,
            //                 ExpendituresQuantity = exp.QUANTITY,
            //                 ExpenditureAccountDate = exp.EXP_DATE,
            //                 ExpenditureCustomerOrder = exp.PROJECT_NUM,
            //                 EmployeeId = esh.EmployeeId,
            //                 Check = esh.Check
            //             });

            return query.ToList();
        }

        public int GetUserIdByReceiptCertId(int recCertId)
        {
            var query = (from recC in receiptCertificate.GetAll()
                         join recCertD in receiptCertificateDetail.GetAll() on recC.ReceiptCertificateId equals recCertD.ReceiptCertificateId into recCertt
                         from recCertD in recCertt.DefaultIfEmpty()
                         join rec in receipts.GetAll() on recCertD.ReceiptId equals rec.ID into recc
                         from rec in recc.DefaultIfEmpty()
                         join ord in orders.GetAll() on rec.ORDER_ID equals ord.ID into ordd
                         from ord in ordd.DefaultIfEmpty()
                         where (recC.ReceiptCertificateId == recCertId)
                         let supplierId = ord.SUPPLIER_ID ?? 0 // Use 0 or default value as per your requirement
                         select supplierId).FirstOrDefault(); // Use FirstOrDefault to get a single result or default

            return query;
        }


        #endregion


        #region AccountClothes CRUD method's

        public int AccountClothesCreate(AccountClothesDTO acDTO)
        {
            var createAC = accountClothes.Create(mapper.Map<AccountClothes>(acDTO));
            return (int)createAC.Id;
        }

        public void AccountClothesUpdate(AccountClothesDTO acDTO)
        {
            var updateAC = accountClothes.GetAll().SingleOrDefault(c => c.Id == acDTO.Id);
            accountClothes.Update((mapper.Map<AccountClothesDTO, AccountClothes>(acDTO, updateAC)));
        }

        public bool AccountClothesDelete(int id)
        {
            try
            {
                accountClothes.Delete(accountClothes.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region AccountClothesMaterials CRUD method's         

        public int AccountClothesMaterialsCreate(AccountClothesMaterialsDTO acmDTO)
        {
            var createACM = accountClothesMaterials.Create(mapper.Map<AccountClothesMaterials>(acmDTO));
            return (int)createACM.Id;
        }

        public void AccountClothesMaterialsCreateRange(List<AccountClothesMaterialsDTO> source)
        {
            accountClothesMaterials.CreateRange(mapper.Map<List<AccountClothesMaterialsDTO>, IEnumerable<AccountClothesMaterials>>(source));
        }

        public void AccountClothesMaterialsUpdate(AccountClothesMaterialsDTO acmDTO)
        {
            var updateACM = accountClothesMaterials.GetAll().SingleOrDefault(c => c.Id == acmDTO.Id);
            accountClothesMaterials.Update((mapper.Map<AccountClothesMaterialsDTO, AccountClothesMaterials>(acmDTO, updateACM)));
        }

        public bool AccountClothesMaterialsRemoveRange(List<AccountClothesMaterialsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = accountClothesMaterials.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    accountClothesMaterials.Delete(deleteModel);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region InvoiceRequirementOrder CRUD method's         

        public int InvoiceRequirementOrderCreate(InvoiceRequirementOrdersDTO iroDTO)
        {
            var createIRO = invoiceRequirementOrders.Create(mapper.Map<Invoice_Requirement_Orders>(iroDTO));
            return (int)createIRO.Id;
        }

        public int InvoiceRequirementCreateDirect(InvoiceRequirementOrdersDTO iroDTO)
        {
            LastIdInvoicesReqGenDTO currentOrderId = LastInvoicesRequirementId();

            string data = iroDTO.Date.ToShortDateString();

            if (Database.GetExecuteSqlCommand(@"INSERT INTO ""Invoice_Requirement_Orders"" (""Id"", ""Number"",""Responsible_Person_Id"", ""Date"") 
                            VALUES (" + currentOrderId.GenId + "," + iroDTO.Number + "," + iroDTO.Responsible_Person_Id+ "," + "'" + data + "'" + ")"))
            {
                return currentOrderId.GenId;
            }
            else
            {
                return 0;
            }
            
        }



        public void InvoiceRequirementOrderUpdate(InvoiceRequirementOrdersDTO iroDTO)
        {
                var updateIRO = invoiceRequirementOrders.GetAll().SingleOrDefault(c => c.Id == iroDTO.Id);
                invoiceRequirementOrders.Update((mapper.Map<InvoiceRequirementOrdersDTO, Invoice_Requirement_Orders>(iroDTO, updateIRO)));
        }

        public bool InvoiceRequirementOrderDelete(int id)
        {
            try
            {
                invoiceRequirementOrders.Delete(invoiceRequirementOrders.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public LastIdInvoicesReqGenDTO LastInvoicesRequirementId()
        {
            string procName = @"select * from ""GetLastIdInvoicesReqGenProc""";

            return mapper.Map<LastIdInvoicesReqGen, LastIdInvoicesReqGenDTO>(lastIdInvoicesReqGen.SQLExecuteProc(procName).First());
        }

        #endregion

        #region InvoiceRequirementMaterial CRUD method's      
        
        public int InvoiceRequirementMaterialCreate(InvoiceRequirementMaterialsDTO irmDTO)
        {
            var createIRM = invoiceRequirementMaterials.Create(mapper.Map<Invoice_Requirement_Materials>(irmDTO));
            
            return (int)createIRM.Id;
        }
        
        public void InvoiceRequirementMaterialCreateRange(List<InvoiceRequirementMaterialsDTO> source)
        {
            invoiceRequirementMaterials.CreateRange(mapper.Map<List<InvoiceRequirementMaterialsDTO>, IEnumerable<Invoice_Requirement_Materials>>(source));

            //foreach (var item in source)
            //{
            //    InvoiceRequirementMaterialCreateDirect(item);
                
            //}

        }

        public void InvoiceRequirementMaterialUpdate(InvoiceRequirementMaterialsDTO irmDTO)
        {
            var updateIRM = invoiceRequirementMaterials.GetAll().SingleOrDefault(c => c.Id == irmDTO.Id);
            invoiceRequirementMaterials.Update((mapper.Map<InvoiceRequirementMaterialsDTO, Invoice_Requirement_Materials>(irmDTO, updateIRM)));
        }

        public bool InvoiceRequirementMaterialRemoveRange(List<InvoiceRequirementMaterialsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = invoiceRequirementMaterials.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    invoiceRequirementMaterials.Delete(deleteModel);
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int InvoiceRequirementMaterialCreateDirect(InvoiceRequirementMaterialsDTO irmoDTO)
        {
            LastIdInvoicesReqMatGenDTO currentOrderMaterial = LastInvoicesRequirementMatId();

            //string data = irmoDTO.Date.ToShortDateString();

            if (Database.GetExecuteSqlCommand(@"INSERT INTO ""Invoice_Requirement_Materials"" (""Id"", ""Invoice_Requirement_Order_Id"",""Receipt_Id"", ""Required_Quantity"", ""Credit_Account_Id"", ""Expenditures_Id"", ""FixedAssets_Id"", ""Description"") 
                            VALUES (" + currentOrderMaterial.GenId + "," + irmoDTO.Invoice_Requirement_Order_Id + "," + irmoDTO.Receipt_Id + "," + irmoDTO.Required_Quantity + "," + irmoDTO.Credit_Account_Id + 
                                      "," + irmoDTO.Expenditures_Id + "," + irmoDTO.FixedAssets_Id + "," + irmoDTO.Description + ")"))
            {
                return currentOrderMaterial.GenId;
            }
            else
            {
                return 0;
            }

        }

        public LastIdInvoicesReqMatGenDTO LastInvoicesRequirementMatId()
        {
            string procName = @"select * from ""GetLastIdInvoicesReqMatGenProc""";

            return mapper.Map<LastIdInvoicesReqMatGen, LastIdInvoicesReqMatGenDTO>(lastIdInvoicesReqMatGen.SQLExecuteProc(procName).First());
        }

        #endregion

        #region StoreHouses CRUD method's                     

        public int StoreHousesCreate(StorehousesDTO shDTO)
        {
            var createSH = storeHouses.Create(mapper.Map<Storehouses>(shDTO));
            return (int)createSH.Id;
        }

        public void StoreHousesUpdate(StorehousesDTO shDTO)
        {
            var updateSH = storeHouses.GetAll().SingleOrDefault(c => c.Id == shDTO.Id);
            storeHouses.Update((mapper.Map<StorehousesDTO, Storehouses>(shDTO, updateSH)));
        }

        public bool StoreHousesDelete(int id)
        {
            try
            {
                storeHouses.Delete(storeHouses.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region NomenclatureGroups CRUD method's              

        public int NomenclatureGroupCreate(NomenclatureGroupsDTO ngDTO)
        {
            var createNG = nomenclaturesGroups.Create(mapper.Map<Nomenclature_Groups>(ngDTO));
            return (int)createNG.Id;
        }

        public void NomenclatureGroupUpdate(NomenclatureGroupsDTO ngDTO)
        {
            var updateNG = nomenclaturesGroups.GetAll().SingleOrDefault(c => c.Id == ngDTO.Id);
            nomenclaturesGroups.Update((mapper.Map<NomenclatureGroupsDTO, Nomenclature_Groups>(ngDTO, updateNG)));
        }

        public bool NomenclatureGroupDelete(int id)
        {
            try
            {
                nomenclaturesGroups.Delete(nomenclaturesGroups.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region NomenclatureMaterials CRUD method's           

        public int NomenclatureMaterialsCreate(NomenclaturesDTO nmDTO)
        {
            var createNM = nomenclatures.Create(mapper.Map<NOMENCLATURES>(nmDTO));
            return (int)createNM.ID;
        }

        public void NomenclatureMaterialsUpdate(NomenclaturesDTO nmDTO)
        {
            var updateNM = nomenclatures.GetAll().SingleOrDefault(c => c.ID == nmDTO.ID);
            nomenclatures.Update((mapper.Map<NomenclaturesDTO, NOMENCLATURES>(nmDTO, updateNM)));
        }

        public bool NomenclatureMaterialsDelete(int id)
        {
            try
            {
                nomenclatures.Delete(nomenclatures.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ToolActs CRUD method's                        

        public int ToolActsCreate(ToolActsDTO taDTO)
        {
            var createTA = toolActs.Create(mapper.Map<ToolActs>(taDTO));
            return (int)createTA.Id;
        }

        public void ToolActsUpdate(ToolActsDTO taDTO)
        {
            var updateTA = toolActs.GetAll().SingleOrDefault(c => c.Id == taDTO.Id);
            toolActs.Update((mapper.Map<ToolActsDTO, ToolActs>(taDTO, updateTA)));
        }

        public bool ToolActsDelete(int id)
        {
            try
            {
                toolActs.Delete(toolActs.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ToolActsMaterials CRUD method's               

        public int ToolActMaterialCreate(ToolActMaterialsDTO tamDTO)
        {
            var createTAM = toolActMaterials.Create(mapper.Map<ToolActMaterials>(tamDTO));
            return (int)createTAM.Id;
        }

        public void ToolActsMaterialUpdate(ToolActMaterialsDTO tamDTO)
        {
            var updateTAM = toolActMaterials.GetAll().SingleOrDefault(c => c.Id == tamDTO.Id);
            toolActMaterials.Update((mapper.Map<ToolActMaterialsDTO, ToolActMaterials>(tamDTO, updateTAM)));
        }

        public void ToolActMaterialCreateRange(List<ToolActMaterialsDTO> source)
        {
            toolActMaterials.CreateRange(mapper.Map<List<ToolActMaterialsDTO>, IEnumerable<ToolActMaterials>>(source));
        }

        public bool ToolActMaterialRemoveRange(List<ToolActMaterialsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = toolActMaterials.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    toolActMaterials.Delete(deleteModel);
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Orders CRUD method's

        public int OrderCreate(OrdersDTO oDTO)
        {
            LastIdOrderGenDTO currentOrderId = OrderLastId();

            oDTO.ID = currentOrderId.GenId;

            var createOrder = orders.Create(mapper.Map<ORDERS>(oDTO));
            return (int)createOrder.ID;
        }

        public int OrderCreateDirect()
        {
            LastIdOrderGenDTO currentOrderId = OrderLastId();

            if (Database.GetExecuteSqlCommand(@"INSERT INTO ORDERS(Id, DEBIT_ACCOUNT_ID) 
                            VALUES (" + currentOrderId.GenId +","+14+")"))
            {
                return currentOrderId.GenId;
            }
            else
            {
                return 0;
            }
        }

        

        public LastIdOrderGenDTO OrderLastId()
        {
            string procName = @"select * from ""GetLastIdOrderGenProc""";

            return mapper.Map<LastIdOrderGen, LastIdOrderGenDTO>(lastIdOrderGen.SQLExecuteProc(procName).First());
        }


        public void OrderUpdate(OrdersDTO oDTO, bool afterCreate = false)
        {

            try
            {
                var updateOrder = orders.GetAll().SingleOrDefault(c => c.ID == oDTO.ID);
                orders.Update((mapper.Map<OrdersDTO, ORDERS>(oDTO, updateOrder)));
            }
            catch (Exception)
            {
                if (afterCreate)
                    OrderDelete(oDTO.ID);
    
            }
            
        }

        public bool OrderDelete(int id)
        {
            try
            {
                orders.Delete(orders.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
                
        #endregion

        #region Receipts CRUD method's

        public int ReceiptCreate(ReceiptsDTO rDTO)
        {
            LastIdReceiptGenDTO currentReceiptId = ReceiptLastId();

            rDTO.ID = currentReceiptId.GenId;

            var createReceipt = receipts.Create(mapper.Map<RECEIPTS>(rDTO));
            return (int)createReceipt.ID;
        }

        public int ReceiptUpdateDirect(ReceiptsDTO receiptsDTO)
        {
            try
            {
                
                Database.GetExecuteSqlCommand(@"UPDATE RECEIPTS SET 
                                                                ORDER_ID =" + receiptsDTO.ORDER_ID +
                                                                ", POS =" + null +
                                                                ", QUANTITY =" + null +
                                                                ", TOTAL_PRICE =" + null +
                                                                ", NOMENCLATURE_ID =" + null +
                                                                ", \"Storehouse_Id\" =" + null +
                                                                " WHERE ID =" + receiptsDTO.ID);                                    
            }
            catch (Exception)
            {
                return 0;
            }

            return receiptsDTO.ID;
        }

        public int ReceiptCreateDirect()
        {
            LastIdReceiptGenDTO currentReceiptId = ReceiptLastId();

            ReceiptsDTO rDTO = new ReceiptsDTO() { ID = (currentReceiptId.GenId +1), ORDER_ID = 37455, QUANTITY =1, TOTAL_PRICE =1000};

            var createReceipt = receipts.Create(mapper.Map<RECEIPTS>(rDTO));
            return (int)createReceipt.ID;
        }



        public void ReceiptUpdate(ReceiptsDTO rDTO)
        {
            var updateReceipt = receipts.GetAll().SingleOrDefault(c => c.ID == rDTO.ID);
            receipts.Update((mapper.Map<ReceiptsDTO, RECEIPTS>(rDTO, updateReceipt)));
        }

        public void ReceiptCreateRange(List<ReceiptsDTO> source)
        {
            receipts.CreateRange(mapper.Map<List<ReceiptsDTO>, IEnumerable<RECEIPTS>>(source));
        }

        public bool ReceiptRemoveRange(List<ReceiptsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = receipts.GetAll().SingleOrDefault(p => p.ID == item.ID);
                    receipts.Delete(deleteModel);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public LastIdReceiptGenDTO ReceiptLastId()
        {
            string procName = @"select * from ""GetLastIdReceiptGenProc""";

            return mapper.Map<LastIdReceiptGen, LastIdReceiptGenDTO>(lastIdReceiptGen.SQLExecuteProc(procName).First());
        }

        public bool ReceiptDelete(int id)
        {
            try
            {
                receipts.Delete(receipts.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #endregion

        #region Delivery CRUD method's

        public int DeliveryCreate(DeliveryDTO delDTO)
        {
            var createTA = delivery.Create(mapper.Map<Delivery>(delDTO));
            return (int)createTA.Id;
        }

        public void DeliveryUpdate(DeliveryDTO delDTO)
        {
            var updateDE = delivery.GetAll().SingleOrDefault(c => c.Id == delDTO.Id);
            delivery.Update((mapper.Map<DeliveryDTO, Delivery>(delDTO, updateDE)));
        }

        public bool DeliveryDelete(int id)
        {
            try
            {
                delivery.Delete(delivery.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region DeliveryOrder CRUD method's

        public int DeliveryOrderCreate(DeliveryOrderDTO docDTO)
        {
            var deliveryOrderCr = deliveryOrder.Create(mapper.Map<DeliveryOrder>(docDTO));
            return (int)deliveryOrderCr.Id; 
        }
        public void DeliveryOrderUpdate(DeliveryOrderDTO docDTO)
        {
            var updateDE = deliveryOrder.GetAll().SingleOrDefault(c => c.Id == docDTO.Id);
            deliveryOrder.Update((mapper.Map<DeliveryOrderDTO, DeliveryOrder>(docDTO, updateDE)));
        }
        public bool DeliveryOrderDelete(int id)
        {
            try
            {
                deliveryOrder.Delete(deliveryOrder.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        
        }

        #endregion

        #region DeliveryOrdersDetails CRUD method's

        public int DeliveryOrdersDetailsCreate(DeliveryOrdersDetailsDTO dodDTO)
        {
            var deliveryOrderDetailsCreate = deliveryOrdersDetails.Create(mapper.Map<DeliveryOrdersDetails>(dodDTO));
            return (int)deliveryOrderDetailsCreate.Id;
        }
        public void DeliveryOrdersDetailsUpdate(DeliveryOrdersDetailsDTO dodDTO)
        {
            var updateDod = deliveryOrdersDetails.GetAll().SingleOrDefault(c => c.Id == dodDTO.Id);
            deliveryOrdersDetails.Update((mapper.Map<DeliveryOrdersDetailsDTO, DeliveryOrdersDetails>(dodDTO, updateDod)));
        }
        public bool DeliveryOrdersDetailsDelete(int id)
        {
            try
            {
                deliveryOrdersDetails.Delete(deliveryOrdersDetails.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion
        
        #region Vat CRUD method's

        public int VatCreate(VatDTO vatDTO)
        {
            var createVat = vat.Create(mapper.Map<VAT>(vatDTO));
            return (int)createVat.ID;
        }

        public int VatCreateDirect(int orderId)
        {

            if (Database.GetExecuteSqlCommand(@"INSERT INTO VAT(Id) VALUES (" + orderId + ")"))
            {
                return orderId;
            }
            else
            {
                return 0;
            }
        }


        public void VatUpdate(VatDTO vatDTO)
        {
            var updateVat = vat.GetAll().SingleOrDefault(c => c.ID == vatDTO.ID);
            vat.Update((mapper.Map<VatDTO, VAT>(vatDTO, updateVat)));
        }

        public bool VatDelete(int id)
        {
            try
            {
                vat.Delete(vat.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region ExpendituresAccountant CRUD method's

        public int ExpendituresAccountantCreate(ExpedinturesAccountantDTO eaDTO)
        {
            var expenditureAccontantCreate = expenditureAccountant.Create(mapper.Map<EXPENDITURES_ACCOUNTANT>(eaDTO));
            return (int)expenditureAccontantCreate.ID;
        }
        public void ExpendituresAccountantUpdate(ExpedinturesAccountantDTO eaDTO)
        {
            var expenditureAccontantUpdate = expenditureAccountant.GetAll().SingleOrDefault(c => c.ID == eaDTO.ID);
            expenditureAccountant.Update((mapper.Map<ExpedinturesAccountantDTO, EXPENDITURES_ACCOUNTANT>(eaDTO, expenditureAccontantUpdate)));
        }
        public bool ExpendituresAccountantDelete(int id)
        {
            try
            {
                expenditureAccountant.Delete(expenditureAccountant.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion

        #region ExpendituresStoreHouses CRUD method's

        public int ExpendituresStoreHousesCreate(ExpendituresStoreHousesDTO eaDTO)
        {
            var expendituresStorehousesCreate = expendituresStoreHouses.Create(mapper.Map<ExpendituresStoreHouses>(eaDTO));
            return (int)expendituresStorehousesCreate.Id;
        }
        public void ExpendituresStoreHousesUpdate(ExpendituresStoreHousesDTO eaDTO)
        {
            var expendituresStoreHousesUpdate = expendituresStoreHouses.GetAll().SingleOrDefault(c => c.Id == eaDTO.Id);
            expendituresStoreHouses.Update((mapper.Map<ExpendituresStoreHousesDTO, ExpendituresStoreHouses>(eaDTO, expendituresStoreHousesUpdate)));
        }
        public bool ExpendituresStoreHousesDelete(int id)
        {
            try
            {
                expendituresStoreHouses.Delete(expendituresStoreHouses.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion

        #region New ExpenditureStoreHouse CRUD method's

        public int ExpenditureStoreHouseCreate(ExpenditureStoreHouseDTO eaDTO)
        {
            var expenditureStorehouseCreate = expenditureStoreHouse.Create(mapper.Map<ExpenditureStoreHouse>(eaDTO));
            return (int)expenditureStorehouseCreate.Id;
        }
        public void ExpenditureStoreHouseUpdate(ExpenditureStoreHouseDTO eaDTO)
        {
            var expenditureStoreHouseUpdate = expenditureStoreHouse.GetAll().SingleOrDefault(c => c.Id == eaDTO.Id);
            expenditureStoreHouse.Update((mapper.Map<ExpenditureStoreHouseDTO, ExpenditureStoreHouse>(eaDTO, expenditureStoreHouseUpdate)));
        }
        public bool ExpenditureStoreHouseDelete(int id)
        {
            try
            {
                expenditureStoreHouse.Delete(expenditureStoreHouse.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        #endregion

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}

