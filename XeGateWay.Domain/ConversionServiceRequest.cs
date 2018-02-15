using System;
using System.Collections.Generic;

namespace XeGateWay.Domain
{
    public class ConversionServiceRequest
    {

        public ConversionServiceRequest()
        {
            AdditionalParam = new Dictionary<string, string>();
        }

        public Dictionary<string,string> AdditionalParam { get; set; }

        public string CurrencyCodeFrom { get; set; }
        public string CurrencyCodeTo { get; set; }
        public Double Amount { get; set; }

        private DateTime? _OnDate = null;

        /// <summary>
        /// Default to current date 
        /// </summary>
        public DateTime OnDate
        {
            get
            {
                return _OnDate ?? DateTime.Now;
            }

            set { _OnDate = value; }
        }


    }
}
