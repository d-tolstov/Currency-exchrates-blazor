using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class KazCurrencyExchRateService : XmlCurrencyExchRateService<KazCurrencyExchRate>
    {
        public void CalcExchRateListByDate(DateTime requestDate)
        {
            RequestDate = requestDate;

            var doc = GetXmlDocumentByDate();

            var deserialize = new XmlSerializer(typeof(KazXmlData));
            var xmlData = (KazXmlData)deserialize.Deserialize(doc.CreateReader());

            RateDate = DateTime.Parse(xmlData.Date);
            ExchRates = xmlData.ValuteList;

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            return $"https://nationalbank.kz/rss/get_rates.cfm?fdate={RequestDate.ToString("dd'.'MM'.'yyyy")}";
        }
    }
    [XmlRoot(ElementName = "rates")]
    public class KazXmlData
    {
        [XmlElement(ElementName = "date")]
        public string Date;
        [XmlElement(ElementName = "item", Type = typeof(KazCurrencyExchRate))]
        public List<KazCurrencyExchRate> ValuteList;
    }
}
