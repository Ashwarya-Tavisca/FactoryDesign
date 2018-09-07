using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class HotelProduct:IProduct
    {
        public string type = "Hotel";
        public string name = "Hyatt Regency";
        public bool isbooked = false;
        public int fare = 50000;

        public string ProductType { get { return type; } set { type = value; } }
        public string ProductName { get { return name; } set { name = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }
        public int Fare { get { return fare; } set { fare = value; } }
    }
}
