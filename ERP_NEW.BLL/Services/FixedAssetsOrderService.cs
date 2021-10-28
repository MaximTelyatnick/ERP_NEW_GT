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
using ERP_NEW.BLL.DTO.ReportsDTO;
using ERP_NEW.DAL.Entities.ReportModel;


namespace ERP_NEW.BLL.Services
{
    public class FixedAssetsOrderService : IFixedAssetsOrderService
    {
        private IUnitOfWork Database { get; set; }

        private IRepository<FixedAssetsOrder> fixedAssetsOrder;
        private IRepository<FixedAssetsOrderJournal> fixedAssetsOrderJournal;
        private IRepository<FixedAssetsOrderJournalPrint> fixedAssetsOrderJournalPrint;
        private IRepository<FixedAssetsGroup> fixedAssetsGroup;
        private IRepository<FixedAssetsMaterials> fixedAssetsMaterials;
        private IRepository<Region> region;
        private IRepository<NOMENCLATURES> nomenclatures;
        private IRepository<ACCOUNTS> account;
        private IRepository<EXPENDITURES_ACCOUNTANT> expedinturesAccount;
        private IRepository<RECEIPTS> receipts;
        private IRepository<ORDERS> order;
        private IRepository<Contractors> contractors;
        private IRepository<FixedAssetsOrderListMaterialsJournal> fixedAssetsOrderListMaterialsJournal;
        private IRepository<FixedAssetsOrderArchiveJournal> fixedAssetsOrderArchiveJournal;
        private IRepository<Invoice_Requirement_Materials> invoice_Requirement_Materials;
        private IRepository<FixedAssetsOrderMaterialsPrintJournal> fixedAssetsOrderMaterialsPrintJournal;
        private IRepository<FixedAssetsOrderRegistration> fixedAssetsOrderRegistration;
        private IRepository<FixedAssetsOrderRegJournal> fixedAssetsOrderRegistrationJournal;

        private IRepository<FixedAssetsOrderReportStrait> fixedAssetsReportStrait;
        private IRepository<FixedAssetsOrderByGroupShortReport> fixedAssetsOrderByGroupShort;
        private IRepository<FixedAssetsReportRegisterCh1> fixedAssetsReportRegisterCh1;
        private IRepository<FixedAssetsReportRegisterCh2> fixedAssetsReportRegisterCh2;
        private IRepository<InputFixedAssetsForGroup> getInputFixedAssetsForGroup;
        private IRepository<InputFixedAssetsForQuarter> getInputFixedForQuarter;

        private IRepository<Responsible> getResponsible;

        private IMapper mapper;


        public FixedAssetsOrderService(IUnitOfWork uow)
        {
            Database = uow;
            fixedAssetsOrder = Database.GetRepository<FixedAssetsOrder>();
            fixedAssetsOrderJournal = Database.GetRepository<FixedAssetsOrderJournal>();
            fixedAssetsGroup = Database.GetRepository<FixedAssetsGroup>();
            region = Database.GetRepository<Region>();
            fixedAssetsMaterials = Database.GetRepository<FixedAssetsMaterials>();
            nomenclatures = Database.GetRepository<NOMENCLATURES>();
            account = Database.GetRepository<ACCOUNTS>();
            expedinturesAccount = Database.GetRepository<EXPENDITURES_ACCOUNTANT>();
            receipts = Database.GetRepository<RECEIPTS>();
            order = Database.GetRepository<ORDERS>();
            contractors = Database.GetRepository<Contractors>();
            fixedAssetsOrderListMaterialsJournal = Database.GetRepository<FixedAssetsOrderListMaterialsJournal>();
            fixedAssetsOrderArchiveJournal = Database.GetRepository<FixedAssetsOrderArchiveJournal>();
            invoice_Requirement_Materials = Database.GetRepository<Invoice_Requirement_Materials>();
            fixedAssetsOrderJournalPrint = Database.GetRepository<FixedAssetsOrderJournalPrint>();
            fixedAssetsOrderMaterialsPrintJournal= Database.GetRepository<FixedAssetsOrderMaterialsPrintJournal>();
            fixedAssetsOrderRegistration = Database.GetRepository<FixedAssetsOrderRegistration>();
            fixedAssetsOrderRegistrationJournal = Database.GetRepository<FixedAssetsOrderRegJournal>();

            fixedAssetsReportStrait=Database.GetRepository<FixedAssetsOrderReportStrait>();
            fixedAssetsOrderByGroupShort = Database.GetRepository<FixedAssetsOrderByGroupShortReport>();
            fixedAssetsReportRegisterCh1 = Database.GetRepository<FixedAssetsReportRegisterCh1>();
            fixedAssetsReportRegisterCh2 = Database.GetRepository<FixedAssetsReportRegisterCh2>();
            getInputFixedAssetsForGroup = Database.GetRepository<InputFixedAssetsForGroup>();
            getInputFixedForQuarter = Database.GetRepository<InputFixedAssetsForQuarter>();

            getResponsible = Database.GetRepository<Responsible>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FixedAssetsOrder, FixedAssetsOrderDTO>();
                cfg.CreateMap<FixedAssetsOrderDTO, FixedAssetsOrder>();
                cfg.CreateMap<FixedAssetsGroup, FixedAssetsGroupDTO>();
                cfg.CreateMap<Region, RegionDTO>();
                cfg.CreateMap<FixedAssetsOrderJournal, FixedAssetsOrderJournalDTO>();
                cfg.CreateMap<FixedAssetsOrderJournalDTO, FixedAssetsOrderJournal>();
                cfg.CreateMap<FixedAssetsMaterialsDTO, FixedAssetsMaterials>();
                cfg.CreateMap<FixedAssetsMaterials, FixedAssetsMaterialsDTO>();
                cfg.CreateMap<FixedAssetsOrderListMaterialsJournal, FixedAssetsOrderListMaterialsJournalDTO>();
                cfg.CreateMap<FixedAssetsOrderArchiveJournal, FixedAssetsOrderArchiveJournalDTO>();
                cfg.CreateMap<FixedAssetsOrderArchiveJournalDTO, FixedAssetsOrderArchiveJournal>();
                cfg.CreateMap<FixedAssetsOrderJournalPrintDTO, FixedAssetsOrderJournalPrint>();
                cfg.CreateMap<FixedAssetsOrderJournalPrint, FixedAssetsOrderJournalPrintDTO>();
                cfg.CreateMap<FixedAssetsOrderMaterialsPrintJournal, FixedAssetsOrderMaterialsPrintJournalDTO>();
                cfg.CreateMap<FixedAssetsOrderRegistration, FixedAssetsOrderRegistrationDTO>();
                cfg.CreateMap<FixedAssetsOrderRegistrationDTO, FixedAssetsOrderRegistration>();
                cfg.CreateMap<FixedAssetsOrderRegJournal, FixedAssetsOrderRegJournalDTO>();
                cfg.CreateMap<FixedAssetsOrderRegJournalDTO, FixedAssetsOrderRegJournal>();
                cfg.CreateMap<FixedAssetsOrderReportStrait, FixedAssetsOrderReportStraitDTO>();
                cfg.CreateMap<FixedAssetsOrderReportStraitDTO, FixedAssetsOrderReportStrait>();
                cfg.CreateMap<FixedAssetsOrderByGroupShortReport, FixedAssetsOrderByGroupShortReportDTO>();
                cfg.CreateMap<FixedAssetsOrderByGroupShortReportDTO, FixedAssetsOrderByGroupShortReport>();
                cfg.CreateMap<FixedAssetsReportRegisterCh1, FixedAssetsReportRegisterCh1DTO>();
                cfg.CreateMap<FixedAssetsReportRegisterCh1DTO, FixedAssetsReportRegisterCh1>();
                cfg.CreateMap<FixedAssetsReportRegisterCh2, FixedAssetsReportRegisterCh2DTO>();
                cfg.CreateMap<FixedAssetsReportRegisterCh2DTO, FixedAssetsReportRegisterCh2>();
                cfg.CreateMap<InputFixedAssetsForGroup, InputFixedAssetsForGroupDTO>();
                cfg.CreateMap<InputFixedAssetsForGroupDTO, InputFixedAssetsForGroup>();
                cfg.CreateMap<InputFixedAssetsForQuarter, InputFixedAssetsForQuarterDTO>();
                cfg.CreateMap<InputFixedAssetsForQuarterDTO, InputFixedAssetsForQuarter>();

                cfg.CreateMap<Responsible, ResponsibleDTO>();
                cfg.CreateMap<ResponsibleDTO, Responsible>();
            });

            mapper = config.CreateMapper();
        }



        public IEnumerable<FixedAssetsOrderJournalDTO> GetFixedAssetsOrderJournal(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsOrderProc""(@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderJournal>, List<FixedAssetsOrderJournalDTO>>(fixedAssetsOrderJournal.SQLExecuteProc(procName, Parameters));
         }

        
        //????
        public IEnumerable<FixedAssetsOrderJournalPrintDTO> GetFixedAssetsOrderJournalPrint(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("ENDDATE", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsOrderPrintProc""(@ENDDATE)";
            return mapper.Map<IEnumerable<FixedAssetsOrderJournalPrint>, List<FixedAssetsOrderJournalPrintDTO>>(fixedAssetsOrderJournalPrint.SQLExecuteProc(procName, Parameters));
         }

        public IEnumerable<FixedAssetsOrderListMaterialsJournalDTO> GetExpendituresForFixedAssetsMaterials(DateTime startDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("StartDate", startDate),
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""ExpendituresForFixedAssetsProc""(@StartDate, @EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderListMaterialsJournal>, List<FixedAssetsOrderListMaterialsJournalDTO>>(fixedAssetsOrderListMaterialsJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<FixedAssetsOrderMaterialsPrintJournalDTO> GetFixedAssetsMateriaslForPrint(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsMateriaslForPrint""(@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderMaterialsPrintJournal>, List<FixedAssetsOrderMaterialsPrintJournalDTO>>(fixedAssetsOrderMaterialsPrintJournal.SQLExecuteProc(procName, Parameters));
        }
        
        public IEnumerable<FixedAssetsOrderArchiveJournalDTO> GetFixedAssetsOrderArchive(DateTime startDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDatePeriod", startDate),
                    new FbParameter("EndDatePeriod", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsOrderArchiveProc""(@BeginDatePeriod, @EndDatePeriod)";
            return mapper.Map<IEnumerable<FixedAssetsOrderArchiveJournal>, List<FixedAssetsOrderArchiveJournalDTO>>(fixedAssetsOrderArchiveJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<FixedAssetsOrderRegJournalDTO> GetFixedAssetsOrderRegistration(DateTime startDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("beginDate", startDate),
                    new FbParameter("endDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsOrderRegProc""(@beginDate, @endDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderRegJournal>, List<FixedAssetsOrderRegJournalDTO>>(fixedAssetsOrderRegistrationJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<FixedAssetsMaterialsDTO> GetFixedAssestMaterials(int fixedAssetsOrderId, DateTime endDate)
        {
            var rezult = (
                from fam in fixedAssetsMaterials.GetAll()

                join acc in account.GetAll() on fam.Fixed_Account_Id equals acc.ID into accc
                from acc in accc.DefaultIfEmpty()

                join exp in expedinturesAccount.GetAll() on fam.Expenditures_Id equals exp.ID into expp
                from exp in expp.DefaultIfEmpty()

                join acou in account.GetAll() on exp.CREDIT_ACCOUNT_ID equals acou.ID into accouu
                from acou in accouu.DefaultIfEmpty()

                join res in receipts.GetAll() on exp.RECEIPT_ID equals res.ID into ress
                from res in ress.DefaultIfEmpty()

                join nom in nomenclatures.GetAll() on res.NOMENCLATURE_ID equals nom.ID into nomm
                from nom in nomm.DefaultIfEmpty()

                join or in order.GetAll() on res.ORDER_ID equals or.ID into orr
                from or in orr.DefaultIfEmpty()

                join con in contractors.GetAll() on or.VENDOR_ID equals con.Id into conn
                from con in conn.DefaultIfEmpty()

                join ord in account.GetAll() on or.DEBIT_ACCOUNT_ID equals ord.ID into ordd
                from ord in ordd.DefaultIfEmpty()



                where fam.FixedAssetsOrder_Id == fixedAssetsOrderId &&
                ((exp.EXP_DATE == null) ? fam.MaterialsDate : exp.EXP_DATE) <= endDate

                // where (exp.QUANTITY > 0 || exp.QUANTITY < 0) 
                //where(fam.Expenditures_Id == null, 
                //)    
                //  orderby
                // fam.Flag
                // join acc in account.GetAll() in 

                select new FixedAssetsMaterialsDTO()
                  {
                      Id = fam.Id,
                      Expenditures_Id = fam.Expenditures_Id,
                      Fixed_Account_Id = fam.Fixed_Account_Id,
                      FixedAssetsOrder_Id = fam.FixedAssetsOrder_Id,
                      FixedPrice = fam.FixedPrice,
                      Flag = (
                        fam.Flag == 0 ? 0 :
                        fam.Flag == 1 ? 1 :
                        fam.Flag == 2 ? 2 :
                        fam.Flag == 3 ? 3 : -1),
                      MaterialsDate = fam.MaterialsDate,
                      SoldPrice = fam.SoldPrice,
                      Description = fam.Description,
                      Name = (fam.Expenditures_Id == null) ? fam.Description : nom.NAME,
                      ExpDate = (fam.Expenditures_Id == null) ? fam.MaterialsDate : exp.EXP_DATE,
                      FixedNum = acc.NUM,
                      Nomenclature = nom.NOMENCLATURE,
                      OrderDate = or.ORDER_DATE,
                      OrderNum = ord.NUM,
                      Price = exp.PRICE,
                      Quantity = exp.QUANTITY,
                      ReceiptNum = or.RECEIPT_NUM,
                      TotalPrice = res.TOTAL_PRICE,
                      UnitPrice = (res.QUANTITY != 0) ? (res.TOTAL_PRICE / res.QUANTITY) : res.TOTAL_PRICE,
                      ExpenNum = acou.NUM,
                      ReceiptId = res.ID,
                      NomenclatureId = res.NOMENCLATURE_ID,
                      VendorId = or.VENDOR_ID,
                      ContractorName = con.Name,
                      Srn = con.Srn,
                      DebitAccountId = or.DEBIT_ACCOUNT_ID,
                      FlagNote = (
                       fam.Flag == 0 ? "Основний засіб" :
                       fam.Flag == 1 ? "Збільшення вартості" :
                       fam.Flag == 2 ? "Корегуввання" :
                       fam.Flag == 3 ? "Корегування початкової вартості" : "---")


                  });

            return rezult.OrderBy(o => o.Flag).ToList();
        }

        public IEnumerable<FixedAssetsOrderDTO> GetFixedAssestsOrder()
        {
            return mapper.Map<IEnumerable<FixedAssetsOrder>, List<FixedAssetsOrderDTO>>(fixedAssetsOrder.GetAll());
        }

        public IEnumerable<FixedAssetsGroupDTO> GetFixedAssestGroup()
        {
            return mapper.Map<IEnumerable<FixedAssetsGroup>, List<FixedAssetsGroupDTO>>(fixedAssetsGroup.GetAll());
        }

        public IEnumerable<FixedAssetsMaterialsDTO> GetAllFixedAssetsMaterials()
        {
            return mapper.Map<IEnumerable<FixedAssetsMaterials>, List<FixedAssetsMaterialsDTO>>(fixedAssetsMaterials.GetAll());
        }

        public IEnumerable<RegionDTO> GetRegion()
        {
            return mapper.Map<IEnumerable<Region>, List<RegionDTO>>(region.GetAll());
        }
        public bool GetContainFixedAssetsMaterials(int idItem)
        {
            if (idItem != null && idItem != 0)
            {
                var list = fixedAssetsMaterials.GetAll().Where(c => c.Expenditures_Id == idItem);
                if (list.Count() > 0)
                    return true;
                else
                    return false;
            }
            else
                return false;

        }
        



        #region FixedAccestsOrder CRUD method's

        public int FixedAssetsOrderCreate(FixedAssetsOrderDTO fixedAssetsOrderDTO)
        {
            var createFixedAssetsOrder = fixedAssetsOrder.Create(mapper.Map<FixedAssetsOrder>(fixedAssetsOrderDTO));
            return (int)createFixedAssetsOrder.Id;
        }
        public void FixedAssetsOrderUpdate(FixedAssetsOrderDTO fixedAssetsOrderDTO)
        {
            var updateFixedAssetsOrder = fixedAssetsOrder.GetAll().SingleOrDefault(c => c.Id == fixedAssetsOrderDTO.Id);
            fixedAssetsOrder.Update((mapper.Map<FixedAssetsOrderDTO, FixedAssetsOrder>(fixedAssetsOrderDTO, updateFixedAssetsOrder)));
        }
        public bool FixedAssetsOrderDelete(int id)
        {
            try
            {
                fixedAssetsOrder.Delete(fixedAssetsOrder.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region FixedAccestsOrderMaterials CRUD method's

        public int FixedAssetsOrderMaterialsCreate(FixedAssetsMaterialsDTO fixedAssetsMaterialsDTO)
        {
            var createFixedAssetsOrderMaterials = fixedAssetsMaterials.Create(mapper.Map<FixedAssetsMaterials>(fixedAssetsMaterialsDTO));
            return (int)createFixedAssetsOrderMaterials.Id;
        }

        public void FixedAssetsOrderMaterialsUpdate(FixedAssetsMaterialsDTO fixedAssetsMaterialsDTO)
        {
            var updateFixedAssetsOrderMaterials = fixedAssetsMaterials.GetAll().SingleOrDefault(c => c.Id == fixedAssetsMaterialsDTO.Id);
            fixedAssetsMaterials.Update((mapper.Map<FixedAssetsMaterialsDTO, FixedAssetsMaterials>(fixedAssetsMaterialsDTO, updateFixedAssetsOrderMaterials)));
        }

        public bool FixedAssetsOrderMaterialsDelete(int id)
        {
            try
            {
                fixedAssetsMaterials.Delete(fixedAssetsMaterials.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //
        public int FixedAssetsOrderRegistrationCreate(FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistrationDTO)
        {
            var createFixedAssetsOrderRegistration = fixedAssetsOrderRegistration.Create(mapper.Map<FixedAssetsOrderRegistration>(fixedAssetsOrderRegistrationDTO));
            return (int)createFixedAssetsOrderRegistration.Id;
        }

        public void FixedAssetsOrderRegistrationUpdate(FixedAssetsOrderRegistrationDTO fixedAssetsOrderRegistrationDTO)
        {
            var updateFixedAssetsOrderRegistration = fixedAssetsOrderRegistration.GetAll().SingleOrDefault(c => c.Id == fixedAssetsOrderRegistrationDTO.Id);
            fixedAssetsOrderRegistration.Update((mapper.Map<FixedAssetsOrderRegistrationDTO, FixedAssetsOrderRegistration>(fixedAssetsOrderRegistrationDTO,updateFixedAssetsOrderRegistration )));
        }

        public bool FixedAssetsOrderRegistrationDelete(int id)
        {
            try
            {
                fixedAssetsOrderRegistration.Delete(fixedAssetsOrderRegistration.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
        #region FixedAssetsOrderReport

        public IEnumerable<FixedAssetsOrderReportStraitDTO> GetFixedAssetsReportStrait(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsReportStraitProc""(@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderReportStrait>, List<FixedAssetsOrderReportStraitDTO>>(fixedAssetsReportStrait.SQLExecuteProc(procName, Parameters).Where(a => a.CurrentPrice+a.CurrentAmortization>0)
                .OrderBy(a=>a.GroupName));
        }

        public IEnumerable<FixedAssetsOrderReportStraitDTO> GetInventoryFixedAssetsForGroups(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsReportStraitProc""(@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderReportStrait>, List<FixedAssetsOrderReportStraitDTO>>(fixedAssetsReportStrait.SQLExecuteProc(procName, Parameters))
                .OrderBy(a=>a.GroupId);
        }

        public IEnumerable<ResponsibleDTO> GetResponsible()
        {
            string procName = @"select * from ""RESPONSIBLE""";
            return mapper.Map<IEnumerable<Responsible>, List<ResponsibleDTO>>(getResponsible.SQLExecuteProc(procName));

                
        }

        public IEnumerable<FixedAssetsOrderReportStraitDTO> GetFixedAssetsOrderByGroupAmortization(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsReportStraitProc""(@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderReportStrait>, List<FixedAssetsOrderReportStraitDTO>>(fixedAssetsReportStrait.SQLExecuteProc(procName, Parameters)
                .Where(a => a.CurrentPrice <= 0 && a.CurrentAmortization <= 0)
                .OrderBy(a => a.GroupName));
        }
        
        public IEnumerable<FixedAssetsOrderByGroupShortReportDTO> GetFixedAssetsByGroupShort(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetFixedAssetsByGroupShort""(@BeginDate,@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsOrderByGroupShortReport>, List<FixedAssetsOrderByGroupShortReportDTO>>(fixedAssetsOrderByGroupShort.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<FixedAssetsReportRegisterCh1DTO> GetFixedAssetsReportRegisterCh1(DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""FixedAssetsReportRegisterCh1""(@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsReportRegisterCh1>, List<FixedAssetsReportRegisterCh1DTO>>(fixedAssetsReportRegisterCh1.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<FixedAssetsReportRegisterCh2DTO> GetFixedAssetsReportRegisterCh2(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""FixedAssetsReportRegisterCh2""(@BeginDate,@EndDate)";
            return mapper.Map<IEnumerable<FixedAssetsReportRegisterCh2>, List<FixedAssetsReportRegisterCh2DTO>>(fixedAssetsReportRegisterCh2.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<InputFixedAssetsForGroupDTO> GetInputFixedAssetsForGroup(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("StartDateFYear", beginDate),
                    new FbParameter("StartDateLYear", endDate)
                };
            string procName = @"select * from ""GetInputFixedAssetsForGroup""(@StartDateFYear,@StartDateLYear)";
            return mapper.Map<IEnumerable<InputFixedAssetsForGroup>, List<InputFixedAssetsForGroupDTO>>(getInputFixedAssetsForGroup.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<InputFixedAssetsForQuarterDTO> GetInputFixedForQuarter(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetInputFixedAssetsForQuarter""(@BeginDate,@EndDate)";
            return mapper.Map<IEnumerable<InputFixedAssetsForQuarter>, List<InputFixedAssetsForQuarterDTO>>(getInputFixedForQuarter.SQLExecuteProc(procName, Parameters));
        }
        
        
        #endregion



        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
