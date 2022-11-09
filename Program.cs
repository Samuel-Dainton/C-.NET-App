using System;

// dotnet run (to start program)

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                // Generate a random number between 1 & 10
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

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
                        PrintColorMessage(ConsoleColor.Red, "Please use a number.");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    //Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again.");
                    }
                }

                //Success message
                PrintColorMessage(ConsoleColor.Green, "Correct!");

                //Play again?
                Console.WriteLine("Would you like to play again? [ Y/N ]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sam Dainton";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appAuthor, appVersion);

            Console.ResetColor();
        }
        // Ask for user info
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

        }
        // Prints a color message and resets the color. Takes two arguments of ConsoleColor.(color choice) & "Message"
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
