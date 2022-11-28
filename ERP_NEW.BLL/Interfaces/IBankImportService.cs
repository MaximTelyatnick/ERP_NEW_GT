using ERP_NEW.BLL.DTO.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.Interfaces
{
    public interface IBankImportService
    {
        List<PaymentImportModelDTO> GetPrivatBankList(string filePath);
        List<PaymentImportModelDTO> GetPrivatBankCurrencyList(string filePath);
        List<PaymentImportModelDTO> GetPrivatBankCardList(string filePath);
        List<PaymentImportModelDTO> GetBankCreditDneprList(string filePath);
        List<PaymentImportModelDTO> GetPoltavaBankList(string filePath);
        List<PaymentImportModelDTO> GetPoltavaBankCurrencyList(string filePath);
        List<PaymentImportModelDTO> GetSberBankList(string filePath);
        List<PaymentImportModelDTO> GetUkrEximBankList(string filePath);
        List<PaymentImportModelDTO> GetUkrSibBankList(string filePath);
    }
}
