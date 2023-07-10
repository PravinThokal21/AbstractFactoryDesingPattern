using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesingPattern
{
    internal class TataBike : IBike
    {
        public void GetBike()
        {
            Console.WriteLine("Tata Bike");
        }
    }
}
