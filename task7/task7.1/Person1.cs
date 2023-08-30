using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public class Person1 : PersonAbstract
    {
        public override string Name { get; set; }
        
        public override void SaysHi()
        {
            Console.WriteLine($"{Name} Waves and says Hi!");
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public void ShowOwnerName()
        {
            Console.WriteLine("Owner name is:" + Name);
        }
    }
}
