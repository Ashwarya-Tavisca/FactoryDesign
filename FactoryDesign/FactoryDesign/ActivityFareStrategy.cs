using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class ActivityFareStrategy: ICalculateFareStrategy
    {
        public int CalculateFareOfProduct(int totalFare)
        {
            return (totalFare + 1400);
        }
    }
}
