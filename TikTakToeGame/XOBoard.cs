using System;

namespace TikTakToeGame
{
    public class XOBoard
    {
        private char[] square; // character array to represent the board game
        private readonly char[] mark; // represents X and O marks
        private int player; // player(1)- X , player(2)- O
        public XOBoard()
        {
            square = new char[] { 'o', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            mark = new char[] { ' ','X', 'O' };
            player = 1;
        }

        /****************************************
        set the board with the correct character,
        x or o in the correct spot in the array 
        *****************************************/
        public bool Put(int player, int choice)
        {
            bool isEmptySquare = true;

            this.player = player;

            if (choice == 1 && square[1] == '1')
                square[1] = mark[player];

            else if (choice == 2 && square[2] == '2')
                square[2] = mark[player];

            else if (choice == 3 && square[3] == '3')
                square[3] = mark[player];

            else if (choice == 4 && square[4] == '4')
                square[4] = mark[player];

            else if (choice == 5 && square[5] == '5')
                square[5] = mark[player];

            else if (choice == 6 && square[6] == '6')
                square[6] = mark[player];

            else if (choice == 7 && square[7] == '7')
                square[7] = mark[player];

            else if (choice == 8 && square[8] == '8')
                square[8] = mark[player];

            else if (choice == 9 && square[9] == '9')
                square[9] = mark[player];

            else
                isEmptySquare = false;

            return isEmptySquare;
        }

        /****************************************
        function to return game status
        X - X won
        O - O won 
        None - game is in progress        
        Draw - game is over and no result
       *****************************************/
        public string Status()
        {
            string status;
            if (isPlayerWon())
            {
                status= (this.player == 1) ? "X" : "O";
            }

            else if (isDraw())
                status = "Draw";

            else
                status = "None";

            return status;
        }

        public void Display()
        {
            Console.Clear();

            Console.WriteLine("\n\n\tTic Tac Toe Game\n");
            Console.WriteLine("   Player 1 (X)  -  Player 2 (O)\n\n");

            Console.WriteLine("              |     |     ");
            Console.WriteLine("            {0} |  {1}  | {2} ", square[1], square[2], square[3]);
            Console.WriteLine("         _____|_____|_____");
            Console.WriteLine("              |     |     ");
            Console.WriteLine("            {0} |  {1}  | {2} ", square[4], square[5], square[6]);
            Console.WriteLine("         _____|_____|_____");
            Console.WriteLine("              |     |     ");
            Console.WriteLine("            {0} |  {1}  | {2} ", square[7], square[8], square[9]);
            Console.WriteLine("              |     |     \n");
        }

        /****************************************
        check for horizontal, vertical and diagonal matches
        *****************************************/
        private bool isPlayerWon()
        {
            bool returnValue = false;

            if (square[1] == square[2] && square[2] == square[3])
                returnValue = true;

            else if (square[4] == square[5] && square[5] == square[6])
                returnValue = true;

            else if (square[7] == square[8] && square[8] == square[9])
                returnValue = true;

            else if (square[1] == square[4] && square[4] == square[7])
                returnValue = true;

            else if (square[2] == square[5] && square[5] == square[8])
                returnValue = true;

            else if (square[3] == square[6] && square[6] == square[9])
                returnValue = true;

            else if (square[1] == square[5] && square[5] == square[9])
                returnValue = true;

            else if (square[3] == square[5] && square[5] == square[7])
                returnValue = true;

            return returnValue;
        }

        /****************************************
        check if all the squares are marked   
        *****************************************/
        private bool isDraw()
        {
            if(square[1] != '1' && square[2] != '2' && square[3] != '3' && 
                square[4] != '4' &&  square[5] != '5' && square[6] != '6' && 
                square[7] != '7' &&  square[8] != '8' &&  square[9] != '9')
            {
                return true;
            }
               
            return false;
        }
    }
}




