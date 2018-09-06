using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FactoryDesign
{
    class FileDatabase
    {
         public void WriteData(string name,int id,string typeOfOperation, bool isBook)
        {
            Logger.Instance.WriteLog("Writing to file ");
            FileStream fs = new FileStream("C:\\Users\\ajoshi\\Desktop\\save.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Type Of Operation Performed : " + typeOfOperation);
            sw.WriteLine("Name : " + name);
            sw.WriteLine("Id : " + id);
            if (isBook == true)
                sw.WriteLine("Is Booked : True");
            else
                sw.WriteLine("Is Booked :False");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}
