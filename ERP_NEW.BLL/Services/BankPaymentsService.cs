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
    public class BankPaymentsService : IBankPaymentsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Bank_Payments> bankPayments;
        private IRepository<BankPaymentsInfo> bankPaymentsInfo;
        private IRepository<BankPaymentsSelect> bankPaymentsSelect;

        private IMapper mapper;

        public BankPaymentsService(IUnitOfWork uow)
        {
            Database = uow;
            
            bankPayments = Database.GetRepository<Bank_Payments>();
            bankPaymentsInfo = Database.GetRepository<BankPaymentsInfo>();
            bankPaymentsSelect = Database.GetRepository<BankPaymentsSelect>();
                                                
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Bank_Payments, Bank_PaymentsDTO>();
                cfg.CreateMap<Bank_PaymentsDTO, Bank_Payments>();
                cfg.CreateMap<BankPaymentsInfo, BankPaymentsInfoDTO>();
                cfg.CreateMap<BankPaymentsSelect, BankPaymentsSelectDTO>();
            });

            mapper = config.CreateMapper();
        }

        #region Get method's
        
        public IEnumerable<Bank_PaymentsDTO> GetBankPayments()
        {
            return mapper.Map<IEnumerable<Bank_Payments>, List<Bank_PaymentsDTO>>(bankPayments.GetAll());
        }

        public IEnumerable<BankPaymentsInfoDTO> GetBankPaymentsJournal(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetBankPayments""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<BankPaymentsInfo>, List<BankPaymentsInfoDTO>>(bankPaymentsInfo.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<BankPaymentsSelectDTO> GetBankPaymentsForCOPrepayments(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetBankPaymentsForCOPre""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<BankPaymentsSelect>, List<BankPaymentsSelectDTO>>(bankPaymentsSelect.SQLExecuteProc(procName, Parameters));
        }

        public IEnumerable<BankPaymentsSelectDTO> GetBankPaymentsForCOPayments(DateTime beginDate, DateTime endDate)
        {
            FbParameter[] Parameters =
                {
                    new FbParameter("BeginDate", beginDate),
                    new FbParameter("EndDate", endDate)
                };

            string procName = @"select * from ""GetBankPaymentsForCOPay""(@BeginDate, @EndDate)";

            return mapper.Map<IEnumerable<BankPaymentsSelect>, List<BankPaymentsSelectDTO>>(bankPaymentsSelect.SQLExecuteProc(procName, Parameters)); 
        }

        public bool GetExistImportPayment(DateTime? paymentDate, string paymentDocument, int? bankAccountId, decimal paymentPrice)
        {
            return bankPayments.GetAll().Any(b => b.Payment_Date == paymentDate && b.Payment_Document == paymentDocument && b.Bank_Account_Id == bankAccountId && b.Payment_Price == paymentPrice);
        }

        #endregion

        #region BankPayments CRUD method's

        public int BankPaymentCreate(Bank_PaymentsDTO bpDTO)
        {
            var createItem = bankPayments.Create(mapper.Map<Bank_Payments>(bpDTO));
            return (int)createItem.Id;
        }
        
        public void BankPaymentUpdate(Bank_PaymentsDTO bpDTO)
        {
            var updateItem = bankPayments.GetAll().SingleOrDefault(c => c.Id == bpDTO.Id);
            bankPayments.Update((mapper.Map<Bank_PaymentsDTO, Bank_Payments>(bpDTO, updateItem)));
        }
        
        public bool BankPaymentDelete(int id) 
        {
            try
            {
                bankPayments.Delete(bankPayments.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
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
