using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class ObjectFactory
    {
        public IProduct GetProduct(string product)
        {
            switch(product.ToLower())
            {
                case "car": return new CarProduct();
                case "air": return new AirProduct();
                case "activity": return new ActivityProduct();
                case "hotel": return new HotelProduct();

                default: return new AirProduct();
            }
        }
            

    }
}
