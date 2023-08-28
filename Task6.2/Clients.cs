using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    public class Clients : Person
    {
        public bool VIP { get; set; } = false;


        public Clients(string name, string lastName, int age,bool vipS)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            VIP = vipS;

        }

        private void TakeLoanz()
        {
            if (VIP == true)
            {
                Console.WriteLine(" Took a loan from the Bank");
            }
            else
            {
                Console.WriteLine(" Can't take the loan");
            }
        }
        public void TakeLoan()
        {
            TakeLoanz();
        }
    }

}
    


