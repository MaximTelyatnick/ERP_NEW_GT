using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ERP_NEW.BLL.DTO.SelectedDTO;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.Interfaces;
using ERP_NEW.DAL.Entities;
using ERP_NEW.DAL.Entities.QueryModels;
using ERP_NEW.DAL.Interfaces;
using FirebirdSql.Data.FirebirdClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ERP_NEW.DAL.Entities.Models;

namespace ERP_NEW.BLL.Services
{
    public class DeliveryService : IDeliveryService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<DeliveryPayments> deliveryPayments;
        private IRepository<DeliveryContractorDebts> deliveryContractorDebts;
        private IRepository<DeliveryOrders> deliveryOrders;
        private IRepository<DeliveryStoreRemains> deliveryStoreRemains;
        private IRepository<DeliveryStoreRemainsReceipt> deliveryStoreRemainsReceipt;
        private IRepository<ReceiptDetails> receiptDetails;
        private IRepository<CustomerOrders> customerOrders;
        private IRepository<MtsAssemblies> mtsAssemblies;
        private IRepository<Contractors> contractors;

        private IMapper mapper;

        public DeliveryService(IUnitOfWork uow)
        {
            Database = uow;
            deliveryOrders = Database.GetRepository<DeliveryOrders>();
            deliveryPayments = Database.GetRepository<DeliveryPayments>();
            deliveryContractorDebts = Database.GetRepository<DeliveryContractorDebts>();
            deliveryStoreRemains = Database.GetRepository<DeliveryStoreRemains>();
            deliveryStoreRemainsReceipt = Database.GetRepository<DeliveryStoreRemainsReceipt>();
            receiptDetails = Database.GetRepository<ReceiptDetails>();
            customerOrders = Database.GetRepository<CustomerOrders>();
            mtsAssemblies = Database.GetRepository<MtsAssemblies>();
            contractors = Database.GetRepository<Contractors>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DeliveryOrders, DeliveryOrdersDTO>();
                cfg.CreateMap<DeliveryPayments, DeliveryPaymentsDTO>();
                cfg.CreateMap<DeliveryContractorDebts, DeliveryContractorDebtsDTO>();
                cfg.CreateMap<DeliveryStoreRemains, DeliveryStoreRemainsDTO>();
                cfg.CreateMap<DeliveryStoreRemainsReceipt, DeliveryStoreRemainsReceiptDTO>();
                cfg.CreateMap<ReceiptDetails, ReceiptDetailsDTO>();
                cfg.CreateMap<ReceiptDetailsDTO, ReceiptDetails>();
                cfg.CreateMap<CustomerOrders, CustomerOrdersDTO>();
                cfg.CreateMap<MtsAssemblies, MtsAssembliesDTO>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<DeliveryOrdersDTO> GetDeliveryOrders(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            string procName = @"select * from ""GetDeliveryOrders""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<DeliveryOrders>, List<DeliveryOrdersDTO>>(deliveryOrders.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<DeliveryContractorDebtsDTO> GetDeliveryContractorDebts(DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetDeliveryContractorDebts""(@EndDate)";

            return mapper.Map<IEnumerable<DeliveryContractorDebts>, List<DeliveryContractorDebtsDTO>>(deliveryContractorDebts.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<DeliveryPaymentsDTO> GetDeliveryPayments(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
            };
            
            string procName = @"select * from ""GetDeliveryPayments""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<DeliveryPayments>, List<DeliveryPaymentsDTO>>(deliveryPayments.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<DeliveryStoreRemainsDTO> GetDeliveryStoreRemains(DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetDeliveryStoreRemains""(@EndDate)";

            return mapper.Map<IEnumerable<DeliveryStoreRemains>, List<DeliveryStoreRemainsDTO>>(deliveryStoreRemains.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<DeliveryStoreRemainsReceiptDTO> GetDeliveryStoreRemainsWithReceipt(DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetDiliveryStoreRemainsReceipt""(@EndDate)";

            return mapper.Map<IEnumerable<DeliveryStoreRemainsReceipt>, List<DeliveryStoreRemainsReceiptDTO>>(deliveryStoreRemainsReceipt.SQLExecuteProc(procName, Parameters));
        }


        public IEnumerable<ReceiptDetailsDTO> GetReceiptDetails(int receiptId)
        {
            var rezult = (from rd in receiptDetails.GetAll()
                          join c in customerOrders.GetAll() on rd.CustomerOrderId equals c.Id into cus
                          from c in cus.DefaultIfEmpty()
                          join mts in mtsAssemblies.GetAll() on c.AssemblyId equals mts.Id into mtss
                          from mts in mtss.DefaultIfEmpty()
                          join con in contractors.GetAll() on c.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()
                          where (rd.ReceiptId == receiptId)
                          select new ReceiptDetailsDTO()
                          {
                              Id = rd.Id,
                              ReceiptId = rd.ReceiptId,
                              CustomerOrderId = rd.CustomerOrderId,
                              ContractorName = con.Name,
                              CustomerOrderNumber = c.OrderNumber,
                              Drawing = mts.Drawing

                          });
            return rezult;
        }

        public IEnumerable<ReceiptDetailsDTO> GetReceiptDetails()
        {
            return mapper.Map<IEnumerable<ReceiptDetails>, List<ReceiptDetailsDTO>>(receiptDetails.GetAll());
        }

        #region ReceiptDetails CRUD method's

        public int ReceiptDetailsCreate(ReceiptDetailsDTO receiptDetailsDTO)
        {
            var createReceiptDetails = receiptDetails.Create(mapper.Map<ReceiptDetails>(receiptDetailsDTO));
            return (int)createReceiptDetails.Id;
        }

        public void ReceiptDetailsCreateRange(List<ReceiptDetailsDTO> source)
        {
            receiptDetails.CreateRange(mapper.Map<List<ReceiptDetailsDTO>, IEnumerable<ReceiptDetails>>(source));
        }

        public void ReceiptDetailsUpdate(ReceiptDetailsDTO receiptDetailsDTO)
        {
            var updateReceiptDetails = receiptDetails.GetAll().SingleOrDefault(c => c.Id == receiptDetailsDTO.Id);
            receiptDetails.Update((mapper.Map<ReceiptDetailsDTO, ReceiptDetails>(receiptDetailsDTO, updateReceiptDetails)));
        }

        public bool ReceiptDetailsDelete(int id)
        {
            try
            {
                receiptDetails.Delete(receiptDetails.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ReceiptDetailsRemoveRange(List<ReceiptDetailsDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var deleteModel = receiptDetails.GetAll().SingleOrDefault(p => p.Id == item.Id);
                    receiptDetails.Delete(deleteModel);
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
