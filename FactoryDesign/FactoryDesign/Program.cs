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
            string product = Console.ReadLine();
            ObjectFactory ObjectFactory = new ObjectFactory();
            IProduct iProduct = ObjectFactory.GetProduct(product);
            Console.WriteLine(iProduct.GetTypeOfProduct());
            iProduct.Book();
            iProduct.Save();
            Console.ReadKey();


        }
    }
}
