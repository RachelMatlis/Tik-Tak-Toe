using System;

namespace TikTakToeGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            XOBoard game = new XOBoard();
            int input = 1, player = 1; // player(1)- X , player(2)- O

            game.Display();

            while(game.Status() == "None") // not all squares are marked
            {
                // set player
                player = (player % 2 != 0) ? 1 : 2;

                // get input
                Console.WriteLine("Player {0}, enter a number:", player);

                // check input validation
                bool isNumericInput = int.TryParse(Console.ReadLine(), out input);

                if (isNumericInput && (input >= 1 && input <= 9))
                {
                    // try to mark board
                    bool isPutSucceed = game.Put(player, input);

                    if (isPutSucceed)
                        player++; // change player turn 

                    else // square is already marked
                        invalidInputMsg();
                }
                else // invalid input
                    invalidInputMsg();

                game.Display();
            }

            string gameStatus = game.Status();

            if(gameStatus == "Draw")
                Console.WriteLine("==> Game draw");
            else // game has a winner
                Console.WriteLine("==> Player {0} win", gameStatus);
        }

        private static void invalidInputMsg()
        {
            Console.WriteLine("Invalid move - Press Enter and try again");
            Console.ReadKey();
        }
    }
}
