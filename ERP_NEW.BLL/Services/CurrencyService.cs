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
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ERP_NEW.BLL.Services
{
    public class CurrencyService : ICurrencyService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<Currency> currency;
        private IRepository<Currency_Rates> currency_Rates;

        private IMapper mapper;

        public CurrencyService(IUnitOfWork uow)
        {
            Database = uow;
            currency = Database.GetRepository<Currency>();
            currency_Rates = Database.GetRepository<Currency_Rates>();

            var config = new MapperConfiguration(cfg =>
             {
                 cfg.CreateMap<Currency, CurrencyDTO>();
                 cfg.CreateMap<Currency_RatesDTO, Currency_Rates>();
                 cfg.CreateMap<Currency_Rates, Currency_RatesDTO>();
             });

            mapper = config.CreateMapper();
        }

        public IEnumerable<CurrencyDTO> GetCurrency()
        {
            string procName = @"select * from ""CurrencyProc""";

            return mapper.Map<IEnumerable<Currency>, List<CurrencyDTO>>(currency.SQLExecuteProc(procName));
        }

        public IEnumerable<CurrencyDTO> GetAllCurrency()
        {
            return mapper.Map<IEnumerable<Currency>, List<CurrencyDTO>>(currency.GetAll()).OrderBy(o => o.Name);
        }

        public IEnumerable<Currency_RatesDTO> GetCurrencyRates()
        {
            return mapper.Map<IEnumerable<Currency_Rates>, List<Currency_RatesDTO>>(currency_Rates.GetAll());
        }
        
        public Currency_RatesDTO GetCurrencyRateById(int id)
        {
            return mapper.Map<Currency_RatesDTO>(currency_Rates.GetAll().SingleOrDefault(w => w.Id == id));
        }




        public decimal GetCurrencyRateByDate(string currencyName, DateTime rateDate)
        {
            decimal currencyRate = 0.00m;
            List<CurencyJSONDTO> account = new List<CurencyJSONDTO>();
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                Uri uri = new Uri("http://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?valcode=" + currencyName + "&date=" + rateDate.ToString("yyyyMMdd") + "&json");
                string json = new WebClient().DownloadString(uri);

                account = JsonConvert.DeserializeObject<IEnumerable<CurencyJSONDTO>>(json).ToList();
                return account.FirstOrDefault().Rate;
            }
            catch (Exception)
            {
                return 1;
            }

            // старый метод получения курса валют с сайта
            //         http://minfin.com.ua/
            //
            //
            //Func <string, decimal> getRateFromInnerText =
            //        value =>
            //        {
            //            decimal rate = 0.00m;
            //            string[] buffer = value.Split(new string[] { " " }, StringSplitOptions.None).Where(s => !String.IsNullOrEmpty(s)).ToArray();
            //            rate = Math.Round(Decimal.Parse(buffer[0].ToString(), CultureInfo.InvariantCulture), 6);
            //            return rate;
            //        };

            //WebClient wb = new WebClient();
            //wb.Headers.Add("user-agent", "Only a test");
            ////ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ////Uri uri = new Uri("http://minfin.com.ua/currency/nbu/" + currencyName + "/" + rateDate.ToString("yyyy-MM-dd") + "/");
            //try
            //{
            //    //StreamReader reader = new StreamReader(wb.OpenRead(uri),Encoding.GetEncoding("UTF-8"));

            //    //string html = reader.ReadToEnd();

            //    //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //    //doc.LoadHtml(html);

            //    //var trNodes = doc.DocumentNode.SelectNodes("//tr");

            //    //if (trNodes.Count != 0)
            //    //{
            //    //    foreach (var item in trNodes)
            //    //    {
            //    //        var tdNodes = item.ChildNodes.Where(x => x.Name == "td").ToArray();
            //    //        if (tdNodes.Count() > 0)
            //    //        {
            //    //            currencyRate = getRateFromInnerText(Regex.Replace(tdNodes[1].InnerText, @"\r\n?|\n", replaceString));
            //    //            //currencyRate = getRateFromInnerText(tdNodes[1].InnerText);
            //    //            if (currencyRate > 0) return currencyRate;
            //    //        }
            //    //    }
            //    //}

            //    return currencyRate;
            //}
            //catch (Exception)
            //{
            //    return 1;
            //}
        }

        public int CurrencyRatesCreate(Currency_RatesDTO currencyRate)
        {
            var createrecord = currency_Rates.Create(mapper.Map<Currency_Rates>(currencyRate));
            return (int)createrecord.Id;
        }

        public void CurrencyRatesUpdate(Currency_RatesDTO currencyRate)
        {

            var eGroup = currency_Rates.GetAll().SingleOrDefault(c => c.Id == currencyRate.Id);
            currency_Rates.Update((mapper.Map<Currency_RatesDTO, Currency_Rates>(currencyRate, eGroup)));
        }

        public bool CurrencyRatesDelete(int id)
        {
            try
            {
                currency_Rates.Delete(currency_Rates.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
