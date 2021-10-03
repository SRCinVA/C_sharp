using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program {

        static void Main(string[] args){
            
            int num1;
            int num2;
            float result;

            string answer;

            Console.WriteLine("Hello! Welcome to our calculator!");
            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.IntTo32(Console.ReadLine());
        

            Console.WriteLine("Now enter your second number: ");
            num2 = Convert.IntTo32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Press 'a' for addition, 's' for subtraction, 'm' for multiplication, and 'd' for division.");

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

            else (answer == "d")
            {
                result = num1/num2;
            }


            Console.ReadKey();



        }

    }
}