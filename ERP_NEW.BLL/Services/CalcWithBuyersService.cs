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
    public class CalcWithBuyersService : ICalcWithBuyersService
    {
        private IUnitOfWork Database { get; set; }

        private IRepository<CalcWithBuyers> calcWithBuyers;
        private IRepository<CalcWithBuyersSpec> calcWithBuyersSpec;
        private IRepository<CalcWithBuyersInfo> calcWithBuyersInfo;
        private IRepository<CalcWithBuyersPaymentVat> calcWithBuyersPaymentVat;
        private IRepository<CustomerOrderSpecifications> customerOrderSpecifications;
        private IRepository<ACCOUNTS> accounts;
        private IRepository<DictionaryCPV> dictionaryCPV;
        private IRepository<DictionaryDKPP> dictionaryDKPP;
        private IRepository<DictionaryUKTV> dictionaryUKTV;
        private IRepository<CustomerOrdersForCWB> customerOrdersForCWB;
        private IRepository<CustomerOrders> customerOrders;
        
        private IMapper mapper;

        public CalcWithBuyersService(IUnitOfWork uow)
        {
            Database = uow;

            calcWithBuyers = Database.GetRepository<CalcWithBuyers>();
            calcWithBuyersSpec = Database.GetRepository<CalcWithBuyersSpec>();
            calcWithBuyersInfo = Database.GetRepository<CalcWithBuyersInfo>();
            calcWithBuyersPaymentVat = Database.GetRepository<CalcWithBuyersPaymentVat>();
            customerOrderSpecifications = Database.GetRepository<CustomerOrderSpecifications>();
            accounts = Database.GetRepository<ACCOUNTS>();
            dictionaryCPV = Database.GetRepository<DictionaryCPV>();
            dictionaryDKPP = Database.GetRepository<DictionaryDKPP>();
            dictionaryUKTV = Database.GetRepository<DictionaryUKTV>();
            customerOrdersForCWB = Database.GetRepository<CustomerOrdersForCWB>();
            customerOrders = Database.GetRepository<CustomerOrders>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CalcWithBuyers, CalcWithBuyersDTO>();
                cfg.CreateMap<CalcWithBuyersDTO, CalcWithBuyers>();
                cfg.CreateMap<CalcWithBuyersSpec, CalcWithBuyersSpecDTO>();
                cfg.CreateMap<CalcWithBuyersSpecDTO, CalcWithBuyersSpec>();
                cfg.CreateMap<CalcWithBuyersInfo, CalcWithBuyersInfoDTO>();
                cfg.CreateMap<CalcWithBuyersPaymentVat, CalcWithBuyersPaymentVatDTO>();
                cfg.CreateMap<CalcWithBuyersPaymentVatDTO, CalcWithBuyersPaymentVat>();
                cfg.CreateMap<CustomerOrdersForCWB, CustomerOrdersForCWBDTO>();
                cfg.CreateMap<CustomerOrdersForCWBDTO, CustomerOrdersForCWB>();
            });

            mapper = config.CreateMapper();
        }

        #region Get method's
        public IEnumerable<CalcWithBuyersDTO> GetCalcWithBuyers()
        {
            return mapper.Map<IEnumerable<CalcWithBuyers>, List<CalcWithBuyersDTO>>(calcWithBuyers.GetAll());
        }
        public IEnumerable<CalcWithBuyersInfoDTO> GetCalcWithBuyersJournal(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetCalcWithBuyersJournal""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<CalcWithBuyersInfo>, List<CalcWithBuyersInfoDTO>>(calcWithBuyersInfo.SQLExecuteProc(procName, Parameters));
        }

        public CalcWithBuyersPaymentVatDTO GetCalcWithBuyersPaymentVatById(int id)
        {
            return mapper.Map<CalcWithBuyersPaymentVat, CalcWithBuyersPaymentVatDTO>(calcWithBuyersPaymentVat.GetAll().SingleOrDefault(s => s.Id == id));
        }

        public IEnumerable<CalcWithBuyersSpecDTO> GetCalcWithBuyersSpec(int id)
        {
            var result = (from cs in calcWithBuyersSpec.GetAll()
                          join cb in calcWithBuyers.GetAll() on cs.CalcWithBuyerId equals cb.Id
                          join pv in calcWithBuyersPaymentVat.GetAll() on cs.Id equals pv.CalcWithBuyerSpecId into cspv
                          from pv in cspv.DefaultIfEmpty()
                          join co in customerOrderSpecifications.GetAll() on cs.CustomerOrderSpecId equals co.Id into csco
                          from co in csco.DefaultIfEmpty()
                          join c in customerOrders.GetAll() on co.CustomerOrderId equals c.Id into cco
                          from c in cco.DefaultIfEmpty()
                          join dcpv in dictionaryCPV.GetAll() on cs.CpvId equals dcpv.Id into cs_dcpv
                          from dcpv in cs_dcpv.DefaultIfEmpty()
                          join duktv in dictionaryUKTV.GetAll() on cs.UktvId equals duktv.Id into cs_duktv
                          from duktv in cs_duktv.DefaultIfEmpty()
                          join ddkpp in dictionaryDKPP.GetAll() on cs.DkppId equals ddkpp.Id into cs_ddkpp
                          from ddkpp in cs_ddkpp.DefaultIfEmpty()
                          where cs.CalcWithBuyerId == id
                          select new CalcWithBuyersSpecDTO()
                          {
                              Id = cs.Id,
                              CalcWithBuyerId = cs.CalcWithBuyerId,
                              PaymentPrice = cs.PaymentPrice,
                              Quantity = cs.Quantity,
                              CustomerOrderSpecId = cs.CustomerOrderSpecId,
                              Details = cs.Details,
                              PaymentPriceCurrency = cs.PaymentPriceCurrency,
                              CpvId = cs.CpvId,
                              DkppId = cs.DkppId,
                              UktvId = cs.UktvId,
                              CpvCode = dcpv.CodeCPV,
                              DkppCode = ddkpp.CodeDKPP,
                              UktvCode = duktv.CodeUKTV,
                              SpecificationName = co.Name,
                              VatPayment6412 = pv.VatPayment6412,
                              VatPayment643 = pv.VatPayment643,
                              TotalPrice = (cs.PaymentPrice ?? 0) + (pv.VatPayment6412 ?? 0) + (pv.VatPayment643 ?? 0),
                              VatSum = (pv.VatPayment6412 ?? 0) + (pv.VatPayment643 ?? 0),
                              CalcWithBuyersPaymentVatId = pv.Id,
                              UserId = cs.UserId,
                              Selected = false,
                              CustomerOrderId = c.Id,
                              CustomerOrderNumber = c.OrderNumber
                          }).OrderBy(o => o.CustomerOrderNumber).ToList();

            return result;
        }

        public IEnumerable<CustomerOrdersForCWBDTO> GetCustomerOrdersByCWBId(int id)
        {
            var result = (from cof in customerOrdersForCWB.GetAll()
                          join co in customerOrders.GetAll() on cof.CustomerOrderId equals co.Id
                          where cof.CalcWithBuyerId == id
                          select new CustomerOrdersForCWBDTO()
                          {
                              Id = cof.Id,
                              CalcWithBuyerId = cof.CalcWithBuyerId,
                              CustomerOrderId = cof.CustomerOrderId,
                              CustomerOrderDate = co.OrderDate,
                              CustomerOrderNumber = co.OrderNumber
                          }).ToList();

            return result;
        }

        #endregion

        #region CalcWithBuyers CRUD method's

        public int CalcWithBuyerCreate(CalcWithBuyersDTO cwbDTO)
        {
            var createCWB = calcWithBuyers.Create(mapper.Map<CalcWithBuyers>(cwbDTO));
            return (int)createCWB.Id;
        }

        public void CalcWithBuyerUpdate(CalcWithBuyersDTO cwbDTO)
        {
            var updateCWB = calcWithBuyers.GetAll().SingleOrDefault(c => c.Id == cwbDTO.Id);
            calcWithBuyers.Update((mapper.Map<CalcWithBuyersDTO, CalcWithBuyers>(cwbDTO, updateCWB)));
        }

        public bool CalcWithBuyerDelete(int id)
        {
            try
            {
                calcWithBuyers.Delete(calcWithBuyers.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region CalcWithBuyersSpec CRUD method's

        public int CalcWithBuyerSpecCreate(CalcWithBuyersSpecDTO cwbsDTO)
        {
            var createCWBS = calcWithBuyersSpec.Create(mapper.Map<CalcWithBuyersSpec>(cwbsDTO));
            return (int)createCWBS.Id;
        }

        public void CalcWithBuyerSpecCreateRange(List<CalcWithBuyersSpecDTO> source)
        { 
            calcWithBuyersSpec.CreateRange(mapper.Map<List<CalcWithBuyersSpecDTO>, IEnumerable<CalcWithBuyersSpec>>(source)); 
        }

        public void CalcWithBuyerSpecUpdate(CalcWithBuyersSpecDTO cwbsDTO)
        {
            var updateCWBS = calcWithBuyersSpec.GetAll().SingleOrDefault(c => c.Id == cwbsDTO.Id);
            calcWithBuyersSpec.Update((mapper.Map<CalcWithBuyersSpecDTO, CalcWithBuyersSpec>(cwbsDTO, updateCWBS)));
        }

        public bool CalcWithBuyerSpecRemoveRange(List<CalcWithBuyersSpecDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = calcWithBuyersSpec.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    calcWithBuyersSpec.Delete(deleteModel);
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region CalcWithBuyersPaymentVat CRUD method's

        public int CalcWithBuyersPaymentVatCreate(CalcWithBuyersPaymentVatDTO cwbpvDTO)
        {
            var createCWBPV = calcWithBuyersPaymentVat.Create(mapper.Map<CalcWithBuyersPaymentVat>(cwbpvDTO));
            return (int)createCWBPV.Id;
        }

        public void CalcWithBuyersPaymentVatUpdate(CalcWithBuyersPaymentVatDTO cwbpvDTO)
        {
            var updateCWBPV = calcWithBuyersPaymentVat.GetAll().SingleOrDefault(c => c.Id == cwbpvDTO.Id);
            calcWithBuyersPaymentVat.Update((mapper.Map<CalcWithBuyersPaymentVatDTO, CalcWithBuyersPaymentVat>(cwbpvDTO, updateCWBPV)));
        }

        public bool CalcWithBuyersPaymentVatDelete(int id)
        {
            try
            {
                calcWithBuyersPaymentVat.Delete(calcWithBuyersPaymentVat.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region CustomerOrdersForCWB

        public int CustomerOrdersForCWBCreate(CustomerOrdersForCWBDTO cofDTO)
        {
            var createCOF = customerOrdersForCWB.Create(mapper.Map<CustomerOrdersForCWB>(cofDTO));
            return (int)createCOF.Id;
        }

        public bool CustomerOrdersForCWBDelete(int id)
        {
            try
            {
                customerOrdersForCWB.Delete(customerOrdersForCWB.GetAll().FirstOrDefault(c => c.Id == id));
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
