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
            Console.WriteLine("\n Board \n");

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

        //Method 2 --find winner
        public void winnerCheck(string[,] board)
        {

        }
    }
}
