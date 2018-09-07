using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class ProductOperations
    {
        public void Book(IProduct product, IRepository storage, int fare)
        {
            product.IsBooked = true;
            Logger.Instance.WriteLog("Booked Successfully!!");
            storage.Add(product, fare);
            Console.WriteLine(product.ProductType + " Booked Successfully!! ");
        }

        public void Save(IProduct product, IRepository storage, int fare)
        {

            Logger.Instance.WriteLog("Saved Successfully!!");
            storage.Add(product, fare);
            Console.WriteLine(product.ProductType + " Saved Successfully!! ");
        }
    }
}
