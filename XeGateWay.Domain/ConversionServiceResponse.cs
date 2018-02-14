﻿using System;

namespace XeGateWay.Domain
{
    public class ConversionServiceResponse
    {
        public int CurrencyCodeFrom { get; set; }
        public int CurrencyCodeTo { get; set; }
        public Double Amount { get; set; }

        private DateTime? _OnDate = null;


        /// <summary>
        /// Default to current date 
        /// </summary>
        public DateTime OnDate
        {
            get
            {
                return _OnDate.HasValue
                   ? _OnDate.Value
                   : DateTime.Now;
            }

            set { _OnDate = value; }
        }
    }
}
