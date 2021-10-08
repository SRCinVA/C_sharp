using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;  // putting the scores here resets them to zero.
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Choose between rock, paper, or scissors.");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1,4);  // randomInt is equal to the next random number (perhaps recursive).
                                                // bounded between 1 and 4.
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("The CPU chose 'rock'");
                            if (inputPlayer == "rock")
                            {
                                Console.WriteLine("It's a tie!\n\n");
                            }

                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("The player wins this round!\n\n");
                                scorePlayer++;
                            }

                            else if(inputPlayer == "scissors")
                            {
                                Console.WriteLine("The CPU wins this round!\n\n");
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("The CPU chose 'paper'");
                            if (inputPlayer == "rock")
                            {
                                Console.WriteLine("The CPU won this round!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("It's a tie!\n\n");
                            }

                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("The player won this round!\n\n");
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("The CPU chose 'scissors'");
                            if (inputPlayer == "rock")
                            {
                                Console.WriteLine("The player won this round!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("The CPU wins this round!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("This round was a tie!\n\n");
                            }
                            break;

                        default:
                            Console.WriteLine("I'm afraid that's an invalid entry ...");
                            break;
                    }        

                    Console.WriteLine("\n\nSCORES:\tPlayer:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);

                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("The player has won!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("The CPU has won!!");
                }
                else
                {

                }
                
                Console.WriteLine("Would you like to play again? (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}