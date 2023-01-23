using System;
using System.Collections.Generic;
using System.Text;

namespace csharpPracticeFun
{
    class Support
    {
        //Method 1 --print board
        public void printBoard(string[,] board) //recieving array from Driver class
        {
            Console.WriteLine("\n   Board \n");

            //looping through coordinates from array passed in 
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {

                    //printing spaces between X's and O's
                    if(y == 2)
                    {
                        Console.Write(" " + board[x, y]);
                    }
                    else
                    {
                        Console.Write(" " + board[x, y] + " |");
                    }
                }

                //printing dividers for the middle rows
                if (x < 2)
                {
                    Console.WriteLine("\n---|---|---");
                }
                else
                {
                    Console.WriteLine("\n");
                }

            }

        }

        //Method 2 --find if there is a winner and who it was
        public void winnerCheck(string[,] board)
        {
            char v = '_'; //used in the if statements to check if the value in the array is "blank"

            //check if player won in row
            for (int x = 0; x <3; x++)
            {
                if ((board[x,0] == board[x,1]) && (board[x, 1] == board[x,2]) && (board[x,0] != (Convert.ToString(v)) ))
                {
                    if (board[x, 0] == "X") //checking which value matched which player to assign correct win credit
                    {
                        Console.WriteLine("Player X won the game! \n");
                    }
                    else
                    {
                        Console.WriteLine("Player O won the game! \n");
                    }
                    
                }
            }

            //check if player won in column
            for (int y = 0; y < 3; y++)
            {
                
                if ((board[0, y] == board[1, y]) && (board[1, y] == board[2, y]) && (board[0, y] != (Convert.ToString(v))))
                {
                    if (board[0, y] == "X") //checking which value matched which player to assign correct win credit
                    {
                        Console.WriteLine("Player X won the game! \n");
                    }
                    else
                    {
                        Console.WriteLine("Player O won the game! \n");
                    }
                    
                }
            }

            //check if player won in diagonal
            if ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]) && (board[0, 0] != (Convert.ToString(v))))
            {
                if (board[0, 0] == "X") //checking which value matched which player to assign correct win credit
                {
                    Console.WriteLine("Player X won the game! \n");
                }
                else
                {
                    Console.WriteLine("Player O won the game! \n");
                }
            }

            if ((board[0, 2] == board[1, 1]) && (board[1, 1] == board[2, 0]) && (board[0, 2] != (Convert.ToString(v))))
            {
                if (board[0, 2] == "X") //checking which value matched which player to assign correct win credit
                {
                    Console.WriteLine("Player X won the game! \n");
                }
                else
                {
                    Console.WriteLine("Player O won the game! \n");
                }
            }

        }
    }
}
