using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public interface IRepository
    {
        void WriteData(string name, int id, string productOperation , bool isBook);
       
    }
}
