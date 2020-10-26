using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class RusCurrencyExchRateService : XmlCurrencyExchRateService<RusCurrencyExchRate>
    {
        public void CalcExchRateListByDate(DateTime requestDate)
        {
            RequestDate = requestDate;

            var doc = GetXmlDocumentByDate();

            var deserialize = new XmlSerializer(typeof(RusXmlData));
            var xmlData = (RusXmlData)deserialize.Deserialize(doc.CreateReader());

            RateDate = DateTime.Parse( xmlData.Date);
            ExchRates = xmlData.ValuteList;

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            return $"http://www.cbr.ru/scripts/XML_daily.asp?date_req={RequestDate.ToString("dd'/'MM'/'yyyy")}&d=0";
        }
    }
    [XmlRoot(ElementName = "ValCurs")]
    public class RusXmlData
    {
        [XmlAttribute(AttributeName = "Date")]
        public string Date;
        [XmlAttribute(AttributeName = "name")]
        public string Name;
        [XmlElement(ElementName = "Valute",Type = typeof(RusCurrencyExchRate))]
        public List<RusCurrencyExchRate> ValuteList;
    }
}
