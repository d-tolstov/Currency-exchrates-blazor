using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class KazCurrencyExchRate : CurrencyExchRate
    {
        [XmlElement(ElementName = "index")]
        public string Direction { get; set; }

        [XmlElement(ElementName = "fullname")]
        public override string Name { get; set; }

        [XmlElement(ElementName = "title")]
        public override string IsoCode { get; set; }

        [XmlElement(ElementName = "quant")]
        public override int Nominal { get; set; }

        [XmlElement(ElementName = "description")]
        public override string Rate { get; set; }

        [XmlElement(ElementName = "change")]
        public string Change { get; set; }
    }
}
