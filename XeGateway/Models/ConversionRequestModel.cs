using System;
namespace XeGateway.Models
{
    public class ConversionRequestModel
    {

        /// <summary>
        /// Additional Param , JSON this can be parsed by Service Integration With Different Sources 
        /// </summary>
        public String AdditionalParam { get; set; }

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

        public Int64 SourceId { get; set; }
    }
}