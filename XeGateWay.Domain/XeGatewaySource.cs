
namespace XeGateWay.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class XeGatewaySource
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public string Endpoint { get; set; }
        public string AdditionalParms { get; set; }
        public bool Active { get; set; }
    }

}
