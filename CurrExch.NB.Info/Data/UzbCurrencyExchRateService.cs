using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class UzbCurrencyExchRateService : XmlCurrencyExchRateService<UzbCurrencyExchRate>
    {
        public void CalcExchRateListByDate()
        {
            var json = GetJsonFromUrl();

            var jsonData = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UzbCurrencyExchRate>>(json);

            ExchRates = jsonData;

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            return "https://nbu.uz/exchange-rates/json/";
        }
    }
}
