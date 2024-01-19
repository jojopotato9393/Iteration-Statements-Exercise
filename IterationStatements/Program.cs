using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Net.WebSockets;
using System.Transactions;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
       public static void LongNumber()
        {
       
           

            for (int num = 1000; num >= -1000; num--)
            {
                Console.WriteLine(num);
                
            }
            


           

        }
        



        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        static void Incroment()
        {
            
            for(int num = 3; num <= 999; num += 3)
            {
                Console.WriteLine(num);
            }
          


        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
       public static void IsEqual(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine($"{num1} does equal {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} does not equal {num2}");
            }




        }
        //Write a method to check whether a given number is positive or negative
        public static void EvenOrOdd(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even");
            }
            else
            {
                Console.WriteLine($"{num} is Odd");
            }
        }

        static void PosOrNeg(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num == 0)
            {
                Console.WriteLine($"{num} is nothing ");
            }
            else
            {
                Console.WriteLine($"{num} negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        static void CanVote()
        {
            Console.WriteLine("age?");
            int age =int.Parse(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("old enough");
            }

            else
            {
                Console.WriteLine("nope");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        static void NumberRange()
        {
            Console.WriteLine("enter number");
            var theUser = int.Parse(Console.ReadLine());

            if(theUser >= -10 && theUser <= 10)
            {
                Console.WriteLine("in range");
            }
            else
            {
                Console.WriteLine("not in range");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void Multiply(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i*num}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Incroment();
            LongNumber();

             IsEqual(1, 2);
              EvenOrOdd(3);
            CanVote();


            Multiply(9);
        }

    }
}
