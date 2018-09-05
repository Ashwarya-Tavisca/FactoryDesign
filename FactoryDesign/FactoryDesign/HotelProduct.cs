using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class HotelProduct:IProduct
    {
        public void Save()
        {
            Console.WriteLine("Saving Hotel Product");
        }
        public void Book()
        {
            Console.WriteLine("Booked Hotel Product");
        }
    }
}
