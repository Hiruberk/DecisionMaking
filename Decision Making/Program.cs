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

                Console.WriteLine("\nPlease enter an integer between 1 and 100: ");
                int input = int.Parse(Console.ReadLine());

                if (input < 1 || input > 100)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nHEY! That was not what I asked for!!!");
                    Console.ResetColor();
                }
                else if (input % 2 == 0 && input < 25)
                {
                    Console.WriteLine($"\n{user} entered {input}, which is even and less than 25!");
                }
                else if (input % 2 == 0 && input <= 60)
                {
                    Console.WriteLine($"\n{user} entered Even!");
                }
                else if (input % 2 == 0 && input >= 60)
                {
                    Console.WriteLine($"\n{user} entered {input} and is Even!");
                }
                else
                {
                    Console.WriteLine($"\n{user} entered {input} and is odd!");
                }

                Console.WriteLine("\nContinue? (y/n)\n");

            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine($"\n Thank you for playing {user}, goodbye!\n");

           // Console.WriteLine("Continue? y/n");
        }
    }
}
