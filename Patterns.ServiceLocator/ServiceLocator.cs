namespace Patterns.ServiceLocator
{
    using System.Collections;
    using System.Configuration;
    using System.Reflection;

    public static class ServiceLocator
    {
        public static Hashtable Services = new Hashtable();

        public static void AddService<T>(T t)
        {
            Services.Add(typeof (T).Name, t);
        }

        public static void AddService<T>(string name, T t)
        {
            Services.Add(name, t);
        }

        public static T GetService<T>()
        {
            return (T) Services[typeof (T).Name];
        }

        public static object GetService<T>(string serviceName)
        {
            return (T)Services[serviceName];
        }

        public static void RegisterService(string serviceName)
        {
            var serviceType = ConfigurationManager.AppSettings[serviceName];

            var assembly = Assembly.LoadFrom(string.Concat(serviceName,".dll"));
            var createdType = assembly.CreateInstance(serviceType);
            AddService("log",createdType);
        }
    }
}
