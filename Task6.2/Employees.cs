using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    public class Employees:Person
    {


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
