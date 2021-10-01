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

            Console.WriteLine("Hello! Welcome to our calculator!");
            Console.WriteLine("Please enter your first number: ");
            num1 = Convert.IntTo32(Console.ReadLine());

            Console.WriteLine("Now enter your second number: ");
            num2 = Convert.IntTo32(Console.ReadLine());

            Console.ReadKey();
        }

    }
}