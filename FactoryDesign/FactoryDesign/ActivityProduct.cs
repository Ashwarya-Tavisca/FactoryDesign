using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class ActivityProduct:IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Activity";
        }
        public void Save()
        {
            Console.WriteLine("Saving Activity Product");
        }
        public void Book()
        {
            Console.WriteLine("Booked Activity Product");
        }
    }
}
