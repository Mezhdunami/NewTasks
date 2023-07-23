using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 

              Console.WriteLine("Enter a positive number:");
              int number = int.Parse(Console.ReadLine());
            
              if (number < 0)
              {
                  Console.WriteLine("Please enter a positive number.");
                  return;
              }
            
              int sum = 0;
              for (int i = 0; i <= number; i++)
              {
                  sum += i;
              }
            
              Console.WriteLine($"The sum of numbers from 0 to {number} is: {sum}");

            //Task 2

             int number = 3;
             int multiplier = 1;
            
             while (multiplier <=10)
             {
                 int result = number * multiplier;
            
                 Console.WriteLine($"{number} x {multiplier} = {result}");
                 multiplier++;
             }

            //Task 3

             int[] numbers = { 3, 5, 9, 8, 15 }; // Creating an array of numbers
            
             int product = 1; // Initializing a variable to store the product of the numbers, starting with 1
            
             foreach (int num in numbers)
             {
                 product *= num; // Multiplying each number in the array with the current product
             }
            
             Console.WriteLine("The product of the numbers is: " + product);

            //Task 4

            int number = 2048;
            int count = 0;
           
            while (number >= 10)
            {
                number /= 2;
                count++;
            }
           
            Console.WriteLine($"2048 must be divided by 2 {count} times to make it less than 10.");

            //Task 5

            // Creating an array of strings
             string[] words = { "Hi", "Hello", "Hey", "Hola", "Bonjour" };
            
            // // Using a foreach loop to iterate through each string in the array
             foreach (string word in words)
             {
                 if (word == "Hello")
                 {
                     Console.WriteLine("Labas!"); // Displaying "Labas!" if the word "Hello" is found
                     break; // Exiting the loop once "Hello" is found
                 }
            
            
             }

            //Task 6

             int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 20};
             int sum = numbers[0] + numbers[8] ;
             Console.WriteLine("Sum of the first and last numbers: " + sum);

            //Task 7
             int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 20 };
            
             int maxNumber = numbers.Max(); // Finding the maximum number in the array using Max()
             int minNumber = numbers.Min(); // Finding the minimum number in the array using Min()
             int sum = maxNumber + minNumber;
             Console.WriteLine("Biggest number "+maxNumber+" + "+"Lowest number "+minNumber+" = "+sum);


            //Task 8

               int[] numbers = { 5, 8, 2, 10, 3, 7 }; // Creating an array of numbers
            
               // Implementing Bubble Sort to sort the elements in ascending order
               for (int i = 0; i < numbers.Length - 1; i++)
               {
                   for (int j = 0; j < numbers.Length - i - 1; j++)
                   {
                       if (numbers[j] > numbers[j + 1])
                       {
                           // Swapping the elements if they are in the wrong order
                           int temp = numbers[j];
                           numbers[j] = numbers[j + 1];
                           numbers[j + 1] = temp;
                       }
                   }
               }
            
               // Printing the sorted array
               Console.WriteLine("Sorted Array:");
               foreach (int num in numbers)
               {
                   Console.Write(num + " ");
            
            
            
               }


            //Task 9

            // // Loop through numbers from 1 to 10
             for (int i = 1; i <= 10; i++)
             {
                 // Loop through multipliers from 1 to 10 for each number
                 for (int j = 1; j <= 10; j++)
                 {
                     int result = i * j;
                     Console.WriteLine($"{i} x {j} = {result}");
                 }
                 Console.WriteLine(); // Add a new line after printing the table for each number


            //Task 10

            // Create a two-dimensional array containing numbers from 1 to 9
             int[,] numbers = new int[3, 3]
             {
             { 1, 2, 3 },
             { 4, 5, 6 },
             { 7, 8, 9 }
             };
           
            //  // Loop through the rows of the array
              for (int row = 0; row < 3; row++)
              {
                  // Loop through the columns of the array
                  for (int col = 0; col < 3; col++)
                  {
                      Console.Write(numbers[row, col] + " ");
                  }
                  Console.WriteLine();
            

            //Task 11
            int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. Add the number 11 to the end of the array
            Array.Resize(ref array1, array1.Length + 1);
            array1[array1.Length - 1] = 11;

            // 2. Add the number -1 to the beginning of the array
            Array.Resize(ref array1, array1.Length + 1);
            Array.Copy(array1, 0, array1, 1, array1.Length - 1);
            array1[0] = -1;

            // 3. Add number 12 to position 4
            Array.Resize(ref array1, array1.Length + 1);
            Array.Copy(array1, 4, array1, 5, array1.Length - 5);
            array1[4] = 12;

            // 4. Remove the first element of the array
            Array.Copy(array1, 1, array1, 0, array1.Length - 1);
            Array.Resize(ref array1, array1.Length - 1);

            // 5. Creating an array from two arrays
            int[] array2 = { 100, 200, 300 };
            int[] resultArray = new int[array1.Length + array2.Length];
            Array.Copy(array1, resultArray, array1.Length);
            Array.Copy(array2, 0, resultArray, array1.Length, array2.Length);

            // Print the resulting array
            Console.WriteLine("Resulting array:");
            foreach (int num in resultArray)
            {
                Console.Write(num + " ");
            }

            



        }
        }
    }


    

