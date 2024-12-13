using System;

namespace SecondAssignment
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            #region 1
            /*
             * Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            */

            ///////////Answer

            /*
            Console.WriteLine("Enter Your Input .. ");
         
            bool res = int.TryParse(Console.ReadLine(),out int num);
            
             if(res== true)
            {
                if ( num % 3 == 0 && num % 4 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("please enter an integer");
            }
            */
            #endregion#region


            #region 2
            /*
Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            */

            //////////ANSWR
            /*
            Console.WriteLine("Enter Your Input .. ");

            bool res = decimal.TryParse(Console.ReadLine(), out decimal num);

            if (res == true)
            {
                if (num < 0 )
                {
                    Console.WriteLine("NEGATIVE");
                }
                else if (num > 0) 
                {
                    Console.WriteLine("POSITIVE");
                }
                else
                {
                    Console.WriteLine("ZERO");

                }
            }
            else
            {
                Console.WriteLine("please enter a NUMBER");
            }
            */
            #endregion#region


            #region 3
            /*
Write a program that takes 3 integers from the user then prints the max element and the min element.            */

            //////ANSWER
            ///
            /*
            Console.WriteLine("enter first number");
            bool res1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("enter second number");
            bool res2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("enter third number");
            bool res3 = int.TryParse(Console.ReadLine(), out int num3);

            if (res1==true && res2 == true && res3 == true)
            {
                if (num1 > num2 && num2 > num3)
                {
                   
                     Console.WriteLine("Max element= " + num1);


                }
                else if (num1< num2 && num2 > num3)
                {
                    Console.WriteLine("Max element= " + num2);
                }
                else
                {
                    Console.WriteLine("Max element= " + num3);
                }
                //
                if (num1 < num2 && num2 < num3)
                {

                    Console.WriteLine("Min element= " + num1);
                    

                }
                else if (num1 > num2 && num2< num3)
                {
                    Console.WriteLine("Min element= " + num2);

                }
                else
                {
                    Console.WriteLine("Min element= " + num3);
                }
            }
            else
            {
                Console.WriteLine("Enter valid numbers");
            }
            */
            #endregion#region


            #region 4
            /*
Write a program that allows the user to insert an integer number then check If a number is even or odd.
            */
            /////ANSWER

            /*
            Console.WriteLine("enter your input");
            bool res = int.TryParse(Console.ReadLine(), out int num);
            if (res==true)
            {
                if (num % 2 == 0) Console.WriteLine("EVEN");
                else Console.WriteLine("ODD");
            }
            else
            {
                Console.WriteLine("PLEASE ENTER A VALID NUMBER");
            }

            */
            #endregion#region


            #region 5
            /*
Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            */

            ////ANSWER

            /*
            Console.WriteLine("ENTER A CHARACTER");

            string input = Console.ReadLine();

            if (input.Length == 1) 
            {
                //char character = input[0]; 

                char character = (char) input;// input.ToString().ToLower();

                if (char.IsDigit(input)) 
                {
                    Console.WriteLine("PLEASE ENTER A CHARACTER, NOT A NUMBER");
                }
                else
                {
                    string ltr = character.ToString().ToLower();

                    if (ltr == "a" || ltr == "i" || ltr == "e" || ltr == "o" || ltr == "u") 
                    {
                        Console.WriteLine("VOWEL");
                    }
                    else
                    {
                        Console.WriteLine("CONSONANT");
                    }
                }
            }
            else
            {
                Console.WriteLine("PLEASE ENTER A SINGLE CHARACTER");
            }
            */


            #endregion#region 


            #region 6
            /*
Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            */

            ////ANSWER
            /*
            Console.Write("Enter an integer: ");
            bool res = int.TryParse(Console.ReadLine(), out int number);

            if (res == true)
            {
                Console.WriteLine($"Multiplication for Table {number}:");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("NOT A VALID NUMBER");
            }
        */

            #endregion#region


            #region 7
            /*
    9- Write a program that takes two integers then prints the power.
            */

            /////ANSWER


            /*
            Console.Write("Enter the base number: ");
            bool resBase = int.TryParse(Console.ReadLine(),out int baseNumber);

            Console.Write("Enter the exponent: ");
            bool resExponent = int.TryParse(Console.ReadLine(),out int exponent);
            if (resBase == true && resExponent == true) 
            {
                double result = Math.Pow(baseNumber, exponent);
                Console.WriteLine(result);

            }

            */
            #endregion#region

            #region 8
            /*
    Write a program to enter marks of five subjects and calculate total, average and percentage.
            */

            ////ANSWER

            /*
             int[] subject = new int[5];
            int total = 0;

            for (int i = 0; i < subject.Length; i++)
            {
                Console.Write($"Enter Mark for subject {i + 1}: ");
                subject[i] = int.Parse(Console.ReadLine());

                if (subject[i] < 0 || subject[i] > 100)
                {
                    Console.WriteLine("Mark should be between 0 and 100. Please enter again.");
                    i--; 
                    continue;
                }

                total += subject[i];
            }

            double average = total / 5;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Percentage: {percentage}%");
            */
            #endregion#region


            #region 9
            /*
    Write a program to input the month number and print the number of days in that month.            */

            ////ANSWER

            /*
            Console.Write("Enter month number (1-12): ");
            int month = int.Parse(Console.ReadLine());

            int monthDays;

            switch (month)
            {
                case 1:
                    goto case 12;
                case 3:
                    goto case 12;

                case 5:
                    goto case 12;

                case 7:
                    goto case 12;

                case 8:
                    goto case 12;

                case 10:
                    goto case 12;

                case 12:
                    monthDays = 31;
                    break;
                case 4:
                    goto case 11;

                case 6:
                    goto case 11;

                case 9:
                    goto case 11;

                case 11:
                    monthDays = 30;
                    break;
                case 2:
                    monthDays = 28;  
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    return;
            }

            Console.WriteLine($"The month {month} has {monthDays} days.");
            */

            #endregion#region


            #region 10
            /*
    Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            */

            ///ANSWER

            /*
            Console.WriteLine("Enter the values of the first point :");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the values of the second point :");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the values of the third point :");
            Console.Write("x3 = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double area = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;

            if (area == 0)
            {
                Console.WriteLine("The points are on straight line");
            }
            else
            {
                Console.WriteLine("The points are not on straight line");
            }
            */
            #endregion#region


            #region 11
            /*
    Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
    - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
    - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
    - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
    - If the worker takes more than 5 hours, they are required to leave the company. 
    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */

            //////ANSWER

            /*
            Console.Write("Enter the time taken to complete task: ");
             bool res = double.TryParse(Console.ReadLine(), out double timeTaken);
            if (res == true)
            {
                if (timeTaken >= 2 && timeTaken <= 3)
                {
                    Console.WriteLine("The worker is highly efficient");
                }
                else if (timeTaken > 3 && timeTaken <= 4)
                {
                    Console.WriteLine("The worker is advised to increase their speed");
                }
                else if (timeTaken > 4 && timeTaken <= 5)
                {
                    Console.WriteLine("The worker will be provided with training to enhance his speed");
                }
                else if (timeTaken > 5)
                {
                    Console.WriteLine("The worker is required to leave the company");
                }
                else
                {
                    Console.WriteLine("Please enter a time of at least 2 hours");
                }

            }
            else
            {
                Console.WriteLine("Enter a number plase");
            }
            */


            #endregion#region


            #region 12
            /*
    Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            */

            /////ANSWER

            /*
            int number1 = 10;
            int number2 = number1;
            Console.WriteLine($"number1 = {number1}");
            Console.WriteLine($"number2 = {number2}");

            number1 = 20;

            Console.WriteLine("=================================");
            Console.WriteLine($"number1 = {number1}");
            Console.WriteLine($"number2 = {number2}");

           
          ////-->> Modifying number1 does not affect number2 because value types store copies of the data, not references
          */
            #endregion#region


            #region 13
            /*
    Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            */

            ////ANSWER

            /*
            Person person1 = new Person { Name = "ahmed" };

            Person person2 = person1;

            Console.WriteLine("Before modification:");
            Console.WriteLine($"person1.Name = {person1.Name}");
            Console.WriteLine($"person2.Name = {person2.Name}");

            person2.Name = "zoz";

            Console.WriteLine("===============================");
            Console.WriteLine($"person1.Name = {person1.Name}");
            Console.WriteLine($"person2.Name = {person2.Name}");

           /////--->>Modifying the object through one variable affects the other variable because both variables point to the same object in memory

            */
            #endregion#region


            #region 14
            /*
    Which of the following statements is correct about the C#.NET code snippet given below?

            int d; 
    d = Convert.ToInt32( !(30 < 20) );
            */

            /// ANSWER --->> b)A value 1 will be assigned to d.

            #endregion#region


            #region 15
            /*
    Which of the following is the correct output for the C# code given below?
           
            Console.WriteLine(13 / 2 + " " + 13 % 2);     
            */

            /// ANSWER --->>> d) 6 1

            #endregion#region



            #region 16
            /*
    What will be the output of the C# code given below?
      
   int num = 1, z = 5;
    if (!(num <= 0))
    Console.WriteLine( ++num + z++ + " " + ++z ); 
    else
    Console.WriteLine( --num + z-- + " " + --z ); 
             */

            /// ANSWER --->>> d) 7 7



            #endregion#region


        }


    }
}
