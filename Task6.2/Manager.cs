using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    sealed class Manager:Employees
    {
       
  
        public void FiresPerson(OfficeWorker officeWorker)
        {
            
            Console.WriteLine(Name + " Fires - " + officeWorker.Name);
        }
    }
}
