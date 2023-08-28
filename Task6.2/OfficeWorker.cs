using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    public class OfficeWorker:Employees
    {
        public string position1 { get; set; } = "Accountant";
        public string position2 { get; set; } = "Director"; 

        public void Position()
        {
            Console.WriteLine(Name + " is an " + position1);
        }
      



    }
}
