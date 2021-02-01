using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessedNumber = false;

            Console.WriteLine("Welcome to GuessMyNumber! Press ESC to close any time.");

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            cki = Console.ReadKey();


            while (!guessedNumber)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                    Environment.Exit(0);
                
                //else if value entered is not a number then ask for one

                //otherwise check number
            }

            Console.WriteLine("Congrats! You have guessed the number correctly!");
        }
    }
}
