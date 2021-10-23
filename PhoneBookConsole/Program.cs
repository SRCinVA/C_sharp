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
            Console.WriteLine("4.) Search for contacts by a given name");
            Console.WriteLine("5.) Type 'x' (no quotes) to exit the program");


            var userInput = Console.ReadLine(); // ... whatever that input is.

            // next, let's do some switch statements

            var phoneBook = new PhoneBook();

            while(true)
            {
                switch (userInput)
                {
                    case "1": // to add a name, take it in from the user
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);  //this creates a new Contact object
                        phoneBook.AddContact(newContact);

                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "x":
                        return; // this terminates the entire program
                                // remember that break statements just drop you out of the while loop.

                    default:
                        Console.WriteLine("Select a valid operation, please.");
                        break;
                }

            }


        }
    }
}
