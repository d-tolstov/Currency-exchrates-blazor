using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class BlrCurrencyExchRateService : XmlCurrencyExchRateService<BlrCurrencyExchRate>
    {
        public void CalcExchRateListByDate(DateTime requestDate)
        {
            RequestDate = requestDate;

            var doc = GetXmlDocumentByDate();

            var deserialize = new XmlSerializer(typeof(BlrXmlData));
            var xmlData = (BlrXmlData)deserialize.Deserialize(doc.CreateReader());

            RateDate = DateTime.ParseExact(
                s: xmlData.Date, 
                format: "MM'/'dd'/'yyyy", 
                provider: null, 
                style: System.Globalization.DateTimeStyles.None
            );

            ExchRates   = xmlData.ValuteList;

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            return $"http://www.nbrb.by/Services/XmlExRates.aspx?ondate={RequestDate.ToString("MM'/'dd'/'yyyy")}";
        }
    }
    [XmlRoot(ElementName = "DailyExRates")]
    public class BlrXmlData
    {
        [XmlAttribute(AttributeName = "Date")]
        public string Date;
        [XmlElement(ElementName = "Currency", Type = typeof(BlrCurrencyExchRate))]
        public List<BlrCurrencyExchRate> ValuteList;
    }
}
