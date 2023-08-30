using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Tractor : Vehicle, IsSlowInterface
    {
        public void IsSlow()
        {
            Console.WriteLine($"{Name} is really slow");
        }
    }
}
