using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();
            Task9();
            Task10();
            Task11(); 

            






        } public static void Task1()
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
        }

        public static void Task2()
        {
            int number = 3;
            int multiplier = 1;

            while (multiplier <= 10)
            {
                int result = number * multiplier;

                Console.WriteLine($"{number} x {multiplier} = {result}");
                multiplier++;
            }

            
        }
        public static void Task3()
        {
            int[] numbers = { 3, 5, 9, 8, 15 }; // Creating an array of numbers

            int product = 1; // Initializing a variable to store the product of the numbers, starting with 1

            foreach (int num in numbers)
            {
                product *= num; // Multiplying each number in the array with the current product
            }

            Console.WriteLine("The product of the numbers is: " + product);
        }

       
            public static void Task4()
        {

            int number = 2048;
            int count = 0;

            while (number >= 10)
            {
                number /= 2;
                count++;
            }

            Console.WriteLine($"2048 must be divided by 2 {count} times to make it less than 10.");
        }

        public static void Task5()
        {
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
        }

        public static void Task6()
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 20 };
            int sum = numbers[0] + numbers[numbers.Length - 1]; ;
            Console.WriteLine("Sum of the first and last numbers: " + sum);
        }

    public static void Task7()
    {
            // Create an array of numbers
            int[] numbers = { 3, 8, 2, 9, 5, 1, 7 };

            // Find the minimum and maximum elements and their indexes
            int min = numbers[0];
            int max = numbers[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }

            // Calculate the sum of the indexes of the minimum and maximum elements
            int sumOfIndexes = minIndex + maxIndex;

            // Display the results
            Console.WriteLine("Array: " + string.Join(", ", numbers));
            Console.WriteLine("Minimum element: " + min + " at index " + minIndex);
            Console.WriteLine("Maximum element: " + max + " at index " + maxIndex);
            Console.WriteLine("Sum of indexes: " + sumOfIndexes);
        }

    public static void Task8()
    {


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

            

        }
        public static void Task9()
        {
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




            }
        }

        public static void Task10()
        {
            // Create a two-dimensional array containing numbers from 1 to 9
            int[,] numbers = new int[,]
            {
                  { 1, 2, 3 },
                  { 4, 5, 6 },
                  { 7, 8, 9 }
            };

            // Loop through the rows of the array
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                // Loop through the columns of the array
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();





            }
        }

        public static void Task11()
        {
            // Create the initial array
            int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 1. Add the number 11 to the end of the array
            int[] newArray1 = new int[array1.Length + 1];
            for (int i = 0; i < array1.Length; i++)
            {
                newArray1[i] = array1[i];
            }
            newArray1[array1.Length] = 11;

            // 2. Add the number -1 to the beginning of the array
            int[] newArray2 = new int[array1.Length + 1];
            newArray2[0] = -1;
            for (int i = 1; i < newArray2.Length; i++)
            {
                newArray2[i] = array1[i - 1];
            }

            // 3. Add number 12 to position 4
            int[] newArray3 = new int[array1.Length + 1];
            for (int i = 0; i < 4; i++)
            {
                newArray3[i] = array1[i];
            }
            newArray3[4] = 12;
            for (int i = 4; i < array1.Length; i++)
            {
                newArray3[i + 1] = array1[i];
            }

            // 4. Remove the first element of the array
            int[] newArray4 = new int[array1.Length - 1];
            for (int i = 1; i < array1.Length; i++)
            {
                newArray4[i - 1] = array1[i];
            }

            // 5. Creating an array from two arrays: array1 and array2
            int[] array2 = { 100, 200, 300 };
            int[] combinedArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                combinedArray[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                combinedArray[array1.Length + i] = array2[i];
            }

            // Print the results
            Console.WriteLine("New Array 1:");
            Console.WriteLine(string.Join(", ", newArray1));
            Console.WriteLine("\nNew Array 2:");
            Console.WriteLine(string.Join(", ", newArray2));
            Console.WriteLine("\nNew Array 3:");
            Console.WriteLine(string.Join(", ", newArray3));
            Console.WriteLine("\nNew Array 4:");
            Console.WriteLine(string.Join(", ", newArray4));
            Console.WriteLine("\nCombined Array:");
            Console.WriteLine(string.Join(", ", combinedArray));
        }
    }

}




   
   






