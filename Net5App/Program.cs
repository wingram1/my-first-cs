using System;

namespace Net5App
{
    internal class Program
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /* Get Name */
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            /* Get Age */
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int age = 0;
            try
            {
                age = Math.Abs(Int32.Parse(ageInput)); 
            }
            catch
            {
                Console.WriteLine("You dingus that's not a number! Setting your age to 0. Deal with it.");
            }

            Console.WriteLine($"{age}? Dang you're getting up there!");

            Console.Read();
        }
    }
}
