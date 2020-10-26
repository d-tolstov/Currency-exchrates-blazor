using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public abstract class CurrencyExchRate
    {
        [XmlIgnore]
        public abstract string IsoCode { get; set; }
        [XmlIgnore]
        public abstract string Name { get; set; }
        [XmlIgnore]
        public abstract int Nominal { get; set; }
        [XmlIgnore]
        public abstract string Rate { get; set; }
    }
}
