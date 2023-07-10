using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesingPattern
{
    internal class TataCar : ICar
    {
        public void GetCar()
        {
            Console.WriteLine("Tata Car");
        }
    }
}
