using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FactoryDesign
{
    class FileDatabase:IRepository
    {
         public void Add(IProduct product,int fare)
        {
            Logger.Instance.WriteLog("Adding content to the file.");
            using (StreamWriter sw = File.AppendText(@"C:\\Users\\ajoshi\\Desktop\\save.txt"))
            {
                sw.WriteLine("Product Type: " + product.ProductType);
                sw.WriteLine("Product Name: " + product.ProductName);
                sw.WriteLine("Product Fare: " + fare);
                sw.WriteLine("IsBooked: " + product.IsBooked);

            }
        }

    }
}
