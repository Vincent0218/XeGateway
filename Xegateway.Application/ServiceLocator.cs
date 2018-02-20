using System;
using System.Collections;
using XeGateway.Data.Services;

namespace XeGateway.ApplicationManager
{

    /// <summary>
    /// ServiceLocator lookup Concversion service [In memory Service list]
    /// </summary>
    /// 


    public sealed class ServiceLocator : IServiceLocator
    {
        private readonly Hashtable Services = new Hashtable();

        private static readonly ServiceLocator instance = new ServiceLocator();

        public static ServiceLocator Instance
        {
            get
            {
                return instance;
            }
        }
        private ServiceLocator()
        {

        }

        public void AddService(IXeService type)
        {
            Services.Add(type.GetType().FullName, type);
        }
        public IXeService GetServiceByName(String Name)
        {
            return (IXeService)Services[Name];
        }



    }

}