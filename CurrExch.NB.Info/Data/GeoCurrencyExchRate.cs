using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class GeoCurrencyExchRate : CurrencyExchRate
    {
        public override string IsoCode { get; set; }
        public override string Name { get; set; }
        public override int Nominal { get; set; }
        public override string Rate { get; set; }
    }
}
