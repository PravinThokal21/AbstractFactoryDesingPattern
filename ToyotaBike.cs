using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesingPattern
{
    internal class ToyotaBike : IBike
    {
        public void GetBike()
        {
            Console.WriteLine("Toyota Bike");
        }
    }
}
