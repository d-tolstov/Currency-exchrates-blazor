using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class BlrCurrencyExchRate : CurrencyExchRate
    {
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
        public string NumCode { get; set; }

        [XmlElement(ElementName = "CharCode")]
        public override string IsoCode { get; set; }

        [XmlElement(ElementName = "Scale")]
        public override int Nominal { get; set; }
        public override string Name { get; set; }
        public override string Rate { get; set; }
    }
}
