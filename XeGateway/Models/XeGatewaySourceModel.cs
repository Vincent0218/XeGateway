using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XeGateway.Models
{
    public class XeGatewaySourceModel
    {
       public XeGatewaySourceModel()
        {
            Actions = new Dictionary<string, string>();
        }
        public Dictionary<string, string> Actions { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        //  public long Id { get; set; }
        public string Endpoint { get; set; }
        public string AdditionalParms { get; set; }
        public bool Active { get; set; }


    }
}