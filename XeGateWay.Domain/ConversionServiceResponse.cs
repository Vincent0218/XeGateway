using System;

namespace XeGateWay.Domain
{
    public class ConversionServiceResponse
    {
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
