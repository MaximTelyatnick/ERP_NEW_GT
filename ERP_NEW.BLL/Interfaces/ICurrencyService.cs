using System.Collections.Generic;
using ERP_NEW.BLL.DTO.ModelsDTO;
using ERP_NEW.BLL.DTO.SelectedDTO;
using System;

namespace ERP_NEW.BLL.Interfaces
{
    public  interface ICurrencyService
    {
        IEnumerable<CurrencyDTO> GetCurrency();
        IEnumerable<CurrencyDTO> GetAllCurrency();
        IEnumerable<Currency_RatesDTO> GetCurrencyRates();

        Currency_RatesDTO GetCurrencyRateById(int id);
        decimal GetCurrencyRateByDate(string currencyName, DateTime rateDate);
                
        int CurrencyRatesCreate(Currency_RatesDTO currencyRate);
        void CurrencyRatesUpdate(Currency_RatesDTO currencyRate);
        bool CurrencyRatesDelete(int id);
    }
}
