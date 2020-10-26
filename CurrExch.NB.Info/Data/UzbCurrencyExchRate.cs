using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class UzbCurrencyExchRate : CurrencyExchRate
    {
        public decimal? nbu_buy_price { get; set; }
        public decimal? nbu_cell_price { get; set; }
        public string date { get; set; }

        [JsonProperty("code")]
        public override string IsoCode { get ; set ; }
        [JsonProperty("title")]
        public override string Name { get ; set ; }
        public override int Nominal { get => 1; set => Nominal = value; }
        [JsonProperty("cb_price")]
        public override string Rate { get ; set ; }
    }
}
