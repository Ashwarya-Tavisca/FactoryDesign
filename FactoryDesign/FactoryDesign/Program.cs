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
            Logger.Instance.WriteLog("In Main ");
            Program program = new Program();
            Console.WriteLine("Enter the name of the product- CarProduct for car, AirProduct For Air, ActivityProduct for Activity and HotelProduct for Hotel ");
            string productName = Console.ReadLine();
            var product = ObjectFactory.GetProduct(productName);
            program.MakeBooking(product);
            Console.ReadKey();
        }
        void MakeBooking(IProduct product)
        {
            product.Save();
            product.Book();
        }
    }
    
}
