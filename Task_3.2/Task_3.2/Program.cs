using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 

             Console.WriteLine("Enter the first number:");
             double num1 = Convert.ToDouble(Console.ReadLine());
           
             Console.WriteLine("Enter the second number:");
             double num2 = Convert.ToDouble(Console.ReadLine());
           
             Console.WriteLine("Enter the arithmetic operation (+, -, *, /):");
             char operation = Convert.ToChar(Console.ReadLine());
           
             double result = 0.0;
           
             switch (operation)
             {
                 case '+':
                     result = num1 + num2;
                     break;
                 case '-':
                     result = num1 - num2;
                     break;
                 case '*':
                     result = num1 * num2;
                     break;
                 case '/':
                     result = num1 / num2;
                     break;
                 default:
                     Console.WriteLine("Operation is not present in the list of allowed operations");
                     return;
             }
           
             Console.WriteLine($"Result: {result}");


            //Task 2

              Console.WriteLine("Enter a number:");
              int a = Convert.ToInt32(Console.ReadLine());
            
              if (a < 50 && a != 37 && a >= 32)
              {
                  Console.WriteLine("Working!");
              }
              else if (a == 0 || a == 15)
              {
                  Console.WriteLine("Partly working!");
              }
              else
              {
                  Console.WriteLine("Doesn't work");
            
              }

            //Task 3
        
            String answer;
            Console.WriteLine("Enter any number: ");
            int number = int.Parse(Console.ReadLine());
        
        
            answer = (number % 2 ==0) ? "The number is even" : " The number is odd";
            Console.WriteLine(answer);
        


        }
    }
}
