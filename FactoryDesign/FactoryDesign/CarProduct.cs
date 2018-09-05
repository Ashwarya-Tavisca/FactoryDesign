using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class CarProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Save()
        {
            Console.WriteLine("Saving Car Product");
        }
        public void Book()
        {
            Console.WriteLine("Booked Car Product");
        }
    }
}
