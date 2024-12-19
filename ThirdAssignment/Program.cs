using System;
using System.Reflection;

namespace ThirdAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
            Passing by Value:
            When a value type parameter is passed by value, a copy of the data is sent to the method. Any changes made to the parameter within the method do not affect the original variable outside the method.

            Passing by Reference:
            When a value type parameter is passed by reference, the method operates on the original data.Any changes made to the parameter within the method directly affect the original variable outside the method.
            */


            /*
           int originalValue = 10;

           static void ModifyByValue(int number)
           {
               number = 20; 
           }

           static void ModifyByReference(ref int number)
           {
               number = 20; 
           }

           Console.WriteLine("Before : " + originalValue);
           ModifyByValue(originalValue);
           Console.WriteLine("After : " + originalValue);

           Console.WriteLine("------Ref------");

           Console.WriteLine("Before : " + originalValue);
           ModifyByReference(ref originalValue);
           Console.WriteLine("After : " + originalValue);


             */
            #endregion


            #region 2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example

            /*
             Passing by Value:
             the method receives a copy of the reference to the object. This means:
             Changes to the object's content will be reflected outside the method because both the original and the copy point to the same memory location.
            
            Passing bby Reference:
            the method receives a reference to the reference itself. This means:
            Changes to the object's content and reassigning the reference to a new object will affect the original reference outside the method
             */


            /*
             static void ModifyByValue(MyClass obj)
            {
                obj.Value = 20; 
                obj = new MyClass { Value = 50 }; 
            }

            static void ModifyByReference(ref MyClass obj)
            {
                obj.Value = 20;  
                obj = new MyClass { Value = 50 }; 
            }

            MyClass originalObject = new MyClass { Value = 10 };

            Console.WriteLine("Before : " + originalObject.Value);
            ModifyByValue(originalObject);
            Console.WriteLine("After : " + originalObject.Value);

            Console.WriteLine("------Ref------");

            Console.WriteLine("Before : " + originalObject.Value);
            ModifyByReference(ref originalObject);
            Console.WriteLine("After : " + originalObject.Value);
             */

            #endregion


            #region  3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


            /*
            static void SUMSub (decimal a, decimal b, decimal c, decimal d , out decimal sum, out decimal sub)
            {
                sum = a + b;
                sub = c - d;
            }
            Console.WriteLine("Enter the first number:");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            decimal b = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            decimal c = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number:");
            decimal d = decimal.Parse(Console.ReadLine());

            decimal sumRes  , subRes ;
            SUMSub(a,b,c,d,out sumRes,out subRes);
            Console.WriteLine($"summation of first two numbers = {sumRes}");
            Console.WriteLine($"subtracion of second two numbers = {subRes}");

            */
            #endregion


            #region  4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            /*
            Console.WriteLine("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Enter a valid integer");
                return;
            }

            int sum = SumOfDigits(number);
            Console.WriteLine($"Sum = {sum}");

            static int SumOfDigits(int number)
            {
                number = Math.Abs(number);  
                int sum = 0;

                while (number > 0)
                {
                    sum += number % 10;  
                    number /= 10;        
                }

                return sum;
            }
            */

            #endregion

            #region 5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            /*
            Console.WriteLine("Enter an integer :");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Please enter a valid integer.");
                return;
            }

            bool result = IsPrime(number);
            Console.WriteLine(result ? "True" : "False");

            static bool IsPrime(int number)
            {
                if (number <= 1)  return false;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }

            */
            #endregion


            #region 6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            /*
            Console.WriteLine("Enter the elements of the array, separated by spaces: ");
            string input = Console.ReadLine();
            string[] inputElements = input.Split(' ');
            int[] array = Array.ConvertAll(inputElements, int.Parse);

            int min = 0, max = 0;
            MinMaxArray(array, ref min, ref max);

            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");

            static void MinMaxArray(int[] array, ref int min, ref int max)
            {
                if (array == null || array.Length == 0)
                {
                    Console.WriteLine("Array cannot be null or empty");
                }

                min = array[0];
                max = array[0];

                foreach (int num in array)
                {
                    if (num < min)
                        min = num;

                    if (num > max)
                        max = num;
                }
            }
            */

            #endregion


            #region 7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            /*
            Console.WriteLine("Enter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Please enter a valid non-negative integer");
                return;
            }
            long result = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is {result}.");

            static long CalculateFactorial(int number)
            {
                long factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }
            */

            #endregion


            #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            /*
            Console.WriteLine("Enter the input string:");
            string input = Console.ReadLine();
            if (input == "" || input == " " || input == null)
            {
                Console.WriteLine("Input cannot be empty");
                return;
            }
            Console.WriteLine("Enter the new character:");
            if (!char.TryParse(Console.ReadLine(), out char newChar))
            {
                Console.WriteLine("Please enter a single character.");
                return;
            }

            int position = 0;

            string result = ChangeChar(input, position, newChar);
            Console.WriteLine("New string: " + result);

            static string ChangeChar(string input, int position, char newChar)
            {
             
                return input.Substring(0, position) + newChar + input.Substring(position + 1);
            }
            */
            #endregion

        }

    }
}
