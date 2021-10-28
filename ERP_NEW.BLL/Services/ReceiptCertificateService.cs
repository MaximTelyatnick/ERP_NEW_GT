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

namespace ERP_NEW.BLL.Services
{
    public class ReceiptCertificateService : IReceiptCertificateService 
    { 
        private IUnitOfWork Database { get; set; }
        private IRepository<ReceiptCertificates> receiptCertificate;
        private IRepository<ExpenditureByOrders> expenditureByOrders;
        private IRepository<OrdersInfo> ordersInfo;
        private IMapper mapper;

        public ReceiptCertificateService(IUnitOfWork uow)
        {
            Database = uow;
            receiptCertificate = Database.GetRepository<ReceiptCertificates>();
            expenditureByOrders = Database.GetRepository<ExpenditureByOrders>();
            ordersInfo = Database.GetRepository<OrdersInfo>();
           
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReceiptCertificates, ReceiptCertificatesDTO>();
                cfg.CreateMap<ReceiptCertificatesDTO, ReceiptCertificates>();

                cfg.CreateMap<OrdersInfo, OrdersInfoDTO>();
                cfg.CreateMap<ExpenditureByOrders, ExpenditureByOrdersDTO>();
            });

            mapper = config.CreateMapper();
        }

        #region GET method`s for ReceiptCertificates

        public IEnumerable<OrdersInfoDTO> GetOrdersWithCertificate(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetOrdersWithCertificate""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<OrdersInfo>, List<OrdersInfoDTO>>(ordersInfo.SQLExecuteProc(procName, Parameters));
        }
        
        public IEnumerable<ExpenditureByOrdersDTO> GetExpenditureByCustomerOrders(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetExpenditureByCustomerOrders""(@BeginDate,@EndDate)";

            return mapper.Map<IEnumerable<ExpenditureByOrders>, List<ExpenditureByOrdersDTO>>(expenditureByOrders.SQLExecuteProc(procName, Parameters));
        }
        
        public ReceiptCertificatesDTO GetCertificate(long id)
        {
           var record = receiptCertificate.GetAll().SingleOrDefault(r => r.ReceiptCertificateId == id);

           return mapper.Map<ReceiptCertificates, ReceiptCertificatesDTO>(record);
        }

        public IEnumerable<ReceiptCertificatesDTO> GetCertificates()
        {
            return mapper.Map<IEnumerable<ReceiptCertificates>, List<ReceiptCertificatesDTO>>(receiptCertificate.GetAll());
        }
        #endregion

        #region ReceiptCertificates CRUD method`s

        public long CreateCertificate(ReceiptCertificatesDTO dtomodel)
        {
            var record = receiptCertificate.Create(mapper.Map<ReceiptCertificates>(dtomodel));
            return record.ReceiptCertificateId;
        }

        public void UpdateCertificate(ReceiptCertificatesDTO dtomodel)
        {
            var entity = receiptCertificate.GetAll().SingleOrDefault(c => c.ReceiptCertificateId == dtomodel.ReceiptCertificateId);
            receiptCertificate.Update(mapper.Map<ReceiptCertificatesDTO, ReceiptCertificates>(dtomodel, entity));
        }

        public bool RemoveCertificateById(long id)
        {
            try
            {
                var delEntity = receiptCertificate.GetAll().SingleOrDefault(c => c.ReceiptCertificateId == id);
                receiptCertificate.Delete(delEntity);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

       private byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
