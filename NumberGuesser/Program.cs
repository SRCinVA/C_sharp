using System;

namespace NumberGuesser
{
    class MainClass
    {
        //Entry point for our application
        public static void Main(string[] args)
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
            //ask user's name
            Console.WriteLine("What's your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", inputName);

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
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        // tell user it's not a number
                        Console.WriteLine("Not a number; please try again.");
                        //resets color
                        Console.ResetColor();

                        //keep going
                        continue;
                    }

                    // cast to int and put in guess var
                    guess = Int32.Parse(input);

                    // match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        // tell user it's the wrong number
                        Console.WriteLine("Wrong number; please try again.");
                        //resets color
                        Console.ResetColor();

                    }
                }
                //Output success message here

                //Change text color
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                // tell user it's the right numberw
                Console.WriteLine("Correct! Good job!!");
                //resets color
                Console.ResetColor();

                // ask to play again
                Console.WriteLine("Do you want to plya again? (Y/N)");

                // get the answer
                string answer = Console.ReadLine().ToUpper();

            }

        }
    }
}
