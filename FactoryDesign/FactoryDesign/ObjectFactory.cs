using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryDesign
{
    public class ObjectFactory
    {
        public  IProduct GetProduct(string product)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == product);
            Logger.Instance.WriteLog("Getting the type of instance to be formed");
            return (IProduct)Activator.CreateInstance(productType);
        }

        public IRepository GetStorageType(string storageType)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == storageType);
            return (IRepository)Activator.CreateInstance(productType);
        }

        public ICalculateFareStrategy GetItemTypeForFare(IProduct product)
        {
            Type t = product.GetType();
            if (t == typeof(CarProduct))
            {
                return new CarFareStrategy();
            }
            else if(t == typeof(HotelProduct))
            {
                return new HotelFareStrategy();
            }
            else if (t == typeof(ActivityProduct))
            {
                return new ActivityFareStrategy();
            }
            else
            {
                return new AirFareStrategy();
            }

        }


    }
}
