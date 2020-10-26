using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class RusCurrencyExchRate : CurrencyExchRate
    {
        [XmlAttribute(AttributeName = "ID")]
        public string Id { get; set; }
        public string NumCode { get; set; }
        [XmlElement(ElementName = "CharCode")]
        public override string IsoCode { get; set; }
        [XmlElement(ElementName = "Value")]
        public override string Rate { get; set; }
        public override string Name { get; set; }
        public override int Nominal { get; set; }
    }
}
