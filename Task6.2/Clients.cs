using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    public class Clients : VIPP
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Clients(string name, string lastName, int age,bool vipS)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            VIP = vipS;

        }

        public void TakeLoan()
        {
            Console.WriteLine(Name+" Took a loan from the bank");
        }


    }
    }


