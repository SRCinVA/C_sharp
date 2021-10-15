using System;

namespace NumberGuesser
{
    class MainClass
    {
        //Entry point for our application
        public static void Main(string[] args)
        {
            //Get app info (obviously)
            GetAppInfo();

            Greeting();

            while (true)
            {
                // Set correct number
                //int correctNumber = 7;

                //create a new random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10); // the random objects generates a random number

                //init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10.");

                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // validate input by converting from string to int; will tell us if failed
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going
                        continue;
                    }

                    // cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Wrong number! Please try again.");
                    }
                }
                //Output success message here
                PrintColorMessage(ConsoleColor.DarkBlue, "Correct!");

                // ask to play again
                Console.WriteLine("Do you want to play again? (Y/N)");

                // get the answer
                string answer = Console.ReadLine().ToUpper();

                // check if yes or no
                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    Console.WriteLine("Thank you for playing! Goodbye!");
                    return;
                }

                else
                {
                    return;
                }

            }

        }
        // States app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string Version = "1.0.0";
            string appAuthor = "Brad Traversy";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, Version, appAuthor);
            //resets color
            Console.ResetColor();

        }
        //Ask user's name
        static void Greeting()
        {
            //ask user's name
            Console.WriteLine("What's your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;
            // tell user it's not a number
            Console.WriteLine(message);
            //resets color
            Console.ResetColor();
        }
    }
}
