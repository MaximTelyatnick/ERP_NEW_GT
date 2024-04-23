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
    public class BusinessTripsService : IBusinessTripsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<BusinessTrips> businessTrips;
        private IRepository<BusinessTripsJournal> businessTripsJournal;
        private IRepository<BusinessTripsPurpose> businessTripsPurpose;
        private IRepository<BusinessTripsDetails> businessTripsDetails;
        private IRepository<BusinessTripsDecree> businessTripsDecree;
        private IRepository<BusinessTripsDecreeDetails> businessTripsDecreeDetails;
        private IRepository<BusinessTripsOrderCust> businessTripsOrderCust;
        private IRepository<BusinessTripsPrepaymentJournal> businessTripsPrepaymentJournal;
        private IRepository<BusinessTripsPrepayment> businessTripsPrepayment;
        private IRepository<BusinessTripsPayment> businessTripsPayment;
        private IRepository<ACCOUNTS> accounts;
        private IRepository<BusinessTripsReport> businessTripsReport;
        private IRepository<BusinessTripsPaymentVat> businessTripsPaymentVat;
        private IRepository<Currency_Rates> currencyRates;
        private IRepository<Currency> currency;
        private IRepository<CashPayments> cashPayments;
        private IRepository<CashPrepayments> cashPrepayments;
        private IRepository<CashPrepaymentsInfo> cashPrepaymentsInfo;
        private IRepository<CashPaymentsInfo> cashPaymentsInfo;
        private IRepository<Contractors> contractors;
        private IRepository<RECEIPTS> receipts;
        private IRepository<NOMENCLATURES> nomenclatures;
        private IRepository<Units> units;
        private IRepository<VAT> vat;
        private IRepository<ORDERS> orders;
        private IRepository<SUPPLIERS> suppliers;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<Employees> employees;
        private IRepository<EmployeesDetails> employeesDetails;
        private IRepository<Colors> colors;
        
        private IMapper mapper;

        public BusinessTripsService(IUnitOfWork uow)
        {
            Database = uow;
            businessTrips = Database.GetRepository<BusinessTrips>();
            businessTripsJournal = Database.GetRepository<BusinessTripsJournal>();
            businessTripsPurpose = Database.GetRepository<BusinessTripsPurpose>();
            businessTripsDetails = Database.GetRepository<BusinessTripsDetails>();
            businessTripsDecree = Database.GetRepository<BusinessTripsDecree>();
            businessTripsDecreeDetails = Database.GetRepository<BusinessTripsDecreeDetails>();
            businessTripsOrderCust = Database.GetRepository<BusinessTripsOrderCust>();
            businessTripsPrepaymentJournal = Database.GetRepository<BusinessTripsPrepaymentJournal>();
            businessTripsPrepayment = Database.GetRepository<BusinessTripsPrepayment>();
            businessTripsPayment = Database.GetRepository<BusinessTripsPayment>();
            businessTripsReport = Database.GetRepository<BusinessTripsReport>();
            businessTripsPaymentVat = Database.GetRepository<BusinessTripsPaymentVat>();
            accounts = Database.GetRepository<ACCOUNTS>();
            currencyRates = Database.GetRepository<Currency_Rates>();
            currency = Database.GetRepository<Currency>();
            cashPayments = Database.GetRepository<CashPayments>();
            cashPrepayments = Database.GetRepository<CashPrepayments>();
            cashPrepaymentsInfo = Database.GetRepository<CashPrepaymentsInfo>();
            cashPaymentsInfo = Database.GetRepository<CashPaymentsInfo>();
            contractors = Database.GetRepository<Contractors>();
            receipts = Database.GetRepository<RECEIPTS>();
            nomenclatures = Database.GetRepository<NOMENCLATURES>();
            units = Database.GetRepository<Units>();
            vat = Database.GetRepository<VAT>();
            orders = Database.GetRepository<ORDERS>();
            suppliers = Database.GetRepository<SUPPLIERS>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            employees = Database.GetRepository<Employees>();
            employeesDetails = Database.GetRepository<EmployeesDetails>();
            colors = Database.GetRepository<Colors>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BusinessTrips, BusinessTripsDTO>();
                cfg.CreateMap<BusinessTripsDTO, BusinessTrips>();
                cfg.CreateMap<BusinessTripsJournal, BusinessTripsJournalDTO>();
                cfg.CreateMap<BusinessTripsPurpose, BusinessTripsPurposeDTO>();
                cfg.CreateMap<BusinessTripsPurposeDTO, BusinessTripsPurpose>();
                cfg.CreateMap<BusinessTripsDetails, BusinessTripsDetailsDTO>();
                cfg.CreateMap<BusinessTripsDetailsDTO, BusinessTripsDetails>();
                cfg.CreateMap<BusinessTripsOrderCustDTO, BusinessTripsOrderCust>();
                cfg.CreateMap<BusinessTripsDecree, BusinessTripsDecreeDTO>();
                cfg.CreateMap<BusinessTripsDecreeDTO, BusinessTripsDecree>();
                cfg.CreateMap<BusinessTripsDecreeDetails, BusinessTripsDecreeDetailsDTO>();
                cfg.CreateMap<BusinessTripsDecreeDetailsDTO, BusinessTripsDecreeDetails>();
                cfg.CreateMap<BusinessTripsPrepaymentJournal, BusinessTripsPrepaymentJournalDTO>();
                cfg.CreateMap<BusinessTripsPrepayment, BusinessTripsPrepaymentDTO>();
                cfg.CreateMap<BusinessTripsPrepaymentDTO, BusinessTripsPrepayment>();
                cfg.CreateMap<BusinessTripsPayment, BusinessTripsPaymentDTO>();
                cfg.CreateMap<BusinessTripsPaymentDTO, BusinessTripsPayment>();
                cfg.CreateMap<BusinessTripsReport, BusinessTripsReportDTO>();
                cfg.CreateMap<BusinessTripsReportDTO, BusinessTripsReport>();
                cfg.CreateMap<BusinessTripsPaymentVat, BusinessTripsPaymentVatDTO>();
                cfg.CreateMap<BusinessTripsPaymentVatDTO, BusinessTripsPaymentVat>();
                cfg.CreateMap<CashPayments, CashPaymentsDTO>();
                cfg.CreateMap<CashPaymentsDTO, CashPayments>();
                cfg.CreateMap<CashPrepayments, CashPrepaymentsDTO>();
                cfg.CreateMap<CashPrepaymentsDTO, CashPrepayments>();
                cfg.CreateMap<CashPrepaymentsInfo, CashPrepaymentsInfoDTO>();
                cfg.CreateMap<CashPaymentsInfo, CashPaymentsInfoDTO>();
                cfg.CreateMap<Colors, ColorsDTO>();
                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
            });

            mapper = config.CreateMapper();
        }

        #region Get method's


        public IEnumerable<ColorsDTO> GetColors()
        {
            return mapper.Map<IEnumerable<Colors>, List<ColorsDTO>>(colors.GetAll());
        }

        public IEnumerable<BusinessTripsDTO> GetBusinessTrips()
        {
            return mapper.Map<IEnumerable<BusinessTrips>, List<BusinessTripsDTO>>(businessTrips.GetAll());
        }

        public IEnumerable<BusinessTripsDTO> GetBusinessTripsForEmployee(int employeeId)
        {
            var result = (from bd in businessTripsDetails.GetAll()
                          join bt in businessTrips.GetAll() on bd.BusinessTripsID equals bt.ID
                          where bd.EmployeesID == employeeId
                          select new BusinessTripsDTO()
                          {
                              ID = bd.BusinessTripsID,
                              StartDate = bt.StartDate,
                              EndDate = bt.EndDate
                          }).ToList();
            return result;
        }

        public IEnumerable<BusinessTripsReportDTO> GetBusinessTripsReports()
        {
            return mapper.Map<IEnumerable<BusinessTripsReport>, List<BusinessTripsReportDTO>>(businessTripsReport.GetAll().OrderBy(o => o.Name.ToLower()));
        }

        public BusinessTripsDTO GetBusinessTripsByDetailId(int id)
        {
            var result = (from c in businessTripsDetails.GetAll()
                          join co in businessTrips.GetAll() on c.BusinessTripsID equals co.ID
                          select new BusinessTripsDTO()
                          {
                              ID = c.BusinessTripsID,
                              Doc_Number = co.Doc_Number,
                              Doc_Date = co.Doc_Date,
                              DepartureID = co.DepartureID,
                              ContractorsID = co.ContractorsID,
                              AgreementsID = co.AgreementsID,
                              CityID = co.CityID,
                              PurposeID = co.PurposeID,
                              StartDate = co.StartDate,
                              EndDate = co.EndDate,
                              AmountDays = co.AmountDays,
                              UserId = co.UserId,
                              BusinessTripDetailId = c.ID,
                              EmployeesID = c.EmployeesID
                          }).Where(c => c.BusinessTripDetailId == id);
            return result.SingleOrDefault();
        }

        public IEnumerable<BusinessTripsDecreeDTO> GetBusinessTripsDecrees()
        {
            return mapper.Map<IEnumerable<BusinessTripsDecree>, List<BusinessTripsDecreeDTO>>(businessTripsDecree.GetAll());
        }

        public IEnumerable<BusinessTripsPurposeDTO> GetBusinessTripsPurpose()
        {
            return mapper.Map<IEnumerable<BusinessTripsPurpose>, List<BusinessTripsPurposeDTO>>(businessTripsPurpose.GetAll());
        }

        public IEnumerable<BusinessTripsJournalDTO> GetBusinessTripsJournal(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDateIn", beginDate),
                    new FbParameter("EndDateIn", endDate)
                };

            string procName = @"select * from ""GetBusinessTripsJournal""(@BeginDateIn, @EndDateIn)";

            return mapper.Map<IEnumerable<BusinessTripsJournal>, List<BusinessTripsJournalDTO>>(businessTripsJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<BusinessTripsDecreeDTO> GetBusinessTripsDecreeByPeriod(DateTime beginDate, DateTime endDate)
        {
            var query = (from d in businessTripsDecree.GetAll()
                         where (d.DecreeDate >= beginDate && d.DecreeDate <= endDate)
                         select new BusinessTripsDecreeDTO()
                         {
                             ID = d.ID,
                             ParentId = d.ParentId,
                             Number = d.Number,
                             DecreeDate = d.DecreeDate,
                             DecreeType = d.DecreeType
                         }).ToList();

            return query.OrderBy(o => o.DecreeDate).ThenBy(o => Decimal.Parse(o.Number.Replace('/', ','))).ToList();
        }
        //public IEnumerable<BusinessTripsDecreeDTO> GetBusinessTrips()
        //{
        //    return mapper.Map<IEnumerable<BusinessTripsDecree>, List<BusinessTripsDecreeDTO>>(businessTripsDecree.GetAll());
        //}
        public IEnumerable<BusinessTripsJournalDTO> GetBusinessTripsByDecree(int decreeId)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("DecreeIdIn", decreeId)
                };

            string procName = @"select * from ""GetBusinessTripsByDecree""(@DecreeIdIn)";

            return mapper.Map<IEnumerable<BusinessTripsJournal>, List<BusinessTripsJournalDTO>>(businessTripsJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<BusinessTripsJournalDTO> GetBusinessTripsWithoutDecree()
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDateIn", DateTime.MinValue),
                    new FbParameter("EndDateIn", DateTime.MaxValue)
                };

            string procName = @"select * from ""GetBusinessTripsJournal""(@BeginDateIn, @EndDateIn)";

            return mapper.Map<IEnumerable<BusinessTripsJournal>, List<BusinessTripsJournalDTO>>(businessTripsJournal.SQLExecuteProc(procName, Parameters).Where(b => b.DecreeId == null));
        }

        public IEnumerable<BusinessTripsPrepaymentJournalDTO> GetBusinessTripsPrepaymentJournalByPeriod(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("StartTripDate", beginDate),
                    new FbParameter("EndTripDate", endDate)
                };

            string procName = @"select * from ""GetBSTPrepaymentJournalByPeriod""(@StartTripDate, @EndTripDate)";

            return mapper.Map<IEnumerable<BusinessTripsPrepaymentJournal>, List<BusinessTripsPrepaymentJournalDTO>>(businessTripsPrepaymentJournal.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<BusinessTripsPrepaymentDTO> GetBusinessTripsPrepaymentList(int btdId)
        {
            var result = (from p in businessTripsPrepayment.GetAll()
                          join a in accounts.GetAll() on p.AccountsID equals a.ID into pa
                          from a in pa.DefaultIfEmpty()
                          where p.BusinessTripsDetailsID == btdId
                          select new BusinessTripsPrepaymentDTO()
                          {
                              ID = p.ID,
                              BusinessTripsDetailsID = p.BusinessTripsDetailsID,
                              Doc_Date = p.Doc_Date,
                              EmployeesID = p.EmployeesID,
                              AccountsID = p.AccountsID,
                              Prepayment = p.Prepayment,
                              Prepayment_Date = p.Prepayment_Date,
                              UserId = p.UserId,
                              AccountsNum = a.NUM,
                              Selected = false,
                              Check = p.Check
                          }).ToList();

            return result;
        }

        public IEnumerable<BusinessTripsPaymentDTO> GetBusinessTripsPaymentList(int btdId)
        {
            var result = (from p in businessTripsPayment.GetAll()
                          join a in accounts.GetAll() on p.AccountsID equals a.ID into pa
                          from a in pa.DefaultIfEmpty()
                          join r in businessTripsReport.GetAll() on p.BusinessTripsReportID equals r.ID into pr
                          from r in pr.DefaultIfEmpty()
                          join v in businessTripsPaymentVat.GetAll() on p.BusinessTripsPaymentVatID equals v.VatID into pv
                          from v in pv.DefaultIfEmpty()
                          join va in accounts.GetAll() on v.VatAccountID equals va.ID into vva
                          from va in vva.DefaultIfEmpty()
                          join cr in currencyRates.GetAll() on p.CurrencyRatesID equals cr.Id into pcr
                          from cr in pcr.DefaultIfEmpty()
                          join c in currency.GetAll() on cr.Currency_Id equals c.Id into crc
                          from c in crc.DefaultIfEmpty()
                          where p.BusinessTripsDetailsID == btdId
                          select new BusinessTripsPaymentDTO()
                          {
                              ID = p.ID,
                              BusinessTripsDetailsID = p.BusinessTripsDetailsID,
                              BusinessTripsReportID = p.BusinessTripsReportID,
                              BusinessTripsPaymentVatID = p.BusinessTripsPaymentVatID,
                              CurrencyRatesID = p.CurrencyRatesID,
                              Comment = p.Comment,
                              Payment = p.Payment,
                              Payment_Date = p.Payment_Date,
                              ReportName = r.Name,
                              CurrencyId = (p.CurrencyRatesID != null) ? cr.Currency_Id : 1,
                              CurrencyDate = cr.Date,
                              CurrencyPayment = cr.CurrencyPayment,
                              CurrencyRate = cr.Rate,
                              CurrencyName = (p.CurrencyRatesID != null) ? c.Code : "UAH",
                              VatAccountId = v.VatAccountID,
                              VatPayment = v.VatPayment,
                              VatAccountNum = va.NUM,
                              Doc_Date = p.Doc_Date,
                              EmployeesID = p.EmployeesID,
                              AccountsID = p.AccountsID,
                              AccountNum = a.NUM,
                              UserId = p.UserId,
                              Selected = false
                          }).ToList();

            return result;
        }
        
        public IEnumerable<BusinessTripsPaymentVatDTO> GetBusinessTripsPaymentVat()
        {
            return mapper.Map<IEnumerable<BusinessTripsPaymentVat>, List<BusinessTripsPaymentVatDTO>>(businessTripsPaymentVat.GetAll());
        }

        public IEnumerable<CashPrepaymentsInfoDTO> GetCashPrepaymentsByPeriod(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetCashPrepaymentsByPeriod""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<CashPrepaymentsInfo>, List<CashPrepaymentsInfoDTO>>(cashPrepaymentsInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<CashPaymentsInfoDTO> GetCashPaymentsById(int id)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("PrepaymentId", id)
                };

            string procName = @"select * from ""GetCashPaymentsById""(@PrepaymentId)";

            return mapper.Map<IEnumerable<CashPaymentsInfo>, List<CashPaymentsInfoDTO>>(cashPaymentsInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<CashPaymentsInfoDTO> GetReceiptsForCashPayment(DateTime firstDateEdit, DateTime lastDateEdit)
        {
            var receiptList = (from r in receipts.GetAll()
                          join o in orders.GetAll() on r.ORDER_ID equals o.ID
                          join v in vat.GetAll() on o.ID equals v.ID into ov
                          from v in ov.DefaultIfEmpty()
                          join s in suppliers.GetAll() on (Int32)o.SUPPLIER_ID equals s.ID into os
                          from s in os.DefaultIfEmpty()
                          join n in nomenclatures.GetAll() on r.NOMENCLATURE_ID equals n.ID
                          join a in accounts.GetAll() on n.BALANCE_ACCOUNT_ID equals a.ID
                          join u in units.GetAll() on n.UnitId equals u.UnitId into nu
                          from u in nu.DefaultIfEmpty()
                          where o.DEBIT_ACCOUNT_ID == 14 && (o.ORDER_DATE >= firstDateEdit && o.ORDER_DATE <= lastDateEdit)
                          select new CashPaymentsInfoDTO()
                          {
                              Id = 0,
                              ReceiptId = r.ID,
                              ReceiptNum = o.RECEIPT_NUM,
                              OrderDate = o.ORDER_DATE,
                              Quantity = r.QUANTITY,
                              TotalPrice = r.TOTAL_PRICE,
                              CashPrepaymentId = 0,
                              NomenclatureNumber = n.NOMENCLATURE,
                              NomenclatureName = n.NAME,
                              UnitLocalName = u.UnitLocalName,
                              BalanceAccountNum = a.NUM,
                              DateAdded = DateTime.Now,
                              UserId = 0,
                                
                              VatAccountId = null,
                              VatPrice = ((v.PRICE ?? 0) == 0) ? 0 : Math.Round(r.TOTAL_PRICE * 0.2m, 2),
                              SupplierName = s.NAME,
                              Selected = false
                          }).ToList();

            var cashPaymentList = mapper.Map<IEnumerable<CashPayments>, List<CashPaymentsDTO>>(cashPayments.GetAll());

            var result = receiptList.Where(r => !cashPaymentList.Any(cp => cp.ReceiptId == r.ReceiptId)).ToList();

            return result;
        }

        public BusinessTripsDTO GetBusinessTripsId(int id)
        {
            return mapper.Map<BusinessTrips, BusinessTripsDTO>(businessTrips.GetAll().SingleOrDefault(s => s.ID == id));
        }

        public BusinessTripsPrepaymentDTO GetBusinessTripsPrepaymentGetId(int id)
        {
            return mapper.Map<BusinessTripsPrepayment, BusinessTripsPrepaymentDTO>(businessTripsPrepayment.GetAll().SingleOrDefault(s => s.ID == id));
        }

        public BusinessTripsDetailsDTO GetBusinessTripsDetailsId(int id)
        {
            return mapper.Map<BusinessTripsDetails, BusinessTripsDetailsDTO>(businessTripsDetails.GetAll().SingleOrDefault(s => s.BusinessTripsID == id));
        }

        public BusinessTripsPurposeDTO GetBusinessTripsPurposeId(int id)
        {
            return mapper.Map<BusinessTripsPurpose, BusinessTripsPurposeDTO>(businessTripsPurpose.GetAll().SingleOrDefault(s => s.PurposeID == id));
        }

        public BusinessTripsDetailsDTO GetBusinessTripsDetailById(int id)
        {
            return mapper.Map<BusinessTripsDetails, BusinessTripsDetailsDTO>(businessTripsDetails.GetAll().SingleOrDefault(s => s.ID == id));
        }

        public IEnumerable<BusinessTripsOrderCustDTO> GetBusinessOrderCustByBTId(int id)
        {
            var receiptList = (from co in customerOrders.GetAll()
                               join ct in contractors.GetAll() on co.ContractorId equals ct.Id into ctt
                               from ct in ctt.DefaultIfEmpty()
                               join btoc in businessTripsOrderCust.GetAll() on co.Id equals btoc.CustomerOrderId into nu
                               from btoc in nu.DefaultIfEmpty()
                               join bt in businessTrips.GetAll() on btoc.BusinessTripsId equals bt.ID into so
                               from bt in so.DefaultIfEmpty()
                               where bt.ID == id
                               select new BusinessTripsOrderCustDTO()
                               {
                                   ID = btoc.ID,
                                   BusinessTripsId = btoc.BusinessTripsId,
                                   CustomerOrderId = btoc.CustomerOrderId,
                                   OrderDate = co.OrderDate,
                                   OrderNumber = co.OrderNumber,
                                   ContractorName = ct.Name,
                                   UserId = btoc.UserId

                               }).ToList();

            return receiptList;
        }

        public string GetLatestDocNumber()
        {
            var businessTripsDto = GetBusinessTrips().OrderByDescending(x => Decimal.Parse(x.Doc_Number.Replace('/', ','))).FirstOrDefault(x => x.Doc_Date.Year == DateTime.Today.Year); //DateTime.Today.Year);

            if (businessTripsDto != null)
            {
                decimal last = Decimal.Parse(businessTripsDto.Doc_Number.Replace('/', ','));
                return ((Math.Truncate(last) + 1).ToString());
            }
            else
            {
                return "1";
            }
        }

        public string GetLatestDecreeNumber()
        {
            var businessTripsDecreeDto = GetBusinessTripsDecrees().OrderByDescending(x => Decimal.Parse(x.Number.Replace('/', ','))).FirstOrDefault(x => x.DecreeDate.Year == DateTime.Today.Year); //DateTime.Today.Year);

            if (businessTripsDecreeDto != null)
            {
                decimal last = Decimal.Parse(businessTripsDecreeDto.Number.Replace('/', ','));
                return ((Math.Truncate(last) + 1).ToString());
            }
            else
            {
                return "1";
            }
        }

        #endregion

        #region BusinessTripsPurpose CRUD method's

        public int BusinessTripsPurposeCreate(BusinessTripsPurposeDTO btDTO)
        {
            var createBusinessTripsPurpose = businessTripsPurpose.Create(mapper.Map<BusinessTripsPurpose>(btDTO));
            return (int)createBusinessTripsPurpose.PurposeID;
        }

        public void BusinessTripsPurposeUpdate(BusinessTripsPurposeDTO btDTO)
        {
            var updateBusinessTripsPurpose = businessTripsPurpose.GetAll().SingleOrDefault(c => c.PurposeID == btDTO.PurposeID);
            businessTripsPurpose.Update((mapper.Map<BusinessTripsPurposeDTO, BusinessTripsPurpose>(btDTO, updateBusinessTripsPurpose)));
        }

        public bool BusinessTripsPurposeDelete(int id)
        {
            try
            {
                businessTripsPurpose.Delete(businessTripsPurpose.GetAll().FirstOrDefault(c => c.PurposeID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTrips CRUD method's

        public int BusinessTripCreate(BusinessTripsDTO btDTO)
        {
            var createBT = businessTrips.Create(mapper.Map<BusinessTrips>(btDTO));
            return (int)createBT.ID;
        }

        public void BusinessTripUpdate(BusinessTripsDTO btDTO)
        {
            var updateBT = businessTrips.GetAll().SingleOrDefault(c => c.ID == btDTO.ID);
            businessTrips.Update((mapper.Map<BusinessTripsDTO, BusinessTrips>(btDTO, updateBT)));
        }

        public bool BusinessTripDelete(int id)
        {
            try
            {
                businessTrips.Delete(businessTrips.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsDecree CRUD method's

        public int BusinessTripDecreeCreate(BusinessTripsDecreeDTO btdDTO)
        {
            var createBTD = businessTripsDecree.Create(mapper.Map<BusinessTripsDecree>(btdDTO));
            return (int)createBTD.ID;
        }

        public void BusinessTripDecreeUpdate(BusinessTripsDecreeDTO btdDTO)
        {
            var updateBTD = businessTripsDecree.GetAll().SingleOrDefault(c => c.ID == btdDTO.ID);
            businessTripsDecree.Update((mapper.Map<BusinessTripsDecreeDTO, BusinessTripsDecree>(btdDTO, updateBTD)));
        }

        public bool BusinessTripDecreeDelete(int id)
        {
            try
            {
                businessTripsDecree.Delete(businessTripsDecree.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsDecreeDetail CRUD method's

        public int BusinessTripDecreeDetailCreate(BusinessTripsDecreeDetailsDTO btddDTO)
        {
            var createBTDD = businessTripsDecreeDetails.Create(mapper.Map<BusinessTripsDecreeDetails>(btddDTO));
            return (int)createBTDD.Id;
        }

        public void BusinessTripDecreeDetailCreateRange(List<BusinessTripsDecreeDetailsDTO> source)
        {
            businessTripsDecreeDetails.CreateRange(mapper.Map<List<BusinessTripsDecreeDetailsDTO>, IEnumerable<BusinessTripsDecreeDetails>>(source));
        }

        public void BusinessTripDecreeDetailUpdate(BusinessTripsDecreeDetailsDTO btddDTO)
        {
            var updateBTDD = businessTripsDecreeDetails.GetAll().SingleOrDefault(c => c.Id == btddDTO.Id);
            businessTripsDecreeDetails.Update((mapper.Map<BusinessTripsDecreeDetailsDTO, BusinessTripsDecreeDetails>(btddDTO, updateBTDD)));
        }

        public bool BusinessTripDecreeDetailRemoveRange(List<BusinessTripsDecreeDetailsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = businessTripsDecreeDetails.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    businessTripsDecreeDetails.Delete(deleteModel);
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsDetail CRUD method's

        public int BusinessTripsDetailsCreate(BusinessTripsDetailsDTO btDTO)
        {
            var createBusinessTripsDetails = businessTripsDetails.Create(mapper.Map<BusinessTripsDetails>(btDTO));
            return (int)createBusinessTripsDetails.ID;
        }

        public void BusinessTripsDetailsUpdate(BusinessTripsDetailsDTO btDTO)
        {
            var updateBusinessTripsDetails = businessTripsDetails.GetAll().SingleOrDefault(c => c.ID == btDTO.ID);
            businessTripsDetails.Update((mapper.Map<BusinessTripsDetailsDTO, BusinessTripsDetails>(btDTO, updateBusinessTripsDetails)));
        }

        public bool BusinessTripsDetailsDelete(int id)
        {
            try
            {
                businessTripsDetails.Delete(businessTripsDetails.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsPrepayment CRUD method's

        public int BusinessTripsPrepaymentCreate(BusinessTripsPrepaymentDTO btDTO)
        {
            var createBusinessTripsPrepayment = businessTripsPrepayment.Create(mapper.Map<BusinessTripsPrepayment>(btDTO));

            return (int)createBusinessTripsPrepayment.ID;
        }


        public void BusinessTripsPrepaymentCreateRange(List<BusinessTripsPrepaymentDTO> source)
        {
            businessTripsPrepayment.CreateRange(mapper.Map<List<BusinessTripsPrepaymentDTO>, IEnumerable<BusinessTripsPrepayment>>(source));
        }

        public void BusinessTripsPrepaymentUpdate(BusinessTripsPrepaymentDTO btDTO)
        {
            var updateBusinessTripsPrepayment = businessTripsPrepayment.GetAll().SingleOrDefault(c => c.ID == btDTO.ID);
            businessTripsPrepayment.Update((mapper.Map<BusinessTripsPrepaymentDTO, BusinessTripsPrepayment>(btDTO, updateBusinessTripsPrepayment)));
        }

        public bool BusinessTripsPrepaymentDelete(int id)
        {
            try
            {
                businessTripsPrepayment.Delete(businessTripsPrepayment.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BusinessTripPrepaymentRemoveRange(List<BusinessTripsPrepaymentDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = businessTripsPrepayment.GetAll().SingleOrDefault(p => p.ID == item.ID);
                    businessTripsPrepayment.Delete(deleteModel);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsPayment CRUD method's

        public int BusinessTripsPaymentCreate(BusinessTripsPaymentDTO btDTO)
        {
            var createBusinessTripsPayment = businessTripsPayment.Create(mapper.Map<BusinessTripsPayment>(btDTO));

            return (int)createBusinessTripsPayment.ID;
        }

        public void BusinessTripsPaymentCreateRange(List<BusinessTripsPaymentDTO> source)
        {
            businessTripsPayment.CreateRange(mapper.Map<List<BusinessTripsPaymentDTO>, IEnumerable<BusinessTripsPayment>>(source));
        }

        public void BusinessTripsPaymentUpdate(BusinessTripsPaymentDTO btDTO)
        {
            var updateBusinessTripsPayment = businessTripsPayment.GetAll().SingleOrDefault(c => c.ID == btDTO.ID);
            businessTripsPayment.Update((mapper.Map<BusinessTripsPaymentDTO, BusinessTripsPayment>(btDTO, updateBusinessTripsPayment)));
        }

        public bool BusinessTripsPaymentDelete(int id)
        {
            try
            {
                businessTripsPayment.Delete(businessTripsPayment.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BusinessTripPaymentRemoveRange(List<BusinessTripsPaymentDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = businessTripsPayment.GetAll().SingleOrDefault(p => p.ID == item.ID);
                    businessTripsPayment.Delete(deleteModel);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsReport CRUD method's

        public int BusinessTripReportCreate(BusinessTripsReportDTO btdDTO)
        {
            var createBusinessTripsReport = businessTripsReport.Create(mapper.Map<BusinessTripsReport>(btdDTO));

            return (int)createBusinessTripsReport.ID;
        }

        public void BusinessTripReportUpdate(BusinessTripsReportDTO btdDTO)
        {
            var updateBusinessTripsReport = businessTripsReport.GetAll().SingleOrDefault(c => c.ID == btdDTO.ID);
            businessTripsReport.Update((mapper.Map<BusinessTripsReportDTO, BusinessTripsReport>(btdDTO, updateBusinessTripsReport)));
        }

        public bool BusinessTripReportDelete(int id)
        {
            try
            {
                businessTripsReport.Delete(businessTripsReport.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsPaymentVat CRUD method's

        public int BusinessTripsPaymentVatCreate(BusinessTripsPaymentVatDTO businessTripsPaymentVatDTO)
        {
            var createBusinessTripsPaymentVat = businessTripsPaymentVat.Create(mapper.Map<BusinessTripsPaymentVat>(businessTripsPaymentVatDTO));

            return (int)createBusinessTripsPaymentVat.VatID;
        }

        public void BusinessTripsPaymentVatUpdate(BusinessTripsPaymentVatDTO businessTripsPaymentVatDTO)
        {
            var updateBusinessTripsPaymentVat = businessTripsPaymentVat.GetAll().SingleOrDefault(c => c.VatID == businessTripsPaymentVatDTO.VatID);
            businessTripsPaymentVat.Update((mapper.Map<BusinessTripsPaymentVatDTO, BusinessTripsPaymentVat>(businessTripsPaymentVatDTO, updateBusinessTripsPaymentVat)));
        }

        public bool BusinessTripsPaymentVatDelete(int id)
        {
            try
            {
                businessTripsPaymentVat.Delete(businessTripsPaymentVat.GetAll().FirstOrDefault(c => c.VatID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region BusinessTripsOrderCust CRUD method's

        public int BusinessTripsOrderCustCreate(BusinessTripsOrderCustDTO businessTripsOrderCustDTO)
        {
            var createBusinessTripsOrderCust = businessTripsOrderCust.Create(mapper.Map<BusinessTripsOrderCust>(businessTripsOrderCustDTO));
            return (int)createBusinessTripsOrderCust.ID;
        }

        public void BusinessTripsOrderCustUpdate(BusinessTripsOrderCustDTO businessTripsOrderCustDTO)
        {
            var updateBusinessTripsOrderCust = businessTripsOrderCust.GetAll().SingleOrDefault(c => c.ID == businessTripsOrderCustDTO.ID);
            businessTripsOrderCust.Update((mapper.Map<BusinessTripsOrderCustDTO, BusinessTripsOrderCust>(businessTripsOrderCustDTO, updateBusinessTripsOrderCust)));
        }

        public bool BusinessTripsOrderCustDelete(int id)
        {
            try
            {
                businessTripsOrderCust.Delete(businessTripsOrderCust.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool BusinessTripsOrderCustRemoveRange(List<BusinessTripsOrderCustDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = businessTripsOrderCust.GetAll().SingleOrDefault(p => p.ID == item.ID);
                    businessTripsOrderCust.Delete(deleteModel);
                }


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #endregion

        #region CashPrepayments CRUD method's

        public int CashPrepaymentCreate(CashPrepaymentsDTO cpDTO)
        {
            var createCashPrepayment = cashPrepayments.Create(mapper.Map<CashPrepayments>(cpDTO));

            return (int)createCashPrepayment.Id;
        }

        public void CashPrepaymentUpdate(CashPrepaymentsDTO cpDTO)
        {
            var updateCashPrepayment = cashPrepayments.GetAll().SingleOrDefault(c => c.Id == cpDTO.Id);
            cashPrepayments.Update((mapper.Map<CashPrepaymentsDTO, CashPrepayments>(cpDTO, updateCashPrepayment)));
        }

        public bool CashPrepaymentDelete(int id)
        {
            try
            {
                cashPrepayments.Delete(cashPrepayments.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region CashPayments CRUD method's

        public void CashPaymentCreateRange(List<CashPaymentsDTO> source)
        {
            cashPayments.CreateRange(mapper.Map<List<CashPaymentsDTO>, IEnumerable<CashPayments>>(source));
        }

        public void CashPaymentUpdate(CashPaymentsDTO cpDTO)
        {
            var updateCashPayment = cashPayments.GetAll().SingleOrDefault(c => c.Id == cpDTO.Id);
            cashPayments.Update((mapper.Map<CashPaymentsDTO, CashPayments>(cpDTO, updateCashPayment)));
        }

        public bool CashPaymentRemoveRange(List<CashPaymentsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = cashPayments.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    cashPayments.Delete(deleteModel);
                }

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
