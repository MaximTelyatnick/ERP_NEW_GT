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
    public class AccountingOperationService : IAccountingOperationService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<AccountingOperation> accountingOperation;
        private IRepository<AccountingOperations> accountingOperations;
        private IRepository<ACCOUNTS> accounts_from;
        private IRepository<ACCOUNTS> accounts_to;
        private IRepository<Contractors> contractors;
        private IRepository<Colors> colors;
        private IRepository<Users> users;

        private IMapper mapper;

        public AccountingOperationService(IUnitOfWork uow)
        {
            Database = uow;
            accountingOperation = Database.GetRepository<AccountingOperation>();
            accountingOperations = Database.GetRepository<AccountingOperations>();
            accounts_from = Database.GetRepository<ACCOUNTS>();
            accounts_to = Database.GetRepository<ACCOUNTS>();
            contractors = Database.GetRepository<Contractors>();
            colors = Database.GetRepository<Colors>();
            users = Database.GetRepository<Users>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AccountingOperation, AccountingOperationDTO>();
                cfg.CreateMap<AccountingOperations, AccountingOperationsDTO>();
                cfg.CreateMap<AccountingOperationsDTO, AccountingOperations>();
                cfg.CreateMap<ACCOUNTS, AccountsDTO>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<Users, UsersDTO>();
                cfg.CreateMap<Colors, ColorsDTO>();
            });

            mapper = config.CreateMapper();
        }
                
        public IEnumerable<AccountingOperationDTO> GetAccountingOperation()
        {
            return mapper.Map<IEnumerable<AccountingOperation>, List<AccountingOperationDTO>>(accountingOperation.GetAll());
        }

        public IEnumerable<AccountingOperationsDTO> GetAccountingOperaionsList(DateTime beginDate, DateTime endDate)
        {
            var result = (from aco in accountingOperations.GetAll()
                          join a in accounts_from.GetAll() on aco.OperatingAccountId equals a.ID into acoa
                          from a in acoa.DefaultIfEmpty()
                          join at in accounts_to.GetAll() on aco.PurposeAccountId equals at.ID into acoat
                          from at in acoat.DefaultIfEmpty()
                          join con in contractors.GetAll() on aco.ContractorId equals con.Id into acocon
                          from con in acocon.DefaultIfEmpty()
                          join ao in accountingOperation.GetAll() on aco.AccountingOperationId equals ao.Id into acoao
                          from ao in acoao.DefaultIfEmpty()
                          join col in colors.GetAll() on aco.ColorId equals col.Id into acocol
                          from col in acocol.DefaultIfEmpty()
                          join usr in users.GetAll() on aco.UserId equals usr.UserId into acousr
                          from usr in acousr.DefaultIfEmpty()
                          where aco.PaymentDate >= beginDate && aco.PaymentDate <= endDate
                          select new AccountingOperationsDTO()
                          {
                              Id = aco.Id,
                              PurposeAccountId = aco.PurposeAccountId,
                              PurposeAccountNum = at.NUM,
                              OperatingAccountId = aco.OperatingAccountId,
                              OperationAccountNum = a.NUM,
                              ContractorId = aco.ContractorId,
                              ContractorName = con.Name,
                               ContractorSrn = con.Srn,
                              UserId = aco.UserId,
                              AccountingOperationId = aco.AccountingOperationId,
                              ColorId = aco.ColorId,
                              ColorName = col.Name_Rus,
                              DateCreate = aco.DateCreate,
                              DateUpdate = aco.DateUpdate,
                              Check = false,
                              Direction = aco.Direction,
                              OperateDocument = aco.OperateDocument,
                              PaymentDate = aco.PaymentDate,
                              PaymentPrice = aco.PaymentPrice,
                              DebitPrice = (aco.AccountingOperationId == 1) ? aco.PaymentPrice : null,
                              CreditPrice = (aco.AccountingOperationId == 2) ? aco.PaymentPrice : null,
                              Purpose = aco.Purpose,
                              PaymentBankAccountId = aco.PaymentBankAccountId
                          }).ToList();
            return result;
        }


        #region AccountOperations CRUD method's

        public int AccountOperationsCreate(AccountingOperationsDTO acDTO)
        {
            var createItem = accountingOperations.Create(mapper.Map<AccountingOperations>(acDTO));
            return (int)createItem.Id;
        }

        public void AccountOperationsUpdate(AccountingOperationsDTO acDTO)
        {
            var updateItem = accountingOperations.GetAll().SingleOrDefault(c => c.Id == acDTO.Id);
            accountingOperations.Update((mapper.Map<AccountingOperationsDTO, AccountingOperations>(acDTO, updateItem)));
        }

        public bool AccountOperationsDelete(int id)
        {
            try
            {
                accountingOperations.Delete(accountingOperations.GetAll().FirstOrDefault(c => c.Id == id));
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
