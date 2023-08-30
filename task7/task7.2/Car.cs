using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Car : Vehicle, IsFastInterFace, IsSlowInterface
    {
        public void Isfast()
        {
            Console.WriteLine($"{Name} is really fast");
        }

        public void IsSlow()
        {
            Console.WriteLine($"{Name} is really slow");
        }
    }
}
