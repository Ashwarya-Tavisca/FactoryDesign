using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryDesign
{
    class ObjectFactory
    {
        public static IProduct GetProduct(string product)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == product);
            Logger.Instance.WriteLog("Getting the type of instance to be formed");
            return (IProduct)Activator.CreateInstance(productType);
        }
        

    }
}
