using ERP_NEW.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IAccountsService
    {
        IEnumerable<AccountsDTO> GetAccounts();
        IEnumerable<AccountsDTO> GetVatAccounts();
        IEnumerable<AccountsDTO> GetCalcWithBuyerAccounts();
        IEnumerable<AccountsDTO> GetBankPaymentAccounts();
        IEnumerable<AccountsDTO> GetBankPaymentImportAccounts();
        IEnumerable<AccountsDTO> GetStoreHousesAccounts();
        IEnumerable<AccountsDTO> GetAllAccounts();

        IEnumerable<AccountsTypeDTO> GetAccountsTypes();

        IEnumerable<DictionaryUKTVDTO> GetDictionaryUKTV();
        void DictionaryUKTVUpdate(DictionaryUKTVDTO dictionaryUKTVDTO);

        IEnumerable<DictionaryCPVDTO> GetDictionaryCPV();

        IEnumerable<DictionaryDKPPDTO> GetDictionaryDKPP();

        int AccountsCreate(AccountsDTO accountsDTO);
        void AccountsUpdate(AccountsDTO accountsDTO);
        bool AccountsDelete(int id);

        

        void Dispose();
    }
}
