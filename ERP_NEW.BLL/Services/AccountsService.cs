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
    public class AccountsService : IAccountsService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<ACCOUNTS> accounts;
        private IRepository<AccountsType> accountsType;
        private IRepository<DictionaryUKTV> dictionaryUKTV;
        private IRepository<DictionaryCPV> dictionaryCPV;
        private IRepository<DictionaryDKPP> dictionaryDKPP;
        private IMapper mapper;


        public AccountsService(IUnitOfWork uow)
        {
            Database = uow;
            accounts = Database.GetRepository<ACCOUNTS>();
            accountsType = Database.GetRepository<AccountsType>();
            dictionaryUKTV = Database.GetRepository<DictionaryUKTV>();
            dictionaryCPV = Database.GetRepository<DictionaryCPV>();
            dictionaryDKPP = Database.GetRepository<DictionaryDKPP>();
                                    
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ACCOUNTS, AccountsDTO>();
                cfg.CreateMap<AccountsDTO, ACCOUNTS>();
                cfg.CreateMap<AccountsType, AccountsTypeDTO>();
                cfg.CreateMap<AccountsTypeDTO, AccountsType>();
                cfg.CreateMap<DictionaryUKTV, DictionaryUKTVDTO>();
                cfg.CreateMap<DictionaryUKTVDTO, DictionaryUKTV>();
                cfg.CreateMap<DictionaryCPV, DictionaryCPVDTO>();
                cfg.CreateMap<DictionaryDKPP, DictionaryDKPPDTO>();
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<AccountsDTO> GetAccounts()
        {

            var result = (from c in accounts.GetAll()
                          join co in accountsType.GetAll() on c.Type equals co.ID into coo
                          from co in coo.DefaultIfEmpty()
                          select new AccountsDTO
                          {
                              Id = c.ID,
                              Num = c.NUM,
                              Description = c.Description,
                              TypeName = co.TypeName,
                              Type = co.ID,
                              VatMark = c.VatMark
                          });
            return result.ToList();  

        }

        public IEnumerable<AccountsDTO> GetVatAccounts()
        {
            return mapper.Map<IEnumerable<ACCOUNTS>, List<AccountsDTO>>(accounts.GetAll().Where(w => w.NUM =="641/2" || w.NUM == "644"));
        }
        public IEnumerable<AccountsDTO> GetAllAccounts()
        {
            return mapper.Map<IEnumerable<ACCOUNTS>, List<AccountsDTO>>(accounts.GetAll().OrderBy(a=>a.NUM));
        }

        public IEnumerable<AccountsDTO> GetCalcWithBuyerAccounts()
        {
            return mapper.Map<IEnumerable<ACCOUNTS>, List<AccountsDTO>>(accounts.GetAll().Where(w => w.NUM.StartsWith("36") && w.Type == 1).OrderBy(o => o.NUM));
        }

        public IEnumerable<AccountsDTO> GetBankPaymentAccounts()
        {
            return mapper.Map<IEnumerable<ACCOUNTS>, List<AccountsDTO>>(accounts.GetAll().Where(w => (w.NUM.StartsWith("31") || w.NUM.StartsWith("60")) && w.Type == 1).OrderBy(o => o.NUM));
        }

        public IEnumerable<AccountsDTO> GetBankPaymentImportAccounts()
        {
            return mapper.Map<IEnumerable<ACCOUNTS>, List<AccountsDTO>>(accounts.GetAll().Where(w => w.Type == 1 || w.NUM == "372").OrderBy(o => o.NUM));
        }

        public IEnumerable<AccountsDTO> GetStoreHousesAccounts()
        {
            return mapper.Map<IEnumerable<ACCOUNTS>, List<AccountsDTO>>(accounts.GetAll().Where(w => w.NUM == "631" || w.NUM == "372").OrderBy(o => o.NUM));
        }

        public IEnumerable<AccountsTypeDTO> GetAccountsTypes()
        {
            return mapper.Map<IEnumerable<AccountsType>, List<AccountsTypeDTO>>(accountsType.GetAll());
        }
        
        #region Accounts CRUD method's

        public int AccountsCreate(AccountsDTO accountsDTO)
        {
            var createAccounts = accounts.Create(mapper.Map<ACCOUNTS>(accountsDTO));
            return (int)createAccounts.ID;
        }
        
        public void AccountsUpdate(AccountsDTO accountsDTO)
        {
            var updateAccounts = accounts.GetAll().SingleOrDefault(c => c.ID == accountsDTO.Id);
            accounts.Update((mapper.Map<AccountsDTO, ACCOUNTS>(accountsDTO, updateAccounts)));
        }

        public bool AccountsDelete(int id)
        {
            try
            {
                accounts.Delete(accounts.GetAll().FirstOrDefault(c => c.ID == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Dictionary method's

        public IEnumerable<DictionaryUKTVDTO> GetDictionaryUKTV()
        {
            return mapper.Map<IEnumerable<DictionaryUKTV>, List<DictionaryUKTVDTO>>(dictionaryUKTV.GetAll());
        }

        public void DictionaryUKTVUpdate(DictionaryUKTVDTO dictionaryUKTVDTO)
        {
            var updateUKTVDictionary = dictionaryUKTV.GetAll().SingleOrDefault(c => c.Id == dictionaryUKTVDTO.Id);
            dictionaryUKTV.Update((mapper.Map<DictionaryUKTVDTO, DictionaryUKTV>(dictionaryUKTVDTO, updateUKTVDictionary)));
        }

        public IEnumerable<DictionaryCPVDTO> GetDictionaryCPV()
        {
            return mapper.Map<IEnumerable<DictionaryCPV>, List<DictionaryCPVDTO>>(dictionaryCPV.GetAll());
        }

        public IEnumerable<DictionaryDKPPDTO> GetDictionaryDKPP()
        {
            return mapper.Map<IEnumerable<DictionaryDKPP>, List<DictionaryDKPPDTO>>(dictionaryDKPP.GetAll());
        }

        #endregion

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
