using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 Task

            int num = 20;
            num += 5;

            Console.WriteLine("Variable: " + num); //

            //2 Task

            Console.WriteLine("Enter a 4 Digit Number: ");
            int allDays = int.Parse(Console.ReadLine());

            //Calculate the years, months, and days
            int years = allDays / 365;
            int remainingDays = allDays % 365;
            int months = remainingDays / 30;
            int days = remainingDays % 30;

            // Output the result to the console
            Console.WriteLine($"Equivalent: {years} years and {months} months and {days} days");


            //Task 3 

            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            int actRes = (number * 2) + number;
            Console.WriteLine(number +" + "+number +" * 2"+" = "+actRes);

            //Task 4 

            short a = -34; //int: Represents signed 32-bit integers, which can store values from -2,147,483,648 to 2,147,483,647, including 0.//
            byte b = 4;//int: Represents signed 32-bit integers, which can store values from -2,147,483,648 to 2,147,483,647, including 0.
            String c = "Hello";//string - stores text, such as "Hello World". String values are surrounded by double quotes
            char d = 'R'; // stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            double e = 23.093433222; //stores floating point numbers, with decimals, such as 19.99 or -19.99
            int f = 40000;//int: Represents signed 32-bit integers, which can store values from -2,147,483,648 to 2,147,483,647, including 0.//
            bool g = true; //stores values with two states: true or false
            int h = 0;//int: Represents signed 32-bit integers, which can store values from -2,147,483,648 to 2,147,483,647, including 0.//

            //Task 5
            Console.WriteLine("Enter a Number: ");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }







        }


    }
}

