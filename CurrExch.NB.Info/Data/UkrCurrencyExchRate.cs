using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class UkrCurrencyExchRate : CurrencyExchRate
    {
        [XmlElement(ElementName = "r030")]
        public int Id { get; set; }
        
        [XmlElement(ElementName = "txt")]
        public override string Name { get; set; }
        
        [XmlElement(ElementName = "cc")]
        public override string IsoCode { get; set; }
        
        [XmlElement(ElementName = "rate")]
        public override string Rate { get; set; }
        
        [XmlElement(ElementName = "exchangedate")]
        public string Date { get; set; }
        public override int Nominal { get; set; } = 1;
    }
}
