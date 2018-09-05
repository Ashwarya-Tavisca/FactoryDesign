using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class AirProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Air";
        }
        public void Save()
        {
            Console.WriteLine("Saving Air Product");
        }
        public void Book()
        {
            Console.WriteLine("Booked Air Product");
        }
    }
}
