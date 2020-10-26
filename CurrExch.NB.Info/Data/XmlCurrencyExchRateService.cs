using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace CurrExch.NB.Info.Data
{
    public abstract class XmlCurrencyExchRateService<T>
    {
        protected DateTime RequestDate;
        public DateTime? RateDate { get; protected set; }
        public ICollection<T> ExchRates { get; protected set; }
        public bool AlreadyLaunched { get; protected set; }

        protected XDocument GetXmlDocumentByDate()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            return XDocument.Load(GetDownloadUrl());
        }
        protected string GetJsonFromUrl()
        {
            return new WebClient().DownloadString(GetDownloadUrl());
        }
        protected Stream GetStreamFromUrl()
        {
            byte[] bytes = null;

            using (var wc = new System.Net.WebClient())
                bytes = wc.DownloadData(GetDownloadUrl());

            return new MemoryStream(bytes);
        }
        abstract protected string GetDownloadUrl();
        public string GetRateDateStr()
        {
            return RateDate == null ? "не указана" : RateDate.Value.ToString("dd'/'MM'/'yyyy");
        }
        public string GetRequestDateStr()
        {
            return AlreadyLaunched 
                ? RequestDate.ToString("dd'/'MM'/'yyyy")
                : DateTime.UtcNow.ToString("dd'/'MM'/'yyyy");
        }
    }
}
