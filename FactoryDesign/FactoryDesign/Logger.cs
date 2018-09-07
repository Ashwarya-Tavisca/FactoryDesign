using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Logger
    {
        private Logger() { }
        public static Logger _object; 
        public static Logger Instance
        {
            get
            {
                if (_object == null)
                    _object = new Logger();

                return _object;
            }
        }

        public void WriteLog(string message)
        {
            using (StreamWriter sw = File.AppendText(@"C:\Users\ajoshi\Desktop\LogFile.txt"))
            {
                sw.WriteLine(message);
            }
        }

       
    }
}
