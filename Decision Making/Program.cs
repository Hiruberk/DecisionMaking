using System;
using System.Linq;

namespace Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string user = Console.ReadLine();
            do
            {

                Console.WriteLine("Please enter an integer between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());

                if (input < 1 || input > 100)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("HEY! That was not what I asked for!");
                }
                else if (input % 2 == 0 && input < 25)
                {
                    Console.WriteLine($"{input} is even and less than 25");
                }
                else if (input % 2 == 0 && input <= 60)
                {
                    Console.WriteLine("Even!");
                }
                else if (input % 2 == 0 && input >= 60)
                {
                    Console.WriteLine($"{input} is Even!");
                }
                else
                {
                    Console.WriteLine($"{input} and odd!");
                }

                Console.WriteLine("Continue? (y/n)");

            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine($" Thank you for playing {user}, goodbye!");

           // Console.WriteLine("Continue? y/n");
        }
    }
}
