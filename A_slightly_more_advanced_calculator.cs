using System;

namespace Calculator
{
    class Program {

        static void Main(){
            
            int num1;
            int num2;
            int result;

            string answer;

            Console.WriteLine("Hello! Welcome to our calculator!");
            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Now enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Press 'a' for addition, 's' for subtraction, 'm' for multiplication, and any other key for division.");

            answer = Console.ReadLine();  // no need to cast this from being a string.

            if (answer == "a")
            {
                result = num1 + num2;
            }

            else if (answer == "s")
            {
                result = num1 - num2;
            }

            else if (answer == "m")
            {
                result = num1 * num2;
            }

            else // if we used an else it statement, then nothing would actually be calculated (it seems?)
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thank you for using this calculator program.");

            Console.ReadKey();

        }

    }
}