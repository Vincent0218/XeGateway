using XeGateway.Data.Services;

namespace XeGateway.ApplicationManager
{
    public interface IServiceLocator
    {
        void AddService(IXeService type);
        IXeService GetServiceByName(string Name);
    }
}