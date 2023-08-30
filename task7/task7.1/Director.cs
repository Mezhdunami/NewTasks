using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public class Director : EmployeeAbstract
    {
        public override string Name { get; set; }
        public string Position { get; set; }
        
        public override void Speaks()
        {
            Console.WriteLine($"{Name} is talking");
        }
        public void SetPosition(string position)
        {
            Position = position;
            Console.WriteLine($"{Name} is in a {Position}'s position");
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
