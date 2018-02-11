﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XeGateway.Models
{
    public class ConversionRequest
    {
        public Dictionary<string, string> AdditionalParam { get; set; }

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