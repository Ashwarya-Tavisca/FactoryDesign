using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class CarProduct:IProduct
    {
        public string type = "Car";
        public string name= "Audi Q7";
        public bool isbooked = false;
        public int fare = 30;

        public string ProductType { get { return type; } set { type = value; } }
        public string ProductName { get { return name; } set { name = value; } }
        public bool IsBooked { get { return isbooked; } set { isbooked = value; } }
        public int Fare { get { return fare; } set { fare = value; } }
      
    }
}
