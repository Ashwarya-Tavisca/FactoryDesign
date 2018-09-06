using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class HotelProduct:IProduct
    {
        public string name = "Hyatt Regency";
        public int id = 04;
        public bool isBook;
        public string productOperation;
        public void Save()
        {
            productOperation = " Save ";
            isBook = false;
            FileDatabase obj = new FileDatabase();
            obj.WriteData(name, id, productOperation, isBook);
            Logger.Instance.WriteLog("Saved Hotel Product");
            Console.WriteLine("Saving Hotel Product");
        }
        public void Book()
        {
            productOperation = " Book ";
            isBook = true;
            FileDatabase obj = new FileDatabase();
            obj.WriteData(name, id, productOperation, isBook);
            Logger.Instance.WriteLog("Booked Hotel Product");
            Console.WriteLine("Booked Hotel Product");
        }
    }
}
