using System;
using System.Collections.Generic;
using System.Linq;
using SystemText;
using SystemThreading.Tasks;
using System.Math;

public class Program
{
	public static void Main()
	{

        String inputPlayer, inputCPU;
        int randomInt;

        Console.WriteLine("Choose between rock, paper, or scissor.")
        inputPlayer = Console.ReadLine();

        Random rnd = new Random();

        randomInt = rnd.Next(1,4);  // randomInt is equal to the next random number (perhaps recursive).
                                    // bounded between 1 and 4.
        switch (randomInt)
        {
            case 1:
                inputCPU = "rock";
                Console.WriteLine("The CPU chose 'rock'")
                if (inputPlayer == 'rock')
                {
                    Console.WriteLine("It's a tie!\n\n");
                }

                else if (inputPlayer == 'paper')
                {
                    Console.WriteLine("The player wins this round!\n\n");
                }

                else (inputPlayer == 'scissors')
                {
                    Console.WriteLine("The CPU wins this round!\n\n");
                }

                default:
                {
                    Console.WriteLine("I'm afraid that's an invalid entry ...")
                }

                break;

            case 2:
                inputCPU = "paper";
                Console.WriteLine("The CPU chose 'paper'")
                if (inputPlayer == 'rock')
                {
                    Console.WriteLine("The CPU won this round!\n\n");
                }

                else if (inputPlayer == 'paper')
                {
                    Console.WriteLine("It's a tie!\n\n");
                }

                else (inputPlayer == 'scissors')
                {
                    Console.WriteLine("The player won this round!");
                }

                default:
                {
                    Console.WriteLine("I'm afraid that's an invalid entry ...")
                }

                break;

                break;

            case 3:
                inputCPU = "scissors";
                Console.WriteLine("The CPU chose 'scissors'")
                if (inputPlayer == 'rock')
                {
                    Console.WriteLine("The player won this round!\n\n");
                }

                else if (inputPlayer == 'paper')
                {
                    Console.WriteLine("The CPU wins this round!\n\n");
                }

                else (inputPlayer == 'scissors')
                {
                    Console.WriteLine("This round was a tie!\n\n");
                }

                default:
                {
                    Console.WriteLine("I'm afraid that's an invalid entry ...")
                }

                break;

                break;

        }
                                


	}
}