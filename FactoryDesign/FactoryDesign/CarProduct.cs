using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class CarProduct:IProduct
    {
        public string name = "Audi";
        public int id=27;
        public bool isBook;
        public string productOperation;

        public void Save()
        {
            productOperation =" Save ";
            FileDatabase obj = new FileDatabase();
            obj.WriteData(name, id, productOperation, isBook);
            Logger.Instance.WriteLog("Saved Car product");
            Console.WriteLine("Saving Car Product");
        }
        public void Book()
        {
            productOperation = " Book ";
            isBook = true;
            FileDatabase obj = new FileDatabase();
            obj.WriteData(name, id, productOperation, isBook);
            Logger.Instance.WriteLog("Booked Car product");
            Console.WriteLine("Booked Car Product");
        }
    }
}
