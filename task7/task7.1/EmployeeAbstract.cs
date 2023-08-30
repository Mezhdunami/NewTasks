using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public abstract class EmployeeAbstract
    {
        public int Age { get; set; }
        public abstract string Name { get; set; }

        public abstract void Speaks();
        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
