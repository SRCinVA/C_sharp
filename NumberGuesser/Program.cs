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

            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", input);

            // Set correct number
            int correctNumber = 7;

            //init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");



        }
    }
}
