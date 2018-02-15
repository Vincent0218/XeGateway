using XeGateWay.Domain;

namespace XeGateway.Data.Services
{
    public interface IXeService
    {
        ConversionServiceResponse Convert(ConversionServiceRequest Request);
    }
}
