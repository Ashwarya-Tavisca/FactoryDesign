using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.WriteLog("....In Main.... ");
            ObjectFactory obj = new ObjectFactory();
            ProductOperations serviceobj = new ProductOperations();
            int option;string itemType;string storageType;
            Console.WriteLine("Enter the type of product : \nCarProduct, AirProduct, ActivityProduct, HotelProduct ");
            itemType = Console.ReadLine();
            Logger.Instance.WriteLog("Getting the type of object to be created");
            IProduct productType = obj.GetProduct(itemType);
            ICalculateFareStrategy FareItemType = obj.GetItemTypeForFare(productType);
            Console.WriteLine("Enter which operartion you want to perform:\n1:Book 2:Save ");
            option = Int32.Parse(Console.ReadLine());
            Logger.Instance.WriteLog("Switch case Implemented");
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the type of Database you want to use :\n1:FileDatabase 2:SqlDatabase");
                        storageType = Console.ReadLine();
                        IRepository finalstorage = obj.GetStorageType(storageType);
                        serviceobj.Book(productType, finalstorage, FareItemType.CalculateFareOfProduct(productType.Fare));
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter the type of Database you want to use:\n1:FileDatabase 2:SqlDatabase");
                        storageType = Console.ReadLine();
                        IRepository finalstorage = obj.GetStorageType(storageType);
                        serviceobj.Save(productType, finalstorage, FareItemType.CalculateFareOfProduct(productType.Fare));
                        break;
                    }
            }
            Console.ReadKey();
        }
            
    }
    
}
