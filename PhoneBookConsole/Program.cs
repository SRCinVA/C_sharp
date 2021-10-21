using System;

namespace PhoneBookConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Console Phone Book app.");

            Console.WriteLine("Select operation");
            Console.WriteLine("1.) Add Contact");
            Console.WriteLine("2.) Display contact by number");
            Console.WriteLine("3.) View all contacts");
            Console.WriteLine("Search for contacts by a given name");

            var userInput = Console.ReadLine(); // ... whatever that input is.

            // next, let's do some switch statements

            var phoneBook = new PhoneBook();

            switch (userInput)
            {
                case "1": // to add a name
                    Console.WriteLine("Contact name:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Contact number:");
                    var number = Console.ReadLine();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                default:
                    Console.WriteLine("Select a valid operation, please.");
                    break;



            }


        }
    }
}
