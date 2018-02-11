using System;
using System.Collections;
namespace XeGateway.ApplicationManager
{

    /// <summary>
    /// ServiceLocator lookup Concversion service [In memory Service list]
    /// </summary>
    internal static class ServiceLocator
    {
        private static readonly Hashtable Services = new Hashtable();

        public static void AddService<T>( T t)
        {

        }
        public static T GetServiceByName<T>(String Name)
        {
            return (T)Services[typeof(T).Name];
        }


    }
}