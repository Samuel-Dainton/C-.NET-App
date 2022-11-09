using System;

// dotnet run (to start program)

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sam Dainton";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appAuthor, appVersion);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

            int correctNumber = 7;

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            //Loop
            while (guess != correctNumber)
            {
                //Get User Input
                string input = Console.ReadLine();

                //Check for number
                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Please enter a number", appName, appAuthor, appVersion);

                    Console.ResetColor();

                    continue;
                }

                guess = Int32.Parse(input);

                //Match guess to correctNumber
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong number! Please try again", appName, appAuthor, appVersion);

                    Console.ResetColor();
                }
            }

            //Success message
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Correct!", appName, appAuthor, appVersion);

            Console.ResetColor();

        }
    }
}
