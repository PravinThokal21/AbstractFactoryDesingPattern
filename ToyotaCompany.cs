using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesingPattern
{
    internal class ToyotaCompany : VehicleCompany
    {
        public override IBike GetBike()
        {
            return new ToyotaBike();
        }

        public override ICar GetCar()
        {
            return new ToyotaCar();
        }
    }
}
