using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesingPattern
{
    internal abstract class VehicleCompany  
    {
        public abstract IBike GetBike();

        public abstract ICar GetCar();
    }
}
