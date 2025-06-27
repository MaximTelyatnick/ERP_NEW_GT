using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Internal;
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
    public class MtsSpecificationsService : IMtsSpecificationsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<MtsAssemblies> mtsAssemblies;
        private IRepository<MtsAssembliesInfo> mtsAssembliesInfo;
        private IRepository<MtsAssembliesCustomerInfo> mtsAssembliesCustomerInfo;
        private IRepository<MtsSpecificationTreeInfo> mtsSpecificationTreeInfo;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<Contractors> contractors;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<MtsSpecifications> mtsSpecificationss;
        private IRepository<MtsDetailsInfo> mtsDetailsInfo;

        private IRepository<MTSSpecificationss> mtsSpecificationsOld;
        private IRepository<MTSAuthorizationUsers> mtsAuthorizationUsers;
        private IRepository<MTSDetails> mtsDetailss;
        private IRepository<MTSGost> mtsGost;
        private IRepository<MTSCreateDetals> mtsCreateDetals;
        private IRepository<MTSDetalsProcessing> mtsDetailsProcessing;
        private IRepository<MTSGuages> mtsGuages;
        private IRepository<MTSNomenclaturesOld> mtsNomenclatures;
        private IRepository<MTSMeasure> mtsMeasure;
        private IRepository<MTSPurchasedProducts> mtsPurchasedProductss;
        private IRepository<MTSMaterials> mtsMaterialss;
        private IRepository<MTSNomenclatureGroupsOld> mtsNomenclatureGroups;
        private IRepository<MTSDetails> mtsDetals;
        private IRepository<MTS_CUSTOMERORDERS> mtsCustomerOrders;
        private IRepository<MTS_DETAILS> mtsDetails;
        private IRepository<MTS_SPECIFICATIONS> mtsSpecifications;
        private IRepository<MTS_PURCHASED_PRODUCTS> mtsPurchasedProducts;
        private IRepository<MTS_MATERIALS> mtsMaterials;


        private IMapper mapper;

        public MtsSpecificationsService(IUnitOfWork uow)
        {
            Database = uow;

            employeesDetails = Database.GetRepository<EmployeesDetails>(); 
            mtsAssemblies = Database.GetRepository<MtsAssemblies>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            contractors = Database.GetRepository<Contractors>();
            mtsAssembliesInfo = Database.GetRepository<MtsAssembliesInfo>();
            mtsAssembliesCustomerInfo = Database.GetRepository<MtsAssembliesCustomerInfo>();
            mtsSpecificationTreeInfo = Database.GetRepository<MtsSpecificationTreeInfo>();
            mtsSpecificationss = Database.GetRepository<MtsSpecifications>();
            mtsDetailsInfo = Database.GetRepository<MtsDetailsInfo>();

            mtsSpecificationsOld = Database.GetRepository<MTSSpecificationss>();
            mtsAuthorizationUsers = Database.GetRepository<MTSAuthorizationUsers>();
            mtsDetailss = Database.GetRepository<MTSDetails>();
            mtsGost = Database.GetRepository<MTSGost>();
            
            mtsCreateDetals = Database.GetRepository<MTSCreateDetals>();
            mtsDetailsProcessing = Database.GetRepository<MTSDetalsProcessing>();
            mtsGuages = Database.GetRepository<MTSGuages>();
            mtsNomenclatures = Database.GetRepository<MTSNomenclaturesOld>();
            mtsMeasure = Database.GetRepository<MTSMeasure>();
            mtsPurchasedProductss = Database.GetRepository<MTSPurchasedProducts>();
            mtsMaterialss = Database.GetRepository<MTSMaterials>();
            mtsNomenclatureGroups = Database.GetRepository<MTSNomenclatureGroupsOld>();
            mtsDetals = Database.GetRepository<MTSDetails>();
            mtsDetails = Database.GetRepository<MTS_DETAILS>();
            mtsPurchasedProducts = Database.GetRepository<MTS_PURCHASED_PRODUCTS>();
            mtsMaterials = Database.GetRepository<MTS_MATERIALS>();
            mtsSpecifications = Database.GetRepository<MTS_SPECIFICATIONS>();
            mtsCustomerOrders = Database.GetRepository<MTS_CUSTOMERORDERS>();




        var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MtsAssembliesInfo, MtsAssembliesInfoDTO>();
                cfg.CreateMap<MtsSpecificationTreeInfo, MtsSpecificationTreeInfoDTO>();
                cfg.CreateMap<MtsAssemblies, MtsAssembliesDTO>();
                cfg.CreateMap<MtsAssembliesDTO, MtsAssemblies>();
                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<EmployeesDetails, EmployeesDetailsDTO>();
                cfg.CreateMap<MtsSpecifications, MtsSpecificationsDTO>();
                cfg.CreateMap<MtsSpecificationsDTO, MtsSpecifications>();
                cfg.CreateMap<MtsDetailsInfo, MtsDetailsInfoDTO>();
                cfg.CreateMap<MtsAssembliesCustomerInfo, MtsAssembliesCustomerInfoDTO>();

                cfg.CreateMap<MTSSpecificationss, MTSSpecificationssDTO>();
                cfg.CreateMap<MTSSpecificationssDTO, MTSSpecificationss>();
                cfg.CreateMap<MTSAuthorizationUsersDTO, MTSAuthorizationUsers>();
                cfg.CreateMap<MTSAuthorizationUsers, MTSAuthorizationUsersDTO>();
                cfg.CreateMap<MTSDetailsDTO, MTSDetails>();
                cfg.CreateMap<MTSDetails, MTSDetailsDTO>();

                cfg.CreateMap<MTSGostDTO, MTSGost>();
                cfg.CreateMap<MTSGost, MTSGostDTO>();
                cfg.CreateMap<MTSCreateDetalsDTO, MTSCreateDetals>();
                cfg.CreateMap<MTSCreateDetals, MTSCreateDetalsDTO>();
                
                cfg.CreateMap<MTSDetalsProcessingDTO, MTSDetalsProcessing>();
                cfg.CreateMap<MTSDetalsProcessing, MTSDetalsProcessingDTO>();
                cfg.CreateMap<MTSGuagesDTO, MTSGuages>();
                cfg.CreateMap<MTSGuages, MTSGuagesDTO>();
                cfg.CreateMap<MTSNomenclaturesOldDTO, MTSNomenclaturesOld>();
                cfg.CreateMap<MTSNomenclaturesOld, MTSNomenclaturesOldDTO>();
                cfg.CreateMap<MTSMeasureDTO, MTSMeasure>();
                cfg.CreateMap<MTSMeasure, MTSMeasureDTO>();
                cfg.CreateMap<MTSPurchasedProductsDTO, MTSPurchasedProducts>();
                cfg.CreateMap<MTSPurchasedProducts, MTSPurchasedProductsDTO>();
                cfg.CreateMap<MTSMaterialsDTO, MTSMaterials>();
                cfg.CreateMap<MTSMaterials, MTSMaterialsDTO>();
                cfg.CreateMap<MTSNomenclatureGroupsOldDTO, MTSNomenclatureGroupsOld>();
                cfg.CreateMap<MTSNomenclatureGroupsOld, MTSNomenclatureGroupsOldDTO>();
                cfg.CreateMap<MTSDetailsDTO, MTSDetails>();
                cfg.CreateMap<MTSDetails, MTSDetailsDTO>();
                cfg.CreateMap<MTS_DETAILS, MTSDetailsDTO>();
                cfg.CreateMap<MTS_MATERIALS, MTSMaterialsDTO>();
                cfg.CreateMap<MTS_PURCHASED_PRODUCTS, MTSPurchasedProductsDTO>();
                cfg.CreateMap<MTS_SPECIFICATIONS, MtsSpecificationsDTO>();
                cfg.CreateMap<MTS_CUSTOMERORDERS, MTSCustomerOrdersDTO>();

            });

            mapper = config.CreateMapper();
        }

        #region Get method's

        public IEnumerable<MtsAssembliesDTO> GetMtsAssembliesByRoot(long rootId)
        {
            var result = (from a in mtsAssemblies.GetAll()
                          join ed in mtsSpecificationss.GetAll() on a.Id equals ed.AssemblyId into aed
                          from ed in aed.DefaultIfEmpty()
                          where ed.RootId == rootId && ed.AssemblyId != null
                          select new MtsAssembliesDTO()
                          {
                              Id = a.Id,
                              Name = a.Name,
                              Drawing = a.Drawing,
                              DesignerId = a.DesignerId,
                              Description = a.Description,
                              UserId = a.UserId,
                              DateCreated = a.DateCreated,
                              AssemblyStatus = a.AssemblyStatus,
                          }
                         );

            return result.ToList();
        }

        public IEnumerable<MtsAssembliesInfoDTO> GetMtsAssemblies(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetMtsAssemblies""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<MtsAssembliesInfo>, List<MtsAssembliesInfoDTO>>(mtsAssembliesInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<MtsAssembliesInfoDTO> GetMtsAssembliesAll(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetMtsAssembliesAll""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<MtsAssembliesInfo>, List<MtsAssembliesInfoDTO>>(mtsAssembliesInfo.SQLExecuteProc(procName, Parameters));
        }


        public IEnumerable<MtsAssembliesDTO> GetAllMtsAssemblies()
        {
            return mapper.Map<IEnumerable<MtsAssemblies>, List<MtsAssembliesDTO>>(mtsAssemblies.GetAll());
        }

        public MtsAssembliesInfoDTO GetSingleMtsAssemblyInfo(long id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("Id", id)
                };

            string procName = @"select * from ""GetSingleMtsAssemblyInfo""(@Id)";

            return mapper.Map<IEnumerable<MtsAssembliesInfo>, List<MtsAssembliesInfoDTO>>(mtsAssembliesInfo.SQLExecuteProc(procName, Parameters)).SingleOrDefault();
        }




        public MtsAssembliesDTO GetMtsAssemblyById(long id)
        {
            return mapper.Map<MtsAssemblies, MtsAssembliesDTO>(mtsAssemblies.GetAll().SingleOrDefault(a => a.Id == id));
        }

        public List<MtsSpecificationTreeInfoDTO> GetMtsSpecificationTreeInfoByRootId(long id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("SpecificationRootId", id)
                };

            string procName = @"select * from ""GetMtsSpecificationTreeInfo""(@SpecificationRootId)";

            return mapper.Map<IEnumerable<MtsSpecificationTreeInfo>, List<MtsSpecificationTreeInfoDTO>>(mtsSpecificationTreeInfo.SQLExecuteProc(procName, Parameters)); 
        }

        public IEnumerable<MtsAssembliesInfoDTO> GetJournalAssemblies()
        {
            string procName = @"select * from ""GetAssemblyWithCustomerOrders""";

            var rezult = mapper.Map<IEnumerable<MtsAssembliesInfo>, List<MtsAssembliesInfoDTO>>(mtsAssembliesInfo.SQLExecuteProc(procName)).ToList();

            List<MtsAssembliesInfoDTO> returnSortList = new List<MtsAssembliesInfoDTO>();

            //Убираем дубликаты
            foreach (var item in rezult)
            {
                string[] splitCustomerOrderArray = item.CustomerOrderNumber.Split(',');
                item.CustomerOrderNumber = string.Join(",", (splitCustomerOrderArray.Distinct()).ToArray());
                returnSortList.Add(item);
            }

            return returnSortList; 
        }

        public IEnumerable<MtsAssembliesCustomerInfoDTO> GetJournalAssembliesWithCustomerOrders()
        {
            string procName = @"select * from ""GetAssemblyCustomer""";

            return mapper.Map<IEnumerable<MtsAssembliesCustomerInfo>, List<MtsAssembliesCustomerInfoDTO>>(mtsAssembliesCustomerInfo.SQLExecuteProc(procName));
        }
        
        public IEnumerable<MtsDetailsInfoDTO> GetDetailsBySpecificationId(long specId)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("SpecificationId", specId)
                };

            string procName = @"select * from ""GetMtsDetailsBySpecId""(@SpecificationId)";

            return mapper.Map<IEnumerable<MtsDetailsInfo>, List<MtsDetailsInfoDTO>>(mtsDetailsInfo.SQLExecuteProc(procName, Parameters));
        }
        
        //public IEnumerable<MTSSpecificationsDTO> GetAllSpecificationOld()
        //{
        //    return mapper.Map<IEnumerable<MTSSpecifications>, IList<MTSSpecificationsDTO>>(mtsSpecificationsOld.GetAll());
        //}
        //public IEnumerable<MTSSpecificationsDTO> GetAllBuyDetailsSpecific()
        //{
        //    return mapper.Map<IEnumerable<MTSSpecifications>, IList<MTSSpecificationsDTO>>(mtsSpecificationsOld.GetAll());
        //}

        public IEnumerable<MTSSpecificationssDTO> GetAllSpecificationOldByPeriod(DateTime startDate, DateTime endDate)
        {

            var result = (from mts in mtsSpecificationsOld.GetAll()
                          join autUser in mtsAuthorizationUsers.GetAll() on mts.AUTHORIZATION_USERS_ID equals autUser.ID into autUs
                          from autUser in autUs.DefaultIfEmpty()

                          where (mts.CREATION_DATE >= startDate && mts.CREATION_DATE <= endDate)
                          select new MTSSpecificationssDTO()
                          {
                              ID = mts.ID,
                              NAME = mts.NAME,
                              AUTHORIZATION_USERS_ID = mts.AUTHORIZATION_USERS_ID,
                              WEIGHT = mts.WEIGHT,
                              CREATION_DATE = mts.CREATION_DATE,
                              DRAWING = mts.DRAWING,
                              AUTHORIZATION_USERS_NAME = autUser.NAME,
                              QUANTITY = mts.QUANTITY,
                              COMPILATION_DRAWINGS = mts.COMPILATION_DRAWINGS,
                              COMPILATION_NAMES = mts.COMPILATION_NAMES,
                              COMPILATION_QUANTITIES = mts.COMPILATION_QUANTITIES,
                               SET_COLOR = mts.SET_COLOR
                          }).ToList();
                
            return result;
        }

        public IEnumerable<MTSSpecificationssDTO> GetAllSpecificationOld()
        {

            var result = (from mts in mtsSpecificationsOld.GetAll()
                          join autUser in mtsAuthorizationUsers.GetAll() on mts.AUTHORIZATION_USERS_ID equals autUser.ID into autUs
                          from autUser in autUs.DefaultIfEmpty()

                          select new MTSSpecificationssDTO()
                          {
                              ID = mts.ID,
                              NAME = mts.NAME,
                              AUTHORIZATION_USERS_ID = mts.AUTHORIZATION_USERS_ID,
                              WEIGHT = mts.WEIGHT,
                              CREATION_DATE = mts.CREATION_DATE,
                              DRAWING = mts.DRAWING,
                              AUTHORIZATION_USERS_NAME = autUser.NAME,
                              QUANTITY = mts.QUANTITY
                          }).ToList();

            return result;
        }

        //public IEnumerable<MTSCreateDetalsDTO> GetAllDetailsSpecific(int spesificId)
        //{
        //    var result = (from mtsSpec in mtsSpecificationsOld.GetAll()

        //                  join mtsDetal in mtsDetails.GetAll() on mtsSpec.ID equals mtsDetal.SPECIFICATIONS_ID into mtsDetals
        //                  from mtsDetal in mtsDetals.DefaultIfEmpty()

        //                  join mtsCreateDet in mtsCreateDetals.GetAll() on mtsDetal.CREATED_DETAILS_ID equals mtsCreateDet.ID into mtsCeateDetals
        //                  from mtsCreateDet in mtsCeateDetals.DefaultIfEmpty()

        //                  join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
        //                  from mtsNom in mtsNomen.DefaultIfEmpty()

        //                  join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
        //                  from mtsG in mtsGos.DefaultIfEmpty()

        //                  join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
        //                  from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

        //                  join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
        //                  from mtsGua in mtsGuag.DefaultIfEmpty()

        //                  where (mtsSpec.ID == spesificId /*&& mtsSpec.ID != null*/)

        //                  select new MTSCreateDetalsDTO()
        //                  {
        //                      ID = mtsCreateDet.ID,//mtsDetal.CREATED_DETAILS_ID,//??????????
        //                      NAME = mtsCreateDet.NAME,//1 
        //                      GOSTNAME = mtsG.NAME,//2 
        //                      NOMENCLATURESNOTE = mtsNom.NOTE,//3 
        //                      DRAWING = mtsCreateDet.DRAWING,//4
        //                      QUANTITY = mtsDetal.QUANTITY,//5
        //                      DETALSPROCESSING = mtsDetalsProc.NAME,//6
        //                      NOMENCLATURESNAME = mtsNom.NAME,//7
        //                      GUAEGENAME = mtsGua.NAME,//8 
        //                      WIDTH = mtsCreateDet.WIDTH,//9
        //                      HEIGHT = mtsCreateDet.HEIGHT,//10
        //                      NOMENCLATURESWEIGHT = mtsNom.WEIGHT,//11 
        //                      QUANTITY_OF_BLANKS = mtsDetal.QUANTITY_OF_BLANKS,//12                              
        //                      PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
        //                      NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID
        //                  });

        //    if (result == null)
        //        return null;



        //    return result.ToList();
        //}

        //public IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecific(int spesificId)
        //{
        //    var rez = (from mtsSpec in mtsSpecificationsOld.GetAll()

        //               join mtsPurc in mtsPurchasedProducts.GetAll() on mtsSpec.ID equals mtsPurc.SPECIFICATIONS_ID into mtsPurchased
        //               from mtsPurc in mtsPurchased.DefaultIfEmpty()

        //               join mtsNom in mtsNomenclatures.GetAll() on mtsPurc.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
        //               from mtsNom in mtsNomen.DefaultIfEmpty()

        //               join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
        //               from mtsMeas in mtsMeasur.DefaultIfEmpty()

        //               join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
        //               from gost in gosts.DefaultIfEmpty()

        //               where mtsSpec.ID == spesificId && mtsSpec.ID != null
        //               select new MTSPurchasedProductsDTO()
        //               {
        //                   ID = mtsSpec.ID,//mtsPurc.ID,
        //                   NOMENCLATURESNAME = mtsNom.NAME,
        //                   GUAEGENAME = mtsNom.GUAGE,
        //                   GOSTNAME = gost.NAME,
        //                   NOMENCLATURESNOTE = mtsNom.NOTE,
        //                   MEASURENAME = mtsMeas.NAME,
        //                   WEIGHT = mtsNom.WEIGHT,
        //                   QUANTITY = mtsPurc.QUANTITY,
        //                   NOMENCLATURES_ID = mtsPurc.NOMENCLATURES_ID,
        //                   SPECIFICATIONS_ID = mtsPurc.SPECIFICATIONS_ID
        //               }).DefaultIfEmpty().ToList();

        //    return rez;
        //}

        //public IEnumerable<MTSMaterialsDTO> GetMaterialsSpecific(int spesificId)
        //{
        //    var rez = (from mtsSpec in mtsSpecificationsOld.GetAll()

        //               join mtsMat in mtsMaterials.GetAll() on mtsSpec.ID equals mtsMat.SPECIFICATIONS_ID into mtsMater
        //               from mtsMat in mtsMater.DefaultIfEmpty()

        //               join mtsNom in mtsNomenclatures.GetAll() on mtsMat.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
        //               from mtsNom in mtsNomen.DefaultIfEmpty()

        //               join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
        //               from mtsMeas in mtsMeasur.DefaultIfEmpty()

        //               join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
        //               from gost in gosts.DefaultIfEmpty()

        //               where mtsSpec.ID == spesificId && mtsSpec.ID != null

        //               select new MTSMaterialsDTO()
        //               {
        //                   ID = mtsSpec.ID,//mtsMat.ID,
        //                   NOMENCLATURES_ID = mtsNom.ID,
        //                   NOMENCLATURESNAME = mtsNom.NAME,//1
        //                   GUAGENAME = mtsNom.GUAGE,//2
        //                   GOSTNAME = gost.NAME,//3
        //                   NOMENCLATURESNOTE = mtsNom.NOTE,//4
        //                   MEASURENAME = mtsMeas.NAME,//5
        //                   NOMENCLATURESWEIGHT = mtsNom.WEIGHT,//6
        //                   QUANTITY = mtsMat.QUANTITY,//7
        //                   SPECIFICATIONS_ID = mtsMat.SPECIFICATIONS_ID

        //               }).DefaultIfEmpty().ToList();

        //    return rez;

        //}


        //public IEnumerable<MTSCreateDetalsDTO> GetAllDetailsSpecific(int spesificId)
        //{
        //    var result = (

        //                  from mtsDetal in mtsDetails.GetAll() 

        //                  join mtsCreateDet in mtsCreateDetals.GetAll() on mtsDetal.CREATED_DETAILS_ID equals mtsCreateDet.ID into mtsCeateDetals
        //                  from mtsCreateDet in mtsCeateDetals.DefaultIfEmpty()

        //                  join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
        //                  from mtsNom in mtsNomen.DefaultIfEmpty()

        //                  join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
        //                  from mtsG in mtsGos.DefaultIfEmpty()

        //                  join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
        //                  from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

        //                  join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
        //                  from mtsGua in mtsGuag.DefaultIfEmpty()

        //                  where (mtsDetal.SPECIFICATIONS_ID == spesificId /*&& mtsSpec.ID != null*/)

        //                  select new MTSCreateDetalsDTO()
        //                  {
        //                      ID = mtsCreateDet.ID,//mtsDetal.CREATED_DETAILS_ID,//??????????
        //                      NAME = mtsCreateDet.NAME,//1 ++
        //                      GOSTNAME = mtsG.NAME,//2 
        //                      NOMENCLATURESNOTE = mtsNom.NOTE,//3 --
        //                      DRAWING = mtsCreateDet.DRAWING,//4++
        //                      QUANTITY = mtsDetal.QUANTITY,//5
        //                      DETALSPROCESSING = mtsDetalsProc.NAME,//6
        //                      NOMENCLATURESNAME = mtsNom.NAME,//7 --
        //                      GUAEGENAME = mtsGua.NAME,//8 
        //                      WIDTH = mtsCreateDet.WIDTH,//9++
        //                      HEIGHT = mtsCreateDet.HEIGHT,//10++
        //                      NOMENCLATURESWEIGHT = mtsNom.WEIGHT,//11 --
        //                      QUANTITY_OF_BLANKS = mtsDetal.QUANTITY_OF_BLANKS,//12                              
        //                      PROCESSING_ID = mtsCreateDet.PROCESSING_ID,//++
        //                      NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID //--
        //                  }).ToList();




        //    return result;
        //}



        public IEnumerable<MTSDetailsDTO> GetAllDetailsSpecificShort(int specificId)
        {
            return mapper.Map<IEnumerable<MTSDetails>, List<MTSDetailsDTO>>(mtsDetailss.GetAll().Where(srch => srch.SPECIFICATIONS_ID == specificId));
        }

        public IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecificShort(int specificId)
        {
            return mapper.Map<IEnumerable<MTSPurchasedProducts>, List<MTSPurchasedProductsDTO>>(mtsPurchasedProductss.GetAll().Where(srch => srch.SPECIFICATIONS_ID == specificId));
        }

        public IEnumerable<MTSMaterialsDTO> GetMaterialsSpecificShort(int specificId)
        {
            return mapper.Map<IEnumerable<MTSMaterials>, List<MTSMaterialsDTO>>(mtsMaterialss.GetAll().Where(srch => srch.SPECIFICATIONS_ID == specificId));
        }

        public IEnumerable<MTSCustomerOrdersDTO> GetMTSCustomerOrdersFullBySpecificationId(int customerOrderId)
        {
            var result = (from mco in mtsCustomerOrders.GetAll()
                          join co in customerOrders.GetAll() on mco.CustomerOrderId equals co.Id into coc
                          from co in coc.DefaultIfEmpty()
                          join mso in mtsSpecifications.GetAll() on mco.SpecificationId equals mso.ID into msoo
                          from mso in msoo.DefaultIfEmpty()
                          join con in contractors.GetAll() on co.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()

                          where mco.CustomerOrderId == customerOrderId
                          //orderby co.OrderDate, co.OrderNumber

                          select new MTSCustomerOrdersDTO
                          {
                              Id = mco.Id,
                              OrderNumber = co.OrderNumber,
                              CustomerOrderId = co.Id,
                              SpecificationId = mso.ID,
                               Assembly = mso.ASSEMBLY,
                                Quantity = mso.QUANTITY,
                                  SpecificationName = mso.NAME,
                                  
                              DataCreateCustomerOrder = co.DateCreate,
                              ContractorName = con.Name,
                              DateCreate = mco.DateCreate,
                              DateUpdate = mco.DateUpdate
                          });

            return result.ToList();
        }

        public IEnumerable<MTSDetailsDTO> GetAllDetailsSpecific(int spesificId)
        {
            var result = (

                          from mtsDetal in mtsDetails.GetAll()

                          join mtsCreateDet in mtsCreateDetals.GetAll() on mtsDetal.CREATED_DETAILS_ID equals mtsCreateDet.ID into mtsCeateDetals
                          from mtsCreateDet in mtsCeateDetals.DefaultIfEmpty()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          join mtsNomGroup in mtsNomenclatureGroups.GetAll() on mtsNom.NOMENCLATUREGROUPS_ID equals mtsNomGroup.ID into mtsNomGroupen
                          from mtsNomGroup in mtsNomGroupen.DefaultIfEmpty()

                          join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeases
                          from mtsMeas in mtsMeases.DefaultIfEmpty()

                          where (mtsDetal.SPECIFICATIONS_ID == spesificId /*&& mtsSpec.ID != null*/)

                          select new MTSDetailsDTO()
                          {
                              ID = mtsDetal.ID,//mtsDetal.CREATED_DETAILS_ID,//??????????
                              SPECIFICATIONS_ID = mtsDetal.SPECIFICATIONS_ID,
                              CREATED_DETAILS_ID = mtsDetal.CREATED_DETAILS_ID,
                              QUANTITY_OF_BLANKS = mtsDetal.QUANTITY_OF_BLANKS,
                              CODZAK = mtsDetal.CODZAK,
                              QUANTITY = mtsDetal.QUANTITY,
                              CHANGES = mtsDetal.CHANGES,
                              TIME_OF_ADD = mtsDetal.TIME_OF_ADD,

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              NOM_GROUP_ID = mtsNomGroup.ID,
                              //NOM_GROUP_ADDIT_CALCULATION_ACTIVE = (bool)mtsNomGroup.ADDIT_CALCULATION_ACTIVE,
                              NOM_GROUP_ADDIT_CALCULATION_ID = mtsNomGroup.ADDIT_CALCULATION_ID,
                              NOM_GROUP_CODPROD = mtsNomGroup.CODPROD,
                              NOM_GROUP_NAME = mtsNomGroup.NAME,
                              NOM_GROUP_PARENT_ID = mtsNomGroup.PARENT_ID,
                              NOM_GROUP_RATIO_OF_WASTE = mtsNomGroup.RATIO_OF_WASTE,
                              NOM_GROUP_SORTPOSITION = mtsNomGroup.SORTPOSITION,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsNom.GUAGE,
                               GUAEGESORT = mtsGua.SORTING,

                               MEASURE_NAME = mtsMeas.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT
                          }).ToList();
            return result;
        }

        //Nomenclature_id = (int)i.NOMENCLATURES_ID,
        //                                   Quantity = (decimal)(i.QUANTITY * val),
        //                                   Price = (decimal)i.MTS_NOMENCLATURES.PRICE * val,
        //                                   Name = i.MTS_NOMENCLATURES.NAME,
        //                                   Guage = i.MTS_NOMENCLATURES.GUAGE,
        //                                   Gost = i.MTS_NOMENCLATURES.MTS_GOST.NAME,
        //                                   Measure = i.MTS_NOMENCLATURES.MTS_MEASURE.NAME,
        //                                   Note = i.MTS_NOMENCLATURES.NOTE,
        //                                   SortPosition = (int)i.MTS_NOMENCLATURES.MTS_NOMENCLATURE_GROUPS.SORTPOSITION

        public IEnumerable<MTSPurchasedProductsDTO> GetBuysDetalSpecific(int spesificId)
        {
            var rez = (

                       from mtsPurc in mtsPurchasedProducts.GetAll()

                       join mtsNom in mtsNomenclatures.GetAll() on mtsPurc.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
                       from mtsNom in mtsNomen.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsNomGroup in mtsNomenclatureGroups.GetAll() on mtsNom.NOMENCLATUREGROUPS_ID equals mtsNomGroup.ID into mtsNomGroupen
                       from mtsNomGroup in mtsNomGroupen.DefaultIfEmpty()


                       where mtsPurc.SPECIFICATIONS_ID == spesificId
                       select new MTSPurchasedProductsDTO()
                       {
                           ID = mtsPurc.ID,//mtsPurc.ID,
                            CHANGES = mtsPurc.CHANGES,
                           
                           GUAEGENAME = mtsNom.GUAGE,
                           GOSTNAME = gost.NAME,

                           NOMENCLATURESNAME = mtsNom.NAME,
                           NOMENCLATURESNOTE = mtsNom.NOTE,
                            NOMENCLATURESPRICE = mtsNom.PRICE,

                            NOM_GROUP_ID = mtsNomGroup.ID,
                             NOM_GROUP_SORTPOSITION = mtsNomGroup.SORTPOSITION,

                           MEASURENAME = mtsMeas.NAME,
                           WEIGHT = mtsNom.WEIGHT,
                           QUANTITY = mtsPurc.QUANTITY,

                           NOMENCLATURES_ID = mtsPurc.NOMENCLATURES_ID,
                           SPECIFICATIONS_ID = mtsPurc.SPECIFICATIONS_ID
                       }).ToList();

                return rez;
        }


           public IEnumerable<MTSMaterialsDTO> GetMaterialsSpecific(int spesificId)
        {
            var rez = (//from mtsSpec in mtsSpecificationsOld.GetAll()
                
                       from mtsMat in mtsMaterials.GetAll() 
                       
                       join mtsNom in mtsNomenclatures.GetAll() on mtsMat.NOMENCLATURES_ID equals mtsNom.ID into mtsNomen
                       from mtsNom in mtsNomen.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNom.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNom.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsNomGroup in mtsNomenclatureGroups.GetAll() on mtsNom.NOMENCLATUREGROUPS_ID equals mtsNomGroup.ID into mtsNomGroupen
                       from mtsNomGroup in mtsNomGroupen.DefaultIfEmpty()

                       where mtsMat.SPECIFICATIONS_ID == spesificId 

                       select new MTSMaterialsDTO()
                       {
                           ID = mtsMat.ID,//mtsMat.ID,
                            CHANGES = mtsMat.CHANGES,
                           NOMENCLATURES_ID = mtsNom.ID,
                           NOMENCLATURESNAME = mtsNom.NAME,//1
                           GUAGENAME = mtsNom.GUAGE,//2
                           GOSTNAME = gost.NAME,//3
                           NOMENCLATURESNOTE = mtsNom.NOTE,//4
                           MEASURENAME = mtsMeas.NAME,//5
                            
                            WEIGHT = mtsNom.WEIGHT,//6
                           QUANTITY = mtsMat.QUANTITY,//7
                           SPECIFICATIONS_ID = mtsMat.SPECIFICATIONS_ID,
                            NOM_GROUP_ID = mtsNomGroup.ID,
                           NOM_GROUP_SORTPOSITION = mtsNomGroup.SORTPOSITION,
                           NOMENCLATURESPRICE = mtsNom.PRICE

                       }).ToList();

                return rez;
 
        }

        public IEnumerable<MTSNomenclatureGroupsOldDTO> GetAllNomenclatureGroupsOld()
        {
            return mapper.Map<IEnumerable<MTSNomenclatureGroupsOld>, IList<MTSNomenclatureGroupsOldDTO>>(mtsNomenclatureGroups.GetAll());
        }

        public IEnumerable<MTSNomenclaturesOldDTO> GetAllNomenclatures(int nomenGroupId)
        {
            var rez = (from mtsNomen in mtsNomenclatures.GetAll()

                       join mtsNomenGr in mtsNomenclatureGroups.GetAll() on mtsNomen.NOMENCLATUREGROUPS_ID equals mtsNomenGr.ID into mtsNomenGroup
                       from mtsNomenGr in mtsNomenGroup.DefaultIfEmpty()

                       join gost in mtsGost.GetAll() on mtsNomen.GOST_ID equals gost.ID into gosts
                       from gost in gosts.DefaultIfEmpty()

                       join mtsMeas in mtsMeasure.GetAll() on mtsNomen.MEASURE_ID equals mtsMeas.ID into mtsMeasur
                       from mtsMeas in mtsMeasur.DefaultIfEmpty()

                       where mtsNomen.NOMENCLATUREGROUPS_ID == nomenGroupId
                       select new MTSNomenclaturesOldDTO()
                       {
                           ID = mtsNomen.ID,
                           NAME = mtsNomen.NAME,
                           GOST = gost.NAME,
                           MEASURE = mtsMeas.NAME,
                           PRICE = mtsNomen.PRICE,
                           WEIGHT = mtsNomen.WEIGHT,
                           NOTE = mtsNomen.NOTE,
                           GUAGE = mtsNomen.GUAGE


                       }
                     ).ToList();
            return rez;
        }


        public IEnumerable<MTSDetalsProcessingDTO> GetDetailsProccesing()
        {
            return mapper.Map<IEnumerable<MTSDetalsProcessing>, IList<MTSDetalsProcessingDTO>>(mtsDetailsProcessing.GetAll());
        }


        public IEnumerable<MTSCreateDetalsDTO> GetAllCreateDetals()
        {
            var result = (

                          from mtsCreateDet in mtsCreateDetals.GetAll()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          select new MTSCreateDetalsDTO()
                          {
                               ID = mtsCreateDet.ID,
                                PROCCESINGNAME = mtsDetalsProc.NAME, 

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsGua.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT
                          }).ToList();
            return result;
        }

        public MTSCreateDetalsDTO GetCreateDetalsByDrawingNumber(string drawignNumber)
        {
            var result = (

                          from mtsCreateDet in mtsCreateDetals.GetAll()

                          join mtsNom in mtsNomenclatures.GetAll() on mtsCreateDet.NOMENCLATURE_ID equals mtsNom.ID into mtsNomen
                          from mtsNom in mtsNomen.DefaultIfEmpty()

                          join mtsG in mtsGost.GetAll() on mtsNom.GOST_ID equals mtsG.ID into mtsGos
                          from mtsG in mtsGos.DefaultIfEmpty()

                          join mtsDetalsProc in mtsDetailsProcessing.GetAll() on mtsCreateDet.PROCESSING_ID equals mtsDetalsProc.ID into mtsDetalsProcces
                          from mtsDetalsProc in mtsDetalsProcces.DefaultIfEmpty()

                          join mtsGua in mtsGuages.GetAll() on mtsNom.GUAGE_ID equals mtsGua.ID into mtsGuag
                          from mtsGua in mtsGuag.DefaultIfEmpty()

                          where mtsCreateDet.DRAWING == drawignNumber

                          select new MTSCreateDetalsDTO()
                          {
                              ID = mtsCreateDet.ID,
                              PROCCESINGNAME = mtsDetalsProc.NAME,

                              NOMENCLATURE_ID = mtsCreateDet.NOMENCLATURE_ID,
                              NOMENCLATURESWEIGHT = mtsNom.WEIGHT,
                              NOMENCLATURESNAME = mtsNom.NAME,
                              NOMENCLATURESNOTE = mtsNom.NOTE,

                              PROCESSING_ID = mtsCreateDet.PROCESSING_ID,
                              DETALSPROCESSING = mtsDetalsProc.NAME,

                              GUAEGENAME = mtsGua.NAME,

                              GOSTID = mtsNom.GOST_ID,
                              GOSTNAME = mtsG.NAME,

                              NAME = mtsCreateDet.NAME,
                              DRAWING = mtsCreateDet.DRAWING,
                              WIDTH = mtsCreateDet.WIDTH,//9++
                              HEIGHT = mtsCreateDet.HEIGHT
                          }).FirstOrDefault();
            return result;
        }





        #endregion

        #region MtsAssembies CRUD method's

        public long CreateAssembly(MtsAssembliesDTO mtsAssembly)
        {
            var createrecord = mtsAssemblies.Create(mapper.Map<MtsAssemblies>(mtsAssembly));
            return (long)createrecord.Id;
        }

        public void UpdateAssembly(MtsAssembliesDTO mtsAssembly)
        {

            var eGroup = mtsAssemblies.GetAll().SingleOrDefault(c => c.Id == mtsAssembly.Id);
            mtsAssemblies.Update((mapper.Map<MtsAssembliesDTO, MtsAssemblies>(mtsAssembly, eGroup)));
        }

        public void UpdateAssemblyDesignerCompany(int mtsAssemblyId, int designerCompanyId)
        {
            var eGroup = mtsAssemblies.GetAll().SingleOrDefault(c => c.Id == mtsAssemblyId);
            eGroup.DesignerCompanyId = designerCompanyId;
            mtsAssemblies.Update(eGroup);
        }

        public bool DeleteAssembly(long id)
        {
            try
            {
                mtsAssemblies.Delete(mtsAssemblies.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MtsSpecificationsTest CRUD method's

        public long CreateSpecification(MtsSpecificationsDTO mtsSpecification)
        {
            var createrecord = mtsSpecificationss.Create(mapper.Map<MtsSpecifications>(mtsSpecification));
            return (long)createrecord.Id;
        }

        public void UpdateSpecification(MtsSpecificationsDTO mtsSpecification)
        {
            var eGroup = mtsSpecificationss.GetAll().SingleOrDefault(c => c.Id == mtsSpecification.Id);
            mtsSpecificationss.Update((mapper.Map<MtsSpecificationsDTO, MtsSpecifications>(mtsSpecification, eGroup)));
        }

        public bool DeleteSpecification(long rootId)
        {
            try
            {
                mtsSpecificationss.DeleteAll(mtsSpecificationss.GetAll().Where(c => c.RootId == rootId));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSSpecification CRUD method's

        public int MTSSpecificationCreate(MTSSpecificationssDTO mtsSpecificationDTO)
        {
            var createSpec = mtsSpecificationsOld.Create(mapper.Map<MTSSpecificationss>(mtsSpecificationDTO));
            return (int)createSpec.ID;
        }

        public void MTSSpecificationUpdate(MTSSpecificationssDTO mtsSpecificationDTO)
        {
            var updateSpec = mtsSpecificationsOld.GetAll().SingleOrDefault(c => c.ID == mtsSpecificationDTO.ID);
            mtsSpecificationsOld.Update((mapper.Map<MTSSpecificationssDTO, MTSSpecificationss>(mtsSpecificationDTO, updateSpec)));
        }

        public bool MTSSpecificationDelete(int id)
        {
            try
            {
                mtsSpecificationsOld.Delete(mtsSpecificationsOld.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //-------
        public int MTSCreateDetailsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var createDetail = mtsCreateDetals.Create(mapper.Map<MTSCreateDetals>(mtsCreateDetalsDTO));
            return (int)createDetail.ID;
        }

        public void MTSCreateDetailsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var updateDetail = mtsCreateDetals.GetAll().SingleOrDefault(c => c.ID == mtsCreateDetalsDTO.ID);
            mtsCreateDetals.Update((mapper.Map<MTSCreateDetalsDTO, MTSCreateDetals>(mtsCreateDetalsDTO, updateDetail)));
        }

        public bool MTSCreateDetailsDelete(int id)
        {
            try
            {
                mtsCreateDetals.Delete(mtsCreateDetals.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //----

        public int MTSDetailCreate(MTSDetailsDTO mtsDetalsDTO)
        {
            var createDetail = mtsDetals.Create(mapper.Map<MTSDetails>(mtsDetalsDTO));
            return (int)createDetail.ID;
        }

        public void MTSDetailUpdate(MTSDetailsDTO mtsDetalsDTO)
        {
            var updateDetail = mtsDetals.GetAll().SingleOrDefault(c => c.ID == mtsDetalsDTO.ID);
            mtsDetals.Update((mapper.Map<MTSDetailsDTO, MTSDetails>(mtsDetalsDTO, updateDetail)));
        }

        public bool MTSDetailDelete(int id)
        {
            try
            {
                mtsCreateDetals.Delete(mtsCreateDetals.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSPurchasedProducts CRUD method's

        public int MTSPurchasedProductsCreate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO)
        {
            var createPurchprod = mtsPurchasedProductss.Create(mapper.Map<MTSPurchasedProducts>(mtsPurchasedProductsDTO));
            return (int)createPurchprod.ID;
        }

        public void MTSPurchasedProductsCreateRange(List<MTSPurchasedProductsDTO> source)
        {
            mtsPurchasedProductss.CreateRange(mapper.Map<List<MTSPurchasedProductsDTO>, IEnumerable<MTSPurchasedProducts>>(source));
        }

        public void MTSPurchasedProductsUpdate(MTSPurchasedProductsDTO mtsPurchasedProductsDTO)
        {
            var updatePurchProd = mtsPurchasedProductss.GetAll().SingleOrDefault(c => c.ID == mtsPurchasedProductsDTO.ID);
            mtsPurchasedProductss.Update((mapper.Map<MTSPurchasedProductsDTO, MTSPurchasedProducts>(mtsPurchasedProductsDTO, updatePurchProd)));
        }

        public bool MTSPurchasedProductsDelete(int id)
        {
            try
            {
                mtsPurchasedProducts.Delete(mtsPurchasedProducts.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        #endregion

        #region MTSMaterial CRUD method's

        public int MTSMaterialCreate(MTSMaterialsDTO mtsMaterialsDTO)
        {
            var createMaterial= mtsMaterialss.Create(mapper.Map<MTSMaterials>(mtsMaterialsDTO));
            return (int)createMaterial.ID;
        }

        public void MTSMaterialCreateRange(List<MTSMaterialsDTO> source)
        {
            mtsMaterialss.CreateRange(mapper.Map<List<MTSMaterialsDTO>, IEnumerable<MTSMaterials>>(source));
        }

        public void MTSMaterialUpdate(MTSMaterialsDTO mtsMaterialsDTO)
        {
            var updateMaterial = mtsMaterialss.GetAll().SingleOrDefault(c => c.ID == mtsMaterialsDTO.ID);
            mtsMaterialss.Update((mapper.Map<MTSMaterialsDTO, MTSMaterials>(mtsMaterialsDTO, updateMaterial)));
        }

        public bool MTSMaterialDelete(int id)
        {
            try
            {
                mtsMaterials.Delete(mtsMaterials.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region MTSDetails CRUD method's

        public int MTSDetailsCreate(MTSDetailsDTO mtsDetailsDTO)
        {
            var createDetails = mtsDetailss.Create(mapper.Map<MTSDetails>(mtsDetailsDTO));
            return (int)createDetails.ID;
        }

        public void MTSDetailsCreateRange(List<MTSDetailsDTO> source)
        {
            mtsDetailss.CreateRange(mapper.Map<List<MTSDetailsDTO>, IEnumerable<MTSDetails>>(source));
        }

        public void MTSDetailsUpdate(MTSDetailsDTO mtsDetailsDTO)
        {
            var updateDetail = mtsDetailss.GetAll().SingleOrDefault(c => c.ID == mtsDetailsDTO.ID);
            mtsDetailss.Update((mapper.Map<MTSDetailsDTO, MTSDetails>(mtsDetailsDTO, updateDetail)));
        }

        #endregion

        #region MTSCreateDetals CRUD method's

        public int MTSCreateDetalsCreate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var createCreateDetails = mtsCreateDetals.Create(mapper.Map<MTSCreateDetals>(mtsCreateDetalsDTO));
            return (int)createCreateDetails.ID;
        }

        public void MTSCreateDetalsUpdate(MTSCreateDetalsDTO mtsCreateDetalsDTO)
        {
            var updateCreateDetail = mtsCreateDetals.GetAll().SingleOrDefault(c => c.ID == mtsCreateDetalsDTO.ID);
            mtsCreateDetals.Update((mapper.Map<MTSCreateDetalsDTO, MTSCreateDetals>(mtsCreateDetalsDTO, updateCreateDetail)));
        }

        public bool MTSCreateDetalDelete(int id)
        {
            try
            {
                mtsCreateDetals.Delete(mtsCreateDetals.GetAll().FirstOrDefault(c => c.ID == id));
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
