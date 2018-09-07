using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public interface IProduct
    {
        string ProductType { get; set; }
        string ProductName { get; set; }
        bool IsBooked { get; set; }
        int Fare { get; set; }

    }
}
