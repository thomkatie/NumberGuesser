using System;

namespace GuessMyNumber
{
    class Program
    {
        private static int numberToGuess;
        static void Main(string[] args)
        {
            //generate number
            Random rand = new Random();
            numberToGuess = rand.Next(0, 100);

            bool guessedNumber = false;

            Console.WriteLine("Welcome to GuessMyNumber! Press ESC to close any time.");

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            string val = "";
            
            while (!guessedNumber)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                    Environment.Exit(0);
                else
                    val = cki.KeyChar.ToString();

                val = val + Console.ReadLine();

                int guess = -1;
                bool validGuess = int.TryParse(val, out guess);
                
                //check number
                if (validGuess)
                    guessedNumber = CheckNumber(guess);
                else
                    //if value entered is not a number then ask for one
                    Console.WriteLine("Invalid guess! Please enter a number.");
            }

            Console.WriteLine("Congrats! You have guessed the number correctly!");
            Console.WriteLine("Press R to play again, or any other key to exit.");

            cki = Console.ReadKey();
            if (cki.Key != ConsoleKey.R)
                Environment.Exit(0);
            else
                guessedNumber = false;
                Console.Clear();
                Main(args);
        }


        static bool CheckNumber(int guess)
        {
            if (guess == numberToGuess)
                return true;

            if (guess < numberToGuess)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine("Too high!");

            return false;
        }
    }
}
