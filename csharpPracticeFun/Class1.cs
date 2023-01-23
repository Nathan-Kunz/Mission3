using System;
using System.Collections.Generic;
using System.Text;

namespace csharpPracticeFun
{
    class Support
    {
        //Method 1 --print board
        public void gameBoard(string[] board) //recieving array from Driver class
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + board[i, j] + " |");
                }
            }
            Console.WriteLine(" Print Board ");
            Console.WriteLine(board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine(board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);

        }

        //Method 2 --find winner
        public void winnerCheck() 
        {

        }
}
