using System;
using System.Collections;
using XeGateway.Data.Services;

namespace XeGateway.ApplicationManager
{

    /// <summary>
    /// ServiceLocator lookup Concversion service [In memory Service list]
    /// </summary>
    public static class ServiceLocator
    {
        private static readonly Hashtable Services = new Hashtable();

        public static void AddService(IXeService type)
        {
            Services.Add(type.GetType().FullName, type);
        }
        public static IXeService GetServiceByName(String Name)
        {
            return (IXeService)Services["Name"];
        }


    }
}