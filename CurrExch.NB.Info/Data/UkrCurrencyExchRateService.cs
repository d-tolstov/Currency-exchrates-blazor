using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class UkrCurrencyExchRateService : XmlCurrencyExchRateService<UkrCurrencyExchRate>
    {
        public void CalcExchRateListByDate(DateTime requestDate)
        {
            RequestDate = requestDate;

            var doc = GetXmlDocumentByDate();

            var deserialize = new XmlSerializer(typeof(UkrXmlData));
            var xmlData = (UkrXmlData)deserialize.Deserialize(doc.CreateReader());

            ExchRates   = xmlData.ValuteList;

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            return $"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date={RequestDate.ToString("yyyyMMdd")}";
        }
    }
    [XmlRoot(ElementName = "exchange")]
    public class UkrXmlData
    {
        [XmlElement(ElementName = "currency", Type = typeof(UkrCurrencyExchRate))]
        public List<UkrCurrencyExchRate> ValuteList;
    }
}
