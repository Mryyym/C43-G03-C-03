using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace FirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first question
            //1- Write a program that allows the user to enter a number then print it.

            /*
             Console.WriteLine("Please enter a number:");
             int user_input=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Your Input is " + user_input);
            */
            #endregion

            #region Second Question
            //2-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            /*
            string Myname = "Mariam";
            string NewName = Myname;
            Console.WriteLine("Your old Name is: "+ Myname+ " Your New name is: "+NewName);
            Console.WriteLine("----------------");
            Myname = "Fayrouz";
            Console.WriteLine("Your old Name is: " + Myname + " Your New name is: " + NewName);
            */

            /*
             What will happen : 
            changing the value of one does not affect the other because each is stored independently; 
             */

            #endregion


            #region Third Qustion
            //3-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            /*
            person person1 = new person();

            person1.address = "Maadi";

            person person2 = person1;

            Console.WriteLine("person2.address: "+person2.address +"  "+ "person2.address: "+ person1.address);
            Console.WriteLine("================");

            person1.address = "Zamalek";

            Console.WriteLine("person2.address: " + person2.address + "  " + "person2.address: " + person1.address);
            */

            /*
             What will happen : 
            changing the value of one affects the other because 
            reference types store references to the same object in memory; 
             */

            #endregion

        }
    }
}
