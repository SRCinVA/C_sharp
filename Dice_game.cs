using System;

namespace Dice_game{

    class Program{

        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;  //initialized to zero.
            int enemyPoints = 0;

            Random random = new Random(); /* the constructor for new random numbers */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                
                Console.ReadKey();
                playerRandomNum = random.Next(1,7); /* inclusive lower bound but exclusive upper bound*/
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1,7); /* inclusive lower bound but exclusive upper bound*/
                Console.WriteLine("Your evil AI opponent rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum){
                    playerPoints++;
                    Console.WriteLine("The player wins this round!!");
                }
                
                else if(playerRandomNum < enemyRandomNum){
                    enemyPoints++;
                    Console.WriteLine("The evil AI wins this round!!");
                }
                
                else{
                    Console.WriteLine("It's a tie!")
                }

            }
            Console.ReadKey(); // to prevent the window closing as soon as the program executes.

        }
    }
}
