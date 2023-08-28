using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    public class Employees
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

  

        public void EmployeeOfTheMonth()
        {
            Console.WriteLine(Name + " Is an employee of the month");
        }

        public void QuitJob()
        {
            Console.WriteLine(Name + " Quit his job");
        }
    }

   
}
