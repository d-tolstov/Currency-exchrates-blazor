using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class KgzCurrencyExchRateService : XmlCurrencyExchRateService<KgzCurrencyExchRate>
    {
        public void CalcExchRateListByDate()
        {
            var doc = GetXmlDocumentByDate();

            var deserialize = new XmlSerializer(typeof(KgzXmlData));
            var xmlData = (KgzXmlData)deserialize.Deserialize(doc.CreateReader());

            RateDate = DateTime.Parse(xmlData.Date);

            ExchRates = xmlData.ValuteList;

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            return "https://www.nbkr.kg/XML/daily.xml";
        }
    }
    [XmlRoot(ElementName = "CurrencyRates")]
    public class KgzXmlData
    {
        [XmlAttribute(AttributeName = "Date")]
        public string Date;
        [XmlAttribute(AttributeName = "Name")]
        public string Name;
        [XmlElement(ElementName = "Currency",Type = typeof(KgzCurrencyExchRate))]
        public List<KgzCurrencyExchRate> ValuteList;
    }
}
