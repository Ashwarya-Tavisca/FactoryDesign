using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class AirProduct:IProduct
    {
        public string name = "Air India";
        public int id = 26;
        public bool isBook;
        public string productOperation;

        public void Save()
        {
            productOperation = " Save ";
            isBook = false;
            FileDatabase obj = new FileDatabase();
            obj.WriteData(name, id, productOperation, isBook);
            Logger.Instance.WriteLog("Saved Air Product");
            Console.WriteLine("Saving Air Product");
        }
        public void Book()
        {
            productOperation = " Book ";
            isBook = true;
            FileDatabase obj = new FileDatabase();
            obj.WriteData(name, id, productOperation, isBook);
            Logger.Instance.WriteLog("Booked Air Product");
            Console.WriteLine("Booked Air Product");
        }
    }
}
