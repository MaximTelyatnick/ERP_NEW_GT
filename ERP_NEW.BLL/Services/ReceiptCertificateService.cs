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
        private IRepository<ReceiptCertificateDetail> receiptCertificateDetail;
        private IRepository<ExpenditureByOrders> expenditureByOrders;
        private IRepository<OrdersInfo> ordersInfo;
        private IMapper mapper;

        public ReceiptCertificateService(IUnitOfWork uow)
        {
            Database = uow;
            receiptCertificate = Database.GetRepository<ReceiptCertificates>();
            receiptCertificateDetail = Database.GetRepository<ReceiptCertificateDetail>();
            expenditureByOrders = Database.GetRepository<ExpenditureByOrders>();
            ordersInfo = Database.GetRepository<OrdersInfo>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ReceiptCertificates, ReceiptCertificatesDTO>();
                cfg.CreateMap<ReceiptCertificatesDTO, ReceiptCertificates>();
                cfg.CreateMap<ReceiptCertificateDetail, ReceiptCertificateDetailDTO>();
                cfg.CreateMap<ReceiptCertificateDetailDTO, ReceiptCertificateDetail>();
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

        public IEnumerable<OrdersInfoDTO> GetOrdersWithCertificateV2(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
            {
                new FbParameter("BeginDate", beginDate),
                new FbParameter("EndDate", endDate)
                };
            string procName = @"select * from ""GetOrdersWithCertificateV2""(@BeginDate,@EndDate)";

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
            var result = (from cert in receiptCertificate.GetAll()
                          select new ReceiptCertificatesDTO()
                          {
                              ReceiptCertificateId = cert.ReceiptCertificateId,
                              CertificateDate = cert.CertificateDate,
                              CertificateNumber = cert.CertificateNumber,
                              ReceiptId = cert.ReceiptId,
                              Description = cert.Description,
                              FileName = cert.FileName,
                              ScanCheck = cert.FileName.Length > 0 ? true:false,
                              ManufacturerInfo = cert.ManufacturerInfo
                                 
                          }).ToList();
            return result;
        }

        public bool CheckCertificates(long certificateId)
        {
            if (receiptCertificateDetail.GetAll().Where(srch => srch.ReceiptCertificateId == certificateId).Count() > 0)
                return true;
            else
                return false;
        }


        public IEnumerable<ReceiptCertificateDetailDTO> GetCertificateDetail()
        {
            return mapper.Map<IEnumerable<ReceiptCertificateDetail>, List<ReceiptCertificateDetailDTO>>(receiptCertificateDetail.GetAll());
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

        #region ReceiptCertificateDetail CRUD method`s

        public long CreateCertificateDetail(ReceiptCertificateDetailDTO dtomodel)
        {
            var record = receiptCertificateDetail.Create(mapper.Map<ReceiptCertificateDetail>(dtomodel));
            return record.ReceiptCertificateDetailId;
        }

        public void UpdateCertificateDetail(ReceiptCertificateDetailDTO dtomodel)
        {
            var entity = receiptCertificateDetail.GetAll().SingleOrDefault(c => c.ReceiptCertificateDetailId == dtomodel.ReceiptCertificateDetailId);
            receiptCertificateDetail.Update(mapper.Map<ReceiptCertificateDetailDTO, ReceiptCertificateDetail>(dtomodel, entity));
        }

        public bool RemoveCertificateDetailId(int id)
        {
            try
            {
                var delEntity = receiptCertificateDetail.GetAll().SingleOrDefault(c => c.ReceiptCertificateDetailId == id);
                receiptCertificateDetail.Delete(delEntity);
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
